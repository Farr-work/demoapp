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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvHang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 60);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã hàng";
            // 
            // txbMaH
            // 
            txbMaH.Location = new Point(210, 55);
            txbMaH.Margin = new Padding(3, 2, 3, 2);
            txbMaH.Name = "txbMaH";
            txbMaH.Size = new Size(261, 23);
            txbMaH.TabIndex = 1;
            // 
            // txbTenH
            // 
            txbTenH.Location = new Point(210, 100);
            txbTenH.Margin = new Padding(3, 2, 3, 2);
            txbTenH.Name = "txbTenH";
            txbTenH.Size = new Size(261, 23);
            txbTenH.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 105);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 156);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 4;
            label3.Text = "Ngày nhập";
            // 
            // txbSoLuong
            // 
            txbSoLuong.Location = new Point(210, 203);
            txbSoLuong.Margin = new Padding(3, 2, 3, 2);
            txbSoLuong.Name = "txbSoLuong";
            txbSoLuong.Size = new Size(261, 23);
            txbSoLuong.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 208);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 6;
            label4.Text = "Số lượng";
            // 
            // txbGia
            // 
            txbGia.Location = new Point(210, 264);
            txbGia.Margin = new Padding(3, 2, 3, 2);
            txbGia.Name = "txbGia";
            txbGia.Size = new Size(261, 23);
            txbGia.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 269);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 8;
            label5.Text = "Giá bán";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbHangCu);
            groupBox1.Controls.Add(rdbHangMoi);
            groupBox1.Location = new Point(83, 322);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(388, 94);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Trạng thái";
            // 
            // rdbHangCu
            // 
            rdbHangCu.AutoSize = true;
            rdbHangCu.Location = new Point(248, 42);
            rdbHangCu.Margin = new Padding(3, 2, 3, 2);
            rdbHangCu.Name = "rdbHangCu";
            rdbHangCu.Size = new Size(70, 19);
            rdbHangCu.TabIndex = 1;
            rdbHangCu.TabStop = true;
            rdbHangCu.Text = "Hàng cũ";
            rdbHangCu.UseVisualStyleBackColor = true;
            // 
            // rdbHangMoi
            // 
            rdbHangMoi.AutoSize = true;
            rdbHangMoi.Location = new Point(38, 42);
            rdbHangMoi.Margin = new Padding(3, 2, 3, 2);
            rdbHangMoi.Name = "rdbHangMoi";
            rdbHangMoi.Size = new Size(78, 19);
            rdbHangMoi.TabIndex = 0;
            rdbHangMoi.TabStop = true;
            rdbHangMoi.Text = "Hàng mới";
            rdbHangMoi.UseVisualStyleBackColor = true;
            // 
            // dtNgayNhap
            // 
            dtNgayNhap.Location = new Point(210, 156);
            dtNgayNhap.Margin = new Padding(3, 2, 3, 2);
            dtNgayNhap.Name = "dtNgayNhap";
            dtNgayNhap.Size = new Size(261, 23);
            dtNgayNhap.TabIndex = 11;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(606, 53);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(82, 22);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(765, 53);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(82, 22);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(606, 99);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(82, 22);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(765, 100);
            btnTimKiem.Margin = new Padding(3, 2, 3, 2);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(82, 22);
            btnTimKiem.TabIndex = 15;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dtgvHang
            // 
            dtgvHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvHang.Dock = DockStyle.Bottom;
            dtgvHang.Location = new Point(0, 449);
            dtgvHang.Margin = new Padding(3, 2, 3, 2);
            dtgvHang.Name = "dtgvHang";
            dtgvHang.RowHeadersWidth = 51;
            dtgvHang.Size = new Size(951, 123);
            dtgvHang.TabIndex = 16;
            dtgvHang.CellClick += dtgvHang_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(600, 168);
            button1.Name = "button1";
            button1.Size = new Size(247, 23);
            button1.TabIndex = 17;
            button1.Text = "em phongdepzai đã ở đây";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 572);
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
            Margin = new Padding(3, 2, 3, 2);
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
    }
}
