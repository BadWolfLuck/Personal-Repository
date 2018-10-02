using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aprendendo_MVC
{
    public partial class frmConsultarCliente : Form
    {
        OracleConnection conn = new OracleConnection("DATASOURCE=;PASSWORD=GA344IGGBAL,USER ID=LUCAS");
        Cliente C1;
        ctr_Cliente ctr_Cliente;
        public frmConsultarCliente()
        {
            InitializeComponent();
            ctr_Cliente = new ctr_Cliente();
            C1 = new Cliente();

            C1 = ctr_Cliente.Consultar(C1);
            
            lbl_Nome.Text = C1.nome;
            lbl_CPF.Text = Convert.ToString(C1.cpf);
            lbl_Endereco.Text = C1.endereco;
            lbl_Idade.Text = Convert.ToString(C1.idade);
            lbl_Limite.Text = Convert.ToString(C1.limite);
            lbl_RG.Text = Convert.ToString(C1.rg);

        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmConsultarCliente_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Nome_Click(object sender, EventArgs e)
        {

        }
    }
}
