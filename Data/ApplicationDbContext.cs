using Microsoft.EntityFrameworkCore;
using ORM_TurmaFormacao.Features.Product.Entities;

namespace ORM_TurmaFormacao.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

        public DbSet<Products> Products { get; set; }
    }
}
