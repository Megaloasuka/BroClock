namespace Broddsulan_Clock
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class AdvancedButton : Panel
    {
        private int intIndex;
        private Label lblCaption = new Label();
        private Label lblDeco = new Label();

        public AdvancedButton()
        {
            base.Padding = new Padding(0, 0, 0, 0);
            base.Margin = new Padding(0, 0, 0, 0);
            this.BackColor = Color.White;
            this.lblCaption.Dock = DockStyle.Fill;
            this.lblCaption.BackColor = Color.White;
            this.lblCaption.ForeColor = Config.ColorGray_D;
            this.lblCaption.Font = Config.FontPublish_M;
            this.lblCaption.TextAlign = ContentAlignment.TopCenter;
            this.lblCaption.MouseEnter += new EventHandler(this.Me_MouseEnter);
            this.lblCaption.MouseLeave += new EventHandler(this.Me_MouseLeave);
            this.lblCaption.MouseDown += new MouseEventHandler(this.Me_MouseDown);
            this.lblCaption.MouseUp += new MouseEventHandler(this.Me_MouseUp);
            base.Controls.Add(this.lblCaption);
            this.lblDeco.Height = 2;
            this.lblDeco.BackColor = Color.Transparent;
            this.lblDeco.Dock = DockStyle.Bottom;
            base.Controls.Add(this.lblDeco);
        }

        private void Me_MouseDown(object sender, EventArgs e)
        {
            this.lblCaption.Focus();
            this.lblDeco.BackColor = Config.ColorBase_L;
        }

        private void Me_MouseEnter(object sender, EventArgs e)
        {
            this.lblDeco.BackColor = Config.ColorBase_N;
        }

        private void Me_MouseLeave(object sender, EventArgs e)
        {
            this.lblDeco.BackColor = Color.Transparent;
        }

        private void Me_MouseUp(object sender, EventArgs e)
        {
            this.lblDeco.BackColor = Config.ColorBase_N;
        }

        public Label Button
        {
            get
            {
                return this.lblCaption;
            }
            set
            {
            }
        }

        public string Caption
        {
            get
            {
                return this.lblCaption.Text;
            }
            set
            {
                this.lblCaption.Text = value;
            }
        }

        public int Index
        {
            get
            {
                return this.intIndex;
            }
            set
            {
                this.intIndex = value;
            }
        }
    }
}

