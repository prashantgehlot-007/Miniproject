using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mynew2
{
    public partial class City : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            //link button for city
            TextBox tb1 = (TextBox)GridView1.FooterRow.FindControl("txtcityid");
            TextBox tb2 = (TextBox)GridView1.FooterRow.FindControl("txtcityname");
            TextBox tb3 = (TextBox)GridView1.FooterRow.FindControl("txtstateid");

            //DropDownList ddl1 = (DropDownList)GridView1.FooterRow.FindControl("ddldep");
            //DropDownList ddl2 = (DropDownList)GridView1.FooterRow.FindControl("ddlstate");
            //DropDownList ddl3 = (DropDownList)GridView1.FooterRow.FindControl("ddlcity");

            ObjectDataSource1.InsertParameters["CtId"].DefaultValue = tb1.Text;
            ObjectDataSource1.InsertParameters["CtName"].DefaultValue = tb2.Text;
            ObjectDataSource1.InsertParameters["StId"].DefaultValue = tb3.Text;
            //ObjectDataSource1.InsertParameters["Dno"].DefaultValue = ddl1.SelectedValue.ToString();
            //ObjectDataSource1.InsertParameters["StId"].DefaultValue = ddl2.SelectedValue.ToString();
            //ObjectDataSource1.InsertParameters["CtId"].DefaultValue = ddl3.SelectedValue.ToString();
            ObjectDataSource1.Insert();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //city row deleting
            ObjectDataSource1.DeleteParameters["CtId"].DefaultValue = e.Values[0].ToString();
            ObjectDataSource1.Delete();
        }
    }
}