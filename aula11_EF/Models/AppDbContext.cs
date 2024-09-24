using Microsoft.EntityFrameworkCore;
using aula11_EF.Models;

public class AppDbContext : DbContext{
    public DbSet<Cliente> Cliente {get; set;}
    public DbSet<Livro> Livro { get; set; }
    public DbSet<Venda> Vendas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseSqlite("Data Source=vendas.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.Entity<Venda>()
        .HasMany(v => v.Livros)
        .WithMany()
        .UsingEntity(j => j.ToTable("VendaLivros"));

        base.OnModelCreating(modelBuilder);
    }
}