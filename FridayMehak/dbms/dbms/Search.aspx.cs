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
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlDataAdapter adapt;
        DataTable dt;
        SqlConnection conn = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=DB6;Integrated Security=True");

        protected void Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            dt = new DataTable();

            adapt = new SqlDataAdapter("select tbl_medicines.MedID,tbl_medicines.Name,tbl_medicines.Composition,tbl_medicines.Description,tbl_medicines.Side_Effects,tbl_MedicinesDetails.Company,tbl_MedicinesDetails.Med_Code,tbl_MedicinesDetails.Alert_Quantity,tbl_MedicinesDetails.Quantity,tbl_MedicinesDate.Purschase_Date,tbl_MedicinesDate.Created_on,tbl_MedicinesDate.Expiry_Date from tbl_medicines join tbl_MedicinesDetails on tbl_medicines.MedID=tbl_MedicinesDetails.MedID join tbl_MedicinesDate on tbl_MedicinesDate.MedID=tbl_medicines.MedID where tbl_MedicinesDate.Purschase_Date='" + Convert.ToDateTime( TextBox3.Text).ToString() + "'", conn);
            adapt.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            if (dt.Rows.Count == 0)
            {
                Label2.Text = "No recod has been found";
            }
           
              
            
            conn.Close();
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
    }
}