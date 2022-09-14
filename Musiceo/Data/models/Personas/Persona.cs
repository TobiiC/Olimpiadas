using Musiceo.Data.models.enums;

namespace Musiceo.Data.models.Personas

{
    public abstract class Persona
    {
        public int PersonaId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Genero Genero { get; set; }

        
    }
}
