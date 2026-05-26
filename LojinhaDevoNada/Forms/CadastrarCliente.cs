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
    public partial class CadastrarCliente : Form
    {
        private readonly ClientesService _clientesService;
        public CadastrarCliente(ClientesService clientesService)
        {
            InitializeComponent();
            _clientesService = clientesService;
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            lblErro.Visible = false;
            lblSucess.Visible = false;
            try
            {
                var cliente = new Clientes
                {
                    Nome = txtNome.Text,
                    Cpf = mtxtCpf.Text.Replace(".", "").Replace("-", "").Replace(",", "").Trim(),
                    Data_nasc = dtpNascimento.Value,
                    Email = txtEmail.Text
                };
                var sucesso = _clientesService.Criar(
                    cliente,
                    out var erros
                );
                if (!sucesso)
                {
                    lblErro.Text = erros.FirstOrDefault()?.ErrorMessage;
                    lblErro.Visible = true;
                    return;
                }
                lblSucess.Text = "*Cliente Cadastrado com êxito!*";
                lblSucess.Visible = true;
                LimparCampos();
            }
            catch (Exception ex)
            {
                lblErro.Text = ex.ToString();
                lblErro.Visible = true;
            }
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            mtxtCpf.Clear();
            txtEmail.Clear();
            dtpNascimento.Value = DateTime.Now;

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Limpar_Click_1(object sender, EventArgs e)
        {
            LimparCampos();
            lblErro.Visible = false;
            lblSucess.Visible = false;
        }

        private void lblSucess_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
