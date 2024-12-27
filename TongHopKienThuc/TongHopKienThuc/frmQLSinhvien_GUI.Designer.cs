namespace TongHopKienThuc
{
    partial class frmQLSinhvien_GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSinhVIênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýChuyênNgànhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxChuaXepLop = new System.Windows.Forms.CheckBox();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem,
            this.chứcNăngToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1181, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSinhVIênToolStripMenuItem,
            this.quảnLýLớpToolStripMenuItem,
            this.quảnLýChuyênNgànhToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.chứcNăngToolStripMenuItem.Text = "Quản Lý";
            // 
            // quảnLýSinhVIênToolStripMenuItem
            // 
            this.quảnLýSinhVIênToolStripMenuItem.Name = "quảnLýSinhVIênToolStripMenuItem";
            this.quảnLýSinhVIênToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.quảnLýSinhVIênToolStripMenuItem.Text = "Quản Lý Sinh VIên";
            // 
            // quảnLýLớpToolStripMenuItem
            // 
            this.quảnLýLớpToolStripMenuItem.Name = "quảnLýLớpToolStripMenuItem";
            this.quảnLýLớpToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.quảnLýLớpToolStripMenuItem.Text = "Quản Lý Lớp";
            // 
            // quảnLýChuyênNgànhToolStripMenuItem
            // 
            this.quảnLýChuyênNgànhToolStripMenuItem.Name = "quảnLýChuyênNgànhToolStripMenuItem";
            this.quảnLýChuyênNgànhToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.quảnLýChuyênNgànhToolStripMenuItem.Text = "Quản Lý Chuyên Ngành";
            // 
            // chứcNăngToolStripMenuItem1
            // 
            this.chứcNăngToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.chứcNăngToolStripMenuItem1.Name = "chứcNăngToolStripMenuItem1";
            this.chứcNăngToolStripMenuItem1.Size = new System.Drawing.Size(96, 24);
            this.chứcNăngToolStripMenuItem1.Text = "Chức Năng";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.sửaToolStripMenuItem.Text = "Sửa ";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // dgvStudent
            // 
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvStudent.Location = new System.Drawing.Point(12, 83);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.Size = new System.Drawing.Size(1157, 500);
            this.dgvStudent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản Lý Sinh Viên";
            // 
            // cbxChuaXepLop
            // 
            this.cbxChuaXepLop.AutoSize = true;
            this.cbxChuaXepLop.Location = new System.Drawing.Point(1029, 57);
            this.cbxChuaXepLop.Name = "cbxChuaXepLop";
            this.cbxChuaXepLop.Size = new System.Drawing.Size(140, 20);
            this.cbxChuaXepLop.TabIndex = 3;
            this.cbxChuaXepLop.Text = "Chưa được xếp lớp";
            this.cbxChuaXepLop.UseVisualStyleBackColor = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "StudentID";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "FullName";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Sex";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Birth";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Address";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Email";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Phone";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Class";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Faculty";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // frmQLSinhvien_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 595);
            this.Controls.Add(this.cbxChuaXepLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmQLSinhvien_GUI";
            this.Text = "frmQLSinhvien_GUI";
            this.Load += new System.EventHandler(this.frmQLSinhvien_GUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxChuaXepLop;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSinhVIênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýChuyênNgànhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}