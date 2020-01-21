using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mynew2
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            //menu program
            if(e.Item.Text.Equals("Home"))
            {
                Response.Redirect("Home.aspx");
            }
            else if (e.Item.Text.Equals("State"))
            {
                Response.Redirect("State.aspx");
            }
            if (e.Item.Text.Equals("City"))
            {
                Response.Redirect("City.aspx");
            }
            if (e.Item.Text.Equals("Dept"))
            {
                Response.Redirect("Dept.aspx");
            }
            if (e.Item.Text.Equals("Employee"))
            {
                Response.Redirect("Employee.aspx");
            }
        }
    }
}