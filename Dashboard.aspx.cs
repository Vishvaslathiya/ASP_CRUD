using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dashboard : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            viewAllStudents();

        }
    }

    private void viewAllStudents()
    {
        SqlConnection con = new SqlConnection("Data Source=VISHVAS;Initial Catalog=Friday;Integrated Security=True;");

        con.Close();

        con.Open();
        String selectQuery = "select * from tbl_student;";
        SqlCommand cmd = new SqlCommand(selectQuery, con);
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.HasRows)
        {
            dispalyStudents.DataSource = dr;
            dispalyStudents.DataBind();
        }
        dr.Close();
        con.Close();




    }
}