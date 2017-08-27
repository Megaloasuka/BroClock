namespace Broddsulan_Clock
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class Ctrl_Description : UserControl
    {
        private bool bolIsFixed = false;
        private bool bolIsInitialized = false;
        private IContainer components;
        private Label lblSubTopic = new Label();
        private Label lblTopic = new Label();
        private Panel pnlContent = new Panel();

        public Ctrl_Description()
        {
            this.BackColor = Color.White;
            base.Padding = new Padding(0, 0, 0, 0);
            base.Resize += new EventHandler(this.Me_Resize);
            base.Controls.Add(this.pnlContent);
            this.lblTopic.BackColor = Color.Transparent;
            this.lblTopic.ForeColor = Config.ColorBase_N;
            this.lblTopic.Font = Config.FontDisplay_L;
            this.lblTopic.TextAlign = ContentAlignment.BottomLeft;
            this.lblTopic.Text = "This is Topic.";
            this.lblTopic.AutoSize = true;
            this.lblTopic.Dock = DockStyle.Top;
            this.pnlContent.Controls.Add(this.lblTopic);
            this.lblSubTopic.BackColor = Color.Transparent;
            this.lblSubTopic.ForeColor = Config.ColorGray_N;
            this.lblSubTopic.Font = Config.FontDisplay_S;
            this.lblSubTopic.TextAlign = ContentAlignment.TopLeft;
            this.lblSubTopic.Text = "This is Sub-Topic.";
            this.lblSubTopic.AutoSize = true;
            this.lblSubTopic.Dock = DockStyle.Bottom;
            this.pnlContent.Controls.Add(this.lblSubTopic);
            base.Height = 220;
            base.Width = Conversions.ToInteger(Interaction.IIf(this.lblTopic.Width >= this.lblSubTopic.Width, this.lblTopic.Width, this.lblSubTopic.Width));
            this.pnlContent.Height = this.lblTopic.Height + this.lblSubTopic.Height;
            this.pnlContent.Width = Conversions.ToInteger(Interaction.IIf(this.lblTopic.Width >= this.lblSubTopic.Width, this.lblTopic.Width, this.lblSubTopic.Width));
            this.pnlContent.Location = new Point((int) Math.Round((double) (((double) (base.Width - this.pnlContent.Width)) / 2.0)), (int) Math.Round((double) (((double) (base.Height - this.pnlContent.Height)) / 2.0)));
            this.bolIsInitialized = true;
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && (this.components > null))
                {
                    this.components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            base.AutoScaleMode = AutoScaleMode.Font;
        }

        private void Me_Resize(object sender, EventArgs e)
        {
            if (this.bolIsInitialized)
            {
                if (!this.bolIsFixed)
                {
                    this.lblTopic.Font = Config.FontSlide_L;
                    this.lblSubTopic.Font = Config.FontSlide_S;
                    base.Height = 220;
                    base.Width = Conversions.ToInteger(Interaction.IIf(this.lblTopic.Width >= this.lblSubTopic.Width, this.lblTopic.Width, this.lblSubTopic.Width));
                    this.pnlContent.Height = this.lblTopic.Height + this.lblSubTopic.Height;
                    this.pnlContent.Width = Conversions.ToInteger(Interaction.IIf(this.lblTopic.Width >= this.lblSubTopic.Width, this.lblTopic.Width, this.lblSubTopic.Width));
                    this.pnlContent.Location = new Point((int) Math.Round((double) (((double) (base.Width - this.pnlContent.Width)) / 2.0)), (int) Math.Round((double) (((double) (base.Height - this.pnlContent.Height)) / 2.0)));
                }
                else
                {
                    this.lblTopic.Font = Config.FontDisplay_L;
                    this.lblSubTopic.Font = Config.FontDisplay_M;
                    base.Height = this.lblTopic.Height + this.lblSubTopic.Height;
                    base.Width = 240;
                    this.pnlContent.Height = this.lblTopic.Height + this.lblSubTopic.Height;
                    this.pnlContent.Width = 240;
                    this.pnlContent.Location = new Point((int) Math.Round((double) (((double) (base.Width - this.pnlContent.Width)) / 2.0)), (int) Math.Round((double) (((double) (base.Height - this.pnlContent.Height)) / 2.0)));
                }
            }
        }

        public bool IsFixed
        {
            get
            {
                return this.bolIsFixed;
            }
            set
            {
                this.bolIsFixed = value;
            }
        }

        public string SubTitle
        {
            get
            {
                return this.lblSubTopic.Text;
            }
            set
            {
                this.lblSubTopic.Text = value;
            }
        }

        public string Title
        {
            get
            {
                return this.lblTopic.Text;
            }
            set
            {
                this.lblTopic.Text = value;
            }
        }
    }
}

