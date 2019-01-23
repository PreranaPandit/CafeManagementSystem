using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMangaementSystem
{
    class CustomertypeClass
    {
        //properties
        private string Customertypename;
        

        public CustomertypeClass()
        {

        }
        public CustomertypeClass(string Customertypename)
        {
            this.Customertypename = Customertypename;
            
        }



        //getter and setter for both labels
        public string _Customertypename
        {
            get { return Customertypename; }
            set { this.Customertypename = value; }
        }
       

        //Database Connection
        DbConnection dbconnection = new DbConnection();

        //insertion 
        public void insertCustomertype()
        {
            String query;
            query = "Insert into CustomerType(Customertypename)values('" + Customertypename + "')";
            dbconnection.Manipulate(query);
        }


        //selection
        public DataTable retrieveCustomertype()
        {
            string query;
            query = "select Customertypeid, Customertypename from CustomerType";

            DataTable dt = dbconnection.Retrieve(query);
            return dt;

        }
    }
}
