using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class AtualizarAuto : System.Web.UI.Page
    {
        App.AnaliseLib.AutomovelDAL obj = new App.AnaliseLib.AutomovelDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string id = Request.QueryString["id"];
                App.AnaliseLib.AutomovelDAL carro = obj.Get(int.Parse(id));
                txtAno.Text = carro.ano;
                txtChassi.Text = carro.chassi;
                txtCor.Text = carro.cor;
                txtModelo.Text = carro.modelo;
            }
            catch { }
            if(!IsPostBack)
            {

            }
        }

        public void preencher()
        {
            string id = Request.QueryString["id"];
            obj.marca = txtMarca.Text;
            obj.modelo = txtModelo.Text;
            obj.ano = txtAno.Text;
            obj.cor = txtCor.Text;
            obj.chassi = txtChassi.Text;
            obj.preco = txtPreco.Text;
           
        }

        protected void butAtu_Click(object sender, EventArgs e)
        {
            try
            {

                obj.id = int.Parse(Request.QueryString["id"]);
                obj.marca = txtMarca.Text;
                obj.modelo = txtModelo.Text;
                obj.ano = txtAno.Text;
                obj.cor = txtCor.Text;
                obj.chassi = txtChassi.Text;
                obj.preco = txtPreco.Text;

                obj.Update(obj);

                lblResposta.Text = "Dados Atualizados!";
                lblResposta.BackColor = System.Drawing.Color.Green;
                lblResposta.Visible = true;
            }
            catch (Exception erro)
            {
                lblResposta.Text = "Algo deu errado!" + erro.Message;
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
            Response.Redirect("CadastroAuto.aspx");
        }
    }
}