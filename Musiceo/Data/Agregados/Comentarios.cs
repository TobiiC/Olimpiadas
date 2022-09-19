using Musiceo.Data.models.Personas;

namespace Musiceo.Data.Agregados
{
    public class Comentarios
    {
        public string contenido { get; set; }
        public Persona Escritor { get; set; }
    }
}
