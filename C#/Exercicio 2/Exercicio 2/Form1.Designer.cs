namespace Exercicio_2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtBox_CustoFabrica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.lbl_CustoFinal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_CustoFabrica
            // 
            this.txtBox_CustoFabrica.Location = new System.Drawing.Point(108, 6);
            this.txtBox_CustoFabrica.Name = "txtBox_CustoFabrica";
            this.txtBox_CustoFabrica.Size = new System.Drawing.Size(139, 20);
            this.txtBox_CustoFabrica.TabIndex = 0;
            this.txtBox_CustoFabrica.TextChanged += new System.EventHandler(this.txtBox_CustoFabrica_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Custo de Fábrica:";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Calcular.Location = new System.Drawing.Point(268, 6);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(156, 36);
            this.btn_Calcular.TabIndex = 2;
            this.btn_Calcular.Text = "Calcular Custo Final";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // lbl_CustoFinal
            // 
            this.lbl_CustoFinal.BackColor = System.Drawing.Color.White;
            this.lbl_CustoFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_CustoFinal.Location = new System.Drawing.Point(108, 47);
            this.lbl_CustoFinal.Name = "lbl_CustoFinal";
            this.lbl_CustoFinal.Size = new System.Drawing.Size(139, 20);
            this.lbl_CustoFinal.TabIndex = 1;
            this.lbl_CustoFinal.Click += new System.EventHandler(this.lbl_CustoFinal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Custo Final:";
            // 
            // btn_Sair
            // 
            this.btn_Sair.AllowDrop = true;
            this.btn_Sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sair.ForeColor = System.Drawing.Color.Black;
            this.btn_Sair.Location = new System.Drawing.Point(349, 48);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.btn_Sair.TabIndex = 4;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limpar.Location = new System.Drawing.Point(268, 48);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpar.TabIndex = 5;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 90);
            this.Controls.Add(this.lbl_CustoFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_CustoFabrica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_CustoFabrica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label lbl_CustoFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Limpar;
    }
}

