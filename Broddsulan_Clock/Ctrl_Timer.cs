namespace Broddsulan_Clock
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Text;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class Ctrl_Timer : UserControl
    {
        private SolidBrush BrushBack = new SolidBrush(Config.ColorGray_N);
        private SolidBrush BrushDeep = new SolidBrush(Config.ColorBase_L);
        private SolidBrush BrushLight = new SolidBrush(Color.White);
        private IContainer components;
        private Font fnt24 = new Font("Digiface", 24f);
        private Font fnt34 = new Font("Digiface", 34f);
        private Font fnt72 = new Font("Digiface", 72f);
        private Rectangle FrontRing = new Rectangle(6, 6, 200, 200);
        private Graphics g;
        private int intInterval = 100;
        private int intTime;
        private int intTimeCount;
        private int intTotalTime;
        private int intTotalTimeCount;
        private Label lblTotalTime = new Label();
        private Rectangle OuterCircle = new Rectangle(0x10, 0x10, 180, 180);
        private PictureBox picTimer = new PictureBox();
        private System.Windows.Forms.Timer Timer1 = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer Timer2 = new System.Windows.Forms.Timer();
        private Graphics WindowGraphics;

        public Ctrl_Timer()
        {
            this.InitializeComponent();
            this.DoubleBuffered = true;
            base.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
            base.BorderStyle = BorderStyle.None;
            this.BackColor = Color.Transparent;
            base.Size = new Size(0xd4, 0x106);
            base.Padding = new Padding(0, 0, 0, 0);
            base.Paint += new PaintEventHandler(this.picTimer_Paint);
            this.picTimer.Size = new Size(0xd4, 0xd4);
            this.picTimer.Location = new Point(0, 0);
            this.picTimer.Click += new EventHandler(this.picTimer_Click);
            this.picTimer.DoubleClick += new EventHandler(this.picTimer_DblClick);
            this.picTimer.Paint += new PaintEventHandler(this.picTimer_Paint);
            this.picTimer.MouseEnter += new EventHandler(this.picTimer_MouseEnter);
            this.picTimer.MouseLeave += new EventHandler(this.picTimer_MouseLeave);
            base.Controls.Add(this.picTimer);
            this.lblTotalTime.Font = this.fnt24;
            this.lblTotalTime.Size = new Size(this.picTimer.Width, 40);
            this.lblTotalTime.Padding = new Padding(0, 0, 0, 0);
            this.lblTotalTime.Text = " ";
            this.lblTotalTime.TextAlign = ContentAlignment.TopCenter;
            this.lblTotalTime.Location = new Point(0, this.picTimer.Bottom);
            this.lblTotalTime.ForeColor = Config.ColorGray_N;
            this.lblTotalTime.BackColor = Color.Transparent;
            this.intTimeCount = 0;
            this.intTotalTimeCount = 0;
            this.intTime = 0;
            this.intTotalTime = 0;
            base.Controls.Add(this.lblTotalTime);
            this.Timer1.Interval = this.intInterval;
            this.Timer1.Enabled = false;
            this.Timer1.Tick += new EventHandler(this.Timer1_Tick);
            this.g = this.picTimer.CreateGraphics();
            this.g.SmoothingMode = SmoothingMode.HighQuality;
            this.g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            this.g.CompositingQuality = CompositingQuality.HighQuality;
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

        private Bitmap DrawGDI(int time, int totaltime)
        {
            int num = (int) Math.Round((double) (1000.0 / ((double) this.intInterval)));
            Bitmap image = new Bitmap(0xfc, 0xfc);
            Graphics graphics = Graphics.FromImage(image);
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.Clear(Color.White);
            graphics.FillPie(this.BrushDeep, this.FrontRing, 270f, -360f);
            graphics.FillPie(this.BrushBack, this.FrontRing, 270f, (float) Conversion.Int((double) ((((double) (0 - totaltime)) / ((double) (this.intTotalTime * num))) * 360.0)));
            graphics.FillEllipse(this.BrushLight, this.OuterCircle);
            Rectangle rectangle = new Rectangle(new Point(0, 0), graphics.MeasureString("00", this.fnt72).ToSize());
            Rectangle rectangle2 = new Rectangle(new Point(0, 0), graphics.MeasureString("00", this.fnt34).ToSize());
            graphics.DrawString(((this.intTime - Conversion.Int((double) (((double) time) / ((double) num)))) % 60.0).ToString("00"), this.fnt72, this.BrushDeep, (float) (((double) (this.picTimer.Width - rectangle.Width)) / 2.0), 30f);
            graphics.DrawString(Conversion.Int((double) ((this.intTime - Conversion.Int((double) (((double) time) / ((double) num)))) / 60.0)).ToString("00"), this.fnt34, this.BrushBack, (float) (((double) (this.picTimer.Width - rectangle2.Width)) / 2.0), 126f);
            return image;
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            base.SuspendLayout();
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.Name = "TimerInCircle";
            base.ResumeLayout(false);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void picTimer_Click(object sender, EventArgs e)
        {
            int num = (int) Math.Round((double) (1000.0 / ((double) this.intInterval)));
            if (!this.Timer1.Enabled)
            {
                this.g.DrawImage(this.DrawGDI(this.intTimeCount, this.intTotalTimeCount), new Point(0, 0));
                if ((this.intTimeCount < (this.intTime * num)) & (this.intTimeCount > 0))
                {
                    this.Timer1.Start();
                }
                else if (this.intTimeCount == 0)
                {
                    if (((this.intTotalTime * num) - this.intTotalTimeCount) < (this.intTime * num))
                    {
                        this.intTimeCount = this.intTime * num;
                        this.intTotalTimeCount = this.intTotalTime * num;
                        this.g.DrawImage(this.DrawGDI(this.intTimeCount, this.intTotalTimeCount), new Point(0, 0));
                        this.lblTotalTime.Text = Conversion.Int((double) ((this.intTotalTime - Conversion.Int((double) (((double) this.intTotalTimeCount) / ((double) num)))) / 60.0)).ToString("00") + " : " + (((this.intTotalTime - Conversion.Int((double) (((double) this.intTotalTimeCount) / ((double) num)))) % 60.0)).ToString("00");
                    }
                    else
                    {
                        this.Timer1.Start();
                    }
                }
            }
            else
            {
                this.Timer1.Stop();
            }
        }

        private void picTimer_DblClick(object sender, EventArgs e)
        {
            int num = (int) Math.Round((double) (1000.0 / ((double) this.intInterval)));
            if (this.Timer.Enabled)
            {
                this.Timer1.Stop();
            }
            this.intTimeCount = 0;
            this.g.DrawImage(this.DrawGDI(this.intTimeCount, this.intTotalTimeCount), new Point(0, 0));
            if (((this.intTotalTime * num) - this.intTotalTimeCount) < (this.intTime * num))
            {
                this.intTimeCount = this.intTime * num;
                this.intTotalTimeCount = this.intTotalTime * num;
                this.g.DrawImage(this.DrawGDI(this.intTimeCount, this.intTotalTimeCount), new Point(0, 0));
                this.lblTotalTime.Text = Conversion.Int((double) ((this.intTotalTime - Conversion.Int((double) (((double) this.intTotalTimeCount) / ((double) num)))) / 60.0)).ToString("00") + " : " + (((this.intTotalTime - Conversion.Int((double) (((double) this.intTotalTimeCount) / ((double) num)))) % 60.0)).ToString("00");
            }
        }

        private void picTimer_MouseEnter(object sender, EventArgs e)
        {
            this.lblTotalTime.ForeColor = Config.ColorBase_L;
        }

        private void picTimer_MouseLeave(object sender, EventArgs e)
        {
            this.lblTotalTime.ForeColor = Color.White;
        }

        private void picTimer_Paint(object sender, PaintEventArgs e)
        {
            this.g.DrawImage(this.DrawGDI(this.intTimeCount, this.intTotalTimeCount), new Point(0, 0));
        }

        public void SetTime(string totaltime, string time)
        {
            int num = (int) Math.Round((double) (1000.0 / ((double) this.intInterval)));
            int num2 = (int) Math.Round(Conversion.Val(totaltime));
            int num3 = (int) Math.Round(Conversion.Val(time));
            if ((num2 == 0) | (num2 < num3))
            {
                num2 = num3;
            }
            else if (num3 == 0)
            {
                num3 = num2;
            }
            if (num3 > 0xe10)
            {
                num3 = 0xe10;
            }
            if (num2 > 0xe10)
            {
                num2 = 0xe10;
            }
            this.Timer1.Stop();
            this.intTimeCount = 0;
            this.intTotalTimeCount = 0;
            this.intTime = num3;
            this.intTotalTime = num2;
            this.g.DrawImage(this.DrawGDI(this.intTimeCount, this.intTotalTimeCount), new Point(0, 0));
            this.lblTotalTime.Text = Conversion.Int((double) ((this.intTotalTime - Conversion.Int((double) (((double) this.intTotalTimeCount) / ((double) num)))) / 60.0)).ToString("00") + " : " + (((this.intTotalTime - Conversion.Int((double) (((double) this.intTotalTimeCount) / ((double) num)))) % 60.0)).ToString("00");
        }

        private unsafe void Timer1_Tick(object sender, EventArgs e)
        {
            ref int numRef;
            int num = (int) Math.Round((double) (1000.0 / ((double) this.intInterval)));
            *(numRef = (int) &this.intTimeCount) = numRef + 1;
            *(numRef = (int) &this.intTotalTimeCount) = numRef + 1;
            if (this.intTimeCount <= (this.intTime * num))
            {
                double num2 = (this.intTotalTime - Conversion.Int((double) (((double) this.intTotalTimeCount) / ((double) num)))) % 60.0;
                this.lblTotalTime.Text = Conversion.Int((double) ((this.intTotalTime - Conversion.Int((double) (((double) this.intTotalTimeCount) / ((double) num)))) / 60.0)).ToString("00") + " : " + num2.ToString("00");
                this.g.DrawImage(this.DrawGDI(this.intTimeCount, this.intTotalTimeCount), new Point(0, 0));
            }
            else
            {
                this.Timer1.Stop();
                this.intTimeCount = 0;
                *(numRef = (int) &this.intTotalTimeCount) = numRef - 1;
                if (this.intTotalTimeCount >= (this.intTotalTime * num))
                {
                    this.intTimeCount = this.intTime * num;
                    this.intTotalTimeCount = this.intTotalTime * num;
                }
                this.g.DrawImage(this.DrawGDI(this.intTimeCount, this.intTotalTimeCount), new Point(0, 0));
                this.lblTotalTime.Text = Conversion.Int((double) ((this.intTotalTime - Conversion.Int((double) (((double) this.intTotalTimeCount) / ((double) num)))) / 60.0)).ToString("00") + " : " + (((this.intTotalTime - Conversion.Int((double) (((double) this.intTotalTimeCount) / ((double) num)))) % 60.0)).ToString("00");
            }
        }

        public PictureBox Timer
        {
            get
            {
                return this.picTimer;
            }
            set
            {
            }
        }
    }
}

