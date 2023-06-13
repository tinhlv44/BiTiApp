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
using static System.Net.Mime.MediaTypeNames;

namespace BiTiApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            init();
            resgisterEvent();
        }

        void init()
        {
            pnRegister.Dock = DockStyle.Right;
        }

        #region Event

        void resgisterEvent()
        {
            lblClose.Click += LblClose_Click;
            lblRegClose.Click += LblClose_Click;
            btnLoginChange.Click += BtnLoginChange_Click;
            btnRegChange.Click += BtnRegChange_Click;
        }

        private void BtnRegChange_Click(object sender, EventArgs e)
        {
            pnLogin.Visible = false;
            pnRegister.Visible = true;
            reset();
        }

        private void BtnLoginChange_Click(object sender, EventArgs e)
        {
            pnLogin.Visible = true;
            pnRegister.Visible = false;
            reset();
        }
        private void reset()
        {
            txtEmail_Dangky.Text = "Email";
            txtEmail_DangNhap.Text = "Email";
            txtMatKhau_Dangky.Text = "Mật khẩu";
            txtNhapLai_MatKhau_Dky.Text = "Nhập lại mật khẩu";
            txtMatKhau_DangNhap.Text = "Mật khẩu";
            txtMatKhau_Dangky.PasswordChar = '\0';
            txtMatKhau_DangNhap.PasswordChar = '\0';
            txtNhapLai_MatKhau_Dky.PasswordChar = '\0';

        }
        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        private void btnDangNhapTaiKhoan_Click(object sender, EventArgs e)
        {
            clsDatabaseConnection con = new clsDatabaseConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT * FROM Userr", con.Open());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                string user = (string)row["User/Email"];
                string password = (string)row["Password"];
                if (user == txtEmail_DangNhap.Text && password == txtMatKhau_DangNhap.Text)
                {
                    if ((bool)row["IsManager"] == true)
                    {
                        clsIsManager.setIsManager(true);
                    }
                    else
                    {
                        clsIsManager.setIsManager(false);
                    }
                    clsIsManager.saveAcc(row);
                    clsFormSwitcher.SwitchForm("frmSanPham", this);
                    return;
                }
            }
            MessageBox.Show("Sai tài khoản hoặc mật khẩu");
        }

        private void txtEmail_DangNhap_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text== "Email")
            {
                txt.Text = "";
            }
        }

        private void txtMatKhau_DangNhap_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == "Mật khẩu")
            {
                txt.Text = "";
            }
            txt.PasswordChar = '*';
        }

        private void txtNhapLai_MatKhau_Dky_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == "Nhập lại mật khẩu")
            {
                txt.Text = "";
            }
            txt.PasswordChar = '*';
        }

        private void checkBox_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPass.Checked == true)
            {
                txtMatKhau_DangNhap.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau_DangNhap.PasswordChar = '*';
            }
            if (cbxshowpass2.Checked == true)
            {
                txtMatKhau_Dangky.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau_Dangky.PasswordChar = '*';
            }
            if (cbxshowpass2.Checked == true)
            {
                txtNhapLai_MatKhau_Dky.PasswordChar = '\0';
            }
            else
            {
                txtNhapLai_MatKhau_Dky.PasswordChar = '*';
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}   
