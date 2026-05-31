using System.ComponentModel.DataAnnotations;
using LojinhaDevoNada.Data;
using LojinhaDevoNada.Models;
using Microsoft.EntityFrameworkCore;

namespace LojinhaDevoNada.Services
{
    public class DividasService
    {
        private readonly LojinhaDbContext _context;

        public DividasService(LojinhaDbContext context)
        {
            _context = context;
        }

        public bool Criar(Dividas divida,out List<ValidationResult> erros)
        {
            erros = new();

            if (divida.Valor <= 0)
            {
                erros.Add(new ValidationResult("O valor da dívida deve ser maior que zero.*"));
                return false;
            }

            bool clienteExiste = _context.Clientes.Any(c => c.Id == divida.ClienteId);

            if (!clienteExiste)
            {
                erros.Add(new ValidationResult("*Cliente não encontrado.*"));

                return false;
            }

            bool possuiDivida = _context.Dividas.Any(d => d.ClienteId == divida.ClienteId);
            if (possuiDivida)
            {
                erros.Add(new ValidationResult("*Este cliente já possui uma dívida cadastrada.*"));

                return false;
            }

            divida.Status = false;
            divida.Data_criacao = DateTime.Now;
            divida.Data_pagamento = null;

            _context.Dividas.Add(divida);
            _context.SaveChanges();

            return true;
        }

        public List<Dividas> Listar()
        {
            return _context.Dividas.Include(d => d.Cliente).OrderBy(d => d.Cliente.Nome).ToList();
        }

        public List<Dividas> Listar(int pageSize,int page)
        {
            int skip = (page - 1) * pageSize;
            return _context.Dividas.Include(d => d.Cliente).OrderBy(d => d.Cliente.Nome).Skip(skip).Take(pageSize).ToList();
        }

        public List<Dividas> Pesquisa(string texto)
        {
            return _context.Dividas.Include(d => d.Cliente).Where(d => d.Cliente.Nome.Contains(texto) || d.Cliente.Cpf.Contains(texto)).OrderBy(d => d.Cliente.Nome).ToList();
        }

        public Dividas Buscar(int id)
        {
            return _context.Dividas.Include(d => d.Cliente) .FirstOrDefault(d => d.Id == id);
        }

        public bool Atualizar(
            int id,
            Dividas dividaAtualizada,
            out List<ValidationResult> erros)
        {
            erros = new();

            var divida = Buscar(id);

            if (divida == null)
            {
                erros.Add(new ValidationResult("*Dívida não encontrada.*"));
                return false;
            }

            if (dividaAtualizada.Valor <= 0)
            {
                erros.Add(new ValidationResult("*O valor da dívida deve ser maior que zero.*"));
                return false;
            }

            bool estavaPaga = divida.Status;

            divida.Valor = dividaAtualizada.Valor;
            divida.Status = dividaAtualizada.Status;

            if (!estavaPaga && divida.Status)
            {
                divida.Data_pagamento = DateTime.Now;
            }

            if (estavaPaga && !divida.Status)
            {
                divida.Data_pagamento = null;
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

        public decimal TotalDividas(Clientes cliente)
        {
            return cliente.Dividas.Where(d => !d.Status).Sum(d => d.Valor);
        }

        public int TotalRegistros(string texto = "")
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return _context.Dividas.Count();
            }

            return _context.Dividas.Include(d => d.Cliente).Count(d => d.Cliente.Nome.Contains(texto) || d.Cliente.Cpf.Contains(texto));
        }
    }
}