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
    public partial class GenerateBill : Form
    {

        ItemClass itemclass = new ItemClass();
        GenerateBillBLL generateBillBll = new GenerateBillBLL();

        public GenerateBill()
        {
            InitializeComponent();
        }

        private void GenerateBill_Load(object sender, EventArgs e)
        {
            lblBillNo.Text = generateBillBll.insertBill();

            cmbSelectItem.DataSource = itemclass.retrieveItem();
            cmbSelectItem.DisplayMember = "Itemname";
            cmbSelectItem.ValueMember = "Itemid";
            cmbSelectItem.DisplayMember = lblRate.Text;
            



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCcode.Text == "")
            {
                MessageBox.Show("Fillup the Customer Code!!!");
                txtCcode.Focus();
                return;
            }
            else
            {
                int Billno = int.Parse(lblBillNo.Text);
                int Ccode = int.Parse(txtCcode.Text);
                int Itemid = (int)cmbSelectItem.SelectedValue;
                int Quantity = int.Parse(txtQuantity.Text);

                DataTable dt = generateBillBll.ItemBill(Billno, Ccode, Itemid, Quantity);

                dgItemDetails.DataSource = dt;

                lblTtotal.Text = generateBillBll.calculateSum(Billno);

                txtQuantity.Text = "";
            }
        }

        private void cmbSelectItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbSelectItem_SelectionChangeCommitted(object sender, EventArgs e)
        {

            int Itemid = (int)cmbSelectItem.SelectedValue;
            lblRate.Text = generateBillBll.loadCombo(Itemid);
        }

        private void txtCcode_TextChanged(object sender, EventArgs e)
        {
            if (txtCcode.Text == "")
            {
                lblCfname.Text = lblClname.Text = lblCaddress.Text = lblCgender.Text = lblCustomertypename.Text = "null";
            }
            else
            {
                int Ccode = int.Parse(txtCcode.Text);

                if (Ccode <= 0)
                {
                    MessageBox.Show("please enter the correct code for customer!!");
                }
                else
                {
                    DataTable dt = generateBillBll.customerCtype(Ccode);
                    lblCfname.Text = dt.Rows[0][0].ToString();
                    lblClname.Text = dt.Rows[0][1].ToString();
                    lblCaddress.Text = dt.Rows[0][2].ToString();
                    lblCgender.Text = dt.Rows[0][3].ToString();
                    lblCustomertypename.Text = dt.Rows[0][4].ToString();

                }

            }


        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscount.Text == "")
            {
                MessageBox.Show("Enter discount amount !!!");
                txtDiscount.Focus();
                return;
            }
            else
            {
                float Ttotal = float.Parse(lblTtotal.Text);
                float Discount = float.Parse(txtDiscount.Text);

                float Gtotal = Ttotal - Discount;
                float Vat = (13 / 100f) * Gtotal;
                float NetTotal = Gtotal + Vat;

                lblVat.Text = Vat.ToString();
                lblNetTotal.Text = NetTotal.ToString();
            }
        }

        public void displayBill(int Billno)
        {
            this.Hide();
            Bill bill = new Bill(Billno);
            bill.ShowDialog();
            this.Close();
        }


        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            int Billno = int.Parse(lblBillNo.Text);
            float Ttotal = float.Parse(lblTtotal.Text);
            float Discount = float.Parse(txtDiscount.Text);
            float Vat = float.Parse(lblVat.Text);
            float NetTotal = float.Parse(lblNetTotal.Text);

            generateBillBll.billDetailsquery(Billno, Ttotal, Discount, Vat, NetTotal);

            displayBill(Billno);

        }
    }
}
