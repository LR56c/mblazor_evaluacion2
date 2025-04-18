using BlazorBiblioteca.Shared;
using Microsoft.EntityFrameworkCore;
namespace BlazorBiblioteca.Context;

public class LibroDBContext : DbContext
{
    public LibroDBContext(DbContextOptions<LibroDBContext> options)
        : base(options)
    {
    }

    public DbSet<Libro> Libros { get; set; }  

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}