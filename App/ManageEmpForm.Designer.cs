namespace App
{
    partial class ManageEmpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmpIdLabel = new System.Windows.Forms.Label();
            this.EmpNameLabel = new System.Windows.Forms.Label();
            this.EmpPhnLabel = new System.Windows.Forms.Label();
            this.EmpSalaryLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EmpIdTB = new System.Windows.Forms.TextBox();
            this.EmpNameTB = new System.Windows.Forms.TextBox();
            this.EmpPhnNumberTB1 = new System.Windows.Forms.TextBox();
            this.EmpSalaryTB = new System.Windows.Forms.TextBox();
            this.EmpDesignationTB = new System.Windows.Forms.TextBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.ViewAllBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.EmployeeTable = new System.Windows.Forms.DataGridView();
            this.EmpPhnNumberTB2 = new System.Windows.Forms.TextBox();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpIdLabel
            // 
            this.EmpIdLabel.AutoSize = true;
            this.EmpIdLabel.Location = new System.Drawing.Point(46, 132);
            this.EmpIdLabel.Name = "EmpIdLabel";
            this.EmpIdLabel.Size = new System.Drawing.Size(66, 13);
            this.EmpIdLabel.TabIndex = 0;
            this.EmpIdLabel.Text = "User Name :";
            // 
            // EmpNameLabel
            // 
            this.EmpNameLabel.AutoSize = true;
            this.EmpNameLabel.Location = new System.Drawing.Point(46, 166);
            this.EmpNameLabel.Name = "EmpNameLabel";
            this.EmpNameLabel.Size = new System.Drawing.Size(90, 13);
            this.EmpNameLabel.TabIndex = 1;
            this.EmpNameLabel.Text = "Employee Name :";
            // 
            // EmpPhnLabel
            // 
            this.EmpPhnLabel.AutoSize = true;
            this.EmpPhnLabel.Location = new System.Drawing.Point(46, 201);
            this.EmpPhnLabel.Name = "EmpPhnLabel";
            this.EmpPhnLabel.Size = new System.Drawing.Size(121, 13);
            this.EmpPhnLabel.TabIndex = 2;
            this.EmpPhnLabel.Text = "Employee Phn Number :";
            // 
            // EmpSalaryLabel
            // 
            this.EmpSalaryLabel.AutoSize = true;
            this.EmpSalaryLabel.Location = new System.Drawing.Point(46, 237);
            this.EmpSalaryLabel.Name = "EmpSalaryLabel";
            this.EmpSalaryLabel.Size = new System.Drawing.Size(91, 13);
            this.EmpSalaryLabel.TabIndex = 3;
            this.EmpSalaryLabel.Text = "Employee Salary :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Employee Designation :";
            // 
            // EmpIdTB
            // 
            this.EmpIdTB.Location = new System.Drawing.Point(174, 132);
            this.EmpIdTB.Name = "EmpIdTB";
            this.EmpIdTB.Size = new System.Drawing.Size(198, 20);
            this.EmpIdTB.TabIndex = 5;
            // 
            // EmpNameTB
            // 
            this.EmpNameTB.Location = new System.Drawing.Point(174, 163);
            this.EmpNameTB.Name = "EmpNameTB";
            this.EmpNameTB.Size = new System.Drawing.Size(198, 20);
            this.EmpNameTB.TabIndex = 6;
            // 
            // EmpPhnNumberTB1
            // 
            this.EmpPhnNumberTB1.Enabled = false;
            this.EmpPhnNumberTB1.Location = new System.Drawing.Point(174, 198);
            this.EmpPhnNumberTB1.Name = "EmpPhnNumberTB1";
            this.EmpPhnNumberTB1.Size = new System.Drawing.Size(36, 20);
            this.EmpPhnNumberTB1.TabIndex = 7;
            this.EmpPhnNumberTB1.Text = "+880";
            // 
            // EmpSalaryTB
            // 
            this.EmpSalaryTB.Location = new System.Drawing.Point(174, 230);
            this.EmpSalaryTB.Name = "EmpSalaryTB";
            this.EmpSalaryTB.Size = new System.Drawing.Size(198, 20);
            this.EmpSalaryTB.TabIndex = 8;
            this.EmpSalaryTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmpSalaryTB_KeyPress);
            // 
            // EmpDesignationTB
            // 
            this.EmpDesignationTB.Location = new System.Drawing.Point(174, 266);
            this.EmpDesignationTB.Name = "EmpDesignationTB";
            this.EmpDesignationTB.Size = new System.Drawing.Size(198, 20);
            this.EmpDesignationTB.TabIndex = 9;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(488, 313);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(281, 20);
            this.SearchBox.TabIndex = 10;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBoxValueChange);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(49, 311);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadBtn.TabIndex = 11;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.Location = new System.Drawing.Point(135, 311);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(75, 23);
            this.InsertBtn.TabIndex = 12;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Enabled = false;
            this.UpdateBtn.Location = new System.Drawing.Point(216, 311);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 13;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Enabled = false;
            this.DeleteBtn.Location = new System.Drawing.Point(297, 311);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 14;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Enabled = false;
            this.RefreshBtn.Location = new System.Drawing.Point(49, 86);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(323, 23);
            this.RefreshBtn.TabIndex = 15;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // ViewAllBtn
            // 
            this.ViewAllBtn.Location = new System.Drawing.Point(403, 86);
            this.ViewAllBtn.Name = "ViewAllBtn";
            this.ViewAllBtn.Size = new System.Drawing.Size(366, 23);
            this.ViewAllBtn.TabIndex = 16;
            this.ViewAllBtn.Text = "View All Employees";
            this.ViewAllBtn.UseVisualStyleBackColor = true;
            this.ViewAllBtn.Click += new System.EventHandler(this.ViewAllBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Search Here :";
            // 
            // EmployeeTable
            // 
            this.EmployeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeTable.Location = new System.Drawing.Point(403, 115);
            this.EmployeeTable.Name = "EmployeeTable";
            this.EmployeeTable.ReadOnly = true;
            this.EmployeeTable.Size = new System.Drawing.Size(366, 175);
            this.EmployeeTable.TabIndex = 20;
            this.EmployeeTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnTableCellClick);
            // 
            // EmpPhnNumberTB2
            // 
            this.EmpPhnNumberTB2.Location = new System.Drawing.Point(214, 198);
            this.EmpPhnNumberTB2.MaxLength = 10;
            this.EmpPhnNumberTB2.Name = "EmpPhnNumberTB2";
            this.EmpPhnNumberTB2.Size = new System.Drawing.Size(158, 20);
            this.EmpPhnNumberTB2.TabIndex = 21;
            this.EmpPhnNumberTB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmpPhnNumberTB2_KeyPress);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Image = global::App.Properties.Resources.logout_icon2;
            this.LogoutBtn.Location = new System.Drawing.Point(691, 12);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(78, 36);
            this.LogoutBtn.TabIndex = 18;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Image = global::App.Properties.Resources.Go_back_icon1;
            this.BackBtn.Location = new System.Drawing.Point(27, 12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(78, 36);
            this.BackBtn.TabIndex = 17;
            this.BackBtn.Text = "Back";
            this.BackBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ManageEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App.Properties.Resources.WhatsApp_Image_2019_12_22_at_7_493;
            this.ClientSize = new System.Drawing.Size(801, 388);
            this.Controls.Add(this.EmpPhnNumberTB2);
            this.Controls.Add(this.EmployeeTable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ViewAllBtn);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.EmpDesignationTB);
            this.Controls.Add(this.EmpSalaryTB);
            this.Controls.Add(this.EmpPhnNumberTB1);
            this.Controls.Add(this.EmpNameTB);
            this.Controls.Add(this.EmpIdTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmpSalaryLabel);
            this.Controls.Add(this.EmpPhnLabel);
            this.Controls.Add(this.EmpNameLabel);
            this.Controls.Add(this.EmpIdLabel);
            this.Name = "ManageEmpForm";
            this.Text = "ManageEmpForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClose);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmpIdLabel;
        private System.Windows.Forms.Label EmpNameLabel;
        private System.Windows.Forms.Label EmpPhnLabel;
        private System.Windows.Forms.Label EmpSalaryLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmpIdTB;
        private System.Windows.Forms.TextBox EmpNameTB;
        private System.Windows.Forms.TextBox EmpPhnNumberTB1;
        private System.Windows.Forms.TextBox EmpSalaryTB;
        private System.Windows.Forms.TextBox EmpDesignationTB;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button ViewAllBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView EmployeeTable;
        private System.Windows.Forms.TextBox EmpPhnNumberTB2;
    }
}