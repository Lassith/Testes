using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Venda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            App.AnaliseLib.AutomovelDAL obj = new App.AnaliseLib.AutomovelDAL();

            obj.marca = txtMarca.SelectedItem.ToString();

            GridCompra.DataSource = obj.Get();
            GridCompra.DataBind();
        }

        protected void GridCompra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}