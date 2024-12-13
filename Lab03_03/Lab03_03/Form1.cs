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
        public Form1()
        {
            InitializeComponent();
        }
        public void AddDataToGrid(Student student)
        {
            int soThuTu = dgvStudent.Rows.Count + 1;
            int newRowIndex = dgvStudent.Rows.Add();
            dgvStudent.Rows[newRowIndex].Cells[0].Value = soThuTu;
            dgvStudent.Rows[newRowIndex].Cells[1].Value = student.MSSV;
            dgvStudent.Rows[newRowIndex].Cells[2].Value = student.Ten;
            dgvStudent.Rows[newRowIndex].Cells[3].Value = student.Khoa;
            dgvStudent.Rows[newRowIndex].Cells[4].Value = student.Diem;
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
    }
}
