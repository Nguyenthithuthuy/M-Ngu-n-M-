<%@ Page Title="" Language="C#" MasterPageFile="~/TrangChinh.master" AutoEventWireup="true" CodeFile="NhapNguyenLieu.aspx.cs" Inherits="NhapNguyenLieu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td style="height: 71px; text-align: center;" colspan="3"><strong>
                <asp:Label ID="Label1" runat="server" Text="NHẬP NGUYÊN LIỆU " ForeColor="Blue" Height="32px" style="margin-top: 6px; margin-left: 0px;" Width="318px" Font-Size="X-Large"></asp:Label>
                </strong> </td>
        </tr>
        <tr>
            <td style="width: 257px">Mã Nguyên Liệu </td>
            <td style="width: 330px">
                            <asp:TextBox ID="txtMaNguyenLieu" runat="server" Width="231px"></asp:TextBox>
                        </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 257px">Tên Nguyên Liệu </td>
            <td style="width: 330px">
                            <asp:TextBox ID="txtTenNguyenLieu" runat="server"  Width="230px"></asp:TextBox>
                        </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 257px">Hàm Lượng </td>
            <td style="width: 330px">
                            <asp:TextBox ID="txtHamLuong" runat="server" Width="229px"></asp:TextBox>
                        </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 257px">Đơn Vị </td>
            <td style="width: 330px">
                            <asp:TextBox ID="txtDonVi" runat="server" Width="231px"></asp:TextBox>
                        </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 257px">Tổng </td>
            <td style="width: 330px">
                            <asp:TextBox ID="txtTong" runat="server" Width="232px"></asp:TextBox>
                        </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 257px; height: 62px"></td>
            <td style="width: 330px; height: 62px">
                            <asp:Button ID="bntThem" runat="server" OnClick="bntThem_Click" Text="THÊM " ForeColor="#0066FF" />
                            <asp:Button ID="bntSua" runat="server" OnClick="bntSua_Click" style="margin-left: 11px" Text="SỬA" ForeColor="#0066FF" />
                            <asp:Button ID="bntXoa" runat="server" CssClass="auto-style11" OnClick="bntXoa_Click" style="margin-left: 12px" Text="XÓA" ForeColor="#0066FF" />
                        </td>
            <td style="height: 62px"></td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="DgNhapNguyenLieu" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" style="margin-left: 112px; margin-right: 207px" Width="561px">
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
            </td>
        </tr>
        <tr>
            <td style="width: 257px">&nbsp;</td>
            <td style="width: 330px">
                <asp:Label ID="lblTB" runat="server" ForeColor="Red"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

