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
    public partial class frmInputData_GUI : Form
    {
        public frmInputData_GUI()
        {
            InitializeComponent();
        }
        private readonly StudentService studentService = new StudentService();
        private readonly ClassesService classesService= new ClassesService();  
        private readonly FacultyService facultyService= new FacultyService();  
        private void frmInputData_GUI_Load(object sender, EventArgs e)
        {
            List<Classes> listClasses = classesService.GetAll();
            List<Faculty> listFaculty = facultyService.GetAll();
            FillClassComboBox(listClasses);
            //FillFacultyComboBox(listFaculty);
        }

        private void FillClassComboBox(List<Classes> listClasses)
        {
            listClasses.Insert(0, new Classes());
            this.cmbClass.DataSource = listClasses;
            this.cmbClass.DisplayMember = "ClassID";
            this.cmbClass.ValueMember = "ClassID";
        }

        //private void FillFacultyComboBox(List<Faculty> listFaculty)
        //{
        //    listFaculty.Insert(0, new Faculty());
        //    this.cmbFaculty.DataSource = listFaculty;
        //    this.cmbFaculty.DisplayMember = "FacultyName";
        //    this.cmbFaculty.ValueMember = "FacultyID";
        //}

        private void btnAddUp_Click(object sender, EventArgs e)
        {
            var isAdding = true;
            if (isAdding)
            {
                Student student = new Student();
                string formattedDate = dtpBirth.Value.ToString("yyyy-MM-dd");
                student.StudentId = txtStudentID.Text;
                student.FullName = txtFullName.Text;
                if (cbxNam.Checked)
                    student.Sex = "Nam";
                else if (cbxNu.Checked)
                    student.Sex = "Nữ";
                else if(cbxKhac.Checked)
                    student.Sex = "Khác";

                student.Birth = formattedDate;
                student.Address = txtAddress.Text;
                student.Email = txtEmail.Text;
                student.Phone = txtPhone.Text;
                student.ClassID = cmbClass.Text;

                studentService.InsertUpStudent(student);
            }
            this.Close();
        }
    }
}
