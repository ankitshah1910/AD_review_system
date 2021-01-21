
namespace Coursework
{
    partial class newCriteria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newCriteria));
            this.NewCriteriaLbl = new System.Windows.Forms.Label();
            this.newCriteriaTxt = new System.Windows.Forms.TextBox();
            this.AddCriteriaBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.CriteriaNameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewCriteriaLbl
            // 
            this.NewCriteriaLbl.AutoSize = true;
            this.NewCriteriaLbl.BackColor = System.Drawing.Color.Transparent;
            this.NewCriteriaLbl.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCriteriaLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NewCriteriaLbl.Location = new System.Drawing.Point(307, 9);
            this.NewCriteriaLbl.Name = "NewCriteriaLbl";
            this.NewCriteriaLbl.Size = new System.Drawing.Size(219, 42);
            this.NewCriteriaLbl.TabIndex = 0;
            this.NewCriteriaLbl.Text = "New Criteria";
            // 
            // newCriteriaTxt
            // 
            this.newCriteriaTxt.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCriteriaTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.newCriteriaTxt.Location = new System.Drawing.Point(250, 207);
            this.newCriteriaTxt.Name = "newCriteriaTxt";
            this.newCriteriaTxt.Size = new System.Drawing.Size(302, 33);
            this.newCriteriaTxt.TabIndex = 1;
            // 
            // AddCriteriaBtn
            // 
            this.AddCriteriaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AddCriteriaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCriteriaBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCriteriaBtn.ForeColor = System.Drawing.Color.White;
            this.AddCriteriaBtn.Location = new System.Drawing.Point(393, 501);
            this.AddCriteriaBtn.Name = "AddCriteriaBtn";
            this.AddCriteriaBtn.Size = new System.Drawing.Size(390, 40);
            this.AddCriteriaBtn.TabIndex = 3;
            this.AddCriteriaBtn.Text = "Add Criteria";
            this.AddCriteriaBtn.UseVisualStyleBackColor = false;
            this.AddCriteriaBtn.Click += new System.EventHandler(this.AddCriteriaBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(0, 501);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(390, 40);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // CriteriaNameLbl
            // 
            this.CriteriaNameLbl.AutoSize = true;
            this.CriteriaNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.CriteriaNameLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriteriaNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CriteriaNameLbl.Location = new System.Drawing.Point(246, 182);
            this.CriteriaNameLbl.Name = "CriteriaNameLbl";
            this.CriteriaNameLbl.Size = new System.Drawing.Size(123, 22);
            this.CriteriaNameLbl.TabIndex = 5;
            this.CriteriaNameLbl.Text = "Criteria Name";
            // 
            // newCriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(784, 541);
            this.Controls.Add(this.CriteriaNameLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddCriteriaBtn);
            this.Controls.Add(this.newCriteriaTxt);
            this.Controls.Add(this.NewCriteriaLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "newCriteria";
            this.Text = "Add New Criteria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewCriteriaLbl;
        private System.Windows.Forms.TextBox newCriteriaTxt;
        private System.Windows.Forms.Button AddCriteriaBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label CriteriaNameLbl;
    }
}