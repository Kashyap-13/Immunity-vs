using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Immunity
{
    public partial class Congrats : Form
    {
        public Congrats()
        {
            InitializeComponent();
        }

        private void Congrats_Load(object sender, EventArgs e)
        {
            
        }

        private void animation()
        {
            try
            {
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
        }

        private void Congrats_Activated(object sender, EventArgs e)
        {
            Thread exth = new Thread(new ThreadStart (this.animation));
     
        }
    }
}
