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
        
        public Form1()
        {
            InitializeComponent();
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            pn2.Enabled = false;
            try
            {
                if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "" || txtHoTen.Text == "" || txtSDT.Text == "")
                {
                    throw new Exception("Vui lòng nhập đủ thông tin.");
                }

                int selectedRow = GetSelectedRow(txtTenDangNhap.Text);
                if (selectedRow == -1)
                {
                    selectedRow = dataGridView1.Rows.Add();
                    Them(selectedRow);
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    
                    UpdateRow(selectedRow);
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private int GetSelectedRow(string txtTenDangNhap)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null && dataGridView1.Rows[i].Cells[0].Value.ToString() == txtTenDangNhap)
                {
                    return i;
                }
            }
            return -1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbNganh.SelectedIndex = 0;
        }

        private void Them(int selectedRow)
        {
            dataGridView1.Rows[selectedRow].Cells[0].Value = txtTenDangNhap.Text;
            dataGridView1.Rows[selectedRow].Cells[1].Value = txtMatKhau.Text;
            dataGridView1.Rows[selectedRow].Cells[2].Value = txtHoTen.Text;
            dataGridView1.Rows[selectedRow].Cells[3].Value = txtSDT.Text;
            dataGridView1.Rows[selectedRow].Cells[4].Value = cbNganh.Text;
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

        private void UpdateRow(int rowIndex)
        {
            dataGridView1.Rows[rowIndex].Cells[0].Value = txtTenDangNhap.Text;
            dataGridView1.Rows[rowIndex].Cells[1].Value = txtMatKhau.Text;
            dataGridView1.Rows[rowIndex].Cells[2].Value = txtHoTen.Text;
            dataGridView1.Rows[rowIndex].Cells[3].Value = txtSDT.Text;
            dataGridView1.Rows[rowIndex].Cells[4].Value = cbNganh.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int selectedRow = dataGridView1.CurrentRow.Index;
                if (selectedRow >= 0)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này?", "Xác Nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        dataGridView1.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("Xóa dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.", "Thông Báo", MessageBoxButtons.OK);
            }
        }
    }
}
