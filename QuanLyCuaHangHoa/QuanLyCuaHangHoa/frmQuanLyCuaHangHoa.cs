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
using QuanLyCuaHangHoa.Migrations;
using QuanLyCuaHangHoa.Models;

namespace QuanLyCuaHangHoa
{
    public partial class frmQuanLyCuaHangHoa : Form
    {
        public frmQuanLyCuaHangHoa()
        {
            InitializeComponent();
        }

        private void frmQuanLyCuaHangHoa_Load(object sender, EventArgs e)
        {
            try
            {
                Huy__96__ShopHoa _context = new Huy__96__ShopHoa();
                List<Huy_96_DanhSachCuaHang> listhuy_96__DanhSachCuaHang = _context.huy_96__DanhSachCuaHangs.ToList();
                BindGrid(listhuy_96__DanhSachCuaHang);
                UpdateTongSoLuongCuaHang();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void BindGrid(List<Huy_96_DanhSachCuaHang> listhuy_96__DanhSachCuaHang)
        {
            dgvCuaHang.Rows.Clear();
            foreach(var item in listhuy_96__DanhSachCuaHang)
            {
                var index = dgvCuaHang.Rows.Add();
                dgvCuaHang.Rows[index].Cells[0].Value = item.MaCuaHang;
                dgvCuaHang.Rows[index].Cells[1].Value = item.TenCuaHang;
                dgvCuaHang.Rows[index].Cells[2].Value = item.DiaChiCuaHang;
                dgvCuaHang.Rows[index].Cells[3].Value = item.SDT;
                dgvCuaHang.Rows[index].Cells[4].Value = item.Email;
                dgvCuaHang.Rows[index].Cells[5].Value = item.HoTenNhanVienQuanLy;
                dgvCuaHang.Rows[index].Cells[6].Value = item.SDTNhanVienQuanLy;
            }
        }
        public Boolean isAdding = true;
        private void btnThem_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            isAdding = true;
        }
        private bool CheckMaCuaHangExists(string maCuaHang, string currentMaCuaHang = "")
        {
            Huy__96__ShopHoa context = new Huy__96__ShopHoa();
            var existingStore = context.huy_96__DanhSachCuaHangs.FirstOrDefault(p => p.MaCuaHang == maCuaHang);

            if (existingStore != null && existingStore.MaCuaHang != currentMaCuaHang)
            {
                return true; 
            }

            return false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            if (isAdding)
            {
                Huy_96_DanhSachCuaHang cuahang = new Huy_96_DanhSachCuaHang
                {
                    MaCuaHang = txtMaCH.Text,
                    TenCuaHang = txtTenCH.Text,
                    DiaChiCuaHang = txtDiaChi.Text,
                    SDT = txtSDT.Text,
                    Email = txtEmail.Text,
                    HoTenNhanVienQuanLy = txtHotenNV.Text,
                    SDTNhanVienQuanLy = txtSDTNV.Text
                };
                string CuaHangID = txtMaCH.Text.Trim(); 
        
                if (CheckMaCuaHangExists(CuaHangID))
                {
                    MessageBox.Show("Mã cửa hàng này đã tồn tại, vui lòng nhập mã khác.");
                    return;
                }
                Huy__96__ShopHoa context = new Huy__96__ShopHoa();
                    context.huy_96__DanhSachCuaHangs.Add(cuahang);
                    context.SaveChanges();
                MessageBox.Show("Thêm cửa hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string CuaHangID = txtMaCH.Text.Trim();
                Huy__96__ShopHoa context = new Huy__96__ShopHoa();
                Huy_96_DanhSachCuaHang cuahangToUpdate = context.huy_96__DanhSachCuaHangs.FirstOrDefault(p => p.MaCuaHang == CuaHangID);

                if (cuahangToUpdate != null)
                {
                    cuahangToUpdate.TenCuaHang = txtTenCH.Text;
                    cuahangToUpdate.DiaChiCuaHang = txtDiaChi.Text;
                    cuahangToUpdate.SDT = txtSDT.Text;
                    cuahangToUpdate.Email = txtEmail.Text;
                    cuahangToUpdate.HoTenNhanVienQuanLy = txtHotenNV.Text;
                    cuahangToUpdate.SDTNhanVienQuanLy = txtSDTNV.Text;

                    context.SaveChanges();
                    MessageBox.Show("Cập nhật cửa hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cửa hàng không tồn tại hoặc mã cửa hàng không hợp lệ.");
                }
            }
            groupBox2.Enabled = false;
            dgvCuaHang.Refresh();
            Huy__96__ShopHoa newContext = new Huy__96__ShopHoa();
            List<Huy_96_DanhSachCuaHang> updatedList = newContext.huy_96__DanhSachCuaHangs.ToList();
            BindGrid(updatedList);
            ClearInputs();
            UpdateTongSoLuongCuaHang();
        }
        private void ClearInputs()
        {
            txtMaCH.Clear();
            txtTenCH.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtHotenNV.Clear();
            txtSDTNV.Clear();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled=false;
        }

        private void dgvCuaHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCuaHang.Rows[e.RowIndex];

                txtMaCH.Text = row.Cells[0].Value?.ToString();
                txtTenCH.Text = row.Cells[1].Value?.ToString();
                txtDiaChi.Text = row.Cells[2].Value?.ToString();
                txtSDT.Text = row.Cells[3].Value?.ToString();
                txtEmail.Text = row.Cells[4].Value?.ToString();
                txtHotenNV.Text = row.Cells[5].Value?.ToString();
                txtSDTNV.Text = row.Cells[6].Value?.ToString();
            }
        }

