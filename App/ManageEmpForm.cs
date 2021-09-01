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
    public partial class ManageEmpForm : Form
    {
        Login l;
        EmployeeRepo er;
        LoginRepo lr;
        
        public ManageEmpForm(Login l)
        {
            InitializeComponent();
            this.er = new EmployeeRepo();
            this.l = l;
            this.lr = new LoginRepo();

        }

        private void ViewAllBtn_Click(object sender, EventArgs e)
        {
            List<Employee> listofEmployee = er.GetAllEmployees();
            EmployeeTable.DataSource = listofEmployee;

        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            string empId = this.EmpIdTB.Text;
            Employee emp = er.GetEmployee(empId);

            if (emp == null)
            {
                MessageBox.Show("Invalid ID");
            }
            else
            {
                this.EmpNameTB.Text = emp.Name;
                this.EmpPhnNumberTB2.Text = emp.PhnNumber.Substring(4);
                this.EmpSalaryTB.Text = emp.Salary + "";
                this.EmpDesignationTB.Text = emp.Designation;

                this.RefreshBtn.Enabled = true;
                this.LoadBtn.Enabled = false;
                this.InsertBtn.Enabled = false;
                this.UpdateBtn.Enabled = true;
                this.DeleteBtn.Enabled = true;

                this.EmpIdTB.Enabled = false;
            }

           
           
        }

        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            Login user = new Login();
            Employee emp = new Employee();

            int p = new Random().Next(9999)+1000;
            user.Id = this.EmpIdTB.Text;
            user.Password = p + "";

            emp.EmpId = this.EmpIdTB.Text;
            emp.Name = this.EmpNameTB.Text;
            try
            {
                int i = Convert.ToInt32(this.EmpPhnNumberTB2.Text);
                emp.PhnNumber = this.EmpPhnNumberTB1.Text + this.EmpPhnNumberTB2.Text;
                double sal = Convert.ToDouble(this.EmpSalaryTB.Text);
                emp.Salary = sal;
                emp.Designation = this.EmpDesignationTB.Text;

                if ((emp.Designation.ToLower()).Equals("admin"))
                {
                    user.Role = 0;
                }
                else
                {
                    user.Role = 1;
                }

                if (lr.InsertUser(user))
                {
                    if (er.InsertEmployee(emp))
                    {
                        MessageBox.Show("Employee Added with Id: "+user.Id+ " & Password: "+user.Password);
                        this.RefreshBtn_Click(sender, e);
                        this.ViewAllBtn_Click(sender, e);

                    }
                }
                else
                {
                    this.ViewAllBtn_Click(sender, e);
                    MessageBox.Show("Can Not Add"+ user.Id);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Invalid Data"+exp.StackTrace);
                
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.EmpIdTB.Text = "";
            this.EmpNameTB.Text = "";
            this.EmpPhnNumberTB2.Text = "";
            this.EmpSalaryTB.Text = "";
            this.EmpDesignationTB.Text = "";


            this.RefreshBtn.Enabled = false;
            this.LoadBtn.Enabled = true;
            this.InsertBtn.Enabled = true;
            this.UpdateBtn.Enabled = false;
            this.DeleteBtn.Enabled = false;
            
            this.EmpIdTB.Enabled = true;


        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Login user = new Login();
            user.Id = this.EmpIdTB.Text;

            Employee emp = new Employee();
            emp.EmpId = this.EmpIdTB.Text;

            if (lr.DeleteUser(user))
            {
                if (er.DeleteEmployee(emp))
                {
                    MessageBox.Show("Employee Removed");
                    this.RefreshBtn_Click(sender, e);
                    this.ViewAllBtn_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Can Not Remove");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmpId = this.EmpIdTB.Text;
            emp.Name = this.EmpNameTB.Text;
            emp.PhnNumber = this.EmpPhnNumberTB1.Text + this.EmpPhnNumberTB2.Text;
            emp.Salary = Convert.ToDouble(this.EmpSalaryTB.Text);
            emp.Designation = this.EmpDesignationTB.Text;

            if (er.UpdateEmployee(emp))
            {
                MessageBox.Show("Updated");
                this.ViewAllBtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Can NOT Update");
            }
        }

        private void OnTableCellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.EmpIdTB.Text = EmployeeTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.EmpNameTB.Text = EmployeeTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.EmpPhnNumberTB2.Text = (EmployeeTable.Rows[e.RowIndex].Cells[2].Value.ToString()).Substring(4);
            this.EmpSalaryTB.Text = EmployeeTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.EmpDesignationTB.Text = EmployeeTable.Rows[e.RowIndex].Cells[4].Value.ToString();

            this.RefreshBtn.Enabled = true;
            this.LoadBtn.Enabled = false;
            this.InsertBtn.Enabled = false;
            this.UpdateBtn.Enabled = true;
            this.DeleteBtn.Enabled = true;

            this.EmpIdTB.Enabled = false;
        }

        private void SearchBoxValueChange(object sender, EventArgs e)
        {
            List<Employee> listOfEmployee = er.GetAllEmployees();
            String keyword = this.SearchBox.Text;
            List<Employee> searchedEmployee = listOfEmployee.FindAll(x => (x.EmpId.ToLower()).Contains(keyword.ToLower()) || (x.Name.ToLower()).Contains(keyword.ToLower()) || (x.PhnNumber.ToLower()).Contains(keyword.ToLower()) || (x.Designation.ToLower()).Contains(keyword.ToLower()) || (x.Salary.ToString().ToLower()).Contains(keyword.ToLower()));
            EmployeeTable.DataSource = searchedEmployee;
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

        private void EmpPhnNumberTB2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar)&&(!char.IsControl(e.KeyChar)))
            e.Handled = true;
        }

        private void EmpSalaryTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
                e.Handled = true;
        }
   }
}
