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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        CustomerClass customerclass = new CustomerClass(); 

        private void btnsave_Click(object sender, EventArgs e)
        {
            string Cfname;
            string Clname;
            string Caddress;
            char Cgender;
            string Username;
            String Password;
            int Customertypeid;

            Cfname = txtcfname.Text;
            Clname = txtclname.Text;
            Caddress = txtcaddress.Text;
            Username = txtusername.Text;
            Password = txtpassword.Text;
            Customertypeid = (int)cmbcustomertypeid.SelectedValue;

            //validation for gender
            if (rdofemale.Checked)
            {
                Cgender = 'F';
            }
            else if (rdomale.Checked)
            {
                Cgender = 'M';
            }
            else
            {
                MessageBox.Show("please do not leave the gender section unchecked !!!");
                return;
            }


            //getter and setter

            customerclass._Cfname = Cfname;
            customerclass._Clname = Clname;
            customerclass._Caddress = Caddress;
            customerclass._Cgender = Cgender;
            customerclass._Username = Username;
            customerclass._Password = Password;
            customerclass._Customertypeid = Customertypeid;

            //SAVE Code begins
            if (btnsave.Text == "Save")
            {
                customerclass.insertCustomer();
                MessageBox.Show("Rows are inserted!!");

                Dgdata.DataSource = customerclass.retrieveCustomer();
            }
            //UPDATE Code begins
            else if (btnsave.Text == "UPDATE")
            {
                int Ccode;
                Ccode = Ccode = int.Parse(Dgdata.CurrentRow.Cells["Ccode"].Value.ToString());

                customerclass.updateCustomer(Ccode);
                MessageBox.Show("Rows are updated bt th user!!!!");
                btnsave.Text = "SAVE";
                Dgdata.DataSource = customerclass.retrieveCustomer();
            }
        
           

           
        }

        

        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        CustomertypeClass customertypeclass = new CustomertypeClass();
        private void Customer_Load(object sender, EventArgs e)
        {
            
            Dgdata.DataSource = customerclass.retrieveCustomer();        

            cmbcustomertypeid.DataSource = customertypeclass.retrieveCustomertype();
            cmbcustomertypeid.DisplayMember = "Customertypename";
            cmbcustomertypeid.ValueMember = "Customertypeid";
        }

        private void Dgdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbcustomertypeid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        DbConnection dbconnection = new DbConnection();
        private void Dgdata_Click(object sender, EventArgs e)
        {
            btnsave.Text = "UPDATE";
            int Ccode;
            int columnIndex = Dgdata.CurrentCell.ColumnIndex;
            Ccode = int.Parse(Dgdata.CurrentRow.Cells["Ccode"].Value.ToString());

            string query;
            DataTable dt;

            if (Dgdata.CurrentRow.Cells[columnIndex].Value.ToString() == "Edit")
            {
                query = "Select Cfname,Clname,Caddress,Cgender,Username,Password,Customertypeid from Customer where Ccode =" + Ccode;
                dt = dbconnection.Retrieve(query);
                txtcfname.Text = dt.Rows[0][0].ToString();
                txtclname.Text = dt.Rows[0][1].ToString();
                txtcaddress.Text = dt.Rows[0][2].ToString();
                lblcgender.Text = dt.Rows[0][3].ToString();
               
                txtusername.Text = dt.Rows[0][4].ToString();
                txtpassword.Text = dt.Rows[0][5].ToString();
                cmbcustomertypeid.Text = dt.Rows[0][6].ToString();

            }
            else if (Dgdata.CurrentRow.Cells[columnIndex].Value.ToString() == "Delete")
            {

                //displayinfo the interactive messagebox
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete?", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    query = "delete from Customer where Ccode=" + Ccode;

                    dbconnection.Manipulate(query);
                    CustomerClass customerClass = new CustomerClass();
                    Dgdata.DataSource = customerClass.retrieveCustomer();
                    MessageBox.Show("One row is deleted!!!");

                }
                else
                {
                    MessageBox.Show("Any row is not deleted");
                }
            }
        }
    }
}
