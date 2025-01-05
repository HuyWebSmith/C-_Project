namespace QuanLyChiTieuCaNhan
{
    partial class frmBase
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBase));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuBtn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBudgets = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnGoals = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblExpense = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvChiTieuGanDay = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblXinChao = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.lblDate = new System.Windows.Forms.Label();
            this.curentDaytimer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnload = new System.Windows.Forms.Button();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTieuGanDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Controls.Add(this.btnLogOut);
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(301, 781);
            this.sidebar.MinimumSize = new System.Drawing.Size(105, 781);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(105, 781);
            this.sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuBtn);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 131);
            this.panel1.TabIndex = 0;
            // 
            // menuBtn
            // 
            this.menuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBtn.Image = ((System.Drawing.Image)(resources.GetObject("menuBtn.Image")));
            this.menuBtn.Location = new System.Drawing.Point(21, 48);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(60, 45);
            this.menuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuBtn.TabIndex = 0;
            this.menuBtn.TabStop = false;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Location = new System.Drawing.Point(3, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 66);
            this.panel2.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-3, -13);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(308, 91);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "                  Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnTransactions);
            this.panel3.Location = new System.Drawing.Point(3, 212);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 66);
            this.panel3.TabIndex = 1;
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.ForeColor = System.Drawing.Color.White;
            this.btnTransactions.Image = ((System.Drawing.Image)(resources.GetObject("btnTransactions.Image")));
            this.btnTransactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactions.Location = new System.Drawing.Point(-3, -14);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnTransactions.Size = new System.Drawing.Size(308, 91);
            this.btnTransactions.TabIndex = 4;
            this.btnTransactions.Text = "                   Transactions";
            this.btnTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactions.UseVisualStyleBackColor = false;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnBudgets);
            this.panel4.Location = new System.Drawing.Point(3, 284);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(298, 66);
            this.panel4.TabIndex = 2;
            // 
            // btnBudgets
            // 
            this.btnBudgets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnBudgets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBudgets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBudgets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBudgets.ForeColor = System.Drawing.Color.White;
            this.btnBudgets.Image = ((System.Drawing.Image)(resources.GetObject("btnBudgets.Image")));
            this.btnBudgets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBudgets.Location = new System.Drawing.Point(-3, -11);
            this.btnBudgets.Name = "btnBudgets";
            this.btnBudgets.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBudgets.Size = new System.Drawing.Size(308, 91);
            this.btnBudgets.TabIndex = 7;
            this.btnBudgets.Text = "                  Budgets";
            this.btnBudgets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBudgets.UseVisualStyleBackColor = false;
            this.btnBudgets.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnGoals);
            this.panel5.Location = new System.Drawing.Point(3, 356);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(298, 66);
            this.panel5.TabIndex = 3;
            // 
            // btnGoals
            // 
            this.btnGoals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnGoals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoals.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoals.ForeColor = System.Drawing.Color.White;
            this.btnGoals.Image = ((System.Drawing.Image)(resources.GetObject("btnGoals.Image")));
            this.btnGoals.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoals.Location = new System.Drawing.Point(-3, -12);
            this.btnGoals.Name = "btnGoals";
            this.btnGoals.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGoals.Size = new System.Drawing.Size(308, 91);
            this.btnGoals.TabIndex = 6;
            this.btnGoals.Text = "                  Goals";
            this.btnGoals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoals.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnReport);
            this.panel6.Location = new System.Drawing.Point(3, 428);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(298, 66);
            this.panel6.TabIndex = 2;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(-3, -10);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(308, 91);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "                  Reports";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(3, 500);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(298, 101);
            this.panel7.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnDangNhap);
            this.panel8.Location = new System.Drawing.Point(3, 607);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(295, 84);
            this.panel8.TabIndex = 10;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.Image")));
            this.btnDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangNhap.Location = new System.Drawing.Point(0, 0);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDangNhap.Size = new System.Drawing.Size(298, 91);
            this.btnDangNhap.TabIndex = 10;
            this.btnDangNhap.Text = "                  Log In";
            this.btnDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(3, 697);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(298, 80);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "                  Log Out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Visible = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMain.Controls.Add(this.lblExpense);
            this.pnlMain.Controls.Add(this.lblBalance);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.dgvChiTieuGanDay);
            this.pnlMain.Location = new System.Drawing.Point(101, 127);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1266, 654);
            this.pnlMain.TabIndex = 2;
            // 
            // lblExpense
            // 
            this.lblExpense.AutoSize = true;
            this.lblExpense.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpense.ForeColor = System.Drawing.Color.Red;
            this.lblExpense.Location = new System.Drawing.Point(39, 235);
            this.lblExpense.Name = "lblExpense";
            this.lblExpense.Size = new System.Drawing.Size(128, 45);
            this.lblExpense.TabIndex = 5;
            this.lblExpense.Text = "Money";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblBalance.Location = new System.Drawing.Point(39, 97);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(128, 45);
            this.lblBalance.TabIndex = 4;
            this.lblBalance.Text = "Money";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(92, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Tiền Đã Sử Dụng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(92, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Dư Hiện Tại";
            // 
            // dgvChiTieuGanDay
            // 
            this.dgvChiTieuGanDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTieuGanDay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTieuGanDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTieuGanDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvChiTieuGanDay.Location = new System.Drawing.Point(680, 0);
            this.dgvChiTieuGanDay.Name = "dgvChiTieuGanDay";
            this.dgvChiTieuGanDay.RowHeadersWidth = 51;
            this.dgvChiTieuGanDay.RowTemplate.Height = 24;
            this.dgvChiTieuGanDay.Size = new System.Drawing.Size(586, 654);
            this.dgvChiTieuGanDay.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Loại ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày Chi";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ghi Chú";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblXinChao
            // 
            this.lblXinChao.AutoSize = true;
            this.lblXinChao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXinChao.ForeColor = System.Drawing.Color.White;
            this.lblXinChao.Location = new System.Drawing.Point(235, 51);
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Size = new System.Drawing.Size(97, 20);
            this.lblXinChao.TabIndex = 4;
            this.lblXinChao.Text = "Xin Chào!!";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(1121, 51);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(90, 20);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Loading...";
            // 
            // curentDaytimer
            // 
            this.curentDaytimer.Tick += new System.EventHandler(this.curentDaytimer_Tick);
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(1281, 98);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(75, 23);
            this.btnload.TabIndex = 7;
            this.btnload.Text = "Load";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(87)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(1368, 780);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblXinChao);
            this.Name = "frmBase";
            this.Text = "QUẢN LÝ THU NHẬP CÁ NHÂN";
            this.Load += new System.EventHandler(this.frmBase_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTieuGanDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBudgets;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnGoals;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.PictureBox menuBtn;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblXinChao;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView dgvChiTieuGanDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer curentDaytimer;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblExpense;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnload;
    }
}