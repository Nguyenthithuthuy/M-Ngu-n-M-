<%@ Page Title="" Language="C#" MasterPageFile="~/TrangChinh.master" AutoEventWireup="true" CodeFile="TinhLuong.aspx.cs" Inherits="TinhLuong" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
    <table style="width: 100%; height: 119px;">
        <tr>
            <td style="height: 58px; text-align: center;" colspan="4"><strong>
                <asp:Label ID="Label1" runat="server" ForeColor="#3333FF" Text="TÍNH LƯƠNG NHÂN VIÊN " Font-Size="X-Large"></asp:Label>
                </strong></td>
        </tr>
        <tr>
            <td style="width: 160px">
                Tên Nhân Viên
            </td>
            <td style="width: 257px">
                <asp:DropDownList ID="DropMaNV" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                Tổng tiền lương
            </td>
            <td>
                <asp:TextBox ID="txtTinhLuong" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 160px">
                Từ Ngày
            </td>
            <td style="width: 257px">
                <asp:TextBox ID="TxtTuNgay" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnTinhLuong" runat="server" Text="TÍNH LƯƠNG " OnClick="btnTinhLuong_Click" ForeColor="#0066FF" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 160px">
                Đến Ngày
            </td>
            <td style="width: 257px">
                <asp:TextBox ID="TxtDenNgay" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 160px">
                &nbsp;</td>
            <td colspan="2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4" style="text-align: left">
                <asp:GridView ID="DgTinhLuong" runat="server" style="margin-left: 278px">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td style="width: 160px">&nbsp;</td>
            <td style="width: 257px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

