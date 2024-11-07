using Microsoft.EntityFrameworkCore;

namespace Mentoria_Db.api
{
    public class ApiDbContext : DbContext
    {
        public DbSet<Entidade1> Entidade1 { get; set; }


        // Construtor que recebe as opções do DbContext
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }


        // Método opcional para configurações adicionais do DbContext
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aqui você pode adicionar configurações de entidade, relações, índices, etc.
            // Exemplo:
            modelBuilder.Entity<Entidade1>().HasKey(e => e.Id);
        }
    }

    // Exemplo de entidade
    public class Entidade1
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public DateTime DataCriacao { get; set; }
    }

}
