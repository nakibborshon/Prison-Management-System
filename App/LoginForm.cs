using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginRepo lr = new LoginRepo();
            string id = UserTB.Text;
            string password = PassTB.Text;

            Login l = lr.GetUser(id, password);

            if (l != null)
            {
                HomePage hp = new HomePage(l);
                this.Visible = false;
                hp.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid User");
            }

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PassTB.UseSystemPasswordChar = false;
            }
            else
            {
                PassTB.UseSystemPasswordChar = true;
            }

        }
    }
}
