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
    public partial class Form2 : Form
    {
        public Form2(Form1 form)
        {
            InitializeComponent();
            form1 = form;
        }
        private Form1 form1;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenSV.Text == "" || txtDiem.Text == "" || txtMSSV.Text == "")
                {
                    throw new Exception("Bắt Buộc Nhập Đầy Đủ Thông Tin!");
                }
                else if (float.Parse(txtDiem.Text) < 0 || float.Parse(txtDiem.Text) > 10)
                {
                    throw new Exception("Nhập Điểm Trong Phạm Vi Từ (0-10)!");
                }
                Student student = new Student();
                student.MSSV = txtMSSV.Text;
                student.Ten = txtTenSV.Text;
                student.Khoa = cmbKhoa.Text;
                student.Diem = float.Parse(txtDiem.Text);
                form1.AddDataToGrid(student);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }    
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbKhoa.SelectedIndex = 0;
        }
    }
}
