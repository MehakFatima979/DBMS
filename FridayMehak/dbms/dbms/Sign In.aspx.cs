﻿using System;
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
            
            if(DropDownListUserType.Text =="Admin")
            {
                string checkuser1 = "select count(*) from tbl_Admin where Name = '" + txtUserName.Text + "'";
                SqlCommand cnd1 = new SqlCommand(checkuser1, conn);
                int temp1 = Convert.ToInt32(cnd1.ExecuteScalar().ToString());
                conn.Close();

                if (temp1 == 1)
                {
                    conn.Open();
                    string checkpwd = "select Pssword from tbl_Admin where Pssword = '" + txtPassword.Text + "'";
                    SqlCommand cmd = new SqlCommand(checkpwd, conn);
                    string password1 = cmd.ExecuteScalar().ToString().Replace(" ", "");
                    if (password1 == txtPassword.Text)
                    {
                        Session["Name"] = txtUserName.Text;

                        Response.Write("<script>alert('Password is correct')</script>");
                        Response.Redirect("Admin.aspx");


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
            }


            else if(DropDownListUserType.Text=="User")
            {
                string checkuser = "select count(*) from tbl_Staff where Name = '" + txtUserName.Text + "'";
                SqlCommand cnd = new SqlCommand(checkuser, conn);
                int temp = Convert.ToInt32(cnd.ExecuteScalar().ToString());
                conn.Close();

                if (temp == 1)
                {
                    conn.Open();
                    string checkpwd = "select Password from tbl_Staff where Password = '" + txtPassword.Text + "'";
                    SqlCommand cmd = new SqlCommand(checkpwd, conn);
                    string password = cmd.ExecuteScalar().ToString();
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
}