﻿namespace DHF
{
    partial class frmCadastroJuridico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.txtboxCidade = new System.Windows.Forms.TextBox();
            this.txtboxBairro = new System.Windows.Forms.TextBox();
            this.txtboxNum = new System.Windows.Forms.TextBox();
            this.txtboxLogradouro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxCNPJ = new System.Windows.Forms.TextBox();
            this.txtboxIE = new System.Windows.Forms.TextBox();
            this.txtboxNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxEstado);
            this.groupBox1.Controls.Add(this.txtboxCidade);
            this.groupBox1.Controls.Add(this.txtboxBairro);
            this.groupBox1.Controls.Add(this.txtboxNum);
            this.groupBox1.Controls.Add(this.txtboxLogradouro);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(15, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 157);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboxEstado
            // 
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Items.AddRange(new object[] {
            "AC  ",
            "AL  ",
            "AP  ",
            "AM  ",
            "BA  ",
            "CE  ",
            "DF  ",
            "ES",
            "GO ",
            "MA ",
            "MT ",
            "MS ",
            "MG ",
            "PA ",
            "PB",
            "PR ",
            "PE ",
            "PI ",
            "RJ  ",
            "RN  ",
            "RS ",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cboxEstado.Location = new System.Drawing.Point(361, 91);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(67, 21);
            this.cboxEstado.TabIndex = 9;
            this.cboxEstado.Text = "Escolha";
            // 
            // txtboxCidade
            // 
            this.txtboxCidade.Location = new System.Drawing.Point(61, 91);
            this.txtboxCidade.Name = "txtboxCidade";
            this.txtboxCidade.Size = new System.Drawing.Size(233, 20);
            this.txtboxCidade.TabIndex = 8;
            // 
            // txtboxBairro
            // 
            this.txtboxBairro.Location = new System.Drawing.Point(61, 56);
            this.txtboxBairro.Name = "txtboxBairro";
            this.txtboxBairro.Size = new System.Drawing.Size(271, 20);
            this.txtboxBairro.TabIndex = 7;
            // 
            // txtboxNum
            // 
            this.txtboxNum.Location = new System.Drawing.Point(386, 24);
            this.txtboxNum.Name = "txtboxNum";
            this.txtboxNum.Size = new System.Drawing.Size(52, 20);
            this.txtboxNum.TabIndex = 6;
            // 
            // txtboxLogradouro
            // 
            this.txtboxLogradouro.Location = new System.Drawing.Point(87, 24);
            this.txtboxLogradouro.Name = "txtboxLogradouro";
            this.txtboxLogradouro.Size = new System.Drawing.Size(267, 20);
            this.txtboxLogradouro.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(311, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Bairro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nº";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Logradouro:";
            // 
            // txtboxCNPJ
            // 
            this.txtboxCNPJ.Location = new System.Drawing.Point(245, 59);
            this.txtboxCNPJ.Name = "txtboxCNPJ";
            this.txtboxCNPJ.Size = new System.Drawing.Size(100, 20);
            this.txtboxCNPJ.TabIndex = 13;
            this.txtboxCNPJ.TextChanged += new System.EventHandler(this.txtboxCNPJ_TextChanged);
            // 
            // txtboxIE
            // 
            this.txtboxIE.Location = new System.Drawing.Point(38, 59);
            this.txtboxIE.Name = "txtboxIE";
            this.txtboxIE.Size = new System.Drawing.Size(100, 20);
            this.txtboxIE.TabIndex = 12;
            this.txtboxIE.TextChanged += new System.EventHandler(this.txtboxIE_TextChanged);
            // 
            // txtboxNome
            // 
            this.txtboxNome.Location = new System.Drawing.Point(57, 20);
            this.txtboxNome.Name = "txtboxNome";
            this.txtboxNome.Size = new System.Drawing.Size(321, 20);
            this.txtboxNome.TabIndex = 11;
            this.txtboxNome.TextChanged += new System.EventHandler(this.txtboxNome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "CNPJ:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "IE:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(375, 291);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(294, 291);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 16;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(456, 291);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmCadastroJuridico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 326);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtboxCNPJ);
            this.Controls.Add(this.txtboxIE);
            this.Controls.Add(this.txtboxNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadastroJuridico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cliente Jurídico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.TextBox txtboxCidade;
        private System.Windows.Forms.TextBox txtboxBairro;
        private System.Windows.Forms.TextBox txtboxNum;
        private System.Windows.Forms.TextBox txtboxLogradouro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxCNPJ;
        private System.Windows.Forms.TextBox txtboxIE;
        private System.Windows.Forms.TextBox txtboxNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
    }
}