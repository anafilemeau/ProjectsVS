namespace EditorDeTexto
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
            this.textoConteudo = new System.Windows.Forms.TextBox();
            this.botaoGrava = new System.Windows.Forms.Button();
            this.textoBusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoBusca = new System.Windows.Forms.Button();
            this.textoReplace = new System.Windows.Forms.TextBox();
            this.botaoReplace = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUpper = new System.Windows.Forms.Button();
            this.buttonLower = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoConteudo
            // 
            this.textoConteudo.Location = new System.Drawing.Point(12, 12);
            this.textoConteudo.Multiline = true;
            this.textoConteudo.Name = "textoConteudo";
            this.textoConteudo.Size = new System.Drawing.Size(260, 270);
            this.textoConteudo.TabIndex = 0;
            this.textoConteudo.TextChanged += new System.EventHandler(this.textoConteudo_TextChanged);
            // 
            // botaoGrava
            // 
            this.botaoGrava.Location = new System.Drawing.Point(101, 288);
            this.botaoGrava.Name = "botaoGrava";
            this.botaoGrava.Size = new System.Drawing.Size(75, 23);
            this.botaoGrava.TabIndex = 1;
            this.botaoGrava.Text = "Grava";
            this.botaoGrava.UseVisualStyleBackColor = true;
            this.botaoGrava.Click += new System.EventHandler(this.botaoGrava_Click);
            // 
            // textoBusca
            // 
            this.textoBusca.Location = new System.Drawing.Point(349, 12);
            this.textoBusca.Name = "textoBusca";
            this.textoBusca.Size = new System.Drawing.Size(169, 20);
            this.textoBusca.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Palavra1 :";
            // 
            // botaoBusca
            // 
            this.botaoBusca.Location = new System.Drawing.Point(349, 38);
            this.botaoBusca.Name = "botaoBusca";
            this.botaoBusca.Size = new System.Drawing.Size(75, 23);
            this.botaoBusca.TabIndex = 4;
            this.botaoBusca.Text = "Buscar";
            this.botaoBusca.UseVisualStyleBackColor = true;
            this.botaoBusca.Click += new System.EventHandler(this.botaoBusca_Click);
            // 
            // textoReplace
            // 
            this.textoReplace.Enabled = false;
            this.textoReplace.Location = new System.Drawing.Point(349, 131);
            this.textoReplace.Name = "textoReplace";
            this.textoReplace.Size = new System.Drawing.Size(184, 20);
            this.textoReplace.TabIndex = 5;
            // 
            // botaoReplace
            // 
            this.botaoReplace.Enabled = false;
            this.botaoReplace.Location = new System.Drawing.Point(349, 102);
            this.botaoReplace.Name = "botaoReplace";
            this.botaoReplace.Size = new System.Drawing.Size(114, 23);
            this.botaoReplace.TabIndex = 6;
            this.botaoReplace.Text = "Substituir por";
            this.botaoReplace.UseVisualStyleBackColor = true;
            this.botaoReplace.Click += new System.EventHandler(this.botaoReplace_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Palavra 2:";
            // 
            // buttonUpper
            // 
            this.buttonUpper.Location = new System.Drawing.Point(349, 186);
            this.buttonUpper.Name = "buttonUpper";
            this.buttonUpper.Size = new System.Drawing.Size(75, 23);
            this.buttonUpper.TabIndex = 8;
            this.buttonUpper.Text = "Maiúsculas";
            this.buttonUpper.UseVisualStyleBackColor = true;
            this.buttonUpper.Click += new System.EventHandler(this.buttonUpper_Click);
            // 
            // buttonLower
            // 
            this.buttonLower.Location = new System.Drawing.Point(443, 186);
            this.buttonLower.Name = "buttonLower";
            this.buttonLower.Size = new System.Drawing.Size(75, 23);
            this.buttonLower.TabIndex = 9;
            this.buttonLower.Text = "Minúsculas";
            this.buttonLower.UseVisualStyleBackColor = true;
            this.buttonLower.Click += new System.EventHandler(this.buttonLower_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 326);
            this.Controls.Add(this.buttonLower);
            this.Controls.Add(this.buttonUpper);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botaoReplace);
            this.Controls.Add(this.textoReplace);
            this.Controls.Add(this.botaoBusca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoBusca);
            this.Controls.Add(this.botaoGrava);
            this.Controls.Add(this.textoConteudo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoConteudo;
        private System.Windows.Forms.Button botaoGrava;
        private System.Windows.Forms.TextBox textoBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoBusca;
        private System.Windows.Forms.TextBox textoReplace;
        private System.Windows.Forms.Button botaoReplace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUpper;
        private System.Windows.Forms.Button buttonLower;
    }
}

