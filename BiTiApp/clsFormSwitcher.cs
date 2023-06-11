using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiTiApp
{
    public enum FORM_NAME
    {
        frmSanPham,
        frmQuanLy,
        frmKhachHang,
        frmHoaDon,
        frmTaiKhoan,
        frmLogin,
        frmChiTietHoaDon
    }
    public class clsFormSwitcher{
        public static void SwitchForm(string f, Form frm)
        {
            switch (f)
            {
                case "frmSanPham":
                    frmSanPham frmSanPham = new frmSanPham();
                    frmSanPham.WindowState = FormWindowState.Maximized;
                    frmSanPham.Show();
                    frm.Hide();
                    break;
                case "frmQuanLy":
                    frmQuanLy frmQuanLy = new frmQuanLy();
                    frmQuanLy.WindowState = FormWindowState.Maximized;
                    frmQuanLy.Show();
                    frm.Hide();
                    break;
                case "frmKhachHang":
                    frmKhachHang frmKhachHang = new frmKhachHang();
                    frmKhachHang.WindowState = FormWindowState.Maximized;
                    frmKhachHang.Show();
                    frm.Hide();
                    break;
                case "frmHoaDon":
                    frmHoaDon frmHoaDon = new frmHoaDon();
                    frmHoaDon.WindowState = FormWindowState.Maximized;
                    frmHoaDon.Show();
                    frm.Hide();
                    break;
                case "frmTaiKhoan":
                    frmTaiKhoan frmTaiKhoan = new frmTaiKhoan();
                    frmTaiKhoan.WindowState = FormWindowState.Maximized;
                    frmTaiKhoan.Show();
                    frm.Hide();
                    break;
                case "frmLogin":
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        frmLogin frmLogin = new frmLogin();
                        frmLogin.Show();
                        frm.Hide();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                    }
                    break;
                case "frmChiTietHoaDon":
                    frmChiTietHoaDon frmChiTietHoaDon = new frmChiTietHoaDon();
                    frmChiTietHoaDon.WindowState = FormWindowState.Maximized;
                    frmChiTietHoaDon.Show();
                    frm.Hide();
                    break;
            }
        }
    }
}
