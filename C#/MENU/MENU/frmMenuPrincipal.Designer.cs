namespace MENU
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuAplicativos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWordApl = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExcelApl = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCalcApl = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProgamas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSairSair = new System.Windows.Forms.ToolStripMenuItem();
            this.prcProcesso = new System.Diagnostics.Process();
            this.menuLifeStrangeProg = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLolProg = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSomatoriaProg = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAplicativos,
            this.menuProgamas,
            this.menuSair});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(411, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // menuAplicativos
            // 
            this.menuAplicativos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuWordApl,
            this.menuExcelApl,
            this.toolStripMenuItem1,
            this.menuCalcApl});
            this.menuAplicativos.Name = "menuAplicativos";
            this.menuAplicativos.Size = new System.Drawing.Size(77, 20);
            this.menuAplicativos.Text = "Aplicativos";
            // 
            // menuWordApl
            // 
            this.menuWordApl.Name = "menuWordApl";
            this.menuWordApl.Size = new System.Drawing.Size(137, 22);
            this.menuWordApl.Text = "&Word";
            this.menuWordApl.Click += new System.EventHandler(this.menuWordApl_Click);
            // 
            // menuExcelApl
            // 
            this.menuExcelApl.Name = "menuExcelApl";
            this.menuExcelApl.Size = new System.Drawing.Size(137, 22);
            this.menuExcelApl.Text = "&Excel";
            this.menuExcelApl.Click += new System.EventHandler(this.menuExcelApl_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(134, 6);
            // 
            // menuCalcApl
            // 
            this.menuCalcApl.Name = "menuCalcApl";
            this.menuCalcApl.Size = new System.Drawing.Size(137, 22);
            this.menuCalcApl.Text = "&Calculadora";
            this.menuCalcApl.Click += new System.EventHandler(this.menuCalcApl_Click);
            // 
            // menuProgamas
            // 
            this.menuProgamas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLifeStrangeProg,
            this.menuLolProg,
            this.menuSomatoriaProg});
            this.menuProgamas.Name = "menuProgamas";
            this.menuProgamas.Size = new System.Drawing.Size(67, 20);
            this.menuProgamas.Text = "Progama";
            // 
            // menuSair
            // 
            this.menuSair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSairSair});
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(38, 20);
            this.menuSair.Text = "Sair";
            // 
            // menuSairSair
            // 
            this.menuSairSair.Name = "menuSairSair";
            this.menuSairSair.Size = new System.Drawing.Size(154, 22);
            this.menuSairSair.Text = "&Sair do Sistema";
            this.menuSairSair.Click += new System.EventHandler(this.menuSairSair_Click);
            // 
            // prcProcesso
            // 
            this.prcProcesso.StartInfo.Domain = "";
            this.prcProcesso.StartInfo.LoadUserProfile = false;
            this.prcProcesso.StartInfo.Password = null;
            this.prcProcesso.StartInfo.StandardErrorEncoding = null;
            this.prcProcesso.StartInfo.StandardOutputEncoding = null;
            this.prcProcesso.StartInfo.UserName = "";
            this.prcProcesso.SynchronizingObject = this;
            // 
            // menuLifeStrangeProg
            // 
            this.menuLifeStrangeProg.Name = "menuLifeStrangeProg";
            this.menuLifeStrangeProg.Size = new System.Drawing.Size(180, 22);
            this.menuLifeStrangeProg.Text = "Life Is Strange";
            this.menuLifeStrangeProg.Click += new System.EventHandler(this.menuLifeStrangeProg_Click);
            // 
            // menuLolProg
            // 
            this.menuLolProg.Name = "menuLolProg";
            this.menuLolProg.Size = new System.Drawing.Size(180, 22);
            this.menuLolProg.Text = "&League Of Legends";
            this.menuLolProg.Click += new System.EventHandler(this.menuLolProg_Click);
            // 
            // menuSomatoriaProg
            // 
            this.menuSomatoriaProg.Name = "menuSomatoriaProg";
            this.menuSomatoriaProg.Size = new System.Drawing.Size(180, 22);
            this.menuSomatoriaProg.Text = "&Somatória";
            this.menuSomatoriaProg.Click += new System.EventHandler(this.menuSomatoriaProg_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 259);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "frmMenuPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuAplicativos;
        private System.Windows.Forms.ToolStripMenuItem menuProgamas;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ToolStripMenuItem menuWordApl;
        private System.Windows.Forms.ToolStripMenuItem menuExcelApl;
        private System.Windows.Forms.ToolStripMenuItem menuCalcApl;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuSairSair;
        private System.Diagnostics.Process prcProcesso;
        private System.Windows.Forms.ToolStripMenuItem menuLifeStrangeProg;
        private System.Windows.Forms.ToolStripMenuItem menuLolProg;
        private System.Windows.Forms.ToolStripMenuItem menuSomatoriaProg;
    }
}

