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
    public partial class Bill : Form
    {


        private int Billno;

        public Bill(int Billno)
        {
            InitializeComponent();
            this.Billno = Billno;
        }

        private void Bill_Load(object sender, EventArgs e)
        {

            BillBLL billBll = new BillBLL();

            DataTable customerDetail = billBll.CustomerDetails(Billno);

            DataTable itemsDetail = billBll.ItemsDetails(Billno);


            lblBillNo.Text = customerDetail.Rows[0][0].ToString();
            lblCcode.Text = customerDetail.Rows[0][1].ToString();
            lblCfname.Text = customerDetail.Rows[0][2].ToString();
            lblClname.Text = customerDetail.Rows[0][3].ToString();
            lblCaddress.Text = customerDetail.Rows[0][4].ToString();
            lblCgender.Text = customerDetail.Rows[0][5].ToString();
            lblCustomerType.Text = customerDetail.Rows[0][6].ToString();
            lblTtotal.Text = customerDetail.Rows[0][7].ToString();
            lblDiscount.Text = customerDetail.Rows[0][8].ToString();
            lblVat.Text = customerDetail.Rows[0][9].ToString();
            lblNetTotal.Text = customerDetail.Rows[0][10].ToString();


            dgItemDetails.DataSource = billBll.ItemsDetails(Billno);


        }
    }
}
