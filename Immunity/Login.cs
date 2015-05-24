using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Immunity
{
    public partial class Login : Form
    {
        //SqlConnection sqlconn;
        //SqlCommand sqlcmd, sqlcmdIns;
        //SqlDataReader sqldtread;
        //String strConnString, result1, result2;
        //int count = 0;

        Session sessionnm = new Session();

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (text_email.TextLength != 0 && text_pass.TextLength != 0)
            {
                string session_var = sessionnm.CreateSession(text_email.Text, text_pass.Text);

                if (session_var == null)
                    MessageBox.Show("Username or password Invalid. Please Try Again..", "Immunity");
                else
                {
                    new Dashboard().Show();
                    this.Visible = false;
                }
            }
            else
                MessageBox.Show("Please Enter Username or Password first..!!", "Immunity");
            /*
            strConnString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\STUDIO PROJECTS\IMMUNITY\IMMUNITY\Immunity_DB_NET.mdf;Integrated Security=True;Connect Timeout=30";
            sqlconn = new SqlConnection(strConnString);
            String query = "select email from Login;" + "select password from Login;";
            sqlconn.Open();
            sqlcmd = new SqlCommand();

            sqlcmd.Connection = sqlconn;
            sqlcmd.CommandText = query;
            
            sqldtread = sqlcmd.ExecuteReader();
            
            while (sqldtread.Read())
            {
                result1  += sqldtread["email"].ToString() + "\n";
                count++;
            }
            
            for (int i = 0; i < count; i++)
            {
                if (result1[i].CompareTo(text_email.Text))
                    MessageBox.Show("Great");

                else
                    MessageBox.Show("Boo");
            }
            count=0;
             */

//            MessageBox.Show(result1.CompareTo(text_email.Text).ToString());
            /*
                if (result1.CompareTo(text_email.Text) == 1)
                {
                    //for password
                    if (sqldtread.NextResult())
                    {
                        while (sqldtread.Read())
                            result2 += sqldtread["password"].ToString() + "\n";

                        if (result2.CompareTo(text_pass.Text) == 1)
                            MessageBox.Show("Successful.");
                    }

                    else
                    {
                        MessageBox.Show("Password Invalid.");
                    }
                }
                else
                    MessageBox.Show("Username Invalid.");
                sqlconn.Close();*/
        }

        private void close_pic_Click(object sender, EventArgs e)
        {
            this.Close();
            new Splash().Show();
        }
    }
}
