using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

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
            dtgvSQL.Columns[5].HeaderText = "Đơn giá nhập";
            dtgvSQL.Columns[6].Visible = false;
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
                txtDonGiaNhap.Text = selectedRow.Cells[5].Value.ToString();
                string imageName = selectedRow.Cells[6].Value.ToString().Trim(); 

                if (!string.IsNullOrEmpty(imageName)) // Kiểm tra xem người dùng đã nhập tên tệp ảnh hay chưa.
                {
                    try
                    {
                        // Đọc tệp ảnh từ tài nguyên Properties.Resources.
                        Bitmap image = (Bitmap)Properties.Resources.ResourceManager.GetObject(imageName);

                        // Hiển thị tệp ảnh lên PictureBox.
                        pictureAnh.Image = image;
                    }
                    catch (Exception ex)
                    {
                        // Nếu không tìm thấy tệp ảnh, hiển thị một thông báo lỗi.
                        MessageBox.Show("Không tìm thấy tệp ảnh. Xin vui lòng kiểm tra lại tên ảnh và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                txtMaSP.ReadOnly = true;
                txtMaSP.BackColor = SystemColors.ActiveBorder;
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
            txtDonGiaNhap.Text = "";
            txtMaSP.ReadOnly = false;
            txtMaSP.BackColor = SystemColors.Control;
            pictureAnh.Image = null;
            dtgvSQLShow();
        }
        //Click đổi màu button
        private void btnThem_MouseEnter(object sender, EventArgs e)
        {
            btnThem.BackColor = Color.FromArgb(9, 135, 173);
            btnThem.ForeColor = Color.White;
        }

        private void btnThem_MouseLeave(object sender, EventArgs e)
        {
            btnThem.BackColor = Color.FromArgb(148, 174, 202);
            btnThem.ForeColor = DefaultForeColor;
        }

        private void btnXoa_MouseEnter(object sender, EventArgs e)
        {
            btnXoa.BackColor = Color.FromArgb(9, 135, 173);
            btnXoa.ForeColor = Color.White;
        }

        private void btnXoa_MouseLeave(object sender, EventArgs e)
        {
            btnXoa.BackColor = Color.FromArgb(148, 174, 202);
            btnXoa.ForeColor = DefaultForeColor;
        }

        private void btnSua_MouseEnter(object sender, EventArgs e)
        {
          btnSua.BackColor = Color.FromArgb(9, 135, 173);
          btnSua.ForeColor = Color.White;
        }

        private void btnSua_MouseLeave(object sender, EventArgs e)
        {
            btnSua.BackColor = Color.FromArgb(148, 174, 202);
            btnSua.ForeColor = DefaultForeColor;
            
        }

        private void btnLamMoi_MouseEnter(object sender, EventArgs e)
        {
            btnLamMoi.BackColor = Color.FromArgb(9, 135, 173);
            btnLamMoi.ForeColor = Color.White;
        }

        private void btnLamMoi_MouseLeave(object sender, EventArgs e)
        {
            btnLamMoi.BackColor= Color.FromArgb(148, 174, 202);
            btnLamMoi.ForeColor= DefaultForeColor;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn của tập tin ảnh đã chọn.
                string filePath = fileDialog.FileName;

                // Hiển thị ảnh đã chọn lên PictureBox.
                pictureAnh.Image = new Bitmap(filePath);
            }
        }

        private void ptbSearch_Click(object sender, EventArgs e)
        {
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(ProductName) FROM Product WHERE ProductName LIKE @ProductName", con.Open());
            checkCmd.Parameters.AddWithValue("@ProductName", "%" + txtSreach.Text + "%");
            int Count = (int)checkCmd.ExecuteScalar();

            if (Count != 0)
            {
                dataTable.Clear();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT * FROM Product WHERE ProductName LIKE '%" + txtSreach.Text + "%'", con.Open());
                sqlDataAdapter.Fill(dataTable);
                dtgvSQL.DataSource = dataTable;
                dtgvSQL.Columns[0].HeaderText = "Mã sản phẩm";
                dtgvSQL.Columns[1].HeaderText = "Tên sản phẩm";
                dtgvSQL.Columns[2].HeaderText = "Số lượng";
                dtgvSQL.Columns[3].HeaderText = "Giá bán";
                dtgvSQL.Columns[4].HeaderText = "Ghi chú";
                dtgvSQL.Columns[5].HeaderText = "Đơn giá nhập";
                dtgvSQL.Columns[6].Visible = false;
                con.Close();
            }
            else
            {
                MessageBox.Show("Không tìm thấy!");
            }
        }
    }
}
