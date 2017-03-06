using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fractal
{
    public partial class koch_form : Form
    {
        Bitmap b;
        Graphics g;
        int copien;

        public koch_form()
        {
            InitializeComponent();
        }

        void koch(int n, double x, double y, double l, double u)
        {
            double xf, yf, x1, y1, x2, y2, x3, y3;

            if (n == 0)
            {
                xf = x + l * Math.Cos(u);
                yf = y - l * Math.Sin(u);
                g.DrawLine(new Pen(Color.Blue), (int)x, (int)y, (int)xf, (int)yf);
            }
            else
            {
                x1 = x + l / 3 * Math.Cos(u);
                y1 = y - l / 3 * Math.Sin(u);
                x2 = x1 + l / 3 * Math.Cos(u + Math.PI / 3);
                y2 = y1 - l / 3 * Math.Sin(u + Math.PI / 3);
                x3 = x + 2 * l / 3 * Math.Cos(u);
                y3 = y - 2 * l / 3 * Math.Sin(u);
                koch(n - 1, x, y, l / 3, u);
                koch(n - 1, x1, y1, l / 3, u + Math.PI / 3);
                koch(n - 1, x2, y2, l / 3, u - Math.PI / 3);
                koch(n - 1, x3, y3, l / 3, u);
            }

            if (n == copien - 3 || copien <= 2)
                pictureBox1.Refresh();
        }

        private void koch_form_Load(object sender, EventArgs e)
        {
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(b);
            pictureBox1.Image = b;
            pictureBox1.Refresh();
            koch(0, 10, 500, 680, 0);
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            main_form main_f = new main_form();
            this.Hide();
            main_f.Show();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            int n = Convert.ToInt32(trackBar1.Value);
            copien = n;
            koch(n, 10, 500, 680, 0);
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox1.Refresh();
            trackBar1.Value = 0;
            trackBar2.Value = 0;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            int n = Convert.ToInt32(trackBar2.Value);
            copien = n;
            koch(n, 600, 500, 500, Math.PI);
            koch(n, 100, 500, 500, Math.PI / 3);
            koch(n, 350, 66, 500, Math.PI + 2 * Math.PI / 3);
        }

        //MOVABLE FORM
        bool isMouseDown = false;
        int lastX, lastY;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                int newY = this.Top + (e.Y - lastY);
                int newX = this.Left + (e.X - lastX);

                this.Location = new Point(newX, newY);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            lastX = e.X;
            lastY = e.Y;
        }
    }
}
