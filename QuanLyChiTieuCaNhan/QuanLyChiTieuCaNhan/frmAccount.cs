using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL.Models;
using DAL;

namespace QuanLyChiTieuCaNhan
{
    public partial class frmAccount : Form
    {
        private readonly UserService _userService = new UserService();
        private readonly CategoriesService categoriesService = new CategoriesService();

        public frmAccount()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            panel2.Enabled = false;

            txtUserNameCrea.SetPlaceholder("User Name");
            txtPasswordCrea.SetPlaceholder("Password");
            txtFullName.SetPlaceholder("Full Name");
            txtEmail.SetPlaceholder("Email");
            txtPhone.SetPlaceholder("Phone");
            txtUserNameLog.SetPlaceholder("User Name");
            txtPasswordLog.SetPlaceholder("Password");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            panel1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            txtUserNameCrea.SetPlaceholder("User Name");
            txtPasswordCrea.SetPlaceholder("Password");
            txtFullName.SetPlaceholder("Full Name");
            txtEmail.SetPlaceholder("Email");
            txtPhone.SetPlaceholder("Phone");
            txtUserNameLog.SetPlaceholder("User Name");
            txtPasswordLog.SetPlaceholder("Password");
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            
            if (_userService.IsUsernameHas(txtUserNameCrea.Text))
            {
                MessageBox.Show("Tài Khoản Đã Tồn Tại Vui Lòng Thử Lại");
            }
            else
            {
                DAL.User newUser = new DAL.User
                {
                    Username = txtUserNameCrea.Text,
                    Password = txtPasswordCrea.Text,
                    FullName = txtFullName.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                };
                _userService.InsertUser(newUser);
                categoriesService.insertCategory(newUser.UserID);
                MessageBox.Show("Tạo Tài Khoản Thành Công");
                DialogResult result = MessageBox.Show("Đã có tài khoản đăng nhập?",
                    "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    panel1.Enabled = true;
                    panel2.Enabled = false;

                    txtUserNameCrea.SetPlaceholder("User Name");
                    txtPasswordCrea.SetPlaceholder("Password");
                    txtFullName.SetPlaceholder("Full Name");
                    txtEmail.SetPlaceholder("Email");
                    txtPhone.SetPlaceholder("Phone");
                    txtUserNameLog.SetPlaceholder("User Name");
                    txtPasswordLog.SetPlaceholder("Password");
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Gọi phương thức Login từ _userService và kiểm tra kết quả
            var userLog = _userService.Login(txtUserNameLog.Text, txtPasswordLog.Text);
            if (userLog != null) 
            {
                MessageBox.Show("Đăng Nhập Thành Công", "Đăng Nhập", MessageBoxButtons.OK);
                CurrentUser.UserID = userLog.UserID;
                CurrentUser.Username = userLog.Username;
                CurrentUser.FullName = userLog.FullName;
                CurrentUser.Email = userLog.Email;
                CurrentUser.Phone = userLog.Phone;
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Không Chính Xác","Đăng Nhập", MessageBoxButtons.RetryCancel);
            }
        }
    }
}
