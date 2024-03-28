<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="align-items:center; padding:5px; box-sizing:border-box; color:aliceblue; background-color:red ">
            <asp:TextBox ID="name" runat="server" placeholder="Enter Name : "></asp:TextBox>
            <br />
            <asp:TextBox ID="email" runat="server" placeholder="Enter Email : "></asp:TextBox>
            <br />
            <asp:TextBox ID="pass" runat="server" placeholder="Enter Password : "></asp:TextBox>
            <br />
            <asp:RadioButton ID="male" runat="server" Text="Male" />
            <asp:RadioButton ID="female" runat="server" Text="female" />
            <br />
            <asp:Button ID="register" runat="server" Text="Register Now" OnClick="register_Click" />
        </div>
    </form>
</body>
</html>
