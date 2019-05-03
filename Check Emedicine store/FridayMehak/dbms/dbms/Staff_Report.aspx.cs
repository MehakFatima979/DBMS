using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using CrystalDecisions.Web;
using CrystalDecisions.Shared;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;

namespace dbms
{
    public partial class Staff_Report : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=DB6;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Show_Click(object sender, EventArgs e)
        {
            //dsStaff ds = new dsStaff();
            //SqlDataAdapter adapter = new SqlDataAdapter("select Name,Email,Password,Confirm_Password,Phoneno , Address,Gender,Salary from tbl_Staff", conn);
            //adapter.Fill(ds.tbl_Staff);
            //rptStaff report = new rptStaff();
            //report.SetDataSource(ds);
            //// object CrystalReportViewer1 = null;
            //CrystalReportViewer1.ReportSource = report;

            //tbl_StaffTableAdapters.tbl_StaffTableAdapter da = new tbl_StaffTableAdapters.tbl_StaffTableAdapter();
            //Customer ds = new Customer();
            //Customer.tbl_StaffDataTable dt = (Customer.tbl_StaffDataTable)
            //ds.Tables["tbl_Staff"];
            //da.Fill(dt);
            //rpt = new rptCustomerList();
            //rpt.SetDataSource(ds);
            //CrystalReportViewer1.ReportSource = rpt;
            //Session.Add("report", rpt);

        }

        protected void CrystalReportViewer1_Init(object sender, EventArgs e)
        {

        }
    }

}