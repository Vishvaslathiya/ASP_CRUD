<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Update.aspx.cs" Inherits="Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div style="align-items: center; padding: 5px; box-sizing: border-box; color: aliceblue; background-color: red">
                <asp:TextBox ID="ename" runat="server" placeholder="Enter New Name : "></asp:TextBox>
                <br />
                <asp:TextBox ID="eemail" runat="server" placeholder="Enter New Email : "></asp:TextBox>
                <br />
                <asp:TextBox ID="epass" runat="server" placeholder="Enter New Password : "></asp:TextBox>
                <br />
                <asp:RadioButton ID="male" runat="server" Text="Male" />
                <asp:RadioButton ID="female" runat="server" Text="female" />
                <br />
                <asp:Button ID="update" runat="server" Text="Update" OnClick="update_Click" />
            </div>

        </div>
    </form>
</body>
</html>
