using LojinhaDevoNada.Forms;
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
    public partial class Form1 : Form
    {
        private readonly ClientesService _clientesService;
        private readonly DividasService _dividasService;
        public Form1(ClientesService clientesService, DividasService dividasService)
        {
            InitializeComponent();
            _clientesService = clientesService;
            _dividasService = dividasService;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var home = new Homepage(_clientesService, _dividasService);
            home.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
