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
        branch branch1 = Restaurant.getBranch("0");
        Table Table1 = null;
        public void Page_Load(object sender, EventArgs e)
        {
            DropDownList2.DataSource = Restaurant.getBranch();
            DropDownList1.DataSource = branch1.getTableList();
            DropDownList1.DataBind();
            DropDownList2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            branch1.addTable(B2.Text, Int32.Parse(B1.Text));
        }

        protected void Unnamed1_SelectedIndexChanged(object sender, EventArgs e)
        {   
            
            branch1 = Restaurant.getBranch(DropDownList1.SelectedItem.ToString());
            Label2.Text = "Branch Selected " + branch1;
            DropDownList1.DataSource = branch1.getTableList();
            DropDownList1.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Table1 = branch1.GetTable(DropDownList1.SelectedItem.ToString());
            Label1.Text = "yes";
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            branch1.RemoveTable(Table1.getTableNo());
            String s = "";
            foreach (var table in branch1.getTableList())
            {
               s+= table + "";
            }
            Label1.Text = Table1.getTableNo();
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Table1.setSeatCount(Int32.Parse(TextBox1.Text));
            Table1.setAvailable(Available.Checked);
        }
    }
}