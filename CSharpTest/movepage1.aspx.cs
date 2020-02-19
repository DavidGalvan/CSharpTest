using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSharpTest
{
    public partial class movepage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonMove_Click(object sender, EventArgs e)
        {
            Page.Server.TransferRequest("movepage2.aspx");
        }
    }
}