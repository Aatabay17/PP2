using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex8
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics graphics;
        int x,y = 100;
        int x1,y1 = 100;
        int x2, y2 = 100;
        int cnt = 0;
       

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;

        }

        public void Draw()
        {
            graphics.Clear(Color.White);
            Point[] star =
            {
                new Point(x , y),
                new Point(x+5 ,  y+5),
               new Point(x+10 , y+30),
                new Point(x+15 , y+5),
                new Point(x+20 , y),
              new Point(x+15 , y-5),
              new Point(x+10 , y-30),
              new Point(x+5 , y-5),
            };

            graphics.FillPolygon(new SolidBrush(Color.Yellow), star);

            Refresh();
        }
        public void Draw2()
        {
            Point[] star1 =
           {
                new Point(x1 , y1),
                new Point(x1+5 ,  y1+5),
               new Point(x1+10 , y1+30),
                new Point(x1+15 , y1+5),
                new Point(x1+20 , y1),
              new Point(x1+15 , y1-5),
              new Point(x1+10 , y1-30),
              new Point(x1+5 , y1-5),
            };

            graphics.FillPolygon(new SolidBrush(Color.Yellow), star1);
            Refresh();
        }
        public void Draw3()
        {
            Point[] star2 =
            {
                new Point(x2 , y2),
                new Point(x2+5 ,  y2+5),
               new Point(x2+10 , y2+30),
                new Point(x2+15 , y2+5),
                new Point(x2+20 , y2),
              new Point(x2+15 , y2-5),
              new Point(x2+10 , y2-30),
              new Point(x2+5 , y2-5),
            };

            graphics.FillPolygon(new SolidBrush(Color.Yellow), star2);
            Refresh();
        }
        private void Move()
        {
            x += 10;
            y += 10;

            if (cnt > 1)
            {
                Draw();
                
                if (y > pictureBox1.Height || x > pictureBox1.Width)
                {
                    x = 35;
                    y = 10;
                }
                if (cnt > 10)
                {
                    x1 += 10;
                    y1 += 10;
                    Draw2();
                    if (y1 > pictureBox1.Height || x1 > pictureBox1.Width)
                    {
                        x1 = 35;
                        y1 = 10;
                    }
                    if (cnt > 20)
                    {
                        x2 += 10;
                        y2 += 10;
                        Draw3();
                        if (y2 > pictureBox1.Height || x2 > pictureBox1.Width)
                        {
                            x2 = 35;
                            y2 = 10;
                        }
                    }

                }
            }


            cnt = cnt + 1;
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Move();
        }
        }
    }

