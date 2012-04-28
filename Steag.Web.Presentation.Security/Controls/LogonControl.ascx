<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LogonControl.ascx.cs" Inherits="Steag.Web.Presentation.Security.Controls.LogonControl" %>

<ul id="logon-ul">
    <li>
        Welcome <asp:Literal ID="txtUser" runat="server" EnableViewState="false" />
    </li>
    <li>
        <a runat="server" href="~/UserHome.aspx">
            Home
        </a>
    </li>
    <li>
        <a href="~/AccountSettings.aspx">
            Account Settings
        </a>
    </li>
    <li>
        <a runat="server" id="lnkLogout" href="~/Logout.aspx">
            Logout
        </a>
    </li>
</ul>