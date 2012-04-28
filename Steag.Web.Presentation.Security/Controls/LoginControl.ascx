<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginControl.ascx.cs" Inherits="Steag.Web.Presentation.Security.Controls.LoginControl" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

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
                <telerik:RadTextBox ID="txtUserName" runat="server" Width="100%">
                </telerik:RadTextBox>
            </div>
        </div>
        <div class="login-row-height">
            <div class="fleft width-80">
                <span class="label-font">Password</span>
            </div>
            <div class="fleft width-200">
                 <telerik:RadTextBox ID="txtPassword" runat="server" Width="100%" TextMode="Password">
                </telerik:RadTextBox>
            </div>
        </div>
        <div class="login-row-height">
            <div class="fleft width-80">
            &nbsp;
            </div>
            <div class="fleft align-right width-200">
                <telerik:RadButton ID="btnLogin" runat="server" Text="Log In" onclick="btnLogin_Click">
                </telerik:RadButton>
            </div>
        </div>
    </div>
</div>