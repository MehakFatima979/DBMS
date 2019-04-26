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
        SqlConnection conn = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=DB6;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!Page.IsPostBack)
            //{ ShowData(); }
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
            TextBox2.Text = Calendar1.SelectedDate.ToLongDateString();
            Calendar2.Visible = false;
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Calendar3.Visible = true;
        }

        protected void Calendar3_SelectionChanged(object sender, EventArgs e)
        {
            TextBox3.Text = Calendar1.SelectedDate.ToLongDateString();
            Calendar2.Visible = false;
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

            string query3 = "insert into tbl_MedicinePrice(Purchase_Price,MedID,Tax) values ('" + txtPurchasePrice.Text + "' ,(select MedID from tbl_medicines where Name='" + txtName.Text + "' and Composition='" + txtComposition.Text + "' and Description='" + txtdescription.Text + "' and Side_Effects='" + txtSideEffects.Text + "'),'"+txtTax.Text+"') ";
            SqlDataAdapter cdn3 = new SqlDataAdapter(query3, conn);
            cdn3.SelectCommand.ExecuteNonQuery();


            string query4 = "insert into tbl_MedicinesDate(Purschase_Date , Created_on,Expiry_Date,MedID) values ('" + Convert.ToDateTime( TextBox1.Text).ToString() + "' , '" + Convert.ToDateTime(TextBox2.Text).ToString() + "','"+ Convert.ToDateTime( TextBox3.Text).ToString()+"',(select MedID from tbl_medicines where Name='" + txtName.Text + "' and Composition='" + txtComposition.Text + "' and Description='" + txtdescription.Text + "' and Side_Effects='" + txtSideEffects.Text + "') )    ";
            SqlDataAdapter cdn4 = new SqlDataAdapter(query4, conn);
            cdn4.SelectCommand.ExecuteNonQuery();






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

               
            
            

        }


    }
}