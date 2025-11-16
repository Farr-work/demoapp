namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txbMaH = new TextBox();
            txbTenH = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txbSoLuong = new TextBox();
            label4 = new Label();
            txbGia = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            rdbHangCu = new RadioButton();
            rdbHangMoi = new RadioButton();
            dtNgayNhap = new DateTimePicker();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnTimKiem = new Button();
            dtgvHang = new DataGridView();
            button1 = new Button();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvHang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 80);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã hàng";
            // 
            // txbMaH
            // 
            txbMaH.Location = new Point(240, 73);
            txbMaH.Name = "txbMaH";
            txbMaH.Size = new Size(298, 27);
            txbMaH.TabIndex = 1;
            // 
            // txbTenH
            // 
            txbTenH.Location = new Point(240, 133);
            txbTenH.Name = "txbTenH";
            txbTenH.Size = new Size(298, 27);
            txbTenH.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 140);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 208);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 4;
            label3.Text = "Ngày nhập";
            // 
            // txbSoLuong
            // 
            txbSoLuong.Location = new Point(240, 271);
            txbSoLuong.Name = "txbSoLuong";
            txbSoLuong.Size = new Size(298, 27);
            txbSoLuong.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 278);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 6;
            label4.Text = "Số lượng";
            // 
            // txbGia
            // 
            txbGia.Location = new Point(240, 352);
            txbGia.Name = "txbGia";
            txbGia.Size = new Size(298, 27);
            txbGia.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(95, 359);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 8;
            label5.Text = "Giá bán";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbHangCu);
            groupBox1.Controls.Add(rdbHangMoi);
            groupBox1.Location = new Point(95, 429);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(443, 125);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Trạng thái";
            // 
            // rdbHangCu
            // 
            rdbHangCu.AutoSize = true;
            rdbHangCu.Location = new Point(284, 56);
            rdbHangCu.Name = "rdbHangCu";
            rdbHangCu.Size = new Size(85, 24);
            rdbHangCu.TabIndex = 1;
            rdbHangCu.TabStop = true;
            rdbHangCu.Text = "Hàng cũ";
            rdbHangCu.UseVisualStyleBackColor = true;
            // 
            // rdbHangMoi
            // 
            rdbHangMoi.AutoSize = true;
            rdbHangMoi.Location = new Point(43, 56);
            rdbHangMoi.Name = "rdbHangMoi";
            rdbHangMoi.Size = new Size(96, 24);
            rdbHangMoi.TabIndex = 0;
            rdbHangMoi.TabStop = true;
            rdbHangMoi.Text = "Hàng mới";
            rdbHangMoi.UseVisualStyleBackColor = true;
            // 
            // dtNgayNhap
            // 
            dtNgayNhap.Location = new Point(240, 208);
            dtNgayNhap.Name = "dtNgayNhap";
            dtNgayNhap.Size = new Size(298, 27);
            dtNgayNhap.TabIndex = 11;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(693, 71);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(874, 71);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(693, 132);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(874, 133);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 15;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dtgvHang
            // 
            dtgvHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvHang.Dock = DockStyle.Bottom;
            dtgvHang.Location = new Point(0, 599);
            dtgvHang.Name = "dtgvHang";
            dtgvHang.RowHeadersWidth = 51;
            dtgvHang.Size = new Size(1087, 164);
            dtgvHang.TabIndex = 16;
            dtgvHang.CellClick += dtgvHang_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(693, 206);
            button1.Name = "button1";
            button1.Size = new Size(275, 29);
            button1.TabIndex = 17;
            button1.Text = "Trang trí cho đỡ trống";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(814, 277);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 18;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 763);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(dtgvHang);
            Controls.Add(btnTimKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dtNgayNhap);
            Controls.Add(groupBox1);
            Controls.Add(txbGia);
            Controls.Add(label5);
            Controls.Add(txbSoLuong);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txbTenH);
            Controls.Add(label2);
            Controls.Add(txbMaH);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbMaH;
        private TextBox txbTenH;
        private Label label2;
        private Label label3;
        private TextBox txbSoLuong;
        private Label label4;
        private TextBox txbGia;
        private Label label5;
        private GroupBox groupBox1;
        private RadioButton rdbHangCu;
        private RadioButton rdbHangMoi;
        private DateTimePicker dtNgayNhap;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTimKiem;
        private DataGridView dtgvHang;
        private Button button1;
        private ComboBox comboBox1;
    }
}
