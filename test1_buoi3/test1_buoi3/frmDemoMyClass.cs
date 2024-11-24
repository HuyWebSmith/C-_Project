using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2_Buoi3
{
    public partial class frmDemoMyClass : Form
    {
        public frmDemoMyClass()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            string GioiTinh = rbtnNam.Checked ? "Nam" : "Nữ";
            string ngaysinh = dtpNgaySinh.Value.ToString("dd/MM/yyyy");

            List<string> sothich = new List<string>();
            if(cbxTheThao.Checked) sothich.Add("Thể thao");
            if (cbxDuli.Checked) sothich.Add("Du lịch");
            if (cbxPhim.Checked) sothich.Add("Phim ảnh");

            string thongtin = $"Họ và tên: {txtHoTen.Text}"
                              + $"\nGiới tính: {GioiTinh}"
                              + $"\nNgày sinh: {ngaysinh}";
                              
            DialogResult res = MessageBox.Show(thongtin, "Thông tin người dùng"
                                , MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
            if (res == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
