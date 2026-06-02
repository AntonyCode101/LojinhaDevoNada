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
            label1 = new Label();
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudValor).BeginInit();
            SuspendLayout();
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.BackColor = Color.White;
            lblErro.ForeColor = Color.Red;
            lblErro.Location = new Point(261, 299);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(36, 15);
            lblErro.TabIndex = 1;
            lblErro.Text = "ERRO";
            // 
            // lblSucess
            // 
            lblSucess.AutoSize = true;
            lblSucess.BackColor = Color.White;
            lblSucess.ForeColor = Color.Green;
            lblSucess.Location = new Point(261, 299);
            lblSucess.Name = "lblSucess";
            lblSucess.Size = new Size(49, 15);
            lblSucess.TabIndex = 2;
            lblSucess.Text = "Sucesso";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = SystemColors.ButtonFace;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Location = new Point(12, 415);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(83, 24);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click_1;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = SystemColors.ButtonFace;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Location = new Point(392, 331);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(97, 36);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // nudValor
            // 
            nudValor.DecimalPlaces = 2;
            nudValor.Location = new Point(261, 248);
            nudValor.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudValor.Name = "nudValor";
            nudValor.Size = new Size(228, 23);
            nudValor.TabIndex = 7;
            nudValor.ThousandsSeparator = true;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(261, 131);
            maskedTextBox1.Mask = "000.000.000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 8;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ButtonFace;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(382, 130);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(61, 23);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.White;
            lblNome.ForeColor = SystemColors.ControlText;
            lblNome.Location = new Point(261, 179);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 10;
            lblNome.Text = "Nome";
            lblNome.Click += lblNome_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.White;
            lblEmail.ForeColor = SystemColors.ControlText;
            lblEmail.Location = new Point(261, 216);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "E-mail";
            lblEmail.Click += lblEmail_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.ButtonFace;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Location = new Point(261, 331);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(97, 36);
            btnCadastrar.TabIndex = 12;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click_1;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Cambria", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(207, 9);
            label1.Name = "label1";
            label1.Size = new Size(398, 50);
            label1.TabIndex = 13;
            label1.Text = "Cadastrar Dívida";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.DarkOliveGreen;
            label6.Font = new Font("Cambria", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(2, 9);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 17;
            label6.Text = "DevoNada";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(211, 250);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 18;
            label2.Text = "Valor";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(208, 134);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 19;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(208, 179);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 20;
            label4.Text = "Nome:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(208, 216);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 21;
            label5.Text = "E-mail:";
            // 
            // CadastrarDividas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
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
            Load += CadastrarDividas_Load;
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
        private Label label1;
        private Label label6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}