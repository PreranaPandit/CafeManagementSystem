using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMangaementSystem
{
    class LoginBLL
    {
        //properties
        private string username;
        private string password;


        //getterand setter begins
        public string _username
        {
            get { return username; }
            set { username = value; }
        }

        public string _password
        {
            get { return password; }
            set { password = value; }
        }

        DbConnection conn = new DbConnection();

        public bool checkUser()
        {
            string query;
            query = "select username from Customer where username = '" + username + "' and password = '" + password + "'";
            DataTable dt = conn.Retrieve(query); 

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
