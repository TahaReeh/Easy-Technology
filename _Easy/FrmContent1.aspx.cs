using MasterPage1._DBConnection;
using System;
using System.Collections.Generic;
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
            HREntities HR = new HREntities();

            var T = (from E in HR.Employees
                     select new
                     {
                         E.Id,
                         E.first_name,
                         E.last_name,
                         E.Job
                     });


            //DdChoose.Items.Clear();
            DdChoose.DataSource = T.ToList();
            DdChoose.DataValueField = "Id";
            DdChoose.DataTextField = "first_name";
            DdChoose.DataBind();
            //DdChoose.SelectedIndex = -1;
            DdChoose.Items.Insert(0, new ListItem("Please select", ""));


            DGVShow.DataSource = T.ToList();
            DGVShow.DataBind();

        }

       protected void BtnSubmit_Click(object sender, EventArgs e)
        {


            LblTestFun.Text = "Great";
            LblTestFun.BackColor = Color.MediumSeaGreen;
            LblTestFun.ForeColor = Color.White;
            BtnSubmit.CssClass = "nav-link text-white active bg-gradient-primary";
            
        }
    }
}