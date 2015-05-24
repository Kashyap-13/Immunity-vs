using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Immunity
{
    public partial class Splash : Form
    {

        public Splash()
        {
            InitializeComponent();
        }

        private void close_pic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_pic_MouseDown(object sender, MouseEventArgs e)
        {
            close_pic.BackgroundImage = Image.FromFile("E:\\Studio Projects\\Immunity\\Immunity\\Assets\\ic_action_cancel_press.png");
        }

        private void close_pic_MouseUp(object sender, MouseEventArgs e)
        {
            close_pic.BackgroundImage = Image.FromFile("E:\\Studio Projects\\Immunity\\Immunity\\Assets\\ic_action_cancel.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Signup().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Login().Show();
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
    }
}
