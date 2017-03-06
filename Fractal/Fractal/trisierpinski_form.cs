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
    public partial class trisierpinski_form : Form
    {
        Bitmap b;
        Graphics g;
        int copien;
        
        public trisierpinski_form()
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

        Point Mid(Point a, Point b)
        {
            return new Point((a.X + b.X) / 2, (a.Y + b.Y) / 2);
        }

        void trisierpinski(int n, Point a, Point b, Point c)
        {
            if (n != 0)
            {

                g.DrawLine(new Pen(Color.DarkCyan), a, b);
                g.DrawLine(new Pen(Color.DarkCyan), b, c);
                g.DrawLine(new Pen(Color.DarkCyan), c, a);

                trisierpinski(n - 1, a, Mid(a, b), Mid(c, a));
                trisierpinski(n - 1, Mid(a, b), b, Mid(b, c));
                trisierpinski(n - 1, Mid(a, c), Mid(b, c), c);


            }
            if (n == copien - 3 || copien <= 2)
                pictureBox1.Refresh();
        }

        void trisierpinski2(int n, Point a, Point b, Point c)
        {
            Random randonGen = new Random();
            Color randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255),
            randonGen.Next(255));
            Color cul = randomColor;

            if (n != 0)
            {
                g.DrawLine(new Pen(cul), a, b);
                g.DrawLine(new Pen(cul), b, c);
                g.DrawLine(new Pen(cul), c, a);
                trisierpinski2(n - 1, a, Mid(a, b), Mid(c, a));
                trisierpinski2(n - 1, Mid(a, b), b, Mid(b, c));
                trisierpinski2(n - 1, Mid(a, c), Mid(b, c), c);

            }

            if (n == copien - 3 || copien <= 2)
                pictureBox1.Refresh();
        }

        private void trisierpinski_form_Load(object sender, EventArgs e)
        {
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(b);
            pictureBox1.Image = b;
            pictureBox1.Refresh();

            Point A = new Point();
            A.X = 0;
            A.Y = 700;
            Point B = new Point();
            B.X = 350;
            B.Y = 0;
            Point C = new Point();
            C.X = 700;
            C.Y = 700;

            g.DrawLine(new Pen(Color.DarkCyan), A, B);
            g.DrawLine(new Pen(Color.DarkCyan), B, C);
            g.DrawLine(new Pen(Color.DarkCyan), C, A);

            pictureBox1.Refresh();
            trisierpinski(0, A, B, C);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            int n = Convert.ToInt32(trackBar1.Value);
            copien = n;
            
            Point A = new Point();
            A.X = 0;
            A.Y = 700;
            Point B = new Point();
            B.X = 350;
            B.Y = 0;
            Point C = new Point();
            C.X = 700;
            C.Y = 700;

            g.DrawLine(new Pen(Color.DarkCyan), A, B);
            g.DrawLine(new Pen(Color.DarkCyan), B, C);
            g.DrawLine(new Pen(Color.DarkCyan), C, A);

            pictureBox1.Refresh();
            if(checkBox1.Checked!=true) trisierpinski(n, A, B, C);
            else trisierpinski2(n, A, B, C);
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
