using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMangaementSystem
{
    class CustomerClass
    {

        //properties
        private string Cfname;
        private string Clname;
        private string Caddress;
        private char Cgender;
        private string Username;
        private string Password;
        private int Customertypeid;
        

        public CustomerClass()
        {

        }
        public CustomerClass(string Cfname, string Clname, string Caddress, char Cgender, string Username, string Password, int Customertypeid)
        {
            this.Cfname = Cfname;
            this.Clname = Clname;
            this.Caddress = Caddress;
            this.Cgender = Cgender;
            this.Username = Username;
            this.Password = Password;
            this.Customertypeid = Customertypeid;
        }



        //getter and setter for all labels
        public string _Cfname
        {
            get { return Cfname; }
            set { this.Cfname = value; }
        }
        public string _Clname
        {
            get { return Clname; }
            set { this.Clname = value; }
        }
        public string _Caddress
        {
            get { return Caddress; }
            set { this.Caddress = value; }
        }
        public char _Cgender
        {
            get { return Cgender; }
            set { this.Cgender = value; }
        }
        public string _Username
        {
            get { return Username; }
            set { this.Username = value; }
        }
        public string _Password
        {
            get { return Password; }
            set { this.Password = value; }
        }
        public int _Customertypeid
        {
            get { return Customertypeid; }
            set { this.Customertypeid = value; }
        }


        //Database Connection
        DbConnection dbconnection = new DbConnection();

        //insertion 
        public void insertCustomer()
        {
            String query;

            query = "Insert into Customer(Cfname,Clname,Caddress,Cgender,Username,Password,Customertypeid)values('" + Cfname + "','" + Clname + "','" + Caddress + "','" + Cgender + "','" + Username + "','" + Password + "'," + Customertypeid + ")";
      
            dbconnection.Manipulate(query);
        }


        //selection
        public DataTable retrieveCustomer()
        {
            string query;
           query = "select C.Ccode, C.Cfname, C.Clname, C.Caddress, C.Cgender, C.Username, C.Password, CT.Customertypename from Customer C, Customertype CT where C.Customertypeid = CT.Customertypeid";

            DataTable dt = dbconnection.Retrieve(query);
            return dt;
                                
        }


        //update
        public void updateCustomer(int Ccode)
        {
            string updateCustomer;
            updateCustomer = "Update Customer set Cfname='" + Cfname + "', Clname='" + Clname + "',Caddress='" + Caddress + "',Cgender='" + Cgender + "',Username='" + Username + "',Password='" + Password + "',Customertypeid='" + Customertypeid + "' where Ccode = " + Ccode;
            dbconnection.Manipulate(updateCustomer);

        }

    }
}
