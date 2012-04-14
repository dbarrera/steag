<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginControl.ascx.cs" Inherits="Steag.Web.Presentation.Security.Controls.LoginControl" %>
<div id="divLoginControl">
    <div class="height-30">
        <div class="fleft width-80">
            <span class="label-font">Username</span>
        </div>
        <div class="fleft width-200">
            <asp:TextBox ID="txtUserName" runat="server" CssClass="width-200" />
        </div>
    </div>
    <div class="clear height-30">
        <div class="fleft width-80">
            <span class="label-font">Password</span>
        </div>
        <div class="fleft width-200">
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="width-200" />
        </div>
    </div>
    <div>
        <div class="fleft width-80">
        &nbsp;
        </div>
        <div class="fleft align-center width-200">
            <asp:Button ID="btnLogin" runat="server" Text="Login" 
                onclick="btnLogin_Click" />
        </div>
    </div>
</div>
