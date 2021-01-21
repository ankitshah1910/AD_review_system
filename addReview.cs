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
    public partial class addReview : Form
    {
        public addReview()
        {
            InitializeComponent();
        }

       
        
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RatingPanel_Paint(object sender, PaintEventArgs e)
        {
            StreamReader streamReader = new StreamReader("criteria.txt");
            List<string> criteria = new List<string>();
            string data = streamReader.ReadLine();
            while (data != null)
            {
                criteria.Add(data);
                data = streamReader.ReadLine();
            }
            streamReader.Close();

            for (int i = 0; i < criteria.Count; i++)
            {
                Criteria rating = new Criteria();
                rating.Name = i.ToString();
                rating.Dock = DockStyle.Top;
                rating.Controls[0].Text = criteria[i];
                RatingPanel.Controls.Add(rating);
                RatingPanel.Controls[i].Visible = true;
            }
        }

        private void SubmitReviewBtn_Click(object sender, EventArgs e)
        {
            string name = FullNameTxt.Text;
            string email = EmailTxt.Text;
            string Phonenum = PhoneNumTxt.Text;
            Dictionary<string, int> ratings = new Dictionary<string, int>();
                
            foreach (var item in RatingPanel.Controls)
            {
                UserControl item1 =(UserControl ) item;
                for (int i = 1; i < item1.Controls.Count; i++)
                {
                    RadioButton rbtn = (RadioButton)item1.Controls[i];
                    if (rbtn.Checked == true)
                    {
                        ratings[item1.Controls[0].Text] =Int32.Parse(rbtn.Text);
                    }
                }
            }

            if (name!=null && email!=null && Phonenum != null && ratings.Count != 0)
            {
                CustomerReview review = new CustomerReview();
                review.customerName = name;
                review.customerEmail = email;
                review.customerContact = Phonenum;
                review.customerRatings = ratings;
                string data = JsonConvert.SerializeObject(review, Formatting.None);
                StreamWriter streamWriter = new StreamWriter("review.txt", true);
                streamWriter.WriteLine(data);
                streamWriter.Close();
                MessageBox.Show("Review Submitted Successfully!", "Success", MessageBoxButtons.OK);
                this.clearAll();
            }
            else
            {
                MessageBox.Show("Please fill up at the Fields!", "Invalid Review", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ClearReviewBtn_Click(object sender, EventArgs e)
        {
            this.clearAll();
        }

        public void clearAll()
        {
            PhoneNumTxt.Text = null;
            EmailTxt.Text = null;
            FullNameTxt.Text = null;

            foreach (var item in RatingPanel.Controls)
            {
                UserControl item1 = (UserControl)item;
                for (int i = 1; i < item1.Controls.Count; i++)
                {
                    RadioButton rbtn = (RadioButton)item1.Controls[i];
                    if (rbtn.Checked == true)
                    {
                        rbtn.Checked = false;
                    }
                }
            }
        }



    }
}
