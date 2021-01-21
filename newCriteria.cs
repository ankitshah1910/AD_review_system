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
    public partial class newCriteria : Form
    {
        public newCriteria()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            adminHome adminHome = new adminHome();
            this.Close();
        }

        private void btnAddCriteria_Click(object sender, EventArgs e)
        {
            String criteria = newCriteriaTxt.Text;
            if (criteria!=null && criteria!="")
            {
                StreamWriter streamWriter = new StreamWriter("criteria.txt",true);
                streamWriter.WriteLine(criteria);
                streamWriter.Close();
                newCriteriaTxt.Text = null;
                MessageBox.Show("Criteria Added Successfully!", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Please Provide a Criteria Name!", "Invalid Criteria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddCriteriaBtn_Click(object sender, EventArgs e)
        {
            String criteria = newCriteriaTxt.Text;
            if (criteria != null && criteria != "")
            {
                StreamWriter streamWriter = new StreamWriter("criteria.txt", true);
                streamWriter.WriteLine(criteria);
                streamWriter.Close();
                newCriteriaTxt.Text = null;
                MessageBox.Show("Criteria Added Successfully!", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Please Provide a Criteria Name!", "Invalid Criteria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
