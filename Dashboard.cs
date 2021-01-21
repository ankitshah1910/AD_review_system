using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AdminLoginBtn_Click(object sender, EventArgs e)
        {
            adminLogin adminLogin = new adminLogin();
            this.Hide();
            adminLogin.StartPosition = FormStartPosition.CenterParent;
            adminLogin.ShowDialog();
            adminLogin.Location = this.Location;
            this.Show();
        }

        private void AddReviewBtn_Click(object sender, EventArgs e)
        {
            addReview reviewForm = new addReview();
            this.Hide();
            reviewForm.StartPosition = FormStartPosition.CenterParent;
            reviewForm.ShowDialog();
            this.Show();
        }
    }
}
