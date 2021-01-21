
namespace Coursework
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.AdminLoginBtn = new System.Windows.Forms.Button();
            this.AddReviewBtn = new System.Windows.Forms.Button();
            this.HelloLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdminLoginBtn
            // 
            this.AdminLoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AdminLoginBtn.FlatAppearance.BorderSize = 0;
            this.AdminLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminLoginBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLoginBtn.ForeColor = System.Drawing.Color.White;
            this.AdminLoginBtn.Location = new System.Drawing.Point(394, 502);
            this.AdminLoginBtn.Name = "AdminLoginBtn";
            this.AdminLoginBtn.Size = new System.Drawing.Size(390, 40);
            this.AdminLoginBtn.TabIndex = 0;
            this.AdminLoginBtn.Text = "Admin Login";
            this.AdminLoginBtn.UseVisualStyleBackColor = false;
            this.AdminLoginBtn.Click += new System.EventHandler(this.AdminLoginBtn_Click);
            // 
            // AddReviewBtn
            // 
            this.AddReviewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AddReviewBtn.FlatAppearance.BorderSize = 0;
            this.AddReviewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddReviewBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddReviewBtn.ForeColor = System.Drawing.Color.White;
            this.AddReviewBtn.Location = new System.Drawing.Point(0, 502);
            this.AddReviewBtn.Name = "AddReviewBtn";
            this.AddReviewBtn.Size = new System.Drawing.Size(390, 40);
            this.AddReviewBtn.TabIndex = 1;
            this.AddReviewBtn.Text = "Add a Review";
            this.AddReviewBtn.UseCompatibleTextRendering = true;
            this.AddReviewBtn.UseVisualStyleBackColor = false;
            this.AddReviewBtn.Click += new System.EventHandler(this.AddReviewBtn_Click);
            // 
            // HelloLbl
            // 
            this.HelloLbl.AutoSize = true;
            this.HelloLbl.BackColor = System.Drawing.Color.Transparent;
            this.HelloLbl.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.HelloLbl.Location = new System.Drawing.Point(333, 70);
            this.HelloLbl.Name = "HelloLbl";
            this.HelloLbl.Size = new System.Drawing.Size(124, 46);
            this.HelloLbl.TabIndex = 2;
            this.HelloLbl.Text = "Hello!";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(784, 541);
            this.Controls.Add(this.HelloLbl);
            this.Controls.Add(this.AddReviewBtn);
            this.Controls.Add(this.AdminLoginBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdminLoginBtn;
        private System.Windows.Forms.Button AddReviewBtn;
        private System.Windows.Forms.Label HelloLbl;
    }
}

