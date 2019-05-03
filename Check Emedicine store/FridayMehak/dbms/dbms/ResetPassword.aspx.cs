using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace dbms
{
    public partial class ResetPassword : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=DB6;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmdSignIn_Click(object sender, EventArgs e)
        {
           

            //string query = "select count(1) from tbl_Staff were Name=@name AND Password=@password ";
            //SqlCommand sqlcmd = new SqlCommand(query, conn);
            //sqlcmd.Parameters.AddWithValue("@name", txtUserName.Text.Trim());
            //sqlcmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
            //int count = Convert.ToInt32(sqlcmd.ExecuteScalar());
            //if (count == 1)
            //{
            //    Session["Name"] = txtUserName.Text.Trim();
            //    Response.Redirect("Main.aspx");
            //}


           
                conn.Open();
            string query = "update tbl_Staff set Password ='"+txtPassword.Text+"', Confirm_Password ='"+txtConfirmPwd+"' where Email ='"+txtUserName.Text+"'  ";
                
            SqlDataAdapter cdn1 = new SqlDataAdapter(query, conn);
            cdn1.SelectCommand.ExecuteNonQuery();

            string query1 = "update tbl_Admin set Password ='" + txtPassword.Text + "', Confirm_Password ='" + txtConfirmPwd + "' where Email ='" + txtUserName.Text + "'  ";

            SqlDataAdapter cdn = new SqlDataAdapter(query1, conn);
            cdn.SelectCommand.ExecuteNonQuery();



            conn.Close();
            Response.Write("<script>alert('Password Reset Successfully')</script>");
            Response.Redirect("Sign In.aspx");



            //txtUserName.Text = "";
            //txtPassword.Text = "";
            //txtConfirmPwd.Text = "";

        }
    }
}