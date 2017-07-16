using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChamCongNV : System.Web.UI.Page
{


    String cn = @"Provider = IBMOLEDB.DB2COPY1; Data Source = QCF; Password=251096thuy1;User ID = NK; Location=127.0.0.1";
    DataTable dsChamCong()
    {

        string sql = "SELECT MaNV, CAST(Ngay AS vargraphic(10)),SoCa FROM user1.ChamCong  ";
        OleDbDataAdapter da = new OleDbDataAdapter(sql, cn);
        DataTable ds = new DataTable();
        da.Fill(ds);
        return ds;
    }
    DataTable NhanVien()
    {

        string sql = "SELECT * FROM user1.NhanVien  ";
        OleDbDataAdapter da = new OleDbDataAdapter(sql, cn);
        DataTable ds = new DataTable();
        da.Fill(ds);
        return ds;
    }
    void ThemChamCong(string MaNV,string Ngay , string  SoCa)
    {

        string sql = "INSERT INTO user1.ChamCong VALUES('" + MaNV + "','" + Ngay + "','" + SoCa + "' )";
        OleDbConnection connDB = new OleDbConnection(cn);
        OleDbCommand cmd = new OleDbCommand(sql, connDB);
        connDB.Open();
        cmd.ExecuteNonQuery();
        connDB.Close();

    }
    void SuaChamCong(string MaNV, string Ngay, string SoCa)
    {
        string sql = "UPDATE user1.ChamCong SET MaNV='" + MaNV + "',Ngay='" + Ngay + "',SoCa='" + SoCa + "' WHERE MaNV='" + MaNV + "',Ngay='"+ Ngay +"'";
        OleDbConnection connDB = new OleDbConnection(cn);
        OleDbCommand cmd = new OleDbCommand(sql, connDB);
        connDB.Open();
        cmd.ExecuteNonQuery();
        connDB.Close();
    }
    void XoaChamCong(string Ngay , string MaNV )
    {
        OleDbConnection connDB = new OleDbConnection(cn);
        OleDbCommand cmd = new OleDbCommand("DELETE FROMuser1.ChamCong WHERE Ngay='" + Ngay+ "',MaNV='"+MaNV+"'", connDB);
        connDB.Open();
        cmd.ExecuteNonQuery();
        connDB.Close();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        DgCong.DataSource = dsChamCong();
        DgCong.DataBind();
        if (!IsPostBack)
        {
            DropDownMaNV.DataSource = NhanVien();
            DropDownMaNV.DataTextField = "TenNV";
            DropDownMaNV.DataValueField = "MaNV";
            DropDownMaNV.DataBind();
            DgCong.DataBind();
            if (DgCong.Rows.Count > 0)
            {
                DgCong.HeaderRow.Cells[0].Text = "Mã Nhân Viên ";
                DgCong.HeaderRow.Cells[1].Text = "Ngày ";
                DgCong.HeaderRow.Cells[2].Text = "Số Ca ";

            }
        }
    

    }

    protected void btnThem_Click(object sender, EventArgs e)
    {
        try
        {
            if ((txtNgay.Text != "") && (txtSoCa.Text != ""))
            {

                ThemChamCong(DropDownMaNV.SelectedValue.ToString(), txtNgay.Text, txtSoCa.Text);
                DgCong.DataSource = dsChamCong();
                DgCong.DataBind();

                if (DgCong.Rows.Count > 0)
                {
                    DgCong.HeaderRow.Cells[0].Text = "Mã Nhân Viên ";
                    DgCong.HeaderRow.Cells[1].Text = "Ngày ";
                    DgCong.HeaderRow.Cells[2].Text = "Số Ca ";

                }
                txtNgay.Text = "";
                txtSoCa.Text = "";
                txtThongBao.Text = "Thêm Thành Công!";

            }
            else
            {
                txtThongBao.Text = "Không được bỏ trống các thuộc tính!";
            }


        }
        catch (Exception)
        { }
    }

    protected void btnSua_Click(object sender, EventArgs e)
    {
        try
        {
            if ((txtNgay.Text != "") && (txtSoCa.Text != ""))
            {

                SuaChamCong(DropDownMaNV.SelectedValue.ToString(), txtNgay.Text, txtSoCa.Text);
                DgCong.DataSource = dsChamCong();
                DgCong.DataBind();

                if (DgCong.Rows.Count > 0)
                {
                    DgCong.HeaderRow.Cells[0].Text = "Mã Nhân Viên ";
                    DgCong.HeaderRow.Cells[1].Text = "Ngày ";
                    DgCong.HeaderRow.Cells[2].Text = "Số Ca ";

                }
                txtNgay.Text = "";
                txtSoCa.Text = "";
                txtThongBao.Text = "Sửa Thành Công!";

            }
            else
            {
                txtThongBao.Text = "Không được bỏ trống các thuộc tính!";
            }
        }
        catch (Exception)
        { }


    }

    protected void btnXoa_Click(object sender, EventArgs e)
    {

        if (txtNgay.Text != "" )
        {
            XoaChamCong(txtNgay.Text, DropDownMaNV.SelectedValue.ToString());
            DgCong.DataSource = dsChamCong();
            DgCong.DataBind();
            if (DgCong.Rows.Count > 0)
            {
                DgCong.HeaderRow.Cells[0].Text = "Mã Nhân Viên ";
                DgCong.HeaderRow.Cells[1].Text = "Ngày ";
                DgCong.HeaderRow.Cells[2].Text = "Số Ca ";

            }
            txtNgay.Text = "";
            txtSoCa.Text = "";
            txtThongBao.Text = "Xóa Thành Công!";

        }
        else
        {
            txtThongBao.Text = "THuộc tính không được xóa !";
        }


    }
}