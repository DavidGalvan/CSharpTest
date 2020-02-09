using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSharpTest
{
    public partial class viewstatetest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonChangeText_Click(object sender, EventArgs e)
        {
            LabelText.Text = "Text Changed!";
        }

        protected void ButtonPostBack_Click(object sender, EventArgs e)
        {

        }
    }
}