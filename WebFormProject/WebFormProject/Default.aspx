<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormProject._Default" %>
<%@ Reference Control="~/UserControl/UserInfoBoxControl.ascx" %>
<%@ Register TagPrefix="My" TagName="EventUserControl" Src="~/UserControl/EventUserControl.ascx" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <%--<asp:PlaceHolder runat="server" ID="phUserInfoBox" />--%>
    <My:EventUserControl runat="server" ID="MyEventUserControl" OnPageTitleUpdated="MyEventUserControl_PageTitleUpdated" />

</asp:Content>

