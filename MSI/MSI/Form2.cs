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
    public partial class Form2 : Form
    {
        public Form2(string imageFile)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(imageFile);

            Text = imageFile.Substring(imageFile.LastIndexOf('\\') + 1);
        }
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(IContainer components, PictureBox pictureBox1)
        {
            this.components = components;
            this.pictureBox1 = pictureBox1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
