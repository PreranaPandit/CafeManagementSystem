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
    public partial class CustomerType : Form
    {
        public CustomerType()
        {
            InitializeComponent();
        }

        //information hiding (encapsulation)

        CustomertypeClass customertypeclass = new CustomertypeClass();

        private void btnsave_Click(object sender, EventArgs e)
        {
            string Customertypename;
           
            Customertypename = txtcustomertypename.Text;

            //setter and getter

            customertypeclass._Customertypename = Customertypename;
            customertypeclass.insertCustomertype();
            dgData.DataSource = customertypeclass.retrieveCustomertype();

          

        }
       

        private void CustomerType_Load(object sender, EventArgs e)
        {

            dgData.DataSource = customertypeclass.retrieveCustomertype();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
