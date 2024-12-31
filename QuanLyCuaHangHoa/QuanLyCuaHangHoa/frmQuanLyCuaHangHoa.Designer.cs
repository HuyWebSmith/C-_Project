namespace QuanLyCuaHangHoa
{
    partial class frmQuanLyCuaHangHoa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Huy_96_btn_them = new System.Windows.Forms.Button();
            this.Huy_96_btn_sua = new System.Windows.Forms.Button();
            this.labelTong = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Huy_96_btn_xoa = new System.Windows.Forms.Button();
            this.dgvCuaHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSDTNV = new System.Windows.Forms.TextBox();
            this.txtHotenNV = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenCH = new System.Windows.Forms.TextBox();
            this.txtMaCH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuaHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Huy_96_btn_them);
            this.groupBox1.Controls.Add(this.Huy_96_btn_sua);
            this.groupBox1.Controls.Add(this.labelTong);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.txtTim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Huy_96_btn_xoa);
            this.groupBox1.Controls.Add(this.dgvCuaHang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1023, 684);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Cửa Hàng";
            // 
            // Huy_96_btn_them
            // 
            this.Huy_96_btn_them.Location = new System.Drawing.Point(942, 641);
            this.Huy_96_btn_them.Name = "Huy_96_btn_them";
            this.Huy_96_btn_them.Size = new System.Drawing.Size(75, 23);
            this.Huy_96_btn_them.TabIndex = 3;
            this.Huy_96_btn_them.Text = "Thêm";
            this.Huy_96_btn_them.UseVisualStyleBackColor = true;
            this.Huy_96_btn_them.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Huy_96_btn_sua
            // 
            this.Huy_96_btn_sua.Location = new System.Drawing.Point(782, 641);
            this.Huy_96_btn_sua.Name = "Huy_96_btn_sua";
            this.Huy_96_btn_sua.Size = new System.Drawing.Size(75, 23);
            this.Huy_96_btn_sua.TabIndex = 4;
            this.Huy_96_btn_sua.Text = "Sửa";
            this.Huy_96_btn_sua.UseVisualStyleBackColor = true;
            this.Huy_96_btn_sua.Click += new System.EventHandler(this.Huy_96_btn_sua_Click);
            // 
            // labelTong
            // 
            this.labelTong.AutoSize = true;
            this.labelTong.Location = new System.Drawing.Point(0, 614);
            this.labelTong.Name = "labelTong";
            this.labelTong.Size = new System.Drawing.Size(146, 16);
            this.labelTong.TabIndex = 5;
            this.labelTong.Text = "Tổng Số Cửa Hàng: ";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTim.Location = new System.Drawing.Point(417, 28);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 37);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(101, 35);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(310, 22);
            this.txtTim.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm Theo Mã";
            // 
            // Huy_96_btn_xoa
            // 
            this.Huy_96_btn_xoa.Location = new System.Drawing.Point(3, 641);
            this.Huy_96_btn_xoa.Name = "Huy_96_btn_xoa";
            this.Huy_96_btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.Huy_96_btn_xoa.TabIndex = 2;
            this.Huy_96_btn_xoa.Text = "Xóa";
            this.Huy_96_btn_xoa.UseVisualStyleBackColor = true;
            this.Huy_96_btn_xoa.Click += new System.EventHandler(this.Huy_96_btn_xoa_Click);
            // 
            // dgvCuaHang
            // 
            this.dgvCuaHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCuaHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuaHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvCuaHang.Location = new System.Drawing.Point(6, 75);
            this.dgvCuaHang.Name = "dgvCuaHang";
            this.dgvCuaHang.RowHeadersWidth = 51;
            this.dgvCuaHang.RowTemplate.Height = 24;
            this.dgvCuaHang.Size = new System.Drawing.Size(1011, 527);
            this.dgvCuaHang.TabIndex = 0;
            this.dgvCuaHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuaHang_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Cửa Hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Cửa Hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Địa Chỉ Cửa Hàng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SDT Cửa Hàng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email Cửa Hàng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Họ Tên Nhân Viên";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "SDT Nhân Viên";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSDTNV);
            this.groupBox2.Controls.Add(this.txtHotenNV);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtSDT);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.txtTenCH);
            this.groupBox2.Controls.Add(this.txtMaCH);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1041, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 684);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết";
            // 
            // txtSDTNV
            // 
            this.txtSDTNV.Location = new System.Drawing.Point(154, 375);
            this.txtSDTNV.Name = "txtSDTNV";
            this.txtSDTNV.Size = new System.Drawing.Size(252, 22);
            this.txtSDTNV.TabIndex = 15;
            // 
            // txtHotenNV
            // 
            this.txtHotenNV.Location = new System.Drawing.Point(154, 321);
            this.txtHotenNV.Name = "txtHotenNV";
            this.txtHotenNV.Size = new System.Drawing.Size(252, 22);
            this.txtHotenNV.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(154, 276);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(252, 22);
            this.txtEmail.TabIndex = 13;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(154, 230);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(252, 22);
            this.txtSDT.TabIndex = 12;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(154, 175);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(252, 22);
            this.txtDiaChi.TabIndex = 11;
            // 
            // txtTenCH
            // 
            this.txtTenCH.Location = new System.Drawing.Point(154, 124);
            this.txtTenCH.Name = "txtTenCH";
            this.txtTenCH.Size = new System.Drawing.Size(252, 22);
            this.txtTenCH.TabIndex = 10;
            // 
            // txtMaCH
            // 
            this.txtMaCH.Location = new System.Drawing.Point(154, 75);
            this.txtMaCH.Name = "txtMaCH";
            this.txtMaCH.Size = new System.Drawing.Size(252, 22);
            this.txtMaCH.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "SDT Nhân Viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Họ Tên Nhân Viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "SDT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa Chỉ Cửa Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Cửa hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Cửa Hàng";
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(331, 641);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(6, 641);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmQuanLyCuaHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 688);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQuanLyCuaHangHoa";
            this.Text = "Cửa Hàng Hoa";
            this.Load += new System.EventHandler(this.frmQuanLyCuaHangHoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuaHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCuaHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button Huy_96_btn_xoa;
        private System.Windows.Forms.TextBox txtSDTNV;
        private System.Windows.Forms.TextBox txtHotenNV;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenCH;
        private System.Windows.Forms.TextBox txtMaCH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Huy_96_btn_them;
        private System.Windows.Forms.Button Huy_96_btn_sua;
        private System.Windows.Forms.Label labelTong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}