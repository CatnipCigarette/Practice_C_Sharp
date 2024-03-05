using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public partial class ClickButton : Button
    {
        public ClickButton()
        {
            InitializeComponent();
        }

        public ClickButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private int mClicks;

        public int Clicks
        {
            get { return mClicks; }
        }

        protected override void OnClick(EventArgs e)
        {
            mClicks++;
            base.OnClick(e);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;
            SizeF stringsize;
            stringsize = g.MeasureString(Clicks.ToString(), this.Font, this.Width);
            g.DrawString(Clicks.ToString(), this.Font, SystemBrushes.ControlText, this.Width - stringsize.Width - 3, this.Height - stringsize.Height - 3);
        }
        
    }
}

