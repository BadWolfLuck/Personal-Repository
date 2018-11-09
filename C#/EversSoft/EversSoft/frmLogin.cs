using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EversSoft
{
    public partial class frmLogin : Form
    {
        public bool Logado { get; set; }
        public string Usuario { get; set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtboxLogin.Text == "admin" && txtboxSenha.Text == "admin")
            {
                Logado = true;
                Usuario = txtboxLogin.Text;

                this.Close();
            }
            else
            {
                MessageBox.Show("Erro usuário ou senha inválidos");
            }
        }

        private void txtboxSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
