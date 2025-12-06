using Microsoft.EntityFrameworkCore;
using dotnet_todo.Models;

namespace dotnet_todo.Data
{
    public class Dotnet_todoContext : DbContext
    {
        public Dotnet_todoContext (DbContextOptions<Dotnet_todoContext> options)
            : base(options)
        {
        }

        public DbSet<Todos> Todos { get; set; } = default!;
    }
}
