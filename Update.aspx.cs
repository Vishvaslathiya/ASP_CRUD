using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Update : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
        }
    }

    private void Updatedata()
    {
        String nname = ename.Text;
        String nemail = eemail.Text;
        String npass = epass.Text;
        String ngen = Findgender();

        int id = Convert.ToInt32(Request.QueryString["uid"]);

        string connectionString = "Data Source=VISHVAS;Initial Catalog=Friday;Integrated Security=True;";

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open();
            SqlCommand updateCmd = new SqlCommand("update tbl_student set name = @Name, email = @Email, pass = @Password, gender = @Gender where id = @ID", con);

            // Add parameters to the SqlCommand to prevent SQL injection
            updateCmd.Parameters.AddWithValue("@Name", nname);
            updateCmd.Parameters.AddWithValue("@Email", nemail);
            updateCmd.Parameters.AddWithValue("@Password", npass);
            updateCmd.Parameters.AddWithValue("@Gender", ngen);
            updateCmd.Parameters.AddWithValue("@ID", id);

            updateCmd.ExecuteNonQuery();
        }

        Response.Write("<script>alert('Data Updated')</script>");
    }


    private string Findgender()
    {
        if(male.Checked)
        {
            return "Male";
        }
        else if (female.Checked)
        {
            return "Female";
        }
        else
        {
            return null;
        }
    }

    protected void update_Click(object sender, EventArgs e)
    {
        Updatedata();
    }
}