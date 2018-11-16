<%@ Page Title="" Language="C#" MasterPageFile="~/login.master" AutoEventWireup="true" CodeFile="place_pub.aspx.cs" Inherits="place_pub" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 326px;
        }
        .style3
        {
            width: 234px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table __designer:mapid="13" class="style1">
        <tr __designer:mapid="14">
            <td __designer:mapid="15" class="style2">
                NAME</td>
            <td __designer:mapid="16" class="style3">
                <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True" 
                    AutoPostBack="True" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td __designer:mapid="20" rowspan="4">
                &nbsp;</td>
        </tr>
        <tr __designer:mapid="17">
            <td __designer:mapid="18" class="style2">
                LOCATION</td>
            <td __designer:mapid="19" class="style3">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr __designer:mapid="1a">
            <td __designer:mapid="1b" class="style2">
                CULTURAL INFO</td>
            <td __designer:mapid="1c" class="style3">
                <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" 
                    ontextchanged="TextBox3_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr __designer:mapid="24">
            <td __designer:mapid="25" class="style2">
                &nbsp;</td>
            <td __designer:mapid="26" class="style3">
                &nbsp;</td>
        </tr>
    </table>
                <asp:Image ID="Image1" runat="server" Height="186px" Width="226px" />
            </asp:Content>

