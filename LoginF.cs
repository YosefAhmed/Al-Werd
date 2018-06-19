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
    public partial class LoginF : Form
    {
        public LoginF()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            User U = new User()
            {
                username = username.Text,
                passowrd =password.Text
            };
            var Chick=U.Check(U.username, U.passowrd);
            if (Chick)
            {
                homepage H = new homepage();
                H.Show();
                this.Hide();
            }
            else throw new Exception("username or password is incorrect !");
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public Point mouslocation;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouslocation = new Point(-e.X, -e.Y);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point Mousepose=Control.MousePosition;
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

        private void LoginF_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            timer1.Start();

        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password.Focus();
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login.Focus();
            }
        }






    }
}
