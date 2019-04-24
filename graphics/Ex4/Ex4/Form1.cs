using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics graphics;
        int x, y = 50;
        int x1, y1 = 50;
        int x2, y2 = 50;
        int cnt = 0;

        Pen pen = new Pen(Color.Black, 3);

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
        }

        private void Drawmen1()
        {
            SolidBrush head = new SolidBrush(Color.DarkRed);
            graphics.FillEllipse(head, x1 + 40, y1 + 20, 70, 70);

            graphics.DrawLine(pen, x1 + 75, y1 + 90, x1 + 75, y1 + 150);
            graphics.DrawLine(pen, x1 + 75, y1 + 145, x1 + 30, y1 + 341);
            graphics.DrawLine(pen, x1 + 75, y1 + 145, x1 + 117, y1 + 350);
            graphics.DrawLine(pen, x1 + 75, y1 + 115, x1 + 145, y1 + 170);
            graphics.DrawLine(pen, x1 + 75, y1 + 115, x1 + 5, y1 + 170);

            Refresh();
        }

        private void Drawmen2()
        {
            SolidBrush head = new SolidBrush(Color.DarkRed);
            graphics.FillEllipse(head, x2 + 190 , y2 + 20, 70, 70);

            graphics.DrawLine(pen, x2 + 225 , y2 + 90, x2 + 225, y2 + 150);
            graphics.DrawLine(pen, x2 + 225, y2 + 145, x2 + 180, y2 + 341);
            graphics.DrawLine(pen, x2 + 225, y2 + 145, x2 + 267, y2 + 350);
            graphics.DrawLine(pen, x2 + 225, y2 + 115, x2 + 295, y2 + 170);
            graphics.DrawLine(pen, x2 + 225, y2 + 115, x2 + 155, y2 + 170);
            Refresh();
        }

        private void Draw()
        {
            graphics.Clear(Color.DarkBlue);
            SolidBrush grass = new SolidBrush(Color.Green);
            graphics.FillRectangle(grass, 0, 250, 780, 250);
            SolidBrush yellow = new SolidBrush(Color.Yellow);
            graphics.FillEllipse(yellow, x, y - 40, 100, 100);
            SolidBrush darkblue = new SolidBrush(Color.DarkBlue);
            graphics.FillEllipse(darkblue, x + 30, y - 60, 110, 110);



            Point[] star1 =
            {
                new Point(100 , 100),
                new Point(105 , 105),
                new Point(110 , 130),
                new Point(115 , 105),
                new Point(120 , 100),
                new Point(115 , 95),
                new Point(110, 70),
                new Point(105 , 95),
            };
            Point[] star2 =
            {
                new Point(100+100 , 100-10),
                new Point(105+100 , 105-10),
                new Point(110+100, 130 - 10),
                new Point(115+100 , 105-10),
                new Point(120+100 , 100-10),
                new Point(115+100 , 95-10),
                new Point(110+100, 70-10),
                new Point(105+100 , 95-10),
            };
            Point[] star3 =
            {
                new Point(100+150 , 100),
                new Point(105+150 , 105),
                new Point(110 +150, 130),
                new Point(115 +150, 105),
                new Point(120 +150, 100),
                new Point(115+150 , 95),
                new Point(110+150, 70),
                new Point(105+150 , 95),
            };
            graphics.FillPolygon(new SolidBrush(Color.Yellow), star1);
            graphics.FillPolygon(new SolidBrush(Color.Yellow), star2);
            graphics.FillPolygon(new SolidBrush(Color.Yellow), star3);
            Refresh();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Draw();
            x1 += 10;
            x2 -= 10;
            if (cnt>1)
            {
                if (cnt % 2 == 0)
                {
                    x1 += 10;
                    x2 -= 10;
                    if (x1 >= pictureBox1.Width  )
                    {
                        x1 = 0;
                    }
                    if (x2 <= 0)
                    {
                        x2 = pictureBox1.Width;
                    }
                }
                Drawmen2();
                Drawmen1();
               
            }
         
            cnt = (cnt + 1);
        }
    }
}


