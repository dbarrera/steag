<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SearchControl.ascx.cs" Inherits="Steag.Web.Presentation.Security.Controls.SearchControl" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<div class="height-50">
    <div class="fleft width-60">
        <span class="label-font">Search</span>
    </div>
    <div class="fleft">
        <telerik:RadComboBox ID="cboKey" runat="server">
        </telerik:RadComboBox>
    </div>
    <div class="fleft margin-left-10 width-320">
        <telerik:RadTextBox ID="txtSearch" runat="server" Width="100%">
        </telerik:RadTextBox>
    </div>
    <div class="fleft margin-left-10">
        <telerik:RadButton ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click">
        </telerik:RadButton>
    </div>
</div>