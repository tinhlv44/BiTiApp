﻿namespace BiTiApp
{
    partial class frmKhachHang
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
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtSreachTenKH = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtgvSQL = new System.Windows.Forms.DataGridView();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.ptbSearch = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(66)))), ((int)(((byte)(63)))));
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
            this.panel1.TabIndex = 2;
            // 
            // btnQuanLy
            // 
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
            this.btnDangxuat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangxuat.Location = new System.Drawing.Point(0, 542);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Size = new System.Drawing.Size(200, 37);
            this.btnDangxuat.TabIndex = 4;
            this.btnDangxuat.Text = "Đăng xuất";
            this.btnDangxuat.UseVisualStyleBackColor = true;
            this.btnDangxuat.Click += new System.EventHandler(this.btnDangxuat_Click);
            // 
            // btnTaikhoang
            // 
            this.btnTaikhoang.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaikhoang.Location = new System.Drawing.Point(0, 334);
            this.btnTaikhoang.Name = "btnTaikhoang";
            this.btnTaikhoang.Size = new System.Drawing.Size(200, 38);
            this.btnTaikhoang.TabIndex = 3;
            this.btnTaikhoang.Text = "Tài khoản";
            this.btnTaikhoang.UseVisualStyleBackColor = true;
            this.btnTaikhoang.Click += new System.EventHandler(this.btnTaikhoang_Click);
            // 
            // btnHoadon
            // 
            this.btnHoadon.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoadon.Location = new System.Drawing.Point(0, 297);
            this.btnHoadon.Name = "btnHoadon";
            this.btnHoadon.Size = new System.Drawing.Size(200, 38);
            this.btnHoadon.TabIndex = 2;
            this.btnHoadon.Text = "Hóa đơn";
            this.btnHoadon.UseVisualStyleBackColor = true;
            this.btnHoadon.Click += new System.EventHandler(this.btnHoadon_Click);
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachhang.Location = new System.Drawing.Point(0, 260);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.Size = new System.Drawing.Size(200, 38);
            this.btnKhachhang.TabIndex = 1;
            this.btnKhachhang.Text = "Khách hàng";
            this.btnKhachhang.UseVisualStyleBackColor = true;
            // 
            // btnSanpham
            // 
            this.btnSanpham.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanpham.Location = new System.Drawing.Point(0, 223);
            this.btnSanpham.Name = "btnSanpham";
            this.btnSanpham.Size = new System.Drawing.Size(200, 38);
            this.btnSanpham.TabIndex = 0;
            this.btnSanpham.Text = "Sản phẩm";
            this.btnSanpham.UseVisualStyleBackColor = true;
            this.btnSanpham.Click += new System.EventHandler(this.btnSanpham_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(718, 198);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(137, 46);
            this.btnLamMoi.TabIndex = 23;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtSreachTenKH
            // 
            this.txtSreachTenKH.Location = new System.Drawing.Point(906, 213);
            this.txtSreachTenKH.Multiline = true;
            this.txtSreachTenKH.Name = "txtSreachTenKH";
            this.txtSreachTenKH.Size = new System.Drawing.Size(190, 28);
            this.txtSreachTenKH.TabIndex = 24;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(555, 198);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(137, 46);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(392, 198);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(137, 46);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(229, 198);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 46);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtgvSQL
            // 
            this.dtgvSQL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSQL.Location = new System.Drawing.Point(206, 260);
            this.dtgvSQL.Name = "dtgvSQL";
            this.dtgvSQL.Size = new System.Drawing.Size(890, 331);
            this.dtgvSQL.TabIndex = 19;
            this.dtgvSQL.SelectionChanged += new System.EventHandler(this.dtgvSQL_SelectionChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(712, 47);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(190, 28);
            this.txtDiaChi.TabIndex = 25;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(373, 47);
            this.txtMaKH.Multiline = true;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(190, 28);
            this.txtMaKH.TabIndex = 27;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(373, 108);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(190, 28);
            this.txtHoTen.TabIndex = 26;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(712, 108);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(190, 28);
            this.txtSDT.TabIndex = 28;
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.Location = new System.Drawing.Point(316, 53);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(51, 17);
            this.lblMaKH.TabIndex = 29;
            this.lblMaKH.Text = "Mã KH";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(316, 114);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(50, 17);
            this.lblHoTen.TabIndex = 30;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(614, 53);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(53, 17);
            this.lblDiaChi.TabIndex = 31;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(614, 114);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(92, 17);
            this.lblSDT.TabIndex = 32;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // ptbSearch
            // 
            this.ptbSearch.BackColor = System.Drawing.SystemColors.Control;
            this.ptbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbSearch.Image = global::BiTiApp.Properties.Resources.icon_search;
            this.ptbSearch.Location = new System.Drawing.Point(870, 213);
            this.ptbSearch.Name = "ptbSearch";
            this.ptbSearch.Size = new System.Drawing.Size(30, 28);
            this.ptbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbSearch.TabIndex = 55;
            this.ptbSearch.TabStop = false;
            this.ptbSearch.Click += new System.EventHandler(this.ptbSearch_Click);
            this.ptbSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ptbSearch_MouseDown);
            this.ptbSearch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptbSearch_MouseUp);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 591);
            this.Controls.Add(this.ptbSearch);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.txtSreachTenKH);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtgvSQL);
            this.Controls.Add(this.panel1);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Button btnDangxuat;
        private System.Windows.Forms.Button btnTaikhoang;
        private System.Windows.Forms.Button btnHoadon;
        private System.Windows.Forms.Button btnKhachhang;
        private System.Windows.Forms.Button btnSanpham;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtSreachTenKH;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dtgvSQL;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Button btnQuanLy;
        private System.Windows.Forms.PictureBox ptbSearch;
    }
}