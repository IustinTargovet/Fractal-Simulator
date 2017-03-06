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
    public partial class dragon_form : Form
    {
        Bitmap b;
        Graphics g;
        int copien;
        
        public dragon_form()
        {
            InitializeComponent();
        }

        void dragon(int n, double x, double y, double l, double u, int sens)
        {
            double xf, yf, x1, y1;

            if (n == 0)
            {
                xf = x + l * Math.Cos(u);
                yf = y - l * Math.Sin(u);
                g.DrawLine(new Pen(Color.DarkMagenta), (int)x, (int)y, (int)xf, (int)yf);
            }
            else
            {
                double l1 = l / Math.Sqrt(2);
                x1 = x + l1 * Math.Cos(u - sens * Math.PI / 4);
                y1 = y - l1 * Math.Sin(u - sens * Math.PI / 4);
                dragon(n - 1, x, y, l1, u - sens * Math.PI / 4, -1);
                dragon(n - 1, x1, y1, l1, u + sens * Math.PI / 4, 1);
            }

            if (n == copien - 3 || copien <= 2)
                pictureBox1.Refresh();
        }

        private void dragon_form_Load(object sender, EventArgs e)
        {
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(b);
            pictureBox1.Image = b;
            pictureBox1.Refresh();
            dragon(0, 100, 300, 400, 0, 1);
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            main_form main_f = new main_form();
            this.Hide();
            main_f.Show();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox1.Refresh();
            trackBar1.Value = 0;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            int n = Convert.ToInt32(trackBar1.Value);
            copien = n;
            dragon(n, 100, 300, 400, 0, 1);
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
