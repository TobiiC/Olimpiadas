using Musiceo.Data.enums;
using Musiceo.Data.models.enums;

namespace Musiceo.Data.models.Artistas;

    public class Artista
    {
        public string Nombre { get; set; }
        public Cancion Cancion { get; set; }
        public string biografia { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public DateOnly? FechaFallecio { get; set; }
        public string genero { get; set; }
        public AñoArtista Año { get; set; }
        public GeneroMusical Genero { get; set; }

    }

