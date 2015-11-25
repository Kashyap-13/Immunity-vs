using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.Mail;
using System.Data.SqlClient;

namespace Immunity
{
    public partial class Dashboard : Form
    {
        SqlConnection sqlconn;
        SqlCommand sqlcmd, sqlcmdIns;
        SqlDataReader sqldtread;
        String strConnString;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("E:\\Studio Projects\\Immunity\\Immunity\\Assets\\ic_action_cancel_press.png");
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("E:\\Studio Projects\\Immunity\\Immunity\\Assets\\ic_action_cancel.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox3.BackgroundImage = Image.FromFile("E:\\Studio Projects\\Immunity\\Immunity\\Assets\\edit_clicked.png");
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox3.BackgroundImage = Image.FromFile("E:\\Studio Projects\\Immunity\\Immunity\\Assets\\edit.png");
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox4.BackgroundImage = Image.FromFile("E:\\Studio Projects\\Immunity\\Immunity\\Assets\\delete_clicked.png");
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox4.BackgroundImage = Image.FromFile("E:\\Studio Projects\\Immunity\\Immunity\\Assets\\delete_normal.png");
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {/*
            strConnString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\STUDIO PROJECTS\IMMUNITY\IMMUNITY\Immunity_DB_NET.mdf;Integrated Security=True;Connect Timeout=30";
            sqlconn = new SqlConnection(strConnString);
            
            sqlconn.Open();
            
            sqlcmd = new SqlCommand("Select child_name from [Login] where fname = '" + _Session_fname + "'", sqlconn);
            sqldtread = sqlcmd.ExecuteReader();

            while (sqldtread.Read())
                lbl_child_name.Text = sqldtread["birthdate"].ToString();
            sqlconn.Close();
            */
            //notifyIcon1.Icon = SystemIcons.Application;
            //notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            //notifyIcon1.BalloonTipText = "Samuel's Next dosage dues after 4 Days..";
            //notifyIcon1.BalloonTipTitle = "Immunity";
            //notifyIcon1.ShowBalloonTip(500);
            //notifyIcon1.Dispose
        }

        protected string SendEmail(string toAddress, string subject, string body)
        {
            string result = "Message Sent Successfully..!!";
     
            try
            {
                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com", // smtp server address here…
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new System.Net.NetworkCredential(senderID, senderPassword),
                    Timeout = 30000,
                };
                
                MailMessage message = new MailMessage(senderID, toAddress, subject, body);
                smtp.Send(message);
            }
     
            catch (Exception ex)
            {
                result = "Error sending email.!!!"  + ex.Message;
            }
            
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string res = SendEmail("ravidudhatra@gmail.com", "Hello", "This is a body.");
            MessageBox.Show(res);
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox5.BackgroundImage = Image.FromFile("E:\\Studio Projects\\Immunity\\Immunity\\Assets\\add_pressed.png");
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox5.BackgroundImage = Image.FromFile("E:\\Studio Projects\\Immunity\\Immunity\\Assets\\add.png");
        }
    }
}
