<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginControl.ascx.cs" Inherits="Steag.Web.Presentation.Security.Controls.LoginControl" %>
<div id="loginControl-wrapper" class="margin-auto">
    <div id="loginControl-header" class="height-20 align-left">
        <span>
            LOGIN
        </span>
    </div>
    <div id="loginControl-div">   
        <div class="align-center padding-bottom-10">
            <span class="error-text">
                <asp:Literal ID="txtError" runat="server" />
            </span>
        </div> 
        <div class="login-row-height">
            <div class="fleft width-80">
                <span class="label-font">Username</span>
            </div>
            <div class="fleft width-200">
                <asp:TextBox ID="txtUserName" runat="server" CssClass="width-200" />
            </div>
        </div>
        <div class="login-row-height">
            <div class="fleft width-80">
                <span class="label-font">Password</span>
            </div>
            <div class="fleft width-200">
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="width-200" />
            </div>
        </div>
        <div class="login-row-height">
            <div class="fleft width-80">
            &nbsp;
            </div>
            <div class="fleft align-right width-200">
                <asp:Button ID="btnLogin" class="btn-action" runat="server" Text="Log In" 
                    onclick="btnLogin_Click" />
            </div>
        </div>
    </div>
</div>