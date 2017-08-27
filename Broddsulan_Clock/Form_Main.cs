namespace Broddsulan_Clock
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class Form_Main : Form
    {
        private bool bolIsInitialized;
        private IContainer components;
        private SidebarButton[] lbl_Temp;
        private Page_Timer pnlTimer;
        private TableLayoutPanel tlpDelList_Temp;

        public Form_Main()
        {
            base.Load += new EventHandler(this.frmMain_Load);
            base.Resize += new EventHandler(this.frmMain_Resize);
            this.pnlTimer = new Page_Timer();
            this.bolIsInitialized = false;
            this.tlpDelList_Temp = new TableLayoutPanel();
            this.lbl_Temp = new SidebarButton[11];
            this.InitializeComponent();
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            base.Size = new Size(0x11b, 430);
            this.MinimumSize = new Size(0x11b, 430);
            base.FormBorderStyle = FormBorderStyle.Sizable;
            this.BackColor = Color.White;
            base.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.pnlTimer.Dock = DockStyle.Fill;
            base.Controls.Add(this.pnlTimer);
            this.pnlTimer.BringToFront();
            this.bolIsInitialized = true;
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (this.bolIsInitialized)
            {
            }
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            base.SuspendLayout();
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(230, 0xcd);
            base.Name = "frmMain";
            this.Text = "MUNCS Lite";
            base.ResumeLayout(false);
        }

        public void Temp()
        {
            base.Controls.Add(this.tlpDelList_Temp);
            this.tlpDelList_Temp.Visible = false;
            TableLayoutPanel panel = this.tlpDelList_Temp;
            panel.ColumnStyles.Clear();
            panel.RowStyles.Clear();
            panel.Size = new Size(150, 300);
            panel.Location = new Point(200, 100);
            panel.AutoScroll = true;
            panel.ColumnCount = 1;
            panel.BackColor = Config.ColorBase_N;
            panel = null;
            int index = 0;
            do
            {
                this.lbl_Temp[index] = new SidebarButton();
                this.tlpDelList_Temp.Controls.Add(this.lbl_Temp[index]);
                this.lbl_Temp[index].Size = new Size(120, 40);
                this.lbl_Temp[index].BackColor = Color.Tomato;
                index++;
            }
            while (index <= 10);
        }
    }
}

