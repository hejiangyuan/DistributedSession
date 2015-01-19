<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DistributedPart1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script>
        function init() {
            var goUrl = document.getElementById('hidGoUrl').value;
            if (goUrl) {
                location.href = goUrl;
            }
        }
    </script>
</head>
<body onload="init()">
    <form id="form1" runat="server">
    <asp:HiddenField runat="server" ClientIDMode="Static" ID="hidGoUrl"/>
    <h1>Part1</h1>
    <p>
        <label>Name：</label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    </p>
    <p>
        <label>Pwd ：</label>
        <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </p>
    </form>
    
    <h4>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </h4>
</body>
</html>
