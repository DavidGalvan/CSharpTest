﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSharpTest
{
    public partial class passdata1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSend_Click(object sender, EventArgs e)
        {
            //Page.Server.Transfer("passdata2.aspx");
            //Page.Response.Redirect("passdata3.aspx?text=" + TextBoxText.Text);
            Session["Text"] = TextBoxText.Text;
            Page.Response.Redirect("passdata4.aspx");

        }
    }
}