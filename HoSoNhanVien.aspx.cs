using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HoSoNhanVien : System.Web.UI.Page
{

    String cn = @"Provider=IBMOLEDB.DB2COPY1;Data Source=QCF;Password=251096thuy1;User ID=NK;Location=127.0.0.1";
    private DataBinding BindThucDon;

    DataTable dsNhanVien()
    {

        string sql = "SELECT MaNV , CONCAT (HoNV, TenNV) AS hoten, DiaChi, SDT , CAST(NgayVaoLam  AS vargraphic(10)) , LuongCB  , (CASE WHEN GioiTinh='1' THEN 'Nam' ELSE 'Nữ' END) AS GioiTinh ,CAST(NgaySinh  AS vargraphic(10)),  CMND  FROM  user1.NhanVien  ";
        OleDbDataAdapter da = new OleDbDataAdapter(sql, cn);
        DataTable ds = new DataTable();
        da.Fill(ds);
        return ds;
    }
 
    void ThemNV(string MaNV,string HoNV, string TenNV, string DiaChi, string SDT, string NgayVaoLam , string LuongCB, int GioiTinh , string NgaySinh , string CMND , string TenDN , string MatKhau , int  Quyen)
    {

        string sql = "INSERT INTO user1.NhanVien  VALUES('" + MaNV + "','"+ HoNV +"','" + TenNV + "','" + DiaChi + "','" + SDT + "','" + NgayVaoLam + "','" + LuongCB + "' ,'" + GioiTinh + "','" + NgaySinh + "','" + CMND + "','" + TenDN + "' ,'" + MatKhau + "','" + Quyen + "' )";
        OleDbConnection conn = new OleDbConnection(cn);
        OleDbCommand cmd = new OleDbCommand(sql, conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }
    void SuaNV(string MaNV,string HoNV, string TenNV, string DiaChi, string SDT, string NgayVaoLam, string LuongCB, int GioiTinh, string NgaySinh, string CMND, string TenDN, string MatKhau, int Quyen)
    {

        string sql = "UPDATE user1.NhanVien   SET MaNV='" + MaNV + "',HoNV='" + HoNV + "',TenNV='" + TenNV + "',DiaChi='" + DiaChi + "',SDT='" + SDT + "',NgayVaoLam='" + NgayVaoLam + "',LuongCB='" + LuongCB + "' ,GioiTinh='" + GioiTinh + "',NgaySinh='" + NgaySinh + "',CMND='" + CMND + "',TenDN='" + TenDN + "' ,MatKhau='" + MatKhau + "',Quyen='" + Quyen + "'  WHERE MaNV='" + MaNV + "'";
        OleDbConnection conn = new OleDbConnection(cn);
        OleDbCommand cmd = new OleDbCommand(sql, conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }
    void Xoa_NV(string MaNV)
    {
        OleDbConnection connDB = new OleDbConnection(cn);
        OleDbCommand cmd = new OleDbCommand("DELETE FROM user1.NhanVien  WHERE MaNV='" + MaNV + "'", connDB);
        connDB.Open();
        cmd.ExecuteNonQuery();
        connDB.Close();
    }
  



    protected void Page_Load(object sender, EventArgs e)
    {
        DgNV.DataSource = dsNhanVien(); 
        DgNV.DataBind();
      
        DgNV.DataBind();
        if (DgNV.Rows.Count > 0)
        {
            DgNV.HeaderRow.Cells[0].Text = "Mã Nhân Viên ";
            DgNV.HeaderRow.Cells[1].Text = "Họ Tên Nhân Viên ";
            DgNV.HeaderRow.Cells[2].Text = "Địa Chỉ ";
            DgNV.HeaderRow.Cells[3].Text = "SDT";
            DgNV.HeaderRow.Cells[4].Text = "Ngày Vào Làm";
            DgNV.HeaderRow.Cells[5].Text = "Lương Cơ Bản ";
            DgNV.HeaderRow.Cells[6].Text = "Giới Tính";
            DgNV.HeaderRow.Cells[7].Text = "Ngày Sinh ";
            DgNV.HeaderRow.Cells[8].Text = "CMND";
           


        }

    }

    protected void bntThem_Click(object sender, EventArgs e)
    {
        if ((txtMaNV.Text != "") && (txtTenNV.Text != "")&&(txtHoNV.Text != "") && (txtDiaChi.Text != "")&& (txtLuongCoBan.Text != "") && (txtNgaySinh.Text != "")&& (txtSDT.Text != "") && (txtTenDN.Text != "")&& (txtMatKhau.Text != "") &&(txtNgayVaoLam.Text != ""))
        {
            try
            {
                int Quyen = 1;
                if (raAdmin.Checked)
                    Quyen = 1;
                else
                    Quyen = 0;

                int gt = 1;
                if (raNam.Checked)
                    gt = 1;
                else
                    gt = 0;
                ThemNV(txtMaNV.Text, txtHoNV.Text, txtTenNV.Text, txtDiaChi.Text,txtSDT.Text,txtNgayVaoLam.Text,txtLuongCoBan.Text,gt ,txtNgaySinh.Text,txtCMND.Text,txtTenDN.Text,txtMatKhau.Text,Quyen);

               DgNV.DataSource = dsNhanVien();
               DgNV.DataBind();
                if (DgNV.Rows.Count > 0)
                {
                    DgNV.HeaderRow.Cells[0].Text = "Mã Nhân Viên ";
                    DgNV.HeaderRow.Cells[1].Text = "Họ Tên Nhân Viên ";
                    DgNV.HeaderRow.Cells[2].Text = "Địa Chỉ ";
                    DgNV.HeaderRow.Cells[3].Text = "SDT";
                    DgNV.HeaderRow.Cells[4].Text = "Ngày Vào Làm";
                    DgNV.HeaderRow.Cells[5].Text = "Lương Cơ Bản ";
                    DgNV.HeaderRow.Cells[6].Text = "Giới Tính";
                    DgNV.HeaderRow.Cells[7].Text = "Ngày Sinh ";
                    DgNV.HeaderRow.Cells[8].Text = "CMND";
                }


                txtMaNV.Text = "";
                txtHoNV.Text = "";
                txtTenNV.Text = "";
                txtDiaChi.Text = "";
                txtSDT.Text = "";
                txtNgayVaoLam.Text = "";
                txtLuongCoBan.Text = "";
                txtCMND.Text = "";
                txtTenDN.Text = "";
                txtMatKhau.Text = "";
             
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

    protected void bntSua_Click(object sender, EventArgs e)
    {
        if ((txtMaNV.Text != "") && (txtTenNV.Text != "") && (txtHoNV.Text != "") && (txtDiaChi.Text != "") && (txtLuongCoBan.Text != "") && (txtNgaySinh.Text != "") && (txtSDT.Text != "") && (txtTenDN.Text != "") && (txtMatKhau.Text != "") && (txtNgayVaoLam.Text != ""))
        {
            try
            {
                int Quyen = 1;
                if (raAdmin.Checked)
                    Quyen = 1;
                else
                    Quyen = 0;

                int gt = 1;
                if (raNam.Checked)
                    gt = 1;
                else
                    gt = 0;
                SuaNV(txtMaNV.Text, txtHoNV.Text, txtTenNV.Text, txtDiaChi.Text, txtSDT.Text, txtNgayVaoLam.Text, txtLuongCoBan.Text, gt, txtNgaySinh.Text, txtCMND.Text, txtTenDN.Text, txtMatKhau.Text, Quyen);

                DgNV.DataSource = dsNhanVien();
                DgNV.DataBind();
                if (DgNV.Rows.Count > 0)
                {
                    DgNV.HeaderRow.Cells[0].Text = "Mã Nhân Viên ";
                    DgNV.HeaderRow.Cells[1].Text = "Họ Tên Nhân Viên ";
                    DgNV.HeaderRow.Cells[2].Text = "Địa Chỉ ";
                    DgNV.HeaderRow.Cells[3].Text = "SDT";
                    DgNV.HeaderRow.Cells[4].Text = "Ngày Vào Làm";
                    DgNV.HeaderRow.Cells[5].Text = "Lương Cơ Bản ";
                    DgNV.HeaderRow.Cells[6].Text = "Giới Tính";
                    DgNV.HeaderRow.Cells[7].Text = "Ngày Sinh ";
                    DgNV.HeaderRow.Cells[8].Text = "CMND";
                }


                txtMaNV.Text = "";
                txtHoNV.Text = "";
                txtTenNV.Text = "";
                txtDiaChi.Text = "";
                txtSDT.Text = "";
                txtNgayVaoLam.Text = "";
                txtLuongCoBan.Text = "";
                txtCMND.Text = "";
                txtTenDN.Text = "";
                txtMatKhau.Text = "";

                lblTB.Text = "Đã sửa vào thành công.";
            }
            catch
            {
                lblTB.Text = "Không thể sửa thông tin này. Vui lòng kiểm tra lại.";
            }
        }
        else
        {
            lblTB.Text = "Không thể sửa  thông tin này. Vui lòng kiểm tra lại.";
        }

    }
    DataTable NhanVien_Tim (string HoTenNV )
    {
        string sql = " SELECT MaNV, CONCAT (HoNV, TenNV) AS hoten, DiaChi, SDT, NgayVaoLam, LuongCB, (CASE WHEN GioiTinh = '1' THEN 'Nam' ELSE 'Nữ' END) AS GioiTinh, NgaySinh, CMND FROM user1.NhanVien WHERE ( (Upper(HoNV) LIKE Upper('%" + HoTenNV + "%')) OR(Upper(TenNV) LIKE Upper('%" + HoTenNV + "%')) OR(Upper(MaNV) LIKE Upper('%" + HoTenNV + "%')) ) ORDER BY TenNV";
        OleDbDataAdapter ad = new OleDbDataAdapter(sql, cn);
        DataTable ds = new DataTable();
        ad.Fill(ds);
        return ds;
    }

    protected void bntXoa_Click(object sender, EventArgs e)
    {
        if(txtMaNV.Text!="")
        {
            Xoa_NV(txtMaNV.Text);
            DgNV.DataSource = dsNhanVien();
            DgNV.DataBind();
            if (DgNV.Rows.Count > 0)
            {
                DgNV.HeaderRow.Cells[0].Text = "Mã Nhân Viên ";
                DgNV.HeaderRow.Cells[1].Text = "Họ Tên Nhân Viên ";
                DgNV.HeaderRow.Cells[2].Text = "Địa Chỉ ";
                DgNV.HeaderRow.Cells[3].Text = "SDT";
                DgNV.HeaderRow.Cells[4].Text = "Ngày Vào Làm";
                DgNV.HeaderRow.Cells[5].Text = "Lương Cơ Bản ";
                DgNV.HeaderRow.Cells[6].Text = "Giới Tính";
                DgNV.HeaderRow.Cells[7].Text = "Ngày Sinh ";
                DgNV.HeaderRow.Cells[8].Text = "CMND";
            }


            txtMaNV.Text = "";
            txtHoNV.Text = "";
            txtTenNV.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtNgayVaoLam.Text = "";
            txtLuongCoBan.Text = "";
            txtCMND.Text = "";
            txtTenDN.Text = "";
            txtMatKhau.Text = "";

            lblTB.Text = "Đã Xóa vào thành công!";

        }
        else
        {
            lblTB.Text = "Không thể xóa !";
        }
    }

    protected void bntTim_Click(object sender, EventArgs e)
    {
        
        DgNV.DataSource = NhanVien_Tim(txtTimKiem.Text );
        DgNV.DataBind();
        if (DgNV.Rows.Count > 0)
        {
            DgNV.HeaderRow.Cells[0].Text = "Mã Nhân Viên ";
            DgNV.HeaderRow.Cells[1].Text = "Họ Tên Nhân Viên ";
            DgNV.HeaderRow.Cells[2].Text = "Địa Chỉ ";
            DgNV.HeaderRow.Cells[3].Text = "SDT";
            DgNV.HeaderRow.Cells[4].Text = "Ngày Vào Làm";
            DgNV.HeaderRow.Cells[5].Text = "Lương Cơ Bản ";
            DgNV.HeaderRow.Cells[6].Text = "Giới Tính";
            DgNV.HeaderRow.Cells[7].Text = "Ngày Sinh ";
            DgNV.HeaderRow.Cells[8].Text = "CMND";
        }
        else
        {
            lblTB.Text = "Không có tên  trong hồ sơ ";
        }
    }
}