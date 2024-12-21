using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF.Models;

namespace EF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Student> students;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB context = new StudentContextDB();
                List<Faculty> listFacultys = context.Faculties.ToList();
                List<Student> listStudent = context.Students.ToList();
                FillFacultyCombobox(listFacultys);
                BindGrid(listStudent,listFacultys);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillFacultyCombobox(List<Faculty> listFacultys)
        {
            this.cmbKhoa.DataSource = listFacultys;
            this.cmbKhoa.DisplayMember = "FacultyName";
            this.cmbKhoa.ValueMember = "FacultyID";
        }

        private void BindGrid(List<Student> listStudent, List<Faculty> listFacultys) 
        {
            dgvStudent.Rows.Clear();
            foreach (var item in listStudent)
            {
                var facultyName = listFacultys.FirstOrDefault(
                    f => f.FacultyID == item.FacultyID)?.FacultyName ?? "N/A";

                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudent.Rows[index].Cells[1].Value = item.FullName;
                dgvStudent.Rows[index].Cells[2].Value = facultyName;
                dgvStudent.Rows[index].Cells[3].Value = item.AverageScore;

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                StudentContextDB context= new StudentContextDB();
                Student student = new Student()
                {
                    StudentID = txtMSSV.Text,
                    FullName = txtHoTen.Text,
                    FacultyID = int.Parse(cmbKhoa.SelectedValue.ToString()),
                    AverageScore = double.Parse(txtDiem.Text)
                };
                context.Students.Add(student);
                context.SaveChanges();
                List<Faculty> listFacultys = context.Faculties.ToList();
                List<Student> listStudent = context.Students.ToList();
                BindGrid(listStudent,listFacultys);
                MessageBox.Show("Thêm Sinh Viên Thành Công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB context = new StudentContextDB();
                string studentId = txtMSSV.Text;
                Student dbupdate = context.Students.FirstOrDefault(p => p.StudentID == studentId);
                if (dbupdate != null)
                {
                    dbupdate.StudentID = txtMSSV.Text;
                    dbupdate.FullName = txtHoTen.Text;
                    dbupdate.FacultyID = int.Parse(cmbKhoa.SelectedValue.ToString());
                    dbupdate.AverageScore = double.Parse(txtDiem.Text);

                    context.SaveChanges();
                    List<Faculty> listFacultys = context.Faculties.ToList();
                    List<Student> listStudent = context.Students.ToList();
                    BindGrid(listStudent, listFacultys);
                    MessageBox.Show("Cập Nhật Sinh Viên Thành Công");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên để sửa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudent.Rows[e.RowIndex];
                txtMSSV.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                cmbKhoa.Text = row.Cells[2].Value.ToString(); 
                txtDiem.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB context = new StudentContextDB();
                string studentId = txtMSSV.Text;
                Student dbupdate = context.Students.FirstOrDefault(p => p.StudentID == studentId);
                if (dbupdate != null)
                {
                    context.Students.Remove(dbupdate);

                    context.SaveChanges();
                    List<Faculty> listFacultys = context.Faculties.ToList();
                    List<Student> listStudent = context.Students.ToList();
                    BindGrid(listStudent, listFacultys);
                    MessageBox.Show("Xóa Sinh Viên Thành Công");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên để xóa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
