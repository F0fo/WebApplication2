﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Restaurant.addBranch("0", "Sigma Strasse");
            Restaurant.addBranch("1", "Alpha Strasse");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("waiterInterface.aspx");
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("receptionInterface.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("managerInterface.aspx");
        }
    }
}