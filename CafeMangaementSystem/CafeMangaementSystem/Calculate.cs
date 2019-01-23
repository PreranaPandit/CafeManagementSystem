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
    public partial class Calculate : Form
    {
        public Calculate()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            if (txtfirst.Text == "")
            {
                MessageBox.Show("please enter first number!!!");
                txtfirst.Focus();
                return;
            }
            if (txtsecond.Text == "")
            {
                MessageBox.Show("please enter second number!!!");
                txtsecond.Focus();
                return;
            }

            double firstno, secondno;
            firstno = double.Parse(txtfirst.Text);
            secondno = double.Parse(txtsecond.Text);

            Arithemetic obj = new Arithemetic(firstno,secondno);

            if (Rdoadd.Checked)
            {
                MessageBox.Show("Addition of two numbers is:" + obj.Add());
            }

            if (Rdosub.Checked)
            {
                MessageBox.Show("Subtraction of two numbers is:" + obj.Sub());
            }

            if (Rdomul.Checked)
            {
                MessageBox.Show("Multiplication of two numbers is:" + obj.Mul());
            }

            if (Rdodiv.Checked)
            {
                MessageBox.Show("Division of two numbers is:" + obj.Div());
            }



        }

        private void txtfirst_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
