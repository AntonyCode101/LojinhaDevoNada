namespace LojinhaDevoNada.Forms
{
    partial class Homepage
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            btnDivida = new Button();
            Pesquisa = new TextBox();
            clientesBindingSource = new BindingSource(components);
            clientesBindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Cpf = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Excluir = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clientesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientesBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria Math", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(15, -12);
            label1.Name = "label1";
            label1.Size = new Size(116, 58);
            label1.TabIndex = 0;
            label1.Text = "DevoNada";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnDivida);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(148, 460);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(15, 132);
            button3.Name = "button3";
            button3.Size = new Size(110, 34);
            button3.TabIndex = 2;
            button3.Text = "Cadastrar Cliente";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnDivida
            // 
            btnDivida.BackColor = SystemColors.ButtonFace;
            btnDivida.FlatStyle = FlatStyle.Flat;
            btnDivida.Location = new Point(15, 172);
            btnDivida.Name = "btnDivida";
            btnDivida.Size = new Size(110, 33);
            btnDivida.TabIndex = 1;
            btnDivida.Text = "Dívidas";
            btnDivida.UseVisualStyleBackColor = false;
            btnDivida.Click += btnDivida_Click;
            // 
            // Pesquisa
            // 
            Pesquisa.BackColor = SystemColors.Menu;
            Pesquisa.BorderStyle = BorderStyle.None;
            Pesquisa.Location = new Point(176, 27);
            Pesquisa.Name = "Pesquisa";
            Pesquisa.PlaceholderText = "Digite nome do cliente...";
            Pesquisa.Size = new Size(598, 16);
            Pesquisa.TabIndex = 2;
            Pesquisa.TextChanged += Pesquisa_TextChanged;
            // 
            // clientesBindingSource
            // 
            clientesBindingSource.DataSource = typeof(Models.Clientes);
            // 
            // clientesBindingSource1
            // 
            clientesBindingSource1.DataSource = typeof(Models.Clientes);
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DarkOliveGreen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Cpf, Email, Editar, Excluir });
            dataGridView1.GridColor = Color.DarkGreen;
            dataGridView1.Location = new Point(151, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(644, 362);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Cpf
            // 
            Cpf.HeaderText = "CPF";
            Cpf.Name = "Cpf";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Name = "Editar";
            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            // 
            // Excluir
            // 
            Excluir.HeaderText = "Excluir";
            Excluir.Name = "Excluir";
            Excluir.Text = "Excluir";
            Excluir.UseColumnTextForButtonValue = true;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(Pesquisa);
            Controls.Add(panel1);
            Name = "Homepage";
            Text = "DevoNada";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)clientesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientesBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox Pesquisa;
        private Button button3;
        private Button btnDivida;
        private BindingSource clientesBindingSource;
        private BindingSource clientesBindingSource1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Cpf;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Excluir;
    }
}