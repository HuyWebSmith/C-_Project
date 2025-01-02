using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChiTieuCaNhan
{
    public partial class frmBase : Form
    {
        bool sidebarExpand;
        public frmBase()
        {
            InitializeComponent();
            curentDaytimer.Interval = 1000;
            curentDaytimer.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            // Dat min va max size sidebar panel
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            
        }

        private void curentDaytimer_Tick(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            lblDate.Text = currentDate.ToString("dd/MM/yyyy HH:mm:ss"); ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAccount frmAccount = new frmAccount();
            frmAccount.ShowDialog();
        }
    }
}
