<%@ Page Title="" Language="C#" MasterPageFile="~/TrangChinh.master" AutoEventWireup="true" CodeFile="HoSoNhanVien.aspx.cs" Inherits="HoSoNhanVien" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
    <table style="width:100%; height: 693px;">
        <tr>
            <td colspan="3" style="text-align: center; height: 81px;"><strong>
                <asp:Label ID="Label1" runat="server" Text="HỒ SƠ NHÂN VIÊN " ForeColor="Blue" Height="32px" style="margin-top: 0px" Width="229px" Font-Size="X-Large"></asp:Label>
                </strong> </td>
        </tr>
        <tr>
            <td style="width: 159px">Mã Nhân Viên &nbsp;</td>
            <td style="width: 266px">
                            <asp:TextBox ID="txtMaNV" runat="server" Width="137px" ></asp:TextBox>
                        </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 159px">Họ Nhân Viên </td>
            <td style="width: 266px">
                            <asp:TextBox ID="txtHoNV" runat="server"></asp:TextBox>
                        </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 159px">Tên Nhân Viên </td>
            <td style="width: 266px">
                            <asp:TextBox ID="txtTenNV" runat="server"></asp:TextBox>
                        </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 159px">Địa Chỉ </td>
            <td style="width: 266px">
                            <asp:TextBox ID="txtDiaChi" runat="server"></asp:TextBox>
                        </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 159px">SĐT</td>
            <td style="width: 266px">
                            <asp:TextBox ID="txtSDT" runat="server"></asp:TextBox>
                        </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 159px">Ngày Vào Làm</td>
            <td style="width: 266px">
                            <asp:TextBox ID="txtNgayVaoLam" runat="server"></asp:TextBox>
                        </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 159px">Lương Cơ Bản </td>
            <td style="width: 266px">
                            <asp:TextBox ID="txtLuongCoBan" runat="server"></asp:TextBox>
                        </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 159px">Giới Tính </td>
            <td style="width: 266px">
                <table style="width:100%;">
                    <tr>
                        <td><asp:RadioButton ID="raNam" runat="server" Checked="True" GroupName="GT" 
                        Text="Nam" />
                        <asp:RadioButton ID="raNu" runat="server" GroupName="GT" Text="Nữ" />

                        </td>
                      
                    </tr>
                </table>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 159px">Ngày Sinh </td>
            <td style="width: 266px">
                            <asp:TextBox ID="txtNgaySinh" runat="server"></asp:TextBox>
                        </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 159px">CMND</td>
            <td style="width: 266px">
                            <asp:TextBox ID="txtCMND" runat="server"></asp:TextBox>
                        </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 159px">Tên Đăng Nhập </td>
            <td style="width: 266px">
                            <asp:TextBox ID="txtTenDN" runat="server"></asp:TextBox>
                        </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 159px">Mật Khẩu </td>
            <td style="width: 266px">
                            <asp:TextBox ID="txtMatKhau" runat="server"></asp:TextBox>
                        </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 159px">Quyền </td>
            <td style="width: 266px">
                            <asp:RadioButton ID="raAdmin" runat="server" Checked="True" GroupName="Quyen" 
                        Text="Admin" />
                        <asp:RadioButton ID="raNu0" runat="server" GroupName="Quyen" Text="User" />

                        </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 159px">&nbsp;</td>
            <td style="width: 266px">
                            <asp:Button ID="bntThem" runat="server" Text="THÊM " OnClick="bntThem_Click" ForeColor="#0066FF" />
                            <asp:Button ID="bntSua" runat="server"  style="margin-left: 11px" Text="SỬA" OnClick="bntSua_Click" ForeColor="#0066FF" />
                            <asp:Button ID="bntXoa" runat="server" CssClass="auto-style11" style="margin-left: 12px" Text="XÓA" OnClick="bntXoa_Click" ForeColor="#0066FF" />
                        </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 159px">Tìm Kiếm Nhân Viên </td>
            <td style="width: 266px">
                            <asp:TextBox ID="txtTimKiem" runat="server"></asp:TextBox>
                        </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 159px">&nbsp;</td>
            <td style="width: 266px">
                            <asp:Button ID="bntTim" runat="server"  Text="Tìm Kiếm " OnClick="bntTim_Click" ForeColor="#0066FF" />
                            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="DgNV" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="100%" Height="100%" CellSpacing="2">
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
        </tr>
        <tr>
            <td style="width: 159px">&nbsp;</td>
            <td style="width: 266px"><strong>
                            <asp:Label ID="lblTB" runat="server" ForeColor="#FF3399"></asp:Label>
                            </strong></td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

