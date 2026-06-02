using LojinhaDevoNada.Models;
using LojinhaDevoNada.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LojinhaDevoNada.Forms
{
    public partial class CadastrarDividas : Form
    {
        private readonly DividasService _dividasService;
        private readonly ClientesService _clientesService;

        private Clientes clienteSelecionado;

        public CadastrarDividas(
            DividasService dividasService,
            ClientesService clientesService)
        {
            InitializeComponent();

            _dividasService = dividasService;
            _clientesService = clientesService;

            lblErro.Visible = false;
            lblSucess.Visible = false;

            lblNome.Text = "";
            lblEmail.Text = "";

            maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        private void LimparCampos()
        {
            maskedTextBox1.Clear();

            lblNome.Text = "";
            lblEmail.Text = "";
            nudValor.Value = 0;
            clienteSelecionado = null;
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            lblErro.Visible = false;
            lblSucess.Visible = false;

            if (clienteSelecionado == null)
            {
                lblErro.Text = "Busque um cliente antes de cadastrar.";
                lblErro.Visible = true;

                return;
            }

            if (nudValor.Value <= 0)
            {
                lblErro.Text = "O valor da dívida deve ser maior que zero.";
                lblErro.Visible = true;

                return;
            }

            if (nudValor.Value >= 1000000)
            {
                lblErro.Text = "O valor da dívida é muito alto para ser cadastrado.";
                lblErro.Visible = true;
                return;
            }

            var divida = new Dividas
            {
                ClienteId = clienteSelecionado.Id,
                Valor = nudValor.Value,
                Status = false
            };

            bool sucesso = _dividasService.Criar(divida, out var erros);

            if (!sucesso)
            {
                lblErro.Text = string.Join("\n", erros.Select(e => e.ErrorMessage));
                lblErro.Visible = true;
                return;
            }

            lblSucess.Text = "Dívida cadastrada com sucesso!";
            lblSucess.Visible = true;

            LimparCampos();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            lblErro.Visible = false;
            lblSucess.Visible = false;

            string cpf = maskedTextBox1.Text;

            clienteSelecionado = _clientesService.BuscarPorCpf(cpf);

            if (clienteSelecionado == null)
            {
                lblErro.Text = "CPF não encontrado.";
                lblErro.Visible = true;
                lblNome.Text = "";
                lblEmail.Text = "";

                return;
            }

            lblNome.Text = clienteSelecionado.Nome;
            lblEmail.Text = clienteSelecionado.Email;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarDividas_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}