using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true; // Ẩn lỗi script
            webBrowser1.Navigate("https://www.google.com/maps/@9.779349,105.6189045,11z?hl=vi-VN");
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
