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
        public void Page_Load(object sender, EventArgs e)
        {
            Restaurant restaurant = new Restaurant("KFC");
            restaurant.addBranch("0", "Sigma Strasse");
            branch1 = restaurant.getBranch("0");
            branch1.addTable("0", 1);
            DropDownList1.DataSource = branch1.getTableList();
            DropDownList1.DataBind();
            DropDownList1.Items[0].Selected = true;

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Table table =  branch1.GetTable(DropDownList1.SelectedItem.ToString());
            Label1.Text="Table Selected " + table;
        }
    }
}