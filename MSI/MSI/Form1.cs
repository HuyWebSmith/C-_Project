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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Use OpenFileDialog to select an image
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Fix filter to correctly show bitmap and jpeg files
            openFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|JPEG files (*.jpg, *.jpeg)|*.jpg;*.jpeg";

            // If the user selects a file, open it in Form2
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Create a new instance of Form2 and pass the file path
                Form3 frm3 = new Form3(openFileDialog.FileName);

                // Set the MDI parent (this form)
                frm3.MdiParent = this;

                // Show the new form
                frm3.Show();
            }
        }


        private void Form1_ImeModeChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            toolStripStatusLabel2.Text = dateTime.ToString();
        }
    }
}
