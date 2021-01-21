using Newtonsoft.Json;
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
    public partial class adminHome : Form
    {
        public adminHome()
        {
            InitializeComponent();
        }

        
       
        private void ImportDataBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<CustomerReview> data= new List<CustomerReview>();
                try
                {
                    StreamReader streamReader = new StreamReader(openFileDialog.FileName);
                    string line = streamReader.ReadLine();
                    while (line != null)
                    {
                        CustomerReview review = (CustomerReview)JsonConvert.DeserializeObject<CustomerReview>(line);
                        data.Add(review);
                        line = streamReader.ReadLine();
                    }
                    streamReader.Close();

                    StreamWriter streamWriter = new StreamWriter("review.txt", true);

                    foreach (CustomerReview review in data)
                    {
                        string review_json = JsonConvert.SerializeObject(review, Formatting.None);
                        streamWriter.WriteLine(review_json);
                    }
                    streamWriter.Close();
                    MessageBox.Show("Data Imported Successfull!", "Success", MessageBoxButtons.OK);
                }
                catch (Exception)
                {
                    MessageBox.Show("The Import was not Successful. Please Check the File and Try Agian.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void viewReportBtn_Click(object sender, EventArgs e)
        {
            ReportsPage report = new ReportsPage();
            this.Hide();
            report.StartPosition = FormStartPosition.CenterParent;
            report.ShowDialog();
            report.Location = this.Location;
            this.Show();
        }

        private void AddCriteriaBtn_Click(object sender, EventArgs e)
        {
            newCriteria addCriteria = new newCriteria();
            this.Hide();
            addCriteria.StartPosition = FormStartPosition.CenterParent;
            addCriteria.ShowDialog();
            this.Show();
        }


        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void adminHome_Load(object sender, EventArgs e)
        {

        }
    }
}
