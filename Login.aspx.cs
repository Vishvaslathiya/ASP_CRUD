using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["email"] != null)
        {
            Response.Redirect("Dashboard.aspx");
        }
    }

    protected void login_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=VISHVAS;Initial Catalog=Friday;Integrated Security=True;");
        con.Open();
        String logEmail = logemail.Text;
        String logPass = logpassword.Text;
        String loginQuery = "select * from tbl_student where email = '" + logEmail + "' and pass = '" + logPass + "' ;";
        SqlCommand cmd = new SqlCommand(loginQuery,con);
        int isloged = (int)cmd.ExecuteScalar();

        if (isloged>0)
        {
            Session["email"]= logEmail;
            Session["password"]= logPass;
            Response.Write("<script>alert('Login Successful')</script>");
            Response.Redirect("Dashboard.aspx");
        }
        else
        {
            Response.Write("<script>alert('Login Failed')</script>");
        }
        con.Close();

    }
}
