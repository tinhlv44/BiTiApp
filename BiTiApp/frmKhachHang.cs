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
    public partial class frmKhachHang : Form
    {
        private DataTable dataTable = new DataTable();
        private clsDatabaseConnection con = new clsDatabaseConnection();
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
            dtgvSQLShow();
        }
        private void dtgvSQLShow()
        {
            dataTable.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT * FROM Customer", con.Open());
            sqlDataAdapter.Fill(dataTable);
            dtgvSQL.DataSource = dataTable;
            dtgvSQL.Columns[0].HeaderText = "Mã khách hàng";
            dtgvSQL.Columns[1].HeaderText = "Tên khách hàng";
            dtgvSQL.Columns[2].HeaderText = "Địa chỉ";
            dtgvSQL.Columns[3].HeaderText = "Số điện thoại";
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO Customer ([CustomerID],[CustomerName],[CustomerAddress],[CustomerPhone]) VALUES (@c1, @c2, @c3, @c4)";
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT([CustomerID]) FROM Customer WHERE [CustomerID] = @CustomerID", con.Open());
            checkCmd.Parameters.AddWithValue("@CustomerID", txtMaKH.Text);
            int Count = (int)checkCmd.ExecuteScalar();

            if (Count == 0)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = insertQuery;
                cmd.Connection = con.Open();
                cmd.Parameters.AddWithValue("@c1", txtMaKH.Text);
                cmd.Parameters.AddWithValue("@c2", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@c3", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@c4", txtSDT.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                con.Close();
                dtgvSQLShow();
            }
            else
            {
                MessageBox.Show("Đã tồn tại Khách hàng có mã này!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT([CustomerID]) FROM Customer WHERE [CustomerID] = @CustomerID", con.Open());
            checkCmd.Parameters.AddWithValue("@CustomerID", txtMaKH.Text);
            int Count = (int)checkCmd.ExecuteScalar();

            if (Count != 0)
            {
                string deleteQuery = "DELETE FROM Customer WHERE [CustomerID] = @CustomerID";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = deleteQuery;
                cmd.Connection = con.Open();
                cmd.Parameters.AddWithValue("@CustomerID", txtMaKH.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                con.Close();
                dtgvSQLShow();
            }
            else
            {
                MessageBox.Show("Không tồn tại Mã Khách hàng này!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT([CustomerID]) FROM Customer WHERE [CustomerID] = @CustomerID", con.Open());
            checkCmd.Parameters.AddWithValue("@CustomerID", txtMaKH.Text);
            int Count = (int)checkCmd.ExecuteScalar();

            if (Count != 0)
            {
                string updateQuery = "UPDATE Customer SET [CustomerName]=@c1,[CustomerAddress]=@c2,[CustomerPhone]=@c3 WHERE [CustomerID] = @CustomerID";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = updateQuery;
                cmd.Connection = con.Open();
                cmd.Parameters.AddWithValue("@CustomerID", txtMaKH.Text);
                cmd.Parameters.AddWithValue("@c1", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@c2", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@c3", txtSDT.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công");
                con.Close();
                dtgvSQLShow();
            }
            else
            {
                MessageBox.Show("Không tồn tại Mã Khách hàng này!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtSreachTenKH.Text = "";
            txtMaKH.ReadOnly = false;
            dtgvSQLShow();
        }

        private void dtgvSQL_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvSQL.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvSQL.SelectedRows[0];
                txtMaKH.Text = selectedRow.Cells[0].Value.ToString();
                txtHoTen.Text = selectedRow.Cells[1].Value.ToString();
                txtDiaChi.Text = selectedRow.Cells[2].Value.ToString();
                txtSDT.Text = selectedRow.Cells[3].Value.ToString();
                txtMaKH.ReadOnly = true;
            }
        }

        private void ptbSearch_Click(object sender, EventArgs e)
        {
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(CustomerName) FROM Customer WHERE CustomerName LIKE @CustomerName", con.Open());
            checkCmd.Parameters.AddWithValue("@CustomerName", "%" + txtSreachTenKH.Text + "%");
            int Count = (int)checkCmd.ExecuteScalar();

            if (Count != 0)
            {
                dataTable.Clear();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Customer WHERE CustomerName LIKE '%" + txtSreachTenKH.Text + "%'", con.Open());
                sqlDataAdapter.Fill(dataTable);
                dtgvSQL.DataSource = dataTable;
                dtgvSQL.Columns[0].HeaderText = "Mã khách hàng";
                dtgvSQL.Columns[1].HeaderText = "Tên khách hàng";
                dtgvSQL.Columns[2].HeaderText = "Địa chỉ";
                dtgvSQL.Columns[3].HeaderText = "Số điện thoại";
                con.Close();
            }
            else
            {
                MessageBox.Show("Không tìm thấy!");
            }

        }

        private void ptbSearch_MouseDown(object sender, MouseEventArgs e)
        {
            ptbSearch.BackColor = SystemColors.Window;
        }

        private void ptbSearch_MouseUp(object sender, MouseEventArgs e)
        {
            ptbSearch.BackColor = SystemColors.Control;
        }
        //Đổi màu button
        private void btnThem_MouseEnter(object sender, EventArgs e)
        {
            btnThem.ForeColor = Color.White;
        }

        private void btnThem_MouseLeave(object sender, EventArgs e)
        {
            btnThem.ForeColor = Color.Black;
        }

        private void btnXoa_MouseEnter(object sender, EventArgs e)
        {
            btnXoa.ForeColor = Color.White;
        }

        private void btnXoa_MouseLeave(object sender, EventArgs e)
        {
            btnXoa.ForeColor= Color.Black;
        }

        private void btnSua_MouseEnter(object sender, EventArgs e)
        {
            btnSua.ForeColor = Color.White;
        }

        private void btnSua_MouseLeave(object sender, EventArgs e)
        {
            btnSua.ForeColor= Color.Black;
        }

        private void btnLamMoi_MouseEnter(object sender, EventArgs e)
        {
            btnLamMoi.ForeColor = Color.White;
        }

        private void btnLamMoi_MouseLeave(object sender, EventArgs e)
        {
            btnLamMoi.ForeColor= Color.Black;
        }

        private void txtSreachTenKH_MouseEnter(object sender, EventArgs e)
        {
            txtSreachTenKH.BackColor = Color.FromArgb(163, 175, 204);
        }

        private void txtSreachTenKH_MouseLeave(object sender, EventArgs e)
        {
            txtSreachTenKH.BackColor = Color.FromArgb(220, 116, 227);
        }
    }
}
