<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Steag.Web.Presentation.Security.UserAccount.Register" 
MasterPageFile="~/Masters/AuthenticatedUser.Master" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register assembly="Steag.Web.Presentation.Security" namespace="Steag.Web.Presentation.Security.Controls" tagprefix="cc1" %>
<%@ Register src="~/Controls/PasswordEntryControl.ascx" tagname="PasswordEntryControl" tagprefix="steag" %>

<asp:Content ID="contentTitle" runat="server" EnableViewState="false" ContentPlaceHolderID="title">
    STEAG Security Management System - Register User
</asp:Content>

<asp:Content ID="contentMain" runat="server" ContentPlaceHolderID="MainContent">
    <span class="heading-5">System User Registration</span>
    <hr class="line-rule" />
    <div class="height-39 margin-top-40">
        <div class="fleft width-120">
            <span class="label-font">Username</span>
        </div>
        <div class="fleft width-200">
            <telerik:RadTextBox ID="txtUsername" runat="server" Width="100%">
            </telerik:RadTextBox>
        </div>
    </div>    

    <div class="clear height-39">
        <div class="fleft width-120">
            <span class="label-font">User Role</span>
        </div>
        <div class="fleft">
            <cc1:UserRoleDropDown ID="cboUserRole" runat="server" />
        </div>
    </div>

    <div class="clear">
        <steag:PasswordEntryControl ID="txtPassword" runat="server" />
    </div>    
    
    <div class="height-39 clear">
        <div class="fleft width-120">
            <span class="label-font">First Name</span>
        </div>
        <div class="fleft width-200">
            <telerik:RadTextBox ID="txtFirstName" runat="server" Width="100%">
            </telerik:RadTextBox>
        </div>
    </div>    

    <div class="height-39 clear">
        <div class="fleft width-120">
            <span class="label-font">Middle Name</span>
        </div>
        <div class="fleft width-200">
            <telerik:RadTextBox ID="txtMiddleName" runat="server" Width="100%">
            </telerik:RadTextBox>
        </div>
    </div>    

    <div class="height-39 clear">
        <div class="fleft width-120">
            <span class="label-font">Last Name</span>
        </div>
        <div class="fleft width-200">
            <telerik:RadTextBox ID="txtLastName" runat="server" Width="100%">
            </telerik:RadTextBox>
        </div>
    </div>    
    
    <div class="height-39 clear">
        <div class="fleft width-120">
            <span class="label-font">Email Address</span>
        </div>
        <div class="fleft width-200">
            <telerik:RadTextBox ID="txtEmailAddress" runat="server" Width="100%">
            </telerik:RadTextBox>
        </div>
    </div>    

    <div class="height-39 clear width-320">
        <div class="fleft width-120">
            &nbsp;
        </div>
        <div class="fleft width-200 align-right">
            <telerik:RadButton ID="btnSubmit" runat="server" Text="Submit">
            </telerik:RadButton>
             <telerik:RadButton ID="btnCancel" runat="server" Text="Cancel">
            </telerik:RadButton>
        </div>
    </div>

</asp:Content>



