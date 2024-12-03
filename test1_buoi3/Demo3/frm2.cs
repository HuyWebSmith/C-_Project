using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Demo3
{
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }
        public NhanVien nv {  get; set; }
        private void btnDongY_Click(object sender, EventArgs e)
        {
            nv = new NhanVien();
            {
                nv.mssv = txtMSSV.Text;
                nv.name = txtTen.Text;
                nv.luongCB = int.Parse(txtLuongCB.Text);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void frm2_Load(object sender, EventArgs e)
        {
           
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
