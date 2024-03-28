using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void register_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=VISHVAS;Initial Catalog=Friday;Integrated Security=True;");
        con.Open();
        String sname = name.Text;
        String semail = email.Text;
        String spass = pass.Text;
        String gen = Findgender();
        String insertQuery = "insert into tbl_student values( '"+sname+"' , '"+semail+"','"+spass + "','"+gen+"')";
        SqlCommand cmd = new SqlCommand(insertQuery, con);
        cmd.ExecuteNonQuery();
        Response.Write("<script>alert('Registration Successful')</script>");
        con.Close();

        Response.Redirect("Login.aspx");

    }
    protected String Findgender()
    {
        if (male.Checked)
        {
            return male.Text;
        }
        else if(female.Checked)
        {
            return female.Text;
        }
        else
        {
            return null;
        }
    }
}