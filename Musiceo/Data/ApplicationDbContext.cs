using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Musiceo.Data.Agregados;
using Musiceo.Data.models.Artistas;

namespace Musiceo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        DbSet<Artista> Artistas { get; set; }
        DbSet<Cancion> Canciones { get; set; }
        DbSet<Juego> Juegos { get; set; }
    }
}