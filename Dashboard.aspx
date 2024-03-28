<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Dashboard.aspx.cs" Inherits="Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 style="text-align:center">View All Student Details</h2>
            <asp:Repeater ID="dispalyStudents" runat="server">
                
                <HeaderTemplate>
                    <th>

                        <tr><strong>Student Name</strong></tr>
                        <tr><strong>Student Email</strong></tr>
                        <tr><strong>Student Password</strong></tr>
                    </th>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td> <%# Eval("id") %> </td>
                        <td> <%# Eval("name") %> </td>
                        <td> <%# Eval("email") %> </td>
                        <td> <%# Eval("pass") %> </td>
                        <td> <%# Eval("gender") %> </td>

                        <td>
                            <a href="edit_student.aspx?uid=<%# Eval("id") %>" >Edit</a>
                            <a href="delete_student.aspx?did=<%# Eval("id") %>" >Delete</a>

                        </td>



                        
                    </tr>
                </ItemTemplate>
            </asp:Repeater>

        </div>
    </form>
</body>
</html>
