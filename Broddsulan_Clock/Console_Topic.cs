namespace Broddsulan_Clock
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class Console_Topic : UserControl
    {
        private AdvancedButton btnConfirm = new AdvancedButton();
        private IContainer components;
        private ConsoleHint lblHint = new ConsoleHint();
        private ConsoleTitle lblTitle = new ConsoleTitle();
        private Panel pnlLayout = new Panel();
        private ConsoleLayOut tlpLayOut = new ConsoleLayOut();
        private AdvancedTextbox txtSubTopic = new AdvancedTextbox();
        private AdvancedTextbox txtTopic = new AdvancedTextbox();

        public Console_Topic()
        {
            this.InitializeComponent();
            base.Padding = new Padding(0, 0, 0, 0);
            this.BackColor = Color.Transparent;
            base.Size = new Size(160, 100);
            this.MinimumSize = new Size(160, 100);
            base.Resize += new EventHandler(this.Me_Resize);
            base.Controls.Add(this.tlpLayOut);
            this.tlpLayOut.Padding = new Padding(0, 0, 0, 0);
            this.lblTitle.Caption = "Description";
            this.tlpLayOut.Controls.Add(this.lblTitle);
            this.lblHint.Caption = "Input";
            this.tlpLayOut.Controls.Add(this.lblHint);
            this.txtTopic.Size = new Size(this.tlpLayOut.Width, 0x19);
            this.txtTopic.Location = new Point(0, 0);
            this.txtTopic.DefaultText = "Topic";
            this.tlpLayOut.Controls.Add(this.txtTopic);
            this.pnlLayout.BackColor = Color.Transparent;
            this.pnlLayout.Size = new Size(50, 0x19);
            this.pnlLayout.Dock = DockStyle.Top;
            this.pnlLayout.Margin = new Padding(0, 0, 0, 0);
            this.tlpLayOut.Controls.Add(this.pnlLayout);
            this.txtSubTopic.Size = new Size((int) Math.Round((double) ((((double) (this.pnlLayout.Width * 3)) / 4.0) - 2.0)), this.pnlLayout.Height);
            this.txtSubTopic.Location = new Point(0, 0);
            this.txtSubTopic.DefaultText = "Sub-Topic";
            this.pnlLayout.Controls.Add(this.txtSubTopic);
            this.btnConfirm.Size = new Size((int) Math.Round((double) (((double) this.pnlLayout.Width) / 4.0)), this.pnlLayout.Height);
            this.btnConfirm.Location = new Point((int) Math.Round((double) (((double) (this.pnlLayout.Width * 3)) / 4.0)), 0);
            this.btnConfirm.Caption = "OK";
            this.pnlLayout.Controls.Add(this.btnConfirm);
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
            this.txtTopic.Size = new Size(this.tlpLayOut.Width, 0x19);
            this.txtSubTopic.Size = new Size((int) Math.Round((double) ((((double) (this.pnlLayout.Width * 3)) / 4.0) - 2.0)), this.pnlLayout.Height);
            this.btnConfirm.Size = new Size((int) Math.Round((double) (((double) this.pnlLayout.Width) / 4.0)), this.pnlLayout.Height);
            this.btnConfirm.Location = new Point((int) Math.Round((double) (((double) (this.pnlLayout.Width * 3)) / 4.0)), 0);
        }

        public AdvancedButton OKButton
        {
            get
            {
                return this.btnConfirm;
            }
            set
            {
            }
        }

        public AdvancedTextbox SubTopicTextbox
        {
            get
            {
                return this.txtSubTopic;
            }
            set
            {
            }
        }

        public AdvancedTextbox TopicTextbox
        {
            get
            {
                return this.txtTopic;
            }
            set
            {
            }
        }
    }
}

