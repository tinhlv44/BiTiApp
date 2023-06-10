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
        frmLogin
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
                    break;
                case "frmQuanLy":
                    frmQuanLy frmQuanLy = new frmQuanLy();
                    frmQuanLy.WindowState = FormWindowState.Maximized;
                    frmQuanLy.Show();
                    break;
                case "frmKhachHang":
                    frmKhachHang frmKhachHang = new frmKhachHang();
                    frmKhachHang.WindowState = FormWindowState.Maximized;
                    frmKhachHang.Show();
                    break;
                case "frmHoaDon":
                    frmHoaDon frmHoaDon = new frmHoaDon();
                    frmHoaDon.WindowState = FormWindowState.Maximized;
                    frmHoaDon.Show();
                    break;
                case "frmTaiKhoan":
                    frmTaiKhoan frmTaiKhoan = new frmTaiKhoan();
                    frmTaiKhoan.WindowState = FormWindowState.Maximized;
                    frmTaiKhoan.Show();
                    break;
                case "frmLogin":
                    frmLogin frmLogin = new frmLogin();
                    frmLogin.Show();
                    break;
            }
            frm.Hide();
        }
    }
}
