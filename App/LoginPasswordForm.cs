using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Repository;
using Entity;
using System.Data.SqlClient;

namespace App
{
    public partial class LoginPasswordForm : Form
    {
        Login l;
        LoginRepo lr;
        public LoginPasswordForm(Login l)
        {
            InitializeComponent();
            this.l = l;
            UserIdLabel.Text += l.Id;

        }

        private void LoginPasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CofirmBTN_Click(object sender, EventArgs e)
        {
            LoginRepo lr = new LoginRepo();
            UserIdLabel.Text=l.Id;
            string password = ExistingPasswordTB.Text;

            Login l2  = lr.GetUser(l.Id, password);

            if (l2 != null)
            {
                l.Password = this.NewPasswordTB.Text;

                if (lr.UpdateUser(l))
                {
                    MessageBox.Show("Updated");
                }
                else
                {
                    MessageBox.Show("Can NOT Update");
                }
            }
            else
            {
                MessageBox.Show("Invalid User");
            }
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Visible = true;
            this.Visible = false;
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage(l);
            this.Visible = false;
            hp.Visible = true;
        }
    }
}
