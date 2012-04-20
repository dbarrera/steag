<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserHome.aspx.cs" Inherits="Steag.Web.Presentation.Security.UserHome" 
 MasterPageFile="~/Masters/AuthenticatedUser.Master" %>

 <asp:Content ID="ContentTitle" ContentPlaceHolderID="title" runat="server">
    STEAG Security Management System Home   
 </asp:Content>

 <asp:Content ID="ContentUserHome" ContentPlaceHolderID="MainContent" runat="server">    
    <div class="min-height-400">
        Hello Welcome to UserHome
    </div>
</asp:Content>

