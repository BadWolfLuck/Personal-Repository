namespace CADASTRO1
{
    partial class formCadastro
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
            this.menuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClientesCad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFornecedoresCad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClienteRela = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFornecedoresRela = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSairSair = new System.Windows.Forms.ToolStripMenuItem();
            this.prcProcesso = new System.Diagnostics.Process();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastros,
            this.menuRelatorios,
            this.menuSair});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(270, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // menuCadastros
            // 
            this.menuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClientesCad,
            this.menuFornecedoresCad});
            this.menuCadastros.Name = "menuCadastros";
            this.menuCadastros.Size = new System.Drawing.Size(71, 20);
            this.menuCadastros.Text = "Cadastros";
            // 
            // menuClientesCad
            // 
            this.menuClientesCad.Name = "menuClientesCad";
            this.menuClientesCad.Size = new System.Drawing.Size(180, 22);
            this.menuClientesCad.Text = "&Clientes";
            this.menuClientesCad.Click += new System.EventHandler(this.menuClientesCad_Click);
            // 
            // menuFornecedoresCad
            // 
            this.menuFornecedoresCad.Name = "menuFornecedoresCad";
            this.menuFornecedoresCad.Size = new System.Drawing.Size(180, 22);
            this.menuFornecedoresCad.Text = "Fornecedores";
            // 
            // menuRelatorios
            // 
            this.menuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClienteRela,
            this.menuFornecedoresRela});
            this.menuRelatorios.Name = "menuRelatorios";
            this.menuRelatorios.Size = new System.Drawing.Size(71, 20);
            this.menuRelatorios.Text = "Relatórios";
            // 
            // menuClienteRela
            // 
            this.menuClienteRela.Name = "menuClienteRela";
            this.menuClienteRela.Size = new System.Drawing.Size(180, 22);
            this.menuClienteRela.Text = "&Clientes";
            // 
            // menuFornecedoresRela
            // 
            this.menuFornecedoresRela.Name = "menuFornecedoresRela";
            this.menuFornecedoresRela.Size = new System.Drawing.Size(180, 22);
            this.menuFornecedoresRela.Text = "&Fornecedores";
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
            this.menuSairSair.Size = new System.Drawing.Size(180, 22);
            this.menuSairSair.Text = "Sair do Sistema";
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
            // formCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 255);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuPrincipal;
            this.MaximizeBox = false;
            this.Name = "formCadastro";
            this.Text = "Cadastro";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Diagnostics.Process prcProcesso;
        private System.Windows.Forms.ToolStripMenuItem menuCadastros;
        private System.Windows.Forms.ToolStripMenuItem menuClientesCad;
        private System.Windows.Forms.ToolStripMenuItem menuFornecedoresCad;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem menuClienteRela;
        private System.Windows.Forms.ToolStripMenuItem menuFornecedoresRela;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ToolStripMenuItem menuSairSair;
    }
}

