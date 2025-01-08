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
using DAL;
using DAL.Models;

namespace QuanLyChiTieuCaNhan
{
    public partial class frmBudget : Form
    {
        public frmBudget()
        {
            InitializeComponent();
        }
        private readonly CategoriesService categoriesService = new CategoriesService();
        private readonly BudgetService budgetService = new BudgetService();
        public int currentUserId = CurrentUser.UserID;
        public int currentBudgetId;
        private void frmBudget_Load(object sender, EventArgs e)
        {
             var listCategories = categoriesService.GetAllByUser(currentUserId);
            var listBudget = budgetService.GetAllByUser(currentUserId);
            FillCombobox(listCategories);
            BridGrid();
            
        }
        public bool ischecked(DateTime endDate)
        {
            DateTime currentDate = DateTime.Now;

            if (currentDate >= endDate)
            {
                MessageBox.Show("Có mục trong danh sách đã đến ngày kết thúc. Vui lòng xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
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
            var listBudget = budgetService.GetAllByUser(currentUserId);
            dgvBudget.Rows.Clear();
            foreach (var item in listBudget)
            {
                var index = dgvBudget.Rows.Add();
                var categoriesName = (from bud in listBudget
                                      join cat in listCategories on bud.CategoryID equals cat.CategoryID
                                      where cat.CategoryID == item.CategoryID
                                      select cat.CategoryName).FirstOrDefault();
                dgvBudget.Rows[index].Cells[0].Value = item.BudgetID;
                dgvBudget.Rows[index].Cells[1].Value = item.BudgetName;
                dgvBudget.Rows[index].Cells[2].Value = categoriesName;
                dgvBudget.Rows[index].Cells[3].Value = item.StartDate;
                dgvBudget.Rows[index].Cells[4].Value = item.EndDate;
                dgvBudget.Rows[index].Cells[5].Value = item.AmountLimit;
                if (ischecked(item.EndDate))
                {
                    MessageBox.Show($"{item.BudgetName} đã hết hạn.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    Console.WriteLine("Vẫn còn trong hạn.");
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Budget budget = new Budget
            {
                CategoryID = (int)cmbDanhMuc.SelectedValue,
                BudgetName = txtTenNganSach.Text,
                StartDate = DateTime.Parse(dtpNgayBatDau.Text),
                EndDate = DateTime.Parse(dtpNgayKetThuc.Text),
                AmountLimit = decimal.Parse(txtGioiHanChiTieu.Text),
                UserID = CurrentUser.UserID
            };
            budgetService.InsertBudget(budget);
            BridGrid();
        }
        public void GetSelectRows(int selectedRow)
        {
            currentBudgetId = Convert.ToInt32(dgvBudget.Rows[selectedRow].Cells[0].Value);
            txtTenNganSach.Text = dgvBudget.Rows[selectedRow].Cells[1].Value.ToString();
            cmbDanhMuc.SelectedItem = dgvBudget.Rows[selectedRow].Cells[2].Value;
            dtpNgayBatDau.Text = dgvBudget.Rows[selectedRow].Cells[3].Value.ToString();
            dtpNgayKetThuc.Text = dgvBudget.Rows[selectedRow].Cells[4].Value.ToString();
            txtGioiHanChiTieu.Text = dgvBudget.Rows[selectedRow].Cells[5].Value.ToString();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBudget.CurrentRow != null)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int budgetId = Convert.ToInt32(dgvBudget.CurrentRow.Cells[0].Value);

                        bool isDeleted = budgetService.DeleteBudget(budgetId);

                        if (isDeleted)
                        {

                            dgvBudget.Rows.Remove(dgvBudget.CurrentRow);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBudget.CurrentRow != null)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật hàng này?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        if (cmbDanhMuc.SelectedValue == null)
                        {
                            MessageBox.Show("Vui lòng chọn danh mục hợp lệ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        Budget newBudget = new Budget
                        {
                            CategoryID = (int)cmbDanhMuc.SelectedValue,
                            BudgetID = currentBudgetId,
                            BudgetName = txtTenNganSach.Text,
                            StartDate = dtpNgayBatDau.Value,
                            EndDate = dtpNgayKetThuc.Value,
                            AmountLimit = decimal.Parse(txtGioiHanChiTieu.Text),
                            UserID = CurrentUser.UserID
                        };
                        bool isUpdate = budgetService.UpdateBudget(newBudget);

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
                    MessageBox.Show("Vui lòng chọn một hàng để Cập nhật.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBudget_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetSelectRows(e.RowIndex);
        }
    }
}
