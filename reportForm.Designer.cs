
namespace Coursework
{
    partial class ReportsPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.AllReviewsTable = new System.Windows.Forms.DataGridView();
            this.SortBtn = new System.Windows.Forms.Button();
            this.TotalReviewsLbl = new System.Windows.Forms.Label();
            this.TotalReviewsCountLbl = new System.Windows.Forms.Label();
            this.numberOfRatingLbl = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.ReportsLbl = new System.Windows.Forms.Label();
            this.AverageRatingLbl = new System.Windows.Forms.Label();
            this.numberOfRatingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AverageRating = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.AllReviewsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfRatingChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AverageRating)).BeginInit();
            this.SuspendLayout();
            // 
            // AllReviewsTable
            // 
            this.AllReviewsTable.BackgroundColor = System.Drawing.Color.White;
            this.AllReviewsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllReviewsTable.GridColor = System.Drawing.Color.White;
            this.AllReviewsTable.Location = new System.Drawing.Point(12, 89);
            this.AllReviewsTable.Name = "AllReviewsTable";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllReviewsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.AllReviewsTable.Size = new System.Drawing.Size(1160, 249);
            this.AllReviewsTable.TabIndex = 0;
            // 
            // SortBtn
            // 
            this.SortBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SortBtn.FlatAppearance.BorderSize = 0;
            this.SortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortBtn.ForeColor = System.Drawing.Color.White;
            this.SortBtn.Location = new System.Drawing.Point(970, 54);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(98, 32);
            this.SortBtn.TabIndex = 3;
            this.SortBtn.Text = "Sort by Date";
            this.SortBtn.UseVisualStyleBackColor = false;
            this.SortBtn.Click += new System.EventHandler(this.btnSortRating_Click);
            // 
            // TotalReviewsLbl
            // 
            this.TotalReviewsLbl.AutoSize = true;
            this.TotalReviewsLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalReviewsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TotalReviewsLbl.Location = new System.Drawing.Point(12, 64);
            this.TotalReviewsLbl.Name = "TotalReviewsLbl";
            this.TotalReviewsLbl.Size = new System.Drawing.Size(127, 22);
            this.TotalReviewsLbl.TabIndex = 6;
            this.TotalReviewsLbl.Text = "Total Reviews:";
            // 
            // TotalReviewsCountLbl
            // 
            this.TotalReviewsCountLbl.AutoSize = true;
            this.TotalReviewsCountLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalReviewsCountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TotalReviewsCountLbl.Location = new System.Drawing.Point(136, 64);
            this.TotalReviewsCountLbl.Name = "TotalReviewsCountLbl";
            this.TotalReviewsCountLbl.Size = new System.Drawing.Size(20, 22);
            this.TotalReviewsCountLbl.TabIndex = 7;
            this.TotalReviewsCountLbl.Text = "0";
            // 
            // numberOfRatingLbl
            // 
            this.numberOfRatingLbl.AutoSize = true;
            this.numberOfRatingLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfRatingLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.numberOfRatingLbl.Location = new System.Drawing.Point(43, 363);
            this.numberOfRatingLbl.Name = "numberOfRatingLbl";
            this.numberOfRatingLbl.Size = new System.Drawing.Size(207, 21);
            this.numberOfRatingLbl.TabIndex = 9;
            this.numberOfRatingLbl.Text = "Number of Rating by People";
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ResetBtn.FlatAppearance.BorderSize = 0;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Location = new System.Drawing.Point(1074, 54);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(98, 32);
            this.ResetBtn.TabIndex = 10;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ReportsLbl
            // 
            this.ReportsLbl.AutoSize = true;
            this.ReportsLbl.BackColor = System.Drawing.Color.Transparent;
            this.ReportsLbl.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ReportsLbl.Location = new System.Drawing.Point(506, 0);
            this.ReportsLbl.Name = "ReportsLbl";
            this.ReportsLbl.Size = new System.Drawing.Size(144, 42);
            this.ReportsLbl.TabIndex = 11;
            this.ReportsLbl.Text = "Reports";
            // 
            // AverageRatingLbl
            // 
            this.AverageRatingLbl.AutoSize = true;
            this.AverageRatingLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageRatingLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AverageRatingLbl.Location = new System.Drawing.Point(662, 363);
            this.AverageRatingLbl.Name = "AverageRatingLbl";
            this.AverageRatingLbl.Size = new System.Drawing.Size(116, 21);
            this.AverageRatingLbl.TabIndex = 13;
            this.AverageRatingLbl.Text = "Average Rating";
            // 
            // numberOfRatingChart
            // 
            chartArea5.Name = "ChartArea1";
            this.numberOfRatingChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.numberOfRatingChart.Legends.Add(legend5);
            this.numberOfRatingChart.Location = new System.Drawing.Point(16, 388);
            this.numberOfRatingChart.Name = "numberOfRatingChart";
            this.numberOfRatingChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series5.BorderWidth = 5;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.IsValueShownAsLabel = true;
            series5.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series5.LabelBorderColor = System.Drawing.Color.Transparent;
            series5.LabelForeColor = System.Drawing.Color.DarkSlateGray;
            series5.Legend = "Legend1";
            series5.Name = "Number of Reviews";
            series5.YValuesPerPoint = 4;
            this.numberOfRatingChart.Series.Add(series5);
            this.numberOfRatingChart.Size = new System.Drawing.Size(575, 332);
            this.numberOfRatingChart.TabIndex = 1;
            this.numberOfRatingChart.Text = "numberOfrating";
            // 
            // AverageRating
            // 
            this.AverageRating.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.Name = "ChartArea1";
            this.AverageRating.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.AverageRating.Legends.Add(legend6);
            this.AverageRating.Location = new System.Drawing.Point(597, 387);
            this.AverageRating.Name = "AverageRating";
            this.AverageRating.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series6.BorderColor = System.Drawing.Color.Red;
            series6.ChartArea = "ChartArea1";
            series6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series6.IsValueShownAsLabel = true;
            series6.LabelBackColor = System.Drawing.Color.LawnGreen;
            series6.Legend = "Legend1";
            series6.Name = "Average Rating";
            series6.ShadowColor = System.Drawing.Color.Yellow;
            series6.YValuesPerPoint = 4;
            this.AverageRating.Series.Add(series6);
            this.AverageRating.Size = new System.Drawing.Size(575, 332);
            this.AverageRating.TabIndex = 30;
            this.AverageRating.Text = "AverageRating";
            // 
            // ReportsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 731);
            this.Controls.Add(this.AverageRating);
            this.Controls.Add(this.numberOfRatingChart);
            this.Controls.Add(this.AverageRatingLbl);
            this.Controls.Add(this.ReportsLbl);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.numberOfRatingLbl);
            this.Controls.Add(this.TotalReviewsCountLbl);
            this.Controls.Add(this.TotalReviewsLbl);
            this.Controls.Add(this.SortBtn);
            this.Controls.Add(this.AllReviewsTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReportsPage";
            this.Text = "Ratings Report";
            this.Load += new System.EventHandler(this.reportForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.AllReviewsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfRatingChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AverageRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllReviewsTable;
        private System.Windows.Forms.Button SortBtn;
        private System.Windows.Forms.Label TotalReviewsLbl;
        private System.Windows.Forms.Label TotalReviewsCountLbl;
        private System.Windows.Forms.Label numberOfRatingLbl;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label ReportsLbl;
        private System.Windows.Forms.Label AverageRatingLbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart numberOfRatingChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart AverageRating;
    }
}