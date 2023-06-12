using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiTiApp
{
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            if (!clsIsManager.getIsManager())
            {
                ShowLimitedContent();
            }
        }
        private void ShowLimitedContent()
        {
            btnQuanLy.Visible = false;
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            clsFormSwitcher.SwitchForm("frmQuanLy", this);
        }

        private void btnSanpham_Click(object sender, EventArgs e)
        {
            clsFormSwitcher.SwitchForm("frmSanPham", this);
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            clsFormSwitcher.SwitchForm("frmKhachHang", this);
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            clsFormSwitcher.SwitchForm("frmHoaDon", this);
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            clsFormSwitcher.SwitchForm("frmLogin", this);
        }

        //Đổi màu button khi lia chuột
        private void btnSua_MouseEnter(object sender, EventArgs e)
        {
            btnSua.BackColor = Color.FromArgb(100, 200, 50);
        }

        private void btnSua_MouseLeave(object sender, EventArgs e)
        {
            btnSua.BackColor = SystemColors.Control;
        }

        private void btnLamMoi_MouseEnter(object sender, EventArgs e)
        {
            btnLamMoi.BackColor = Color.FromArgb(100, 200, 50);
        }

        private void btnLamMoi_MouseLeave(object sender, EventArgs e)
        {
            btnLamMoi.BackColor = SystemColors.Control;
        }

        private void btnDoiMatKhau_MouseEnter(object sender, EventArgs e)
        {
            btnDoiMatKhau.BackColor = Color.FromArgb(100, 200, 50);
        }

        private void btnDoiMatKhau_MouseLeave(object sender, EventArgs e)
        {
            btnDoiMatKhau.BackColor = SystemColors.Control;
        }
    }
}
