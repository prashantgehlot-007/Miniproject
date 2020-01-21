using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mynew2
{
    public partial class State : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            //Insert button
            TextBox tb1 = (TextBox)GridView1.FooterRow.FindControl("txtstateid");
            TextBox tb2 = (TextBox)GridView1.FooterRow.FindControl("txtstatename");
            ObjectDataSource1.InsertParameters["StId"].DefaultValue = tb1.Text;
            ObjectDataSource1.InsertParameters["StName"].DefaultValue = tb2.Text;
            ObjectDataSource1.Insert();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //Row Deleting
            ObjectDataSource1.DeleteParameters["StId"].DefaultValue = e.Values[0].ToString();
            ObjectDataSource1.Delete();
        }
    }
}