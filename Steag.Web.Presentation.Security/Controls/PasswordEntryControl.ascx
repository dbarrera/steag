<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PasswordEntryControl.ascx.cs" Inherits="Steag.Web.Presentation.Security.Controls.PasswordEntryControl" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<div class="fleft width-120">
    <span class="label-font">Password</span>
</div>
<div class="fleft">
    <telerik:RadTextBox ID="txtPassword" runat="server">
    </telerik:RadTextBox>
</div>
<div class="clear"></div>
<div class="fleft width-120">
    <span class="label-font">Confirm Password</span>
</div>
<div class="fleft">
    <telerik:RadTextBox ID="txtConfirmPassword" runat="server">
    </telerik:RadTextBox>
</div>
