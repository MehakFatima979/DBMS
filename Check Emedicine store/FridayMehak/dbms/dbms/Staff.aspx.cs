﻿using System;
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
            adapt = new SqlDataAdapter("select tbl_Staff.StaffID ,tbl_Staff.Name , tbl_Staff.Email , tbl_Staff.Password , tbl_Staff.Confirm_Password , tbl_Staff.Address,tbl_Staff.Phoneno, tbl_Staff.Gender, tbl_Staff.PharmacyID ,tbl_Staff.Salary from tbl_Staff join tbl_Pharmacy on tbl_Staff.PharmacyID=tbl_Pharmacy.PharmacyID  ", conn);
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
            TextBox Name = GridView1.Rows[e.RowIndex].FindControl("txt_Name") as TextBox;
            TextBox Email = GridView1.Rows[e.RowIndex].FindControl("txt_Email") as TextBox;
            TextBox Password = GridView1.Rows[e.RowIndex].FindControl("txt_Password") as TextBox;
            TextBox Confirm_Password = GridView1.Rows[e.RowIndex].FindControl("txt_Confirm_Password") as TextBox;
            TextBox Address = GridView1.Rows[e.RowIndex].FindControl("txt_Address") as TextBox;
            TextBox Phoneno = GridView1.Rows[e.RowIndex].FindControl("txt_Phoneno") as TextBox;
            TextBox Gender = GridView1.Rows[e.RowIndex].FindControl("txt_Gender") as TextBox;
            
            TextBox PharmacyID = GridView1.Rows[e.RowIndex].FindControl("txt_PharmacyID") as TextBox;
            TextBox Salary = GridView1.Rows[e.RowIndex].FindControl(" txt_Salary") as TextBox;
            conn.Open();
            //updating the record  


            SqlCommand cmd = new SqlCommand("Update tbl_Staff set Name='" + Name.Text + "',Email='" + Email.Text+ "',Password='" + Password.Text + "',Confirm_Password='" + Confirm_Password.Text + "',Addess='" + Address.Text + "',Phoneno='"+Phoneno.Text+ "',Gender= (select LookupID from tbl_Lookup where Value = '" +Gender.Text + "'),Salary='" + Salary.Text + "'  where StaffID=" + Convert.ToInt32(id.Text), conn);
            cmd.ExecuteNonQuery();




            //SqlCommand cmd = new SqlCommand("Update tbl_Staff set Name='" + txtName.Text + "',Email='" + txtEmail.Text + "' ,Password='" + txtPwd.Text + "' ,Confirm_Password='" + txtConfirmPwd.Text + "' ,Address='" + txtAddress.Text + "' ,Phoneno='" + txtPhone.Text + "' ,Gender= (select LookupID from tbl_Lookup where Value = '"+DropDownListGender.Text+"')  ,Salary='" + txtSalary.Text + "'  where StaffID=" + Convert.ToInt32(id.Text), conn);
            //cmd.ExecuteNonQuery();
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

                    SqlCommand cmd = new SqlCommand("delete from tbl_Pharmacy where PharmacyID=lbl_ID", conn);
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

                    string query = "insert into tbl_Staff(Name , Email , Password, Confirm_Password,Address,Phoneno,Gender,PharmacyID,Salary) values ('" + txtName.Text + "','" + txtEmail.Text + "','" + txtPassword.Text + "','" + txtConfirmPwd.Text + "','" + txtAddress.Text + "','" + txtPhoneno.Text + "',(select LookupID from tbl_Lookup where Value='"+txtGender.Text+"'),(select PharmacyID from tbl_Pharmacy where Name='"+txtPharmacy.Text+"'),'"+txtSalary.Text+"')";
                    SqlDataAdapter cdn = new SqlDataAdapter(query, conn);

                    cdn.SelectCommand.ExecuteNonQuery();
                    conn.Close();
            lblSaveRecord.Text = "Data Added Successfully";
            //TextBox1.Text = "";
            //TextBox2.Text = "";
            //TextBox3.Text = "";
            //TextBox4.Text = "";
            //TextBox5.Text = "";
            //TextBox6.Text = "";
            //TextBox7.Text = "";
            //DropDownList2.Text = "";
            //DropDownList1.Text = "";



            //catch(Exception ex)
            //{

            //}
        }
    }
}