using Entity;
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
    public partial class HomePage : Form
    {
        internal Login l;

        public HomePage(Login l)
        {
            InitializeComponent();
            this.l = l;
            WelcomeLabel.Text += l.Id;
        }

        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ManageEmpBtn_Click(object sender, EventArgs e)
        {
            if (l.Role == 0)
            {
                ManageEmpForm mef = new ManageEmpForm(l);
                this.Visible = false;
                mef.Visible = true;
            }
            else
            {
                MessageBox.Show("Access Denied");
            }

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Visible = false;
            lf.Visible = true;
        }

        private void PrisonerManagementBtn_Click(object sender, EventArgs e)
        {
            if (l.Role == 0)
            {
                ManagePrisonerForm mpf = new ManagePrisonerForm(l);
                this.Visible = false;
                mpf.Visible = true;
            }
            else
            {
                MessageBox.Show("Access Denied");
            }
        }

        private void CellManagementBtn_Click(object sender, EventArgs e)
        {
            ManageCellForm mcf = new ManageCellForm(l);
            this.Visible = false;
            mcf.Visible = true;
        }

        private void ChangePasswordBTN_Click(object sender, EventArgs e)
        {
            LoginPasswordForm lpf = new LoginPasswordForm(l);
            this.Visible = false;
            lpf.Visible = true;
        }

        private void VisitorManagementBTN_Click(object sender, EventArgs e)
        {
            ManageVisitorForm mvf = new ManageVisitorForm(l);
            this.Visible = false;
            mvf.Visible = true;
        }

        }

    }

