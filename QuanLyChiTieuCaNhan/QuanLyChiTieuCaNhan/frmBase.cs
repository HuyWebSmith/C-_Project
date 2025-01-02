using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL.Models;

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
            if (UserService.CurrentUser != null)
            {
                lblXinChao.Text = "Welcome, " + UserService.CurrentUser.FullName;
            }
            else
            {
                // Nếu chưa đăng nhập
                lblXinChao.Text = "Please log in";
                lblBalance.Text = $"N/A";
                lblExpense.Text = $"N/A";
            }
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
            lblXinChao.Text = "Welcome! " + CurrentUser.FullName;
            btnDangNhap.Visible = false;
            btnLogOut.Visible = true;
            DisplayBalance();
            DisplayExpense();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            CurrentUser.UserID = 0;
            CurrentUser.Username = string.Empty;
            CurrentUser.FullName = string.Empty;
            CurrentUser.Email = string.Empty;
            CurrentUser.Phone = string.Empty;
            DialogResult result = MessageBox.Show("Xác Nhận Đăng Xuất","Warning",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Đăng xuất thành công");
                lblXinChao.Text = "Welcome! ";
                btnDangNhap.Visible = true;
                btnLogOut.Visible = false;
                lblBalance.Text = $"N/A";
                lblExpense.Text = $"N/A";
            }   
        }

        private void DisplayBalance()
        {
            int currentUserId = CurrentUser.UserID; 
            TransactionService transactionService = new TransactionService();


            decimal Income = transactionService.GetTotalAmountIncome(currentUserId);
            decimal Expense = transactionService.GetTotalAmountExpense(currentUserId);
            decimal total = Income - Expense;
            lblBalance.Text = $"{total}" + "đ"; 
        }

        private void DisplayExpense()
        {
            int currentUserId = CurrentUser.UserID;
            TransactionService transactionService = new TransactionService();


            decimal totalAmount = transactionService.GetTotalAmountExpense(currentUserId);

            lblExpense.Text = $"{totalAmount}" + "đ";
        }
    }
}
