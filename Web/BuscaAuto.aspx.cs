using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class BuscaAuto : System.Web.UI.Page
    {
        App.AnaliseLib.AutomovelDAL obj = new App.AnaliseLib.AutomovelDAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Grid();
            }

        }

        private void Grid()
        {
            obj.marca = txtMarca.SelectedItem.ToString();
            GridAuto.DataSource = obj.Get();
            GridAuto.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            App.AnaliseLib.AutomovelDAL obj = new App.AnaliseLib.AutomovelDAL();

            Grid();
        }

        protected void GridAuto_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            App.AnaliseLib.AutomovelDAL obj = new App.AnaliseLib.AutomovelDAL();
            if (e.CommandName == "Editar")
            {
                Response.Redirect("AtualizarAuto.aspx?id=" + e.CommandArgument);
                                         
            }

            if (e.CommandName == "Apagar")
            {

                obj.Delete(Convert.ToInt32(e.CommandArgument));
                Grid();
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AtualizarAuto.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Venda.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastroAuto.aspx");
        }

    }
}