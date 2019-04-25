using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex7
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics graphics;
        int x = 70;
        int y = 70;
        int x2 = 70;
        int y2 = 70;
        int x3, y3 = 70;
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
            SolidBrush black = new SolidBrush(Color.Black);
            Point point1 = new Point(x-35, y-60);
            Point point2 = new Point(x, y);
            Point point3 = new Point(x-60, y);
            Point[] p = { point1, point2, point3 };
            graphics.FillPolygon(black,p );
           
            Refresh();
        }
        public void Draw2()
        {
           

            SolidBrush black = new SolidBrush(Color.Black);
            Point point1 = new Point(x2 - 35, y2 - 60);
            Point point2 = new Point(x2, y2);
            Point point3 = new Point(x2 - 60, y2);
            Point[] p = { point1, point2, point3 };
            graphics.FillPolygon(black, p);

            Refresh();
        }
        public void Draw3()
        {


            SolidBrush black = new SolidBrush(Color.Black);
            Point point1 = new Point(x3 - 35, y3 - 60);
            Point point2 = new Point(x3, y3);
            Point point3 = new Point(x3 - 60, y3);
            Point[] p = { point1, point2, point3 };
            graphics.FillPolygon(black, p);

            Refresh();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += 10;
            y += 10;
           
            if (cnt > 1) {
                Draw();
                if (y > pictureBox1.Height || x > pictureBox1.Width)
                {
                    x = 35;
                    y = 10;
                }
                    if (cnt > 10)
                {
                    x2 += 10;
                    y2 += 10;
                    Draw2();
                    if (y2 > pictureBox1.Height || x2 > pictureBox1.Width)
                    {
                        x2 = 35;
                        y2 = 10;
                    }
                    if (cnt > 20)
                    {
                        x3 += 10;
                        y3 += 10;
                        Draw3();
                        if (y3 > pictureBox1.Height || x3 > pictureBox1.Width)
                        {
                            x3 = 35;
                            y3 = 10;
                        }
                    }
                }
            }

            cnt += 1;
          
        }
    }
}
