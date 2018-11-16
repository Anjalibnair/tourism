<%@ Page Title="" Language="C#" MasterPageFile="~/login.master" AutoEventWireup="true" CodeFile="food_pub.aspx.cs" Inherits="food_pub" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 137px;
        }
        .style3
        {
            width: 300px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td class="style2">
                TYPE</td>
            <td class="style3">
                <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" 
                    AutoPostBack="True" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged1">
                    <asp:ListItem>-SELECT-</asp:ListItem>
                    <asp:ListItem>VEG</asp:ListItem>
                    <asp:ListItem>NON-VEG</asp:ListItem>
                    <asp:ListItem>COOL &amp; HOT</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td rowspan="4">
                <asp:Image ID="Image1" runat="server" Height="110px" Width="168px" />
            </td>
        </tr>
        <tr>
            <td class="style2">
                NAME</td>
            <td class="style3">
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList2_SelectedIndexChanged" 
                    style="margin-bottom: 0px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style2">
                LOCATION</td>
            <td class="style3">
                <asp:TextBox ID="TextBox1" runat="server" ontextchanged="TextBox1_TextChanged" 
                    ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

