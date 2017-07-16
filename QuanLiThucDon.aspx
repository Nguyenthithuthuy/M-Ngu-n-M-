<%@ Page Title="" Language="C#" MasterPageFile="~/TrangChinh.master" AutoEventWireup="true" CodeFile="QuanLiThucDon.aspx.cs" Inherits="QuanLiThucDon" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
    <table class="auto-style2">
        <tr>
            <td colspan="3" style="text-align: center">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 99px"></td>
            <td class="auto-style3">
                <table>
                    <tr>
                        <td class="auto-style10" colspan="3" style="text-align: center; height: 58px;"><strong>
                <asp:Label ID="Label1" runat="server" Text="QUẢN LÍ THỰC ĐƠN " ForeColor="Blue" Height="32px" style="margin-top: 0px" Width="281px" Font-Size="X-Large"></asp:Label>
                </strong> </td>
                    </tr>
                    <tr>
                        <td class="auto-style5" style="text-align: left; width: 424px">Mã Món</td>
                        <td class="auto-style7" style="width: 244px">
                            <asp:TextBox ID="txtMaMon" runat="server"></asp:TextBox>
                        </td>
                        <td style="width: 367px; text-align: center">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style6" style="text-align: left; width: 424px">Tên Món</td>
                        <td class="auto-style8" style="width: 244px">
                            <asp:TextBox ID="txtTenMon" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style4" style="width: 367px; text-align: center">
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5" style="text-align: left; width: 424px">Mã Loại</td>
                        <td class="auto-style7" style="width: 244px">
                            <asp:DropDownList ID="DropDownMaLoai" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td style="width: 367px; text-align: center">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5" style="text-align: left; width: 424px">Đơn Giá</td>
                        <td class="auto-style7" style="width: 244px">
                            <asp:TextBox ID="txtDonGia" runat="server"></asp:TextBox>
                        </td>
                        <td style="width: 367px; text-align: center">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5" style="text-align: left; width: 424px">Đơn Vị Tính</td>
                        <td class="auto-style7" style="width: 244px">
                            <asp:TextBox ID="txtDVT" runat="server"></asp:TextBox>
                        </td>
                        <td style="width: 367px; text-align: center">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5" style="text-align: left; width: 424px; height: 46px;">Ảnh Món</td>
                        <td class="auto-style7" style="width: 244px; height: 46px;">
                            <asp:FileUpload ID="FileAnh" runat="server" />
                        </td>
                        <td style="width: 367px; text-align: center; height: 46px;"></td>
                    </tr>
                    <tr>
                        <td class="auto-style5" style="text-align: center; width: 424px; height: 86px;"></td>
                        <td class="auto-style7" style="width: 244px; height: 86px;">
                            <asp:Button ID="bntThem" runat="server" OnClick="bntThem_Click" Text="THÊM " ForeColor="#0066FF" />
                            <asp:Button ID="bntSua" runat="server" OnClick="bntSua_Click" style="margin-left: 11px" Text="SỬA" ForeColor="#0066FF" />
                            <asp:Button ID="bntXoa" runat="server" CssClass="auto-style11" OnClick="bntXoa_Click" style="margin-left: 12px" Text="XÓA" ForeColor="#0066FF" />
                        </td>
                        <td style="width: 367px; text-align: center; height: 86px;"></td>
                    </tr>
                    <tr>
                        <td class="auto-style5" style="text-align: left; width: 424px">Tìm Kiếm Tên Món </td>
                        <td class="auto-style7" style="width: 244px">
                            <asp:TextBox ID="txtTimKiemMon" runat="server" Width="149px"></asp:TextBox>
                        </td>
                        <td style="width: 367px">
                            <asp:Button ID="bntTimKiem" runat="server" OnClick="bntTimKiem_Click" Text="TÌM KIẾM " ForeColor="#0066FF" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3" style="text-align: center">
                            <asp:GridView ID="DgThucDon" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" style="margin-left: 30px; margin-top: 22px">
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
                        <td colspan="3" style="text-align: center"><strong>
                            <asp:Label ID="txtThongBao" runat="server" ForeColor="#FF3399"></asp:Label>
                            </strong></td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

