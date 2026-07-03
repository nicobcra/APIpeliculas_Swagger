using APIpeliculas.Models;
using Microsoft.EntityFrameworkCore;

namespace APIpeliculas.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //Aqui se ponen todas las entidades (Modelos)
        public DbSet<Categoria>Categoria { get; set; }
    }
}
