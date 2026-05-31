namespace LojinhaDevoNada.Forms
{
    partial class CadastrarDividas
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
            lblErro = new Label();
            lblSucess = new Label();
            btnVoltar = new Button();
            btnLimpar = new Button();
            nudValor = new NumericUpDown();
            maskedTextBox1 = new MaskedTextBox();
            btnBuscar = new Button();
            lblNome = new Label();
            lblEmail = new Label();
            btnCadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudValor).BeginInit();
            SuspendLayout();
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.Location = new Point(256, 304);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(38, 15);
            lblErro.TabIndex = 1;
            lblErro.Text = "label1";
            // 
            // lblSucess
            // 
            lblSucess.AutoSize = true;
            lblSucess.Location = new Point(325, 328);
            lblSucess.Name = "lblSucess";
            lblSucess.Size = new Size(38, 15);
            lblSucess.TabIndex = 2;
            lblSucess.Text = "label1";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(124, 299);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click_1;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(119, 244);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // nudValor
            // 
            nudValor.DecimalPlaces = 2;
            nudValor.Location = new Point(243, 162);
            nudValor.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudValor.Name = "nudValor";
            nudValor.Size = new Size(120, 23);
            nudValor.TabIndex = 7;
            nudValor.ThousandsSeparator = true;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(250, 69);
            maskedTextBox1.Mask = "000.000.000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 8;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(380, 69);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(254, 109);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(38, 15);
            lblNome.TabIndex = 10;
            lblNome.Text = "label1";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(258, 137);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(38, 15);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "label1";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(91, 164);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 12;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click_1;
            // 
            // CadastrarDividas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Controls.Add(btnBuscar);
            Controls.Add(maskedTextBox1);
            Controls.Add(nudValor);
            Controls.Add(btnLimpar);
            Controls.Add(btnVoltar);
            Controls.Add(lblSucess);
            Controls.Add(lblErro);
            Name = "CadastrarDividas";
            Text = "CadastrarDividas";
            ((System.ComponentModel.ISupportInitialize)nudValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblErro;
        private Label lblSucess;
        private Button btnVoltar;
        private Button btnLimpar;
        private NumericUpDown nudValor;
        private MaskedTextBox maskedTextBox1;
        private Button btnBuscar;
        private Label lblNome;
        private Label lblEmail;
        private Button btnCadastrar;
    }
}