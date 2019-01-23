using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMangaementSystem
{
    class GenerateBillBLL
    {

        DbConnection dbConnection = new DbConnection();

        
        public DataTable customerCtype(int Ccode)
        {
            String query;
            query = "select C.Cfname, C.Clname, C.Caddress, C.Cgender, C.Username, C.Password, CT.Customertypename from Customer C, CustomerType CT where C.Customertypeid = CT.Customertypeid and C.Ccode = " + Ccode;

            DataTable dt = dbConnection.Retrieve(query);
            return dt;
        }


        public string loadCombo(int Itemid)
        {
            String query;
            query = "select Itemrate from Items where Itemid = " + Itemid;

            DataTable dt = dbConnection.Retrieve(query);
            return dt.Rows[0][0].ToString();
        }


        public String insertBill()
        {
            String query;
            query = "insert into Bill(Ccode, Total, Discount, Vat, Nettotal) values(null,null,null,null,null);";
            dbConnection.Manipulate(query);

            String listBill = "select top 1 Billno from Bill order by Billno desc";

            DataTable dt = dbConnection.Retrieve(listBill);
            return dt.Rows[0][0].ToString();
        }



        public DataTable ItemBill(int Billno, int Ccode, int Itemid, int Quantity)
        {

            String updateQuery = "update Bill set Ccode = " + Ccode + "where Billno = " + Billno;

            String totalQuery = "(select I.Itemrate from Items I where Itemid = " + Itemid + ") * " + Quantity;

            String ItemBill = "insert into ItemBill(Billno, Itemid, Quantity, Ltotal) values(" + Billno + "," + Itemid + "," + Quantity + "," + totalQuery + ")";

            dbConnection.Manipulate(updateQuery);
            dbConnection.Manipulate(ItemBill);

            String selectQuery = "select I.Itemname, I.Itemrate, IB.Quantity, IB.Ltotal from Items I, ItemBill ib where I.Itemid = IB.Itemid and Billno = +" + Billno + ";";

            DataTable dt = dbConnection.Retrieve(selectQuery);
            return dt;
        }



        public String calculateSum(int Billno)
        {
            String query;
            query = "select SUM(Ltotal) from ItemBill where Billno = " + Billno;

            DataTable dt = dbConnection.Retrieve(query);
            return dt.Rows[0][0].ToString();
        }


        public void billDetailsquery(int Billno, float Total, float Discount, float Vat, float Nettotal)
        {
            String query;
            query = "update Bill set Total = " + Total + ", Discount = " + Discount + ", Vat = " + Vat + ", Nettotal = " + Nettotal + " where billNo = " + Billno;
            dbConnection.Manipulate(query);
        }

    }
}
