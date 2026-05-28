using LojinhaDevoNada.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LojinhaDevoNada.Models;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
