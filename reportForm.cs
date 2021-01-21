using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class ReportsPage : Form
    {
        public ReportsPage()
        {
            InitializeComponent();
        }

        private void reportForm_Load_1(object sender, EventArgs e)
        {
            CustomerReview reviews = new CustomerReview();
            List<CustomerReview> reviewList = reviews.List();
            TotalReviewsCountLbl.Text = reviewList.Count.ToString();
            DataTable dt = ReportsPage.ConvertToDataTable(reviews.List());
            AllReviewsTable.DataSource = dt;

            Dictionary<string, int> chartData1 = ReportsPage.chartData1(reviewList);

            foreach (KeyValuePair<string, int> entry in chartData1)
            {
                numberOfRatingChart.Series["Number of Reviews"].Points.AddXY(entry.Key, entry.Value);
            }


            Dictionary<string, double> chartData2 = ReportsPage.chartData2(reviewList);

            foreach (KeyValuePair<string, double> entry in chartData2)
            {
                AverageRating.Series["Average Rating"].Points.AddXY(entry.Key, entry.Value);
            }
        }

        public static DataTable ConvertToDataTable(List<CustomerReview> reviews)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(CustomerReview));
            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties)
            {
                if (prop.Name != "customerRatings")
                {
                    table.Columns.Add(prop.Name);
                }
                else
                {
                    List<string> criterias = ReportsPage.Criterias();
                    foreach (var criteria in criterias)
                    {
                        table.Columns.Add(criteria);
                    }
                }
            }


            if (reviews != null)
            {
                foreach (CustomerReview item in reviews)
                {
                    DataRow row = table.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                    {
                        if (prop.Name != "customerRatings")
                        {
                            row[prop.Name] = prop.GetValue(item);
                        }
                        else
                        {
                            foreach (KeyValuePair<string,int> entry in item.customerRatings)
                            {
                                row[entry.Key] = entry.Value;
                            }
                        }
                    }
                    table.Rows.Add(row);
                }
            }
            return table;

        }

        public static List<string> Criterias()
        {
            StreamReader streamReader = new StreamReader("criteria.txt");
            List<string> Criterias = new List<string>();
            string line = streamReader.ReadLine();
            while (line != null)
            {
                Criterias.Add(line);
                line = streamReader.ReadLine();
            }
            streamReader.Close();
            return Criterias;
        }

        public static Dictionary<string, int> chartData1(List<CustomerReview> reviews)
        {

            Dictionary<string, int> chartDatacount = new Dictionary<string, int>();
            Dictionary<string, int> chartDataFinal = new Dictionary<string, int>();
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(CustomerReview));

            if (reviews != null)
            {
                foreach (CustomerReview item in reviews)
                {
                    foreach (PropertyDescriptor prop in properties)
                    {
                        if (prop.Name == "customerRatings")
                        {
                            foreach (KeyValuePair<string, int> entry in item.customerRatings)
                            {
                                if (chartDatacount.ContainsKey(entry.Key))
                                {
                                    chartDatacount[entry.Key] = chartDatacount[entry.Key] + 1;
                                }
                                else
                                {
                                    chartDatacount.Add(entry.Key, 1);
                                }

                            }
                        }
                    }

                }

                foreach (KeyValuePair<string, int> entry in chartDatacount)
                {
                    chartDataFinal.Add(entry.Key, entry.Value);
                }
            }
            return chartDataFinal;
        }


        public static Dictionary<string, double> chartData2(List<CustomerReview> reviews)
        {
            Dictionary<string, int> chartData = new Dictionary<string, int>();
            Dictionary<string, double> chartDataFinal = new Dictionary<string, double>();
            Dictionary<string, int> chartDatacount = new Dictionary<string, int>();
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(CustomerReview));

            if (reviews != null)
            {
                foreach (CustomerReview item in reviews)
                {
                    foreach (PropertyDescriptor prop in properties)
                    {
                        if (prop.Name == "customerRatings")
                        {
                            foreach (KeyValuePair<string, int> entry in item.customerRatings)
                            {
                                if (chartData.ContainsKey(entry.Key))
                                {
                                    int newVal = chartData[entry.Key];
                                    chartData[entry.Key] = newVal + entry.Value;
                                }
                                else
                                {
                                    chartData.Add(entry.Key, entry.Value);
                                }
                            }

                            foreach (KeyValuePair<string, int> entry in item.customerRatings)
                            {
                                if (chartDatacount.ContainsKey(entry.Key))
                                {
                                    chartDatacount[entry.Key] = chartDatacount[entry.Key] + 1;
                                }
                                else
                                {
                                    chartDatacount.Add(entry.Key, 1);
                                }
                            }
                           
                        }
                    }

                }

                foreach (KeyValuePair<string, int> entry in chartData)
                {
                    double Avg = Math.Round((double)entry.Value / (double)chartDatacount[entry.Key], 2);
                    chartDataFinal.Add(entry.Key, Avg);
                }
            }
            return chartDataFinal;
        }
        
        private void btnSortRating_Click(object sender, EventArgs e)
        {
            CustomerReview reviews = new CustomerReview();
            List<CustomerReview> reviewList = reviews.List();
            DataTable dt = ReportsPage.ConvertToDataTable(CustomerReview.SortByDate(reviews.List()));
            AllReviewsTable.DataSource = dt;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            CustomerReview reviews = new CustomerReview();
            List<CustomerReview> reviewList = reviews.List();
            TotalReviewsCountLbl.Text = reviewList.Count.ToString();
            DataTable dt = ReportsPage.ConvertToDataTable(reviews.List());
            AllReviewsTable.DataSource = dt;
        }
    }
}
