using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace dbms
{
    public partial class Sell_Medicines : System.Web.UI.Page
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
            adapt = new SqlDataAdapter("select tbl_medicines.MedID,tbl_medicines.Name,tbl_MedicinePrice.Purchase_Price,tbl_MedicinePrice.Sale_Price,tbl_MedicinePrice.Tax,tbl_MedicinesDate.Purschase_Date,tbl_MedicinesDate.Created_on,tbl_MedicinesDate.Expiry_Date,tbl_MedicineSale.Sale_Date,tbl_Doctor.Name,tbl_Hospital.Name  from tbl_medicines join tbl_MedicinePrice on tbl_medicines.MedID=tbl_MedicinePrice.MedID join tbl_MedicinesDate on tbl_MedicinePrice.MedID=tbl_MedicinesDate.MedID join tbl_MedicineSale on tbl_MedicineSale.MedID= tbl_medicines.MedID join tbl_Doctor on tbl_Doctor.MedID= tbl_medicines.MedID join tbl_Hospital on tbl_Hospital.HospitalID=tbl_Doctor.HospitalID", conn);
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
            TextBox sale = GridView1.Rows[e.RowIndex].FindControl("txt_Sale_Price") as TextBox;
            TextBox hosp = GridView1.Rows[e.RowIndex].FindControl("txt_hospital") as TextBox;
            TextBox doc = GridView1.Rows[e.RowIndex].FindControl("txt_Med_docotor") as TextBox;
            TextBox saledate = GridView1.Rows[e.RowIndex].FindControl("txt_Sale_Date") as TextBox;
            Label tax = GridView1.Rows[e.RowIndex].FindControl("lbl_tax") as Label;
            Label expiry = GridView1.Rows[e.RowIndex].FindControl("lbl_Expiry") as Label;
            Label created= GridView1.Rows[e.RowIndex].FindControl("lbl_Created") as Label;
            Label purchase = GridView1.Rows[e.RowIndex].FindControl("lbl_Purschase") as Label;
            Label purchaseprice = GridView1.Rows[e.RowIndex].FindControl("lbl_purchaseprice") as Label;
            conn.Open();
            //updating the record  

            SqlCommand cmd = new SqlCommand("Update tbl_MedicinesDate set Purschase_Date='" + Convert.ToDateTime(purchase.Text).ToString() + "' where MedID=" + Convert.ToInt32(id.Text), conn);
            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = new SqlCommand("Update tbl_MedicineSale set Sale_Date='" + Convert.ToDateTime(saledate.Text).ToString() + "'  where MedID=" + Convert.ToInt32(id.Text), conn);
            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("Update tbl_MedicinePrice set Sale_Price='" + sale.Text.ToString() + "' where MedID=" + Convert.ToInt32(id.Text), conn);
            cmd2.ExecuteNonQuery();
            

            SqlCommand cmd3 = new SqlCommand("Update tbl_Doctor  set Name='"+doc.Text+"' where HospitalID=(select HospitalID from tbl_Hospital where Name='"+hosp.Text+"') and MedID=" + Convert.ToInt32(id.Text), conn);
            cmd3.ExecuteNonQuery();
            

            SqlCommand cmd4 = new SqlCommand("Update tbl_Hospital  set Name='" +hosp.Text + "'  where Name='"+hosp.Text , conn);
            cmd4.ExecuteNonQuery();
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
            TextBox hosp = GridView1.Rows[e.RowIndex].FindControl("txt_hospital") as TextBox;

            SqlCommand cmd = new SqlCommand("delete from tbl_MedicineSale where MedID=@id", conn);
            //  cmd.CommandText = "delete from tbl_Pharmacy where PharmacyID=@id";
            cmd.Parameters.AddWithValue("@id", l1.Text);
            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = new SqlCommand("delete from tbl_MedicinePrice where MedID=@id", conn);
            //  cmd.CommandText = "delete from tbl_Pharmacy where PharmacyID=@id";
            cmd1.Parameters.AddWithValue("@id", l1.Text);
            cmd1.ExecuteNonQuery();

            SqlCommand cmd3 = new SqlCommand("delete from tbl_MedicinesDate where MedID=@id", conn);
            //  cmd.CommandText = "delete from tbl_Pharmacy where PharmacyID=@id";
            cmd3.Parameters.AddWithValue("@id", l1.Text);
            cmd3.ExecuteNonQuery();

            //SqlCommand cmd4 = new SqlCommand("delete from tbl_Hospital where Name=@name", conn);
            ////  cmd.CommandText = "delete from tbl_Pharmacy where PharmacyID=@id";
            //cmd4.Parameters.AddWithValue("@Name",hosp.Text);
            //cmd4.ExecuteNonQuery();

            SqlCommand cmd5 = new SqlCommand("delete from tbl_Doctor where MedID=@id", conn);
            //  cmd.CommandText = "delete from tbl_Pharmacy where PharmacyID=@id";
            cmd5.Parameters.AddWithValue("@id", l1.Text);
            cmd5.ExecuteNonQuery();
            conn.Close();

            ShowData();

        }



          protected void Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select tbl_medicines.Name,tbl_MedicinePrice.Purchase_Price,tbl_MedicinePrice.Tax,tbl_MedicinesDate.Purschase_Date,tbl_MedicinesDate.Created_on,tbl_MedicinesDate.Expiry_Date  from tbl_medicines join tbl_MedicinePrice on tbl_medicines.MedID=tbl_MedicinePrice.MedID join tbl_MedicinesDate on tbl_MedicinePrice.MedID=tbl_MedicinesDate.MedID  where tbl_medicines.Name='" + txtMedName.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtmedtx.Text = reader["Tax"].ToString();
                txtPurchase.Text = reader["Purchase_Price"].ToString();
                TextBox4.Text = reader["Purschase_Date"].ToString();
             //   TextBox4.Text = reader["Created_on"].ToString();
                TextBox5.Text = reader["Expiry_Date"].ToString();
                reader.Close();
                conn.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query1 = "insert into tbl_MedicineSale(Sale_Date,MedID) values ('"+Convert.ToDateTime(TextBox6.Text).ToString()+"',(select MedID from tbl_medicines where Name='"+txtMedName.Text+"'))";
            SqlDataAdapter cdn1 = new SqlDataAdapter(query1, conn);
            cdn1.SelectCommand.ExecuteNonQuery();

            string query2 = "insert into tbl_MedicinePrice(Sale_Price,MedID,Purchase_Price,Tax) values ('" + txtsale.Text + "' ,(select MedID from tbl_medicines where Name='" + txtMedName.Text + "'),'"+txtPurchase.Text+"','"+txtmedtx.Text+"') ";
            SqlDataAdapter cdn2 = new SqlDataAdapter(query2, conn);
            cdn2.SelectCommand.ExecuteNonQuery();

            string query4 = "insert into tbl_Hospital(Name) values ('"+txthospital.Text+"' )    ";
            SqlDataAdapter cdn4 = new SqlDataAdapter(query4, conn);
            cdn4.SelectCommand.ExecuteNonQuery();

            string query3 = "insert into tbl_Doctor(Name,MedID,HospitalID) values ('" + txtrecommended.Text + "',(select MedID from tbl_medicines where Name='" + txtMedName.Text + "'),(select HospitalID from tbl_Hospital where Name='"+txthospital.Text+"')) ";
            SqlDataAdapter cdn3 = new SqlDataAdapter(query3, conn);
            cdn3.SelectCommand.ExecuteNonQuery();



            lblSave.Text = "record saved successfully";


            //txtAlertQty.Text = txtCompany.Text = txtComposition.Text = txtdescription.Text = txtMedCode.Text = txtName.Text = txtPurchasePrice.Text = txtQuantity.Text = txtSideEffects.Text = txtTax.Text = "";


            conn.Close();
        }
        //protected void LinkButton4_Click(object sender, EventArgs e)
        //{
        //    Calendar4.Visible = true;
        //}

        //protected void Calendar4_SelectionChanged(object sender, EventArgs e)
        //{
        //    TextBox4.Text = Calendar4.SelectedDate.ToLongDateString();
        //    Calendar4.Visible = false;
        //}

        //protected void LinkButton5_Click(object sender, EventArgs e)
        //{
        //    Calendar5.Visible = true;
        //}

        //protected void Calendar5_SelectionChanged(object sender, EventArgs e)
        //{
        //    TextBox5.Text = Calendar5.SelectedDate.ToLongDateString();
        //    Calendar5.Visible = false;
        //}
        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Calendar6.Visible = true;
        }

        protected void Calendar6_SelectionChanged(object sender, EventArgs e)
        {
            TextBox6.Text = Calendar6.SelectedDate.ToLongDateString();
            Calendar6.Visible = false;
        }



    }
}