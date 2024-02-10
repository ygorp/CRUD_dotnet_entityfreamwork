using ApiCrud.api.Estudantes;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud.api.Data;

public class AppDbContext : DbContext
{
    private DbSet<Estudante> Estudantes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Banco.sqlite");
        base.OnConfiguring(optionsBuilder);
    }
}