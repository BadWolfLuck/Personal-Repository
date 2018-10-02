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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void tmrProgresso_Tick(object sender, EventArgs e)
        {
            if(prgSplash.Value<100 )
            {
                prgSplash.Value += 10;
                if (picNoz.Location.X < 640)
                {
                    this.picNoz.Location = new Point(picNoz.Location.X + Convert.ToInt32(3.5), picNoz.Location.Y + 0);
                }
            }
            else
            {
                tmrProgresso.Enabled = false;
                frmLogin Login = new frmLogin();
                Login.Show();
                Visible = false;
            }
        }

        private void prgSplash_Click(object sender, EventArgs e)
        {

        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void tmrNoz_Tick(object sender, EventArgs e)
        {
          /* if (picNoz.Location.X < 640)
            {
                picNoz.Location = new Point(picNoz.Location.X + Convert.ToInt32(3.5), picNoz.Location.Y + 0);
            }*/
        }

        private void picNoz_Click(object sender, EventArgs e)
        {

        }
    }

}
