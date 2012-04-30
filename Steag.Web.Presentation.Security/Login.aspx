<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Steag.Web.Presentation.Security.Login"
 MasterPageFile="~/Masters/Default.Master" %>

<%@ Register src="~/Controls/LoginControl.ascx" tagname="LoginControl" tagprefix="steag" %>

<asp:Content ID="ContentTitle" ContentPlaceHolderID="title" runat="server">
    STEAG Security Management System Login
</asp:Content>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">    
    <div class="min-height-300">
        <div id="divLogin" class="align-center">        
            <steag:LoginControl ID="loginControl" runat="server" OnLogin="loginControl_Login" />
        </div>
    </div>
</asp:Content>

    


