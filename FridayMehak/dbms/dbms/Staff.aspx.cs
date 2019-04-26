using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace dbms
{
    public partial class Staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=DB6;Integrated Security=True");

        protected void DropDownList2_DataBinding(object sender, EventArgs e)
        {
            //conn.Open();
            //string query = "select Name from tbl_Pharmacy";
            //DropDownList2.DataBinding = query;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (TextBox1.Text != null || TextBox2.Text != null || TextBox3.Text != null)
                {
                    conn.Open();

                    string query = "insert into tbl_Staff(Name , Email , Password, Confirm_Password,Address,Phoneno,Gender,PharmacyID,Salary) values ('" + TextBox1.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "',(select LookupID from tbl_Lookup where Category='"+DropDownList1.Text+"'),(select PharmacyID from tbl_Pharmacy where Name='"+DropDownList2.Text+"'),'"+TextBox7.Text+"')";
                    SqlDataAdapter cdn = new SqlDataAdapter(query, conn);

                    cdn.SelectCommand.ExecuteNonQuery();
                    conn.Close();
                    Label10.Text = "Data Added Successfully";
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                    TextBox7.Text = "";
                    DropDownList2.Text = "";
                    DropDownList1.Text = "";

                }
                else
                {
                    Label10.Text = "Plz fill all the details";
                }
            
            //catch(Exception ex)
            //{

            //}
        }
    }
}