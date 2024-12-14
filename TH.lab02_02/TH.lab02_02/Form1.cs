using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH.lab02_02
{
    public partial class Form1 : Form
    {
        private List<Student> list = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }
        public void AddDataToGrid(Student student)
        {
            list.Add(student);
            UpdateGridView(list);

        }
        private void UpdateGridView(List<Student> list)
        {
            dgvStudent.Rows.Clear();
            foreach (var student in list)
            {
                int newRowIndex = dgvStudent.Rows.Add();
                dgvStudent.Rows[newRowIndex].Cells[0].Value = student.TenDangNhap;
                dgvStudent.Rows[newRowIndex].Cells[1].Value = student.MatKhau;
                dgvStudent.Rows[newRowIndex].Cells[2].Value = student.HoTen;
                dgvStudent.Rows[newRowIndex].Cells[3].Value = student.Sdt;
                dgvStudent.Rows[newRowIndex].Cells[4].Value = student.ChuyenNganh;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            pn2.Enabled = true;
            ClearInputFields();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            pn2.Enabled = false;
        }
        private int GetSelectedRow()
        {
            if (dgvStudent.CurrentRow != null)
            {
                return dgvStudent.CurrentRow.Index;
            }
            return -1;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            pn2.Enabled = false;
            try
            {
                if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "" || txtHoTen.Text == "" || txtSDT.Text == "")
                {
                    throw new Exception("Bắt Buộc Nhập Đầy Đủ Thông Tin!");
                }
                int selectedRow = GetSelectedRow();
                if (selectedRow >= 0) 
                {
                    list[selectedRow].MatKhau = txtMatKhau.Text;
                    list[selectedRow].HoTen = txtHoTen.Text;
                    list[selectedRow].Sdt = txtSDT.Text;
                    list[selectedRow].ChuyenNganh = cbNganh.Text;

                    UpdateGridView(list);
                    MessageBox.Show("Cập nhật thành công!", "Thông báo");
                }
                else 
                {
                    Student student = new Student
                    {
                        TenDangNhap = txtTenDangNhap.Text,
                        MatKhau = txtMatKhau.Text,
                        HoTen = txtHoTen.Text,
                        Sdt = txtSDT.Text,
                        ChuyenNganh = cbNganh.Text
                    };

                    AddDataToGrid(student);
                    MessageBox.Show("Thêm mới thành công!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbNganh.SelectedIndex = 0;
        }


        private void ClearInputFields()
        {
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtHoTen.Text = "";
            txtSDT.Text = "";
            cbNganh.SelectedIndex = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            pn2.Enabled = true;
            ClearInputFields();

        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvStudent.CurrentRow != null)
            {
                int selectedRow = dgvStudent.CurrentRow.Index;
                if (selectedRow >= 0)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này?", "Xác Nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        list.RemoveAt(selectedRow);
                        dgvStudent.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("Xóa dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int selectedRowIndex = e.RowIndex;

                string maNganh = dgvStudent.Rows[selectedRowIndex].Cells[0].Value?.ToString();

                if (!string.IsNullOrEmpty(maNganh))
                {
                    MessageBox.Show($"Bạn đã chọn dòng có Mã Ngành: {maNganh}", "Thông Báo");
                }
            }
        }
    }
}
