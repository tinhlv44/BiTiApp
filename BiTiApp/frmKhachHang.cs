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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
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

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            clsFormSwitcher.SwitchForm("frmHoaDon", this);
        }

        private void btnTaikhoang_Click(object sender, EventArgs e)
        {
            clsFormSwitcher.SwitchForm("frmTaiKhoan", this);
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            clsFormSwitcher.SwitchForm("frmLogin", this);
        }
    }
}
