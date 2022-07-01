using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAgenda
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bt_Login_Click(object sender, EventArgs e)
        {
            String email = txb_Email.Text;
            String senha = txb_Senha.Text;
            // Capturar a string de conexão
            System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
            System.Configuration.ConnectionStringSettings connString;
            connString = rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionString"];
            //Cria um objeto de
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connString.ToString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from usuario where email = @email and senha = @senha";
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("senha", senha);
            con.Open();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                //Cookie
                HttpCookie LoginWeb = new HttpCookie("LoginWeb", txb_Email.Text);
                Response.Cookies.Add(LoginWeb);
              
                //Direcionar par apágina principal
                Response.Redirect("~/Index.aspx");
            }
            else
            {
                Response.Write("<script> alert('E-mail ou senha incorretos!!!');</script>");
                //Lmsg.Text = "email ou senha incorretos!!!";
            }

        }
    }
}