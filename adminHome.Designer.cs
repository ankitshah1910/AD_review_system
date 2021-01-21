
namespace Coursework
{
    partial class adminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminHome));
            this.AddcriteriaBtn = new System.Windows.Forms.Button();
            this.ViewReportBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.HelloAdminLbl = new System.Windows.Forms.Label();
            this.ImportDataBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // AddcriteriaBtn
            // 
            this.AddcriteriaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AddcriteriaBtn.FlatAppearance.BorderSize = 0;
            this.AddcriteriaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddcriteriaBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddcriteriaBtn.ForeColor = System.Drawing.Color.White;
            this.AddcriteriaBtn.Location = new System.Drawing.Point(394, 458);
            this.AddcriteriaBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddcriteriaBtn.Name = "AddcriteriaBtn";
            this.AddcriteriaBtn.Size = new System.Drawing.Size(390, 40);
            this.AddcriteriaBtn.TabIndex = 0;
            this.AddcriteriaBtn.Text = "Add Criteria";
            this.AddcriteriaBtn.UseVisualStyleBackColor = false;
            this.AddcriteriaBtn.Click += new System.EventHandler(this.AddCriteriaBtn_Click);
            // 
            // ViewReportBtn
            // 
            this.ViewReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ViewReportBtn.FlatAppearance.BorderSize = 0;
            this.ViewReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewReportBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewReportBtn.ForeColor = System.Drawing.Color.White;
            this.ViewReportBtn.Location = new System.Drawing.Point(0, 458);
            this.ViewReportBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewReportBtn.Name = "ViewReportBtn";
            this.ViewReportBtn.Size = new System.Drawing.Size(390, 40);
            this.ViewReportBtn.TabIndex = 1;
            this.ViewReportBtn.Text = "View Report";
            this.ViewReportBtn.UseVisualStyleBackColor = false;
            this.ViewReportBtn.Click += new System.EventHandler(this.viewReportBtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LogOutBtn.FlatAppearance.BorderSize = 0;
            this.LogOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutBtn.ForeColor = System.Drawing.Color.White;
            this.LogOutBtn.Location = new System.Drawing.Point(394, 501);
            this.LogOutBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(390, 40);
            this.LogOutBtn.TabIndex = 2;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = false;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // HelloAdminLbl
            // 
            this.HelloAdminLbl.AutoSize = true;
            this.HelloAdminLbl.BackColor = System.Drawing.Color.White;
            this.HelloAdminLbl.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloAdminLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.HelloAdminLbl.Location = new System.Drawing.Point(263, 9);
            this.HelloAdminLbl.Name = "HelloAdminLbl";
            this.HelloAdminLbl.Size = new System.Drawing.Size(248, 46);
            this.HelloAdminLbl.TabIndex = 3;
            this.HelloAdminLbl.Text = "Hello, Admin";
            // 
            // ImportDataBtn
            // 
            this.ImportDataBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ImportDataBtn.FlatAppearance.BorderSize = 0;
            this.ImportDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportDataBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportDataBtn.ForeColor = System.Drawing.Color.White;
            this.ImportDataBtn.Location = new System.Drawing.Point(0, 501);
            this.ImportDataBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImportDataBtn.Name = "ImportDataBtn";
            this.ImportDataBtn.Size = new System.Drawing.Size(390, 40);
            this.ImportDataBtn.TabIndex = 4;
            this.ImportDataBtn.Text = "Import Data";
            this.ImportDataBtn.UseVisualStyleBackColor = false;
            this.ImportDataBtn.Click += new System.EventHandler(this.ImportDataBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.Filter = "Text Files|*.txt";
            this.openFileDialog.Title = "Select Import File";
            // 
            // adminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(784, 541);
            this.Controls.Add(this.ImportDataBtn);
            this.Controls.Add(this.HelloAdminLbl);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.ViewReportBtn);
            this.Controls.Add(this.AddcriteriaBtn);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "adminHome";
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.adminHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddcriteriaBtn;
        private System.Windows.Forms.Button ViewReportBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Label HelloAdminLbl;
        private System.Windows.Forms.Button ImportDataBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}