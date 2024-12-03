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
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmListView_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedIndices.Count > 0)
            {
                ListViewItem lvi = lvNhanVien.SelectedItems[0];

                string firstName = lvi.SubItems[0].Text;
                string lastName = lvi.SubItems[1].Text;
                string phone = lvi.SubItems[2].Text;

                txtFirstName.Text = firstName;
                txtLastName.Text = lastName;
                txtPhone.Text = phone;
            }
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(txtFirstName.Text);
            lvi.SubItems.Add(txtLastName.Text);
            lvi.SubItems.Add(txtPhone.Text);

            lvNhanVien.Items.Add(lvi);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvNhanVien.SelectedItems[0];

                selectedItem.Text = txtFirstName.Text;
                selectedItem.SubItems[1].Text = txtLastName.Text;
                selectedItem.SubItems[2].Text = txtPhone.Text;

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count > 0)
            {

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    lvNhanVien.Items.Remove(lvNhanVien.SelectedItems[0]);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
