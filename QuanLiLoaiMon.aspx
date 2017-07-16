<%@ Page Title="" Language="C#" MasterPageFile="~/TrangChinh.master" AutoEventWireup="true" CodeFile="QuanLiLoaiMon.aspx.cs" Inherits="QuanLiLoaiMon" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
    <table>
        <tr>
            <td class="auto-style3" style="width: 288px; text-align: center; height: 79px;"></td>
            <td class="auto-style3" colspan="2" style="text-align: center; height: 79px;">
                <strong>
                <asp:Label ID="Label1" runat="server" Text="QUẢN LÍ LOẠI MÓN " ForeColor="Blue" Height="34px" style="margin-top: 0px" Width="289px" Font-Size="X-Large"></asp:Label>
                </strong>
            </td>
            <td style="width: 503px; height: 79px;"></td>
        </tr>
        <tr>
            <td class="auto-style3" style="width: 288px">&nbsp;</td>
            <td class="auto-style3" style="width: 164px">
                <asp:Label ID="Label2" runat="server" Text="Mã Loại"></asp:Label>
            </td>
            <td class="auto-style4" style="width: 486px">
                <asp:TextBox ID="txtMaLoai" runat="server" Width="211px"></asp:TextBox>
            </td>
            <td style="width: 503px">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" style="width: 288px">&nbsp;</td>
            <td class="auto-style3" style="width: 164px">
                <asp:Label ID="Label3" runat="server" Text="Tên Loại "></asp:Label>
            </td>
            <td class="auto-style4" style="width: 486px">
                <asp:TextBox ID="txtTenLoai" runat="server" Width="207px"></asp:TextBox>
            </td>
            <td style="width: 503px">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" style="width: 288px">&nbsp;</td>
            <td class="auto-style3" style="width: 164px">&nbsp;</td>
            <td class="auto-style4" style="width: 486px">
                <asp:Button ID="btnThem" runat="server" OnClick="btnThem_Click" style="margin-left: 0px" Text="THÊM " ForeColor="#0066FF" />
                <asp:Button ID="btnSua" runat="server" CssClass="auto-style5" OnClick="btnSua_Click" style="margin-left: 20px" Text="SỬA " ForeColor="#0066FF" />
                <asp:Button ID="btnXoa" runat="server" CssClass="auto-style5" OnClick="btnXoa_Click" style="margin-left: 26px" Text="XÓA " ForeColor="#0066FF" />
            </td>
            <td style="width: 503px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 288px">&nbsp;</td>
            <td colspan="3">
                <asp:GridView ID="DgLoaiMon" runat="server" style="margin-left: 66px; margin-top: 16px" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                    <PagerStyle ForeColor="#330099" HorizontalAlign="Center" BackColor="#FFFFCC" />
                    <RowStyle BackColor="White" ForeColor="#330099" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                    <SortedAscendingCellStyle BackColor="#FEFCEB" />
                    <SortedAscendingHeaderStyle BackColor="#AF0101" />
                    <SortedDescendingCellStyle BackColor="#F6F0C0" />
                    <SortedDescendingHeaderStyle BackColor="#7E0000" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style3" style="width: 288px">&nbsp;</td>
            <td colspan="2">
                <asp:Label ID="lblTB" runat="server" ForeColor="Red"></asp:Label>
            </td>
            <td style="width: 503px">&nbsp;</td>
        </tr>
    </table>
</asp:Content>

