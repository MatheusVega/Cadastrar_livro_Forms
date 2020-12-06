namespace Books
{
    partial class Cadastrar
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
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textAutor = new System.Windows.Forms.TextBox();
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.checkFisico = new System.Windows.Forms.CheckBox();
            this.checkVirtual = new System.Windows.Forms.CheckBox();
            this.comboNota = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textQuant = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnviar.Location = new System.Drawing.Point(565, 228);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Padding = new System.Windows.Forms.Padding(2);
            this.buttonEnviar.Size = new System.Drawing.Size(114, 45);
            this.buttonEnviar.TabIndex = 0;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do Livro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome do Autor:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(132, 43);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(547, 20);
            this.textNome.TabIndex = 5;
            this.textNome.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            // 
            // textAutor
            // 
            this.textAutor.Location = new System.Drawing.Point(132, 75);
            this.textAutor.Name = "textAutor";
            this.textAutor.Size = new System.Drawing.Size(547, 20);
            this.textAutor.TabIndex = 6;
            // 
            // textDescricao
            // 
            this.textDescricao.Location = new System.Drawing.Point(132, 111);
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(547, 20);
            this.textDescricao.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data Inicio:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(132, 150);
            this.maskedTextBox1.Mask = "00-00-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(80, 20);
            this.maskedTextBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data Termino:";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(392, 148);
            this.maskedTextBox2.Mask = "00-00-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(80, 20);
            this.maskedTextBox2.TabIndex = 12;
            this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // checkFisico
            // 
            this.checkFisico.AutoSize = true;
            this.checkFisico.Location = new System.Drawing.Point(67, 191);
            this.checkFisico.Name = "checkFisico";
            this.checkFisico.Size = new System.Drawing.Size(53, 17);
            this.checkFisico.TabIndex = 14;
            this.checkFisico.Text = "Fisico";
            this.checkFisico.UseVisualStyleBackColor = true;
            this.checkFisico.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkVirtual
            // 
            this.checkVirtual.AutoSize = true;
            this.checkVirtual.Location = new System.Drawing.Point(157, 191);
            this.checkVirtual.MaximumSize = new System.Drawing.Size(100, 100);
            this.checkVirtual.Name = "checkVirtual";
            this.checkVirtual.Size = new System.Drawing.Size(55, 17);
            this.checkVirtual.TabIndex = 15;
            this.checkVirtual.Text = "Virtual";
            this.checkVirtual.UseVisualStyleBackColor = true;
            // 
            // comboNota
            // 
            this.comboNota.FormattingEnabled = true;
            this.comboNota.Location = new System.Drawing.Point(132, 228);
            this.comboNota.Name = "comboNota";
            this.comboNota.Size = new System.Drawing.Size(211, 21);
            this.comboNota.TabIndex = 16;
            this.comboNota.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Nota do Livro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "ID Livro:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(132, 9);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(547, 20);
            this.textID.TabIndex = 19;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.Location = new System.Drawing.Point(418, 228);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Padding = new System.Windows.Forms.Padding(2);
            this.buttonConsultar.Size = new System.Drawing.Size(114, 45);
            this.buttonConsultar.TabIndex = 20;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrar.Location = new System.Drawing.Point(418, 299);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Padding = new System.Windows.Forms.Padding(2);
            this.buttonCadastrar.Size = new System.Drawing.Size(114, 45);
            this.buttonCadastrar.TabIndex = 21;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Quantidade de Livros:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textQuant
            // 
            this.textQuant.Location = new System.Drawing.Point(192, 272);
            this.textQuant.Name = "textQuant";
            this.textQuant.Size = new System.Drawing.Size(77, 20);
            this.textQuant.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(565, 150);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(2);
            this.button1.Size = new System.Drawing.Size(114, 45);
            this.button1.TabIndex = 24;
            this.button1.Text = "Total";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(565, 299);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(2);
            this.button2.Size = new System.Drawing.Size(114, 45);
            this.button2.TabIndex = 25;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 385);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textQuant);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboNota);
            this.Controls.Add(this.checkVirtual);
            this.Controls.Add(this.checkFisico);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textDescricao);
            this.Controls.Add(this.textAutor);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEnviar);
            this.Name = "Cadastrar";
            this.Text = "Livros Lidos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnviar;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textAutor;
        private System.Windows.Forms.TextBox textDescricao;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.CheckBox checkFisico;
        private System.Windows.Forms.CheckBox checkVirtual;
        private System.Windows.Forms.ComboBox comboNota;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Button buttonCadastrar;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textQuant;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

