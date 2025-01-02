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
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            panel2.Enabled = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            panel1.Enabled = false;
        }
    }
}
