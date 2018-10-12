using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acesso_Banco
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            int i =0;
            for (i = 0; i > 1000;i++)
            {
           
            }
            this.Visible = false;
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();



        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
