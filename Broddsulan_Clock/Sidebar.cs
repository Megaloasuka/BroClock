namespace Broddsulan_Clock
{
    using Microsoft.VisualBasic.CompilerServices;
    using MUNCS_Lite.My.Resources;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class Sidebar : UserControl
    {
        private bool bolIsInitialized;
        private SidebarButton[] btnOption;
        private IContainer components;
        private int intSelected;
        private TableLayoutPanel tlpMainOption;

        public Sidebar()
        {
            base.Resize += new EventHandler(this.Me_Resize);
            this.btnOption = new SidebarButton[6];
            this.tlpMainOption = new TableLayoutPanel();
            this.intSelected = -1;
            this.bolIsInitialized = false;
            this.InitializeComponent();
            this.BackColor = Config.ColorBase_N;
            base.Width = 150;
            base.Padding = new Padding(0, 0, 0, 0);
            this.tlpMainOption.ColumnStyles.Clear();
            this.tlpMainOption.RowStyles.Clear();
            this.tlpMainOption.BackColor = Config.ColorBase_N;
            this.tlpMainOption.Size = new Size(base.Width, 240);
            this.tlpMainOption.MinimumSize = new Size(40, 240);
            this.tlpMainOption.Location = new Point(0, 0);
            this.tlpMainOption.ColumnCount = 1;
            this.tlpMainOption.AutoScroll = false;
            this.tlpMainOption.BorderStyle = BorderStyle.None;
            base.Controls.Add(this.tlpMainOption);
            Bitmap[] bitmapArray = new Bitmap[] { MUNCS_Lite.My.Resources.Resources.location, MUNCS_Lite.My.Resources.Resources.bubble, MUNCS_Lite.My.Resources.Resources.bulb, MUNCS_Lite.My.Resources.Resources.calendar, MUNCS_Lite.My.Resources.Resources.clock, MUNCS_Lite.My.Resources.Resources.news };
            string[] strArray = new string[] { "Roll Call", "Speakers List", "Motion", "Vote", "Timer", "Record" };
            string[] strArray2 = new string[] { "Roll Call", "Speakers List", "Motion", "Vote", "Timer", "Record" };
            int index = 0;
            do
            {
                this.btnOption[index] = new SidebarButton();
                this.btnOption[index].Size = new Size(this.tlpMainOption.Width, 40);
                this.btnOption[index].Index = index;
                this.btnOption[index].Target = strArray2[index];
                this.btnOption[index].Icon = bitmapArray[index];
                this.btnOption[index].Caption = strArray[index];
                this.btnOption[index].MouseEnter += new EventHandler(this.btnOption_MouseEnter);
                this.btnOption[index].MouseLeave += new EventHandler(this.btnOption_MouseLeave);
                this.btnOption[index].MouseClick += new MouseEventHandler(this.btnOption_MouseClick);
                this.btnOption[index].LabelCaption.MouseClick += new MouseEventHandler(this.btnOption_MouseClick);
                this.btnOption[index].PictureBoxIcon.MouseClick += new MouseEventHandler(this.btnOption_MouseClick);
                this.tlpMainOption.Controls.Add(this.btnOption[index]);
                index++;
            }
            while (index <= 5);
            this.bolIsInitialized = true;
        }

        private void btnOption_MouseClick(object sender, EventArgs e)
        {
            int index = 0;
            do
            {
                this.btnOption[index].BackColor = Config.ColorBase_N;
                index++;
            }
            while (index <= 5);
            if ((NewLateBinding.LateGet(sender, null, "Name", new object[0], null, null, null).ToString() == "lblCaption") | (NewLateBinding.LateGet(sender, null, "Name", new object[0], null, null, null).ToString() == "picIcon"))
            {
                object[] arguments = new object[] { Config.ColorBase_D };
                NewLateBinding.LateSetComplex(NewLateBinding.LateGet(sender, null, "Parent", new object[0], null, null, null), null, "BackColor", arguments, null, null, false, true);
                this.intSelected = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "Parent", new object[0], null, null, null), null, "Index", new object[0], null, null, null));
            }
            else
            {
                object[] objArray2 = new object[] { Config.ColorBase_D };
                NewLateBinding.LateSet(sender, null, "BackColor", objArray2, null, null);
                this.intSelected = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Index", new object[0], null, null, null));
            }
        }

        private void btnOption_MouseEnter(object sender, EventArgs e)
        {
            int index = 0;
            do
            {
                if (this.intSelected == this.btnOption[index].Index)
                {
                    this.btnOption[index].BackColor = Config.ColorBase_L;
                }
                else
                {
                    this.btnOption[index].BackColor = Config.ColorBase_N;
                }
                index++;
            }
            while (index <= 5);
            object[] arguments = new object[] { Config.ColorBase_D };
            NewLateBinding.LateSet(sender, null, "BackColor", arguments, null, null);
        }

        private void btnOption_MouseLeave(object sender, EventArgs e)
        {
            Control topControl = this;
            Control youngestChildUnderMouse = this.GetYoungestChildUnderMouse(ref topControl);
            if (youngestChildUnderMouse > null)
            {
                if (!((youngestChildUnderMouse.Name.ToString() == "lblCaption") | (youngestChildUnderMouse.Name.ToString() == "picIcon")))
                {
                    if (Operators.ConditionalCompareObjectEqual(this.intSelected, NewLateBinding.LateGet(sender, null, "Index", new object[0], null, null, null), false))
                    {
                        object[] arguments = new object[] { Config.ColorBase_L };
                        NewLateBinding.LateSet(sender, null, "BackColor", arguments, null, null);
                    }
                    else
                    {
                        object[] objArray2 = new object[] { Config.ColorBase_N };
                        NewLateBinding.LateSet(sender, null, "BackColor", objArray2, null, null);
                    }
                }
            }
            else if (Operators.ConditionalCompareObjectEqual(this.intSelected, NewLateBinding.LateGet(sender, null, "Index", new object[0], null, null, null), false))
            {
                object[] objArray3 = new object[] { Config.ColorBase_L };
                NewLateBinding.LateSet(sender, null, "BackColor", objArray3, null, null);
            }
            else
            {
                object[] objArray4 = new object[] { Config.ColorBase_N };
                NewLateBinding.LateSet(sender, null, "BackColor", objArray4, null, null);
            }
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

        public void FixedSideBar(int Width)
        {
            if (Width < 450)
            {
                base.Width = 40;
                this.tlpMainOption.Width = base.Width;
                this.tlpMainOption.Left = 0;
                int index = 0;
                do
                {
                    this.btnOption[index].LabelCaption.Visible = false;
                    index++;
                }
                while (index <= 5);
            }
            else
            {
                base.Width = 150;
                this.tlpMainOption.Width = base.Width;
                this.tlpMainOption.Left = 0;
                int num2 = 0;
                do
                {
                    this.btnOption[num2].LabelCaption.Visible = true;
                    num2++;
                }
                while (num2 <= 5);
            }
        }

        private Control GetYoungestChildAtDesktopPoint(ref Control TopControl, Point DesktopPoint)
        {
            Control childAtPoint = TopControl.GetChildAtPoint(TopControl.PointToClient(DesktopPoint));
            if (childAtPoint == null)
            {
                return childAtPoint;
            }
            if (!childAtPoint.HasChildren)
            {
                return childAtPoint;
            }
            return this.GetYoungestChildAtDesktopPoint(ref childAtPoint, DesktopPoint);
        }

        private Control GetYoungestChildUnderMouse(ref Control TopControl)
        {
            return this.GetYoungestChildAtDesktopPoint(ref TopControl, Cursor.Position);
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            base.SuspendLayout();
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.Name = "Sidebar";
            base.Size = new Size(0x84, 0x30);
            base.ResumeLayout(false);
        }

        private void Me_Resize(object sender, EventArgs e)
        {
            if (this.bolIsInitialized)
            {
                this.tlpMainOption.Top = (int) Math.Round((double) (((double) (base.Height - this.tlpMainOption.Height)) / 2.0));
            }
        }
    }
}

