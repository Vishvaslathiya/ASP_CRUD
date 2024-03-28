using System;
using System.Data;
using System.Data.SqlClient;

public partial class Dashboard : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ViewAllStudents();
        }
    }

    private void ViewAllStudents()
    {
        string connectionString = "Data Source=VISHVAS;Initial Catalog=Friday;Integrated Security=True;";

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string selectQuery = "SELECT * FROM tbl_student";
            SqlCommand cmd = new SqlCommand(selectQuery, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dispalyStudents.DataSource = dt;
                    dispalyStudents.DataBind();
                }
                else
                {
                    Response.Write("<script>alert('NO Data Found')</script>");

                    // No data found, display a message or handle it accordingly
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('SQL Catch Block')</script>");

                // Handle any exceptions
            }
        }
    }
}
