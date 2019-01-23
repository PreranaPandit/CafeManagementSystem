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
    public partial class addition : Form
    {
        public addition()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            //information hiding ENCAPSULATION process

            Calculation obj = new Calculation();

            //getter and setter use

            obj._first = int.Parse(txtfirst.Text);
            obj._second = int.Parse(txtsecond.Text);

            int sum = obj.add();

            MessageBox.Show("sum is " + sum);



        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
