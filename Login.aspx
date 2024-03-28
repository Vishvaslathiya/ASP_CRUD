<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="logemail" placeholder="Enter Email" />
            <br />
            <asp:TextBox ID="logpassword" runat="server" placeholder="Enter Password"></asp:TextBox>
            <br />
            <asp:Button ID="login" runat="server" Text="Login" OnClick="login_Click" />


        </div>
    </form>
</body>
</html>
