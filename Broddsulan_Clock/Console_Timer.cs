namespace Broddsulan_Clock
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class Console_Timer : UserControl
    {
        private AdvancedButton btnConfirm = new AdvancedButton();
        private AdvancedButton[] btnQuickBoot = new AdvancedButton[4];
        private IContainer components;
        private ConsoleHint[] lblHint = new ConsoleHint[2];
        private ConsoleTitle lblTitle = new ConsoleTitle();
        private Panel[] pnlLayOut = new Panel[2];
        private ConsoleLayOut tlpLayOut = new ConsoleLayOut();
        private AdvancedTextbox txtTime = new AdvancedTextbox();
        private AdvancedTextbox txtTotalTime = new AdvancedTextbox();

        public Console_Timer()
        {
            this.InitializeComponent();
            base.Padding = new Padding(0, 0, 0, 0);
            this.BackColor = Color.White;
            base.Size = new Size(160, 120);
            this.MinimumSize = new Size(160, 120);
            base.Resize += new EventHandler(this.Me_Resize);
            base.Controls.Add(this.tlpLayOut);
            this.lblTitle.Caption = "Setup Timer";
            this.tlpLayOut.Controls.Add(this.lblTitle);
            this.lblHint[0] = new ConsoleHint();
            this.lblHint[0].Caption = "Click";
            this.tlpLayOut.Controls.Add(this.lblHint[0]);
            this.pnlLayOut[0] = new Panel();
            this.pnlLayOut[0].Size = new Size(50, 0x19);
            this.pnlLayOut[0].Margin = new Padding(0, 0, 0, 0);
            this.pnlLayOut[0].Dock = DockStyle.Top;
            this.tlpLayOut.Controls.Add(this.pnlLayOut[0]);
            int index = 0;
            do
            {
                this.btnQuickBoot[index] = new AdvancedButton();
                this.btnQuickBoot[index].Size = new Size((int) Math.Round((double) (((double) this.pnlLayOut[0].Width) / 4.0)), this.pnlLayOut[0].Height);
                this.btnQuickBoot[index].Location = new Point(this.btnQuickBoot[0].Width * index, 0);
                this.btnQuickBoot[index].Caption = ((index + 1) * 30).ToString();
                this.btnQuickBoot[index].Index = index;
                this.pnlLayOut[0].Controls.Add(this.btnQuickBoot[index]);
                index++;
            }
            while (index <= 3);
            this.lblHint[1] = new ConsoleHint();
            this.lblHint[1].Caption = "Or Input";
            this.tlpLayOut.Controls.Add(this.lblHint[1]);
            this.pnlLayOut[1] = new Panel();
            this.pnlLayOut[1].Size = new Size(50, 0x19);
            this.pnlLayOut[1].Dock = DockStyle.Top;
            this.pnlLayOut[1].Margin = new Padding(0, 0, 0, 0);
            this.tlpLayOut.Controls.Add(this.pnlLayOut[1]);
            this.txtTotalTime.Size = new Size((int) Math.Round((double) ((((double) (this.pnlLayOut[1].Width * 3)) / 8.0) - 2.0)), this.pnlLayOut[1].Height);
            this.txtTotalTime.Location = new Point(0, 0);
            this.txtTotalTime.DefaultText = "Total";
            this.pnlLayOut[1].Controls.Add(this.txtTotalTime);
            this.txtTime.Size = new Size((int) Math.Round((double) ((((double) (this.pnlLayOut[1].Width * 3)) / 8.0) - 2.0)), this.pnlLayOut[1].Height);
            this.txtTime.Location = new Point((int) Math.Round((double) (((double) (this.pnlLayOut[1].Width * 3)) / 8.0)), 0);
            this.txtTime.DefaultText = "Single";
            this.pnlLayOut[1].Controls.Add(this.txtTime);
            this.btnConfirm.Size = new Size((int) Math.Round((double) (((double) (this.pnlLayOut[1].Width * 2)) / 8.0)), this.pnlLayOut[1].Height);
            this.btnConfirm.Location = new Point((int) Math.Round((double) (((double) (this.pnlLayOut[1].Width * 3)) / 4.0)), 0);
            this.btnConfirm.Caption = "OK";
            this.pnlLayOut[1].Controls.Add(this.btnConfirm);
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
            int index = 0;
            do
            {
                this.btnQuickBoot[index].Size = new Size((int) Math.Round((double) (((double) this.pnlLayOut[0].Width) / 4.0)), this.pnlLayOut[0].Height);
                this.btnQuickBoot[index].Location = new Point(this.btnQuickBoot[0].Width * index, 0);
                index++;
            }
            while (index <= 3);
            this.txtTotalTime.Size = new Size((int) Math.Round((double) ((((double) (this.pnlLayOut[1].Width * 3)) / 8.0) - 2.0)), this.pnlLayOut[1].Height);
            this.txtTime.Size = new Size((int) Math.Round((double) ((((double) (this.pnlLayOut[1].Width * 3)) / 8.0) - 2.0)), this.pnlLayOut[1].Height);
            this.txtTime.Location = new Point((int) Math.Round((double) (((double) (this.pnlLayOut[1].Width * 3)) / 8.0)), 0);
            this.btnConfirm.Size = new Size((int) Math.Round((double) (((double) (this.pnlLayOut[1].Width * 2)) / 8.0)), this.pnlLayOut[1].Height);
            this.btnConfirm.Location = new Point((int) Math.Round((double) (((double) (this.pnlLayOut[1].Width * 3)) / 4.0)), 0);
        }

        public AdvancedButton ConfirmButton
        {
            get
            {
                return this.btnConfirm;
            }
            set
            {
            }
        }

        public AdvancedButton this[int num]
        {
            get
            {
                return this.btnQuickBoot[num];
            }
            set
            {
            }
        }

        public AdvancedTextbox TimeTextbox
        {
            get
            {
                return this.txtTime;
            }
            set
            {
            }
        }

        public AdvancedTextbox TotalTimeTextbox
        {
            get
            {
                return this.txtTotalTime;
            }
            set
            {
            }
        }
    }
}

