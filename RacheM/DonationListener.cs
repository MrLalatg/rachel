using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RacheM
{
    public class DonationListener
    {
        private string addUserTemplate = "69:42[\"add-user\",{{\"token\":\"{0}\",\"type\":\"alert_widget\"}}]";


        public Action<JObject> OnDonation = null;
        private readonly string _token;

        public DonationListener(string token)
        {
            _token = token;
        }

        public void DoListen()
        {
            var result =
                DoRequest("GET", "https://socket.donationalerts.ru/socket.io/?EIO=3&transport=polling"); //&t=MYotE0N
            var sid = ExtractToken(result);
            if (string.IsNullOrEmpty(sid))
            {
                throw new Exception("Failed to get sid");
            }

            var cookie = new Cookie("io", sid, "/", "socket.donationalerts.ru");
            DoRequest(
                "POST",
                $"https://socket.donationalerts.ru/socket.io/?EIO=3&transport=polling&sid={sid}",
                string.Format(addUserTemplate, _token),
                cookie
            );

            var waiter = DoWebSocket($"wss://socket.donationalerts.ru/socket.io/?EIO=3&transport=websocket&sid={sid}",
                cookie);
            waiter.GetAwaiter().GetResult();
        }


        private static string ExtractToken(string strWidthToken)
        {
            var m = Regex.Match(strWidthToken, "\"sid\":\"(?<token>[^\"]+)\"");
            return m.Groups["token"].Value;
        }

        private static string DoRequest(string method, string url, string data = "", Cookie cookie = null)
        {
            var httpWebRequest = (HttpWebRequest) WebRequest.Create(url);

            httpWebRequest.Method = method;
            httpWebRequest.Accept = "*/*";
            httpWebRequest.Headers.Add("Origin", "https://www.donationalerts.com");
            httpWebRequest.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip, deflate, br");
            httpWebRequest.Headers.Add(HttpRequestHeader.AcceptLanguage, "en-US,en;q=0.9");
            httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.2; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.84 Safari/537.36";

            httpWebRequest.Referer = "https://www.donationalerts.com/widget/alerts?group_id=1&token=mcq71m8KVIsojvo5ukFZ";
            if (method == "GET")
            {
                //httpWebRequest.Headers.Remove("Content-Length");
                httpWebRequest.ContentLength = 0;
            }
            else
            {
                httpWebRequest.ContentType = "text/plain;charset=UTF-8";
            }

            if (cookie != null)
            {
                if (httpWebRequest.CookieContainer == null)
                {
                    httpWebRequest.CookieContainer = new CookieContainer();
                }

                httpWebRequest.CookieContainer.Add(cookie);
            }

            if (method == "POST" && !string.IsNullOrEmpty(data))
            {
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(data);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }

            var httpResponse = (HttpWebResponse) httpWebRequest.GetResponse();

            var streamReader = new StreamReader(httpResponse.GetResponseStream());

            if(streamReader == null)
            {
                throw new Exception("Connection error");
            }

            using (streamReader)
            {
                return streamReader.ReadToEnd();
            }
        }
        
        private  async Task DoWebSocket(string url, Cookie cookie)
        {
            using (var ws = new ClientWebSocket())
            {
                var serverUri = new Uri(url);
                ws.Options.Cookies = new CookieContainer();
                ws.Options.Cookies.Add(cookie);
                await ws.ConnectAsync(serverUri, CancellationToken.None);
                var cts = new CancellationTokenSource();
                
                Task.Factory.StartNew(
                    async () =>
                    {
                        while (true)
                        {
                            try
                            {
                                string srcMessage = string.Empty;
                                ArraySegment<Byte> buffer = new ArraySegment<byte>(new Byte[8192]);

                                using (var ms = new MemoryStream())
                                {
                                    WebSocketReceiveResult result= null;
                                    do
                                    {
                                        result = await ws.ReceiveAsync(buffer, CancellationToken.None);
                                        ms.Write(buffer.Array, buffer.Offset, result.Count);
                                    } while (!result.EndOfMessage);
                                    
                                    ms.Seek(0, SeekOrigin.Begin);
                                    if (result.MessageType == WebSocketMessageType.Text)
                                    {
                                        using (var reader = new StreamReader(ms, Encoding.UTF8))
                                        {
                                            srcMessage = reader.ReadToEnd();
                                        }
                                    }
                                }

                                if (string.IsNullOrEmpty(srcMessage)) continue;
                                
                                
                                if (srcMessage.IndexOf("42[\"donation", StringComparison.Ordinal) == 0)
                                {
                                    OnDonation?.Invoke(ParseDonateMessage(srcMessage));
                                }
                                else
                                {
                                    Console.WriteLine("no donate msg: " + srcMessage);
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error: " + ex.Message);
                            }
                        }
                    }, cts.Token, TaskCreationOptions.LongRunning, TaskScheduler.Default);

                await SendWsMessage(ws, "2probe");
                await SendWsMessage(ws, "5");
                while (ws.State == WebSocketState.Open)
                {
                    await SendWsMessage(ws, "2");
                    Thread.Sleep(25000);
                }
            }
        }
        
        private static async Task SendWsMessage(WebSocket ws, string message)
        {
            var sendBytes = Encoding.UTF8.GetBytes(message);
            var cts = new CancellationTokenSource();
            var sendBuffer = new ArraySegment<byte>(sendBytes);
            await
                ws.SendAsync(sendBuffer, WebSocketMessageType.Text, endOfMessage: true,
                    cancellationToken: cts.Token);
        }

        private static JObject ParseDonateMessage(string rcvMsg)
        {
            rcvMsg = rcvMsg.Replace("42[\"donation\",\"", "");
            rcvMsg = rcvMsg.Substring(0, rcvMsg.Length - 2);
            return (JObject)JsonConvert.DeserializeObject(Regex.Unescape(rcvMsg));
        }
    }
}