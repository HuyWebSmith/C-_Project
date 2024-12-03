using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<NhanVien> listNV = new List<NhanVien>();
        private void btnThem_Click(object sender, EventArgs e)
        {
            frm2 frm2 = new frm2();
            if (frm2.ShowDialog() == DialogResult.OK)
            {
                ListViewItem listItem = new ListViewItem(frm2.nv.mssv);
                listItem.SubItems.Add(frm2.nv.name);
                listItem.SubItems.Add(frm2.nv.luongCB.ToString());
                lvNhanVien.Items.Add(listItem);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedIndices.Count > 0)
            {
                ListViewItem selectedItem = lvNhanVien.SelectedItems[0];

                frm2 frm2 = new frm2();

                if (frm2.ShowDialog() == DialogResult.OK)
                {
                    selectedItem.SubItems[0].Text = frm2.nv.mssv;
                    selectedItem.SubItems[1].Text = frm2.nv.name;
                    selectedItem.SubItems[2].Text = frm2.nv.luongCB.ToString();
                }
            }
            else
            {
                MessageBox.Show("Chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Chắc chắn muốn xóa mục đã chọn không?",
                                                      "Xác nhận",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    lvNhanVien.Items.Remove(lvNhanVien.SelectedItems[0]);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
