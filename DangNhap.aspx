<%@ Page Title="" Language="C#" MasterPageFile="~/MasterQuan.master" AutoEventWireup="true" CodeFile="DangNhap.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server"> 
    
    <table style="width: 100%; height: 179px;">
        <tr>
            <td colspan="3" style="text-align: center">ĐĂNG NHẬP VÀO HỆ THỐNG </td>
        </tr>
        <tr>
            <td style="width: 192px; height: 67px">Tên Đăng Nhập </td>
            <td style="text-align: center; width: 446px; height: 67px">
                <asp:TextBox ID="txtTenDN" runat="server" Width="246px"></asp:TextBox>
            </td>
            <td style="height: 67px">
                <asp:Button ID="bntDN" runat="server" OnClick="bntDN_Click" Text="OK" />
            </td>
        </tr>
        <tr>
            <td style="width: 192px">Mật Khẩu </td>
            <td style="width: 446px; text-align: center">
                <asp:TextBox ID="txtMatKhau" runat="server" Width="246px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="bntThoat" runat="server" OnClick="bntThoat_Click" Text="THOÁT" />
            </td>
        </tr>
    </table>
    
</asp:Content>

