using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMangaementSystem
{
    class BillBLL
    {
        DbConnection dbConnection = new DbConnection();

        public DataTable CustomerDetails(int Billno)
        {
            String query;
            query = "select B.Billno, C.Ccode, C.Cfname, C.Clname, C.Caddress, C.Cgender,CT.Customertypename,B.Total,B.Discount, B.Vat, B.Nettotal from  Customer C, CustomerType CT, Bill B where B.Ccode = C.Ccode and C.Customertypeid = CT.Customertypeid and B.Billno = " + Billno;

            DataTable dt = dbConnection.Retrieve(query);
            return dt;
        }



        public DataTable ItemsDetails(int Billno)
        {
            String query;
            query = "select I.Itemname, I.Itemrate, IB.Quantity, IB.Ltotal from Bill B, Items I, ItemBill IB where B.Billno = IB.Billno and I.Itemid = IB.Itemid and B.Billno = " + Billno;

            DataTable dt = dbConnection.Retrieve(query);
            return dt;
        }

    }
}
