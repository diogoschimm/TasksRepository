using Microsoft.Extensions.DependencyInjection;
using System;
using TrabalhandoComTasks.Data.Contexts;
using TrabalhandoComTasks.Data.Repositories;
using TrabalhandoComTasks.Domain.Contracts.Repositories;
using TrabalhandoComTasks.UI;

namespace TrabalhandoComTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = GetProvider();

            var opcao = "";
            while (opcao != "X")
            {
                opcao = GenericUI.ShowTelaInicial();
                switch (opcao)
                {
                    case "1": 
                        service.GetService<PessoaUI>().Show();
                        break;
                    case "2":
                        service.GetService<GrupoPessoaUI>().Show();
                        break;
                }
            } 
        }
         
        static IServiceProvider GetProvider()
        {
            var collection = new ServiceCollection();
            collection.AddDbContext<TasksContext>();

            collection.AddScoped<IPessoaRepository, PessoaRepository>();
            collection.AddScoped<IGrupoPessoaRepository, GrupoPessoaRepository>();
            collection.AddScoped<PessoaUI>();
            collection.AddScoped<GrupoPessoaUI>();

            return collection.BuildServiceProvider();
        }
    }
}
