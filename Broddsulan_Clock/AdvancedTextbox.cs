namespace Broddsulan_Clock
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class AdvancedTextbox : Panel
    {
        private Label lblDeco = new Label();
        private string strDefaultText;
        private TextBox txtContent = new TextBox();

        public AdvancedTextbox()
        {
            base.Padding = new Padding(0, 0, 0, 0);
            base.Margin = new Padding(0, 0, 0, 0);
            this.BackColor = Color.White;
            this.txtContent.BackColor = Color.White;
            this.txtContent.BorderStyle = BorderStyle.None;
            this.txtContent.ForeColor = Config.ColorGray_D;
            this.txtContent.Font = Config.FontPublish_M;
            this.txtContent.TextAlign = HorizontalAlignment.Left;
            this.txtContent.Dock = DockStyle.Top;
            base.Controls.Add(this.txtContent);
            this.txtContent.MouseEnter += new EventHandler(this.Textbox_MouseEnter);
            this.txtContent.MouseLeave += new EventHandler(this.Textbox_MouseLeave);
            this.txtContent.GotFocus += new EventHandler(this.Textbox_Focus);
            this.txtContent.LostFocus += new EventHandler(this.Textbox_LoseFocus);
            this.lblDeco.Height = 2;
            this.lblDeco.BackColor = Color.Transparent;
            this.lblDeco.Dock = DockStyle.Bottom;
            base.Controls.Add(this.lblDeco);
        }

        private void Textbox_Focus(object sender, EventArgs e)
        {
            if (this.txtContent.Text == ("[ " + this.strDefaultText + " ]"))
            {
                this.txtContent.Text = "";
            }
            this.lblDeco.BackColor = Config.ColorBase_N;
        }

        private void Textbox_LoseFocus(object sender, EventArgs e)
        {
            if (this.txtContent.Text == "")
            {
                this.txtContent.Text = "[ " + this.strDefaultText + " ]";
            }
            this.lblDeco.BackColor = Color.Transparent;
        }

        private void Textbox_MouseEnter(object sender, EventArgs e)
        {
            this.txtContent.BackColor = Config.ColorGray_XL;
        }

        private void Textbox_MouseLeave(object sender, EventArgs e)
        {
            this.txtContent.BackColor = Color.White;
        }

        public string DefaultText
        {
            get
            {
                return this.strDefaultText;
            }
            set
            {
                this.strDefaultText = value;
                if (this.txtContent.Text == "")
                {
                    this.txtContent.Text = "[ " + this.strDefaultText + " ]";
                }
            }
        }

        public TextBox Textbox
        {
            get
            {
                return this.txtContent;
            }
            set
            {
            }
        }
    }
}

