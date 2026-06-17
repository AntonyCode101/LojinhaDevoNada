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
    public partial class FormDividas : Form
    {
        private readonly DividasService _dividasService;
        private readonly ClientesService _clientesService;
        private int paginaAtual = 1;
        private int tamanhoPagina = 10;

        public FormDividas(
            DividasService dividasService,
            ClientesService clientesService)
        {
            InitializeComponent();

            _dividasService = dividasService;
            _clientesService = clientesService;

            comboBox1.SelectedIndex = 0;

            CarregarDividas();
        }

        private void HomepageDividas_Load(object sender, EventArgs e)
        {
            CarregarDividas();
        }
        private int TotalPaginas(string texto = "")
        {
            string filtro = comboBox1.Text;

            int totalDividas =
                _dividasService.TotalRegistros(texto, filtro);

            return Math.Max(
                1,
                (int)Math.Ceiling(
                    totalDividas / (double)tamanhoPagina
                )
            );
        }
        private void AtualizarPaginas(string texto = "")
        {
            int totalPaginas = TotalPaginas(texto);

            lblPagina.Text =
                $"Página {paginaAtual} de {totalPaginas}";

            btnAnterior.Enabled = paginaAtual > 1;
            btnProximo.Enabled = paginaAtual < totalPaginas;
        }


        private void CarregarDividas(string texto = "")
        {
            dataGridView1.Rows.Clear();

            string filtro = comboBox1.Text;

            if (string.IsNullOrWhiteSpace(filtro))
            {
                filtro = "Todos";
            }

            var dividas = _dividasService.Pesquisa(texto, comboBox1.Text, tamanhoPagina, paginaAtual);

            foreach (var divida in dividas)
            {
                dataGridView1.Rows.Add(
                    divida.Id,
                    divida.Cliente.Nome,
                    divida.Cliente.Idade,
                    divida.Valor,
                    divida.Status ? "Paga" : "Em Aberto",
                    divida.Data_criacao.ToString("dd/MM/yyyy"),
                    divida.Data_pagamento?.ToString("dd/MM/yyyy") ?? "-"
                );
            }

            AtualizarPaginas(texto);
        }


        private void btnDividaCadastrar_Click(object sender, EventArgs e)
        {
            var form = new CadastrarDividas(
                _dividasService,
                _clientesService
            );

            form.ShowDialog();

            CarregarDividas();
        }

        private void txtPesquisar_TextChanged_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            paginaAtual = 1;
            CarregarDividas(txtPesquisar.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
                var form = new AtualizarDivida(_dividasService, id);

                form.ShowDialog();

                CarregarDividas();
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Excluir")
            {
                var resultado = MessageBox.Show(
                    "Você realmente deseja deletar esta dívida?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    _dividasService.Deletar(id);
                    CarregarDividas();
                }
            }
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            var home = new Homepage(
               _clientesService,
               _dividasService
           );

            home.Show();

            Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (paginaAtual > 1)
            {
                paginaAtual--;
                CarregarDividas(txtPesquisar.Text);
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (paginaAtual < TotalPaginas(txtPesquisar.Text))
            {
                paginaAtual++;
                CarregarDividas(txtPesquisar.Text);
            }
        }

        private void lblErro_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSucess_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            paginaAtual = 1;
            CarregarDividas(txtPesquisar.Text);
        }
    }
}
