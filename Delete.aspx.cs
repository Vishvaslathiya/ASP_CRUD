using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Delete : System.Web.UI.Page
{
    String conString = "Data Source=VISHVAS;Initial Catalog=Friday;Integrated Security=True;";
    protected void Page_Load(object sender, EventArgs e)
    {

        if(!IsPostBack)
        {
            int delid = Convert.ToInt32(Request.QueryString["did"]);

            if (delid != 0)
            {
                DropUser();
            }
        }
    }

    private void DropUser()
    {
        int delid = Convert.ToInt32(Request.QueryString["did"]);

        using (SqlConnection con = new SqlConnection(conString))
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from tbl_student where id = "+ delid +";",con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                Response.Write("<script>alert('User Dropped')</script>");
                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                Response.Write("<script>alert('NOT Dropped')</script>");
                Response.Redirect("Dashboard.aspx");
            }
        }
        
        
    }
}