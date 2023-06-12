namespace BiTiApp
{
    partial class frmSanPham
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.btnDangxuat = new System.Windows.Forms.Button();
            this.btnTaikhoang = new System.Windows.Forms.Button();
            this.btnHoadon = new System.Windows.Forms.Button();
            this.btnKhachhang = new System.Windows.Forms.Button();
            this.btnSanpham = new System.Windows.Forms.Button();
            this.dtgvSQL = new System.Windows.Forms.DataGridView();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblDonGiaNhap = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblDonGiaBan = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblAnh = new System.Windows.Forms.Label();
            this.pictureAnh = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.txtSreach = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(171)))), ((int)(((byte)(199)))));
            this.panel1.Controls.Add(this.btnQuanLy);
            this.panel1.Controls.Add(this.pictureLogo);
            this.panel1.Controls.Add(this.btnDangxuat);
            this.panel1.Controls.Add(this.btnTaikhoang);
            this.panel1.Controls.Add(this.btnHoadon);
            this.panel1.Controls.Add(this.btnKhachhang);
            this.panel1.Controls.Add(this.btnSanpham);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 591);
            this.panel1.TabIndex = 1;
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.FlatAppearance.BorderSize = 0;
            this.btnQuanLy.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLy.Location = new System.Drawing.Point(0, 186);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Size = new System.Drawing.Size(200, 38);
            this.btnQuanLy.TabIndex = 19;
            this.btnQuanLy.Text = "Quản lý";
            this.btnQuanLy.UseVisualStyleBackColor = true;
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::BiTiApp.Properties.Resources.logoBiTi;
            this.pictureLogo.Location = new System.Drawing.Point(3, 21);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(194, 125);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 5;
            this.pictureLogo.TabStop = false;
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.FlatAppearance.BorderSize = 0;
            this.btnDangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangxuat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangxuat.Location = new System.Drawing.Point(0, 542);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Size = new System.Drawing.Size(200, 37);
            this.btnDangxuat.TabIndex = 4;
            this.btnDangxuat.Text = "Đăng xuất";
            this.btnDangxuat.UseVisualStyleBackColor = false;
            this.btnDangxuat.Click += new System.EventHandler(this.btnDangxuat_Click);
            // 
            // btnTaikhoang
            // 
            this.btnTaikhoang.FlatAppearance.BorderSize = 0;
            this.btnTaikhoang.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaikhoang.Location = new System.Drawing.Point(0, 351);
            this.btnTaikhoang.Name = "btnTaikhoang";
            this.btnTaikhoang.Size = new System.Drawing.Size(200, 38);
            this.btnTaikhoang.TabIndex = 3;
            this.btnTaikhoang.Text = "Tài khoản";
            this.btnTaikhoang.UseVisualStyleBackColor = true;
            this.btnTaikhoang.Click += new System.EventHandler(this.btnTaikhoang_Click);
            // 
            // btnHoadon
            // 
            this.btnHoadon.FlatAppearance.BorderSize = 0;
            this.btnHoadon.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoadon.Location = new System.Drawing.Point(0, 314);
            this.btnHoadon.Name = "btnHoadon";
            this.btnHoadon.Size = new System.Drawing.Size(200, 38);
            this.btnHoadon.TabIndex = 2;
            this.btnHoadon.Text = "Hóa đơn";
            this.btnHoadon.UseVisualStyleBackColor = true;
            this.btnHoadon.Click += new System.EventHandler(this.btnHoadon_Click);
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.FlatAppearance.BorderSize = 0;
            this.btnKhachhang.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachhang.Location = new System.Drawing.Point(0, 277);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.Size = new System.Drawing.Size(200, 38);
            this.btnKhachhang.TabIndex = 1;
            this.btnKhachhang.Text = "Khách hàng";
            this.btnKhachhang.UseVisualStyleBackColor = true;
            this.btnKhachhang.Click += new System.EventHandler(this.btnKhachhang_Click);
            // 
            // btnSanpham
            // 
            this.btnSanpham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.btnSanpham.FlatAppearance.BorderSize = 0;
            this.btnSanpham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanpham.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanpham.Location = new System.Drawing.Point(0, 223);
            this.btnSanpham.Name = "btnSanpham";
            this.btnSanpham.Size = new System.Drawing.Size(200, 54);
            this.btnSanpham.TabIndex = 0;
            this.btnSanpham.Text = "Sản phẩm";
            this.btnSanpham.UseVisualStyleBackColor = false;
            // 
            // dtgvSQL
            // 
            this.dtgvSQL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSQL.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(135)))), ((int)(((byte)(173)))));
            this.dtgvSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSQL.Location = new System.Drawing.Point(206, 320);
            this.dtgvSQL.Name = "dtgvSQL";
            this.dtgvSQL.Size = new System.Drawing.Size(890, 259);
            this.dtgvSQL.TabIndex = 2;
            this.dtgvSQL.SelectionChanged += new System.EventHandler(this.dtgvSQL_SelectionChanged);
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSP.Location = new System.Drawing.Point(245, 38);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(51, 17);
            this.lblMaSP.TabIndex = 3;
            this.lblMaSP.Text = "Mã SP";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.Location = new System.Drawing.Point(341, 38);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(57, 17);
            this.lblTenSP.TabIndex = 4;
            this.lblTenSP.Text = "Tên SP";
            // 
            // lblDonGiaNhap
            // 
            this.lblDonGiaNhap.AutoSize = true;
            this.lblDonGiaNhap.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGiaNhap.Location = new System.Drawing.Point(341, 129);
            this.lblDonGiaNhap.Name = "lblDonGiaNhap";
            this.lblDonGiaNhap.Size = new System.Drawing.Size(96, 17);
            this.lblDonGiaNhap.TabIndex = 6;
            this.lblDonGiaNhap.Text = "Đơn giá nhập";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(245, 129);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(69, 17);
            this.lblSoLuong.TabIndex = 5;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // lblDonGiaBan
            // 
            this.lblDonGiaBan.AutoSize = true;
            this.lblDonGiaBan.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGiaBan.Location = new System.Drawing.Point(484, 129);
            this.lblDonGiaBan.Name = "lblDonGiaBan";
            this.lblDonGiaBan.Size = new System.Drawing.Size(88, 17);
            this.lblDonGiaBan.TabIndex = 8;
            this.lblDonGiaBan.Text = "Đơn giá bán";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.Location = new System.Drawing.Point(245, 195);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(62, 17);
            this.lblGhiChu.TabIndex = 7;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.Location = new System.Drawing.Point(248, 67);
            this.txtMaSP.Multiline = true;
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(64, 28);
            this.txtMaSP.TabIndex = 9;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtTenSP.Location = new System.Drawing.Point(344, 67);
            this.txtTenSP.Multiline = true;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(173, 28);
            this.txtTenSP.TabIndex = 10;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(248, 149);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(64, 28);
            this.txtSoLuong.TabIndex = 11;
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtDonGiaNhap.Location = new System.Drawing.Point(344, 149);
            this.txtDonGiaNhap.Multiline = true;
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(112, 28);
            this.txtDonGiaNhap.TabIndex = 12;
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtDonGiaBan.Location = new System.Drawing.Point(487, 149);
            this.txtDonGiaBan.Multiline = true;
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(112, 28);
            this.txtDonGiaBan.TabIndex = 13;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtGhiChu.Location = new System.Drawing.Point(344, 189);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(255, 28);
            this.txtGhiChu.TabIndex = 14;
            // 
            // lblAnh
            // 
            this.lblAnh.AutoSize = true;
            this.lblAnh.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnh.Location = new System.Drawing.Point(712, 38);
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Size = new System.Drawing.Size(37, 17);
            this.lblAnh.TabIndex = 15;
            this.lblAnh.Text = "Ảnh:";
            // 
            // pictureAnh
            // 
            this.pictureAnh.Location = new System.Drawing.Point(755, 38);
            this.pictureAnh.Name = "pictureAnh";
            this.pictureAnh.Size = new System.Drawing.Size(280, 151);
            this.pictureAnh.TabIndex = 16;
            this.pictureAnh.TabStop = false;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.FlatAppearance.BorderSize = 0;
            this.btnChonAnh.Location = new System.Drawing.Point(842, 195);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(107, 34);
            this.btnChonAnh.TabIndex = 17;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            // 
            // txtSreach
            // 
            this.txtSreach.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSreach.Location = new System.Drawing.Point(899, 286);
            this.txtSreach.Multiline = true;
            this.txtSreach.Name = "txtSreach";
            this.txtSreach.Size = new System.Drawing.Size(190, 28);
            this.txtSreach.TabIndex = 18;
            this.txtSreach.MouseEnter += new System.EventHandler(this.txtSreach_MouseEnter);
            this.txtSreach.MouseLeave += new System.EventHandler(this.txtSreach_MouseLeave);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(720, 257);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(137, 46);
            this.btnLamMoi.TabIndex = 9;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            this.btnLamMoi.MouseEnter += new System.EventHandler(this.btnLamMoi_MouseEnter);
            this.btnLamMoi.MouseLeave += new System.EventHandler(this.btnLamMoi_MouseLeave);
            // 
            // btnSua
            // 
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(563, 257);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(137, 46);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            this.btnSua.MouseEnter += new System.EventHandler(this.btnSua_MouseEnter);
            this.btnSua.MouseLeave += new System.EventHandler(this.btnSua_MouseLeave);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(404, 257);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(137, 46);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnXoa.MouseEnter += new System.EventHandler(this.btnXoa_MouseEnter);
            this.btnXoa.MouseLeave += new System.EventHandler(this.btnXoa_MouseLeave);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(248, 257);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 46);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnThem.MouseEnter += new System.EventHandler(this.btnThem_MouseEnter);
            this.btnThem.MouseLeave += new System.EventHandler(this.btnThem_MouseLeave);
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1101, 591);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.txtSreach);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.pictureAnh);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblAnh);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtDonGiaBan);
            this.Controls.Add(this.txtDonGiaNhap);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.lblDonGiaBan);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.lblDonGiaNhap);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.dtgvSQL);
            this.Controls.Add(this.panel1);
            this.Name = "frmSanPham";
            this.Text = "Form sản phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTaikhoang;
        private System.Windows.Forms.Button btnHoadon;
        private System.Windows.Forms.Button btnKhachhang;
        private System.Windows.Forms.Button btnSanpham;
        private System.Windows.Forms.Button btnDangxuat;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.DataGridView dtgvSQL;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblDonGiaNhap;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblDonGiaBan;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblAnh;
        private System.Windows.Forms.PictureBox pictureAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.TextBox txtSreach;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnQuanLy;
    }
}