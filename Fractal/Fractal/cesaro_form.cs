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
    public partial class cesaro_form : Form
    {
        Bitmap b;
        Graphics g;
        int copien;
        double L = 2.117647058823529;
        
        public cesaro_form()
        {
            InitializeComponent();
        }

        void cesaro(int n, double x, double y, double l, double u)
        {
            double xf, yf, x1, y1, x2, y2, x3, y3;
            double opt5 = Math.Cos(Math.PI / L);
            double X = (2 + 2 * opt5);

            if (n == 0)
            {
                xf = x + l * Math.Cos(u);
                yf = y - l * Math.Sin(u);
                g.DrawLine(new Pen(Color.Orange), (int)x, (int)y, (int)xf, (int)yf);
            }
            else
            {
                x1 = x + l / X * Math.Cos(u);
                y1 = y - l / X * Math.Sin(u);
                x2 = x1 + l / X * Math.Cos(u + Math.PI / L);
                y2 = y1 - l / X * Math.Sin(u + Math.PI / L);
                x3 = x + (2 * l / X * opt5 + l / X) * Math.Cos(u);
                y3 = y - (2 * l / X * opt5 + l / X) * Math.Sin(u);
                cesaro(n - 1, x, y, l / X, u);
                cesaro(n - 1, x1, y1, l / X, u + Math.PI / L);
                cesaro(n - 1, x2, y2, l / X, u - Math.PI / L);
                cesaro(n - 1, x3, y3, l / X, u);
            }

            if (n == copien - 3 || copien <= 2)
                pictureBox1.Refresh();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox1.Refresh();
            trackBar1.Value = 0;
            trackBar2.Value = 0;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            main_form main_f = new main_form();
            this.Hide();
            main_f.Show();
        }

        private void cesaro_form_Load(object sender, EventArgs e)
        {
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(b);
            pictureBox1.Image = b;
            pictureBox1.Refresh();
            cesaro(0, 10, 500, 680, 0);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            int n = Convert.ToInt32(trackBar1.Value);
            copien = n;
            cesaro(n, 10, 500, 680, 0);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            int n = Convert.ToInt32(trackBar2.Value);
            copien = n;
            cesaro(n, 473, 550, 250, Math.PI);
            cesaro(n, 225, 550, 250, 2 * Math.PI / 3);
            cesaro(n, 100, 332, 250, Math.PI / 3);
            cesaro(n, 225, 114, 250, 0);
            cesaro(n, 475, 114, 250, 2 * Math.PI - Math.PI / 3);
            cesaro(n, 601, 331, 252, Math.PI + Math.PI / 3);
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
