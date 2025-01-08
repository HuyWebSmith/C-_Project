using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DAL.Models;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

namespace QuanLyChiTieuCaNhan
{
    public partial class frmTransaction : Form
    {

        private readonly CategoriesService categoriesService = new CategoriesService();
        private readonly TransactionService transactionService = new TransactionService();
        private readonly BudgetService budgetService = new BudgetService();
        public int currentUserId = CurrentUser.UserID;
        public int currentTransactionId;
        public frmTransaction()
        {
            InitializeComponent();
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            
            var listCategories = categoriesService.GetAllByUser(currentUserId);
            var listTransaction = transactionService.GetAllByUser(currentUserId);
            FillCombobox(listCategories);
            BridGrid();
        }
        public void FillCombobox(List<Categories> listCategories)
        {
            listCategories.Insert(0, new Categories { CategoryID = 0, CategoryName = "Chọn danh mục..." });
            this.cmbDanhMuc.DataSource = listCategories;
            this.cmbDanhMuc.DisplayMember = "CategoryName";
            this.cmbDanhMuc.ValueMember = "CategoryID";
            this.cmbDanhMuc.SelectedIndex = 0;  
        }
        
        public void BridGrid()
        {
            int currentUserId = CurrentUser.UserID;
            var listCategories = categoriesService.GetAllByUser(currentUserId);
            var listTransaction = transactionService.GetAllByUser(currentUserId);
            dgvTransaction.Rows.Clear();
            foreach (var item in listTransaction)
            {
                var index = dgvTransaction.Rows.Add();
                var categoriesName = (from tra in listTransaction
                                      join cat in listCategories on tra.CategoryID equals cat.CategoryID
                                      where cat.CategoryID == item.CategoryID
                                      select cat.CategoryName).FirstOrDefault();
                dgvTransaction.Rows[index].Cells[0].Value = categoriesName;
                dgvTransaction.Rows[index].Cells[1].Value = item.TransactionID;
                dgvTransaction.Rows[index].Cells[2].Value = item.TransactionName;
                dgvTransaction.Rows[index].Cells[3].Value = item.Amount;
                dgvTransaction.Rows[index].Cells[4].Value = item.Date;
                dgvTransaction.Rows[index].Cells[5].Value = item.Note;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtSoTienGiaoDich.Text) || !decimal.TryParse(txtSoTienGiaoDich.Text, out decimal amount))
                {
                    MessageBox.Show("Vui lòng nhập một số hợp lệ cho số tiền giao dịch.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmbDanhMuc.SelectedValue == null || (int)cmbDanhMuc.SelectedValue == 0)
                {
                    MessageBox.Show("Vui lòng chọn danh mục .", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                decimal budget = budgetService.GetBudgetByCategoryAndUser((int)cmbDanhMuc.SelectedValue, currentUserId);
                decimal Expense = transactionService.GetTotalAmountExpense(currentUserId);

                if (budget == 0)
                {
                    var result = MessageBox.Show(
                        "Danh mục này chưa được thiết lập ngân sách. Bạn có chắc muốn thêm giao dịch không?",
                        "Cảnh báo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.No)
                    {
                        return; 
                    }
                }
                else if (Expense + amount > budget)
                {
                    MessageBox.Show($"Số tiền giao dịch vượt quá ngân sách! Ngân sách tối đa cho danh mục là {budget:C}.",
                        "Cảnh báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }


                Transaction transaction = new Transaction
                {
                    CategoryID = (int)cmbDanhMuc.SelectedValue,
                    TransactionName = txtTenGiaoDich.Text,
                    Amount = amount,
                    Date = DateTime.Now,
                    Note = rtbGhiChu.Text,
                    UserID = currentUserId
                };

                transactionService.InsertTransaction(transaction);
                BridGrid();
                MessageBox.Show("Giao dịch đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void GetSelectRows(int selectedRow)
        {
            try
            {
                cmbDanhMuc.SelectedValue = dgvTransaction.Rows[selectedRow].Cells[0].Value ?? "";
                currentTransactionId = dgvTransaction.Rows[selectedRow].Cells[1].Value != null
                    ? Convert.ToInt32(dgvTransaction.Rows[selectedRow].Cells[1].Value)
                    : 0;
                txtTenGiaoDich.Text = dgvTransaction.Rows[selectedRow].Cells[2].Value?.ToString() ?? "";
                txtSoTienGiaoDich.Text = dgvTransaction.Rows[selectedRow].Cells[3].Value?.ToString() ?? "0";
                dtpNgayThucHien.Text = dgvTransaction.Rows[selectedRow].Cells[4].Value?.ToString() ?? DateTime.Now.ToString();
                rtbGhiChu.Text = dgvTransaction.Rows[selectedRow].Cells[5].Value?.ToString() ?? "";
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetSelectRows(e.RowIndex);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTransaction.CurrentRow != null)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int transactionId = Convert.ToInt32(dgvTransaction.CurrentRow.Cells[1].Value);

                        bool isDeleted = transactionService.DeleteTransaction(transactionId);

                        if (isDeleted)
                        {
  
                            dgvTransaction.Rows.Remove(dgvTransaction.CurrentRow);
                            MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hàng để xóa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTransaction_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = e.RowIndex;
            cmbDanhMuc.SelectedValue = dgvTransaction.Rows[selectedRow].Cells[0].Value;
            txtTenGiaoDich.Text = dgvTransaction.Rows[selectedRow].Cells[2].Value.ToString();
            txtSoTienGiaoDich.Text = dgvTransaction.Rows[selectedRow].Cells[3].Value.ToString();
            dtpNgayThucHien.Text = dgvTransaction.Rows[selectedRow].Cells[4].Value.ToString();
            rtbGhiChu.Text = dgvTransaction.Rows[selectedRow].Cells[5].Value.ToString();
            var result = MessageBox.Show($"{txtTenGiaoDich.Text}" + "    " +
                $"{txtSoTienGiaoDich.Text} VND" + "    " + $"{dtpNgayThucHien.Text}"
                + $"\nNote: {rtbGhiChu.Text}", "Thông tin chi tiết giao dịch", MessageBoxButtons.OK);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTransaction.CurrentRow != null)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật hàng này?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        // Kiểm tra số tiền giao dịch hợp lệ
                        if (string.IsNullOrEmpty(txtSoTienGiaoDich.Text) || !decimal.TryParse(txtSoTienGiaoDich.Text, out decimal amount))
                        {
                            MessageBox.Show("Vui lòng nhập một số hợp lệ cho số tiền giao dịch.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Kiểm tra danh mục hợp lệ
                        if (cmbDanhMuc.SelectedValue == null || (int)cmbDanhMuc.SelectedValue == 0)
                        {
                            MessageBox.Show("Vui lòng chọn danh mục.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }


                        // Tạo đối tượng giao dịch mới
                        Transaction newTransaction = new Transaction
                        {
                            TransactionID = currentTransactionId,
                            CategoryID = (int)cmbDanhMuc.SelectedValue,
                            TransactionName = txtTenGiaoDich.Text,
                            Amount = amount,
                            Date = DateTime.Now,
                            Note = rtbGhiChu.Text,
                            UserID = CurrentUser.UserID
                        };

                        // Lấy ngân sách và chi tiêu hiện tại của danh mục
                        decimal budget = budgetService.GetBudgetByCategoryAndUser(newTransaction.CategoryID, newTransaction.UserID);
                        decimal Income = transactionService.GetTotalAmountIncome(currentUserId);
                        decimal Expense = transactionService.GetTotalAmountExpense(currentUserId);
                        decimal total = Income - Expense;

                        // Kiểm tra nếu vượt ngân sách
                        if (budget == 0)
                        {
                            var results = MessageBox.Show(
                                "Danh mục này chưa được thiết lập ngân sách. Bạn có chắc muốn sửa giao dịch không?",
                                "Cảnh báo",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning);

                            if (results == DialogResult.No)
                            {
                                return;
                            }
                        }
                        else if (amount + total > budget)
                        {
                            var result2 = MessageBox.Show(
                                $"Số tiền giao dịch mới sẽ vượt ngân sách ({budget:C}). Bạn vẫn muốn tiếp tục sửa giao dịch không?",
                                "Cảnh báo vượt ngân sách",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning
                            );
                            if (result2 == DialogResult.Yes)
                            {
                                bool isUpdate1 = transactionService.UpdateTransaction(newTransaction);

                                if (isUpdate1)
                                {
                                    BridGrid();
                                }
                                else
                                {
                                    MessageBox.Show("Cập nhật thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                return;
                            }
                        }
                        // Thực hiện cập nhật
                        bool isUpdate = transactionService.UpdateTransaction(newTransaction);

                        if (isUpdate)
                        {
                            BridGrid(); 
                            MessageBox.Show("Cập nhật thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hàng để cập nhật.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
