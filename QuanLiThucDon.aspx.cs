using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class QuanLiThucDon : System.Web.UI.Page
{
    String cn = @"Provider=IBMOLEDB.DB2COPY1;Data Source=QCF;Password=251096thuy1;User ID=NK;Location=127.0.0.1";
    private DataBinding BindThucDon;

    DataTable dsThucDon()
    {

        string sql = "SELECT * FROM user1.THUCDON  ";
        OleDbDataAdapter da = new OleDbDataAdapter(sql, cn);
        DataTable ds = new DataTable();
        da.Fill(ds);
        return ds;
    }
    DataTable ds_LoaiMon()
    {

        string sql = "SELECT * FROM user1.LOAIMON  ";
        OleDbDataAdapter da = new OleDbDataAdapter(sql, cn);
        DataTable ds = new DataTable();
        da.Fill(ds);
        return ds;
    }

    void ThemMon(string MaMon, string TenMon, string MaLoai, string DonGia, string DVT, string AnhMon)
    {

        string sql = "INSERT INTO user1.ThucDon VALUES('" + MaMon + "','" + TenMon + "','" + MaLoai + "','" + DonGia + "','" + DVT + "','" + AnhMon + "'   )";
        OleDbConnection conn = new OleDbConnection(cn);
        OleDbCommand cmd = new OleDbCommand(sql, conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }
    void SuaMon(string MaMon, string TenMon, string MaLoai, string DonGia, string DVT, string AnhMon)
    {

        string sql = "UPDATE user1.ThucDon  SET MaMon='" + MaMon + "',TenMon='" + TenMon + "',MaLoai='" + MaLoai + "',DonGia='" + DonGia + "',DVT='" + DVT + "',AnhMon='" + AnhMon + "' WHERE MaMon='" + MaMon + "'";
        OleDbConnection conn = new OleDbConnection(cn);
        OleDbCommand cmd = new OleDbCommand(sql, conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }
    void Xoa_ThucDon(string MaMon)
    {
        OleDbConnection connDB = new OleDbConnection(cn);
        OleDbCommand cmd = new OleDbCommand("DELETE FROM user1.ThucDon WHERE MaMon='" + MaMon + "'", connDB);
        connDB.Open();
        cmd.ExecuteNonQuery();
        connDB.Close();
    }

    DataTable ThucDon_TenMon(string TenMon)
    {
        string sql = " SELECT* FROM user1.ThucDon WHERE  Upper(TenMon) LIKE Upper('%" + TenMon + "%')";
        OleDbDataAdapter ad = new OleDbDataAdapter(sql, cn);
        DataTable ds = new DataTable();
        ad.Fill(ds);
        return ds;
    }



    protected void Page_Load(object sender, EventArgs e)
    {
        DgThucDon.DataSource = dsThucDon();
        DgThucDon.DataBind();
        if (!IsPostBack)
        {
            DropDownMaLoai.DataSource = ds_LoaiMon();
            DropDownMaLoai.DataTextField = "TenLoai";
            DropDownMaLoai.DataValueField = "MaLoai";
            DropDownMaLoai.DataBind();
            DgThucDon.DataBind();
            if (DgThucDon.Rows.Count > 0)
            {
                DgThucDon.HeaderRow.Cells[0].Text = "Mã Món";
                DgThucDon.HeaderRow.Cells[1].Text = "Tên Món";
                DgThucDon.HeaderRow.Cells[2].Text = "Mã Loại";
                DgThucDon.HeaderRow.Cells[3].Text = "Đơn Giá";
                DgThucDon.HeaderRow.Cells[4].Text = "Đơn Vị Tính";
                DgThucDon.HeaderRow.Cells[5].Text = "Ảnh Món";
            }
        }

    }

    protected void bntThem_Click(object sender, EventArgs e)
    {
        try
        {
            if ((txtTenMon.Text != "") && (txtMaMon.Text != "") && (txtDonGia.Text != "") && (txtDVT.Text != ""))
            {
                string TenFile = "";
                if (FileAnh.HasFile)
                {
                    TenFile = FileAnh.FileName;
                    FileAnh.SaveAs(Server.MapPath("~/Images/") + TenFile);
                }
                ThemMon(txtMaMon.Text, txtTenMon.Text, DropDownMaLoai.SelectedValue.ToString(), txtDonGia.Text, txtDVT.Text, TenFile);
                DgThucDon.DataSource = dsThucDon();
                DgThucDon.DataBind();

                if (DgThucDon.Rows.Count > 0)
                {
                    DgThucDon.HeaderRow.Cells[0].Text = "Mã Món";
                    DgThucDon.HeaderRow.Cells[1].Text = "Tên Món";
                    DgThucDon.HeaderRow.Cells[2].Text = "Mã Loại";
                    DgThucDon.HeaderRow.Cells[3].Text = "Đơn Giá";
                    DgThucDon.HeaderRow.Cells[4].Text = "Đơn Vị Tính";
                    DgThucDon.HeaderRow.Cells[5].Text = "Ảnh Món";

                }
                txtMaMon.Text = "";
                txtTenMon.Text = "";
                txtDVT.Text = "";
                txtDonGia.Text = "";
            }
            else
            {
                txtThongBao.Text = "Không được bỏ trống các thuộc tính!";
            }


        }
        catch (Exception) { }
    }

    protected void bntXoa_Click(object sender, EventArgs e)
    {
        if(txtTenMon.Text != "")
        {
            Xoa_ThucDon(txtMaMon.Text);
            DgThucDon.DataSource = dsThucDon();
            DgThucDon.DataBind();
            if (DgThucDon.Rows.Count > 0)
            {
                DgThucDon.HeaderRow.Cells[0].Text = "Mã Món";
                DgThucDon.HeaderRow.Cells[1].Text = "Tên Món";
                DgThucDon.HeaderRow.Cells[2].Text = "Mã Loại";
                DgThucDon.HeaderRow.Cells[3].Text = "Đơn Giá";
                DgThucDon.HeaderRow.Cells[4].Text = "Đơn Vị Tính";
                DgThucDon.HeaderRow.Cells[5].Text = "Ảnh Món";
            }
            txtMaMon.Text = "";
            txtTenMon.Text = "";
            txtDVT.Text = "";
            txtDonGia.Text = "";
            txtThongBao.Text = "Thêm Thành Công !";
        }
        else
        {
            txtThongBao.Text = "Không được bỏ trống các thuộc tính!";
        }
       

    }

    protected void bntSua_Click(object sender, EventArgs e)
    {
        if ((txtTenMon.Text != "") && (txtMaMon.Text != "") && (txtDonGia.Text != "") && (txtDVT.Text != ""))
        {
            string TenFile = "";
            if (FileAnh.HasFile)
            {
                TenFile = FileAnh.FileName;
                FileAnh.SaveAs(Server.MapPath("~/Images/") + TenFile);
            }
            SuaMon(txtMaMon.Text, txtTenMon.Text, DropDownMaLoai.SelectedValue.ToString(), txtDonGia.Text, txtDVT.Text, TenFile);
            DgThucDon.DataSource = dsThucDon();
            DgThucDon.DataBind();
            if (DgThucDon.Rows.Count > 0)
            {
                DgThucDon.HeaderRow.Cells[0].Text = "Mã Món";
                DgThucDon.HeaderRow.Cells[1].Text = "Tên Món";
                DgThucDon.HeaderRow.Cells[2].Text = "Mã Loại";
                DgThucDon.HeaderRow.Cells[3].Text = "Đơn Giá";
                DgThucDon.HeaderRow.Cells[4].Text = "Đơn Vị Tính";
                DgThucDon.HeaderRow.Cells[5].Text = "Ảnh Món";
                
            }
            txtMaMon.Text = "";
            txtTenMon.Text = "";
            txtDVT.Text = "";
            txtDonGia.Text = "";
            txtThongBao.Text = "Sửa thành công!";
        }
        else
        {
            txtThongBao.Text = "Không được bỏ trống thuộc tính!";
        }
           
    }

    protected void bntTimKiem_Click(object sender, EventArgs e)
    {
        DgThucDon.DataSource = ThucDon_TenMon(txtTimKiemMon.Text);
        DgThucDon.DataBind();
        if (DgThucDon.Rows.Count > 0)
        {
            DgThucDon.HeaderRow.Cells[0].Text = "Mã Món";
            DgThucDon.HeaderRow.Cells[1].Text = "Tên Món";
            DgThucDon.HeaderRow.Cells[2].Text = "Mã Loại";
            DgThucDon.HeaderRow.Cells[3].Text = "Đơn Giá";
            DgThucDon.HeaderRow.Cells[4].Text = "Đơn Vị Tính";
            DgThucDon.HeaderRow.Cells[5].Text = "Ảnh Món";
            txtThongBao.Text = "";
           
        }
        else
        {
            txtThongBao.Text = "Không có tên món trong thực đơn";
        }
    }
}