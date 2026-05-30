using LojinhaDevoNada.Forms;
using LojinhaDevoNada.Models;
using LojinhaDevoNada.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LojinhaDevoNada
{
    public partial class FormDividas : Form
    {
        private readonly DividasService _dividasService;
        private readonly ClientesService _clientesService;



        public FormDividas(DividasService dividasService, ClientesService clientesService)
        {
            InitializeComponent();

            _dividasService = dividasService;
            _clientesService = clientesService;

            CarregarClientes();
            ListarDividas();
        }
        private void CarregarClientes()
        {
            var clientes = _clientesService.Listar();

            cmbClientes.DataSource = clientes;
            cmbClientes.DisplayMember = "Nome";
            cmbClientes.ValueMember = "Id";
        }
        private void ListarDividas()
        {
            dataGridView1.Rows.Clear();

            var dividas = _dividasService.Listar();

            foreach (var divida in dividas)
            {
                dataGridView1.Rows.Add(
                    divida.Cliente?.Nome,
                    divida.Valor,
                    divida.Status
                );
            }
        }
        
        private void FormDividas_Load(object sender, EventArgs e)
        {
            ListarDividas();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var divida = new Dividas
            {
                ClienteId = 1,
                Valor = 100,
                Status = false
            };

            if (_dividasService.Criar(divida, out var erros))
            {
                MessageBox.Show("Dívida cadastrada com sucesso!");
                ListarDividas();
            }
            else
            {
                MessageBox.Show(erros[0].ErrorMessage);
            }
        }

        private void btnVoltarDivida_Click(object sender, EventArgs e)
        {
            var home = new Homepage(
                _clientesService,
                _dividasService
            );

            home.Show();

            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
