using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAulaMasterPage
{
    public partial class frmPrincipal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtUsuario.Focus();
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnQuemSomos_Click(object sender, EventArgs e)
        {
            Server.Transfer("frmQuemSomos.aspx", false);
        }

        protected void btnClientes_Click(object sender, EventArgs e)
        {
            Server.Transfer("frmClientes.aspx", false);
        }

        protected void btnLocalizacao_Click(object sender, EventArgs e)
        {
            Server.Transfer("frmLocalizacao.aspx", false);
        }

        protected void btnContato_Click(object sender, EventArgs e)
        {
            Server.Transfer("frmContato.aspx", false);
        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            Server.Transfer("frmCadastro.aspx", true);
        }
    }
}