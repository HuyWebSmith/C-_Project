using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2_Buoi3
{
    public partial class dataGridView : Form
    {
        public dataGridView()
        {
            InitializeComponent();
        }
        List<Student> students = new List<Student>();
        private int vt = -1;
        private void dtaStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView_Load(object sender, EventArgs e)
        {
            
            students.Add(new Student(1, "A" ,"0900004455"));
            students.Add(new Student(2, "B", "0900005456"));
            students.Add(new Student(3, "C", "09000047322"));
            students.Add(new Student(4, "D", "0900007895"));
            students.Add(new Student(5, "E", "0900001234"));
            dtaStudent.DataSource = new BindingList<Student>(students);
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dtaStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Student s = new Student() { id = int.Parse(txtID.Text)
                                        ,name = txtName.Text
                                        ,phone =txtPhone.Text };
            students.Add (s);
            dtaStudent.DataSource = new BindingList<Student>(students);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
