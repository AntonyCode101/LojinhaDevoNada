using LojinhaDevoNada.Services;
using LojinhaDevoNada.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace LojinhaDevoNada.Forms
{
    public partial class AtualizarClientes : Form
    {
        private readonly ClientesService _clientesService;
        private readonly int _clienteId;
        public AtualizarClientes(Services.ClientesService clientesService, int clienteId)
        {
            InitializeComponent();
            _clientesService = clientesService;
            _clienteId = clienteId;
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            dtpNascimento.Value = DateTime.Now;

        }

        private void AtualizarClientes_Load(object sender, EventArgs e)
        {
            var cliente = _clientesService.Buscar(_clienteId);

            if (cliente == null)
            {
                lblErro.Text = "Cliente não encontrado";

                lblErro.Visible = true;
                return;
            }

            txtNome.Text = cliente.Nome;
            txtEmail.Text = cliente.Email;
            dtpNascimento.Value = cliente.Data_nasc;
            mtxtCpf.Enabled = false;
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            lblErro.Visible = false;
            lblSucess.Visible = false;

            try
            {
                var cliente = new Clientes
                {
                    Nome = txtNome.Text,
                    Email = txtEmail.Text,
                    Data_nasc = dtpNascimento.Value
                };

                var sucesso = _clientesService.Atualizar(_clienteId, cliente, out List<ValidationResult> erros);

                if (!sucesso)
                {
                    lblErro.Text = erros.FirstOrDefault()?.ErrorMessage;
                    lblErro.Visible = true;

                    return;
                }
                lblSucess.Text = "*Cliente Atualizado com êxito!*";
                lblSucess.Visible = true;
            }
            catch
            {
                lblErro.Text = "*Erro ao Atualizar Cliente!*";
                lblErro.Visible = true;
            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            lblErro.Visible = false;
            lblSucess.Visible = false;
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
