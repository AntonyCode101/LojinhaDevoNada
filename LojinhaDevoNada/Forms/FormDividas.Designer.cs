namespace LojinhaDevoNada.Forms
{
    partial class FormDividas
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
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Idade = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            DataCriacao = new DataGridViewTextBoxColumn();
            DataPagamento = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Excluir = new DataGridViewButtonColumn();
            btnDividaCadastrar = new Button();
            lblErro = new Label();
            lblSucess = new Label();
            txtPesquisar = new TextBox();
            btnVoltar = new Button();
            btnAnterior = new Button();
            btnProximo = new Button();
            lblPagina = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.OliveDrab;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, Nome, Idade, Total, Status, DataCriacao, DataPagamento, Editar, Excluir });
            dataGridView1.Location = new Point(22, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(749, 279);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Idade
            // 
            Idade.HeaderText = "Idade";
            Idade.Name = "Idade";
            // 
            // Total
            // 
            Total.HeaderText = "Total Divida";
            Total.Name = "Total";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // DataCriacao
            // 
            DataCriacao.HeaderText = "Criado em";
            DataCriacao.Name = "DataCriacao";
            // 
            // DataPagamento
            // 
            DataPagamento.HeaderText = "Pago em";
            DataPagamento.Name = "DataPagamento";
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Name = "Editar";
            Editar.Text = "Editar";
            Editar.ToolTipText = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            // 
            // Excluir
            // 
            Excluir.HeaderText = "Excluir";
            Excluir.Name = "Excluir";
            Excluir.Text = "Excluir";
            Excluir.ToolTipText = "Excluir";
            Excluir.UseColumnTextForButtonValue = true;
            // 
            // btnDividaCadastrar
            // 
            btnDividaCadastrar.BackColor = SystemColors.ButtonFace;
            btnDividaCadastrar.FlatStyle = FlatStyle.Flat;
            btnDividaCadastrar.Location = new Point(682, 410);
            btnDividaCadastrar.Name = "btnDividaCadastrar";
            btnDividaCadastrar.Size = new Size(106, 32);
            btnDividaCadastrar.TabIndex = 1;
            btnDividaCadastrar.Text = "Cadastrar Dívida";
            btnDividaCadastrar.UseVisualStyleBackColor = false;
            btnDividaCadastrar.Click += btnDividaCadastrar_Click;
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.BackColor = Color.DarkOliveGreen;
            lblErro.ForeColor = Color.DarkOliveGreen;
            lblErro.Location = new Point(735, 419);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(36, 15);
            lblErro.TabIndex = 2;
            lblErro.Text = "ERRO";
            lblErro.Click += lblErro_Click;
            // 
            // lblSucess
            // 
            lblSucess.AutoSize = true;
            lblSucess.BackColor = Color.DarkOliveGreen;
            lblSucess.ForeColor = Color.DarkOliveGreen;
            lblSucess.Location = new Point(637, 415);
            lblSucess.Name = "lblSucess";
            lblSucess.Size = new Size(49, 15);
            lblSucess.TabIndex = 3;
            lblSucess.Text = "Sucesso";
            lblSucess.Click += lblSucess_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(22, 62);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Buscar";
            txtPesquisar.Size = new Size(565, 23);
            txtPesquisar.TabIndex = 4;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged_1;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = SystemColors.ButtonFace;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.ForeColor = SystemColors.ControlText;
            btnVoltar.Location = new Point(12, 415);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(106, 29);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click_1;
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = SystemColors.ButtonFace;
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.Location = new Point(292, 415);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(75, 23);
            btnAnterior.TabIndex = 6;
            btnAnterior.Text = "Voltar";
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnProximo
            // 
            btnProximo.BackColor = SystemColors.ButtonFace;
            btnProximo.FlatStyle = FlatStyle.Flat;
            btnProximo.Location = new Point(460, 415);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(75, 23);
            btnProximo.TabIndex = 7;
            btnProximo.Text = "Próximo";
            btnProximo.UseVisualStyleBackColor = false;
            btnProximo.Click += btnProximo_Click;
            // 
            // lblPagina
            // 
            lblPagina.AutoSize = true;
            lblPagina.Location = new Point(377, 419);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(77, 15);
            lblPagina.TabIndex = 8;
            lblPagina.Text = "Página 1 de 1";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Cambria", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(202, 9);
            label1.Name = "label1";
            label1.Size = new Size(398, 50);
            label1.TabIndex = 19;
            label1.Text = "Dívidas";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 47);
            panel1.TabIndex = 20;
            panel1.Paint += panel1_Paint;
            // 
            // label6
            // 
            label6.BackColor = Color.DarkOliveGreen;
            label6.Font = new Font("Cambria", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(1, 9);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 18;
            label6.Text = "DevoNada";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Todos", "Em Aberto", "Pagas" });
            comboBox1.Location = new Point(650, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 20;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(593, 63);
            label2.Name = "label2";
            label2.Size = new Size(61, 17);
            label2.TabIndex = 21;
            label2.Text = "Filtros: ";
            label2.Click += label2_Click;
            // 
            // FormDividas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(lblPagina);
            Controls.Add(btnDividaCadastrar);
            Controls.Add(btnVoltar);
            Controls.Add(txtPesquisar);
            Controls.Add(btnProximo);
            Controls.Add(btnAnterior);
            Controls.Add(lblSucess);
            Controls.Add(lblErro);
            Controls.Add(dataGridView1);
            Name = "FormDividas";
            Text = "FormDividas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnDividaCadastrar;
        private Label lblErro;
        private Label lblSucess;
        private TextBox txtPesquisar;
        private Button btnVoltar;
        private Button btnAnterior;
        private Button btnProximo;
        private Label lblPagina;
        private Label label1;
        private Panel panel1;
        private Label label6;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Idade;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn DataCriacao;
        private DataGridViewTextBoxColumn DataPagamento;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Excluir;
        private Label label2;
        private ComboBox comboBox1;
    }
}