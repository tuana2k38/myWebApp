<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormProject._Default" %>
<%@ Reference Control="~/UserControl/UserInfoBoxControl.ascx" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:PlaceHolder runat="server" ID="phUserInfoBox" />

</asp:Content>

