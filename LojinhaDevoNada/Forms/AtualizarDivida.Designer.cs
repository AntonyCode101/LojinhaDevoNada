namespace LojinhaDevoNada.Forms
{
    partial class AtualizarDivida
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
            lblCliente = new Label();
            chkPago = new CheckBox();
            btnSalvar = new Button();
            btnVoltar = new Button();
            lblErro = new Label();
            lblSucess = new Label();
            nudValor = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudValor).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(187, 121);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            // 
            // chkPago
            // 
            chkPago.AutoSize = true;
            chkPago.Location = new Point(244, 183);
            chkPago.Name = "chkPago";
            chkPago.Size = new Size(53, 19);
            chkPago.TabIndex = 2;
            chkPago.Text = "Pago";
            chkPago.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(182, 301);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Atualizar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(322, 319);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 4;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.Location = new Point(82, 360);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(38, 15);
            lblErro.TabIndex = 5;
            lblErro.Text = "label1";
            // 
            // lblSucess
            // 
            lblSucess.AutoSize = true;
            lblSucess.Location = new Point(153, 359);
            lblSucess.Name = "lblSucess";
            lblSucess.Size = new Size(38, 15);
            lblSucess.TabIndex = 6;
            lblSucess.Text = "label1";
            // 
            // nudValor
            // 
            nudValor.DecimalPlaces = 2;
            nudValor.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            nudValor.Location = new Point(526, 242);
            nudValor.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudValor.Name = "nudValor";
            nudValor.Size = new Size(120, 23);
            nudValor.TabIndex = 7;
            nudValor.ThousandsSeparator = true;
            // 
            // AtualizarDivida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nudValor);
            Controls.Add(lblSucess);
            Controls.Add(lblErro);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Controls.Add(chkPago);
            Controls.Add(lblCliente);
            Name = "AtualizarDivida";
            Text = "AtualizarDivida";
            ((System.ComponentModel.ISupportInitialize)nudValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private CheckBox chkPago;
        private Button btnSalvar;
        private Button btnVoltar;
        private Label lblErro;
        private Label lblSucess;
        private NumericUpDown nudValor;
    }
}