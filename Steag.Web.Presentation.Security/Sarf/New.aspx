<%@ Page Title="STEAG Security Management System SARF" Language="C#" AutoEventWireup="true" CodeBehind="New.aspx.cs" 
Inherits="Steag.Web.Presentation.Security.Sarf.New" MasterPageFile="~/Masters/AuthenticatedUser.Master" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register Src="~/Controls/SarfInputControl.ascx" TagName="SarfInput" TagPrefix="steag" %>


<asp:Content ID="SarfTitle" ContentPlaceHolderID="title" runat="server">
    STEAG Security Management System - SARF Entry
</asp:Content>

<asp:Content ID="HeadSarf" ContentPlaceHolderID="head" runat="server">
    <%-- Register your scripts here (javascripts, css) --%>
</asp:Content>

<asp:Content ID="ContentSarf" ContentPlaceHolderID="MainContent" runat="server">
    
    <steag:SarfInput ID="SarfControl" runat="server" />
    
    <div class="fleft width-120">
        &nbsp;
    </div>  
    <div class="fleft width-10">
        &nbsp;
    </div>
    <div class="fleft width-200 align-right">
        <telerik:RadButton ID="AddSarfButton" runat="server" Text="Add" onclick="AddSarfButton_Click">
        </telerik:RadButton>

        <telerik:RadButton ID="btnCancel" runat="server" Text="Cancel">
        </telerik:RadButton>
    </div>

</asp:Content>

