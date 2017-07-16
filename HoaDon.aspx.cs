using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HoaDon : System.Web.UI.Page
{
    float TongTien = 0;

    String cn = @"Provider=IBMOLEDB.DB2COPY1;Data Source=QCF;Password=251096thuy1;User ID=NK;Location=127.0.0.1";
    private DataBinding BindThucDon;
    DataTable ds_LoaiMon()
    {

        string sql = "SELECT * FROM user1.ThucDon  ";
        OleDbDataAdapter da = new OleDbDataAdapter(sql, cn);
        DataTable ds = new DataTable();
        da.Fill(ds);
        return ds;
    }
    DataTable dsBan()
    {

        string sql = "SELECT * FROM user1.Ban  ";
        OleDbDataAdapter da = new OleDbDataAdapter(sql, cn);
        DataTable ds = new DataTable();
        da.Fill(ds);
        return ds;
    }
    DataTable ds_Phieu()
    {

        string sql = "SELECT MaPhieu , MaNV ,  CAST(NgayTao AS vargraphic(10)) , MaBan , Tongsotien , TrangThai  FROM  user1.phieu   ";
        OleDbDataAdapter da = new OleDbDataAdapter(sql, cn);
        DataTable ds = new DataTable();
        da.Fill(ds);
        return ds;
    }
    DataTable ds_NHANVIEN()
    {

        string sql = "SELECT * FROM user1.NhanVien  ";
        OleDbDataAdapter da = new OleDbDataAdapter(sql, cn);
        DataTable ds = new DataTable();
        da.Fill(ds);
        return ds;
    }
    string  DonGia ( string MaMon  )
    {
        string sql = "Select DonGia from  user1.ThucDon where MaMon= '"+ MaMon +"'";
        OleDbConnection conn = new OleDbConnection(cn);
        OleDbCommand cmd = new OleDbCommand(sql, conn);
        conn.Open();
        return (string)cmd.ExecuteScalar();
    }
    void ThemPhieu(string MaPhieu, string MaNV, string Ngay, string MaBan, string TongSoTien, int TrangThai)
    {

        string sql = "INSERT INTO user1.phieu VALUES('" + MaPhieu + "','" + MaNV + "','" + Ngay + "','" + MaBan + "','" + TongSoTien + "','" + TrangThai+ "'   )";
        OleDbConnection conn = new OleDbConnection(cn);
        OleDbCommand cmd = new OleDbCommand(sql, conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }
    void SuaPhieu(string MaPhieu, string MaNV, string Ngay, string MaBan, string TongSoTien, int TrangThai)
    {

        string sql = "UPDATE user1.phieu   SET MaPhieu='" + MaPhieu + "',NgayTao='" + Ngay + "',MaBan='" + MaBan + "',TongSoTien='" + TongSoTien + "', TrangThai='" + TrangThai + "' WHERE MaPhieu='" + MaPhieu + "'";
        OleDbConnection conn = new OleDbConnection(cn);
        OleDbCommand cmd = new OleDbCommand(sql, conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }
    void Xoa_Phieu(string MaPhieu)
    {
        OleDbConnection connDB = new OleDbConnection(cn);
        OleDbCommand cmd = new OleDbCommand("DELETE FROM user1.Phieu  WHERE MaPhieu='" + MaPhieu + "'", connDB);
        connDB.Open();
        cmd.ExecuteNonQuery();
        connDB.Close();
    }
    DataTable MaPhieu_Tim(string MaPhieu )
    {
        string sql = " SELECT  MaPhieu , MaNV ,  CAST(NgayTao AS vargraphic(10)) , MaBan , Tongsotien , TrangThai FROM user1.Phieu WHERE  (Upper(MaPhieu) LIKE Upper('%" + MaPhieu + "%'))  ORDER BY MaPhieu";
        OleDbDataAdapter ad = new OleDbDataAdapter(sql, cn);
        DataTable ds = new DataTable();
        ad.Fill(ds);
        return ds;
    }
    private void _KhoiTao()
    {
        try
        {
            lsbTenSanPham.Items.Clear();
            lsbThanhTien.Items.Clear();
        }
        catch (Exception)
        {

        }
    }

    public static string _DoiSoSangDonViTienTe(object _object)
    {
        try
        {
            if (_object.ToString().Trim().Length == 0)
            { return " "; }

            if (_object.ToString() == "0")
            {
                return "0,000";
            }

            decimal dThanhTien = Convert.ToDecimal(_object);
            string strThanhTien = string.Format("{0:#,#.}", dThanhTien);
            return strThanhTien;
        }
        catch (Exception)
        {

        }
        return "0.000";
    }

    private void _TongTien()
    {
        try
        {
            if (lsbThanhTien.Items.Count == 0)
                return;

            float ThanhTien = 0;

            float SoLuong = 0;


            for (int i = 0; i < lsbThanhTien.Items.Count; i++)
            {
                ThanhTien = Convert.ToSingle(lsbThanhTien.Items[i].ToString().Replace(",", ""));
                SoLuong = Convert.ToSingle(txtSoLuong.Text);
                TongTien = (TongTien + (ThanhTien * SoLuong));
            }
            txtTongTien.Text = Convert.ToDecimal(TongTien).ToString();

        }
        catch (Exception)
        {

        }
    }
    private void _ThanhTien()
    {
        try
        {
            if (Convert.ToSingle(txtTienMat.Text) > TongTien)
            {
                float tientra = 0;
                tientra = Convert.ToSingle(txtTienMat.Text) - TongTien;
                txtTienTra.Text = Convert.ToDecimal(tientra).ToString();
            }
            else
            {
                lbthongbao.Text = "Giá trị tiền mặt không đủ!";
            }
        }
        catch (Exception)
        { }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                DropMaMon.DataSource = ds_LoaiMon();
                DropMaMon.DataTextField = "TenMon";
                DropMaMon.DataValueField = "MaMon";
                DropMaMon.DataBind();
            }
            if (!IsPostBack)
            {
                DropMaNV.DataSource = ds_NHANVIEN();
                DropMaNV.DataTextField = "TenNV";
                DropMaNV.DataValueField = "MaNV";
                DropMaNV.DataBind();
            }
            if (!IsPostBack)
            {
                DropMaBan.DataSource = dsBan();
                DropMaBan.DataTextField = "MaBan";
                DropMaBan.DataValueField = "MaBan";
                DropMaBan.DataBind();
            }
          
        }
        catch { }

        dgPhieu.DataSource = ds_Phieu();
        dgPhieu.DataBind();
        if (!IsPostBack)
        {

            
                DropMaMon.DataSource = ds_LoaiMon();
                DropMaMon.DataTextField = "TenMon";
                DropMaMon.DataValueField = "MaMon";
                DropMaMon.DataBind();
         
            
                DropMaNV.DataSource = ds_NHANVIEN();
                DropMaNV.DataTextField = "TenNV";
                DropMaNV.DataValueField = "MaNV";
                DropMaNV.DataBind();
            
            
               DropMaBan.DataSource = dsBan();
                DropMaBan.DataTextField = "MaBan";
                DropMaBan.DataValueField = "MaBan";
                DropMaBan.DataBind();
            }



        if (dgPhieu.Rows.Count > 0)
        {
            dgPhieu.HeaderRow.Cells[0].Text = "Mã Phiếu ";
            dgPhieu.HeaderRow.Cells[1].Text = "Mã Nhân Viên  ";
            dgPhieu.HeaderRow.Cells[2].Text = "Ngày Tạo  ";
            dgPhieu.HeaderRow.Cells[3].Text = "Mã Bàn ";
            dgPhieu.HeaderRow.Cells[4].Text = "Tổng Số Tiền  ";
            dgPhieu.HeaderRow.Cells[5].Text = "Trạng Thái  ";

        }
            string myFileName = String.Format("{0}{1}", DateTime.Now.ToString("dd-MM-yyyy"), "");
            txtNgay.Text = myFileName.ToString();



    }

    protected void btnThem_Click(object sender, EventArgs e)
    {
        try
        {
           

                lsbTenSanPham.Items.Add(DropMaMon.Text);
                string Tam = _DoiSoSangDonViTienTe(txtDonGia.Text);
                lsbThanhTien.Items.Add(Tam);
               
                _TongTien();
          
                _TongTien();
                _ThanhTien();
           
        }
        catch (Exception)
        {

        }

    }

    protected void btnXoa_Click(object sender, EventArgs e)
    {
        try
        {
            int Index = lsbTenSanPham.SelectedIndex;
            lsbTenSanPham.Items.RemoveAt(Index);
            lsbThanhTien.Items.RemoveAt(Index);
            _TongTien();
        }
        catch (Exception)
        {

        }
    }

    protected void lsbTenSanPham_SelectedIndexChanged(object sender, EventArgs e)
    {
        lsbThanhTien.SelectedIndex = lsbTenSanPham.SelectedIndex;
    }

    protected void lsbThanhTien_SelectedIndexChanged(object sender, EventArgs e)
    {
        lsbTenSanPham.SelectedIndex = lsbThanhTien.SelectedIndex;
    }

   

    protected void btnThemPhieu_Click(object sender, EventArgs e)
    {
        try
        {
            

            int TrangThai = 1;
            if (RadioButton1.Checked)
                TrangThai = 1;
            else
                TrangThai = 0;
            ThemPhieu(txtMaPhieu.Text, DropMaNV.SelectedValue.ToString(), txtNgay.Text, DropMaBan.SelectedValue.ToString(), txtTongTien.Text, TrangThai);

            dgPhieu.DataSource = ds_Phieu();
            dgPhieu.DataBind();
            if (dgPhieu.Rows.Count > 0)
            {
                dgPhieu.HeaderRow.Cells[0].Text = "Mã Phiếu ";
                dgPhieu.HeaderRow.Cells[1].Text = "Mã Nhân Viên  ";
                dgPhieu.HeaderRow.Cells[2].Text = "Ngày Tạo  ";
                dgPhieu.HeaderRow.Cells[3].Text = "Mã Bàn ";
                dgPhieu.HeaderRow.Cells[4].Text = "Tổng Số Tiền  ";
                dgPhieu.HeaderRow.Cells[5].Text = "Trạng Thái  ";


            }
            lbthongbao.Text = "Phiếu đã được thêm vào danh sách!";
        }
        catch (Exception)
        {
            lbthongbao.Text = "Mã Phiếu đã có trong danh sách!";
        }
        
       


    }

    protected void btnSuaPhieu_Click(object sender, EventArgs e)
    {

        try
        {


            int TrangThai = 1;
            if (RadioButton1.Checked)
                TrangThai = 1;
            else
                TrangThai = 0;
            SuaPhieu(txtMaPhieu.Text, DropMaNV.SelectedValue.ToString(), txtNgay.Text, DropMaBan.SelectedValue.ToString(), txtTongTien.Text, TrangThai);

            dgPhieu.DataSource = ds_Phieu();
            dgPhieu.DataBind();
            if (dgPhieu.Rows.Count > 0)
            {
                dgPhieu.HeaderRow.Cells[0].Text = "Mã Phiếu ";
                dgPhieu.HeaderRow.Cells[1].Text = "Mã Nhân Viên  ";
                dgPhieu.HeaderRow.Cells[2].Text = "Ngày Tạo  ";
                dgPhieu.HeaderRow.Cells[3].Text = "Mã Bàn ";
                dgPhieu.HeaderRow.Cells[4].Text = "Tổng Số Tiền  ";
                dgPhieu.HeaderRow.Cells[5].Text = "Trạng Thái  ";


            }
            lbthongbao.Text = "Phiếu đã được sửa vào danh sách!";
        }
        catch (Exception)
        {
            lbthongbao.Text = "Mã Phiếu đã có trong danh sách!";
        }




    }

    protected void btnXoaPhieu_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtMaPhieu.Text != "")
            {
                Xoa_Phieu(txtMaPhieu.Text);
                dgPhieu.DataSource = ds_Phieu();
                dgPhieu.DataBind();
                if (dgPhieu.Rows.Count > 0)
                {
                    dgPhieu.HeaderRow.Cells[0].Text = "Mã Phiếu ";
                    dgPhieu.HeaderRow.Cells[1].Text = "Mã Nhân Viên  ";
                    dgPhieu.HeaderRow.Cells[2].Text = "Ngày Tạo  ";
                    dgPhieu.HeaderRow.Cells[3].Text = "Mã Bàn ";
                    dgPhieu.HeaderRow.Cells[4].Text = "Tổng Số Tiền  ";
                    dgPhieu.HeaderRow.Cells[5].Text = "Trạng Thái  ";

                }
                lbthongbao.Text = "Phiếu đã được Xóa khỏi danh sách!";
            }
            else
            {
                lbthongbao.Text = "yêu cầu nhập mã phiếu!! ";
            }

        } catch( Exception)
        {
            lbthongbao.Text = "Phiếu không tồn tại! ";
        }

       
    }



    protected void btnTimKiem_Click(object sender, EventArgs e)
    {
        try
        {
            dgPhieu.DataSource = MaPhieu_Tim(txtTimKiem.Text);
            dgPhieu.DataBind();
            if (dgPhieu.Rows.Count > 0)
            {
                dgPhieu.HeaderRow.Cells[0].Text = "Mã Phiếu ";
                dgPhieu.HeaderRow.Cells[1].Text = "Mã Nhân Viên  ";
                dgPhieu.HeaderRow.Cells[2].Text = "Ngày Tạo  ";
                dgPhieu.HeaderRow.Cells[3].Text = "Mã Bàn ";
                dgPhieu.HeaderRow.Cells[4].Text = "Tổng Số Tiền  ";
                dgPhieu.HeaderRow.Cells[5].Text = "Trạng Thái  ";


            }
            else
            {
                lbthongbao.Text = " Không có phiếu trong danh sách!";
            }
        }
        catch (Exception)
        {
            
        }
    }

    protected void BntTinh_Click(object sender, EventArgs e)
    {
        _TongTien();
        _ThanhTien();
    }
}