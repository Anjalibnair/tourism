<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="admin_home.aspx.cs" Inherits="admin_home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/view_reg.aspx">Registration</asp:LinkButton>
    <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" 
        PostBackUrl="~/place_reg.aspx">Place _Reg</asp:LinkButton>
    <asp:LinkButton ID="LinkButton4" runat="server" 
        PostBackUrl="~/view_placereg.aspx">View_place</asp:LinkButton>
    <asp:LinkButton ID="LinkButton3" runat="server">Feedback</asp:LinkButton>
    <asp:LinkButton ID="LinkButton5" runat="server" PostBackUrl="~/gallery.aspx">Gallery</asp:LinkButton>
</asp:Content>

