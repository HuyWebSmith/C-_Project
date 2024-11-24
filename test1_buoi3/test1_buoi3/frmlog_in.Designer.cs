namespace test1_buoi3
{
    partial class log_in_form
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.btnTen = new System.Windows.Forms.Button();
            this.lblTen = new System.Windows.Forms.Label();
            this.btnHolot = new System.Windows.Forms.Button();
            this.btnHoTen = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHovaten = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(114, 130);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Họ lót";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(196, 130);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(501, 22);
            this.txtHo.TabIndex = 1;
            // 
            // btnTen
            // 
            this.btnTen.Location = new System.Drawing.Point(328, 230);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(75, 23);
            this.btnTen.TabIndex = 2;
            this.btnTen.Text = "Tên";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(117, 167);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(31, 16);
            this.lblTen.TabIndex = 3;
            this.lblTen.Text = "Tên";
            // 
            // btnHolot
            // 
            this.btnHolot.Location = new System.Drawing.Point(196, 230);
            this.btnHolot.Name = "btnHolot";
            this.btnHolot.Size = new System.Drawing.Size(75, 23);
            this.btnHolot.TabIndex = 4;
            this.btnHolot.Text = "Họ lót";
            this.btnHolot.UseVisualStyleBackColor = true;
            this.btnHolot.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHoTen
            // 
            this.btnHoTen.Location = new System.Drawing.Point(483, 229);
            this.btnHoTen.Name = "btnHoTen";
            this.btnHoTen.Size = new System.Drawing.Size(75, 23);
            this.btnHoTen.TabIndex = 5;
            this.btnHoTen.Text = "Họ và tên";
            this.btnHoTen.UseVisualStyleBackColor = true;
            this.btnHoTen.Click += new System.EventHandler(this.btnHoTen_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(328, 326);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát chương trình";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(196, 167);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(501, 22);
            this.txtTen.TabIndex = 7;
            // 
            // txtHovaten
            // 
            this.txtHovaten.Location = new System.Drawing.Point(196, 45);
            this.txtHovaten.Name = "txtHovaten";
            this.txtHovaten.Size = new System.Drawing.Size(501, 22);
            this.txtHovaten.TabIndex = 8;
            this.txtHovaten.DoubleClick += new System.EventHandler(this.txtHovaten_DoubleClick);
            // 
            // log_in_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHovaten);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHoTen);
            this.Controls.Add(this.btnHolot);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.lblName);
            this.Name = "log_in_form";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.log_in_form_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Button btnHolot;
        private System.Windows.Forms.Button btnHoTen;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHovaten;
    }
}

