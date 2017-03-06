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
    public partial class sierpinski_form : Form
    {
        Bitmap b;
        Graphics g;
        int copien;
        
        public sierpinski_form()
        {
            InitializeComponent();
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

        void sierpinski(int n, double x, double y, double l)
        {
            if (n != 0)
            {
                double l1 = l / 3;
                g.DrawRectangle(new Pen(Color.DarkCyan), (int)(x + l1), (int)(y + l1), (int)l1, (int)l1);
                sierpinski(n - 1, x, y, l1);
                sierpinski(n - 1, x + l1, y, l1);
                sierpinski(n - 1, x + 2 * l1, y, l1);
                sierpinski(n - 1, x, y + l1, l1);
                sierpinski(n - 1, x, y + 2 * l1, l1);
                sierpinski(n - 1, x + l1, y + 2 * l1, l1);
                sierpinski(n - 1, x + 2 * l1, y + 2 * l1, l1);
                sierpinski(n - 1, x + 2 * l1, y + l1, l1);
            }
            if (n == copien - 3 || copien <= 2)
                pictureBox1.Refresh();
        }

        void sierpinski2(int n, double x, double y, double l)
        {
            Random randonGen = new Random();
            Color randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255),
            randonGen.Next(255));
            Color cul = randomColor;
            
            if (n != 0)
            {
                double l1 = l / 3;
                g.DrawRectangle(new Pen(cul), (int)(x + l1), (int)(y + l1), (int)l1, (int)l1);
                sierpinski2(n - 1, x, y, l1);
                sierpinski2(n - 1, x + l1, y, l1);
                sierpinski2(n - 1, x + 2 * l1, y, l1);
                sierpinski2(n - 1, x, y + l1, l1);
                sierpinski2(n - 1, x, y + 2 * l1, l1);
                sierpinski2(n - 1, x + l1, y + 2 * l1, l1);
                sierpinski2(n - 1, x + 2 * l1, y + 2 * l1, l1);
                sierpinski2(n - 1, x + 2 * l1, y + l1, l1);
            }
            if (n == copien - 3 || copien <= 2)
                pictureBox1.Refresh();
        }

        private void sierpinski_form_Load(object sender, EventArgs e)
        {
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(b);
            pictureBox1.Image = b;
            pictureBox1.Refresh();
            g.DrawRectangle(new Pen(Color.DarkCyan), 10, 10, 680, 680);
            sierpinski(0, 10, 10, 680);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            int n = Convert.ToInt32(trackBar1.Value);
            copien = n;
            g.DrawRectangle(new Pen(Color.DarkCyan), 10, 10, 680, 680);
            if(checkBox1.Checked==true)
                 sierpinski2(n, 10, 10, 680);
            else
                sierpinski(n, 10, 10, 680);
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
