using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAgenda
{
    public partial class Contatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbEmail.Text != "" && txbNome.Text != "" && txbTelefone.Text != "")
                {

                    // Capturar a string de conexão
                    System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
                    System.Configuration.ConnectionStringSettings connString;
                    connString = rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionString"];
                    //Cria um objeto de
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = connString.ToString();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "Insert into contato (nome,email,telefone) values (@nome,@email,@telefone)";
                    cmd.Parameters.AddWithValue("nome", txbNome.Text);
                    cmd.Parameters.AddWithValue("Email", txbEmail.Text);
                    cmd.Parameters.AddWithValue("Telefone", txbTelefone.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    GridView1.DataBind();
                }
                else
                {
                    throw new Exception("Campos em branco");
                }
            }catch(Exception erro)
            {
                Response.Write("<script> alert ('" + erro.Message + "'); </script>");
            }
        }
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}