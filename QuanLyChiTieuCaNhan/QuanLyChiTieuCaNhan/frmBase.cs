using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
        private readonly TransactionService transactionService = new TransactionService();
        public frmBase()
        {
            InitializeComponent();
            curentDaytimer.Interval = 1000;
            curentDaytimer.Start();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form_KeyDown);
        }
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnload.PerformClick();
            }
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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                frmAccount frmAccount = new frmAccount();
                frmAccount.ShowDialog();
                if (CurrentUser.Username != null && !string.IsNullOrEmpty(CurrentUser.FullName))
                {
                    lblXinChao.Text = "Welcome! " + CurrentUser.FullName;
                    btnDangNhap.Visible = false;
                    btnLogOut.Visible = true;
                    DisplayBalance();
                    DisplayExpense();
                    var listTransaction = transactionService.GetAllByUser(UserService.CurrentUser.UserID);
                    dgvChiTieuGanDay.Rows.Clear();
                    foreach (var item in listTransaction)
                    {
                        int index = dgvChiTieuGanDay.Rows.Add();
                        dgvChiTieuGanDay.Rows[index].Cells[0].Value = item.TransactionID;
                        dgvChiTieuGanDay.Rows[index].Cells[1].Value = item.TransactionName;
                        dgvChiTieuGanDay.Rows[index].Cells[2].Value = item.Date;
                        dgvChiTieuGanDay.Rows[index].Cells[3].Value = item.Note;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng đăng nhập để sử dụng ứng dụng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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


            if (total < 0)
            {
                lblBalance.Text = $"-{total:c}" + "đ";
                lblBalance.ForeColor = Color.Red;
                MessageBox.Show("Bạn đã tiêu vượt định mức Số Dư . Vui lòng Nhập thêm Số Dư");
            }
            else
            {
                lblBalance.Text = $"{total:c}" + "đ";
                lblBalance.ForeColor = Color.Green;
            }
        }

        private void DisplayExpense()
        {
            int currentUserId = CurrentUser.UserID;
            TransactionService transactionService = new TransactionService();


            decimal totalAmount = transactionService.GetTotalAmountExpense(currentUserId);

            lblExpense.Text = $"{totalAmount:c}" + "đ";
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            frmTransaction frmTransaction = new frmTransaction();
            frmTransaction.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport frmReport = new frmReport();
            frmReport.Show();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            DisplayBalance();
            DisplayExpense();
            var listTransaction = transactionService.GetAllByUser(UserService.CurrentUser.UserID);
            dgvChiTieuGanDay.Rows.Clear();
            foreach (var item in listTransaction)
            {
                int index = dgvChiTieuGanDay.Rows.Add();
                dgvChiTieuGanDay.Rows[index].Cells[0].Value = item.TransactionID;
                dgvChiTieuGanDay.Rows[index].Cells[1].Value = item.TransactionName;
                dgvChiTieuGanDay.Rows[index].Cells[2].Value = item.Date;
                dgvChiTieuGanDay.Rows[index].Cells[3].Value = item.Note;
            }
        }
    }
}
