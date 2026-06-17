using LojinhaDevoNada.Data;
using LojinhaDevoNada.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Printing;

namespace LojinhaDevoNada.Services
{
    public class ClientesService
    {
        private readonly LojinhaDbContext _context;

        public ClientesService(LojinhaDbContext context)
        {
            _context = context;
        }

        public bool Criar(
            Clientes cliente,
            out List<ValidationResult> erros)
        {
            if (!Validar(cliente, out erros))
            {
                return false;
            }

            _context.Clientes.Add(cliente);

            _context.SaveChanges();

            return true;
        }
        public bool Validar(
            Clientes cliente,
            out List<ValidationResult> erros)
        {
            var contexto = new ValidationContext(cliente);
            erros = new List<ValidationResult>();

            var objetoValido = Validator.TryValidateObject(cliente,contexto,erros,true);

            bool cpfExiste = _context.Clientes.Any(c => c.Cpf == cliente.Cpf && c.Id != cliente.Id);

            if (cpfExiste)
            {
                erros.Add(new ValidationResult("*Já existe um cliente com esse CPF!*",new[] { "Cpf" }));
                objetoValido = false;
            }

            if (cliente.Idade < 18)
            {
                erros.Add(new ValidationResult("*O cliente deve ser maior de idade!*",new[] { "Idade" }));
                objetoValido = false;
            }
            return objetoValido;
        }

        public List<Clientes> Pesquisa(string texto = "", int pageSize = 0, int page = 1)
        {
            var query = _context.Clientes
                .Include(c => c.Dividas)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                texto = texto.Trim().ToLower();

                query = query.Where(c =>
                    c.Nome.ToLower().Contains(texto) ||
                    c.Email.ToLower().Contains(texto) ||
                    c.Cpf.Contains(texto));
            }

            query = query.OrderBy(c => c.Nome);

            if (pageSize > 0)
            {
                int skip = (page - 1) * pageSize;

                query = query
                    .Skip(skip)
                    .Take(pageSize);
            }

            return query.ToList();
        }

        public Clientes Buscar(int id)
        {
            var cliente = _context.Clientes.Include(c => c.Dividas).FirstOrDefault(c => c.Id == id);
            return cliente;
        }
        public bool Atualizar(
            int id,
            Clientes clienteAtualizado,
            out List<ValidationResult> erros)
        {
            var cliente = Buscar(id);

            erros = new List<ValidationResult>();

            if (cliente == null)
            {
                erros.Add(new ValidationResult("Cliente não encontrado"));
                return false;
            }

            cliente.Nome = clienteAtualizado.Nome;
            cliente.Email = clienteAtualizado.Email;
            cliente.Data_nasc = clienteAtualizado.Data_nasc;

            if (!Validar(cliente, out erros))
            {
                return false;
            }

            _context.SaveChanges();

            return true;
        }

        public bool Deletar(int id)
        {
            var cliente = Buscar(id);

            if (cliente == null)
            {
                return false;
            }

            _context.Clientes.Remove(cliente);

            _context.SaveChanges();

            return true;
        }

        public decimal TotalDividas(Clientes cliente)
        {
            return cliente.Dividas.Where(d => d.Status == false).Sum(d => d.Valor);
        }

        public int TotalClientes()
        {
            return _context.Clientes.Count();
        }

        public Clientes BuscarPorCpf(string cpf)
        {
            return _context.Clientes.FirstOrDefault(c => c.Cpf == cpf);

        }

        public int TotalRegistros(string texto = "")
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return _context.Dividas.Count();
            }

            texto = texto.Trim().ToLower();

            return _context.Dividas.Include(d => d.Cliente).Count(d => d.Cliente.Nome.ToLower().Contains(texto) || d.Cliente.Cpf.Contains(texto));
        }
    }
}