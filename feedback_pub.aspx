<%@ Page Title="" Language="C#" MasterPageFile="~/login.master" AutoEventWireup="true" CodeFile="feedback_pub.aspx.cs" Inherits="feedback_pub" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 172px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <asp:MultiView ID="MultiView1" runat="server">
        <asp:View ID="View1" runat="server">

            <table class="style1">
                <tr>
                    <td>
                        <asp:DataGrid ID="DataGrid1" runat="server" AutoGenerateColumns="False" 
                            onitemcommand="DataGrid1_ItemCommand" 
                            onselectedindexchanged="DataGrid1_SelectedIndexChanged">
                            <Columns>
                                <asp:BoundColumn DataField="ID" HeaderText="ID" Visible="False">
                                </asp:BoundColumn>
                                <asp:BoundColumn DataField="NAME" HeaderText="User Name"></asp:BoundColumn>
                                <asp:BoundColumn DataField="FEEDBACK" HeaderText="feedback" Visible="False">
                                </asp:BoundColumn>
                                <asp:BoundColumn DataField="SUGGESTION" HeaderText="suggestion" Visible="False">
                                </asp:BoundColumn>
                                <asp:ButtonColumn Text="VIEW"></asp:ButtonColumn>
                            </Columns>
                        </asp:DataGrid>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>

        </asp:View>
        <asp:View ID="View2" runat="server">
        <table class="style1">
        <tr>
            <td class="style2">
                User Name</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" ontextchanged="TextBox3_TextChanged" 
                    ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
            <tr>
                <td class="style2">
                    FEEDBACK</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" ontextchanged="TextBox1_TextChanged" 
                        ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
        <tr>
            <td class="style2">
                SUGGESTION</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
    </table>
        </asp:View>
    </asp:MultiView>
    
</asp:Content>

