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
    public partial class barnsley_form : Form
    {
        Bitmap b;
        Graphics g;
        
        public barnsley_form()
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            int np = 300000;
            double[,] f = new double[4, 7];
            double s = 0;
            double[] prob = new double[4];
            int i;
            double xold = 0, yold = 0, alea, x, y, xim, yim;
            double xmin = -2.18, ymin = 0.01, sc = 70;
            int k;
            Random r = new Random();

            f[0, 0] = 0; f[0, 1] = 0; f[0, 2] = 0; f[0, 3] = 0.16; f[0, 4] = 0; f[0, 5] = 0; f[0, 6] = 0.01;
            f[1, 0] = 0.2; f[1, 1] = -0.26; f[1, 2] = 0.23; f[1, 3] = 0.22; f[1, 4] = 0; f[1, 5] = 1.6; f[1, 6] = 0.07;
            f[2, 0] = -0.15; f[2, 1] = 0.28; f[2, 2] = 0.26; f[2, 3] = 0.24; f[2, 4] = 0; f[2, 5] = 0.44; f[2, 6] = 0.07;
            f[3, 0] = 0.85; f[3, 1] = 0.04; f[3, 2] = -0.04; f[3, 3] = 0.85; f[3, 4] = 0; f[3, 5] = 1.6; f[3, 6] = 0.85;

            for (i = 0; i <= 3; i++)
            {
                s += f[i, 6];
                prob[i] = s;
            }

            for (i = 1; i <= np; i++)
            {
                alea = r.NextDouble();
                k = 0;
                while (prob[k] < alea) k++;
                x = f[k, 0] * xold + f[k, 1] * yold + f[k, 4];
                y = f[k, 2] * xold + f[k, 3] * yold + f[k, 5];
                xold = x; yold = y;
                xim = (x - xmin) * sc + 200;
                yim = 700 - (y - ymin) * sc;
                b.SetPixel((int)xim, (int)yim, Color.Green);
                if (i % 2000 == 0) pictureBox1.Refresh();
            }
        }

        private void barnsley_form_Load(object sender, EventArgs e)
        {
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(b);
            pictureBox1.Image = b;
            pictureBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);

            int np = 300000;
            double[,] f = new double[4, 7];
            double s = 0;
            double[] prob = new double[4];
            int i;
            double xold = 0, yold = 0, alea, x, y, xim, yim;
            double xmin = -1.56, ymin = -0.18, sc = 109;
            int k;
            Random r = new Random();

            f[0, 0] = 0; f[0, 1] = 0; f[0, 2] = 0; f[0, 3] = 0.25; f[0, 4] = 0; f[0, 5] = -0.14; f[0, 6] = 0.02;
            f[1, 0] = 0.09; f[1, 1] = -0.28; f[1, 2] = 0.30; f[1, 3] = 0.11; f[1, 4] = 0; f[1, 5] = 0.6; f[1, 6] = 0.07;
            f[2, 0] = -0.09; f[2, 1] = 0.28; f[2, 2] = 0.30; f[2, 3] = 0.09; f[2, 4] = 0; f[2, 5] = 0.70; f[2, 6] = 0.07;
            f[3, 0] = 0.85; f[3, 1] = 0.02; f[3, 2] = -0.02; f[3, 3] = 0.83; f[3, 4] = 0; f[3, 5] = 1; f[3, 6] = 0.84;

            for (i = 0; i <= 3; i++)
            {
                s += f[i, 6];
                prob[i] = s;
            }

            for (i = 1; i <= np; i++)
            {
                alea = r.NextDouble();
                k = 0;
                while (prob[k] < alea) k++;
                x = f[k, 0] * xold + f[k, 1] * yold + f[k, 4];
                y = f[k, 2] * xold + f[k, 3] * yold + f[k, 5];
                xold = x; yold = y;
                xim = (x - xmin) * sc + 200;
                yim = 700 - (y - ymin) * sc;
                b.SetPixel((int)xim, (int)yim, Color.ForestGreen);
                if (i % 2000 == 0) pictureBox1.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);

            int np = 300000;
            double[,] f = new double[4, 7];
            double s = 0;
            double[] prob = new double[4];
            int i;
            double xold = 0, yold = 0, alea, x, y, xim, yim;
            double xmin = -2.34, ymin = 0, sc = 68;
            int k;
            Random r = new Random();

            f[0, 0] = 0; f[0, 1] = 0; f[0, 2] = 0; f[0, 3] = 0.16; f[0, 4] = 0; f[0, 5] = 0; f[0, 6] = 0.10;
            f[1, 0] = 0.20; f[1, 1] = -0.26; f[1, 2] = 0.23; f[1, 3] = 0.22; f[1, 4] = 0; f[1, 5] = 1.6; f[1, 6] = 0.08;
            f[2, 0] = -0.15; f[2, 1] = 0.28; f[2, 2] = 0.26; f[2, 3] = 0.24; f[2, 4] = 0; f[2, 5] = 0.44; f[2, 6] = 0.08;
            f[3, 0] = 0.75; f[3, 1] = 0.04; f[3, 2] = -0.04; f[3, 3] = 0.85; f[3, 4] = 0; f[3, 5] = 1.6; f[3, 6] = 0.74;

            for (i = 0; i <= 3; i++)
            {
                s += f[i, 6];
                prob[i] = s;
            }

            for (i = 1; i <= np; i++)
            {
                Random randonGen = new Random();
                Color randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255),
                randonGen.Next(255));
                Color cul = randomColor;
                alea = r.NextDouble();
                k = 0;
                while (prob[k] < alea) k++;
                x = f[k, 0] * xold + f[k, 1] * yold + f[k, 4];
                y = f[k, 2] * xold + f[k, 3] * yold + f[k, 5];
                xold = x; yold = y;
                xim = (x - xmin) * sc + 200;
                yim = 700 - (y - ymin) * sc;
                b.SetPixel((int)xim, (int)yim, cul);
                if (i % 2000 == 0) pictureBox1.Refresh();
            }
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
