<%@ Page Title="" Language="C#" MasterPageFile="~/TrangChinh.master" AutoEventWireup="true" CodeFile="HoaDon.aspx.cs" Inherits="HoaDon" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td colspan="4" style="text-align: center; height: 50px"><strong>
                <asp:Label ID="Label2" runat="server" ForeColor="#3333FF" Text="PHIẾU " Font-Size="X-Large" Height="50px"></asp:Label>
                </strong>&nbsp;&nbsp;</td>
        </tr>
         <tr>
            <td style="width: 64px">Mã Phiếu </td>
            <td style="width: 90px">
                <asp:TextBox ID="txtMaPhieu" runat="server"></asp:TextBox>
            </td>
            <td style="width: 243px">Số Lượng </td>
            <td style="width: 147px"><asp:TextBox ID="txtSoLuong" runat="server" Width="98px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 64px">Mã Món</td>
            <td style="width: 90px">
                <asp:DropDownList ID="DropMaMon" runat="server">
                </asp:DropDownList>
            </td>
            <td style="width: 243px">Nhân Viên</td>
            <td style="width: 210px">
                <asp:DropDownList ID="DropMaNV" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 64px">Đơn Giá</td>
            <td style="width: 90px"><asp:TextBox ID="txtDonGia" runat="server"></asp:TextBox>
            </td>
            <td style="width: 243px">Khách Hàng </td>
            <td style="width: 210px">
                <asp:TextBox ID="TextKhachHang" runat="server" Width="100px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 64px">Ngày Tạo</td>
            <td style="width: 90px">
                <asp:TextBox ID="txtNgay" runat="server"></asp:TextBox>
            </td>
            <td style="width: 243px">Mã Bàn </td>
            <td>
                <asp:DropDownList ID="DropMaBan" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 64px">&nbsp;</td>
            <td style="width: 90px">&nbsp;</td>
            <td style="width: 243px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:ListBox ID="lsbTenSanPham" runat="server" Width="356px" OnSelectedIndexChanged="lsbTenSanPham_SelectedIndexChanged"></asp:ListBox>
            </td>
            <td colspan="2">
                <asp:ListBox ID="lsbThanhTien" runat="server" Width="383px" OnSelectedIndexChanged="lsbThanhTien_SelectedIndexChanged"></asp:ListBox>
            </td>
        </tr>
        <tr>
            <td colspan="2"><strong>
                <asp:Label ID="Label3" runat="server" ForeColor="#3333FF" Text="THANH TOÁN "></asp:Label>
                </strong></td>
            <td style="width: 243px" rowspan="3">
                <asp:Button ID="btnThem" runat="server" Text="THÊM MÓN " OnClick="btnThem_Click" ForeColor="#0066FF" style="margin-bottom: 19px" />
                <br />
                <asp:Button ID="BntTinh" runat="server" OnClick="BntTinh_Click" Text="TÍNH TIỀN " ForeColor="#0066FF" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 64px">&nbsp;</td>
            <td style="width: 90px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 64px">Tổng Tiền </td>
            <td style="width: 90px"><asp:TextBox ID="txtTongTien" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 64px">Tiền Mặt</td>
            <td style="width: 90px"><asp:TextBox ID="txtTienMat" runat="server"></asp:TextBox>
            </td>
            <td style="width: 243px" rowspan="2">
                <asp:Button ID="btnXoa" runat="server" Text="XÓA MÓN " OnClick="btnXoa_Click" ForeColor="#0066FF" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 64px">Tiền Trả </td>
            <td style="width: 90px"><asp:TextBox ID="txtTienTra" runat="server" ReadOnly="True" ></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" style="height: 56px">
                <asp:Label ID="Label1" runat="server" Text="Trạng Thái "></asp:Label>
            </td>
            <td style="width: 243px; height: 56px;">
                <asp:RadioButton ID="RadioButton1" runat="server" GroupName="g1" Text="Đã Tính " />
                <asp:RadioButton ID="RadioButton2" runat="server" GroupName="g1" Text="Chưa Tính" />
            </td>
            <td style="height: 56px"></td>
        </tr>
        <tr>
            <td style="height: 34px;" colspan="2">
                <asp:Button ID="btnThemPhieu" runat="server" OnClick="btnThemPhieu_Click" Text="THÊM PHIẾU " ForeColor="#0066FF" />
                <asp:Button ID="btnSuaPhieu" runat="server" style="margin-left: 29px" Text="SỬA PHIẾU " OnClick="btnSuaPhieu_Click" ForeColor="#0066FF" />
            </td>
            <td style="width: 243px; height: 34px;">
                <asp:Button ID="btnXoaPhieu" runat="server" Text="XÓA PHIẾU " OnClick="btnXoaPhieu_Click" ForeColor="#0066FF" />
            </td>
            <td style="height: 34px"></td>
        </tr>
        <tr>
            <td colspan="2" style="height: 52px">Tìm Kiếm Phiếu <asp:TextBox ID="txtTimKiem" runat="server" style="margin-left: 59px" Width="152px"></asp:TextBox>
            </td>
            <td style="width: 243px; height: 52px;">
                <asp:Button ID="btnTimKiem" runat="server" Text="TÌM KIẾM PHIẾU " OnClick="btnTimKiem_Click" ForeColor="#0066FF" />
            </td>
            <td style="height: 52px"></td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:GridView ID="dgPhieu" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4">
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
            <td colspan="3">
                <asp:Label ID="lbthongbao" runat="server" ForeColor="#FF3399" Height="20px"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

