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
    public partial class ManageCellForm : Form
    {
        Login l;
        CellRepo cr;
        LoginRepo lr;
        public ManageCellForm(Login l)
        {
            InitializeComponent();
            this.cr = new CellRepo();
            this.l = l;
            this.lr = new LoginRepo();
        }

        private void ManageCellFormcs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            string CellNo = this.CellNoTB.Text;

            Cell c = cr.GetCell(CellNo);

            if (c == null)
            {
                MessageBox.Show("Invalid ID");
            }
            else
            {
                this.CellCapacityTB.Text = c.CellCapacity.ToString();
                this.NumberOfPrisonerTB.Text = c.NumberOfPrisoners.ToString();
                this.GuardIdTB.Text = c.GuardId;
                this.GuardNameTB.Text = c.GuardName;

                this.RefreshBtn.Enabled = true;
                this.LoadBtn.Enabled = false;
                this.InsertBtn.Enabled = false;
                this.UpdateBtn.Enabled = true;
                this.DeleteBtn.Enabled = true;

                this.CellNoTB.Enabled = false;
        }


        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            //Login user = new Login();
            Cell c = new Cell();
            CellRepo cr = new CellRepo();
            try
            {
                if (CellNoTB.Text != "" && GuardNameTB.Text != "" && CellCapacityTB.Text != "" && NumberOfPrisonerTB.Text != "" && GuardIdTB.Text != "")
                {
                    c.CellNo = this.CellNoTB.Text;
                    c.CellCapacity = Convert.ToInt32(this.CellCapacityTB.Text);
                    c.NumberOfPrisoners = Convert.ToInt32(this.NumberOfPrisonerTB.Text);
                    c.GuardId = this.GuardIdTB.Text;
                    c.GuardName = this.GuardNameTB.Text;
                    if (!cr.InsertCell(c))

                        MessageBox.Show("CellNo Already Exists!!!");
                    
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
            Cell c = new Cell();
            c.CellNo = this.CellNoTB.Text;
            c.CellCapacity = Convert.ToInt32(this.CellCapacityTB.Text);
            c.NumberOfPrisoners = Convert.ToInt32(this.NumberOfPrisonerTB.Text);
            c.GuardId = this.GuardIdTB.Text;
            c.GuardName = this.GuardNameTB.Text;

            if (cr.UpdateCell(c))
            {
                MessageBox.Show("Updated");
                this.ViewAllBtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Can NOT Update");
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.CellNoTB.Text = "";
            this.CellCapacityTB.Text = "";
            this.NumberOfPrisonerTB.Text = "";
            this.GuardIdTB.Text = "";
            this.GuardNameTB.Text = "";


            this.RefreshBtn.Enabled = false;
            this.LoadBtn.Enabled = true;
            this.InsertBtn.Enabled = true;
            this.UpdateBtn.Enabled = false;
            this.DeleteBtn.Enabled = false;

            this.CellNoTB.Enabled = true;
        }

        private void ViewAllBtn_Click(object sender, EventArgs e)
        {
            List<Cell> listofCell = cr.GetAllCells();
            CellTable.DataSource = listofCell;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Login user = new Login();


            Cell c = new Cell();
           c.CellNo = this.CellNoTB.Text;

            if (lr.DeleteUser(user))
            {
                if (cr.DeleteCell(c))
                {
                    MessageBox.Show("Cell Removed");
                    this.RefreshBtn_Click(sender, e);
                    this.ViewAllBtn_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Can Not Remove");
            }
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

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            List<Cell> listOfCell = cr.GetAllCells();
            String keyword = this.SearchBox.Text;
            List<Cell> searchedCell = listOfCell.FindAll(x => (x.CellNo.ToLower()).Contains(keyword.ToLower()) || (x.GuardId.ToLower()).Contains(keyword.ToLower()) || (x.GuardName.ToLower()).Contains(keyword.ToLower()) || (x.CellCapacity.ToString().ToLower()).Contains(keyword.ToLower()) || (x.NumberOfPrisoners.ToString().ToLower()).Contains(keyword.ToLower()));
            CellTable.DataSource = searchedCell;
        }

        private void PrisonerTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.CellNoTB.Text = CellTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.CellCapacityTB.Text = CellTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.NumberOfPrisonerTB.Text = CellTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.GuardIdTB.Text = CellTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.GuardNameTB.Text = CellTable.Rows[e.RowIndex].Cells[4].Value.ToString();

            this.RefreshBtn.Enabled = true;
            this.LoadBtn.Enabled = false;
            this.InsertBtn.Enabled = false;
            this.UpdateBtn.Enabled = true;
            this.DeleteBtn.Enabled = true;

            this.CellNoTB.Enabled = false;
        }

        public object searchedCell { get; set; }

        private void CellCapacityTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void NumberOfPrisonerTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

    }
}
