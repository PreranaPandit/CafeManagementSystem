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
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
        }

        ItemClass itemclass = new ItemClass();

        private void btnsave_Click(object sender, EventArgs e)
        {
            string Itemname;
            float Rate;
            Itemname = txtitemname.Text;
            Rate = float.Parse(txtrate.Text);

            //information hiding (encapsulation)


            //getter and setter

            //insert
            itemclass._Itemname = Itemname;
            itemclass._Rate = Rate;

            if (btnsave.Text == "Save")
            {

               

                itemclass.insertItem();


                dgData.DataSource = itemclass.retrieveItem();

            }
            else if (btnsave.Text == "UPDATE")
            {

               
               int Itemid = int.Parse(dgData.CurrentRow.Cells["Itemid"].Value.ToString());

                itemclass.updateItem(Itemid);
                btnsave.Text = "Save";
                dgData.DataSource = itemclass.retrieveItem();


            }



        }

       

        

        private void dgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Items_Load(object sender, EventArgs e)
        {
            dgData.DataSource = itemclass.retrieveItem();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            
            this.Close();       
        }

        
        DbConnection dbconnection = new DbConnection();
        private void dgData_Click(object sender, EventArgs e)
        {
            btnsave.Text = "UPDATE";
            int Itemid;
            int columnIndex = dgData.CurrentCell.ColumnIndex;
            Itemid = int.Parse(dgData.CurrentRow.Cells["Itemid"].Value.ToString());
            string query;
            DataTable dt;
            if (dgData.CurrentRow.Cells[columnIndex].Value.ToString()=="Edit")
            {
                query = "select Itemname, Itemrate from Items where Itemid =" + Itemid;
                dt = dbconnection.Retrieve(query);
               
                txtitemname.Text = dt.Rows[0][0].ToString();
                txtrate.Text = dt.Rows[0][1].ToString();
            }

            else if(dgData.CurrentRow.Cells[columnIndex].Value.ToString()=="Delete")
            {
                
                //displayinfo the interactive messagebox
                DialogResult confirmResult = MessageBox.Show("Are you sure to delete this item?","Confirm Delete?",MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    query = "delete from Items where Itemid=" + Itemid;

                    dbconnection.Manipulate(query);
                    ItemClass itemclass = new ItemClass();
                    dgData.DataSource = itemclass.retrieveItem();
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
