<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="user_home.aspx.cs" Inherits="user_home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click" 
        PostBackUrl="~/place_reg.aspx">Place_reg</asp:LinkButton>
    <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/feedback.aspx">Feedback&amp;Suggestion</asp:LinkButton>
    <asp:LinkButton ID="LinkButton4" runat="server" 
        PostBackUrl="~/transportation.aspx">Transportation</asp:LinkButton>
    <asp:LinkButton ID="LinkButton5" runat="server" PostBackUrl="~/upload_img.aspx">Images</asp:LinkButton>
    <asp:LinkButton ID="LinkButton6" runat="server" PostBackUrl="~/hotel_reg.aspx">Hotel</asp:LinkButton>
    <asp:LinkButton ID="LinkButton7" runat="server" PostBackUrl="~/food.aspx">Food</asp:LinkButton>
</asp:Content>

