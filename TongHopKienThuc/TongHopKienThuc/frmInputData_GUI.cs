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
        private readonly ClassesService classesService= new ClassesService();  
        private void frmInputData_GUI_Load(object sender, EventArgs e)
        {
            List<Classes> listClasses = classesService.GetAll();
        }

        private void FillClassComboBox(List<Classes> listClasses)
        {
            listClasses.Insert(0, new Classes());
            this.cmbClass.DataSource = listClasses;
            this.cmbClass.DisplayMember = "ClassName";
            this.cmbClass.ValueMember = "ClassID";
        }
    }
}
