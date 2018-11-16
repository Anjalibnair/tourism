<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="view_feedback.aspx.cs" Inherits="view_feedback" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DataGrid ID="DataGrid1" runat="server" AutoGenerateColumns="False" 
        onitemcommand="DataGrid1_ItemCommand">
        <Columns>
            <asp:BoundColumn DataField="ID" HeaderText="ID"></asp:BoundColumn>
            <asp:BoundColumn DataField="FEEDBACK" HeaderText="FEEDBACK"></asp:BoundColumn>
            <asp:BoundColumn DataField="SUGGESTION" HeaderText="SUGGESTION">
            </asp:BoundColumn>
            <asp:ButtonColumn Text="delete"></asp:ButtonColumn>
        </Columns>
    </asp:DataGrid>
</asp:Content>

