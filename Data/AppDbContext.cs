using CakesApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CakesApp.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Cake> Cakes {get; set;}
    }
}
