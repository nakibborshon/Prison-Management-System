using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entity;
using Repository;

namespace App
{
    public partial class ManageVisitorForm : Form
    {
        Login l;
        VisitorRepo vr;
        LoginRepo lr;
        public ManageVisitorForm(Login l)
        {
            InitializeComponent();
            this.vr = new VisitorRepo();
            this.l = l;
            this.lr = new LoginRepo();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            string VisitorName = this.VisitorNameTB.Text;

            Visitor v = vr.GetVisitor(VisitorName);

            if (v == null)
            {
                MessageBox.Show("Invalid ID");
            }
            else
            {
                this.VisitorNameTB.Text = v.VisitorName.ToString();
                this.VisitedPrisonerIdTB.Text = v.VisitedPrisonerId.ToString();
                this.CounterNoTB.Text = v.CounterNo;
                this.VisitedDurationTB.Text = v.VisitedDuration.ToString();

                this.RefreshBtn.Enabled = true;
                this.LoadBtn.Enabled = false;
                this.InsertBtn.Enabled = false;
                this.UpdateBtn.Enabled = true;
                this.DeleteBtn.Enabled = true;

                this.VisitorNameTB.Enabled = false;
            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            Visitor v = new Visitor();
            VisitorRepo vr = new VisitorRepo();
            try
            {
                if (VisitorNameTB.Text != "" && VisitedPrisonerIdTB.Text != "" && CounterNoTB.Text != "" && VisitedDurationTB.Text != "")
                {
                    v.VisitorName = this.VisitorNameTB.Text;
                    v.VisitedPrisonerId = this.VisitedPrisonerIdTB.Text;
                    v.VisitedDuration = Convert.ToDouble(this.VisitedDurationTB.Text);
                    v.CounterNo = this.CounterNoTB.Text;
                    if (!vr.InsertVisitor(v))
                    MessageBox.Show("Duplication Occured");
                    this.RefreshBtn_Click(sender, e);
                    this.ViewAllBtn_Click(sender, e);
                }
                else
                {
                    this.ViewAllBtn_Click(sender, e);
                    MessageBox.Show("Insert All Information");
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show("Invalid Data");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Visitor v = new Visitor();
            v.VisitorName = this.VisitorNameTB.Text;
            v.VisitedPrisonerId = this.VisitedPrisonerIdTB.Text;
            v.VisitedDuration = Convert.ToDouble(this.VisitedDurationTB.Text);
            v.CounterNo = this.CounterNoTB.Text;

            if (vr.UpdateVisitor(v))
            {
                MessageBox.Show("Updated");
                this.ViewAllBtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Can NOT Update");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Login user = new Login();


            Visitor v = new Visitor();
            v.VisitorName = this.VisitorNameTB.Text;

            if (lr.DeleteUser(user))
            {
                if (vr.DeleteVisitor(v))
                {
                    MessageBox.Show("Visitor Removed");
                    this.RefreshBtn_Click(sender, e);
                    this.ViewAllBtn_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Can Not Remove");
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.VisitorNameTB.Text = "";
            this.VisitedPrisonerIdTB.Text = "";
            this.CounterNoTB.Text = "";
            this.VisitedDurationTB.Text = "";


            this.RefreshBtn.Enabled = false;
            this.LoadBtn.Enabled = true;
            this.InsertBtn.Enabled = true;
            this.UpdateBtn.Enabled = false;
            this.DeleteBtn.Enabled = false;

            this.VisitorNameTB.Enabled = true;
        }

        private void ViewAllBtn_Click(object sender, EventArgs e)
        {
            List<Visitor> listofVisitor = vr.GetAllVisitors();
            VisitorTable.DataSource = listofVisitor;
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            List<Visitor> listOfCell = vr.GetAllVisitors();
            String keyword = this.SearchBox.Text;
            List<Visitor> searchedCell = listOfCell.FindAll(x => (x.VisitorName.ToLower()).Contains(keyword.ToLower()) || (x.VisitedPrisonerId.ToLower()).Contains(keyword.ToLower()) || (x.CounterNo.ToLower()).Contains(keyword.ToLower()) || (x.VisitedDuration.ToString().ToLower()).Contains(keyword.ToLower()));
            VisitorTable.DataSource = searchedCell;
        }

        private void VisitorTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.VisitorNameTB.Text = VisitorTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.VisitedPrisonerIdTB.Text = VisitorTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.CounterNoTB.Text = VisitorTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.VisitedDurationTB.Text = VisitorTable.Rows[e.RowIndex].Cells[3].Value.ToString();

            this.RefreshBtn.Enabled = true;
            this.LoadBtn.Enabled = false;
            this.InsertBtn.Enabled = false;
            this.UpdateBtn.Enabled = true;
            this.DeleteBtn.Enabled = true;

            this.VisitorNameTB.Enabled = false;
        }

        private void VisitedDurationTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Visible = true;
            this.Visible = false;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage(l);
            hp.Visible = true;
            this.Visible = false;
        }

        private void ManageVisitorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
