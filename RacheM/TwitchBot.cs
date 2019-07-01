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
            client.SendMessage(e.Channel, "Привет, я инвентарь-бот! Я умею показывать что у вас в инвентаре для это напишите !инвентарь <ник>");
        }

        private void Client_OnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            if (e.ChatMessage.Message.Contains("!инвентарь"))
            {
                string userName = e.ChatMessage.Message.Split(' ').Count() > 1 ? e.ChatMessage.Message.Split(' ')[1] : e.ChatMessage.Username;
                if (db.getUserByField(userName) != null)
                {
                    int count = 1;
                    string answer = $"Инвентарь пользователя {userName}: ";
                    foreach (PrizeItem i in db.getUserByField(userName).prizes)
                    {
                        answer += $"{count}. {i.Name} ";
                        count++;
                    }

                    if (answer == "")
                    {
                        client.SendWhisper(e.ChatMessage.Username, $"Инвентарь пользователя {userName} - пуст!");
                    } else
                    {
                        client.SendWhisper(e.ChatMessage.Username, answer);
                    }
                }
                else
                {
                    client.SendWhisper(userName, $"Пользователя {userName} нет в базе, возможно он еще не открывал кейсов");
                }
            }
        }
    }
}
