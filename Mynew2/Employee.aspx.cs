using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mynew2
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //Row Deleting of emmployee
            ObjectDataSource1.DeleteParameters["ECode"].DefaultValue = e.Values[0].ToString();
            ObjectDataSource1.Delete();
        }

        protected void ddlstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ddlstate
            DropDownList ddl2 = (DropDownList)GridView1.FooterRow.FindControl("ddlstate");
            Session["StId"] = ddl2.SelectedValue;

            Response.Write("Selected State Id =" + Session["StId"].ToString());
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            //linkbutton of emp
            TextBox tb1 = (TextBox)GridView1.FooterRow.FindControl("txtempcode");
            TextBox tb2 = (TextBox)GridView1.FooterRow.FindControl("txtename");
            TextBox tb3 = (TextBox)GridView1.FooterRow.FindControl("txtesalary");

            DropDownList ddl1 = (DropDownList)GridView1.FooterRow.FindControl("ddldep");
            DropDownList ddl2 = (DropDownList)GridView1.FooterRow.FindControl("ddlstate");
            DropDownList ddl3 = (DropDownList)GridView1.FooterRow.FindControl("ddlcity");

            ObjectDataSource1.InsertParameters["ECode"].DefaultValue = tb1.Text;
            ObjectDataSource1.InsertParameters["EName"].DefaultValue = tb2.Text;
            ObjectDataSource1.InsertParameters["ESal"].DefaultValue = tb3.Text;
            ObjectDataSource1.InsertParameters["Dno"].DefaultValue = ddl1.SelectedValue.ToString();
            ObjectDataSource1.InsertParameters["StId"].DefaultValue = ddl2.SelectedValue.ToString();
            ObjectDataSource1.InsertParameters["CtId"].DefaultValue = ddl3.SelectedValue.ToString();
            ObjectDataSource1.Insert();

        }
    }
}