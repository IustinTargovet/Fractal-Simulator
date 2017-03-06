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
    public partial class main_form : Form
    {
        //VARIABLES FOR THE MOVABLE FORM
        bool isMouseDown = false;
        int lastX, lastY;
        
        public main_form()
        {
            InitializeComponent();
        }

        //EXIT BUTTON
        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //MOVABLE FORM
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

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ajutooooor feteloooor!"); //INLOCUIESTE TEXTUL 
        }

        //MENU
        private void koch_button_Click(object sender, EventArgs e)
        {
            koch_form koch_f = new koch_form();
            this.Hide();
            koch_f.Show();
        }

        private void cesaro_button_Click(object sender, EventArgs e)
        {
            cesaro_form cesaro_f = new cesaro_form();
            this.Hide();
            cesaro_f.Show();
        }

        private void sierpinski_button_Click(object sender, EventArgs e)
        {
            sierpinski_form sierpinski_f = new sierpinski_form();
            this.Hide();
            sierpinski_f.Show();
        }

        private void dragon_button_Click(object sender, EventArgs e)
        {
            dragon_form dragon_f = new dragon_form();
            this.Hide();
            dragon_f.Show();
        }

        private void trisierpinski_button_Click(object sender, EventArgs e)
        {
            trisierpinski_form trisierpinski_f = new trisierpinski_form();
            this.Hide();
            trisierpinski_f.Show();
        }

        private void barnsley_button_Click(object sender, EventArgs e)
        {
            barnsley_form barnsley_f = new barnsley_form();
            this.Hide();
            barnsley_f.Show();
        }

        
    }
}
