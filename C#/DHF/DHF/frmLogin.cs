using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DHF
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            //Primeira gambiarra kkkk
            /*frmSplashScreen SplashScreen = new frmSplashScreen();
            SplashScreen.Show();
            //Gambiarra para exibir imagen durante 3 segundos.
            double i = 0;
            while(i < 199999990)
            {
                i++;
            }
            //Fim Gambiarra.
            SplashScreen.Close();
            */
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente deseja sair?", "Sair", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtboxLogin.Text != "")
            {
                if (txtboxSenha.Text != "")
                {
                    frmIndex Index = new frmIndex();
                    Index.Show();
                    Close();
                    //Visible = false;
                }
                else
                {
                    MessageBox.Show("Digite a Senha", "Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    //txtboxLogin.Text = txtboxSenha.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Digite o Login", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               //txtboxLogin.Text = txtboxSenha.Text = "";
            }
           
            

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtboxLogin.Text = txtboxSenha.Text = "";
        }
    }
}
