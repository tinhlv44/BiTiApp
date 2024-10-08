﻿using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections;
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
    public partial class frmHoaDon : Form
    {
        private DataTable dataTable = new DataTable();
        private clsDatabaseConnection con = new clsDatabaseConnection();
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
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
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT * FROM [Order]", con.Open());
            sqlDataAdapter.Fill(dataTable);
            dtgvSQL.DataSource = dataTable;
            dtgvSQL.Columns[0].HeaderText = "Mã hóa đơn";
            dtgvSQL.Columns[1].HeaderText = "Mã khách hàng";
            dtgvSQL.Columns[2].HeaderText = "Ngày đặt hàng";
            dtgvSQL.Columns[3].HeaderText = "Tổng hóa đơn";
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

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            clsFormSwitcher.SwitchForm("frmKhachHang", this);
        }

        private void btnTaikhoang_Click(object sender, EventArgs e)
        {
            clsFormSwitcher.SwitchForm("frmTaiKhoan", this);
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            clsFormSwitcher.SwitchForm("frmLogin", this);
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            if (dtgvSQL.SelectedRows.Count > 0)
            {
                clsFormSwitcher.SwitchForm("frmChiTietHoaDon", this);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để xem chi tiết");
            }
        }
        //đổi màu button
        private void btnTaoHoaDon_MouseEnter(object sender, EventArgs e)
        {
            btnTaoHoaDon.ForeColor = Color.White;
        }

        private void btnTaoHoaDon_MouseLeave(object sender, EventArgs e)
        {
            btnTaoHoaDon.ForeColor = Color.Black;
        }
        private void dtgvSQL_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvSQL.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvSQL.SelectedRows[0];
                clsIsManager.saveOrderID(selectedRow.Cells[0].Value.ToString());
                txtMaKH.Text = selectedRow.Cells[0].Value.ToString();
                txtMaKH.ReadOnly = true;
            }
        }
    }
}
