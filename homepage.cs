using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app1
{
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }


        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        public Point mouslocation;
        private void homepage_MouseDown(object sender, MouseEventArgs e)
        {
            mouslocation = new Point(-e.X, -e.Y);
        }

        private void homepage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point Mousepose = Control.MousePosition;
                Mousepose.Offset(mouslocation.X, mouslocation.Y);
                Location = Mousepose;
            }
        }

        private void homepar_MouseDown(object sender, MouseEventArgs e)
        {
            mouslocation = new Point(-e.X, -e.Y);
        }

        private void homepar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point Mousepose = Control.MousePosition;
                Mousepose.Offset(mouslocation.X, mouslocation.Y);
                Location = Mousepose;
            }
        }

        private void titlepar_MouseDown(object sender, MouseEventArgs e)
        {
            mouslocation = new Point(-e.X, -e.Y);
        }

        private void titlepar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point Mousepose = Control.MousePosition;
                Mousepose.Offset(mouslocation.X, mouslocation.Y);
                Location = Mousepose;
            }
        }

        private void maxinormal_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
               
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0)
            {
                this.Opacity += 0.3;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void homepage_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            timer1.Start();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
           LoginF F = new LoginF();
            F.Show();
        }




    }
}
