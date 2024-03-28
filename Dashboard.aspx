<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Dashboard.aspx.cs" Inherits="Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dashboard</title>
    <script type="text/javascript">
        window.onload = function () {
            if (window.history && window.history.pushState) {
                window.history.pushState('forward', null, './#');
                window.onpopstate = function () {
                    if (sessionStorage.getItem("email")) {
                        window.location.href = "Dashboard.aspx";
                    } else {
                        window.history.pushState('forward', null, './#');
                    }
                };
            }
        };
</script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 style="text-align:center">View All Student Details</h2>
            <table>
                <thead>
                    <tr>
                        <th>Student ID</th>
                        <th>Student Name</th>
                        <th>Student Email</th>
                        <th>Student Password</th>
                        <th>Student Gender</th>
                        <th>Actions</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="dispalyStudents" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("id") %></td>
                                <td><%# Eval("name") %></td>
                                <td><%# Eval("email") %></td>
                                <td><%# Eval("pass") %></td>
                                <td><%# Eval("gender") %></td>
                                <td>
                                    <a href="Update.aspx?uid=<%# Eval("id") %>">Edit</a>
                                    <a href="Delete.aspx?did=<%# Eval("id") %>">Delete</a>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </div>
    </form>
</body>
</html>

