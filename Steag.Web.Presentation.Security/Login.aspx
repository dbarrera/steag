<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Steag.Web.Presentation.Security.Login" %>


<%@ Register src="Controls/LoginControl.ascx" tagname="LoginControl" tagprefix="steag" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="divLogin">        
        <steag:LoginControl ID="loginControl" runat="server" OnLogin="loginControl_Login" />
    </div>
    </form>
</body>
</html>
