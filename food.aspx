<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="food.aspx.cs" Inherits="food" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 174px;
        }
        .style3
        {
            width: 337px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td class="style2">
                ID</td>
            <td class="style3">
                <asp:TextBox ID="TextBox1" runat="server" Height="22px" ReadOnly="True"></asp:TextBox>
            </td>
            <td rowspan="4">
                <asp:Image ID="Image1" runat="server" Height="175px" Width="265px" />
            </td>
        </tr>
        <tr>
            <td class="style2">
                REST_NAME</td>
            <td class="style3">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="TextBox5" ErrorMessage="*must fill" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                LOCATION</td>
            <td class="style3">
                <asp:DropDownList ID="DropDownList3" runat="server" 
                    onselectedindexchanged="DropDownList3_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="DropDownList3" ErrorMessage="*must fill" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                TYPE</td>
            <td class="style3">
                <asp:CheckBox ID="CheckBox1" runat="server" Text="VEG" />
                <asp:CheckBox ID="CheckBox2" runat="server" Text="NON-VEG" />
                <asp:CheckBox ID="CheckBox3" runat="server" Text="BAKERY" />
            </td>
        </tr>
        <tr>
            <td class="style2">
                IMAGE</td>
            <td class="style3">
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click1" 
                    Text="UPLOAD" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="SUBMIT" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

