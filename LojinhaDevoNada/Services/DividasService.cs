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
                erros.Add(new ValidationResult("*O valor da dívida deve ser maior que zero.*"));
                return false;
            }

            bool clienteExiste = _context.Clientes.Any(c => c.Id == divida.ClienteId);

            if (!clienteExiste)
            {
                erros.Add(new ValidationResult("*Cliente não encontrado.*"));

                return false;
            }

            bool possuiDivida = _context.Dividas.Any(d => d.ClienteId == divida.ClienteId && d.Status == false);
            if (possuiDivida)
            {
                erros.Add(new ValidationResult("*Este cliente já possui uma dívida em aberto.*"));

                return false;
            }

            divida.Status = false;
            divida.Data_criacao = DateTime.Now;
            divida.Data_pagamento = null;

            _context.Dividas.Add(divida);
            _context.SaveChanges();

            return true;
        }

        public List<Dividas> Pesquisa(string texto = "", string filtro = "Todos", int pageSize = 0, int page = 1)
        {
            var query = _context.Dividas.Include(d => d.Cliente).AsQueryable();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                texto = texto.Trim().ToLower();

                query = query.Where(d => d.Cliente.Nome.ToLower().Contains(texto) || d.Cliente.Cpf.Contains(texto));
            }

            if (filtro == "Em Aberto")
            {
                query = query.Where(d => !d.Status);
            }
            else if (filtro == "Pagas")
            {
                query = query.Where(d => d.Status);
            }

            query = query.OrderByDescending(d => d.Valor);

            if (pageSize > 0)
            {
                int skip = (page - 1) * pageSize;

                query = query.Skip(skip).Take(pageSize);
            }

            return query.ToList();
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

        public List<Dividas> Filtrar(string texto, string status, int pageSize, int page)
        {
            texto = texto?.Trim().ToLower() ?? "";

            int skip = (page - 1) * pageSize;

            var query = _context.Dividas
                .Include(d => d.Cliente)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                query = query.Where(d =>
                    d.Cliente.Nome.ToLower().Contains(texto) ||
                    d.Cliente.Cpf.Contains(texto));
            }

            if (status == "Em Aberto")
            {
                query = query.Where(d => !d.Status);
            }
            else if (status == "Pagas")
            {
                query = query.Where(d => d.Status);
            }

            return query
                .OrderByDescending(d => d.Valor).Skip(skip).Take(pageSize).ToList();
        }

        public decimal TotalDividas(Clientes cliente)
        {
            return cliente.Dividas.Where(d => !d.Status).Sum(d => d.Valor);
        }

        public int TotalRegistros(string texto = "", string filtro = "Todos")
        {
            var query = _context.Dividas
                .Include(d => d.Cliente)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                texto = texto.Trim().ToLower();

                query = query.Where(d =>
                    d.Cliente.Nome.ToLower().Contains(texto) ||
                    d.Cliente.Cpf.Contains(texto));
            }

            if (filtro == "Em Aberto")
            {
                query = query.Where(d => !d.Status);
            }
            else if (filtro == "Pagas")
            {
                query = query.Where(d => d.Status);
            }

            return query.Count();
        }

        public int totalRegistrosPesquisa(string texto)
        {
            texto = texto.Trim().ToLower();

            return _context.Dividas.Include(d => d.Cliente).Count(d => d.Cliente.Nome.ToLower().Contains(texto) || d.Cliente.Cpf.Contains(texto));
        }
    }
}