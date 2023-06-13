using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            DataRow acc = clsIsManager.getAcc();
            txtEmail.Text = (string)acc["User/Email"];
            txtHoTen.Text = (string)acc["Name"];
            try
            {
                txtDiaChi.Text = (string)acc["Addresss"];

            }
            catch (Exception ex)
            {
                txtDiaChi.Text = "";
            }
            txtSDT.Text = (string)acc["Phone"];
            txtEmail.ReadOnly = true;
            txtHoTen.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtSDT.ReadOnly = true;
            btnSua.Visible = false;
            btnLamMoi.Visible = false;
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
            btnSua.ForeColor = Color.White;
        }

        private void btnSua_MouseLeave(object sender, EventArgs e)
        {
            btnSua.ForeColor = Color.Black;
        }

        private void btnLamMoi_MouseEnter(object sender, EventArgs e)
        {
            btnLamMoi.ForeColor = Color.White;
        }

        private void btnLamMoi_MouseLeave(object sender, EventArgs e)
        {
            btnLamMoi.ForeColor = Color.Black;
        }

        private void btnDoiMatKhau_MouseEnter(object sender, EventArgs e)
        {
            btnDoiMatKhau.ForeColor = Color.White;
        }

        private void btnDoiMatKhau_MouseLeave(object sender, EventArgs e)
        {
            btnDoiMatKhau.ForeColor = Color.Black;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            DataRow acc = clsIsManager.getAcc();
            if (txtMatKhauCu.Text != (string)acc["Password"])
            {
                MessageBox.Show("Mật khẩu sai!");
            }
            else if (txtMatKhauMoi.Text != txtNhapLaiMatKhau.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu không trùng với mật khẩu mới!");
            }
            else
            {
                clsDatabaseConnection con = new clsDatabaseConnection();
                SqlCommand command = new SqlCommand("UPDATE Userr SET Password = '" + txtMatKhauMoi.Text + "' WHERE UserID = " + acc["UserID"]+"", con.Open());
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Cập nhật mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
