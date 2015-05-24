using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immunity
{
    class Session
    {
        public string _Session_fname = null;
        public SqlConnection sqlconn, sqlcon;
        public SqlCommand sqlcmd, sqlcmd2;
        public SqlDataReader sqldtread, sqlreader;
        public String strConnString;

        public Session()
        {
            strConnString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\STUDIO PROJECTS\IMMUNITY\IMMUNITY\Immunity_DB_NET.mdf;Integrated Security=True;Connect Timeout=30";
            sqlconn = new SqlConnection(strConnString);
            sqlcon = new SqlConnection(strConnString);
        }

        public string CreateSession(string email, string password)
        {
            string query;
            sqlconn.Open();

            query = "Select email from [Login]";
            sqlcmd = new SqlCommand(query, sqlconn);

            sqldtread = sqlcmd.ExecuteReader();
            
            while (sqldtread.Read())
            {
                if (sqldtread["email"].Equals(email))
                {
                    sqlcon.Open();
                    sqlcmd2 = new SqlCommand("Select password from [Login] where email = '" + sqldtread["email"].ToString() + "' ", sqlcon);
                    sqlreader = sqlcmd2.ExecuteReader();

                    sqlreader.Read();
                    
                    if (sqlreader["password"].Equals(password))
                        _Session_fname = email;
                    sqlcon.Close();
                }
            }

            sqlconn.Close();
            return _Session_fname;
        }
    }
}