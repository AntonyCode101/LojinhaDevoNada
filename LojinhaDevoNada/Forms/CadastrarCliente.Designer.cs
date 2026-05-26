namespace LojinhaDevoNada.Forms
{
    partial class CadastrarCliente
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
            txtNome = new TextBox();
            txtEmail = new TextBox();
            mtxtCpf = new MaskedTextBox();
            dtpNascimento = new DateTimePicker();
            Cadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Limpar = new Button();
            lblSucesso = new Label();
            lblErro = new Label();
            lblSucess = new Label();
            label6 = new Label();
            Voltar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Location = new Point(206, 84);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(389, 16);
            txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Location = new Point(206, 127);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(389, 16);
            txtEmail.TabIndex = 2;
            // 
            // mtxtCpf
            // 
            mtxtCpf.BorderStyle = BorderStyle.None;
            mtxtCpf.Location = new Point(206, 171);
            mtxtCpf.Mask = " 000.000.000-00";
            mtxtCpf.Name = "mtxtCpf";
            mtxtCpf.Size = new Size(145, 16);
            mtxtCpf.TabIndex = 3;
            // 
            // dtpNascimento
            // 
            dtpNascimento.Format = DateTimePickerFormat.Short;
            dtpNascimento.Location = new Point(206, 209);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(200, 23);
            dtpNascimento.TabIndex = 4;
            // 
            // Cadastrar
            // 
            Cadastrar.BackColor = SystemColors.ButtonHighlight;
            Cadastrar.FlatStyle = FlatStyle.Flat;
            Cadastrar.Location = new Point(206, 295);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(120, 31);
            Cadastrar.TabIndex = 5;
            Cadastrar.Text = "Cadastrar";
            Cadastrar.UseVisualStyleBackColor = false;
            Cadastrar.Click += cadastrar_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Cambria", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(197, 20);
            label1.Name = "label1";
            label1.Size = new Size(398, 50);
            label1.TabIndex = 6;
            label1.Text = "Cadastrar Cliente";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(151, 84);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(155, 127);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 8;
            label3.Text = "E-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(163, 171);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 9;
            label4.Text = "CPF";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(206, 191);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 10;
            label5.Text = "Data de Nascimento";
            label5.Click += label5_Click;
            // 
            // Limpar
            // 
            Limpar.BackColor = SystemColors.ButtonHighlight;
            Limpar.FlatStyle = FlatStyle.Flat;
            Limpar.Location = new Point(351, 295);
            Limpar.Name = "Limpar";
            Limpar.Size = new Size(120, 31);
            Limpar.TabIndex = 11;
            Limpar.Text = "Limpar";
            Limpar.UseVisualStyleBackColor = false;
            Limpar.Click += Limpar_Click_1;
            // 
            // lblSucesso
            // 
            lblSucesso.AutoSize = true;
            lblSucesso.BackColor = Color.Transparent;
            lblSucesso.Location = new Point(194, 397);
            lblSucesso.Name = "lblSucesso";
            lblSucesso.Size = new Size(0, 15);
            lblSucesso.TabIndex = 12;
            lblSucesso.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblErro
            // 
            lblErro.BackColor = Color.WhiteSmoke;
            lblErro.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErro.ForeColor = Color.Red;
            lblErro.Location = new Point(206, 244);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(388, 19);
            lblErro.TabIndex = 13;
            lblErro.Text = "label6";
            lblErro.Visible = false;
            // 
            // lblSucess
            // 
            lblSucess.BackColor = Color.WhiteSmoke;
            lblSucess.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSucess.ForeColor = Color.Green;
            lblSucess.Location = new Point(206, 244);
            lblSucess.Name = "lblSucess";
            lblSucess.Size = new Size(199, 19);
            lblSucess.TabIndex = 14;
            lblSucess.Text = "label6";
            lblSucess.Visible = false;
            lblSucess.Click += lblSucess_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.DarkOliveGreen;
            label6.Font = new Font("Cambria", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 9);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 16;
            label6.Text = "DevoNada";
            label6.TextAlign = ContentAlignment.TopCenter;
            label6.Click += label6_Click;
            // 
            // Voltar
            // 
            Voltar.BackColor = SystemColors.ButtonHighlight;
            Voltar.FlatStyle = FlatStyle.Flat;
            Voltar.Location = new Point(12, 414);
            Voltar.Name = "Voltar";
            Voltar.Size = new Size(83, 24);
            Voltar.TabIndex = 21;
            Voltar.Text = "Voltar";
            Voltar.UseVisualStyleBackColor = false;
            Voltar.Click += Voltar_Click;
            // 
            // CadastrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(Voltar);
            Controls.Add(label6);
            Controls.Add(lblSucess);
            Controls.Add(lblErro);
            Controls.Add(lblSucesso);
            Controls.Add(Limpar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Cadastrar);
            Controls.Add(dtpNascimento);
            Controls.Add(mtxtCpf);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Name = "CadastrarCliente";
            Text = "DevoNada/CadastrarCliente";
            Load += CadastrarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEmail;
        private MaskedTextBox mtxtCpf;
        private DateTimePicker dtpNascimento;
        private Button Cadastrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Limpar;
        private Label lblSucesso;
        private Label lblErro;
        private Label lblSucess;
        private Label label6;
        private Button Voltar;
    }
}