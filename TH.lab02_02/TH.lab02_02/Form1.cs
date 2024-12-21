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

namespace TH.lab02_02
{
    public partial class Form1 : Form
    {
        private List<Student> listStudent = new List<Student>();
        private bool isAdding = true;
        public Form1()
        {
            InitializeComponent();
        }      

        private void btnThem_Click(object sender, EventArgs e)
        {
            UpdateFacultyComboBox();
            isAdding = true;
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
            try
            {
                if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "" || txtHoTen.Text == "")
                {
                    throw new Exception("Bắt Buộc Nhập Đầy Đủ Thông Tin!");
                }
                Student student = new Student()
                {
                    TenDangNhap = txtTenDangNhap.Text,
                    MatKhau = txtMatKhau.Text,
                    HoTen = txtHoTen.Text,
                    Sdt = txtSDT.Text,
                    ChuyenNganh = cbNganh.SelectedItem?.ToString() ?? "Chưa chọn ngành"
                };
                if (isAdding)
                {
                    AddDataToGrid(student);
                    MessageBox.Show("Thêm Sinh Viên Thành Công");
                }
                else
                {
                    int selectedRow = GetSelectedRow();
                    if (selectedRow >= 0)
                    {
                        listStudent[selectedRow] = student;
                        ThemGrid(listStudent);
                        MessageBox.Show("Sửa Sinh Viên Thành Công");
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một sinh viên để sửa.");
                    }
                }
                pn2.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void AddDataToGrid(Student student)
        {
            listStudent.Add(student);
            ThemGrid(listStudent);

        }
        private void ThemGrid(List<Student> listStudent)
        {
            dgvStudent.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.TenDangNhap;
                dgvStudent.Rows[index].Cells[1].Value = item.MatKhau;
                dgvStudent.Rows[index].Cells[2].Value = item.HoTen;
                dgvStudent.Rows[index].Cells[3].Value = item.Sdt;
                dgvStudent.Rows[index].Cells[4].Value = item.ChuyenNganh;

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void UpdateFacultyComboBox()
        {
            cbNganh.Items.Clear();
            foreach (var faculty in frmBase.Faculties)
            {
                cbNganh.Items.Add(faculty.TenNganh);
            }
        }
        private void ClearInputFields()
        {
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtHoTen.Text = "";
            txtSDT.Text = "";
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            UpdateFacultyComboBox();
            isAdding = false;
            pn2.Enabled = true;
            ClearInputFields();
            int selectedRow = GetSelectedRow();
            if (selectedRow >= 0)
            {
                txtTenDangNhap.Text = listStudent[selectedRow].TenDangNhap;
                txtMatKhau.Text = listStudent[selectedRow].MatKhau;
                txtHoTen.Text = listStudent[selectedRow].HoTen;
                txtSDT.Text = listStudent[selectedRow].Sdt;
                cbNganh.SelectedItem = listStudent[selectedRow].ChuyenNganh;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để sửa.");
            }
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
                        listStudent.RemoveAt(selectedRow);
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
