
namespace Coursework
{
    partial class adminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminLogin));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.AdminLoginBtn = new System.Windows.Forms.Button();
            this.AdminLoginLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtUsername.Location = new System.Drawing.Point(287, 181);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(263, 29);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtPassword.Location = new System.Drawing.Point(287, 247);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(263, 29);
            this.txtPassword.TabIndex = 1;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLbl.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.UsernameLbl.Location = new System.Drawing.Point(364, 156);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(86, 19);
            this.UsernameLbl.TabIndex = 2;
            this.UsernameLbl.Text = "Username";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLbl.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PasswordLbl.Location = new System.Drawing.Point(364, 224);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(81, 19);
            this.PasswordLbl.TabIndex = 3;
            this.PasswordLbl.Text = "Password";
            // 
            // AdminLoginBtn
            // 
            this.AdminLoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AdminLoginBtn.FlatAppearance.BorderSize = 0;
            this.AdminLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminLoginBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLoginBtn.ForeColor = System.Drawing.Color.White;
            this.AdminLoginBtn.Location = new System.Drawing.Point(357, 302);
            this.AdminLoginBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdminLoginBtn.Name = "AdminLoginBtn";
            this.AdminLoginBtn.Size = new System.Drawing.Size(120, 40);
            this.AdminLoginBtn.TabIndex = 4;
            this.AdminLoginBtn.Text = "Login";
            this.AdminLoginBtn.UseVisualStyleBackColor = false;
            this.AdminLoginBtn.Click += new System.EventHandler(this.AdminLoginBtn_Click);
            // 
            // AdminLoginLbl
            // 
            this.AdminLoginLbl.AutoSize = true;
            this.AdminLoginLbl.BackColor = System.Drawing.Color.Transparent;
            this.AdminLoginLbl.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLoginLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AdminLoginLbl.Location = new System.Drawing.Point(299, 9);
            this.AdminLoginLbl.Name = "AdminLoginLbl";
            this.AdminLoginLbl.Size = new System.Drawing.Size(224, 42);
            this.AdminLoginLbl.TabIndex = 5;
            this.AdminLoginLbl.Text = "Admin Login";
            // 
            // adminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 541);
            this.Controls.Add(this.AdminLoginLbl);
            this.Controls.Add(this.AdminLoginBtn);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "adminLogin";
            this.Text = "Admin Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Button AdminLoginBtn;
        private System.Windows.Forms.Label AdminLoginLbl;
    }
}