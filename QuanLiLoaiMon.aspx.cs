using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class QuanLiLoaiMon : System.Web.UI.Page
{

    String cn = @"Provider = IBMOLEDB.DB2COPY1; Data Source = QCF; Password=251096thuy1;User ID = NK; Location=127.0.0.1";
    DataTable dsLoaiMon()
    {

        string sql = "SELECT * FROM user1.LoaiMon  ";
        OleDbDataAdapter da = new OleDbDataAdapter(sql, cn);
        DataTable ds = new DataTable();
        da.Fill(ds);
        return ds;
    }
    void ThemLoaiMon(string MaLoai, string TenLoai)
    {

        string sql = "INSERT INTO user1.LoaiMon VALUES('" + MaLoai + "', '" + TenLoai + "' )";
        OleDbConnection conn = new OleDbConnection(cn);
        OleDbCommand cmd = new OleDbCommand(sql, conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

    }
    void Sua_LoaiMon(string MaLoai, string TenLoai)
    {
        string sql = "UPDATE user1.LoaiMon SET MaLoai='" + MaLoai + "',TenLoai='" + TenLoai + "' WHERE MaLoai='" + MaLoai + "'";
        OleDbConnection connDB = new OleDbConnection(cn);
        OleDbCommand cmd = new OleDbCommand(sql, connDB);
        connDB.Open();
        cmd.ExecuteNonQuery();
        connDB.Close();
    }
    void Xoa_LoaiMon(string MaLoai)
    {
        OleDbConnection connDB = new OleDbConnection(cn);
        OleDbCommand cmd = new OleDbCommand("DELETE FROM user1.LoaiMon WHERE MaLoai='" + MaLoai + "'", connDB);
        connDB.Open();
        cmd.ExecuteNonQuery();
        connDB.Close();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        DgLoaiMon.DataSource = dsLoaiMon();
        DgLoaiMon.DataBind();
        DgLoaiMon.HeaderRow.Cells[0].Text = "Mã Loại ";
        DgLoaiMon.HeaderRow.Cells[1].Text = "Tên Loại  ";

    }


    protected void btnThem_Click(object sender, EventArgs e)
    {
      
        
        if ((txtMaLoai.Text != "") && (txtTenLoai.Text != ""))
        {
            try
            {

                ThemLoaiMon(txtMaLoai.Text, txtTenLoai.Text);

                DgLoaiMon.DataSource = dsLoaiMon();
                DgLoaiMon.DataBind();
                DgLoaiMon.HeaderRow.Cells[0].Text = "Mã Loại ";
                DgLoaiMon.HeaderRow.Cells[1].Text = "Tên Loại  ";
                txtMaLoai.Text = "";
                txtTenLoai.Text = "";
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

    protected void btnSua_Click(object sender, EventArgs e)
    {
        if ((txtMaLoai.Text != "") && (txtTenLoai.Text != ""))
        {
            try
            {

                Sua_LoaiMon(txtMaLoai.Text, txtTenLoai.Text);
                lblTB.Text = "Đã sửa vào thành công.";
                DgLoaiMon.DataSource = dsLoaiMon();
                DgLoaiMon.DataBind();
                DgLoaiMon.HeaderRow.Cells[0].Text = "Mã Loại ";
                DgLoaiMon.HeaderRow.Cells[1].Text = "Tên Loại  ";
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

    protected void btnXoa_Click(object sender, EventArgs e)
    {
        if (txtMaLoai.Text == "") 
        {
          
            lblTB.Text = "Không thể xóa thông tin này. Vui lòng kiểm tra lại.";
        }
        else
        {
          Xoa_LoaiMon(txtMaLoai.Text);
            DgLoaiMon.DataSource = dsLoaiMon();
            DgLoaiMon.DataBind();
            DgLoaiMon.HeaderRow.Cells[0].Text = "Mã Loại ";
            DgLoaiMon.HeaderRow.Cells[1].Text = "Tên Loại ";
            lblTB.Text = "Xóa thành công !";
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";
        }
    }
}