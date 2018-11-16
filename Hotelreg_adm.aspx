<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="Hotelreg_adm.aspx.cs" Inherits="Hotelreg_adm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 184px;
        }
        .style16
        {
            width: 184px;
        }
        .style18
        {
            width: 31px;
            height: 25px;
        }
        .style19
        {
            width: 31px;
            height: 26px;
        }
        .style20
        {
            width: 31px;
            height: 30px;
        }
        .style21
        {
            width: 31px;
            height: 23px;
        }
        .style22
        {
            width: 31px;
            height: 28px;
        }
        .style23
        {
            width: 31px;
        }
        .style25
        {
            width: 223px;
            height: 25px;
        }
        .style26
        {
            width: 223px;
            height: 26px;
        }
        .style27
        {
            width: 223px;
            height: 30px;
        }
        .style28
        {
            width: 223px;
            height: 23px;
        }
        .style29
        {
            width: 223px;
            height: 28px;
        }
        .style30
        {
            width: 223px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td class="style23">
                ID</td>
            <td class="style30">
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            </td>
            <td class="style2" rowspan="4">
                <asp:Image ID="Image1" runat="server" Height="111px" Width="274px" />
            </td>
        </tr>
        <tr>
            <td class="style18">
                LOCATION</td>
            <td class="style25">
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style19">
                HOTEL_NAME</td>
            <td class="style26">
                <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style23">
                ADDRESS</td>
            <td class="style30">
                <asp:TextBox ID="TextBox9" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style20">
                PHONE</td>
            <td class="style27">
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
            </td>
            <td class="style16">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style20">
                EMAIL</td>
            <td class="style27">
                <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
            </td>
            <td class="style16" rowspan="3">
                <asp:Image ID="Image2" runat="server" Height="111px" Width="275px" />
            </td>
        </tr>
        <tr>
            <td class="style21">
                ROOM_TYPE</td>
            <td class="style28">
                <asp:CheckBox ID="CheckBox1" runat="server" Text="A/C" />
                <asp:CheckBox ID="CheckBox2" runat="server" Text="NON A/C" />
                <asp:CheckBox ID="CheckBox3" runat="server" Text="SINGLE" />
                <asp:CheckBox ID="CheckBox4" runat="server" Text="DOUBLE" />
                <asp:CheckBox ID="CheckBox5" runat="server" Text="FAMILY" />
            </td>
        </tr>
        <tr>
            <td class="style22">
                ROOM_AVAIL</td>
            <td class="style29">
                <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style23">
                IMAGE</td>
            <td class="style30">
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="UPLOAD" />
            </td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style23">
                IMAGE</td>
            <td class="style30">
                <asp:FileUpload ID="FileUpload2" runat="server" />
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="UPLOAD" />
            </td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style23">
                &nbsp;</td>
            <td class="style30">
                <asp:Button ID="Button3" runat="server" onclick="Button3_Click1" 
                    Text="SUBMIT" />
            </td>
            <td class="style2">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

