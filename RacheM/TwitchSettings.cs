using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacheM
{
    public class TwitchSettings
    {
        public string password;
        public string channelName;
        public string botUsername;
        public string botToken;
        public string clientId;

        public TwitchSettings(string pass = "", string chNm = "", string botUsrnm = "", string botTok = "", string clId = "")
        {
            this.password = pass;
            this.channelName = chNm;
            this.botUsername = botUsrnm;
            this.botToken = botTok;
            this.clientId = clId;
        }
    }
}
