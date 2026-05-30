using LojinhaDevoNada.Data;
using LojinhaDevoNada.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace LojinhaDevoNada.Services
{
    public class DividasService
    {
        private readonly LojinhaDbContext _context;

        public DividasService(LojinhaDbContext context)
        {
            _context = context;
        }

        public bool Criar(
            Dividas divida,
            out List<ValidationResult> erros)
        {
            if (!Validar(divida, out erros))
            {
                return false;
            }

            _context.Dividas.Add(divida);

            _context.SaveChanges();

            return true;
        }

        public bool Validar(
            Dividas divida,
            out List<ValidationResult> erros)
        {
            var contexto = new ValidationContext(divida);

            erros = new List<ValidationResult>();

            bool objetoValido = Validator.TryValidateObject(
                divida,
                contexto,
                erros,
                true
            );

            return objetoValido;
        }

        public List<Dividas> Listar()
        {
            return _context.Dividas
                .Include(d => d.Cliente)
                .ToList();
        }

        public Dividas Buscar(int id)
        {
            return _context.Dividas
                .Include(d => d.Cliente)
                .FirstOrDefault(d => d.Id == id);
        }

        public bool Atualizar(
            int id,
            Dividas dividaAtualizada,
            out List<ValidationResult> erros)
        {
            var divida = Buscar(id);

            erros = new List<ValidationResult>();

            if (divida == null)
            {
                erros.Add(
                    new ValidationResult("Dívida não encontrada")
                );

                return false;
            }

            divida.Valor = dividaAtualizada.Valor;
            divida.Status = dividaAtualizada.Status;
            divida.Data_pagamento = dividaAtualizada.Data_pagamento;
            divida.ClienteId = dividaAtualizada.ClienteId;

            if (!Validar(divida, out erros))
            {
                return false;
            }

            _context.SaveChanges();

            return true;
        }

        public bool Deletar(int id)
        {
            var divida = Buscar(id);

            if (divida == null)
            {
                return false;
            }

            _context.Dividas.Remove(divida);

            _context.SaveChanges();

            return true;
        }
    }
}