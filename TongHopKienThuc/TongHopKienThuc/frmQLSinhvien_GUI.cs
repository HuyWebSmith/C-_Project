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
using DAL.Entities;

namespace TongHopKienThuc
{
    public partial class frmQLSinhvien_GUI : Form
    {
        public frmQLSinhvien_GUI()
        {
            InitializeComponent();
        }
        private readonly StudentService studentService = new StudentService();
        private readonly ClassesService classesService = new ClassesService();
        private readonly FacultyService facultyService = new FacultyService();
        private void frmQLSinhvien_GUI_Load(object sender, EventArgs e)
        {
            try
            {
                var listStudents = studentService.GettAll();
                var listClasses = classesService.GetAll();
                var listFaculty = facultyService.GetAll();
                BindGrid(listStudents,listClasses);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindGrid(List<Student> listStudent,List<Classes> listClasses)
        {
            dgvStudent.Rows.Clear();
            foreach(var item in listStudent)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.StudentId;
                dgvStudent.Rows[index].Cells[1].Value = item.FullName;
                dgvStudent.Rows[index].Cells[2].Value = item.Sex;
                dgvStudent.Rows[index].Cells[3].Value = item.Birth;
                dgvStudent.Rows[index].Cells[4].Value = item.Address;
                dgvStudent.Rows[index].Cells[5].Value = item.Email;
                dgvStudent.Rows[index].Cells[6].Value = item.Phone;
                dgvStudent.Rows[index].Cells[7].Value = item.ClassID;
                foreach (var i in listClasses)
                {
                    dgvStudent.Rows[index].Cells[8].Value = i.FacultyID;
                }
                
            }
        }
        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInputData_GUI frmInputData = new frmInputData_GUI();
            frmInputData.Show();
        }
    }
}
