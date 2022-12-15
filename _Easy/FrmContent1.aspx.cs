using MasterPage1._DBConnection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPage1._EasyPages
{
    public partial class FrmContent1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetData();
            }
               
        }

        private void GetData()
        {
            HREntities HR = new HREntities();

            var T = (from E in HR.Employees
                     select E);


            DdChoose.DataSource = T.ToList();
            DdChoose.DataValueField = "Id";
            DdChoose.DataTextField = "first_name";
            DdChoose.DataBind();
            //DdChoose.SelectedIndex = -1;
            DdChoose.Items.Insert(0, new ListItem("Please select", ""));


            DGVShow.DataSource = T.ToList();
            DGVShow.DataBind();

        }

        protected void DGVShow_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //if (e.Row.RowType == DataControlRowType.Header)
            //{
            //    e.Row.Cells[0].Text = "المعرف";
            //    e.Row.Cells[1].Text = "الإسم";
            //    e.Row.Cells[2].Text = "اللقب";
            //}

            //DGVShow.RowStyle.BorderStyle = BorderStyle.Solid;
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {

            
            LblTestFun.Text = "Great";
            LblTestFun.BackColor = Color.MediumSeaGreen;
            LblTestFun.ForeColor = Color.White;
            BtnSubmit.Attributes.CssStyle.Clear();
            BtnSubmit.CssClass = "nav-link text-white active bg-gradient-primary";
            //Master.
        }

        protected  void DGVShow_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            DGVShow.PageIndex = e.NewPageIndex;
            GetData();
        }
    }
}