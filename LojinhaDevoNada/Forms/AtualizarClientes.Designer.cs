namespace LojinhaDevoNada.Forms
{
    partial class AtualizarClientes
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
            Atualizar = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Limpar = new Button();
            label2 = new Label();
            label6 = new Label();
            lblErro = new Label();
            lblSucess = new Label();
            Voltar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Location = new Point(206, 127);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(389, 16);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Location = new Point(206, 84);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(389, 16);
            txtEmail.TabIndex = 3;
            // 
            // mtxtCpf
            // 
            mtxtCpf.BorderStyle = BorderStyle.None;
            mtxtCpf.Location = new Point(206, 171);
            mtxtCpf.Mask = " 000.000.000-00";
            mtxtCpf.Name = "mtxtCpf";
            mtxtCpf.Size = new Size(145, 16);
            mtxtCpf.TabIndex = 4;
            // 
            // dtpNascimento
            // 
            dtpNascimento.Format = DateTimePickerFormat.Short;
            dtpNascimento.Location = new Point(206, 209);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(200, 23);
            dtpNascimento.TabIndex = 5;
            // 
            // Atualizar
            // 
            Atualizar.BackColor = SystemColors.ButtonHighlight;
            Atualizar.FlatStyle = FlatStyle.Flat;
            Atualizar.Location = new Point(206, 295);
            Atualizar.Name = "Atualizar";
            Atualizar.Size = new Size(120, 31);
            Atualizar.TabIndex = 6;
            Atualizar.Text = "Atualizar";
            Atualizar.UseVisualStyleBackColor = false;
            Atualizar.Click += Atualizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(151, 84);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 9;
            label1.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(151, 127);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 10;
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
            label4.TabIndex = 11;
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
            label5.TabIndex = 12;
            label5.Text = "Data de Nascimento";
            // 
            // Limpar
            // 
            Limpar.BackColor = SystemColors.ButtonHighlight;
            Limpar.FlatStyle = FlatStyle.Flat;
            Limpar.Location = new Point(351, 295);
            Limpar.Name = "Limpar";
            Limpar.Size = new Size(120, 31);
            Limpar.TabIndex = 13;
            Limpar.Text = "Limpar";
            Limpar.UseVisualStyleBackColor = false;
            Limpar.Click += Limpar_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Cambria", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(197, 20);
            label2.Name = "label2";
            label2.Size = new Size(398, 50);
            label2.TabIndex = 14;
            label2.Text = "Editar Cliente";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Cambria", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 9);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 17;
            label6.Text = "DevoNada";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblErro
            // 
            lblErro.BackColor = Color.WhiteSmoke;
            lblErro.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErro.ForeColor = Color.Red;
            lblErro.Location = new Point(206, 244);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(388, 19);
            lblErro.TabIndex = 18;
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
            lblSucess.TabIndex = 19;
            lblSucess.Text = "label6";
            lblSucess.Visible = false;
            // 
            // Voltar
            // 
            Voltar.BackColor = SystemColors.ButtonHighlight;
            Voltar.FlatStyle = FlatStyle.Flat;
            Voltar.Location = new Point(12, 414);
            Voltar.Name = "Voltar";
            Voltar.Size = new Size(83, 24);
            Voltar.TabIndex = 20;
            Voltar.Text = "Voltar";
            Voltar.UseVisualStyleBackColor = false;
            Voltar.Click += Voltar_Click;
            // 
            // AtualizarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(Voltar);
            Controls.Add(lblSucess);
            Controls.Add(lblErro);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(Limpar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(Atualizar);
            Controls.Add(dtpNascimento);
            Controls.Add(mtxtCpf);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Name = "AtualizarClientes";
            Text = "DevoNada/AtualizarClientes";
            Load += AtualizarClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEmail;
        private MaskedTextBox mtxtCpf;
        private DateTimePicker dtpNascimento;
        private Button Atualizar;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Limpar;
        private Label label2;
        private Label label6;
        private Label lblErro;
        private Label lblSucess;
        private Button Voltar;
    }
}