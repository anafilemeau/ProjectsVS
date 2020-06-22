namespace Banco
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.textSaldo = new System.Windows.Forms.TextBox();
            this.textValor = new System.Windows.Forms.TextBox();
            this.textTitular = new System.Windows.Forms.TextBox();
            this.Saca = new System.Windows.Forms.Button();
            this.Deposita = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.CriarNovaConta = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textTipo = new System.Windows.Forms.TextBox();
            this.textBusca = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonBusca = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.botaoRelatorios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titular:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor (R$):";
            // 
            // textNumero
            // 
            this.textNumero.Enabled = false;
            this.textNumero.Location = new System.Drawing.Point(138, 158);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(100, 20);
            this.textNumero.TabIndex = 5;
            // 
            // textSaldo
            // 
            this.textSaldo.Enabled = false;
            this.textSaldo.Location = new System.Drawing.Point(138, 184);
            this.textSaldo.Name = "textSaldo";
            this.textSaldo.Size = new System.Drawing.Size(100, 20);
            this.textSaldo.TabIndex = 6;
            this.textSaldo.TextChanged += new System.EventHandler(this.textSaldo_TextChanged);
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(138, 245);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(100, 20);
            this.textValor.TabIndex = 7;
            // 
            // textTitular
            // 
            this.textTitular.Enabled = false;
            this.textTitular.Location = new System.Drawing.Point(138, 132);
            this.textTitular.Name = "textTitular";
            this.textTitular.Size = new System.Drawing.Size(100, 20);
            this.textTitular.TabIndex = 10;
            this.textTitular.TextChanged += new System.EventHandler(this.textTitular_TextChanged);
            // 
            // Saca
            // 
            this.Saca.Location = new System.Drawing.Point(36, 296);
            this.Saca.Name = "Saca";
            this.Saca.Size = new System.Drawing.Size(75, 23);
            this.Saca.TabIndex = 11;
            this.Saca.Text = "Saca (R$)";
            this.Saca.UseVisualStyleBackColor = true;
            this.Saca.Click += new System.EventHandler(this.Saca_Click);
            // 
            // Deposita
            // 
            this.Deposita.Location = new System.Drawing.Point(138, 296);
            this.Deposita.Name = "Deposita";
            this.Deposita.Size = new System.Drawing.Size(91, 23);
            this.Deposita.TabIndex = 12;
            this.Deposita.Text = "Deposita (R$)";
            this.Deposita.UseVisualStyleBackColor = true;
            this.Deposita.Click += new System.EventHandler(this.Deposita_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "TestaTotal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Busca de Conta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Escolha a conta:";
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(138, 38);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(121, 21);
            this.comboContas.TabIndex = 17;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // CriarNovaConta
            // 
            this.CriarNovaConta.Location = new System.Drawing.Point(138, 326);
            this.CriarNovaConta.Name = "CriarNovaConta";
            this.CriarNovaConta.Size = new System.Drawing.Size(100, 23);
            this.CriarNovaConta.TabIndex = 18;
            this.CriarNovaConta.Text = "Criar Nova Conta";
            this.CriarNovaConta.UseVisualStyleBackColor = true;
            this.CriarNovaConta.Click += new System.EventHandler(this.CriarNovaConta_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tipo:";
            // 
            // textTipo
            // 
            this.textTipo.Enabled = false;
            this.textTipo.Location = new System.Drawing.Point(138, 215);
            this.textTipo.Name = "textTipo";
            this.textTipo.Size = new System.Drawing.Size(100, 20);
            this.textTipo.TabIndex = 20;
            // 
            // textBusca
            // 
            this.textBusca.Location = new System.Drawing.Point(138, 65);
            this.textBusca.Name = "textBusca";
            this.textBusca.Size = new System.Drawing.Size(100, 20);
            this.textBusca.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Busca por titular:";
            // 
            // buttonBusca
            // 
            this.buttonBusca.Location = new System.Drawing.Point(244, 63);
            this.buttonBusca.Name = "buttonBusca";
            this.buttonBusca.Size = new System.Drawing.Size(34, 23);
            this.buttonBusca.TabIndex = 23;
            this.buttonBusca.Text = "OK";
            this.buttonBusca.UseVisualStyleBackColor = true;
            this.buttonBusca.Click += new System.EventHandler(this.buttonBusca_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Conta";
            // 
            // botaoRelatorios
            // 
            this.botaoRelatorios.Location = new System.Drawing.Point(278, 306);
            this.botaoRelatorios.Name = "botaoRelatorios";
            this.botaoRelatorios.Size = new System.Drawing.Size(75, 23);
            this.botaoRelatorios.TabIndex = 25;
            this.botaoRelatorios.Text = "Relatorios";
            this.botaoRelatorios.UseVisualStyleBackColor = true;
            this.botaoRelatorios.Click += new System.EventHandler(this.botaoRelatorios_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 352);
            this.Controls.Add(this.botaoRelatorios);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonBusca);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBusca);
            this.Controls.Add(this.textTipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CriarNovaConta);
            this.Controls.Add(this.comboContas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Deposita);
            this.Controls.Add(this.Saca);
            this.Controls.Add(this.textTitular);
            this.Controls.Add(this.textValor);
            this.Controls.Add(this.textSaldo);
            this.Controls.Add(this.textNumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Banco da Ana";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.TextBox textSaldo;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.TextBox textTitular;
        private System.Windows.Forms.Button Saca;
        private System.Windows.Forms.Button Deposita;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.Button CriarNovaConta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textTipo;
        private System.Windows.Forms.TextBox textBusca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonBusca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button botaoRelatorios;
    }
}

