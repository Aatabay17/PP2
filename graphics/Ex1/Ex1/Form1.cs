﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics graphics;
        Pen pen;
        int x = 50;
        int y = 30;
        int cnt = 0;
        int brushWidth = 7;
        public Form1()
        {
            InitializeComponent();

            pen = new Pen(Color.Blue, brushWidth);
           
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            
            pictureBox1.Image = bitmap;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
          
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {


        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DrawDay()
        {
            graphics.Clear(Color.Orange);
            graphics.FillRectangle(new SolidBrush(Color.Green), 0, 250, 780, 250);


            graphics.FillEllipse(new SolidBrush(Color.Yellow), x, y, 30, 30);

          
            Refresh();
        }


        private void DrawNight()
        {

            graphics.Clear(Color.DarkBlue);
            graphics.FillRectangle(new SolidBrush(Color.Green), 0, 250, 780, 250);


            graphics.FillEllipse(new SolidBrush(Color.White), x, y, 30, 30);
            Point[] star =
            {
                new Point(100 , 100),
                new Point(105 ,  105),
               new Point(110 , 130),
                new Point(115 , 105),
                new Point(120 , 100),
              new Point(115 , 95),
              new Point(110 , 70),
              new Point(105 , 95),
            };
            Point[] star1 =
          {
                new Point(100+30 , 100+30),
                new Point(105+30 ,  105+30),
               new Point(110+30 , 130+30),
                new Point(115+30 , 105+30),
              new Point(120 +30, 100 +30),
              new Point(115 +30, 95+30),
               new Point(110+30 , 70+30),
              new Point(105+30 , 95+30),
            };
            graphics.FillPolygon(new SolidBrush(Color.Yellow), star);
            graphics.FillPolygon(new SolidBrush(Color.Yellow), star1);
            Refresh();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            x += 200;
           
            if (cnt < 3)
            {
                if (cnt % 6 == 0)
                {
                    x = 50; y = 30;
                }
                DrawDay();
            }
            else
            {
                if (cnt % 6 == 3)
                {
                    x = 50; y = 30;
                }
                DrawNight();
            }
            cnt = (cnt + 1) % 6;
        }
    }
}