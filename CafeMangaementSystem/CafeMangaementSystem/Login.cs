using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeMangaementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        LoginBLL loginBll = new LoginBLL();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            loginBll._username = txtusername.Text.Trim();
            loginBll._password = txtpassword.Text.Trim();

            bool isValidUser = loginBll.checkUser();

           
            if (isValidUser)
            {
                this.Hide();
                Dashboard dashboard = new Dashboard(txtusername.Text);
                dashboard.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("either username or password is incorrect!!!");
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
