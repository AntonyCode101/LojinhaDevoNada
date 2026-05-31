using LojinhaDevoNada.Models;
using LojinhaDevoNada.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LojinhaDevoNada.Forms
{
    public partial class AtualizarDivida : Form
    {
        private readonly DividasService _dividasService;
        private readonly int _id;

        public AtualizarDivida(DividasService dividasService, int id)
        {
            InitializeComponent();

            _dividasService = dividasService;
            _id = id;

            CarregarDivida();
        }

        private void CarregarDivida()
        {
            lblErro.Visible = false;
            lblSucess.Visible = false;
            var divida = _dividasService.Buscar(_id);

            if (divida == null)
            {
                lblErro.Text = "*Dívida não encontrada.*";
                lblErro.Visible = true;

                Close();
                return;
            }
            if (divida.Valor >= 1000000)
            { 
                lblErro.Text = "*Dívida muito alta para ser atualizada.*";
                lblErro.Visible = true;
            }

            lblCliente.Text = divida.Cliente.Nome;
            nudValor.Value = divida.Valor;
            chkPago.Checked = divida.Status;
        }



        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            lblErro.Visible = false;
            lblSucess.Visible = false;

            try
            {
                var dividaAtualizada =
                    new Dividas
                    {
                        Valor = nudValor.Value,
                        Status = chkPago.Checked
                    };

                bool sucesso = _dividasService.Atualizar( _id, dividaAtualizada, out var erros);

                if (!sucesso)
                {
                    lblErro.Text = string.Join("\n", erros.Select(e => e.ErrorMessage));
                    lblErro.Visible = true;
                    return;
                }

                lblSucess.Text = "Dívida atualizada com sucesso!";
                lblSucess.Visible = true;
            }
            catch
            {
                lblErro.Text = "Informe um valor válido.";
                lblErro.Visible = true;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}