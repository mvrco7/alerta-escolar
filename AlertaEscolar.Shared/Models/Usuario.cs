
namespace AlertaEscolar.Shared.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Correo { get; set; } = string.Empty;

        public string Rol { get; set; } = "Encargado de Convivencia Escolar";

        public bool Activo { get; set; } = true;
    }
}
