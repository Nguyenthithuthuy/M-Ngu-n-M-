<%@ Page Title="" Language="C#" MasterPageFile="~/TrangChinh.master" AutoEventWireup="true" CodeFile="QuanLiBan.aspx.cs" Inherits="QuanLiBan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
    <table style="width: 100%; height: 341px;">
        <tr>
            <td colspan="3" style="text-align: center; height: 68px;"><strong>
                <asp:Label ID="Label1" runat="server" Text="QUẢN LÍ BÀN " ForeColor="Blue" Height="34px" style="margin-top: 0px" Width="229px" Font-Size="X-Large"></asp:Label>
                </strong> </td>
        </tr>
        <tr>
            <td style="width: 197px; text-align: center">Mã Bàn</td>
            <td style="width: 402px; text-align: center">
                <asp:TextBox ID="TxtMaBan" runat="server" OnDataBinding="Page_Load" Width="266px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 197px; text-align: center">Số Người</td>
            <td style="width: 402px; text-align: center">
                <asp:TextBox ID="TxtSoNguoi" runat="server" OnDataBinding="Page_Load" Width="267px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 197px; height: 73px"></td>
            <td style="width: 402px; text-align: center; height: 73px">
                <asp:Button ID="BntThem" runat="server" OnClick="BntThem_Click" Text="THÊM" ForeColor="#0066FF" />
                <asp:Button ID="BntSua" runat="server" OnClick="BntSua_Click" style="margin-left: 41px" Text="SỬA" ForeColor="#0066FF" />
                <asp:Button ID="BntXoa" runat="server" OnClick="BntXoa_Click" style="margin-left: 45px" Text="XÓA" ForeColor="#0066FF" />
            </td>
            <td style="height: 73px"></td>
        </tr>
        <tr>
            <td style="width: 197px">&nbsp;</td>
            <td style="width: 402px; text-align: center">
                <asp:GridView ID="DgBan" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" OnSelectedIndexChanging="DgBan_SelectedIndexChanging" style="margin-left: 83px; margin-top: 0px">
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                    <SortedAscendingHeaderStyle BackColor="#B95C30" />
                    <SortedDescendingCellStyle BackColor="#F1E5CE" />
                    <SortedDescendingHeaderStyle BackColor="#93451F" />
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 197px">&nbsp;</td>
            <td style="width: 402px">
                <asp:Label ID="lblTB" runat="server" ForeColor="Red"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

