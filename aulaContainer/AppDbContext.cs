using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext{
    public DbSet<Pessoa> Pessoas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseNpgsql("Host=localhost; Database=pessoasdb;Username=admin;Password=admin123");
    }
}