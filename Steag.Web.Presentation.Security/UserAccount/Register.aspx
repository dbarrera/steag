<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Steag.Web.Presentation.Security.UserAccount.Register" 
MasterPageFile="~/Masters/AuthenticatedUser.Master" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register assembly="Steag.Web.Presentation.Security" namespace="Steag.Web.Presentation.Security.Controls" tagprefix="cc1" %>

<asp:Content ID="contentTitle" runat="server" EnableViewState="false" ContentPlaceHolderID="title">
    STEAG Security Management System - Register User
</asp:Content>

<asp:Content ID="contentMain" runat="server" ContentPlaceHolderID="MainContent">
    <span class="heading-5">System User Registration</span>
    <hr class="line-rule" />

    <div>
        <asp:ValidationSummary ID="valSummary" runat="server" CssClass="validation-summary" />    
        <div class="invisible">
            <asp:CustomValidator ID="valConfirmPassword" runat="server" CssClass="validation-summary" Visible="true"
                ErrorMessage="Password didn't match" Text="*" OnServerValidate="valConfirmPassword_Validate" 
                ValidateEmptyText="True" ControlToValidate="txtPassword" />
            <asp:CustomValidator ID="valCheckUsername" runat="server" CssClass="validation-summary" Visible="true"
                ErrorMessage="Username already exists" Text="*" OnServerValidate="valCheckUsername_Validate" 
                ValidateEmptyText="True" ControlToValidate="txtUsername" />
        </div>    
    </div>

    <div class="height-39 margin-top-40">
        <div class="fleft width-120">
            <span class="label-font">Username</span>
        </div>
        <div class="fleft width-10">
            <asp:RequiredFieldValidator runat="server" ID="valUsername" ErrorMessage="Username is Required" Text="*"
                ControlToValidate="txtUsername" CssClass="validator" />
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
        <div class="fleft width-10">
            <asp:RequiredFieldValidator runat="server" ID="valUserRole" ErrorMessage="UserRole is Required" Text="*"
                ControlToValidate="cboUserRole" CssClass="validator" />
        </div>
        <div class="fleft">
            <cc1:UserRoleDropDown ID="cboUserRole" runat="server" />
        </div>
    </div>

    <div class="height-39">
        <div class="fleft width-120">
            <span class="label-font">Password</span>
        </div>
        <div class="fleft width-10">
            <asp:RequiredFieldValidator runat="server" ID="valPassword" ErrorMessage="Password is Required" Text="*"
                ControlToValidate="txtPassword" CssClass="validator" />
        </div>
        <div class="fleft width-200">
            <telerik:RadTextBox ID="txtPassword" runat="server" Width="100%"  TextMode="Password">
            </telerik:RadTextBox>
        </div>
    </div>  

    <div class="height-39">
        <div class="fleft width-120">
            <span class="label-font">Confirm Password</span>
        </div>
        <div class="fleft width-10">
            &nbsp;
        </div>
        <div class="fleft width-200">
            <telerik:RadTextBox ID="txtConfirmPassword" runat="server" Width="100%" TextMode="Password">
            </telerik:RadTextBox>
        </div>
    </div>  
    
    <div class="height-39 clear">
        <div class="fleft width-120">
            <span class="label-font">First Name</span>
        </div>
        <div class="fleft width-10">
            <asp:RequiredFieldValidator runat="server" ID="valFirstName" ErrorMessage="Firstname is Required" Text="*"
                ControlToValidate="txtFirstName" CssClass="validator" />
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
        <div class="fleft width-10">
            &nbsp;
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
        <div class="fleft width-10">
            <asp:RequiredFieldValidator runat="server" ID="valLastName" ErrorMessage="Lastname is Required" Text="*"
                ControlToValidate="txtLastName" CssClass="validator" />
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
        <div class="fleft width-10">
            &nbsp;
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
            <telerik:RadButton ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" CausesValidation="true" />
            
            <telerik:RadButton ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" CausesValidation="false" />            
        </div>
    </div>

</asp:Content>



