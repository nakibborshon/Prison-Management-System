namespace App
{
    partial class HomePage
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.ChangePasswordBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.CellManagementBtn = new System.Windows.Forms.Button();
            this.PrisonerManagementBtn = new System.Windows.Forms.Button();
            this.ManageEmpBtn = new System.Windows.Forms.Button();
            this.VisitorManagementBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(103, 28);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(102, 25);
            this.WelcomeLabel.TabIndex = 6;
            this.WelcomeLabel.Text = "Welcome : ";
            // 
            // ChangePasswordBTN
            // 
            this.ChangePasswordBTN.Image = global::App.Properties.Resources.data_management_icon2;
            this.ChangePasswordBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangePasswordBTN.Location = new System.Drawing.Point(574, 226);
            this.ChangePasswordBTN.Name = "ChangePasswordBTN";
            this.ChangePasswordBTN.Size = new System.Drawing.Size(132, 60);
            this.ChangePasswordBTN.TabIndex = 8;
            this.ChangePasswordBTN.Text = "Change Password";
            this.ChangePasswordBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChangePasswordBTN.UseVisualStyleBackColor = true;
            this.ChangePasswordBTN.Click += new System.EventHandler(this.ChangePasswordBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App.Properties.Resources.crime_prison_cell_bars_260nw_724345753;
            this.pictureBox1.Location = new System.Drawing.Point(12, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Image = global::App.Properties.Resources.logout_icon;
            this.LogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutBtn.Location = new System.Drawing.Point(632, 25);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(74, 41);
            this.LogoutBtn.TabIndex = 5;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // CellManagementBtn
            // 
            this.CellManagementBtn.Image = global::App.Properties.Resources.data_management_icon1;
            this.CellManagementBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CellManagementBtn.Location = new System.Drawing.Point(394, 176);
            this.CellManagementBtn.Name = "CellManagementBtn";
            this.CellManagementBtn.Size = new System.Drawing.Size(132, 60);
            this.CellManagementBtn.TabIndex = 2;
            this.CellManagementBtn.Text = "Cell Management";
            this.CellManagementBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CellManagementBtn.UseVisualStyleBackColor = true;
            this.CellManagementBtn.Click += new System.EventHandler(this.CellManagementBtn_Click);
            // 
            // PrisonerManagementBtn
            // 
            this.PrisonerManagementBtn.Image = global::App.Properties.Resources.data_management_icon1;
            this.PrisonerManagementBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrisonerManagementBtn.Location = new System.Drawing.Point(394, 84);
            this.PrisonerManagementBtn.Name = "PrisonerManagementBtn";
            this.PrisonerManagementBtn.Size = new System.Drawing.Size(132, 60);
            this.PrisonerManagementBtn.TabIndex = 1;
            this.PrisonerManagementBtn.Text = "Prisoner Management";
            this.PrisonerManagementBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrisonerManagementBtn.UseVisualStyleBackColor = true;
            this.PrisonerManagementBtn.Click += new System.EventHandler(this.PrisonerManagementBtn_Click);
            // 
            // ManageEmpBtn
            // 
            this.ManageEmpBtn.Image = global::App.Properties.Resources.data_management_icon2;
            this.ManageEmpBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageEmpBtn.Location = new System.Drawing.Point(574, 134);
            this.ManageEmpBtn.Name = "ManageEmpBtn";
            this.ManageEmpBtn.Size = new System.Drawing.Size(132, 60);
            this.ManageEmpBtn.TabIndex = 0;
            this.ManageEmpBtn.Text = "Manage Employee";
            this.ManageEmpBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ManageEmpBtn.UseVisualStyleBackColor = true;
            this.ManageEmpBtn.Click += new System.EventHandler(this.ManageEmpBtn_Click);
            // 
            // VisitorManagementBTN
            // 
            this.VisitorManagementBTN.Image = global::App.Properties.Resources.data_management_icon2;
            this.VisitorManagementBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VisitorManagementBTN.Location = new System.Drawing.Point(394, 262);
            this.VisitorManagementBTN.Name = "VisitorManagementBTN";
            this.VisitorManagementBTN.Size = new System.Drawing.Size(132, 60);
            this.VisitorManagementBTN.TabIndex = 9;
            this.VisitorManagementBTN.Text = "Visitor Management";
            this.VisitorManagementBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.VisitorManagementBTN.UseVisualStyleBackColor = true;
            this.VisitorManagementBTN.Click += new System.EventHandler(this.VisitorManagementBTN_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App.Properties.Resources.WhatsApp_Image_2019_12_22_at_7_496;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.VisitorManagementBTN);
            this.Controls.Add(this.ChangePasswordBTN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.CellManagementBtn);
            this.Controls.Add(this.PrisonerManagementBtn);
            this.Controls.Add(this.ManageEmpBtn);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClose);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ManageEmpBtn;
        private System.Windows.Forms.Button PrisonerManagementBtn;
        private System.Windows.Forms.Button CellManagementBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ChangePasswordBTN;
        private System.Windows.Forms.Button VisitorManagementBTN;
    }
}