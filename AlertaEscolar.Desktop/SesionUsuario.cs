
namespace AlertaEscolar.Desktop
{
    public static class SesionUsuario
    {
        public static string Token { get; set; } = string.Empty;

        public static int Id { get; set; }

        public static string Nombre { get; set; } = string.Empty;

        public static string Correo { get; set; } = string.Empty;

        public static string Rol { get; set; } = string.Empty;

        public static void CerrarSesion()
        {
            Token = string.Empty;
            Id = 0;
            Nombre = string.Empty;
            Correo = string.Empty;
            Rol = string.Empty;
        }
    }
}