        private void Huy_96_btn_xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaCH.Text))
            {
                MessageBox.Show("Vui lòng chọn cửa hàng để xóa!");
                return;
            }

            string CuaHangID = txtMaCH.Text.Trim();
            Huy__96__ShopHoa context = new Huy__96__ShopHoa();

            Huy_96_DanhSachCuaHang cuahangToDelete = context.huy_96__DanhSachCuaHangs
                .FirstOrDefault(p => p.MaCuaHang == CuaHangID);

            if (cuahangToDelete != null)
            {
                context.huy_96__DanhSachCuaHangs.Remove(cuahangToDelete);
                context.SaveChanges();
                MessageBox.Show("Xóa cửa hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cửa hàng không tồn tại hoặc mã cửa hàng không hợp lệ.");
            }

            groupBox2.Enabled = false;

            Huy__96__ShopHoa newContext = new Huy__96__ShopHoa();
            List<Huy_96_DanhSachCuaHang> updatedList = newContext.huy_96__DanhSachCuaHangs.ToList();
            BindGrid(updatedList);
            UpdateTongSoLuongCuaHang();
        }

        private void Huy_96_btn_sua_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            isAdding = false;
        }
        private void LoadDanhSachCuaHang()
        {
            try
            {
                Huy__96__ShopHoa _context = new Huy__96__ShopHoa();
                List<Huy_96_DanhSachCuaHang> listhuy_96__DanhSachCuaHang = _context.huy_96__DanhSachCuaHangs.ToList();
                BindGrid(listhuy_96__DanhSachCuaHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateTongSoLuongCuaHang()
        {
            Huy__96__ShopHoa context = new Huy__96__ShopHoa();
            int totalStores = context.huy_96__DanhSachCuaHangs.Count(); 
            labelTong.Text = $"Tổng số lượng cửa hàng: {totalStores}";
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
                string maCuaHang = txtTim.Text.Trim();

                if (string.IsNullOrEmpty(maCuaHang))
                {
                    MessageBox.Show("Vui lòng nhập mã cửa hàng để tìm kiếm.");
                    LoadDanhSachCuaHang();
                    return;
                }

                Huy__96__ShopHoa context = new Huy__96__ShopHoa();
                var result = context.huy_96__DanhSachCuaHangs
                                    .Where(p => p.MaCuaHang.Contains(maCuaHang)) 
                                    .ToList();

                if (result.Any())
                {
                    BindGrid(result);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy cửa hàng với mã này.");
                    LoadDanhSachCuaHang();
                }
            }
    }
}
