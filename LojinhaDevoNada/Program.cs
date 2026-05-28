using LojinhaDevoNada.Data;
using LojinhaDevoNada.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LojinhaDevoNada
{
    internal static class Program
    {
        private static DbContextOptions<LojinhaDbContext> options;

        [STAThread]
        static void Main()
        {
            Environment.SetEnvironmentVariable(
                "ConnectionStrings__DefaultConnection",
                "Host=localhost;" +
                "Port=5432;" +
                "Database=db_devonada;" +
                "User Id=postgres;" +
                "Password=1234"
            );

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<LojinhaDbContext>(options => options.UseNpgsql(Environment.GetEnvironmentVariable(
                                "ConnectionStrings__DefaultConnection"
                            )
                        )
                    );

                    
                    services.AddScoped<ClientesService>();

                    services.AddScoped<DividasService>();

                    
                    services.AddTransient<Form1>();
                })
                .Build();


            ApplicationConfiguration.Initialize();

            
            var form = host.Services.GetRequiredService<Form1>();

            Application.Run(form);
        }
    }
}