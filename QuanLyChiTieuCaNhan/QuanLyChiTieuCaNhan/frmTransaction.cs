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
                // Kiểm tra xem giá trị nhập vào có hợp lệ không

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
                Transaction transaction = new Transaction
                {
                    CategoryID = (int)cmbDanhMuc.SelectedValue,
                    TransactionName = txtTenGiaoDich.Text,
                    Amount = decimal.Parse(txtSoTienGiaoDich.Text),
                    Date = DateTime.Now,
                    Note = rtbGhiChu.Text,
                    UserID = CurrentUser.UserID
                };

                
                transactionService.InsertTransaction(transaction);
                BridGrid(); // Làm mới dữ liệu trên lưới
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
                        if (cmbDanhMuc.SelectedValue == null)
                        {
                            MessageBox.Show("Vui lòng chọn danh mục hợp lệ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        Transaction newTransaction = new Transaction
                        {
                            CategoryID = (int)cmbDanhMuc.SelectedValue,
                            TransactionID = currentTransactionId,
                            TransactionName = txtTenGiaoDich.Text,
                            Amount = decimal.Parse(txtSoTienGiaoDich.Text),
                            Date = DateTime.Now,
                            Note = rtbGhiChu.Text,
                            UserID = CurrentUser.UserID
                        };
                        decimal? budget = budgetService.GetBudgetByCategoryAndUser(newTransaction.CategoryID, newTransaction.UserID);
                        var tongSoDu = transactionService.GetTotalExpensesByCategoryAndUser(newTransaction.CategoryID, newTransaction.UserID);
                        if (tongSoDu + newTransaction.Amount > budget)
                        {

                            var results = MessageBox.Show(
                                "Số tiền giao dịch vượt quá ngân sách. Bạn có muốn tiếp tục sửa giao dịch không?",
                                "Cảnh báo vượt ngân sách",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning
                            );
                            
                            if (results == DialogResult.No)
                            {
                                return;
                            }
                            else
                            {
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
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hàng để Cập nhật.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
