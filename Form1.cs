using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2_7
{
    public partial class Form1 : Form
    {
        Image[] frogFrames;
        public Form1()
        {
            InitializeComponent();

            frogFrames = new Image[18];
            frogFrames[0] = Image.FromFile("frog1.png");
            frogFrames[1] = Image.FromFile("frog2.png");
            frogFrames[2] = Image.FromFile("frog3.png");
            frogFrames[3] = Image.FromFile("frog4.png");
            frogFrames[4] = Image.FromFile("frog5.png");
            frogFrames[5] = Image.FromFile("frog6.png");
            frogFrames[6] = Image.FromFile("frog7.png");
            frogFrames[7] = Image.FromFile("frog8.png");
            frogFrames[8] = Image.FromFile("frog9.png");
            frogFrames[9] = Image.FromFile("frog10.png");
            frogFrames[10] = Image.FromFile("frog11.png");
            frogFrames[11] = Image.FromFile("frog12.png");
            frogFrames[12] = Image.FromFile("frog13.png");
            frogFrames[13] = Image.FromFile("frog14.png");
            frogFrames[14] = Image.FromFile("frog15.png");
            frogFrames[15] = Image.FromFile("frog16.png");
            frogFrames[16] = Image.FromFile("frog17.png");
            frogFrames[17] = Image.FromFile("frog18.png");
        }
        Graphics g;
        private void TaskA_Click(object sender, EventArgs e)
        {
            g = CreateGraphics();
            Point[] trianglePoints = { new Point(100, 100), new Point(100, 200), new Point(200, 200), new Point(100, 100) };
            g.DrawLines(Pens.Black, trianglePoints);
            g.DrawRectangle(Pens.Red, 260,150, 100,100);

            Point[] starPoints = new Point[10];
            double outerRadius = 60; 
            double innerRadius = outerRadius / 2.5; 

            for (int i = 0; i < 10; i++)
            {
                double angle = - Math.PI / 6 + i * Math.PI / 5;
                double radius = i % 2 == 0 ? outerRadius : innerRadius;
                int x = (int)(Math.Cos(angle) * radius)+250;
                int y = (int)(Math.Sin(angle) * radius)+250;
                starPoints[i] = new Point(x, y);
            }

            g.FillPolygon(Brushes.Yellow, starPoints);
            g.DrawPolygon(Pens.YellowGreen, starPoints);

            g.DrawEllipse(Pens.Purple, 350, 120, 200, 100);
        }
        private void TaskB_Click(object sender, EventArgs e)
        {
            g = CreateGraphics();
            Pen pen1 = new Pen(Color.Black, 8);
            g.DrawEllipse(pen1, 350, 200, 100, 100);
            g.DrawEllipse(pen1, 150, 200, 100, 100);
            Pen pen2 = new Pen(Color.DarkCyan, 8);
            Point[] points = { new Point(400, 250), new Point(370, 190), new Point(300, 250), new Point(200, 250), new Point(260, 190), new Point(370, 190), new Point(300, 250), new Point(245, 170) };
            g.DrawLines(pen2, points);
            g.DrawLine(pen1, new Point(225, 170), new Point(265, 170));
            g.DrawLine(pen2, new Point(370, 190), new Point(370, 170));
            g.DrawLine(pen1, new Point(370, 170), new Point(340, 170));
        }
        private void TaskC_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int step = 0;
        Point a = new Point(275, 125);
        Point b = new Point(275, 75);
        Point c = new Point(325, 75);
        Point d = new Point(325, 125);
        Point cente = new Point(300, 175);
        Point[] newPoints;
        Point newA, newB, newC, newD;
        private void timer1_Tick(object sender, EventArgs e)
        {
            g = CreateGraphics();
            g.Clear(BackColor);
            g.DrawEllipse(Pens.Black,250,125,100,100);
            double angle = step * Math.PI / 100;

            newA.X = (int)((a.X - cente.X) * Math.Cos(angle) - (a.Y - cente.Y) * Math.Sin(angle) + cente.X);
            newA.Y = (int)((a.X - cente.X) * Math.Sin(angle) + (a.Y - cente.Y) * Math.Cos(angle) + cente.Y);
            newB.X = (int)((b.X - cente.X) * Math.Cos(angle) - (b.Y - cente.Y) * Math.Sin(angle) + cente.X);
            newB.Y = (int)((b.X - cente.X) * Math.Sin(angle) + (b.Y - cente.Y) * Math.Cos(angle) + cente.Y);
            newC.X = (int)((c.X - cente.X) * Math.Cos(angle) - (c.Y - cente.Y) * Math.Sin(angle) + cente.X);
            newC.Y = (int)((c.X - cente.X) * Math.Sin(angle) + (c.Y - cente.Y) * Math.Cos(angle) + cente.Y);
            newD.X = (int)((d.X - cente.X) * Math.Cos(angle) - (d.Y - cente.Y) * Math.Sin(angle) + cente.X);
            newD.Y = (int)((d.X - cente.X) * Math.Sin(angle) + (d.Y - cente.Y) * Math.Cos(angle) + cente.Y);

            Point[] newPoints = { newA, newB, newC, newD, newA};
            g.DrawLines(Pens.Gray, newPoints);
            step++;
        }
        private void TaskD_Click(object sender, EventArgs e)
        {
            pic.Visible = true;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            timer2.Start();

        }
        int curr = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            curr++;
            if (curr >= frogFrames.Length)
                curr = 0;

            pic.Image = frogFrames[curr];
        }
        private void Close_Click(object sender, EventArgs e)
        {
            step = 0;
            timer1.Stop();
            timer2.Stop();
            pic.Visible = false;
            try
            {
                g.Clear(BackColor);
            }
            catch (System.NullReferenceException)
            {

            }
        }
    }
}
