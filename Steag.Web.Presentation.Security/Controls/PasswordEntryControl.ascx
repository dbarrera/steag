<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PasswordEntryControl.ascx.cs" Inherits="Steag.Web.Presentation.Security.Controls.PasswordEntryControl" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<div class="fleft width-120 height-39">
    <span class="label-font">Password</span>
</div>
<div class="fleft height-39 width-200">
    <telerik:RadTextBox ID="txtPassword" runat="server" Width="100%" TextMode="Password">
    </telerik:RadTextBox>
</div>
<div class="clear"></div>
<div class="fleft width-120 height-39">
    <span class="label-font">Confirm Password</span>
</div>
<div class="fleft height-39  width-200">
    <telerik:RadTextBox ID="txtConfirmPassword" runat="server" Width="100%" TextMode="Password">
    </telerik:RadTextBox>
</div>
