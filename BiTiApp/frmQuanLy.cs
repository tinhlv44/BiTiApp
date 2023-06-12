using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Image = System.Drawing.Image;

namespace BiTiApp
{
    public partial class frmQuanLy : Form
    {
        private DataTable dataTable = new DataTable();
        private clsDatabaseConnection con = new clsDatabaseConnection();
        public frmQuanLy()
        {
            InitializeComponent();
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

        private void btnTaikhoang_Click(object sender, EventArgs e)
        {
            clsFormSwitcher.SwitchForm("frmTaiKhoan", this);
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            clsFormSwitcher.SwitchForm("frmLogin", this);
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            dtgvSQLShow();
        }
        private void dtgvSQLShow()
        {
            dataTable.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT UserID, Name, [User/Email], Password, Addresss, Phone, IsManager FROM Userr", con.Open());
            sqlDataAdapter.Fill(dataTable);
            dtgvSQL.DataSource = dataTable;
            dtgvSQL.Columns[0].HeaderText = "Mã nhân viên";
            dtgvSQL.Columns[2].HeaderText = "Tài khoản";
            dtgvSQL.Columns[3].Visible = false;
            dtgvSQL.Columns[4].HeaderText = "Địa chỉ";
            dtgvSQL.Columns[5].HeaderText = "Số điện thoại";
            dtgvSQL.Columns[1].HeaderText = "Tên nhân viên";
            con.Close();
        }
        private void dtgvSQL_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvSQL.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvSQL.SelectedRows[0];
                txtHoTen.Text = selectedRow.Cells[1].Value.ToString();
                txtEmail.Text = selectedRow.Cells[2].Value.ToString();
                txtDiaChi.Text = selectedRow.Cells[4].Value.ToString();
                txtSDT.Text = selectedRow.Cells[5].Value.ToString();
                //txtMatKhau.Text = selectedRow.Cells[3].Value.ToString();
                txtMatKhau.Text = "********";
                if (selectedRow.Cells[6].Value.Equals(true))
                {
                    checkBox_QTri.Checked = true;
                    checkBox_NV.Checked = false;
                }
                else
                {
                    checkBox_NV.Checked = true;
                    checkBox_QTri.Checked = false;
                }
                txtEmail.ReadOnly = true;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtMatKhau.Text = "";
            checkBox_NV.Checked = false;
            checkBox_QTri.Checked = false;
            txtEmail.ReadOnly = false;
            dtgvSQLShow();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //string insertQuery = "INSERT INTO userr ([User/Email],[Password],[Addresss],[Phone],[IsManager],[Name]) VALUES ('" + txtEmail.Text + "', '" + txtMatKhau.Text + "', n'" + txtDiaChi.Text + "', '" + txtSDT.Text + "', " + (checkBox_QTri.Checked == true ? 1 : 0) + ", n'" + txtHoTen.Text + "')";
            string insertQuery = "INSERT INTO userr ([User/Email],[Password],[Addresss],[Phone],[IsManager],[Name]) VALUES (@c1, @c2, @c3, @c4, @c5, @c6)";
            SqlCommand checkEmailCmd = new SqlCommand("SELECT COUNT([User/Email]) FROM userr WHERE [User/Email] = @email", con.Open());
            checkEmailCmd.Parameters.AddWithValue("@email", txtEmail.Text);
            int emailCount = (int)checkEmailCmd.ExecuteScalar();

            if (emailCount == 0)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = insertQuery;
                cmd.Connection = con.Open();
                cmd.Parameters.AddWithValue("@c1", txtEmail.Text);
                cmd.Parameters.AddWithValue("@c2", txtMatKhau.Text);
                cmd.Parameters.AddWithValue("@c3", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@c4", txtSDT.Text);
                cmd.Parameters.AddWithValue("@c5", (checkBox_QTri.Checked == true?1:0));
                cmd.Parameters.AddWithValue("@c6", txtHoTen.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                con.Close();
            }
            else
            {
                MessageBox.Show("Đã tồn tại Email!");
            }
            dtgvSQLShow();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlCommand checkEmailCmd = new SqlCommand("SELECT COUNT([User/Email]) FROM userr WHERE [User/Email] = @email", con.Open());
            checkEmailCmd.Parameters.AddWithValue("@email", txtEmail.Text);
            int emailCount = (int)checkEmailCmd.ExecuteScalar();

            if (emailCount != 0)
            {
                string deleteQuery = "DELETE FROM Userr WHERE [User/Email] = @email";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = deleteQuery;
                cmd.Connection = con.Open();
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                con.Close();
                dtgvSQLShow();
            }
            else
            {
                MessageBox.Show("Không tồn tại email!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlCommand checkEmailCmd = new SqlCommand("SELECT COUNT([User/Email]) FROM userr WHERE [User/Email] = @email", con.Open());
            checkEmailCmd.Parameters.AddWithValue("@email", txtEmail.Text);
            int emailCount = (int)checkEmailCmd.ExecuteScalar();

            if (emailCount != 0)
            {
                string updateQuery = "UPDATE Userr SET [Password]=@c2,[Addresss]=@c3,[Phone]=@c4,[IsManager]=@c5,[Name]=@c6 WHERE [User/Email] = @c1";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = updateQuery;
                cmd.Connection = con.Open();
                cmd.Parameters.AddWithValue("@c1", txtEmail.Text);
                cmd.Parameters.AddWithValue("@c2", txtMatKhau.Text);
                cmd.Parameters.AddWithValue("@c3", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@c4", txtSDT.Text);
                cmd.Parameters.AddWithValue("@c5", (checkBox_QTri.Checked == true ? 1 : 0));
                cmd.Parameters.AddWithValue("@c6", txtHoTen.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công");
                con.Close();
                dtgvSQLShow();
            }
            else
            {
                MessageBox.Show("Không tồn tại email!");
            }
        }


        private void ptbShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            if (dtgvSQL.SelectedRows.Count > 0)
            {
                ptbShowPass.Image = Properties.Resources.showpass;
                ptbShowPass.BackColor = SystemColors.Window;
                txtMatKhau.Text = dtgvSQL.SelectedRows[0].Cells[3].Value.ToString();
            }

        }

        private void ptbShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            if (dtgvSQL.SelectedRows.Count > 0)
            {                
                ptbShowPass.Image = Properties.Resources.hidepass;
                ptbShowPass.BackColor = SystemColors.Control;
                txtMatKhau.Text = "********";
            }

        }

        private void ptbSearch_MouseDown(object sender, MouseEventArgs e)
        {
            //ptbSearch.BackColor = Color.FromArgb(69, 69, 69);
            ptbSearch.BackColor = SystemColors.Window;
        }

        private void ptbSearch_MouseUp(object sender, MouseEventArgs e)
        {
            ptbSearch.BackColor = SystemColors.Control;
        }

        private void ptbSearch_Click(object sender, EventArgs e)
        {
            SqlCommand checkEmailCmd = new SqlCommand("SELECT COUNT(Name) FROM userr WHERE Name LIKE @name", con.Open());
            checkEmailCmd.Parameters.AddWithValue("@name", "%" + txtSreachTenNV.Text + "%");
            int emailCount = (int)checkEmailCmd.ExecuteScalar();

            if (emailCount != 0)
            {
                dataTable.Clear();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT UserID, Name, [User/Email], Password, Addresss, Phone, IsManager FROM userr WHERE Name LIKE '%" + txtSreachTenNV.Text + "%'", con.Open());
                sqlDataAdapter.Fill(dataTable);
                dtgvSQL.DataSource = dataTable;
                dtgvSQL.Columns[0].HeaderText = "Mã nhân viên";
                dtgvSQL.Columns[2].HeaderText = "Tài khoản";
                dtgvSQL.Columns[3].Visible = false;
                dtgvSQL.Columns[4].HeaderText = "Địa chỉ";
                dtgvSQL.Columns[5].HeaderText = "Số điện thoại";
                dtgvSQL.Columns[1].HeaderText = "Tên nhân viên";
                con.Close();
            }
            else
            {
                MessageBox.Show("Không tìm thấy!");
            }
        }
        //Đổi màu lia button
        private void btnThem_MouseEnter(object sender, EventArgs e)
        {
            btnThem.BackColor = Color.FromArgb(153, 5, 176);
            btnThem.ForeColor = Color.White;
        }

        private void btnThem_MouseLeave(object sender, EventArgs e)
        {
            btnThem.BackColor = SystemColors.Control;
            btnThem.ForeColor= SystemColors.ControlText;
        }

        private void btnXoa_MouseEnter(object sender, EventArgs e)
        {
            btnXoa.BackColor = Color.FromArgb(153, 5, 176);
            btnXoa.ForeColor = Color.White;
        }

        private void btnXoa_MouseLeave(object sender, EventArgs e)
        {
            btnXoa.BackColor = SystemColors.Control;
            btnXoa.ForeColor= SystemColors.ControlText;
        }

        private void btnSua_MouseEnter(object sender, EventArgs e)
        {
            btnSua.BackColor = Color.FromArgb(153, 5, 176);
            btnSua.ForeColor = Color.White;
        }

        private void btnSua_MouseLeave(object sender, EventArgs e)
        {
            btnSua.BackColor = SystemColors.Control;
            btnSua.ForeColor = SystemColors.ControlText;
        }

        private void btnLamMoi_MouseEnter(object sender, EventArgs e)
        {
            btnLamMoi.BackColor = Color.FromArgb(153, 5, 176);
            btnLamMoi.ForeColor = Color.White;
        }

        private void btnLamMoi_MouseLeave(object sender, EventArgs e)
        {
            btnLamMoi.BackColor = SystemColors.Control;
            btnLamMoi.ForeColor = SystemColors.ControlText;
        }

        private void txtSreachTenNV_MouseEnter(object sender, EventArgs e)
        {
            txtSreachTenNV.BackColor = Color.FromArgb(163, 175, 204);
        }

        private void txtSreachTenNV_MouseLeave(object sender, EventArgs e)
        {
            txtSreachTenNV.BackColor = SystemColors.Control;
        }
    }
}
