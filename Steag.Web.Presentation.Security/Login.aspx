<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Steag.Web.Presentation.Security.Login" %>


<%@ Register src="Controls/LoginControl.ascx" tagname="LoginControl" tagprefix="steag" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div id="divLoginHeader">
        <div id="divLoginLogo" class="fleft">
            <img src="images/steaglogo-small.png" alt="STEAG Stage Power Inc." />
        </div>
        <div id="divLoginCaption" class="fleft padding-left-30 padding-top-30">
            <span class="heading-1">
                Security Management System
            </span>
        </div>
    </div>
    <div class="clear"></div>
    <div class="margin-auto width-500">
        <form id="formMain" runat="server">
        <div id="divLogin" class="align-center">        
            <steag:LoginControl ID="loginControl" runat="server" OnLogin="loginControl_Login" />
        </div>
        </form>
    </div>
    <div id="divLoginFooter">
    </div>
</body>
</html>
