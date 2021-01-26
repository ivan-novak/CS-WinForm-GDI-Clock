using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClockApp
{
    public partial class Form1 : Form
    {
        Pen PenBoard = new Pen(Color.Yellow);
        Pen PenCircle = new Pen(Color.Black);
        Pen PenMajor = new Pen(Color.Black, 5);
        Pen PenBig = new Pen(Color.Black, 4);
        Pen PenTick = new Pen(Color.Black);
        Pen PenHoures = new Pen(Color.Black, 5);
        Pen PenMinutes = new Pen(Color.Black, 3);
        Pen PenSecundes = new Pen(Color.Red);
        Pen PenDate = new Pen(Color.Black);
        SolidBrush BrushBoard = new SolidBrush(Color.Red);
        SolidBrush BrushCircle = new SolidBrush(Color.Yellow);
        SolidBrush BrushFont = new SolidBrush(Color.Black);
        SolidBrush BrushDate = new SolidBrush(Color.White);
        Font fontDate;
        Font fontMinute;
        string dw;
        string dm;


        public Form1()
        {
            
            InitializeComponent();
            DoStandart(this, null);
            DoStyle(this, null);
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics C = e.Graphics;
            Rectangle b = new Rectangle(0, 0, Clock.Size.Width, Clock.Size.Height);
            int R0 = Math.Min(b.Width-20, b.Height-20)/2;
            int R1 = R0 - 5;
            int R2 = R1 - 5;
            int RM = R2 - 5;
            int RH = RM / 2;
            int RS = R2;
            int RT = R0 - 30;

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            int minutes = DateTime.Now.Minute;
            int secundes = DateTime.Now.Second;
            int houres = DateTime.Now.Hour;
            dw = DateTime.Now.DayOfWeek.ToString();
            dm = DateTime.Now.Day.ToString();
            Point O = new Point(b.Width/2, b.Height /2);
            C.FillRectangle(BrushBoard, b);
            C.DrawRectangle(PenBoard, b);


            C.FillEllipse(BrushCircle, O.X - R0 , O.Y - R0, R0*2, R0*2);
            C.DrawEllipse(PenCircle, O.X - R0, O.Y - R0, R0*2, R0*2);
            double shift = -Math.PI / 2;
            int n = 0;
            // --------------  small ticks
            if(comboBoxTick.SelectedIndex == 0) n = 60;
            double delta = 2 * Math.PI / n;
            for (int i = 0; i < n; i++)
            {
                int x1 = (int)(Math.Cos(delta * i + shift) * R0);
                int y1 = (int)(Math.Sin(delta * i + shift) * R0);
                int x0 = (int)(Math.Cos(delta * i + shift) * R1);
                int y0 = (int)(Math.Sin(delta * i + shift) * R1);
                C.DrawLine(PenTick, O.X + x0, O.Y - y0, O.X + x1, O.Y - y1); 
            }
            // --------------  big ticks
            if (comboBoxTick.SelectedIndex <= 1) n = 12; else n = 0;
            delta = 2 * Math.PI / n;
            for (int i = 1; i < n+1; i++)
            {
                int x1 = (int)(Math.Cos(delta * i + shift) * R0);
                int y1 = (int)(Math.Sin(delta * i + shift) * R0);
                int x0 = (int)(Math.Cos(delta * i + shift) * R2);
                int y0 = (int)(Math.Sin(delta * i + shift) * R2);
                C.DrawLine(PenBig, O.X + x0, O.Y - y0, O.X + x1, O.Y - y1);
            }
            // --------------  main ticks
            if (comboBoxTick.SelectedIndex <= 2) n = 4; else n = 0;
            delta = 2 * Math.PI / n;
            for (int i = 1; i < n + 1; i++)
            {
                int x1 = (int)(Math.Cos(delta * i + shift) * R0);
                int y1 = (int)(Math.Sin(delta * i + shift) * R0);
                int x0 = (int)(Math.Cos(delta * i + shift) * R2);
                int y0 = (int)(Math.Sin(delta * i + shift) * R2);
                C.DrawLine(PenMajor, O.X + x0, O.Y - y0, O.X + x1, O.Y - y1);
            }

            // --------------  main numbers
            n = 0;
            if (comboBoxNumber.SelectedIndex == 0) n = 12;
            if (comboBoxNumber.SelectedIndex == 1) n = 4;
            delta = 2 * Math.PI / n;
            int deltaN = 1;
            if (n != 0) deltaN = 12 / n;
            for (int i = 1; i < n+1; i++)
            {
                int xt = (int)(Math.Cos(delta * i + shift) * RT);
                int yt = (int)(Math.Sin(delta * i + shift) * RT);             
                C.DrawString((i*deltaN).ToString(), fontMinute, BrushFont, xt + O.X, yt + O.Y, stringFormat);  
            }

            if (comboBox2.SelectedIndex == 0)
            {
                int SY = 25;
                int WD = 60;
                int WN = 30;

                Rectangle RN = new Rectangle(O.X + RT - 10 - WN, O.Y - SY / 2, WN, SY);
                Rectangle RD = new Rectangle(O.X + RT - 10 - WD - WN, O.Y - SY / 2, WD, SY);

                C.FillRectangle(BrushDate, RN);
                C.FillRectangle(BrushDate, RD);
                C.DrawRectangle(PenDate, RN);
                C.DrawRectangle(PenDate, RD);
                C.DrawString(dm, fontMinute, BrushFont, RN, stringFormat);
                C.DrawString(dw, fontDate, BrushFont, RD, stringFormat);
            }

            double deltaS = 2 * Math.PI / 60;
            int xs = (int)(Math.Cos(deltaS * secundes + shift) * RS);
            int ys = (int)(Math.Sin(deltaS * secundes + shift) * RS);
            C.DrawLine(PenSecundes, O.X, O.Y, O.X + xs, O.Y + ys);

            double deltaM = 2 * Math.PI / 60;
            int xm = (int)(Math.Cos(deltaM * minutes + shift) * RM);
            int ym = (int)(Math.Sin(deltaM * minutes + shift) * RM);
            C.DrawLine(PenMinutes, O.X, O.Y, O.X + xm, O.Y + ym);

            double deltaH = 2 * Math.PI / 12;
            int xh = (int)(Math.Cos(deltaH * houres + shift) * RH);
            int yh = (int)(Math.Sin(deltaH * houres + shift) * RH);
            C.DrawLine(PenHoures, O.X, O.Y, O.X + xh, O.Y + yh);

            C.DrawString(textBox1.Text, fontMinute, BrushFont,O.X, O.Y - R0/2, stringFormat);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Clock.Refresh();
        }


 
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() != DialogResult.OK) return;
            BrushCircle.Color = color.Color;
            Clock.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() != DialogResult.OK) return;
            PenMinutes.Color = color.Color;
            PenHoures.Color = color.Color;
            Clock.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() != DialogResult.OK) return;
            BrushBoard.Color = color.Color;
            Clock.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() != DialogResult.OK) return;
            PenSecundes.Color = color.Color;         
            Clock.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() != DialogResult.OK) return;
            PenTick.Color = color.Color;
            PenMajor.Color = color.Color;
            PenBig.Color = color.Color;
            Clock.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() != DialogResult.OK) return;
            BrushFont.Color = color.Color;
            Clock.Refresh();
        }

        private void DoClockRefresh(object sender, EventArgs e)
        {
            Clock.Refresh();
        }

        private void DoStyle(object sender, EventArgs e)
        {

            if(StandartHand.Checked)
            {
                PenMinutes.EndCap = LineCap.NoAnchor;
                PenHoures.EndCap = LineCap.NoAnchor;
                Clock.Refresh();
            }
            else
            {
                PenMinutes.EndCap = LineCap.ArrowAnchor;
                PenHoures.EndCap = LineCap.ArrowAnchor;
                Clock.Refresh();
            }
        }

        private void DoStandart(object sender, EventArgs e)
        {
            fontMinute = new Font(Font.FontFamily, 12, FontStyle.Bold);
            fontDate = new Font(Font.FontFamily, 9, FontStyle.Bold);
            timer1.Start();
            comboBoxTick.SelectedIndex = 0;
            comboBoxNumber.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            if (Standart.Checked)
            {
                PenBoard = new Pen(Color.Yellow);
                PenCircle = new Pen(Color.Black);
                PenMajor = new Pen(Color.Black, 5);
                PenBig = new Pen(Color.Black, 4);
                PenTick = new Pen(Color.Black);
                PenHoures = new Pen(Color.Black, 5);
                PenMinutes = new Pen(Color.Black, 3);
                PenSecundes = new Pen(Color.Red);
                PenDate = new Pen(Color.Black);
                BrushBoard = new SolidBrush(Color.SlateGray);
                BrushCircle = new SolidBrush(Color.Silver);
                BrushFont = new SolidBrush(Color.Black);
                BrushDate = new SolidBrush(Color.White);
            }
            else
            {
                PenBoard = new Pen(Color.Yellow);
                PenCircle = new Pen(Color.Black);
                PenMajor = new Pen(Color.Black, 5);
                PenBig = new Pen(Color.Black, 4);
                PenTick = new Pen(Color.Black);
                PenHoures = new Pen(Color.Black, 5);
                PenMinutes = new Pen(Color.Black, 3);
                PenSecundes = new Pen(Color.Red);
                PenDate = new Pen(Color.Black);
                BrushBoard = new SolidBrush(Color.Gray);
                BrushCircle = new SolidBrush(Color.SkyBlue);
                BrushFont = new SolidBrush(Color.Black);
                BrushDate = new SolidBrush(Color.White);
            }
        }
    }
    
}
