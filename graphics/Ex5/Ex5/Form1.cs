using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex5
{
    public partial class Form1 : Form
    {
        bool IsClicked = false;
        Bitmap bitmap;
        Graphics graphics;
        int x, y;
        public Form1()
        {
            InitializeComponent();
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!IsClicked)
            {
                x = e.Location.X;
                y = e.Location.Y;
                timer1.Start();
                IsClicked = true;
            }
            else
            {
                IsClicked = false;
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsClicked == true)
            {
                DrawEllipse();
                movedown();
            }
            Refresh();
        }


        private void movedown()
        { 
                y += 10;
            
        }
        private void DrawEllipse()
        {
            graphics.Clear(Color.White);
            SolidBrush blue = new SolidBrush(Color.Blue);
            graphics.FillEllipse(blue, x, y ,50,50);
            Refresh();
        }
    }
}
