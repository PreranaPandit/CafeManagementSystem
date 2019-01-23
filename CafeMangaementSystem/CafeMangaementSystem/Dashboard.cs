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
    public partial class Dashboard : Form
    {
        private string username;
        public Dashboard(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        public Dashboard()
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerType customertype = new CustomerType();
            customertype.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer customer = new Customer();
            customer.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Items items = new Items();
            items.ShowDialog();
            this.Close();
        }

       

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            GenerateBill generateBill = new GenerateBill();
            generateBill.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblusername_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblusername.Text = username;
        }

        private void lblwelcome_Click(object sender, EventArgs e)
        {

        }

        private void lnklbllogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
    }
}
