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
    public partial class Adminpage : System.Web.UI.Page
    {
        SqlDataAdapter adapt;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            { ShowData(); }
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("select PharmacyID,Name,City,Location from tbl_Pharmacy order by Name", conn);
            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //DataSet dt = new DataSet();
            //adp.Fill(dt);
            //if (dt.Tables[0].Rows.Count > 0)
            //{
            //    pharmacytable.DataSource = dt;
            //    pharmacytable.DataBind();
            //}
            //conn.Close();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DOTOD0U\SQLEXPRESS;Initial Catalog=DB6;Integrated Security=True");
        private void ShowData()
        {
           
            dt = new DataTable();
            conn.Open();
            adapt = new SqlDataAdapter("select * from tbl_Pharmacy", conn);
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
            TextBox city = GridView1.Rows[e.RowIndex].FindControl("txt_City") as TextBox;
            TextBox location= GridView1.Rows[e.RowIndex].FindControl("txt_Location") as TextBox;
            conn.Open();
            //updating the record  
         
            SqlCommand cmd = new SqlCommand("Update tbl_Pharmacy set Name='" + name.Text + "',City='" + city.Text + "' where PharmacyID=" + Convert.ToInt32(id.Text), conn);
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
          
            SqlCommand cmd = new SqlCommand("delete from tbl_Pharmacy where PharmacyID=@id", conn);
          //  cmd.CommandText = "delete from tbl_Pharmacy where PharmacyID=@id";
            cmd.Parameters.AddWithValue("@id", l1.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            ShowData();
           
        }
        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void select_Click(object sender, EventArgs e)
        {


        }
        protected void Button1_Add(object sender, EventArgs e)
        {
         
             
            
         
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
        //public void BindDataToGridView()
        //{
        //    try
        //    {
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("select PharmacyID,Name,City,Location from tbl_Pharmacy order by City", conn);
        //        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        //        DataSet dt = new DataSet();
        //        adp.Fill(dt);
        //        if (dt.Tables[0].Rows.Count > 0)
        //        {
        //            pharmacytable.DataSource = dt;
        //            pharmacytable.DataBind();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Label4.Text = "Error:" + ex.Message;
        //    }
        //    conn.Close();
        //}



        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != null || TextBox2.Text != null || TextBox3.Text != null)
            {
                conn.Open();

                string query = "insert into tbl_Pharmacy(Name , City , Location) values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";
                SqlDataAdapter cdn = new SqlDataAdapter(query, conn);

                cdn.SelectCommand.ExecuteNonQuery();
                conn.Close();
                Label4.Text = "Data Added Successfully";
              
                SqlCommand cmd = new SqlCommand("select PharmacyID,Name,City,Location from tbl_Pharmacy order by Name", conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet dt = new DataSet();
                adp.Fill(dt);
                if (dt.Tables[0].Rows.Count > 0)
                {
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
                conn.Close();
                
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
            }
            else
            {
                Label4.Text = "Plz fill all the details";
            }

        }

        protected void pharmacytable_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}