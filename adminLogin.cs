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
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
        }

        private void AdminLoginBtn_Click(object sender, EventArgs e)
        {
            string usernmae = txtUsername.Text;
            string password = txtPassword.Text;
            if (usernmae=="admin" && password=="admin")
            {
                adminHome adminHome = new adminHome();
                this.Hide();
                adminHome.StartPosition = FormStartPosition.CenterParent;
                adminHome.ShowDialog();
                adminHome.Location = this.Location;
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Credentials!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
