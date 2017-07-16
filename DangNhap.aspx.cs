using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    String cn = @"Provider=IBMOLEDB.DB2COPY1;Data Source=QCF;Password=251096thuy1;User ID=NK;Location=127.0.0.1";

    bool KiemTraDN(string TenDN, string MatKhau)
    {
        OleDbConnection dbCon = new OleDbConnection(cn);
        dbCon.Open();
        string sql = ("SELECT TENDN FROM user1.NHANVIEN WHERE TENDN ='" + TenDN + "' AND  MATKHAU = '" + MatKhau + "'");
        OleDbCommand cmd = new OleDbCommand(sql, dbCon);
        OleDbDataReader reader = cmd.ExecuteReader();
        if (reader.HasRows)
            return true;
        else
            return false;
    }
    protected void bntDN_Click(object sender, EventArgs e)
    {

        if (KiemTraDN(txtTenDN.Text, txtMatKhau.Text) == true)
        {
            Session["TENDN"] = txtTenDN.Text;
            Response.Redirect("ndTrangChinh.aspx");
        }
        else
        {
            Session["TENDN"] = "";
            Response.Redirect("QuangCao.aspx");
        }


    
}

    protected void bntThoat_Click(object sender, EventArgs e)
    {
        Response.Redirect("QuangCao.aspx");
    }
}