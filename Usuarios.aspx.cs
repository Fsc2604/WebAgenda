using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAgenda
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource1Usuarios_Inserted(object sender, SqlDataSourceStatusEventArgs e)
        {
            if (e.Exception != null)
            {
                Lmsg.Text = "Você esta inserindo um registro duplicado ou com campos em branco";
                e.ExceptionHandled = true;
            }
        }

        protected void SqlDataSource1Usuarios_Updated(object sender, SqlDataSourceStatusEventArgs e)
        {
            if (e.Exception != null)
            {
                Lmsg.Text = "Alterando um registro sem informar todos os campos";
                e.ExceptionHandled = true;
            }
        }
    }
}