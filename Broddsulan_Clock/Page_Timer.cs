namespace Broddsulan_Clock
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class Page_Timer : UserControl
    {
        private bool bolIsInitialized;
        private IContainer components;
        private FlowLayoutPanel flpControl;
        private FlowLayoutPanel flpDisplay;
        private Panel pnlTimer;
        private Console_Timer pnlTimerConsole;
        private Ctrl_Timer tmrTimer;

        public Page_Timer()
        {
            base.Resize += new EventHandler(this.Me_Resize);
            this.flpDisplay = new FlowLayoutPanel();
            this.pnlTimer = new Panel();
            this.tmrTimer = new Ctrl_Timer();
            this.flpControl = new FlowLayoutPanel();
            this.pnlTimerConsole = new Console_Timer();
            this.bolIsInitialized = false;
            this.InitializeComponent();
            base.Padding = new Padding(0, 0, 0, 0);
            this.BackColor = Color.White;
            this.flpDisplay.Padding = new Padding(10, 2, 10, 2);
            this.flpDisplay.Height = 250;
            this.flpDisplay.Dock = DockStyle.Top;
            this.flpDisplay.BackColor = Color.White;
            base.Controls.Add(this.flpDisplay);
            this.tmrTimer.Location = new Point((int) Math.Round((double) (((double) (this.pnlTimer.Width - this.tmrTimer.Width)) / 2.0)), (int) Math.Round((double) (((double) (this.pnlTimer.Height - this.tmrTimer.Height)) / 2.0)));
            this.pnlTimer.Controls.Add(this.tmrTimer);
            this.pnlTimer.Size = new Size(240, 250);
            this.pnlTimer.BackColor = Color.Transparent;
            this.flpDisplay.Controls.Add(this.pnlTimer);
            this.flpControl.Padding = new Padding(0x19, 10, 10, 10);
            this.flpControl.Dock = DockStyle.Bottom;
            this.flpControl.Height = 150;
            base.Controls.Add(this.flpControl);
            int num = 0;
            do
            {
                this.pnlTimerConsole.get_TimeButton(num).Button.MouseUp += new MouseEventHandler(this.Console_Timer_QuickBoot_Click);
                num++;
            }
            while (num <= 3);
            this.pnlTimerConsole.ConfirmButton.Button.MouseUp += new MouseEventHandler(this.Console_Timer_OKButton_Click);
            this.flpControl.Controls.Add(this.pnlTimerConsole);
            this.bolIsInitialized = true;
        }

        private void Console_Timer_OKButton_Click(object sender, EventArgs e)
        {
            this.tmrTimer.SetTime(this.pnlTimerConsole.TotalTimeTextbox.Textbox.Text, this.pnlTimerConsole.TimeTextbox.Textbox.Text);
        }

        private void Console_Timer_QuickBoot_Click(object sender, EventArgs e)
        {
            this.tmrTimer.SetTime(Conversions.ToString(0), Conversions.ToString(Operators.MultiplyObject(Operators.AddObject(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "Parent", new object[0], null, null, null), null, "Index", new object[0], null, null, null), 1), 30)));
        }

        private void Console_Topic_OKButton_Click(object sender, EventArgs e)
        {
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
                this.tmrTimer.Location = new Point((int) Math.Round((double) (((double) (this.pnlTimer.Width - this.tmrTimer.Width)) / 2.0)), (int) Math.Round((double) (((double) (this.pnlTimer.Height - this.tmrTimer.Height)) / 2.0)));
            }
        }
    }
}

