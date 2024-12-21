using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH.lab02_02
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
        }
        public static List<Faculty> Faculties = new List<Faculty>();
        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form1 form1 = new Form1();

            form1.TopLevel = false;
            form1.FormBorderStyle = FormBorderStyle.Sizable; 
            form1.Dock = DockStyle.Fill;

            pnBase.Controls.Add(form1);
            form1.Show();
        }

        private void Base_Load(object sender, EventArgs e)
        {

        }

        private void chuyênNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLy frmQuanLy = new frmQuanLy();

            frmQuanLy.TopLevel = false;
            frmQuanLy.FormBorderStyle = FormBorderStyle.Sizable;
            frmQuanLy.Dock = DockStyle.Fill;

            pnBase.Controls.Add(frmQuanLy);
            frmQuanLy.Show();
        }
    }
}
