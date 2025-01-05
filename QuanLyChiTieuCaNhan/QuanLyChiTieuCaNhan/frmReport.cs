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
using Microsoft.Reporting.WinForms;

namespace QuanLyChiTieuCaNhan
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            int currenUser = CurrentUser.UserID;
            TransactionService transactionService = new TransactionService();
            ReportService reportService = new ReportService();
            var listTransaction = transactionService.GetAllByUser(currenUser);
            var listreport = reportService.GetAllByUser(currenUser);
            List<Reportss> reportss = new List<Reportss>();
            List<TransactionReport> reportList = new List<TransactionReport>();
            foreach ( var item in listTransaction )
            {
                TransactionReport temp = new TransactionReport();
                temp.TransactionName = item.TransactionName;
                temp.Amount = item.Amount;
                temp.Date = item.Date;
                temp.Note = item.Note;
                reportList.Add(temp);
            }
            foreach (var item in listreport)
            {
                Reportss temp = new Reportss();
                temp.ReportID  = item.ReportID;
                temp.StartAReportDate = item.StartAReportDate;
                temp.EndAReportDate =item.EndAReportDate;
                temp.TotalIncome = item.TotalIncome;
                temp.TotalExpense = item.TotalExpense;
                temp.ReportDetails = item.ReportDetails;
                reportss.Add(temp);
    }

            reportViewer1.LocalReport.ReportPath = "C:\\Users\\nquan\\Desktop\\.NET\\QuanLyChiTieuCaNhan\\DAL\\Models\\rptQuanLyChiTieu.rdlc";
            var TransactionReport = new ReportDataSource("TransactionReport", reportList);
            var DataReport = new ReportDataSource("DataReport", reportss);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(TransactionReport);
            reportViewer1.LocalReport.DataSources.Add(DataReport);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
