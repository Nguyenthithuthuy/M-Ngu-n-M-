<%@ Page Title="" Language="C#" MasterPageFile="~/TrangChinh.master" AutoEventWireup="true" CodeFile="ChamCongNV.aspx.cs" Inherits="ChamCongNV" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td style="height: 68px; text-align: center;" colspan="3"><strong>
                <asp:Label ID="Label1" runat="server" ForeColor="#3333FF" Text="CHẤM CÔNG NHÂN VIÊN " Font-Size="X-Large"></asp:Label>
                </strong></td>
        </tr>
        <tr>
            <td style="width: 176px">
                <asp:Label ID="Label2" runat="server" Text="Mã Nhân Viên "></asp:Label>
            </td>
            <td style="width: 267px">
                <asp:DropDownList ID="DropDownMaNV" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="btnThem" runat="server" OnClick="btnThem_Click" Text="THÊM " ForeColor="#6666FF" />
            </td>
        </tr>
        <tr>
            <td style="width: 176px">
                <asp:Label ID="Label3" runat="server" Text="Ngày "></asp:Label>
            </td>
            <td style="width: 267px">
                <asp:TextBox ID="txtNgay" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnSua" runat="server" OnClick="btnSua_Click" Text="SỬA" ForeColor="#0066FF" />
            </td>
        </tr>
        <tr>
            <td style="width: 176px">
                <asp:Label ID="Label4" runat="server" Text="Số Ca"></asp:Label>
            </td>
            <td style="width: 267px">
                <asp:TextBox ID="txtSoCa" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnXoa" runat="server" OnClick="btnXoa_Click" Text="XÓA" ForeColor="#0066FF" />
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="DgCong" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" style="margin-left: 194px; margin-top: 23px">
                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#330099" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                    <SortedAscendingCellStyle BackColor="#FEFCEB" />
                    <SortedAscendingHeaderStyle BackColor="#AF0101" />
                    <SortedDescendingCellStyle BackColor="#F6F0C0" />
                    <SortedDescendingHeaderStyle BackColor="#7E0000" />
                </asp:GridView>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 176px">&nbsp;</td>
            <td style="width: 267px">
                <asp:Label ID="txtThongBao" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

