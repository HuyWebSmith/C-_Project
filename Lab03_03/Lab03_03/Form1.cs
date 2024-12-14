using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_03
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
            int soThuTu = 1;

            foreach (var student in list)
            {
                int newRowIndex = dgvStudent.Rows.Add();
                dgvStudent.Rows[newRowIndex].Cells[0].Value = soThuTu++;
                dgvStudent.Rows[newRowIndex].Cells[1].Value = student.MSSV;
                dgvStudent.Rows[newRowIndex].Cells[2].Value = student.Ten;
                dgvStudent.Rows[newRowIndex].Cells[3].Value = student.Khoa;
                dgvStudent.Rows[newRowIndex].Cells[4].Value = student.Diem;
            }
        }
        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
            
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm Kiếm Theo Tên") return;
            string timKiem = txtTimKiem.Text.ToLower().Trim();
            if(string.IsNullOrEmpty(timKiem) 
                || timKiem == "Tìm Kiếm Theo Tên") 
            {
                UpdateGridView(list);
                return; 
            }

            var ketQua = list.Where(s => s.Ten.ToLower().Contains(timKiem)).ToList();

            UpdateGridView(ketQua);
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm Kiếm Theo Tên")
            {
                txtTimKiem.Clear();
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                txtTimKiem.Text = "Tìm Kiếm Theo Tên"; 
                txtTimKiem.ForeColor = Color.Gray; 
            }
        }
    }
}
