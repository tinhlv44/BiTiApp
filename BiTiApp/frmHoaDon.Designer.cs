namespace BiTiApp
{
    partial class frmHoaDon
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
            this.dtgvSQL = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.btnDangxuat = new System.Windows.Forms.Button();
            this.btnTaikhoang = new System.Windows.Forms.Button();
            this.btnHoadon = new System.Windows.Forms.Button();
            this.btnKhachhang = new System.Windows.Forms.Button();
            this.btnSanpham = new System.Windows.Forms.Button();
            this.btnTaoHoaDon = new System.Windows.Forms.Button();
            this.txtSreach_TheoTenKH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSQL)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvSQL
            // 
            this.dtgvSQL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSQL.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSQL.Location = new System.Drawing.Point(208, 105);
            this.dtgvSQL.Name = "dtgvSQL";
            this.dtgvSQL.Size = new System.Drawing.Size(890, 486);
            this.dtgvSQL.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(71)))), ((int)(((byte)(69)))));
            this.panel1.BackgroundImage = global::BiTiApp.Properties.Resources.backg_black;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.panel1.TabIndex = 20;
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanLy.FlatAppearance.BorderSize = 0;
            this.btnQuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuanLy.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLy.ForeColor = System.Drawing.Color.White;
            this.btnQuanLy.Location = new System.Drawing.Point(0, 186);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Size = new System.Drawing.Size(200, 38);
            this.btnQuanLy.TabIndex = 27;
            this.btnQuanLy.Text = "Quản lý";
            this.btnQuanLy.UseVisualStyleBackColor = false;
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.Transparent;
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
            this.btnDangxuat.BackColor = System.Drawing.Color.Transparent;
            this.btnDangxuat.FlatAppearance.BorderSize = 0;
            this.btnDangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDangxuat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangxuat.ForeColor = System.Drawing.Color.White;
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
            this.btnTaikhoang.BackColor = System.Drawing.Color.Transparent;
            this.btnTaikhoang.FlatAppearance.BorderSize = 0;
            this.btnTaikhoang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTaikhoang.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaikhoang.ForeColor = System.Drawing.Color.White;
            this.btnTaikhoang.Location = new System.Drawing.Point(0, 350);
            this.btnTaikhoang.Name = "btnTaikhoang";
            this.btnTaikhoang.Size = new System.Drawing.Size(200, 38);
            this.btnTaikhoang.TabIndex = 3;
            this.btnTaikhoang.Text = "Tài khoản";
            this.btnTaikhoang.UseVisualStyleBackColor = false;
            this.btnTaikhoang.Click += new System.EventHandler(this.btnTaikhoang_Click);
            // 
            // btnHoadon
            // 
            this.btnHoadon.BackColor = System.Drawing.SystemColors.Control;
            this.btnHoadon.BackgroundImage = global::BiTiApp.Properties.Resources.phoimau3;
            this.btnHoadon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHoadon.FlatAppearance.BorderSize = 0;
            this.btnHoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoadon.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoadon.ForeColor = System.Drawing.Color.White;
            this.btnHoadon.Location = new System.Drawing.Point(0, 297);
            this.btnHoadon.Name = "btnHoadon";
            this.btnHoadon.Size = new System.Drawing.Size(200, 54);
            this.btnHoadon.TabIndex = 2;
            this.btnHoadon.Text = "Hóa đơn";
            this.btnHoadon.UseVisualStyleBackColor = false;
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.BackColor = System.Drawing.Color.Transparent;
            this.btnKhachhang.FlatAppearance.BorderSize = 0;
            this.btnKhachhang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKhachhang.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachhang.ForeColor = System.Drawing.Color.White;
            this.btnKhachhang.Location = new System.Drawing.Point(0, 260);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.Size = new System.Drawing.Size(200, 38);
            this.btnKhachhang.TabIndex = 1;
            this.btnKhachhang.Text = "Khách hàng";
            this.btnKhachhang.UseVisualStyleBackColor = false;
            this.btnKhachhang.Click += new System.EventHandler(this.btnKhachhang_Click);
            // 
            // btnSanpham
            // 
            this.btnSanpham.BackColor = System.Drawing.Color.Transparent;
            this.btnSanpham.FlatAppearance.BorderSize = 0;
            this.btnSanpham.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSanpham.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanpham.ForeColor = System.Drawing.Color.White;
            this.btnSanpham.Location = new System.Drawing.Point(0, 223);
            this.btnSanpham.Name = "btnSanpham";
            this.btnSanpham.Size = new System.Drawing.Size(200, 38);
            this.btnSanpham.TabIndex = 0;
            this.btnSanpham.Text = "Sản phẩm";
            this.btnSanpham.UseVisualStyleBackColor = false;
            this.btnSanpham.Click += new System.EventHandler(this.btnSanpham_Click);
            // 
            // btnTaoHoaDon
            // 
            this.btnTaoHoaDon.BackColor = System.Drawing.SystemColors.Control;
            this.btnTaoHoaDon.FlatAppearance.BorderSize = 0;
            this.btnTaoHoaDon.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoHoaDon.Image = global::BiTiApp.Properties.Resources.radianDoXanh;
            this.btnTaoHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoHoaDon.Location = new System.Drawing.Point(706, 31);
            this.btnTaoHoaDon.Name = "btnTaoHoaDon";
            this.btnTaoHoaDon.Size = new System.Drawing.Size(137, 46);
            this.btnTaoHoaDon.TabIndex = 25;
            this.btnTaoHoaDon.Text = "Tạo hóa đơn";
            this.btnTaoHoaDon.UseVisualStyleBackColor = false;
            this.btnTaoHoaDon.Click += new System.EventHandler(this.btnTaoHoaDon_Click);
            this.btnTaoHoaDon.MouseEnter += new System.EventHandler(this.btnTaoHoaDon_MouseEnter);
            this.btnTaoHoaDon.MouseLeave += new System.EventHandler(this.btnTaoHoaDon_MouseLeave);
            // 
            // txtSreach_TheoTenKH
            // 
            this.txtSreach_TheoTenKH.BackColor = System.Drawing.SystemColors.Control;
            this.txtSreach_TheoTenKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSreach_TheoTenKH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSreach_TheoTenKH.Location = new System.Drawing.Point(429, 38);
            this.txtSreach_TheoTenKH.Multiline = true;
            this.txtSreach_TheoTenKH.Name = "txtSreach_TheoTenKH";
            this.txtSreach_TheoTenKH.Size = new System.Drawing.Size(251, 32);
            this.txtSreach_TheoTenKH.TabIndex = 26;
            this.txtSreach_TheoTenKH.MouseEnter += new System.EventHandler(this.txtSreach_TheoTenKH_MouseEnter);
            this.txtSreach_TheoTenKH.MouseLeave += new System.EventHandler(this.txtSreach_TheoTenKH_MouseLeave);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::BiTiApp.Properties.Resources.phoimau3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1101, 591);
            this.Controls.Add(this.btnTaoHoaDon);
            this.Controls.Add(this.txtSreach_TheoTenKH);
            this.Controls.Add(this.dtgvSQL);
            this.Controls.Add(this.panel1);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSQL)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvSQL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Button btnDangxuat;
        private System.Windows.Forms.Button btnTaikhoang;
        private System.Windows.Forms.Button btnHoadon;
        private System.Windows.Forms.Button btnKhachhang;
        private System.Windows.Forms.Button btnSanpham;
        private System.Windows.Forms.Button btnTaoHoaDon;
        private System.Windows.Forms.TextBox txtSreach_TheoTenKH;
        private System.Windows.Forms.Button btnQuanLy;
    }
}