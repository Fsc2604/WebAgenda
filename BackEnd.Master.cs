using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAgenda
{
    public partial class BackEnd : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["LoginWeb"] == null)
            {
                Response.Redirect("~/LoginWeb.aspx");
            }
        }
    }
}