<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SarfInputControl.ascx.cs" Inherits="Steag.Web.Presentation.Security.Controls.SarfInputControl" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>

<span class="heading-5">SARF Entry</span>
<hr class="line-rule" />



<div class="height-39 margin-top-40">
    <div class="fleft width-120">
        <span class="label-font">SARF Code</span>
    </div>
    <div class="fleft width-10">
        &nbsp;
    </div>
    <div class="fleft width-200">
        <asp:Literal ID="SarfCodeLiteral" runat="server"></asp:Literal>
    </div>
</div>

<div class="height-39">
    <div class="fleft width-120">
        <span class="label-font">Date Filed</span>
    </div>    
    <div class="fleft width-10">
        &nbsp;
    </div>
    <div class="fleft width-200">
        <telerik:RadDatePicker ID="dateFiledDatePicker" runat="server" Width="100%">
            <Calendar>
                <SpecialDays>
                    <telerik:RadCalendarDay Repeatable="Today" />
                </SpecialDays>
            </Calendar>
        </telerik:RadDatePicker>
    </div>
</div>

<div class="height-39">
    <div class="fleft width-120">
        <span class="label-font">Date of Visit</span>
    </div>  
    <div class="fleft width-10">
        &nbsp;
    </div>
    <div class="fleft width-200">
        <telerik:RadDatePicker ID="dateOfVisitDatePicker" runat="server" Width="100%">
            <Calendar>
                <SpecialDays>
                    <telerik:RadCalendarDay Repeatable="Today" />
                </SpecialDays>
            </Calendar>
        </telerik:RadDatePicker>
    </div>
</div>

<div class="height-auto">
    <div class="fleft width-120">
        <span class="label-font">Purpose</span>
    </div>  
    <div class="fleft width-10">
        &nbsp;
    </div>
    <div class="fleft width-200">
        <telerik:RadTextBox ID="purposeTextBox" runat="server" TextMode="MultiLine" AutoPostBack="false" Width="100%">
        </telerik:RadTextBox>
    </div>
</div>

<div class="padding-top-15 clear"></div>

<div class="height-39">
    <div class="fleft width-120">
        <span class="label-font">Status</span>
    </div>  
    <div class="fleft width-10">
        &nbsp;
    </div>
    <div class="fleft width-200">
        <%--Please make this into combo box with the following values (New, Created)--%>
        <telerik:RadTextBox ID="statusTextBox" runat="server" AutoPostBack="false">
        </telerik:RadTextBox>
    </div>
</div>

<div class="height-39">
    <div class="fleft width-120">
        <span class="label-font">Date Visited</span>
    </div>  
    <div class="fleft width-10">
        &nbsp;
    </div>
    <div class="fleft width-200">
        <telerik:RadDatePicker ID="dateVisitedDatePicker" runat="server" Width="100%">
            <Calendar>
                <SpecialDays>
                    <telerik:RadCalendarDay Repeatable="Today" />
                </SpecialDays>
            </Calendar>
        </telerik:RadDatePicker>
    </div>
</div>
<%--
SARFCode - nvarchar(60)
DateFiled - datetime
DateOfVisit - datetime
FiledBy - bigint
Purpose - nvarchar(250)
SourceIP - nvarchar(60)
Status - nvarchar(60)
ApprovedBy - bigint
DateVisited - datetime
VisitVerifiedBy - bigint
IsActive - bit
UserCreated - bigint
DateCreated - datetime
UserModified - bigint
DateModified - datetime
--%>