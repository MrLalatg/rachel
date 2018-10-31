using System;
using System.Windows.Forms;

namespace RacheM
{
    public class myBtn : System.Windows.Forms.Button
    {
        public myBtn() : base()
        {
            
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            base.OnPaintBackground(pevent);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20;
                return cp;
            }
        }

    }
}
