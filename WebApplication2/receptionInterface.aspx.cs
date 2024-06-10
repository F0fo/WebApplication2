using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class receptionInterface : System.Web.UI.Page
    { 
        branch branch1 = null;
        Table Table1 = null;
        public void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.DataSource = Restaurant.getBranch();
            DropDownList1.DataBind();
            DropDownList1.Items[0].Selected = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            branch1.addTable(B2.Text, Int32.Parse(B1.Text));
        }

        protected void Unnamed1_SelectedIndexChanged(object sender, EventArgs e)
        {
            branch1 = Restaurant.getBranch(DropDownList1.SelectedItem.ToString());
            Label2.Text = "Branch Selected " + branch1;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Table1 = branch1.GetTable(DropDownList1.SelectedItem.ToString());
            Label1.Text = "Table Selected " + Table1;
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            branch1.RemoveTable(Table1.getTableNo());
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Table1.setSeatCount(Int32.Parse(TextBox1.Text));
            Table1.setAvailable(Available.Checked);
        }
    }
}