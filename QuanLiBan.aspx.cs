using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class QuanLiBan : System.Web.UI.Page
{
    String cn = @"Provider = IBMOLEDB.DB2COPY1; Data Source = QCF; Password=251096thuy1;User ID = NK; Location=127.0.0.1";
    DataTable dsBan()
    {

        string sql = "SELECT * FROM user1.Ban  ";
        OleDbDataAdapter da = new OleDbDataAdapter(sql, cn);
        DataTable ds = new DataTable();
        da.Fill(ds);
        return ds;
    }
    void ThemBan(string MaBan, string SoNguoi)
    {

        string sql = "INSERT INTO user1.Ban VALUES('" + MaBan + "', '" + SoNguoi + "' )";
        OleDbConnection conn = new OleDbConnection(cn);
        OleDbCommand cmd = new OleDbCommand(sql, conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

    }
    void Sua_Ban(string MaBan, string SoNguoi)
    {
        string sql = "UPDATE user1.Ban SET MaBan='" + MaBan + "',SoNguoi='" + SoNguoi + "' WHERE MaBan='" + MaBan + "'";
        OleDbConnection connDB = new OleDbConnection(cn);
        OleDbCommand cmd = new OleDbCommand(sql, connDB);
        connDB.Open();
        cmd.ExecuteNonQuery();
        connDB.Close();
    }
    void Xoa_Ban(string MaBan)
    {
        OleDbConnection connDB = new OleDbConnection(cn);
        OleDbCommand cmd = new OleDbCommand("DELETE FROM user1.Ban WHERE MaBan='" + MaBan + "'", connDB);
        connDB.Open();
        cmd.ExecuteNonQuery();
        connDB.Close();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        DgBan.DataSource = dsBan();
        DgBan.DataBind();
        DgBan.HeaderRow.Cells[0].Text = "Mã Bàn ";
        DgBan.HeaderRow.Cells[1].Text = "Số Người ";
    }

    protected void BntThem_Click(object sender, EventArgs e)
    {
        if ((TxtMaBan.Text != "") && (TxtSoNguoi.Text != ""))
        {
            try
            {

                ThemBan(TxtMaBan.Text, TxtSoNguoi.Text);
                lblTB.Text = "Đã thêm vào thành công.";
                DgBan.DataSource = dsBan();
                DgBan.DataBind();
                DgBan.HeaderRow.Cells[0].Text = "Mã Bàn ";
                DgBan.HeaderRow.Cells[1].Text = "Số Người ";
                TxtMaBan.Text = "";
                TxtSoNguoi.Text = "";
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


    protected void BntSua_Click(object sender, EventArgs e)
    {
        if ((TxtMaBan.Text != "") && (TxtSoNguoi.Text != ""))
        {
            try
            {

                Sua_Ban(TxtMaBan.Text, TxtSoNguoi.Text);
                lblTB.Text = "Đã sửa vào thành công.";
                DgBan.DataSource = dsBan();
                DgBan.DataBind();
                DgBan.HeaderRow.Cells[0].Text = "Mã Bàn ";
                DgBan.HeaderRow.Cells[1].Text = "Số Người ";
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

    protected void BntXoa_Click(object sender, EventArgs e)
    {
        if((TxtMaBan.Text=="")||(TxtSoNguoi.Text==""))
        {
            lblTB.Text = "Không thể xóa thông tin này. Vui lòng kiểm tra lại.";
        }
        else
        {
            Xoa_Ban(TxtMaBan.Text);
            DgBan.DataSource = dsBan();
            DgBan.DataBind();
            DgBan.HeaderRow.Cells[0].Text = "Mã Bàn ";
            DgBan.HeaderRow.Cells[1].Text = "Số Người ";
            lblTB.Text = "Xóa thành công !";
            TxtMaBan.Text = "";
            TxtSoNguoi.Text = "";
        }
    }

    protected void DgBan_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {

        GridViewRow row;

        row = DgBan.Rows[e.NewSelectedIndex];
        TxtMaBan.Text = Server.HtmlDecode(row.Cells[1].Text);
        TxtSoNguoi.Text = Server.HtmlDecode(row.Cells[2].Text);
    }
}