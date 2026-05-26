using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LojinhaDevoNada.Models
{
    public class Clientes
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "*O nome do cliente é obrigatório!*")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "*Nome muito curto (Mínimo de 10 caracteres)*")]
        [RegularExpression(@"^[A-Za-zÀ-ÿ\s]+$",
            ErrorMessage = "*Digite um nome válido*")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "*CPF é obrigatório!*")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "*CPF inválido!*")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "*Data de nascimento é obrigatória!*")]
        public DateTime Data_nasc { get; set; }

        [Required(ErrorMessage = "*Email é obrigatório!*")]
        [EmailAddress(ErrorMessage = "*Email inválido*")]
        public string Email { get; set; }

        public List<Dividas> Dividas { get; set; } = new();

        public int Idade
        {
            get
            {
                var hoje = DateTime.Today;

                var idade = hoje.Year - Data_nasc.Year;

                if (Data_nasc.Date > hoje.AddYears(-idade))
                {
                    idade--;
                }

                return idade;
            }
        }
    }
}