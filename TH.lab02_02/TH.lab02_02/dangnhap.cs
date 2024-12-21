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
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text;
            string password = txtMatKhau.Text;

            
            if (IsValidLogin(username, password))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide(); 
                dangnhap dangnhap = new dangnhap();
                frmBase frm = new frmBase();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private bool IsValidLogin(string username, string password)
        {
            string validUsername = "quanghuy";
            string validPassword = "123456";

            return username == validUsername && password == validPassword;
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
