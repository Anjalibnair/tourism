<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="view_hotelreg.aspx.cs" Inherits="view_hotelreg" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">


        .style1
        {
            width: 100%;
        }
        .style23
        {
            width: 31px;
        }
        .style30
        {
            width: 223px;
        }
        .style2
        {
            width: 184px;
        }
        .style18
        {
            width: 31px;
            height: 25px;
        }
        .style25
        {
            width: 223px;
            height: 25px;
        }
        .style19
        {
            width: 31px;
            height: 26px;
        }
        .style26
        {
            width: 223px;
            height: 26px;
        }
        .style20
        {
            width: 31px;
            height: 30px;
        }
        .style27
        {
            width: 223px;
            height: 30px;
        }
        .style16
        {
            width: 184px;
        }
        .style21
        {
            width: 31px;
            height: 23px;
        }
        .style28
        {
            width: 223px;
            height: 23px;
        }
        .style31
        {
            width: 184px;
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:MultiView ID="MultiView1" runat="server">
        <asp:View ID="View1" runat="server">
            <asp:DataGrid ID="DataGrid1" runat="server" AutoGenerateColumns="False" 
                onitemcommand="DataGrid1_ItemCommand" 
                onselectedindexchanged="DataGrid1_SelectedIndexChanged">
                <Columns>
                    <asp:BoundColumn DataField="ID" HeaderText="ID"></asp:BoundColumn>
                    <asp:BoundColumn DataField="LOCATION" HeaderText="LOCATION"></asp:BoundColumn>
                    <asp:BoundColumn DataField="HOTEL_NAME" HeaderText="HOTEL_NAME">
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="ADDRESS" HeaderText="ADDRESS"></asp:BoundColumn>
                    <asp:BoundColumn DataField="PHONE" HeaderText="PHONE"></asp:BoundColumn>
                    <asp:BoundColumn DataField="EMAIL" HeaderText="EMAIL"></asp:BoundColumn>
                    <asp:BoundColumn DataField="ROOM" HeaderText="ROOM" Visible="False">
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="ROOM_AVAIL" HeaderText="ROOM_AVAIL" Visible="False">
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="IMAGE1" HeaderText="IMAGE1"></asp:BoundColumn>
                    <asp:BoundColumn DataField="IMAGE2" HeaderText="IMAGE2" Visible="False">
                    </asp:BoundColumn>
                    <asp:ButtonColumn Text="VIEW"></asp:ButtonColumn>
                </Columns>
            </asp:DataGrid>
        </asp:View>
        <asp:View ID="View2" runat="server">
            <table class="style1">
                <tr>
                    <td class="style23">
                        ID</td>
                    <td class="style30">
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    </td>
                    <td class="style2" rowspan="4">
                        <asp:Image ID="Image1" runat="server" Height="150px" Width="299px" />
                    </td>
                </tr>
                <tr>
                    <td class="style18">
                        LOCATION</td>
                    <td class="style25">
                        <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
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
                    <td class="style31">
                    </td>
                </tr>
                <tr>
                    <td class="style20">
                        EMAIL</td>
                    <td class="style27">
                        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                    </td>
                    <td class="style16" rowspan="2">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style21">
                        ROOM_TYPE</td>
                    <td class="style28">
                        <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style23">
                        &nbsp;</td>
                    <td class="style30">
                        &nbsp;</td>
                    <td class="style2">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style23">
                        &nbsp;</td>
                    <td class="style30">
                        <asp:Button ID="Button3" runat="server" onclick="Button3_Click1" 
                            Text="ACCEPT" />
                        <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="BLOCK" />
                    </td>
                    <td class="style2">
                        &nbsp;</td>
                </tr>
            </table>
        </asp:View>
    </asp:MultiView>
</asp:Content>

