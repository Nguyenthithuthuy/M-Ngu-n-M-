using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NhapNguyenLieu : System.Web.UI.Page
{
    String cn = @"Provider = IBMOLEDB.DB2COPY1; Data Source = QCF; Password=251096thuy1;User ID = NK; Location=127.0.0.1";
    DataTable dsNguyenLieu()
    {

        string sql = "SELECT * FROM user1.nguyenlieu   ";
        OleDbDataAdapter da = new OleDbDataAdapter(sql, cn);
        DataTable ds = new DataTable();
        da.Fill(ds);
        return ds;
    }
    void ThemNguyenLieu(string MaNL, string TenNL, string HamLuong, string DonVi, string Tong)
    {

        string sql = "INSERT INTO user1.nguyenlieu  VALUES('" + MaNL + "', '" + TenNL + "',  '" + HamLuong + "', '" + DonVi + "', '" + Tong+ "')";
        OleDbConnection conn = new OleDbConnection(cn);
        OleDbCommand cmd = new OleDbCommand(sql, conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

    }
    void Sua_NguyenLieu(string MaNL, string TenNL, string HamLuong, string DonVi, string Tong)
    {
        string sql = "UPDATE user1.nguyenlieu SET MaNL='" + MaNL + "', TenNL='" + TenNL + "', HamLuong= '" + HamLuong + "', Donvi='" + DonVi + "', Tong='" + Tong + "' WHERE MaNL='" + MaNL + "'";
        OleDbConnection connDB = new OleDbConnection(cn);
        OleDbCommand cmd = new OleDbCommand(sql, connDB);
        connDB.Open();
        cmd.ExecuteNonQuery();
        connDB.Close();
    }
    void Xoa_NguyenLieu(string MaNL)
    {
        OleDbConnection connDB = new OleDbConnection(cn);
        OleDbCommand cmd = new OleDbCommand("DELETE FROM user1.nguyenlieu WHERE MaNL='" + MaNL + "'", connDB);
        connDB.Open();
        cmd.ExecuteNonQuery();
        connDB.Close();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
       DgNhapNguyenLieu.DataSource = dsNguyenLieu();
       DgNhapNguyenLieu.DataBind();
       DgNhapNguyenLieu.HeaderRow.Cells[0].Text = "Mã Nguyên Liệu  ";
       DgNhapNguyenLieu.HeaderRow.Cells[1].Text = "Tên Nguyên Liệu   ";
        DgNhapNguyenLieu.HeaderRow.Cells[2].Text =  "Hàm Lượng  ";
        DgNhapNguyenLieu.HeaderRow.Cells[3].Text = "Đơn Vị    ";
        DgNhapNguyenLieu.HeaderRow.Cells[4].Text = "Tổng   ";
    }




    protected void bntThem_Click(object sender, EventArgs e)
    {
        {
            if ((txtMaNguyenLieu.Text != "") && (txtTenNguyenLieu.Text != "") && (txtDonVi.Text != "") && (txtHamLuong.Text != "") && (txtTong.Text != ""))
            {
                try
                {

                    ThemNguyenLieu(txtMaNguyenLieu.Text, txtTenNguyenLieu.Text, txtHamLuong.Text, txtDonVi.Text, txtTong.Text);

                    DgNhapNguyenLieu.DataSource = dsNguyenLieu();
                    DgNhapNguyenLieu.DataBind();
                    DgNhapNguyenLieu.HeaderRow.Cells[0].Text = "Mã Nguyên Liệu  ";
                    DgNhapNguyenLieu.HeaderRow.Cells[1].Text = "Tên Nguyên Liệu   ";
                    DgNhapNguyenLieu.HeaderRow.Cells[2].Text = "Hàm Lượng  ";
                    DgNhapNguyenLieu.HeaderRow.Cells[3].Text = "Đơn Vị    ";
                    DgNhapNguyenLieu.HeaderRow.Cells[4].Text = "Tổng   ";
                    txtMaNguyenLieu.Text = "";
                    txtTenNguyenLieu.Text = "";
                    txtHamLuong.Text = "";
                    txtDonVi.Text = "";
                    txtTong.Text = "";

                    lblTB.Text = "Đã thêm vào thành công.";
                }
                catch
                {
                    lblTB.Text = "Không thể thêm thông tin này. Vui lòng kiểm tra lại.";
                }
            }
            else
            {
                lblTB.Text = "Không thể thêm thông tin này. Vui lòng kiểm tra lại.";
            }


        }
    }

    protected void bntSua_Click(object sender, EventArgs e)
    {
        
            if ((txtMaNguyenLieu.Text != "") && (txtTenNguyenLieu.Text != "") && (txtDonVi.Text != "") && (txtHamLuong.Text != "") && (txtTong.Text != ""))
            {
                try
                {

                    Sua_NguyenLieu(txtMaNguyenLieu.Text, txtTenNguyenLieu.Text, txtHamLuong.Text, txtDonVi.Text, txtTong.Text);

                    DgNhapNguyenLieu.DataSource = dsNguyenLieu();
                    DgNhapNguyenLieu.DataBind();
                    DgNhapNguyenLieu.HeaderRow.Cells[0].Text = "Mã Nguyên Liệu  ";
                    DgNhapNguyenLieu.HeaderRow.Cells[1].Text = "Tên Nguyên Liệu   ";
                    DgNhapNguyenLieu.HeaderRow.Cells[2].Text = "Hàm Lượng  ";
                    DgNhapNguyenLieu.HeaderRow.Cells[3].Text = "Đơn Vị    ";
                    DgNhapNguyenLieu.HeaderRow.Cells[4].Text = "Tổng   ";
                    txtMaNguyenLieu.Text = "";
                    txtTenNguyenLieu.Text = "";
                    txtHamLuong.Text = "";
                    txtDonVi.Text = "";
                    txtTong.Text = "";

                    lblTB.Text = "Đã Sửa vào thành công.";
                }
                catch
                {
                    lblTB.Text = "Không thể sửa thông tin này. Vui lòng kiểm tra lại.";
                }
            }
            else
            {
                lblTB.Text = "Không thể sửa thông tin này. Vui lòng kiểm tra lại.";
            }


        

    }

    protected void bntXoa_Click(object sender, EventArgs e)
    {

        if (txtMaNguyenLieu.Text == "")
        {

            lblTB.Text = "Không thể xóa thông tin này. Vui lòng kiểm tra lại.";
        }
        else
        {
            Xoa_NguyenLieu(txtMaNguyenLieu.Text);
            DgNhapNguyenLieu.DataSource = dsNguyenLieu();
            DgNhapNguyenLieu.DataBind();
            DgNhapNguyenLieu.HeaderRow.Cells[0].Text = "Mã Nguyên Liệu  ";
            DgNhapNguyenLieu.HeaderRow.Cells[1].Text = "Tên Nguyên Liệu   ";
            DgNhapNguyenLieu.HeaderRow.Cells[2].Text = "Hàm Lượng  ";
            DgNhapNguyenLieu.HeaderRow.Cells[3].Text = "Đơn Vị    ";
            DgNhapNguyenLieu.HeaderRow.Cells[4].Text = "Tổng   ";
            txtMaNguyenLieu.Text = "";
            txtTenNguyenLieu.Text = "";
            txtHamLuong.Text = "";
            txtDonVi.Text = "";
            txtTong.Text = "";
            lblTB.Text = "Xóa thành công !";
           
        }
    }
}