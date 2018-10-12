namespace Acesso_Banco
{
    partial class frmConsulta
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtConsultarNome = new System.Windows.Forms.TextBox();
            this.btnConsultarNome = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtConsultarCpf = new System.Windows.Forms.TextBox();
            this.btnConsultarCpf = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(573, 249);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConsultarNome);
            this.groupBox1.Controls.Add(this.btnConsultarNome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 105);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta por Nome:";
            // 
            // txtConsultarNome
            // 
            this.txtConsultarNome.Location = new System.Drawing.Point(51, 24);
            this.txtConsultarNome.Name = "txtConsultarNome";
            this.txtConsultarNome.Size = new System.Drawing.Size(257, 20);
            this.txtConsultarNome.TabIndex = 6;
            // 
            // btnConsultarNome
            // 
            this.btnConsultarNome.Location = new System.Drawing.Point(128, 66);
            this.btnConsultarNome.Name = "btnConsultarNome";
            this.btnConsultarNome.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarNome.TabIndex = 5;
            this.btnConsultarNome.Text = "Consultar";
            this.btnConsultarNome.UseVisualStyleBackColor = true;
            this.btnConsultarNome.Click += new System.EventHandler(this.btnConsultarNome_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtConsultarCpf);
            this.groupBox2.Controls.Add(this.btnConsultarCpf);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(332, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 105);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta por CPF:";
            // 
            // txtConsultarCpf
            // 
            this.txtConsultarCpf.Location = new System.Drawing.Point(75, 27);
            this.txtConsultarCpf.MaxLength = 11;
            this.txtConsultarCpf.Name = "txtConsultarCpf";
            this.txtConsultarCpf.Size = new System.Drawing.Size(225, 20);
            this.txtConsultarCpf.TabIndex = 7;
            // 
            // btnConsultarCpf
            // 
            this.btnConsultarCpf.Location = new System.Drawing.Point(170, 66);
            this.btnConsultarCpf.Name = "btnConsultarCpf";
            this.btnConsultarCpf.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarCpf.TabIndex = 5;
            this.btnConsultarCpf.Text = "Consultar";
            this.btnConsultarCpf.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "CPF:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCpf);
            this.groupBox3.Controls.Add(this.lblNome);
            this.groupBox3.Controls.Add(this.lblId);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(13, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(635, 111);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado";
            // 
            // lblCpf
            // 
            this.lblCpf.BackColor = System.Drawing.Color.White;
            this.lblCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCpf.Location = new System.Drawing.Point(231, 63);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(225, 20);
            this.lblCpf.TabIndex = 15;
            // 
            // lblNome
            // 
            this.lblNome.BackColor = System.Drawing.Color.White;
            this.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNome.Location = new System.Drawing.Point(127, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(414, 20);
            this.lblNome.TabIndex = 14;
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.White;
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblId.Location = new System.Drawing.Point(127, 63);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(31, 20);
            this.lblId.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome:";
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 284);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVoltar);
            this.Name = "frmConsulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtConsultarNome;
        private System.Windows.Forms.Button btnConsultarNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtConsultarCpf;
        private System.Windows.Forms.Button btnConsultarCpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNome;
    }
}