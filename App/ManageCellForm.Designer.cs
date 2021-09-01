namespace App
{
    partial class ManageCellForm
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
            this.CellTable = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.ViewAllBtn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.GuardNameTB = new System.Windows.Forms.TextBox();
            this.GuardIdTB = new System.Windows.Forms.TextBox();
            this.NumberOfPrisonerTB = new System.Windows.Forms.TextBox();
            this.CellCapacityTB = new System.Windows.Forms.TextBox();
            this.CellNoTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmpSalaryLabel = new System.Windows.Forms.Label();
            this.EmpPhnLabel = new System.Windows.Forms.Label();
            this.EmpNameLabel = new System.Windows.Forms.Label();
            this.EmpIdLabel = new System.Windows.Forms.Label();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CellTable)).BeginInit();
            this.SuspendLayout();
            // 
            // CellTable
            // 
            this.CellTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CellTable.Location = new System.Drawing.Point(403, 125);
            this.CellTable.Name = "CellTable";
            this.CellTable.ReadOnly = true;
            this.CellTable.Size = new System.Drawing.Size(366, 175);
            this.CellTable.TabIndex = 62;
            this.CellTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrisonerTable_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Search Here :";
            // 
            // ViewAllBtn
            // 
            this.ViewAllBtn.Location = new System.Drawing.Point(403, 96);
            this.ViewAllBtn.Name = "ViewAllBtn";
            this.ViewAllBtn.Size = new System.Drawing.Size(366, 23);
            this.ViewAllBtn.TabIndex = 59;
            this.ViewAllBtn.Text = "View All Cells";
            this.ViewAllBtn.UseVisualStyleBackColor = true;
            this.ViewAllBtn.Click += new System.EventHandler(this.ViewAllBtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(488, 323);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(281, 20);
            this.SearchBox.TabIndex = 58;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Enabled = false;
            this.DeleteBtn.Location = new System.Drawing.Point(280, 321);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 57;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Enabled = false;
            this.UpdateBtn.Location = new System.Drawing.Point(199, 321);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 56;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.Location = new System.Drawing.Point(118, 321);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(75, 23);
            this.InsertBtn.TabIndex = 55;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(37, 321);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadBtn.TabIndex = 54;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // GuardNameTB
            // 
            this.GuardNameTB.Location = new System.Drawing.Point(157, 248);
            this.GuardNameTB.Name = "GuardNameTB";
            this.GuardNameTB.Size = new System.Drawing.Size(198, 20);
            this.GuardNameTB.TabIndex = 53;
            // 
            // GuardIdTB
            // 
            this.GuardIdTB.Location = new System.Drawing.Point(157, 222);
            this.GuardIdTB.Name = "GuardIdTB";
            this.GuardIdTB.Size = new System.Drawing.Size(198, 20);
            this.GuardIdTB.TabIndex = 52;
            // 
            // NumberOfPrisonerTB
            // 
            this.NumberOfPrisonerTB.Location = new System.Drawing.Point(157, 196);
            this.NumberOfPrisonerTB.Name = "NumberOfPrisonerTB";
            this.NumberOfPrisonerTB.Size = new System.Drawing.Size(198, 20);
            this.NumberOfPrisonerTB.TabIndex = 51;
            this.NumberOfPrisonerTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOfPrisonerTB_KeyPress);
            // 
            // CellCapacityTB
            // 
            this.CellCapacityTB.Location = new System.Drawing.Point(157, 170);
            this.CellCapacityTB.Name = "CellCapacityTB";
            this.CellCapacityTB.Size = new System.Drawing.Size(198, 20);
            this.CellCapacityTB.TabIndex = 50;
            this.CellCapacityTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CellCapacityTB_KeyPress);
            // 
            // CellNoTB
            // 
            this.CellNoTB.Location = new System.Drawing.Point(157, 142);
            this.CellNoTB.Name = "CellNoTB";
            this.CellNoTB.Size = new System.Drawing.Size(198, 20);
            this.CellNoTB.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Guard Name:";
            // 
            // EmpSalaryLabel
            // 
            this.EmpSalaryLabel.AutoSize = true;
            this.EmpSalaryLabel.Location = new System.Drawing.Point(45, 225);
            this.EmpSalaryLabel.Name = "EmpSalaryLabel";
            this.EmpSalaryLabel.Size = new System.Drawing.Size(51, 13);
            this.EmpSalaryLabel.TabIndex = 47;
            this.EmpSalaryLabel.Text = "Guard Id:";
            // 
            // EmpPhnLabel
            // 
            this.EmpPhnLabel.AutoSize = true;
            this.EmpPhnLabel.Location = new System.Drawing.Point(45, 199);
            this.EmpPhnLabel.Name = "EmpPhnLabel";
            this.EmpPhnLabel.Size = new System.Drawing.Size(102, 13);
            this.EmpPhnLabel.TabIndex = 46;
            this.EmpPhnLabel.Text = "Number Of Prisoner:";
            // 
            // EmpNameLabel
            // 
            this.EmpNameLabel.AutoSize = true;
            this.EmpNameLabel.Location = new System.Drawing.Point(45, 173);
            this.EmpNameLabel.Name = "EmpNameLabel";
            this.EmpNameLabel.Size = new System.Drawing.Size(71, 13);
            this.EmpNameLabel.TabIndex = 45;
            this.EmpNameLabel.Text = "Cell Capacity:";
            // 
            // EmpIdLabel
            // 
            this.EmpIdLabel.AutoSize = true;
            this.EmpIdLabel.Location = new System.Drawing.Point(45, 145);
            this.EmpIdLabel.Name = "EmpIdLabel";
            this.EmpIdLabel.Size = new System.Drawing.Size(47, 13);
            this.EmpIdLabel.TabIndex = 44;
            this.EmpIdLabel.Text = "Cell No :";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Enabled = false;
            this.RefreshBtn.Location = new System.Drawing.Point(37, 96);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(323, 23);
            this.RefreshBtn.TabIndex = 43;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Image = global::App.Properties.Resources.Go_back_icon2;
            this.BackBtn.Location = new System.Drawing.Point(20, 29);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(82, 35);
            this.BackBtn.TabIndex = 63;
            this.BackBtn.Text = "Back";
            this.BackBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Image = global::App.Properties.Resources.logout_icon5;
            this.LogoutBtn.Location = new System.Drawing.Point(685, 41);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(81, 35);
            this.LogoutBtn.TabIndex = 60;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // ManageCellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App.Properties.Resources.WhatsApp_Image_2019_12_22_at_7_492;
            this.ClientSize = new System.Drawing.Size(801, 392);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.CellTable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.ViewAllBtn);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.GuardNameTB);
            this.Controls.Add(this.GuardIdTB);
            this.Controls.Add(this.NumberOfPrisonerTB);
            this.Controls.Add(this.CellCapacityTB);
            this.Controls.Add(this.CellNoTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmpSalaryLabel);
            this.Controls.Add(this.EmpPhnLabel);
            this.Controls.Add(this.EmpNameLabel);
            this.Controls.Add(this.EmpIdLabel);
            this.Controls.Add(this.RefreshBtn);
            this.Name = "ManageCellForm";
            this.Text = "ManageCellFormcs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageCellFormcs_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.CellTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridView CellTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button ViewAllBtn;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.TextBox GuardNameTB;
        private System.Windows.Forms.TextBox GuardIdTB;
        private System.Windows.Forms.TextBox NumberOfPrisonerTB;
        private System.Windows.Forms.TextBox CellCapacityTB;
        private System.Windows.Forms.TextBox CellNoTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label EmpSalaryLabel;
        private System.Windows.Forms.Label EmpPhnLabel;
        private System.Windows.Forms.Label EmpNameLabel;
        private System.Windows.Forms.Label EmpIdLabel;
        private System.Windows.Forms.Button RefreshBtn;
    }
}