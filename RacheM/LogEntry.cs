using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacheM
{
    class LogEntry
    {
        public User user;
        public PrizeItem prize;

        public LogEntry(User in_user, PrizeItem in_prize)
        {
            this.user = in_user;
            this.prize = in_prize;
        }
    }
}
