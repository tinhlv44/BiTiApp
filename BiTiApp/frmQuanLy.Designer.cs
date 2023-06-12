namespace BiTiApp
{
    partial class frmQuanLy
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
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtSreachTenNV = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.checkBox_NV = new System.Windows.Forms.CheckBox();
            this.checkBox_QTri = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.ptbSearch = new System.Windows.Forms.PictureBox();
            this.ptbShowPass = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbShowPass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(21)))), ((int)(((byte)(212)))));
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
            this.panel1.TabIndex = 3;
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(116)))), ((int)(((byte)(227)))));
            this.btnQuanLy.FlatAppearance.BorderSize = 0;
            this.btnQuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLy.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLy.Location = new System.Drawing.Point(0, 186);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Size = new System.Drawing.Size(200, 54);
            this.btnQuanLy.TabIndex = 6;
            this.btnQuanLy.Text = "Quản lý";
            this.btnQuanLy.UseVisualStyleBackColor = false;
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
            this.btnDangxuat.UseVisualStyleBackColor = true;
            this.btnDangxuat.Click += new System.EventHandler(this.btnDangxuat_Click);
            // 
            // btnTaikhoang
            // 
            this.btnTaikhoang.FlatAppearance.BorderSize = 0;
            this.btnTaikhoang.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaikhoang.Location = new System.Drawing.Point(0, 350);
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
            this.btnHoadon.Location = new System.Drawing.Point(0, 313);
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
            this.btnKhachhang.Location = new System.Drawing.Point(0, 276);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.Size = new System.Drawing.Size(200, 38);
            this.btnKhachhang.TabIndex = 1;
            this.btnKhachhang.Text = "Khách hàng";
            this.btnKhachhang.UseVisualStyleBackColor = true;
            this.btnKhachhang.Click += new System.EventHandler(this.btnKhachhang_Click);
            // 
            // btnSanpham
            // 
            this.btnSanpham.FlatAppearance.BorderSize = 0;
            this.btnSanpham.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanpham.Location = new System.Drawing.Point(0, 239);
            this.btnSanpham.Name = "btnSanpham";
            this.btnSanpham.Size = new System.Drawing.Size(200, 38);
            this.btnSanpham.TabIndex = 0;
            this.btnSanpham.Text = "Sản phẩm";
            this.btnSanpham.UseVisualStyleBackColor = true;
            this.btnSanpham.Click += new System.EventHandler(this.btnSanpham_Click);
            // 
            // dtgvSQL
            // 
            this.dtgvSQL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSQL.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(5)))), ((int)(((byte)(176)))));
            this.dtgvSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSQL.Location = new System.Drawing.Point(206, 260);
            this.dtgvSQL.Name = "dtgvSQL";
            this.dtgvSQL.Size = new System.Drawing.Size(890, 331);
            this.dtgvSQL.TabIndex = 20;
            this.dtgvSQL.SelectionChanged += new System.EventHandler(this.dtgvSQL_SelectionChanged);
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(657, 98);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(96, 17);
            this.lblSDT.TabIndex = 45;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(657, 37);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(57, 17);
            this.lblDiaChi.TabIndex = 44;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(316, 98);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 17);
            this.lblEmail.TabIndex = 43;
            this.lblEmail.Text = "Email:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(316, 37);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(50, 17);
            this.lblHoTen.TabIndex = 42;
            this.lblHoTen.Text = "Họ tên";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtSDT.Location = new System.Drawing.Point(755, 92);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(190, 28);
            this.txtSDT.TabIndex = 41;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(373, 31);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(190, 28);
            this.txtHoTen.TabIndex = 40;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtEmail.Location = new System.Drawing.Point(373, 92);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(190, 28);
            this.txtEmail.TabIndex = 39;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtDiaChi.Location = new System.Drawing.Point(755, 31);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(190, 28);
            this.txtDiaChi.TabIndex = 38;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(719, 199);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(137, 46);
            this.btnLamMoi.TabIndex = 36;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            this.btnLamMoi.MouseEnter += new System.EventHandler(this.btnLamMoi_MouseEnter);
            this.btnLamMoi.MouseLeave += new System.EventHandler(this.btnLamMoi_MouseLeave);
            // 
            // txtSreachTenNV
            // 
            this.txtSreachTenNV.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtSreachTenNV.Location = new System.Drawing.Point(906, 214);
            this.txtSreachTenNV.Multiline = true;
            this.txtSreachTenNV.Name = "txtSreachTenNV";
            this.txtSreachTenNV.Size = new System.Drawing.Size(190, 28);
            this.txtSreachTenNV.TabIndex = 37;
            this.txtSreachTenNV.MouseEnter += new System.EventHandler(this.txtSreachTenNV_MouseEnter);
            this.txtSreachTenNV.MouseLeave += new System.EventHandler(this.txtSreachTenNV_MouseLeave);
            // 
            // btnSua
            // 
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(556, 199);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(137, 46);
            this.btnSua.TabIndex = 35;
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
            this.btnXoa.Location = new System.Drawing.Point(393, 199);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(137, 46);
            this.btnXoa.TabIndex = 34;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnXoa.MouseEnter += new System.EventHandler(this.btnXoa_MouseEnter);
            this.btnXoa.MouseLeave += new System.EventHandler(this.btnXoa_MouseLeave);
            // 
            // btnThem
            // 
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(230, 199);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 46);
            this.btnThem.TabIndex = 33;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnThem.MouseEnter += new System.EventHandler(this.btnThem_MouseEnter);
            this.btnThem.MouseLeave += new System.EventHandler(this.btnThem_MouseLeave);
            // 
            // lblVaiTro
            // 
            this.lblVaiTro.AutoSize = true;
            this.lblVaiTro.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaiTro.Location = new System.Drawing.Point(316, 152);
            this.lblVaiTro.Name = "lblVaiTro";
            this.lblVaiTro.Size = new System.Drawing.Size(52, 17);
            this.lblVaiTro.TabIndex = 46;
            this.lblVaiTro.Text = "Vai trò:";
            // 
            // checkBox_NV
            // 
            this.checkBox_NV.AutoSize = true;
            this.checkBox_NV.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_NV.Location = new System.Drawing.Point(393, 152);
            this.checkBox_NV.Name = "checkBox_NV";
            this.checkBox_NV.Size = new System.Drawing.Size(81, 19);
            this.checkBox_NV.TabIndex = 47;
            this.checkBox_NV.Text = "Nhân viên";
            this.checkBox_NV.UseVisualStyleBackColor = true;
            // 
            // checkBox_QTri
            // 
            this.checkBox_QTri.AutoSize = true;
            this.checkBox_QTri.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_QTri.Location = new System.Drawing.Point(483, 152);
            this.checkBox_QTri.Name = "checkBox_QTri";
            this.checkBox_QTri.Size = new System.Drawing.Size(69, 19);
            this.checkBox_QTri.TabIndex = 48;
            this.checkBox_QTri.Text = "Quản trị";
            this.checkBox_QTri.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(657, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtMatKhau.Location = new System.Drawing.Point(755, 150);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(190, 28);
            this.txtMatKhau.TabIndex = 49;
            // 
            // ptbSearch
            // 
            this.ptbSearch.BackColor = System.Drawing.SystemColors.Control;
            this.ptbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbSearch.Image = global::BiTiApp.Properties.Resources.icon_search;
            this.ptbSearch.Location = new System.Drawing.Point(870, 214);
            this.ptbSearch.Name = "ptbSearch";
            this.ptbSearch.Size = new System.Drawing.Size(30, 28);
            this.ptbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbSearch.TabIndex = 54;
            this.ptbSearch.TabStop = false;
            this.ptbSearch.Click += new System.EventHandler(this.ptbSearch_Click);
            this.ptbSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ptbSearch_MouseDown);
            this.ptbSearch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptbSearch_MouseUp);
            // 
            // ptbShowPass
            // 
            this.ptbShowPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbShowPass.Image = global::BiTiApp.Properties.Resources.hidepass;
            this.ptbShowPass.Location = new System.Drawing.Point(962, 150);
            this.ptbShowPass.Name = "ptbShowPass";
            this.ptbShowPass.Size = new System.Drawing.Size(30, 28);
            this.ptbShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbShowPass.TabIndex = 53;
            this.ptbShowPass.TabStop = false;
            this.ptbShowPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ptbShowPass_MouseDown);
            this.ptbShowPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptbShowPass_MouseUp);
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(116)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1101, 591);
            this.Controls.Add(this.ptbSearch);
            this.Controls.Add(this.ptbShowPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.checkBox_QTri);
            this.Controls.Add(this.checkBox_NV);
            this.Controls.Add(this.lblVaiTro);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.txtSreachTenNV);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtgvSQL);
            this.Controls.Add(this.panel1);
            this.Name = "frmQuanLy";
            this.Text = "frmQuanLy";
            this.Load += new System.EventHandler(this.frmQuanLy_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbShowPass)).EndInit();
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
        private System.Windows.Forms.Button btnQuanLy;
        private System.Windows.Forms.DataGridView dtgvSQL;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtSreachTenNV;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblVaiTro;
        private System.Windows.Forms.CheckBox checkBox_NV;
        private System.Windows.Forms.CheckBox checkBox_QTri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.PictureBox ptbShowPass;
        private System.Windows.Forms.PictureBox ptbSearch;
    }
}