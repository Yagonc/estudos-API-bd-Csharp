using Chapter.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Chapter.WebApi.Contexts
{
    public class ChapterContext : DbContext
    {
        public ChapterContext()
        {
        }
        public ChapterContext(DbContextOptions<ChapterContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Essa string de conexão, depende da SUA máquina
                optionsBuilder.UseSqlServer("User ID=sa;Password=1234;Server=DRAGAOCHINES\\CHOPPSERVER;"
                +
                "Database=Chapter;Trusted_Connection=False");

                // Exemplo 1 de string de conexão:
                // User ID=sa;Password=1234;Server=localhost;Database=Chapter; + Trusted_Connection=False;

                // Exemplo 2 de string de conexão;
                // "Server=DRAGAOCHINES\\CHOPPSERVER;" + "Database=Chapter;Trusted_Connection=True"


            }
        }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
