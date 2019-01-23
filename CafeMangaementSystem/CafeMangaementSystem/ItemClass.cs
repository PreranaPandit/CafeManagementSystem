using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMangaementSystem
{
    class ItemClass
    {
        //properties
        private string Itemname;
        private float Rate;

        public ItemClass()
        {

        }
        public ItemClass(string Itemname, float Rate)
        {
            this.Itemname = Itemname;
            this.Rate = Rate;
        }

      

        //getter and setter for both labels
        public string _Itemname
        {
            get { return Itemname; }
            set { this.Itemname = value; }
        }
        public float _Rate
        {
            get { return Rate; }
            set { this.Rate = value; }
        }

        //Database Connection
        DbConnection dbconnection = new DbConnection();

        //insertion 
        public void insertItem()
        {
            String query;
            query = "Insert into Items(Itemname,Itemrate)values('" + Itemname + "'," + Rate + ")";
            dbconnection.Manipulate(query);            
        }


        //selection
        public DataTable retrieveItem()
        {
            string query;
            query = "select Itemid, Itemname, Itemrate from Items order by ItemName";

            DataTable dt = dbconnection.Retrieve(query);
            return dt;
        
        }

        //update
        public void updateItem(int itemId)
        {
            string updateItem;
            updateItem = "Update Items set Itemname='"+Itemname+"', Itemrate='"+Rate+"' where Itemid = " + itemId + "";
            dbconnection.Manipulate(updateItem);
         
        }

      
        
    }
}
