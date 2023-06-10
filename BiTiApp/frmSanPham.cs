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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BiTiApp
{
    public partial class frmSanPham : Form
    {
        private DataTable dataTable = new DataTable();
        public frmSanPham()
        {
            InitializeComponent();
        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            if (!clsIsManager.getIsManager())
            {
                ShowLimitedContent();
            }
            clsDatabaseConnection con = new clsDatabaseConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT * FROM Product", con.Open());
            sqlDataAdapter.Fill(dataTable);
            dtgvSQL.DataSource = dataTable;
            dtgvSQL.Columns[0].HeaderText = "Mã sản phẩm";
            dtgvSQL.Columns[1].HeaderText = "Tên sản phẩm";
            dtgvSQL.Columns[2].HeaderText = "Số lượng";
            dtgvSQL.Columns[3].HeaderText = "Giá bán";
            dtgvSQL.Columns[4].HeaderText = "Ghi chú";
            con.Close();
        }
        private void ShowLimitedContent()
        {
            btnQuanLy.Visible = false;
        }
        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            clsFormSwitcher.SwitchForm("frmQuanLy", this);
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            clsFormSwitcher.SwitchForm("frmKhachHang", this);
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

        private void dtgvSQL_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvSQL.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvSQL.SelectedRows[0];
                txtMaSP.Text = selectedRow.Cells[0].Value.ToString();
                txtTenSP.Text = selectedRow.Cells[1].Value.ToString();
                txtSoLuong.Text = selectedRow.Cells[2].Value.ToString();
                txtDonGiaBan.Text = selectedRow.Cells[3].Value.ToString();
                txtGhiChu.Text = selectedRow.Cells[4].Value.ToString();
            }
        }
    }
}
