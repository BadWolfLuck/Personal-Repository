using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MENU
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuSairSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja sair?", "Encerrar Aplicação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuCalcApl_Click(object sender, EventArgs e)
        {
            prcProcesso.StartInfo.FileName = "Calc.exe";
            prcProcesso.Start();
        }

        private void menuWordApl_Click(object sender, EventArgs e)
        {
            prcProcesso.StartInfo.FileName = "winWord.exe";
            prcProcesso.Start();
        }

        private void menuExcelApl_Click(object sender, EventArgs e)
        {
            prcProcesso.StartInfo.FileName = "Excel.exe";
            prcProcesso.Start();
        }

        private void menuLifeStrangeProg_Click(object sender, EventArgs e)
        {
            prcProcesso.StartInfo.FileName = @"steam://rungameid/319630";
            //prcProcesso.StartInfo.FileName = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Life Is Strange\\Binaries\\Win32\\LifeIsStrange.exe";
            prcProcesso.Start();
        }

        private void menuLolProg_Click(object sender, EventArgs e)
        {
            prcProcesso.StartInfo.FileName = @"C:\Riot Games\League of Legends\LeagueClient.exe";
            prcProcesso.Start();
        }

        private void menuSomatoriaProg_Click(object sender, EventArgs e)
        {
            frmSomatorio soma = new frmSomatorio();
            soma.Show();
            
        }
    }
}
