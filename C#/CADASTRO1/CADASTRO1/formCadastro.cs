using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CADASTRO1
{
    public partial class formCadastro : Form
    {
        public formCadastro()
        {
            InitializeComponent();
        }

        private void menuClientesCad_Click(object sender, EventArgs e)
        {
            Cadastro x = new Cadastro();
            x.Show();
        }
    }
}
