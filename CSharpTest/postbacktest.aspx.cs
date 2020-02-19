using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSharpTest
{
    public partial class postbacktest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelIsPostBack.Text = Page.IsPostBack.ToString();

        }
    }
}