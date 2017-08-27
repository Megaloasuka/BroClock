namespace Broddsulan_Clock
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class ConsoleHint : Label
    {
        private string strCaption;

        public ConsoleHint()
        {
            this.BackColor = Color.White;
            base.Padding = new Padding(0, 0, 0, 0);
            base.Margin = new Padding(0, 0, 0, 0);
            base.Height = 20;
            this.Dock = DockStyle.Top;
            this.TextAlign = ContentAlignment.MiddleLeft;
            this.ForeColor = Config.ColorGray_N;
            this.Font = Config.FontPublish_S;
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
                this.Text = "- " + this.strCaption + " -";
            }
        }
    }
}

