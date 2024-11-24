using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1_buoi3
{
    public partial class log_in_form : Form
    {
        public log_in_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void log_in_form_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtHovaten.Text = txtHo.Text;

        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            txtHovaten.Text = txtTen.Text;
        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            txtHovaten.Text = txtHo.Text + " " + txtTen.Text;
        }

        private void txtHovaten_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure about that ?", "Close"
                                , MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (res == DialogResult.OK)
            {
                this.Close();
            }
            
        }
    }
}
