namespace Broddsulan_Clock
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class SidebarButton : UserControl
    {
        private bool bolIsInitialized;
        private IContainer components;
        private int intIndex;
        private Label lblCaption;
        private PictureBox picIcon;
        private string strTarget;

        public SidebarButton()
        {
            base.Resize += new EventHandler(this.Me_Resize);
            this.picIcon = new PictureBox();
            this.lblCaption = new Label();
            this.bolIsInitialized = false;
            this.InitializeComponent();
            this.BackColor = Color.Transparent;
            base.Margin = new Padding(0, 0, 0, 0);
            this.picIcon.BackgroundImage = this.Icon;
            this.picIcon.Name = "picIcon";
            this.picIcon.BackgroundImageLayout = ImageLayout.Zoom;
            this.picIcon.Size = new Size(base.Height - 20, base.Height - 20);
            this.picIcon.Location = new Point(10, 10);
            this.picIcon.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            base.Controls.Add(this.picIcon);
            this.lblCaption.Text = this.Caption;
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Font = Config.FontPublish_M;
            this.lblCaption.BackColor = Color.Transparent;
            this.lblCaption.ForeColor = Color.White;
            this.lblCaption.AutoSize = true;
            base.Controls.Add(this.lblCaption);
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
            base.SuspendLayout();
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.Name = "SidebarButton";
            base.Size = new Size(0x8e, 0x83);
            base.ResumeLayout(false);
        }

        private void Me_Resize(object sender, EventArgs e)
        {
            if (this.bolIsInitialized)
            {
                this.picIcon.Width = this.picIcon.Height;
                this.picIcon.Left = 10;
                this.lblCaption.Top = (int) Math.Round((double) (this.picIcon.Top + (((double) (this.picIcon.Height - this.lblCaption.Height)) / 2.0)));
                this.lblCaption.Left = this.picIcon.Right + 8;
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

        public Bitmap Icon
        {
            get
            {
                return (Bitmap) this.picIcon.BackgroundImage;
            }
            set
            {
                this.picIcon.BackgroundImage = value;
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

        public Label LabelCaption
        {
            get
            {
                return this.lblCaption;
            }
            set
            {
            }
        }

        public PictureBox PictureBoxIcon
        {
            get
            {
                return this.picIcon;
            }
            set
            {
            }
        }

        public string Target
        {
            get
            {
                return this.strTarget;
            }
            set
            {
                this.strTarget = value;
            }
        }
    }
}

