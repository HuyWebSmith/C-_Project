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
using DAL;
using DAL.enums;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

namespace QuanLyChiTieuCaNhan
{
    public partial class frmGoal : Form
    {
        public frmGoal()
        {
            InitializeComponent();
        }
        GoalsService GoalsService = new GoalsService();
        TransactionService transactionService = new TransactionService();
        public int currentUserId = CurrentUser.UserID;
        private int curentGoalID;
        private decimal curentIncome;
        private void frmGoal_Load(object sender, EventArgs e)
        {

            BridGrid();
            
            
        }

        public void BridGrid()
        {
            decimal Income = transactionService.GetTotalAmountIncome(currentUserId);
            decimal Expense = transactionService.GetTotalAmountExpense(currentUserId);
            decimal currentIncome = Income - Expense;
            var listGoal = GoalsService.GetAllByUser(currentUserId);
            var listTransaction = transactionService.GetAllByUser(currentUserId);
            dgvGoal.Rows.Clear();
            foreach (var item in listGoal)
            {
                var index = dgvGoal.Rows.Add();
                dgvGoal.Rows[index].Cells[0].Value = item.GoalID;
                dgvGoal.Rows[index].Cells[1].Value = item.GoalName;
                dgvGoal.Rows[index].Cells[2].Value = item.TargetAmount;
                dgvGoal.Rows[index].Cells[3].Value = currentIncome;

                dgvGoal.Rows[index].Cells[4].Value = item.DueDate;
                dgvGoal.Rows[index].Cells[5].Value = item.Status;

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra tên mục tiêu
                if (string.IsNullOrWhiteSpace(txtTenMucTieu.Text))
                {
                    MessageBox.Show("Tên mục tiêu không được để trống.");
                    return;
                }

                if (!decimal.TryParse(txtTienMucTieu.Text, out decimal targetAmount) || targetAmount <= 0)
                {
                    MessageBox.Show("Số tiền mục tiêu phải là số hợp lệ và lớn hơn 0.");
                    return;
                }
                if (dtpNgayDenHan.Value <= DateTime.Now)
                {
                    MessageBox.Show("Ngày đến hạn phải lớn hơn ngày hiện tại.");
                    return;
                }
                decimal Income = transactionService.GetTotalAmountIncome(currentUserId);
                decimal Expense = transactionService.GetTotalAmountExpense(currentUserId);
                decimal currentIncome = Income - Expense;
                Goals goals = new Goals
                {
                    GoalName = txtTenMucTieu.Text,
                    TargetAmount = targetAmount,
                    CurrentAmount = currentIncome,
                    DueDate = dtpNgayDenHan.Value,
                    Status = Status.InProgress,
                    UserID = currentUserId
                };

                GoalsService.InsertGoal(goals);

                BridGrid();

                MessageBox.Show("Thêm mục tiêu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }
        public void GetSelectRows(int selectedRow)
        {
            try
            {
                curentGoalID = Convert.ToInt32(dgvGoal.Rows[selectedRow].Cells[0].Value);
                
                txtTenMucTieu.Text = dgvGoal.Rows[selectedRow].Cells[1].Value.ToString();
                txtTienMucTieu.Text = dgvGoal.Rows[selectedRow].Cells[2].Value.ToString();
                curentIncome = (decimal)dgvGoal.Rows[selectedRow].Cells[3].Value;
                dtpNgayDenHan.Value = Convert.ToDateTime(dgvGoal.Rows[selectedRow].Cells[4].Value);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvGoal.CurrentRow != null)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int goalID = Convert.ToInt32(dgvGoal.CurrentRow.Cells[0].Value);

                        bool isDeleted = GoalsService.DeleteGoal(goalID);

                        if (isDeleted)
                        {

                            dgvGoal.Rows.Remove(dgvGoal.CurrentRow);
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

        private void dgvGoal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetSelectRows(e.RowIndex);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvGoal.CurrentRow != null)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật hàng này?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        
                        Goals newGoal = new Goals
                        {
                            GoalID = curentGoalID,
                            GoalName = txtTenMucTieu.Text,
                            TargetAmount = decimal.Parse(txtTienMucTieu.Text),
                            CurrentAmount = transactionService.GetTotalAmountIncome(currentUserId),
                            DueDate = dtpNgayDenHan.Value,
                            UserID = CurrentUser.UserID
                        };
                        bool isUpdate = GoalsService.UpdateGoal(newGoal);

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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvGoal.CurrentRow != null)
                {
                    int goalID = Convert.ToInt32(dgvGoal.CurrentRow.Cells[0].Value);
                    var goal = GoalsService.GetById(goalID);
                    decimal Income = transactionService.GetTotalAmountIncome(currentUserId);
                    decimal Expense = transactionService.GetTotalAmountExpense(currentUserId);
                    decimal currentIncome = Income - Expense;
                    goal.CurrentAmount = currentIncome;
                    if(goal.DueDate == DateTime.Now)
                    {
                        MessageBox.Show("Đã đến ngày phải hoàn thành mục tiêu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    // Kiểm tra nếu số tiền hiện tại đạt hoặc vượt mục tiêu
                    if (goal.CurrentAmount >= goal.TargetAmount)
                    {
                        // Cập nhật trạng thái mục tiêu thành 'Completed'
                        var status = Status.Completed;

                        // Cập nhật lại mục tiêu vào cơ sở dữ liệu
                        bool isUpdated = GoalsService.UpdateStatus(goal, status);

                        if (isUpdated)
                        {
                            BridGrid(); // Làm mới bảng

                            MessageBox.Show("Mục tiêu đã hoàn thành!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật trạng thái thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Nếu số tiền chưa đạt mục tiêu
                        BridGrid();
                        MessageBox.Show("Số tiền hiện tại chưa đạt mục tiêu.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một mục tiêu để cập nhật trạng thái.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
