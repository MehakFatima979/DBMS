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
    public partial class Staff : System.Web.UI.Page
    {
        SqlDataAdapter adapt;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            { ShowData(); }
        }
        SqlConnection conn = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=DB6;Integrated Security=True");


        private void ShowData()
        {

            dt = new DataTable();
            conn.Open();
            adapt = new SqlDataAdapter("select tbl_Staff.*,tbl_Lookup.Value from tbl_Staff join tbl_Lookup on tbl_Lookup.LookupID=tbl_Staff.Gender", conn);
            adapt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            conn.Close();
        }

        protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            //NewEditIndex property used to determine the index of the row being edited.  
            GridView1.EditIndex = e.NewEditIndex;
            ShowData();
        }
        protected void GridView1_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            //Finding the controls from Gridview for the row which is going to update  
            Label id = GridView1.Rows[e.RowIndex].FindControl("lbl_ID") as Label;
            TextBox name = GridView1.Rows[e.RowIndex].FindControl("txt_Name") as TextBox;
            TextBox email = GridView1.Rows[e.RowIndex].FindControl("txt_Email") as TextBox;
            TextBox password = GridView1.Rows[e.RowIndex].FindControl("txt_Password") as TextBox;
            TextBox confirmpassword = GridView1.Rows[e.RowIndex].FindControl("txt_Confirm_Password") as TextBox;
            TextBox address = GridView1.Rows[e.RowIndex].FindControl("txt_Address") as TextBox;
            TextBox phoneno = GridView1.Rows[e.RowIndex].FindControl("txt_Phoneno") as TextBox;
            TextBox salary = GridView1.Rows[e.RowIndex].FindControl("txt_Salary") as TextBox;
            TextBox Gender = GridView1.Rows[e.RowIndex].FindControl("txt_Gender") as TextBox;
            
            conn.Open();
            //updating the record  

            SqlCommand cmd = new SqlCommand("Update tbl_Staff set Name='" + name.Text + "',Email='" + email.Text + "' ,Password='" + password.Text + "' ,Confirm_Password='" + confirmpassword.Text + "' ,Address='" + address.Text + "' ,Phoneno='" + phoneno.Text + "' ,Gender= (select LookupID from tbl_Lookup where Value = '" + Gender.Text + "')  ,Salary='" + salary.Text + "'  where StaffID=" + Convert.ToInt32(id.Text), conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
            GridView1.EditIndex = -1;

            //Call ShowData method for displaying updated data  
            ShowData();
        }


        protected void GridView1_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
            GridView1.EditIndex = -1;
            ShowData();
        }

        protected void GridView1_RowDeleting(object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
        {
            //this.GridView1.Columns[2].Visible = false;
            conn.Open();
            Label l1 = GridView1.Rows[e.RowIndex].FindControl("lbl_ID") as Label;

            SqlCommand cmd = new SqlCommand("delete from tbl_Staff where StaffID=@id", conn);
            //  cmd.CommandText = "delete from tbl_Pharmacy where PharmacyID=@id";
            cmd.Parameters.AddWithValue("@id", l1.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            ShowData();

        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow gvrow in GridView1.Rows)
            {
                CheckBox chck = gvrow.FindControl("CheckBox1") as CheckBox;
                if (chck.Checked)
                {
                    //var Label = gvrow.FindControl("lbl_ID") as Label;

                    SqlCommand cmd = new SqlCommand("delete from tbl_Staff where StaffID=lbl_ID", conn);
                    //cmd.Parameters.AddWithValue("id", int.Parse(Label.Text));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    ShowData();


                }
            }
        }






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
                
                    conn.Open();

                    string query = "insert into tbl_Staff(Name , Email , Password, Confirm_Password,Address,Phoneno,Gender,PharmacyID,Salary) values ('" + txtName.Text + "','" + txtEmail.Text + "','" + txtPwd.Text + "','" + txtConfirmPwd.Text + "','" + txtAddress.Text + "','" + txtPhone.Text + "',(select LookupID from tbl_Lookup where Value='"+DropDownListGender.Text+"'),(select PharmacyID from tbl_Pharmacy where Name='"+DropDownListPharmacy.Text+"'),'"+txtSalary.Text+"')";
                    SqlDataAdapter cdn = new SqlDataAdapter(query, conn);

                    cdn.SelectCommand.ExecuteNonQuery();
                    conn.Close();
                    Label10.Text = "Data Added Successfully";
                    txtName.Text = txtAddress.Text = txtConfirmPwd.Text = txtEmail.Text = txtPhone.Text = txtPwd.Text = txtSalary.Text = "";
                    //TextBox1.Text = "";
                    //TextBox2.Text = "";
                    //TextBox3.Text = "";
                    //TextBox4.Text = "";
                    //TextBox5.Text = "";
                    //TextBox6.Text = "";
                    //TextBox7.Text = "";
                    //DropDownList2.Text = "";
                    //DropDownList1.Text = "";

                    ShowData();
            
            //catch(Exception ex)
            //{

            //}
        }
    }
}