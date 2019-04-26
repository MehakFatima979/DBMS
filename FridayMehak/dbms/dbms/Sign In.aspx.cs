using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace dbms
{
    public partial class Sign_In : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=DB6;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmdSignIn_Click(object sender, EventArgs e)
        {
            conn.Open();

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


            string checkuser = "select count(*) from tbl_Staff where Name = '" + txtUserName.Text + "'";
            SqlCommand cnd = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(cnd.ExecuteScalar().ToString());
            conn.Close();

            if (temp == 1)
            {
                conn.Open();
                string checkpwd = "select Password from tbl_Staff where Password = '" + txtPassword.Text + "'";
                SqlCommand cmd = new SqlCommand(checkpwd, conn);
                string password = cmd.ExecuteScalar().ToString().Replace(" ", "");
                if (password == txtPassword.Text)
                {
                    Session["Name"] = txtUserName.Text;

                    Response.Write("<script>alert('Password is correct')</script>");
                    Response.Redirect("UserMainPage.aspx");


                }
                else
                {
                    Response.Write("<script>alert('Password is not correct')</script>");

                }
            }
            else
            {
                Response.Write("<script>alert('User is invalid')</script>");

            }

            //txtUserName.Text = "";
            //txtPassword.Text = "";
            //txtConfirmPwd.Text = "";

        }
    }
}