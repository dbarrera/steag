<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SarfInputControl.ascx.cs" Inherits="Steag.Web.Presentation.Security.Controls.SarfInputControl" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>

<div class="fleft">
    <div class="fleft width-80">
        <span>SARF Code</span>
    </div>
    <div class="fleft">
        <asp:Literal ID="SarfCodeLiteral" runat="server"></asp:Literal>
    </div>
</div>
<div class="fleft">
    <span>Date Filed</span>
    <telerik:RadDatePicker ID="dateFiledDatePicker" runat="server">
        <Calendar>
            <SpecialDays>
                <telerik:RadCalendarDay Repeatable="Today" />
            </SpecialDays>
        </Calendar>
    </telerik:RadDatePicker>
</div>
<div>
    <span>Date of Visit</span>
    <telerik:RadDatePicker ID="dateOfVisitDatePicker" runat="server">
        <Calendar>
            <SpecialDays>
                <telerik:RadCalendarDay Repeatable="Today" />
            </SpecialDays>
        </Calendar>
    </telerik:RadDatePicker>
</div>
<div>
    <span>Purpose</span>
    <telerik:RadTextBox ID="purposeTextBox" runat="server" TextMode="MultiLine" AutoPostBack="false">
    </telerik:RadTextBox>
</div>
<div>
    <span>Status</span>
    <telerik:RadTextBox ID="statusTextBox" runat="server" AutoPostBack="false">
    </telerik:RadTextBox>
</div>
<div>
    <span>Date Visited</span>
    <telerik:RadDatePicker ID="dateVisitedDatePicker" runat="server">
        <Calendar>
            <SpecialDays>
                <telerik:RadCalendarDay Repeatable="Today" />
            </SpecialDays>
        </Calendar>
    </telerik:RadDatePicker>
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