<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="DistributedPart1.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>
        Home1
    </h1>
        
    <h2>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </h2>
        
    <p>
        <a href="/Logout.aspx">logout</a>
    </p>
        
        <h4>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </h4>
    </form>
</body>
</html>
