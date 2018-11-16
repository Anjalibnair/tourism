<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="gallery.aspx.cs" Inherits="gallery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td>
                <asp:DataGrid ID="DataGrid1" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundColumn DataField="ID" HeaderText="ID"></asp:BoundColumn>
                        <asp:BoundColumn DataField="USER_ID" HeaderText="USER_ID" Visible="False">
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="IMAGE" HeaderText="IMAGE" Visible="False">
                        </asp:BoundColumn>
                        <asp:BoundColumn DataField="DISCRIPTION" HeaderText="DESCRIPTION">
                        </asp:BoundColumn>
                        <asp:TemplateColumn HeaderText="IMAGE">
                            <ItemTemplate>
                                <asp:Image ID="Image1" runat="server" Height="62px" 
                                    ImageUrl='<%# Eval("IMAGE") %>' Width="76px" />
                            </ItemTemplate>
                        </asp:TemplateColumn>
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
</asp:Content>

