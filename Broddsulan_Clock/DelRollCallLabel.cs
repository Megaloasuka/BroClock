namespace Broddsulan_Clock
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class DelRollCallLabel : UserControl
    {
        private IContainer components;
        private Label lblCaption = new Label();
        private Label lblStatus = new Label();

        public DelRollCallLabel()
        {
            this.InitializeComponent();
            this.BackColor = Color.White;
            base.Padding = new Padding(0, 0, 0, 0);
            base.Controls.Add(this.lblCaption);
            base.Controls.Add(this.lblStatus);
            this.lblStatus.Height = base.Height;
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
            base.Name = "DelRollCallLabel";
            base.ResumeLayout(false);
        }
    }
}

