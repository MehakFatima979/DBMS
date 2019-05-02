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
    public partial class MedicinesDetails : System.Web.UI.Page
    {
        SqlDataAdapter adapt;
        DataTable dt;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DOTOD0U\SQLEXPRESS;Initial Catalog=DB6;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            { ShowData(); }
        }

        private void ShowData()
        {

            dt = new DataTable();
            conn.Open();
            adapt = new SqlDataAdapter("select tbl_medicines.MedID,tbl_medicines.Name,tbl_medicines.Composition,tbl_medicines.Description,tbl_medicines.Side_Effects,tbl_MedicinesDetails.Company,tbl_MedicinesDetails.Med_Code,tbl_MedicinesDetails.Alert_Quantity,tbl_MedicinesDetails.Quantity,tbl_MedicinesDate.Purschase_Date,tbl_MedicinesDate.Created_on,tbl_MedicinesDate.Expiry_Date from tbl_medicines join tbl_MedicinesDetails on tbl_medicines.MedID=tbl_MedicinesDetails.MedID join tbl_MedicinesDate on tbl_MedicinesDate.MedID=tbl_medicines.MedID ", conn);
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
            //Label id1 = GridView1.Rows[e.RowIndex].FindControl("lbl_ID") as Label;
            //Label id2 = GridView1.Rows[e.RowIndex].FindControl("lbl_ID") as Label;
            TextBox Name = GridView1.Rows[e.RowIndex].FindControl("txt_Name") as TextBox;
            TextBox Composition = GridView1.Rows[e.RowIndex].FindControl("txt_Composition") as TextBox;
            TextBox Description = GridView1.Rows[e.RowIndex].FindControl("txt_Description") as TextBox;
            TextBox Side_Effects = GridView1.Rows[e.RowIndex].FindControl("txt_Side_Effects") as TextBox;
            TextBox Company = GridView1.Rows[e.RowIndex].FindControl("txt_Company") as TextBox;
            TextBox Med_Code = GridView1.Rows[e.RowIndex].FindControl("txt_Med_Code") as TextBox;
            TextBox Alert_Quantity = GridView1.Rows[e.RowIndex].FindControl("txt_Alert_Quantity") as TextBox;
            TextBox Quantity = GridView1.Rows[e.RowIndex].FindControl("txt_Quantity") as TextBox;
            TextBox Purschase_Date = GridView1.Rows[e.RowIndex].FindControl("txt_Purschase_Date") as TextBox;
            TextBox Created_on = GridView1.Rows[e.RowIndex].FindControl("txt_Created_on") as TextBox;
            TextBox Expiry_Date = GridView1.Rows[e.RowIndex].FindControl("txt_Expiry_Date") as TextBox;
            conn.Open();
            //updating the record  
            
            SqlCommand cmd = new SqlCommand("Update tbl_medicines set Name='" + Name.Text + "',Composition='" + Composition.Text + "',Description='" + Description.Text + "', Side_Effects='"+Side_Effects.Text+"'  where MedID=" + Convert.ToInt32(id.Text), conn);
            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = new SqlCommand("Update tbl_MedicinesDetails set Company='" + Company.Text + "',Med_Code='" + Med_Code.Text + "',Alert_Quantity='" + Alert_Quantity.Text + "', Quantity='" + Quantity.Text + "'  where MedID=" + Convert.ToInt32(id.Text), conn);
            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("Update tbl_MedicinesDate set Purschase_Date='" + Convert.ToDateTime(Purschase_Date.Text).ToString() + "',Created_on='" + Convert.ToDateTime(Created_on.Text).ToString() + "',Expiry_Date='" + Convert.ToDateTime(Expiry_Date.Text).ToString() + "' where MedID=" + Convert.ToInt32(id.Text), conn);
            cmd2.ExecuteNonQuery();
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

            SqlCommand cmd = new SqlCommand("delete from tbl_medicines where MedID=@id", conn);
            //  cmd.CommandText = "delete from tbl_Pharmacy where PharmacyID=@id";
            cmd.Parameters.AddWithValue("@id", l1.Text);
            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = new SqlCommand("delete from tbl_MedicinesDetails where MedID=@id", conn);
            //  cmd.CommandText = "delete from tbl_Pharmacy where PharmacyID=@id";
            cmd1.Parameters.AddWithValue("@id", l1.Text);
            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("delete from tbl_MedicinesDate where MedID=@id", conn);
            //  cmd.CommandText = "delete from tbl_Pharmacy where PharmacyID=@id";
            cmd2.Parameters.AddWithValue("@id", l1.Text);
            cmd2.ExecuteNonQuery();
            conn.Close();

            ShowData();

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


        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Calendar2.Visible = true;
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            TextBox2.Text = Calendar2.SelectedDate.ToLongDateString();
            Calendar2.Visible = false;
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Calendar3.Visible = true;
        }

        protected void Calendar3_SelectionChanged(object sender, EventArgs e)
        {
            TextBox3.Text = Calendar3.SelectedDate.ToLongDateString();
            Calendar3.Visible = false;
        }

        //private void ShowData()
        //{

        //    dt = new DataTable();
        //    conn.Open();
        //    adapt = new SqlDataAdapter("select * from tbl_Pharmacy", conn);
        //    adapt.Fill(dt);
        //    if (dt.Rows.Count > 0)
        //    {
        //        GridView1.DataSource = dt;
        //        GridView1.DataBind();
        //    }
        //    conn.Close();
        //}

        protected void Button1_Click(object sender, EventArgs e)
        {
           
                conn.Open();

            string query1 = "insert into tbl_medicines(Name , Composition , Description, Side_Effects) values ('" + txtName.Text + "','" + txtComposition.Text + "','" + txtdescription.Text + "' ,'" + txtSideEffects.Text + "')";
            SqlDataAdapter cdn1 = new SqlDataAdapter(query1, conn);
            cdn1.SelectCommand.ExecuteNonQuery();

            string query2 = "insert into tbl_MedicinesDetails(Company , Med_Code , Alert_Quantity, Quantity,MedID) values ('" + txtCompany.Text + "','" + txtMedCode.Text + "','" + txtAlertQty.Text + "'  ,'" + txtQuantity.Text + "',(select MedID from tbl_medicines where Name='" + txtName.Text + "' and Composition='" + txtComposition.Text + "' and Description='" + txtdescription.Text + "' and Side_Effects='" + txtSideEffects.Text + "') ) ";
            SqlDataAdapter cdn2 = new SqlDataAdapter(query2, conn);
            cdn2.SelectCommand.ExecuteNonQuery();

            string query3 = "insert into tbl_MedicinePrice(Purchase_Price,MedID,Tax) values ('" + txtPurchasePrice.Text + "' ,(select MedID from tbl_medicines where Name='" + txtName.Text + "' and Composition='" + txtComposition.Text + "' ),'"+txtTax.Text+"') ";
            SqlDataAdapter cdn3 = new SqlDataAdapter(query3, conn);
            cdn3.SelectCommand.ExecuteNonQuery();


            string query4 = "insert into tbl_MedicinesDate(Purschase_Date , Created_on,Expiry_Date,MedID) values ('" + Convert.ToDateTime( TextBox1.Text).ToString() + "' , '" + Convert.ToDateTime(TextBox2.Text).ToString() + "','"+ Convert.ToDateTime( TextBox3.Text).ToString()+"',(select MedID from tbl_medicines where Name='" + txtName.Text + "' and Composition='" + txtComposition.Text + "') )    ";
            SqlDataAdapter cdn4 = new SqlDataAdapter(query4, conn);
            cdn4.SelectCommand.ExecuteNonQuery();



            txtAlertQty.Text = txtCompany.Text = txtComposition.Text = txtdescription.Text = txtMedCode.Text = txtName.Text = txtPurchasePrice.Text = txtQuantity.Text = txtSideEffects.Text = txtTax.Text = "";


            conn.Close();




                lblSaveRecord.Text = "Data Added Successfully";

                //SqlCommand cmd = new SqlCommand("select PharmacyID,Name,City,Location from tbl_Pharmacy order by Name", conn);
                //SqlDataAdapter adp = new SqlDataAdapter(cmd);
                //DataSet dt = new DataSet();
                //adp.Fill(dt);
                //if (dt.Tables[0].Rows.Count > 0)
                //{
                //    GridView1.DataSource = dt;
                //    GridView1.DataBind();
                //}
                //conn.Close();


                ShowData();
            

        }


    }
}