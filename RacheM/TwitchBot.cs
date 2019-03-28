using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitchLib.Client;
using TwitchLib.Client.Enums;
using TwitchLib.Client.Events;
using TwitchLib.Client.Extensions;
using TwitchLib.Client.Models;


namespace RacheM
{
    public class TwitchBot
    {
        ConnectionCredentials conCr;
        TwitchClient client;
        TwitchSettings settings;
        public TwitchBot(TwitchSettings settings)
        {
            this.settings = settings;
            conCr = new ConnectionCredentials(settings.botUsername, settings.botToken);
        }

        public void connect()
        {
            client = new TwitchClient();
            client.Initialize(conCr, settings.channelName);
            client.OnMessageReceived += Client_OnMessageReceived;
            client.OnJoinedChannel += Client_OnJoinedChannel;
            client.Connect();
        }

        private void Client_OnJoinedChannel(object sender, OnJoinedChannelArgs e)
        {
            client.SendMessage(e.Channel, "Привет, я тестирую бота для твича");
        }

        private void Client_OnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            if (e.ChatMessage.Message.Contains("!инвентарь"))
            {
                if (db.getUserByField(e.ChatMessage.Username) != null)
                {
                    int count = 1;
                    foreach (PrizeItem i in db.getUserByField(e.ChatMessage.Username).prizes)
                    {
                        client.SendWhisper(e.ChatMessage.Username, $"{count}. {i.Name}");
                        count++;
                    }
                }
                else
                {
                    client.SendWhisper(e.ChatMessage.Username, "Вы еще не открывали ни одного кейса");
                }
            }
        }
    }
}
