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
    public partial class ManagePrisonerForm : Form
    {
        Login l;
        PrisonerRepo pr;
        LoginRepo lr;
        CellRepo cr;
        public ManagePrisonerForm(Login l)
        {
            InitializeComponent();
            this.pr = new PrisonerRepo();
            this.l = l;
            this.lr = new LoginRepo();
        }

        private void ManagePrisonerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            string PrisonerId = this.PrisonerIdTB.Text;
            Prisoner p = pr.GetPriosner(PrisonerId);

            if (p == null)
            {
                MessageBox.Show("Invalid ID");
            }
            else
            {
                this.PrisonerNameTB.Text = p.PrisonerName;
                this.AddressTB.Text = p.Address;
                this.CrimeTB.Text = p.Crime;
                this.PunishmentTB.Text = p.Punishment;
                this.CellNoTB.Text = p.CellNo;

                this.RefreshBtn.Enabled = true;
                this.LoadBtn.Enabled = false;
                this.InsertBtn.Enabled = false;
                this.UpdateBtn.Enabled = true;
                this.DeleteBtn.Enabled = true;

                this.PrisonerIdTB.Enabled = false;
            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
           //Login user = new Login();
            Prisoner p = new Prisoner();
            PrisonerRepo  pr= new PrisonerRepo();
            cr = new CellRepo();
            Cell c=new Cell();
            try
            {
                if (PrisonerIdTB.Text != "" && PrisonerNameTB.Text != "" && AddressTB.Text != "" && CrimeTB.Text != "" && PunishmentTB.Text != "" && CellNoTB.Text != "")
                {

                    p.PrisonerId = this.PrisonerIdTB.Text;
                    p.PrisonerName = this.PrisonerNameTB.Text;
                    p.Address = this.AddressTB.Text;
                    p.Crime = this.CrimeTB.Text;
                    p.Punishment = this.PunishmentTB.Text;
                    p.CellNo = this.CellNoTB.Text;

                    c = cr.GetCell(this.CellNoTB.Text);

                    if (c.NumberOfPrisoners <= c.CellCapacity)
                    {
                        if (pr.InsertPrisoner(p))
                        {


                            c.NumberOfPrisoners = c.NumberOfPrisoners + 1;


                            if (cr.UpdateCell(c))
                            {
                                MessageBox.Show("Updated");
                                this.ViewAllBtn_Click(sender, e);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Id Already Exists");
                        }


                        this.RefreshBtn_Click(sender, e);
                        this.ViewAllBtn_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Insert All Information");
                    }
                     
                }
                else
                {
                    MessageBox.Show("capacity Full");
                }


            }
            catch (Exception exp)
            {
                MessageBox.Show("Invalid Data");
            }
        }
        

        private Cell GetCell(string cellNo)
        {
            throw new NotImplementedException();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.PrisonerIdTB.Text = "";
            this.PrisonerNameTB.Text = "";
            this.AddressTB.Text = "";
            this.CrimeTB.Text = "";
            this.PunishmentTB.Text = "";
            this.CellNoTB.Text = "";


            this.RefreshBtn.Enabled = false;
            this.LoadBtn.Enabled = true;
            this.InsertBtn.Enabled = true;
            this.UpdateBtn.Enabled = false;
            this.DeleteBtn.Enabled = false;

            this.PrisonerIdTB.Enabled = true;

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Prisoner p = new Prisoner();
            p.PrisonerId = this.PrisonerIdTB.Text;
            p.PrisonerName = this.PrisonerNameTB.Text;
            p.Address = this.AddressTB.Text;
            p.Crime = this.CrimeTB.Text;
            p.Punishment = this.PunishmentTB.Text;
            p.CellNo=this.CellNoTB.Text;

            if (pr.UpdatePrisoner(p))
            {
                MessageBox.Show("Updated");
                this.ViewAllBtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Can NOT Update");
            }
        }

        private void ViewAllBtn_Click(object sender, EventArgs e)
        {
            List<Prisoner> listofPrisoner = pr.GetAllPrisoners();
            PrisonerTable.DataSource = listofPrisoner;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Login user = new Login();
           // user.Id = this.EmpIdTB.Text;

            Prisoner p = new Prisoner();
            p.PrisonerId = this.PrisonerIdTB.Text;

            if (lr.DeleteUser(user))
            {
                if (pr.DeletePrisoner(p))
                {
                    MessageBox.Show("Prisoner Removed");
                    this.RefreshBtn_Click(sender, e);
                    this.ViewAllBtn_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Can Not Remove");
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage(l);
            hp.Visible = true;
            this.Visible = false;
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Visible = true;
            this.Visible = false;
        }
        private void SearchBoxValueChange(object sender, EventArgs e)
        {
            List<Prisoner> listOfPrisoner = pr.GetAllPrisoners();
            String keyword = this.SearchBox.Text;
            List<Prisoner> searchedPrisoner = listOfPrisoner.FindAll(x => (x.PrisonerId.ToLower()).Contains(keyword.ToLower()) || (x.PrisonerName.ToLower()).Contains(keyword.ToLower()) || (x.Address.ToLower()).Contains(keyword.ToLower()) || (x.Crime.ToLower()).Contains(keyword.ToLower()) || (x.Punishment.ToLower()).Contains(keyword.ToLower()) || (x.CellNo.ToLower()).Contains(keyword.ToLower()));
            PrisonerTable.DataSource = searchedPrisoner;
        }

        private void PrisonerTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.PrisonerIdTB.Text = PrisonerTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.PrisonerNameTB.Text = PrisonerTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.AddressTB.Text = PrisonerTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.CrimeTB.Text = PrisonerTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.PunishmentTB.Text = PrisonerTable.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.CellNoTB.Text = PrisonerTable.Rows[e.RowIndex].Cells[4].Value.ToString();

            this.RefreshBtn.Enabled = true;
            this.LoadBtn.Enabled = false;
            this.InsertBtn.Enabled = false;
            this.UpdateBtn.Enabled = true;
            this.DeleteBtn.Enabled = true;

            this.PrisonerIdTB.Enabled = false;
        }

        public string cellNo { get; set; }
    }
}
