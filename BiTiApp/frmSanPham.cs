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
        private clsDatabaseConnection con = new clsDatabaseConnection();
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
            dtgvSQLShow();
        }
        private void dtgvSQLShow()
        {
            dataTable.Clear();
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
                txtMaSP.ReadOnly = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO Product ([ProductID],[ProductName],[Inventory],[ProductPrice],[Note]) VALUES (@c1, @c2, @c3, @c4, @c5)";
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT([ProductID]) FROM Product WHERE [ProductID] = @ProductID", con.Open());
            checkCmd.Parameters.AddWithValue("@ProductID", txtMaSP.Text);
            int Count = (int)checkCmd.ExecuteScalar();

            if (Count == 0)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = insertQuery;
                cmd.Connection = con.Open();
                cmd.Parameters.AddWithValue("@c1", txtMaSP.Text);
                cmd.Parameters.AddWithValue("@c2", txtTenSP.Text);
                cmd.Parameters.AddWithValue("@c3", txtSoLuong.Text);
                cmd.Parameters.AddWithValue("@c4", txtDonGiaBan.Text);
                cmd.Parameters.AddWithValue("@c5", txtGhiChu.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                con.Close();
                dtgvSQLShow();
            }
            else
            {
                MessageBox.Show("Đã tồn tại Sản phảm có mã này!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT([ProductID]) FROM Product WHERE [ProductID] = @ProductID", con.Open());
            checkCmd.Parameters.AddWithValue("@ProductID", txtMaSP.Text);
            int Count = (int)checkCmd.ExecuteScalar();

            if (Count != 0)
            {
                string deleteQuery = "DELETE FROM Product WHERE [ProductID] = @ProductID";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = deleteQuery;
                cmd.Connection = con.Open();
                cmd.Parameters.AddWithValue("@ProductID", txtMaSP.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                con.Close();
                dtgvSQLShow();
            }
            else
            {
                MessageBox.Show("Không tồn tại Mã SP!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT([ProductID]) FROM Product WHERE [ProductID] = @ProductID", con.Open());
            checkCmd.Parameters.AddWithValue("@ProductID", txtMaSP.Text);
            int Count = (int)checkCmd.ExecuteScalar();

            if (Count != 0)
            {
                string updateQuery = "UPDATE Product SET [ProductName]=@c2,[Inventory]=@c3,[ProductPrice]=@c4,[Note]=@c5 WHERE [ProductID] = @ProductID";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = updateQuery;
                cmd.Connection = con.Open();
                cmd.Parameters.AddWithValue("@ProductID", txtMaSP.Text);
                cmd.Parameters.AddWithValue("@c2", txtTenSP.Text);
                cmd.Parameters.AddWithValue("@c3", txtSoLuong.Text);
                cmd.Parameters.AddWithValue("@c4", txtDonGiaBan.Text);
                cmd.Parameters.AddWithValue("@c5", txtGhiChu.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công");
                con.Close();
                dtgvSQLShow();
            }
            else
            {
                MessageBox.Show("Không tồn tại Mã SP!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtSoLuong.Text = "";
            txtDonGiaBan.Text = "";
            txtGhiChu.Text = "";
            txtSreach.Text = "";
            txtMaSP.ReadOnly = false;
            dtgvSQLShow();
        }
    }
}
