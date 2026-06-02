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
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudValor).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BackColor = Color.White;
            lblCliente.Location = new Point(314, 128);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            // 
            // chkPago
            // 
            chkPago.AutoSize = true;
            chkPago.ForeColor = Color.White;
            chkPago.Location = new Point(444, 180);
            chkPago.Name = "chkPago";
            chkPago.Size = new Size(53, 19);
            chkPago.TabIndex = 2;
            chkPago.Text = "Pago";
            chkPago.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.ButtonFace;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Location = new Point(260, 286);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(98, 36);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Atualizar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = SystemColors.ButtonFace;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Location = new Point(444, 286);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(98, 36);
            btnVoltar.TabIndex = 4;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.BackColor = Color.White;
            lblErro.ForeColor = Color.Red;
            lblErro.Location = new Point(260, 236);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(36, 15);
            lblErro.TabIndex = 5;
            lblErro.Text = "ERRO";
            // 
            // lblSucess
            // 
            lblSucess.AutoSize = true;
            lblSucess.BackColor = Color.White;
            lblSucess.ForeColor = Color.Green;
            lblSucess.Location = new Point(260, 236);
            lblSucess.Name = "lblSucess";
            lblSucess.Size = new Size(49, 15);
            lblSucess.TabIndex = 6;
            lblSucess.Text = "Sucesso";
            // 
            // nudValor
            // 
            nudValor.DecimalPlaces = 2;
            nudValor.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            nudValor.Location = new Point(308, 176);
            nudValor.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudValor.Name = "nudValor";
            nudValor.Size = new Size(120, 23);
            nudValor.TabIndex = 7;
            nudValor.ThousandsSeparator = true;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Cambria", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(206, 9);
            label2.Name = "label2";
            label2.Size = new Size(398, 50);
            label2.TabIndex = 15;
            label2.Text = "Editar Dívida";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(260, 178);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 16;
            label1.Text = "Valor";
            // 
            // label6
            // 
            label6.BackColor = Color.DarkOliveGreen;
            label6.Font = new Font("Cambria", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 9);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 17;
            label6.Text = "DevoNada";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(260, 128);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 18;
            label3.Text = "Cliente:";
            // 
            // AtualizarDivida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label2);
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
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label3;
    }
}