using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

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
            string checkuser = "select count(*) from tbl_Staff where Name = '" + txtUserName.Text + "'";
            SqlCommand cnd = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(cnd.ExecuteScalar().ToString());
            //    conn.Close();
            string checkadmin = "select count(*) from tbl_Admin where Email = '" + txtUserName.Text + "'";
            SqlCommand cmd1 = new SqlCommand(checkadmin, conn);
            int temp1 = Convert.ToInt32(cmd1.ExecuteScalar().ToString());
            //    conn.Close();
            if (temp == 1)
            {
                //        conn.Open();
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
            else if (temp1 == 1)
            {
                string checkpwd1 = "select Pssword from tbl_Admin where Pssword = '" + txtPassword.Text + "'";
                SqlCommand cmd2 = new SqlCommand(checkpwd1, conn);
                string password1 = cmd2.ExecuteScalar().ToString().Replace(" ", "");
                if (password1 == txtPassword.Text)
                {
                    Session["UserName"] = txtUserName.Text;

                    Response.Write("<script>alert('Password is correct')</script>");
                    Response.Redirect("AdminPage.aspx");


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
            conn.Close();

            //txtUserName.Text = "";
            //txtPassword.Text = "";
            //txtConfirmPwd.Text = "";

            }


    

                //txtUserName.Text = "";
                //txtPassword.Text = "";
                //txtConfirmPwd.Text = "";
        
           
    }
}