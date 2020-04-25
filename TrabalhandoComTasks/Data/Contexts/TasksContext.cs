using Microsoft.EntityFrameworkCore;
using TrabalhandoComTasks.Data.Mappings;
using TrabalhandoComTasks.Domain.Entities;
using TrabalhandoComTasks.Domain.Shared.Entities;
using TrabalhandoComTasks.Domain.Shared.Notifications;
using TrabalhandoComTasks.Domain.Shared.ValueObjects;

namespace TrabalhandoComTasks.Data.Contexts
{
    public class TasksContext : DbContext
    {
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<GrupoPessoa> GrupoPessoa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=EST-BT13\\SQL2017;Initial Catalog=BdProjetoTeste;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PessoaMapping());
            modelBuilder.ApplyConfiguration(new GrupoPessoaMapping());

            modelBuilder.Ignore<Entity>();
            modelBuilder.Ignore<ValueObject>();
            modelBuilder.Ignore<Notifiable>(); 
        }
    }
}
