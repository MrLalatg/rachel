using System.Collections.Generic;

namespace RacheM
{
    public class User
    {
        public int Id;
        public string Name;
        public List<PrizeItem> prizes = new List<PrizeItem>();
    }
}
