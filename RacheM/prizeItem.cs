using System;
using System.Drawing;

namespace RacheM
{
    public class PrizeItem
    {
        public int Id;
        public Image Image;
        public string Name;
        public int IsBad;
        public int Type;
        public DateTime? Date = null;
    }
}
