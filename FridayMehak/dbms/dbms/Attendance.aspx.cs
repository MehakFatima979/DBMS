using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace dbms
{
    public partial class Attendance : System.Web.UI.Page
    {

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DOTOD0U\SQLEXPRESS;Initial Catalog=DB6;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox1.Text = Calendar1.SelectedDate.ToLongDateString();
            Calendar1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (DropDownListName != null || DropDownListAttendance.Text != null || TextBox1.Text != null)
            {
                conn.Open();


                string query = "insert into tbl_StaffAttendance(StaffID, Date , Status ) values ((select StaffID from tbl_Staff where Name= '" + DropDownListName.Text + "') ,'" +Convert.ToDateTime( TextBox1.Text).ToString() + "' , (select LookupID from tbl_Lookup where Value = '" + DropDownListAttendance.Text + "'));  ";

                SqlDataAdapter cdn = new SqlDataAdapter(query, conn);

                cdn.SelectCommand.ExecuteNonQuery();
                conn.Close();
                lblMessage.Text = "Data Added Successfully";
                //DropDownListName.Text = "";
                //DropDownListAttendance =""
                //    //TextBox1.Text = "";
                //    //TextBox2.Text = "";
                //    //TextBox3.Text = "";
                //    //TextBox4.Text = "";
                //    //TextBox5.Text = "";
                //    //TextBox6.Text = "";
                //    //TextBox7.Text = "";
                //    //DropDownList2.Text = "";
                //    //DropDownList1.Text = "";

            }
            else
            {
                //Label10.Text = "Plz fill all the details";
            }

        }

    }
}