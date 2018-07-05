namespace Exercicio1
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
            this.tbox_nome1 = new System.Windows.Forms.TextBox();
            this.tbox_nome2 = new System.Windows.Forms.TextBox();
            this.tbox_nome3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbox_idade3 = new System.Windows.Forms.TextBox();
            this.tbox_idade2 = new System.Windows.Forms.TextBox();
            this.tbox_idade1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_maior = new System.Windows.Forms.Label();
            this.lbl_menor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbox_nome1
            // 
            this.tbox_nome1.Location = new System.Drawing.Point(73, 19);
            this.tbox_nome1.Name = "tbox_nome1";
            this.tbox_nome1.Size = new System.Drawing.Size(100, 20);
            this.tbox_nome1.TabIndex = 0;
            // 
            // tbox_nome2
            // 
            this.tbox_nome2.Location = new System.Drawing.Point(73, 61);
            this.tbox_nome2.Name = "tbox_nome2";
            this.tbox_nome2.Size = new System.Drawing.Size(100, 20);
            this.tbox_nome2.TabIndex = 1;
            this.tbox_nome2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbox_nome3
            // 
            this.tbox_nome3.Location = new System.Drawing.Point(73, 108);
            this.tbox_nome3.Name = "tbox_nome3";
            this.tbox_nome3.Size = new System.Drawing.Size(100, 20);
            this.tbox_nome3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Idade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Idade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Idade:";
            // 
            // tbox_idade3
            // 
            this.tbox_idade3.Location = new System.Drawing.Point(248, 108);
            this.tbox_idade3.Name = "tbox_idade3";
            this.tbox_idade3.Size = new System.Drawing.Size(100, 20);
            this.tbox_idade3.TabIndex = 8;
            // 
            // tbox_idade2
            // 
            this.tbox_idade2.Location = new System.Drawing.Point(248, 61);
            this.tbox_idade2.Name = "tbox_idade2";
            this.tbox_idade2.Size = new System.Drawing.Size(100, 20);
            this.tbox_idade2.TabIndex = 7;
            // 
            // tbox_idade1
            // 
            this.tbox_idade1.Location = new System.Drawing.Point(248, 19);
            this.tbox_idade1.Name = "tbox_idade1";
            this.tbox_idade1.Size = new System.Drawing.Size(100, 20);
            this.tbox_idade1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbox_nome1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbox_nome2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbox_nome3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbox_idade3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbox_idade2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbox_idade1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 144);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escreva os Nomes e Idades";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbl_menor);
            this.groupBox2.Controls.Add(this.lbl_maior);
            this.groupBox2.Location = new System.Drawing.Point(13, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 168);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // lbl_maior
            // 
            this.lbl_maior.BackColor = System.Drawing.Color.White;
            this.lbl_maior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_maior.Location = new System.Drawing.Point(79, 33);
            this.lbl_maior.Name = "lbl_maior";
            this.lbl_maior.Size = new System.Drawing.Size(78, 22);
            this.lbl_maior.TabIndex = 0;
            this.lbl_maior.Click += new System.EventHandler(this.lbl_maior_Click);
            // 
            // lbl_menor
            // 
            this.lbl_menor.BackColor = System.Drawing.Color.White;
            this.lbl_menor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_menor.Location = new System.Drawing.Point(79, 71);
            this.lbl_menor.Name = "lbl_menor";
            this.lbl_menor.Size = new System.Drawing.Size(78, 22);
            this.lbl_menor.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "label8";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 385);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Exercício";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_nome1;
        private System.Windows.Forms.TextBox tbox_nome2;
        private System.Windows.Forms.TextBox tbox_nome3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbox_idade3;
        private System.Windows.Forms.TextBox tbox_idade2;
        private System.Windows.Forms.TextBox tbox_idade1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_maior;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_menor;
        private System.Windows.Forms.Button button1;
    }
}

