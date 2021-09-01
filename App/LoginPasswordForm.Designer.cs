namespace App
{
    partial class LoginPasswordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ExistingPasswordTB = new System.Windows.Forms.TextBox();
            this.NewPasswordTB = new System.Windows.Forms.TextBox();
            this.UserIdLabel = new System.Windows.Forms.Label();
            this.BackBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.CofirmBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Your Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Existing Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "New Password :";
            // 
            // ExistingPasswordTB
            // 
            this.ExistingPasswordTB.Location = new System.Drawing.Point(425, 171);
            this.ExistingPasswordTB.Name = "ExistingPasswordTB";
            this.ExistingPasswordTB.Size = new System.Drawing.Size(196, 20);
            this.ExistingPasswordTB.TabIndex = 5;
            this.ExistingPasswordTB.UseSystemPasswordChar = true;
            // 
            // NewPasswordTB
            // 
            this.NewPasswordTB.Location = new System.Drawing.Point(425, 223);
            this.NewPasswordTB.Name = "NewPasswordTB";
            this.NewPasswordTB.Size = new System.Drawing.Size(196, 20);
            this.NewPasswordTB.TabIndex = 6;
            // 
            // UserIdLabel
            // 
            this.UserIdLabel.AutoSize = true;
            this.UserIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIdLabel.Location = new System.Drawing.Point(435, 121);
            this.UserIdLabel.Name = "UserIdLabel";
            this.UserIdLabel.Size = new System.Drawing.Size(0, 15);
            this.UserIdLabel.TabIndex = 12;
            // 
            // BackBTN
            // 
            this.BackBTN.Image = global::App.Properties.Resources.Go_back_icon1;
            this.BackBTN.Location = new System.Drawing.Point(682, 46);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(75, 35);
            this.BackBTN.TabIndex = 11;
            this.BackBTN.Text = "Back";
            this.BackBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BackBTN.UseVisualStyleBackColor = true;
            this.BackBTN.Click += new System.EventHandler(this.BackBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App.Properties.Resources.Apps_preferences_desktop_user_password_icon;
            this.pictureBox1.Location = new System.Drawing.Point(33, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Image = global::App.Properties.Resources.logout_icon4;
            this.LogoutBtn.Location = new System.Drawing.Point(425, 287);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(79, 43);
            this.LogoutBtn.TabIndex = 9;
            this.LogoutBtn.Text = "Log Out";
            this.LogoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // CofirmBTN
            // 
            this.CofirmBTN.Image = global::App.Properties.Resources.Check_icon;
            this.CofirmBTN.Location = new System.Drawing.Point(546, 287);
            this.CofirmBTN.Name = "CofirmBTN";
            this.CofirmBTN.Size = new System.Drawing.Size(79, 43);
            this.CofirmBTN.TabIndex = 8;
            this.CofirmBTN.Text = "Confirm";
            this.CofirmBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CofirmBTN.UseVisualStyleBackColor = true;
            this.CofirmBTN.Click += new System.EventHandler(this.CofirmBTN_Click);
            // 
            // LoginPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App.Properties.Resources.WhatsApp_Image_2019_12_22_at_7_491;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.UserIdLabel);
            this.Controls.Add(this.BackBTN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.CofirmBTN);
            this.Controls.Add(this.NewPasswordTB);
            this.Controls.Add(this.ExistingPasswordTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginPasswordForm";
            this.Text = "LoginPasswordForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginPasswordForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ExistingPasswordTB;
        private System.Windows.Forms.TextBox NewPasswordTB;
        private System.Windows.Forms.Button CofirmBTN;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BackBTN;
        private System.Windows.Forms.Label UserIdLabel;
    }
}