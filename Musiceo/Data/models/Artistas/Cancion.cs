namespace Musiceo.Data.models.Artistas
{
    public class Cancion
    {
        public string Nombre { get; set; }
        public DateOnly FechaLanzamiento { get; set; }
        public string? Historia { get; set; }
    }
}
