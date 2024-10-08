using Microsoft.EntityFrameworkCore;

namespace aula12_TPH{
    public class AppDbContext : DbContext{
        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlite("Data Source=pessoas.db");
        }

        // no metodo OnModelCreating, utilimos o HasDiscriminator para definir uma coluna de discriminaão
        // chamada PessoaTipo, q indica o tipo de essoa (Auno ou professor) na tabela unica
        // tabela unica por hierarquia (TPH- table per hierarchy)

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Pessoa> ()
                        .HasDiscriminator<string>("PessoaTipo")
                        .HasValue<Aluno>("Aluno")
                        .HasValue<Professor>("Professor");
        }
    }
}