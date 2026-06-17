using LojinhaDevoNada.Data;
using LojinhaDevoNada.Services;
using Microsoft.EntityFrameworkCore;

namespace LojinhaDevoNada
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var options = new DbContextOptionsBuilder<LojinhaDbContext>()
                .UseNpgsql(
                    "Host=localhost;" +
                    "Port=5432;" +
                    "Database=db_devonada;" +
                    "Username=postgres;" +
                    "Password=40028922"
                )
                .Options;

            var context = new LojinhaDbContext(options);

            var clientesService = new ClientesService(context);
            var dividasService = new DividasService(context);

            var form = new Form1(
                clientesService,
                dividasService
            );

            Application.Run(form);
        }
    }
}