using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMangaementSystem
{
    class DbConnection
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-FCBC4PK\SQLEXPRESS;Initial Catalog=CMS;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        //insert,update,delete
        public void Manipulate(string query)
        {
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        //select
        public DataTable Retrieve(string query)
        {
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(query, cn);
            da.Fill(ds);
            return ds.Tables[0];

        }


    }
}
