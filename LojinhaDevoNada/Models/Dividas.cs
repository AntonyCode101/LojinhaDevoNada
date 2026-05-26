using System;
using System.ComponentModel.DataAnnotations;

namespace LojinhaDevoNada.Models
{
    public class Dividas
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O valor da dívida é obrigatório")]
        [Range(0.01, 999999.99, ErrorMessage = "O valor deve ser maior que zero")]
        public decimal Valor { get; set; }

        [Required]
        public bool Status { get; set; } = false;

        public DateTime Data_criacao { get; set; } = DateTime.Now;

        public DateTime? Data_pagamento { get; set; }

        [Required(ErrorMessage = "O cliente é obrigatório")]
        public int ClienteId { get; set; }

        public Clientes Cliente { get; set; }
    }
}