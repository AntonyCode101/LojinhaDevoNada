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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { cmbClientes, txtValor, Status, btnSalvar, btnListar, btnAtualizar, btnExcluir });
            dataGridView1.Location = new Point(30, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(742, 150);
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
            // 
            // btnListar
            // 
            btnListar.HeaderText = "Listar";
            btnListar.Name = "btnListar";
            // 
            // btnAtualizar
            // 
            btnAtualizar.HeaderText = "Atualizar";
            btnAtualizar.Name = "btnAtualizar";
            // 
            // btnExcluir
            // 
            btnExcluir.HeaderText = "Excluir";
            btnExcluir.Name = "btnExcluir";
            // 
            // FormDividas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "FormDividas";
            Text = "FormDividas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}