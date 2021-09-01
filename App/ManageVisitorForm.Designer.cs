namespace App
{
    partial class ManageVisitorForm
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.VisitorTable = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.ViewAllBtn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.VisitedDurationTB = new System.Windows.Forms.TextBox();
            this.CounterNoTB = new System.Windows.Forms.TextBox();
            this.VisitedPrisonerIdTB = new System.Windows.Forms.TextBox();
            this.VisitorNameTB = new System.Windows.Forms.TextBox();
            this.EmpSalaryLabel = new System.Windows.Forms.Label();
            this.EmpPhnLabel = new System.Windows.Forms.Label();
            this.EmpNameLabel = new System.Windows.Forms.Label();
            this.VisitorName = new System.Windows.Forms.Label();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorTable)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Image = global::App.Properties.Resources.Go_back_icon;
            this.BackBtn.Location = new System.Drawing.Point(12, 21);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(85, 36);
            this.BackBtn.TabIndex = 63;
            this.BackBtn.Text = "Back";
            this.BackBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // VisitorTable
            // 
            this.VisitorTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VisitorTable.Location = new System.Drawing.Point(415, 107);
            this.VisitorTable.Name = "VisitorTable";
            this.VisitorTable.ReadOnly = true;
            this.VisitorTable.Size = new System.Drawing.Size(366, 175);
            this.VisitorTable.TabIndex = 62;
            this.VisitorTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VisitorTable_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Search Here :";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Image = global::App.Properties.Resources.logout_icon1;
            this.LogoutBtn.Location = new System.Drawing.Point(691, 23);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(90, 36);
            this.LogoutBtn.TabIndex = 60;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // ViewAllBtn
            // 
            this.ViewAllBtn.Location = new System.Drawing.Point(415, 78);
            this.ViewAllBtn.Name = "ViewAllBtn";
            this.ViewAllBtn.Size = new System.Drawing.Size(366, 23);
            this.ViewAllBtn.TabIndex = 59;
            this.ViewAllBtn.Text = "View All Visitors";
            this.ViewAllBtn.UseVisualStyleBackColor = true;
            this.ViewAllBtn.Click += new System.EventHandler(this.ViewAllBtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(500, 305);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(281, 20);
            this.SearchBox.TabIndex = 58;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Enabled = false;
            this.DeleteBtn.Location = new System.Drawing.Point(299, 263);
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
            this.UpdateBtn.Location = new System.Drawing.Point(224, 263);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 56;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.Location = new System.Drawing.Point(143, 263);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(75, 23);
            this.InsertBtn.TabIndex = 55;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(65, 263);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadBtn.TabIndex = 54;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // VisitedDurationTB
            // 
            this.VisitedDurationTB.Location = new System.Drawing.Point(176, 226);
            this.VisitedDurationTB.MaxLength = 2;
            this.VisitedDurationTB.Name = "VisitedDurationTB";
            this.VisitedDurationTB.Size = new System.Drawing.Size(123, 20);
            this.VisitedDurationTB.TabIndex = 52;
            this.VisitedDurationTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VisitedDurationTB_KeyPress);
            // 
            // CounterNoTB
            // 
            this.CounterNoTB.Location = new System.Drawing.Point(176, 194);
            this.CounterNoTB.Name = "CounterNoTB";
            this.CounterNoTB.Size = new System.Drawing.Size(198, 20);
            this.CounterNoTB.TabIndex = 51;
            // 
            // VisitedPrisonerIdTB
            // 
            this.VisitedPrisonerIdTB.Location = new System.Drawing.Point(176, 156);
            this.VisitedPrisonerIdTB.Name = "VisitedPrisonerIdTB";
            this.VisitedPrisonerIdTB.Size = new System.Drawing.Size(198, 20);
            this.VisitedPrisonerIdTB.TabIndex = 50;
            // 
            // VisitorNameTB
            // 
            this.VisitorNameTB.Location = new System.Drawing.Point(176, 128);
            this.VisitorNameTB.Name = "VisitorNameTB";
            this.VisitorNameTB.Size = new System.Drawing.Size(198, 20);
            this.VisitorNameTB.TabIndex = 49;
            // 
            // EmpSalaryLabel
            // 
            this.EmpSalaryLabel.AutoSize = true;
            this.EmpSalaryLabel.Location = new System.Drawing.Point(68, 229);
            this.EmpSalaryLabel.Name = "EmpSalaryLabel";
            this.EmpSalaryLabel.Size = new System.Drawing.Size(87, 13);
            this.EmpSalaryLabel.TabIndex = 47;
            this.EmpSalaryLabel.Text = "Visited Duration :";
            // 
            // EmpPhnLabel
            // 
            this.EmpPhnLabel.AutoSize = true;
            this.EmpPhnLabel.Location = new System.Drawing.Point(68, 194);
            this.EmpPhnLabel.Name = "EmpPhnLabel";
            this.EmpPhnLabel.Size = new System.Drawing.Size(67, 13);
            this.EmpPhnLabel.TabIndex = 46;
            this.EmpPhnLabel.Text = "Counter No :";
            // 
            // EmpNameLabel
            // 
            this.EmpNameLabel.AutoSize = true;
            this.EmpNameLabel.Location = new System.Drawing.Point(68, 159);
            this.EmpNameLabel.Name = "EmpNameLabel";
            this.EmpNameLabel.Size = new System.Drawing.Size(101, 13);
            this.EmpNameLabel.TabIndex = 45;
            this.EmpNameLabel.Text = "Visited Presoner Id :";
            // 
            // VisitorName
            // 
            this.VisitorName.AutoSize = true;
            this.VisitorName.Location = new System.Drawing.Point(68, 131);
            this.VisitorName.Name = "VisitorName";
            this.VisitorName.Size = new System.Drawing.Size(72, 13);
            this.VisitorName.TabIndex = 44;
            this.VisitorName.Text = "Visitor Name :";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Enabled = false;
            this.RefreshBtn.Location = new System.Drawing.Point(65, 78);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(309, 23);
            this.RefreshBtn.TabIndex = 43;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "<100 Minutes";
            // 
            // ManageVisitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App.Properties.Resources.WhatsApp_Image_2019_12_22_at_7_495;
            this.ClientSize = new System.Drawing.Size(801, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.VisitorTable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.ViewAllBtn);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.VisitedDurationTB);
            this.Controls.Add(this.CounterNoTB);
            this.Controls.Add(this.VisitedPrisonerIdTB);
            this.Controls.Add(this.VisitorNameTB);
            this.Controls.Add(this.EmpSalaryLabel);
            this.Controls.Add(this.EmpPhnLabel);
            this.Controls.Add(this.EmpNameLabel);
            this.Controls.Add(this.VisitorName);
            this.Controls.Add(this.RefreshBtn);
            this.Name = "ManageVisitorForm";
            this.Text = "ManageVisitorForm";
            ((System.ComponentModel.ISupportInitialize)(this.VisitorTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridView VisitorTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button ViewAllBtn;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.TextBox VisitedDurationTB;
        private System.Windows.Forms.TextBox CounterNoTB;
        private System.Windows.Forms.TextBox VisitedPrisonerIdTB;
        private System.Windows.Forms.TextBox VisitorNameTB;
        private System.Windows.Forms.Label EmpSalaryLabel;
        private System.Windows.Forms.Label EmpPhnLabel;
        private System.Windows.Forms.Label EmpNameLabel;
        private System.Windows.Forms.Label VisitorName;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Label label1;
    }
}