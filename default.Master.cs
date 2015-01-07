using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspPVBopdracht
{
    public partial class _default : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            lblTitleHere.Text = Convert.ToString(Session["titel"]);

        }
    }
}