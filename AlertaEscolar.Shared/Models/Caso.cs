
namespace AlertaEscolar.Shared.Models
{
    public class Caso
    {
        public int Id { get; set; }

        public string Titulo { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;

        public string Estado { get; set; } = "Pendiente";

        public int UsuarioResponsableId { get; set; }
    }
}
