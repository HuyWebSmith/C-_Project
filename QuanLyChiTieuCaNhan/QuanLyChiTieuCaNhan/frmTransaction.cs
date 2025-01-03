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
using DAL;
using DAL.Models;

namespace QuanLyChiTieuCaNhan
{
    public partial class frmTransaction : Form
    {
        private readonly CategoriesService categoriesService = new CategoriesService();
        private readonly TransactionService transactionService = new TransactionService();
        public frmTransaction()
        {
            InitializeComponent();
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            int currentUserId = CurrentUser.UserID;
            var listCategories = categoriesService.GetAllByUser(currentUserId);
            
            FillCombobox(listCategories);
        }
        public void FillCombobox(List<Categories> listTransaction)
        {
            listTransaction.Insert(0, new Categories());
            this.cmbDanhMuc.DataSource = listTransaction;
            this.cmbDanhMuc.DisplayMember = "CategoryName";
            this.cmbDanhMuc.ValueMember = "CategoryID";
        }
    }
}
