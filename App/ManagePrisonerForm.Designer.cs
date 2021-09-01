namespace App
{
    partial class ManagePrisonerForm
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
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.PunishmentTB = new System.Windows.Forms.TextBox();
            this.CrimeTB = new System.Windows.Forms.TextBox();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.PrisonerNameTB = new System.Windows.Forms.TextBox();
            this.PrisonerIdTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmpSalaryLabel = new System.Windows.Forms.Label();
            this.EmpPhnLabel = new System.Windows.Forms.Label();
            this.EmpNameLabel = new System.Windows.Forms.Label();
            this.EmpIdLabel = new System.Windows.Forms.Label();
            this.PrisonerTable = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.ViewAllBtn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.CellNoTB = new System.Windows.Forms.TextBox();
            this.CellNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PrisonerTable)).BeginInit();
            this.SuspendLayout();
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Enabled = false;
            this.RefreshBtn.Location = new System.Drawing.Point(57, 82);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(302, 23);
            this.RefreshBtn.TabIndex = 16;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Enabled = false;
            this.DeleteBtn.Location = new System.Drawing.Point(284, 302);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 35;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Enabled = false;
            this.UpdateBtn.Location = new System.Drawing.Point(209, 302);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 34;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.Location = new System.Drawing.Point(131, 302);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(75, 23);
            this.InsertBtn.TabIndex = 33;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(56, 302);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadBtn.TabIndex = 32;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // PunishmentTB
            // 
            this.PunishmentTB.Location = new System.Drawing.Point(161, 234);
            this.PunishmentTB.Name = "PunishmentTB";
            this.PunishmentTB.Size = new System.Drawing.Size(198, 20);
            this.PunishmentTB.TabIndex = 31;
            // 
            // CrimeTB
            // 
            this.CrimeTB.Location = new System.Drawing.Point(161, 208);
            this.CrimeTB.Name = "CrimeTB";
            this.CrimeTB.Size = new System.Drawing.Size(198, 20);
            this.CrimeTB.TabIndex = 30;
            // 
            // AddressTB
            // 
            this.AddressTB.Location = new System.Drawing.Point(161, 182);
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(198, 20);
            this.AddressTB.TabIndex = 29;
            // 
            // PrisonerNameTB
            // 
            this.PrisonerNameTB.Location = new System.Drawing.Point(161, 156);
            this.PrisonerNameTB.Name = "PrisonerNameTB";
            this.PrisonerNameTB.Size = new System.Drawing.Size(198, 20);
            this.PrisonerNameTB.TabIndex = 28;
            // 
            // PrisonerIdTB
            // 
            this.PrisonerIdTB.Location = new System.Drawing.Point(161, 128);
            this.PrisonerIdTB.Name = "PrisonerIdTB";
            this.PrisonerIdTB.Size = new System.Drawing.Size(198, 20);
            this.PrisonerIdTB.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Punishment  :";
            // 
            // EmpSalaryLabel
            // 
            this.EmpSalaryLabel.AutoSize = true;
            this.EmpSalaryLabel.Location = new System.Drawing.Point(60, 215);
            this.EmpSalaryLabel.Name = "EmpSalaryLabel";
            this.EmpSalaryLabel.Size = new System.Drawing.Size(39, 13);
            this.EmpSalaryLabel.TabIndex = 25;
            this.EmpSalaryLabel.Text = "Crime :";
            // 
            // EmpPhnLabel
            // 
            this.EmpPhnLabel.AutoSize = true;
            this.EmpPhnLabel.Location = new System.Drawing.Point(60, 185);
            this.EmpPhnLabel.Name = "EmpPhnLabel";
            this.EmpPhnLabel.Size = new System.Drawing.Size(45, 13);
            this.EmpPhnLabel.TabIndex = 24;
            this.EmpPhnLabel.Text = "Address";
            // 
            // EmpNameLabel
            // 
            this.EmpNameLabel.AutoSize = true;
            this.EmpNameLabel.Location = new System.Drawing.Point(60, 159);
            this.EmpNameLabel.Name = "EmpNameLabel";
            this.EmpNameLabel.Size = new System.Drawing.Size(82, 13);
            this.EmpNameLabel.TabIndex = 23;
            this.EmpNameLabel.Text = "Prisoner Name :";
            // 
            // EmpIdLabel
            // 
            this.EmpIdLabel.AutoSize = true;
            this.EmpIdLabel.Location = new System.Drawing.Point(60, 131);
            this.EmpIdLabel.Name = "EmpIdLabel";
            this.EmpIdLabel.Size = new System.Drawing.Size(65, 13);
            this.EmpIdLabel.TabIndex = 22;
            this.EmpIdLabel.Text = "Prisoner ID :";
            // 
            // PrisonerTable
            // 
            this.PrisonerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrisonerTable.Location = new System.Drawing.Point(407, 111);
            this.PrisonerTable.Name = "PrisonerTable";
            this.PrisonerTable.ReadOnly = true;
            this.PrisonerTable.Size = new System.Drawing.Size(366, 175);
            this.PrisonerTable.TabIndex = 41;
            this.PrisonerTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrisonerTable_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Search Here :";
            // 
            // ViewAllBtn
            // 
            this.ViewAllBtn.Location = new System.Drawing.Point(407, 82);
            this.ViewAllBtn.Name = "ViewAllBtn";
            this.ViewAllBtn.Size = new System.Drawing.Size(366, 23);
            this.ViewAllBtn.TabIndex = 38;
            this.ViewAllBtn.Text = "View All Prisoners";
            this.ViewAllBtn.UseVisualStyleBackColor = true;
            this.ViewAllBtn.Click += new System.EventHandler(this.ViewAllBtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(492, 309);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(281, 20);
            this.SearchBox.TabIndex = 37;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBoxValueChange);
            // 
            // BackBtn
            // 
            this.BackBtn.Image = global::App.Properties.Resources.Go_back_icon;
            this.BackBtn.Location = new System.Drawing.Point(23, 12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(85, 36);
            this.BackBtn.TabIndex = 42;
            this.BackBtn.Text = "Back";
            this.BackBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Image = global::App.Properties.Resources.logout_icon1;
            this.LogoutBtn.Location = new System.Drawing.Point(683, 12);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(90, 36);
            this.LogoutBtn.TabIndex = 39;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // CellNoTB
            // 
            this.CellNoTB.Location = new System.Drawing.Point(161, 266);
            this.CellNoTB.Name = "CellNoTB";
            this.CellNoTB.Size = new System.Drawing.Size(198, 20);
            this.CellNoTB.TabIndex = 43;
            // 
            // CellNo
            // 
            this.CellNo.AutoSize = true;
            this.CellNo.Location = new System.Drawing.Point(60, 269);
            this.CellNo.Name = "CellNo";
            this.CellNo.Size = new System.Drawing.Size(47, 13);
            this.CellNo.TabIndex = 44;
            this.CellNo.Text = "Cell No :";
            // 
            // ManagePrisonerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App.Properties.Resources.WhatsApp_Image_2019_12_22_at_7_494;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.CellNo);
            this.Controls.Add(this.CellNoTB);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.PrisonerTable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.ViewAllBtn);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.PunishmentTB);
            this.Controls.Add(this.CrimeTB);
            this.Controls.Add(this.AddressTB);
            this.Controls.Add(this.PrisonerNameTB);
            this.Controls.Add(this.PrisonerIdTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmpSalaryLabel);
            this.Controls.Add(this.EmpPhnLabel);
            this.Controls.Add(this.EmpNameLabel);
            this.Controls.Add(this.EmpIdLabel);
            this.Controls.Add(this.RefreshBtn);
            this.Name = "ManagePrisonerForm";
            this.Text = "ManagePrisonerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagePrisonerForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PrisonerTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.TextBox PunishmentTB;
        private System.Windows.Forms.TextBox CrimeTB;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.TextBox PrisonerNameTB;
        private System.Windows.Forms.TextBox PrisonerIdTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label EmpSalaryLabel;
        private System.Windows.Forms.Label EmpPhnLabel;
        private System.Windows.Forms.Label EmpNameLabel;
        private System.Windows.Forms.Label EmpIdLabel;
        private System.Windows.Forms.DataGridView PrisonerTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button ViewAllBtn;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TextBox CellNoTB;
        private System.Windows.Forms.Label CellNo;
    }
}