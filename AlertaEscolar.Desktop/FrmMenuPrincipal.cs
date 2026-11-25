
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlertaEscolar.Shared.Models;

namespace AlertaEscolar.Desktop
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();

            lblBienvenida.Text =
                $"Bienvenido, {SesionUsuario.Nombre}";

            this.Load += FrmMenuPrincipal_Load;
        }

        private async void FrmMenuPrincipal_Load(
            object? sender, EventArgs e)
        {
            await CargarCasosAsync();
        }

        private async Task CargarCasosAsync()
        {
            try
            {
                using HttpClient cliente = new HttpClient
                {
                    BaseAddress =
                        new Uri("https://localhost:7299/")
                };

                cliente.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue(
                        "Bearer",
                        SesionUsuario.Token);

                var casos = await cliente.GetFromJsonAsync<
                    List<Caso>>("api/casos");

                if (casos == null)
                {
                    return;
                }

                // Actualizar el total de casos
                lblTotalCasos.Text =
                    casos.Count.ToString();

                // Actualizar casos pendientes
                lblPendientes.Text =
                    casos.Count(c =>
                        string.Equals(
                            c.Estado,
                            "Pendiente",
                            StringComparison.OrdinalIgnoreCase))
                    .ToString();

                // Actualizar casos en seguimiento
                label5.Text =
                    casos.Count(c =>
                        string.Equals(
                            c.Estado,
                            "En seguimiento",
                            StringComparison.OrdinalIgnoreCase))
                    .ToString();

                // Actualizar casos cerrados
                label7.Text =
                    casos.Count(c =>
                        string.Equals(
                            c.Estado,
                            "Cerrado",
                            StringComparison.OrdinalIgnoreCase))
                    .ToString();

                // Actualizar la tabla de casos recientes
                dvgCasosRecientes.Rows.Clear();

                foreach (var caso in casos
                    .OrderByDescending(c => c.FechaRegistro)
                    .Take(10))
                {
                    dvgCasosRecientes.Rows.Add(
                        caso.Id,
                        caso.FechaRegistro.ToLocalTime()
                            .ToString("dd-MM-yyyy"),
                        caso.Titulo,
                        caso.UsuarioResponsableId,
                        caso.Estado);
                }
            }
            catch (HttpRequestException)
            {
                MessageBox.Show(
                    "No se pudo conectar con la API de Alerta Escolar.",
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudieron cargar los casos: {ex.Message}",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void lblTotalCasos_Click(
            object sender, EventArgs e)
        {

        }

        // Abrir el formulario de registro
        private async void btnRegistrarCaso_Click(
            object sender, EventArgs e)
        {
            using (FrmRegistrarCaso formulario = new FrmRegistrarCaso())
            {
                formulario.ShowDialog(this);
            }

            // Actualizar el panel al regresar
            await CargarCasosAsync();
        }

        // Abrir el listado de casos
        private async void btnCasos_Click(
            object sender, EventArgs e)
        {
            using (FrmListadoCasos formulario = new FrmListadoCasos())
            {
                formulario.ShowDialog(this);
            }

            // Actualizar el panel al regresar
            await CargarCasosAsync();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            using (FrmHistorial formulario = new FrmHistorial())
            {
                formulario.ShowDialog(this);
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (SesionUsuario.Rol != "Administrador")
            {
                MessageBox.Show(
                    "No tiene permisos para administrar usuarios.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            using (FrmUsuarios formulario = new FrmUsuarios())
            {
                formulario.ShowDialog(this);
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
        "¿Está seguro de que desea cerrar sesión?",
        "Alerta Escolar - Cerrar sesión",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button2);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
