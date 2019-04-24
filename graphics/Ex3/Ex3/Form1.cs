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

namespace Ex3
{
    public partial class Form1 : Form
    {
        bool isClicked = false;
        Bitmap bitmap;
        Graphics graphics;

        int x, y, r = 50, d = 5;
        Color[] colors = new Color[]
        {
            Color.Red,
            Color.Blue,
            Color.Yellow,
            Color.Purple,
            Color.Green,
            Color.Bisque,
            Color.BurlyWood
        };
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
        }

        private void DrawEllipse()
        {
            graphics.Clear(Color.White);
            int index = random.Next(0, colors.Length - 1);
            Pen pen = new Pen(colors[index], 3);
            graphics.DrawEllipse(pen, x - r + d, y - r, 2 * r, 2 * r);
            graphics.DrawEllipse(pen, x - r, y - r + d, 2 * r, 2 * r);
            graphics.DrawEllipse(pen, x - r - d, y - r, 2 * r, 2 * r);
            graphics.DrawEllipse(pen, x - r, y - r - d, 2 * r, 2 * r);
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isClicked)
            {
                x = e.Location.X;
                y = e.Location.Y;
                d = 5;

                timer1.Start();
                isClicked = true;
            }
            else
            {
                isClicked = false;
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d += 3;
            DrawEllipse();
            pictureBox1.Refresh();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
          
        }
 
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
    }

      
    }
