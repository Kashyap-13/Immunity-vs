using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Immunity
{
    public partial class Signup : Form
    {
        SqlConnection sqlconn;
        SqlCommand sqlcmd, sqlcmdIns;
        SqlDataReader sqldtread;
        String strConnString;
        //public Splash splashform = new Splash();

        public Signup()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Splash().Show();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("E:\\Studio Projects\\Immunity\\Immunity\\Assets\\ic_action_cancel_press.png");
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("E:\\Studio Projects\\Immunity\\Immunity\\Assets\\ic_action_cancel.png");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            strConnString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\STUDIO PROJECTS\IMMUNITY\IMMUNITY\Immunity_DB_NET.mdf;Integrated Security=True;Connect Timeout=30";
            sqlconn = new SqlConnection(strConnString);
            int count = 0;
            sqlconn.Open();
            sqlcmd = new SqlCommand("Select Id from [Login]", sqlconn);
            sqldtread = sqlcmd.ExecuteReader();
            
            while (sqldtread.Read())
                count++;
            
            //MessageBox.Show(bdate.Text);
            count++;
            sqlconn.Close();
            sqlconn.Open();

            sqlcmdIns = new SqlCommand("Insert into [Login](Id, fname, child_name, email, password, birthdate) values ('" + count.ToString() + "','" + text_fname.Text + "', '" + text_child_name.Text + "', '" + txt_email.Text + "', '" + text_pass.Text + "', '" + bdate.Text + "') ", sqlconn);

            int res = sqlcmdIns.ExecuteNonQuery();

            if (res == 1)
            {*/
                //done.Show();
                this.Close();
                new Congrats().Show();
           // }
            //sqlconn.Close();
            
            //sqlcmd.CommandType = CommandType.StoredProcedure;
            
            //sqlcmd.CommandText = "Login";
            //sqlcmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = text_fname.Text.Trim();
            //sqlcmd.Parameters.Add("@child_name", SqlDbType.VarChar).Value = text_child_name.Text.Trim();
            //sqlcmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txt_email.Text.Trim();
            //sqlcmd.Parameters.Add("@password", SqlDbType.VarChar).Value = text_pass.Text.Trim();
            //sqlcmd.Parameters.Add("@birthdate", SqlDbType.DateTime).Value = bdate.Text.Trim();
            //sqlcmd.Connection = sqlconn;
            
            //try
            //{
            //    sqlconn.Open();
            //    object obj = sqlcmd.ExecuteScalar();
            //    //lblMessage.Text = "Record inserted successfully. ID = " + obj.ToString();
            //    MessageBox.Show("Record inserted successfully. ID = " + obj.ToString());
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            //finally
            //{
                //sqlconn.Close();
            //    sqlconn.Dispose();
            //}
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
