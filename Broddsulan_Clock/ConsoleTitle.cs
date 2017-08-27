namespace Broddsulan_Clock
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class ConsoleTitle : Label
    {
        private string strCaption;

        public ConsoleTitle()
        {
            this.BackColor = Color.Transparent;
            base.Padding = new Padding(0, 0, 0, 0);
            base.Margin = new Padding(0, 0, 0, 0);
            base.Height = 30;
            this.Dock = DockStyle.Top;
            this.ForeColor = Config.ColorBase_D;
            this.Font = Config.FontPublish_L;
            this.TextAlign = ContentAlignment.MiddleLeft;
        }

        public string Caption
        {
            get
            {
                return this.strCaption;
            }
            set
            {
                this.strCaption = value;
                this.Text = "| " + this.strCaption;
            }
        }
    }
}

