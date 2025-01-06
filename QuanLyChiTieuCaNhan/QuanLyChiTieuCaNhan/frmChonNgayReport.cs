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

namespace QuanLyChiTieuCaNhan
{
    public partial class frmChonNgayReport : Form
    {
        public frmChonNgayReport()
        {
            InitializeComponent();
        }
        private readonly TransactionService transactionService= new TransactionService();
        private readonly ReportService reportService= new ReportService();
        public int currentUserId = CurrentUser.UserID;
        public int currentReportId;
        public decimal currentTotalIncome;
        public decimal currentTotalExpense;
        
        private void frmChonNgayReport_Load(object sender, EventArgs e)
        {
            var listReport = reportService.GetAllByUser(currentUserId);
            BridGrid();
        }
        public void BridGrid()
        {
            int currentUserId = CurrentUser.UserID;
            var listTransaction = transactionService.GetAllByUser(currentUserId);
            var listReport = reportService.GetAllByUser(currentUserId);
            dgvReport.Rows.Clear();
            foreach (var item in listReport)
            {
                var index = dgvReport.Rows.Add();
                
                dgvReport.Rows[index].Cells[0].Value = item.ReportID;
                dgvReport.Rows[index].Cells[1].Value = item.StartAReportDate;
                dgvReport.Rows[index].Cells[2].Value = item.EndAReportDate;
                dgvReport.Rows[index].Cells[3].Value = item.TotalIncome;
                dgvReport.Rows[index].Cells[4].Value = item.TotalExpense;
                dgvReport.Rows[index].Cells[5].Value = item.ReportDetails;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Report report = new Report
            {
                StartAReportDate = DateTime.Parse(dtpNgayBatDau.Text),
                EndAReportDate = DateTime.Parse(dtpNgayKetThuc.Text),
                TotalIncome = reportService.GetTotalIncome(currentUserId, DateTime.Parse(dtpNgayBatDau.Text), DateTime.Parse(dtpNgayKetThuc.Text)),
                TotalExpense = reportService.GetTotalExpense(currentUserId, DateTime.Parse(dtpNgayBatDau.Text), DateTime.Parse(dtpNgayKetThuc.Text)),
                ReportDetails = rtbReportDetail.Text,
                UserID = CurrentUser.UserID
            };
            reportService.InsertReport(report);
            BridGrid();
        }
        public void GetSelectRows(int selectedRow)
        {
            currentReportId = Convert.ToInt32(dgvReport.Rows[selectedRow].Cells[0].Value);
            dtpNgayBatDau.Text = dgvReport.Rows[selectedRow].Cells[1].Value.ToString();
            dtpNgayKetThuc.Text = dgvReport.Rows[selectedRow].Cells[2].Value.ToString();
            currentTotalIncome = Convert.ToDecimal(dgvReport.Rows[selectedRow].Cells[3].Value);
            currentTotalExpense = Convert.ToDecimal(dgvReport.Rows[selectedRow].Cells[4].Value);
            rtbReportDetail.Text = dgvReport.Rows[selectedRow].Cells[5].Value.ToString();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReport.CurrentRow != null)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int ReportId = Convert.ToInt32(dgvReport.CurrentRow.Cells[0].Value);

                        bool isDeleted = reportService.DeleteReport(ReportId);

                        if (isDeleted)
                        {

                            dgvReport.Rows.Remove(dgvReport.CurrentRow);
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

        private void dgvReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetSelectRows(e.RowIndex);
        }
    }
}
