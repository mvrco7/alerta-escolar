
namespace AlertaEscolar.Shared.Models
{
    public class HistorialCaso
    {
        public int Id { get; set; }

        public int CasoId { get; set; }

        public int UsuarioId { get; set; }

        public DateTime Fecha { get; set; } = DateTime.UtcNow;

        public string DescripcionAccion { get; set; } = string.Empty;

        public string Estado { get; set; } = "Pendiente";
    }
}
