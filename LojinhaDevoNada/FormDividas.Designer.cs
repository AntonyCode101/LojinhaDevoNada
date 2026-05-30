namespace LojinhaDevoNada
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
            cmbClientes = new DataGridViewComboBoxColumn();
            txtValor = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            btnSalvar = new DataGridViewButtonColumn();
            btnListar = new DataGridViewButtonColumn();
            btnAtualizar = new DataGridViewButtonColumn();
            btnExcluir = new DataGridViewButtonColumn();
            btnVoltarDivida = new Button();
            btnAddDivida = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { cmbClientes, txtValor, Status, btnSalvar, btnListar, btnAtualizar, btnExcluir });
            dataGridView1.Location = new Point(30, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(747, 317);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cmbClientes
            // 
            cmbClientes.HeaderText = "Clientes";
            cmbClientes.Name = "cmbClientes";
            // 
            // txtValor
            // 
            txtValor.HeaderText = "Valor";
            txtValor.Name = "txtValor";
            // 
            // Status
            // 
            Status.HeaderText = "Pago";
            Status.Name = "Status";
            // 
            // btnSalvar
            // 
            btnSalvar.HeaderText = "Salvar";
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Text = "Salvar";
            btnSalvar.UseColumnTextForButtonValue = true;
            // 
            // btnListar
            // 
            btnListar.HeaderText = "Listar";
            btnListar.Name = "btnListar";
            btnListar.Text = "Listar";
            btnListar.UseColumnTextForButtonValue = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.HeaderText = "Atualizar";
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseColumnTextForButtonValue = true;
            // 
            // btnExcluir
            // 
            btnExcluir.HeaderText = "Excluir";
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Text = "Excluir";
            btnExcluir.UseColumnTextForButtonValue = true;
            // 
            // btnVoltarDivida
            // 
            btnVoltarDivida.Location = new Point(24, 14);
            btnVoltarDivida.Name = "btnVoltarDivida";
            btnVoltarDivida.Size = new Size(121, 48);
            btnVoltarDivida.TabIndex = 9;
            btnVoltarDivida.Text = "Voltar";
            btnVoltarDivida.UseVisualStyleBackColor = true;
            btnVoltarDivida.Click += btnVoltarDivida_Click;
            // 
            // btnAddDivida
            // 
            btnAddDivida.Location = new Point(174, 14);
            btnAddDivida.Name = "btnAddDivida";
            btnAddDivida.Size = new Size(122, 48);
            btnAddDivida.TabIndex = 10;
            btnAddDivida.Text = "Adicionar Dívida";
            btnAddDivida.UseVisualStyleBackColor = true;
            btnAddDivida.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(btnAddDivida);
            panel1.Controls.Add(btnVoltarDivida);
            panel1.Location = new Point(-3, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 91);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // FormDividas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "FormDividas";
            Text = "FormDividas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox textValor;
        private DataGridView gridDividas;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn btnSalvar;
        private DataGridViewButtonColumn btnListar;
        private DataGridViewButtonColumn btnExcluir;
        private DataGridViewButtonColumn btnAtualizar;
        private DataGridViewComboBoxColumn cmbClientes;
        private DataGridViewTextBoxColumn txtValor;
        private DataGridViewCheckBoxColumn Status;
        private Button btnVoltarDivida;
        private Button btnAddDivida;
        private Panel panel1;
    }
}