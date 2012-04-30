<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditPassword.aspx.cs" Inherits="Steag.Web.Presentation.Security.UserAccount.EditPassword"
MasterPageFile="~/Masters/AuthenticatedUser.Master" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<asp:Content ID="contentTitle" runat="server" EnableViewState="false" ContentPlaceHolderID="title">
    STEAG Security Management System - Edit User Password
</asp:Content>

<asp:Content ID="contentMain" runat="server" ContentPlaceHolderID="MainContent">
    <span class="heading-5">Edit User Password</span>
    <hr class="line-rule" />

    <div class="clear">
        <asp:ValidationSummary ID="valSummary" runat="server" CssClass="validation-summary" />        
        <div class="invisible">
            <asp:CustomValidator ID="valConfirmPassword" runat="server" CssClass="validation-summary" Visible="true"
                ErrorMessage="Password didn't match" Text="*" OnServerValidate="valConfirmPassword_Validate" 
                ValidateEmptyText="True" ControlToValidate="txtPassword" />
        </div>         
    </div>

    <div class="height-39 margin-top-40" id="divOldPassword" runat="server">
        <div class="fleft width-120">
            <span class="label-font">Old Password</span>
        </div>
        <div class="fleft width-10">
            <asp:RequiredFieldValidator runat="server" ID="valPassword" ErrorMessage="Old Password is Required" Text="*"
                ControlToValidate="txtOldPassword" CssClass="validator" />
             <div class="invisible">
                <asp:CustomValidator ID="valCheckOldPassword" runat="server" CssClass="validation-summary" Visible="true"
                    ErrorMessage="Invalid Current Password" Text="*" OnServerValidate="valCheckOldPassword_Validate" 
                    ValidateEmptyText="True" />
             </div>             
        </div>
        <div class="fleft width-200">
            <telerik:RadTextBox ID="txtOldPassword" runat="server" Width="100%" TextMode="Password">
            </telerik:RadTextBox>
        </div>
    </div>    

    <div class="height-39">
        <div class="fleft width-120">
            <span class="label-font">Password</span>
        </div>
        <div class="fleft width-10">
            <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ErrorMessage="Password is Required" Text="*"
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