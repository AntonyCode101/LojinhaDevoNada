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
            btnDividaCadastrar = new Button();
            lblErro = new Label();
            lblSucess = new Label();
            txtPesquisar = new TextBox();
            btnVoltar = new Button();
            btnAnterior = new Button();
            btnProximo = new Button();
            lblPagina = new Label();
            id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Idade = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            DataCriacao = new DataGridViewTextBoxColumn();
            DataPagamento = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Excluir = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, Nome, Idade, Total, Status, DataCriacao, DataPagamento, Editar, Excluir });
            dataGridView1.Location = new Point(12, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(787, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnDividaCadastrar
            // 
            btnDividaCadastrar.Location = new Point(176, 344);
            btnDividaCadastrar.Name = "btnDividaCadastrar";
            btnDividaCadastrar.Size = new Size(75, 23);
            btnDividaCadastrar.TabIndex = 1;
            btnDividaCadastrar.Text = "button1";
            btnDividaCadastrar.UseVisualStyleBackColor = true;
            btnDividaCadastrar.Click += btnDividaCadastrar_Click;
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.Location = new Point(329, 354);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(38, 15);
            lblErro.TabIndex = 2;
            lblErro.Text = "label1";
            // 
            // lblSucess
            // 
            lblSucess.AutoSize = true;
            lblSucess.Location = new Point(266, 283);
            lblSucess.Name = "lblSucess";
            lblSucess.Size = new Size(38, 15);
            lblSucess.TabIndex = 3;
            lblSucess.Text = "label1";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(240, 42);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(100, 23);
            txtPesquisar.TabIndex = 4;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged_1;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(52, 320);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click_1;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(199, 402);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(75, 23);
            btnAnterior.TabIndex = 6;
            btnAnterior.Text = "Voltar";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnProximo
            // 
            btnProximo.Location = new Point(428, 414);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(75, 23);
            btnProximo.TabIndex = 7;
            btnProximo.Text = "Próximo";
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // lblPagina
            // 
            lblPagina.AutoSize = true;
            lblPagina.Location = new Point(302, 408);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(77, 15);
            lblPagina.TabIndex = 8;
            lblPagina.Text = "Página 1 de 1";
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
            // 
            // Excluir
            // 
            Excluir.HeaderText = "Excluir";
            Excluir.Name = "Excluir";
            Excluir.Text = "Excluir";
            Excluir.ToolTipText = "Excluir";
            // 
            // FormDividas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPagina);
            Controls.Add(btnProximo);
            Controls.Add(btnAnterior);
            Controls.Add(btnVoltar);
            Controls.Add(txtPesquisar);
            Controls.Add(lblSucess);
            Controls.Add(lblErro);
            Controls.Add(btnDividaCadastrar);
            Controls.Add(dataGridView1);
            Name = "FormDividas";
            Text = "FormDividas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Idade;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn DataCriacao;
        private DataGridViewTextBoxColumn DataPagamento;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Excluir;
    }
}