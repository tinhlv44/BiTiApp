﻿using System;
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
    public partial class frmChiTietHoaDon : Form
    {
        private DataTable dtgv = new DataTable();
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            string orderID = clsIsManager.getOrderID();

            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            clsDatabaseConnection con = new clsDatabaseConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT * FROM [Order], OrderDetail WHERE [Order].OrderID='"+ orderID + "' AND OrderDetail.OrderID = '"+ orderID + "'", con.Open());
            sqlDataAdapter.Fill(dt);
            con.Close();
            DataRow dr = dt.Rows[0];
            txtMaKHvaTenKH.Text = dr["CustomerID"].ToString();
            txtDonGia.Text = dr["UnitPrice"].ToString();
            txtSoLuong.Text = dr["Quantity"].ToString();
            txtTongThanhTien.Text = dr["TotalAmount"].ToString();
            int soLuong = Convert.ToInt32(dr["Quantity"]);
            int donGia = Convert.ToInt32(dr["UnitPrice"]);
            txtThanhTien.Text = Convert.ToString(soLuong * donGia);
            txtThoiGian.Text = dr["OrderDate"].ToString();

            sqlDataAdapter = new SqlDataAdapter(@"SELECT * FROM Product WHERE ProductID='" + dr["ProductID"].ToString() + "'", con.Open());
            sqlDataAdapter.Fill(dt2);
            DataRow dr2 = dt2.Rows[0];
            txtTenSPvaTonKho.Text = dr2["ProductName"].ToString();
            con.Close();

            txtMaKHvaTenKH.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
            txtTenSPvaTonKho.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            txtThoiGian.ReadOnly = true;

            SqlDataAdapter sql = new SqlDataAdapter(@"SELECT * FROM OrderDetail WHERE OrderID='" + orderID + "'", con.Open());
            sql.Fill(dtgv);
            dtgvSQL.DataSource = dtgv;
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            clsFormSwitcher.SwitchForm("frmHoaDon", this);
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (txtMaNVvaTenNV.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên để in hóa đơn");
            }
        }

        private void dtgvSQL_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvSQL.SelectedRows.Count > 0)
            {
                clsDatabaseConnection con = new clsDatabaseConnection();
                DataGridViewRow selectedRow = dtgvSQL.SelectedRows[0];

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(@"SELECT * FROM Product WHERE ProductID='" + selectedRow.Cells[1].Value.ToString() + "'", con.Open());
                sqlDataAdapter.Fill(dt);
                DataRow dr = dt.Rows[0];
                txtTenSPvaTonKho.Text = dr["ProductName"].ToString();
                txtDonGia.Text = dr["ProductPrice"].ToString();
                txtSoLuong.Text = selectedRow.Cells[2].Value.ToString();
                int soLuong = Convert.ToInt32(dr["ProductPrice"]);
                int donGia = Convert.ToInt32(selectedRow.Cells[2].Value);
                txtThanhTien.Text = Convert.ToString(soLuong * donGia);
            }
        }
    }
}
