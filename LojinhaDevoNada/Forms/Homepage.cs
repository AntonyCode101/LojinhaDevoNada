using LojinhaDevoNada.Models;
using LojinhaDevoNada.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LojinhaDevoNada.Forms
{
    public partial class Homepage : Form
    {
        private readonly ClientesService _clientesService;

        private void Homepage_Load(object sender,EventArgs e)
        {
            CarregarClientes();
        }


        public Homepage(ClientesService clientesService)
        {
            InitializeComponent();
            _clientesService = clientesService;
            CarregarClientes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new CadastrarCliente(_clientesService);
            form.ShowDialog();
            CarregarClientes();
        }

        private void CarregarClientes(string texto = "")
        {
            dataGridView1.Rows.Clear();

            var clientes = string.IsNullOrWhiteSpace(texto) ? _clientesService.Listar() : _clientesService.Pesquisa(texto);
            foreach (var cliente in clientes)
            {
                dataGridView1.Rows.Add(
                    cliente.Id,
                    cliente.Nome,
                    cliente.Cpf,
                    cliente.Email

                );
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
                var form = new AtualizarClientes(_clientesService, id);
                form.ShowDialog();
                CarregarClientes();
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Excluir")
            {
                var resultado = MessageBox.Show("Você realmente deseja deletar este cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    _clientesService.Deletar(id);

                    CarregarClientes();
                }
            }
        }

        private void Pesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarClientes(Pesquisa.Text);
        }

    }
}
