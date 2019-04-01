using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class CadatroAuto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void butCada_Click(object sender, EventArgs e)
        {

            try
            {
                App.AnaliseLib.AutomovelDAL objauto = new App.AnaliseLib.AutomovelDAL();

                objauto.marca = txtMarca.SelectedItem.ToString();
                objauto.modelo = txtModelo.Text;
                objauto.ano = txtAno.Text;
                objauto.cor = txtCor.Text;
                objauto.chassi = txtChassi.Text;
                objauto.preco = txtPreco.Text;

                objauto.Create(objauto);

                lblResposta.Text = "Dados cadastrados!";
                lblResposta.BackColor = System.Drawing.Color.Green;
                lblResposta.Visible = true;
                
            }
            catch (Exception erro)
            {
                lblResposta.Text = "Preencha todos os campos!" + erro.Message;
                lblResposta.BackColor = System.Drawing.Color.Red;
                lblResposta.Visible = true;
            }
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Venda.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("BuscaAuto.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("AtualizarAuto.aspx");
        }
    }
}