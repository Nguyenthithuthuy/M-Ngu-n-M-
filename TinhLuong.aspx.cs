using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TinhLuong : System.Web.UI.Page
{
    String cn = @"Provider=IBMOLEDB.DB2COPY1;Data Source=QCF;Password=251096thuy1;User ID=NK;Location=127.0.0.1";
    int TongSoCa(string MaNV, string TuNgay, string DenNgay)
    {
        string sql = "SELECT count(SoCa) FROM user1.ChamCong where( (ngay between '" + TuNgay + "' and '" + DenNgay + "') AND (MaNV= '" + MaNV + "') )  ";
        OleDbConnection conn = new OleDbConnection(cn);
        OleDbCommand cmd = new OleDbCommand(sql, conn);
        conn.Open();
        int dem = 0;
          dem = (int)cmd.ExecuteScalar();
        return dem;
    }
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
    int hesoluong ( string maNV  )
    {
        string sql = "SELECT LuongCB FROM user1.NhanVien where MaNV = '"+maNV+"' ";
        OleDbConnection conn = new OleDbConnection(cn);
        OleDbCommand cmd = new OleDbCommand(sql, conn);
        conn.Open();
        
        return (int)cmd.ExecuteScalar();

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        DgTinhLuong.DataSource = dsChamCong();
        DgTinhLuong.DataBind();
        if (!IsPostBack)
        {
            DropMaNV.DataSource = NhanVien();
            DropMaNV.DataTextField = "TenNV";
            DropMaNV.DataValueField = "MaNV";
            DropMaNV.DataBind();
            DgTinhLuong.DataBind();
            if (DgTinhLuong.Rows.Count > 0)
            {
                DgTinhLuong.HeaderRow.Cells[0].Text = "Mã Nhân Viên ";
                DgTinhLuong.HeaderRow.Cells[1].Text = "Ngày ";
                DgTinhLuong.HeaderRow.Cells[2].Text = "Số Ca ";

            }
        }
    }

    protected void btnTinhLuong_Click(object sender, EventArgs e)
    {
        int t;
        t = TongSoCa(DropMaNV.SelectedValue.ToString(), TxtTuNgay.Text, TxtDenNgay.Text);
        int h;
        h = hesoluong(DropMaNV.SelectedValue.ToString());
        int luong = t * h;
        txtTinhLuong.Text = Convert.ToSingle(luong).ToString();
        if (!IsPostBack)
        {
            DropMaNV.DataSource = NhanVien();
            DropMaNV.DataTextField = "TenNV";
            DropMaNV.DataValueField = "MaNV";
            DropMaNV.DataBind();
            DgTinhLuong.DataBind();
            if (DgTinhLuong.Rows.Count > 0)
            {
                DgTinhLuong.HeaderRow.Cells[0].Text = "Mã Nhân Viên ";
                DgTinhLuong.HeaderRow.Cells[1].Text = "Ngày ";
                DgTinhLuong.HeaderRow.Cells[2].Text = "Số Ca ";

            }


        }
    }
}