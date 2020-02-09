using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSharpTest
{
    public partial class debugme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCrash_Click(object sender, EventArgs e)
        {
            int Denominator = 0;
            LabelResult.Text = (10 / Denominator).ToString();
        }
    }
}