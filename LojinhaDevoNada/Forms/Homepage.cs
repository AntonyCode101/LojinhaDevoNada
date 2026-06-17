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
        private readonly DividasService _dividasService;
        private int paginaAtual = 1;
        private int tamanhoPagina = 10;

        private void Homepage_Load(object sender, EventArgs e)
        {
            CarregarClientes();
        }



        public Homepage(ClientesService clientesService, DividasService dividasService)
        {
            InitializeComponent();
            _clientesService = clientesService;
            _dividasService = dividasService;
            CarregarClientes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new CadastrarCliente(_clientesService);
            form.ShowDialog();
            CarregarClientes();
        }

        private int TotalPaginas(string texto = "")
        {
            int totalDividas = _dividasService.TotalRegistros(texto);

            return Math.Max(1, (int)Math.Ceiling(totalDividas / (double)tamanhoPagina));
        }
        private void AtualizarPaginas(string texto = "")
        {
            int totalPaginas = TotalPaginas(texto);
            lblPagina.Text = $"Página {paginaAtual} de {totalPaginas}";

            btnVoltar.Enabled = paginaAtual > 1;
            btnProximo.Enabled = paginaAtual < totalPaginas;
        }

        private void CarregarClientes(string texto = "")
        {
            dataGridView1.Rows.Clear();

            var clientes = _clientesService.Pesquisa(texto, tamanhoPagina, paginaAtual);
            foreach (var cliente in clientes)
            {
                dataGridView1.Rows.Add(
                    cliente.Id,
                    cliente.Nome,
                    cliente.Cpf,
                    cliente.Email

                );
            }
            AtualizarPaginas(texto);
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
            paginaAtual = 1;
            dataGridView1.Rows.Clear();
            CarregarClientes(Pesquisa.Text);
        }

        private void btnDivida_Click(object sender, EventArgs e)
        {
            var form = new FormDividas(
                _dividasService,
                _clientesService
            );

            form.Show();

            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (paginaAtual < TotalPaginas(Pesquisa.Text))
            {
                paginaAtual++;
                CarregarClientes(Pesquisa.Text);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (paginaAtual > 1)
            {
                paginaAtual--;
                CarregarClientes(Pesquisa.Text);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
