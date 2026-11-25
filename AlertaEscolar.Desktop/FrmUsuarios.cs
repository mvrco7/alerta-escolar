using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlertaEscolar.Desktop
{
    public partial class FrmUsuarios : Form
    {
        private static readonly HttpClient clienteHttp = new HttpClient();

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        public class UsuarioListado
        {
            public int Id { get; set; }
            public string Nombre { get; set; } = string.Empty;
            public string Correo { get; set; } = string.Empty;
            public string Rol { get; set; } = string.Empty;
            public bool Activo { get; set; }
        }

        private async Task CargarUsuariosAsync()
        {
            if (string.IsNullOrWhiteSpace(SesionUsuario.Token))
            {
                MessageBox.Show(
                    "Debe iniciar sesión para consultar los usuarios.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (SesionUsuario.Rol != "Administrador")
            {
                MessageBox.Show(
                    "No tiene permisos para administrar usuarios.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                string url = "https://localhost:7299/api/usuarios";

                using var solicitud = new HttpRequestMessage(
                    HttpMethod.Get, url);

                solicitud.Headers.Authorization =
                    new AuthenticationHeaderValue(
                        "Bearer", SesionUsuario.Token);

                using var respuesta =
                    await clienteHttp.SendAsync(solicitud);

                if (respuesta.StatusCode == HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show(
                        "La sesión ha expirado. Inicie sesión nuevamente.",
                        "Alerta Escolar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (respuesta.StatusCode == HttpStatusCode.Forbidden)
                {
                    MessageBox.Show(
                        "No tiene permisos para consultar los usuarios.",
                        "Alerta Escolar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (!respuesta.IsSuccessStatusCode)
                {
                    MessageBox.Show(
                        $"Error al consultar usuarios. Código HTTP: " +
                        $"{(int)respuesta.StatusCode}",
                        "Alerta Escolar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                var usuarios = await respuesta.Content
                    .ReadFromJsonAsync<List<UsuarioListado>>();

                dgvUsuarios.DataSource = null;

                dgvUsuarios.DataSource =
                    (usuarios ?? new List<UsuarioListado>())
                    .Select(u => new
                    {
                        u.Id,
                        u.Nombre,
                        u.Correo,
                        u.Rol,
                        Estado = u.Activo ? "Activo" : "Inactivo"
                    }).ToList();

                if (dgvUsuarios.Columns["Id"] is DataGridViewColumn id)
                {
                    id.HeaderText = "ID";
                    id.FillWeight = 8;
                }

                if (dgvUsuarios.Columns["Nombre"] is DataGridViewColumn nombre)
                {
                    nombre.HeaderText = "Nombre";
                    nombre.FillWeight = 22;
                }

                if (dgvUsuarios.Columns["Correo"] is DataGridViewColumn correo)
                {
                    correo.HeaderText = "Correo electrónico";
                    correo.FillWeight = 30;
                }

                if (dgvUsuarios.Columns["Rol"] is DataGridViewColumn rol)
                {
                    rol.HeaderText = "Rol";
                    rol.FillWeight = 30;
                    rol.DefaultCellStyle.WrapMode =
                        DataGridViewTriState.True;
                }

                if (dgvUsuarios.Columns["Estado"] is DataGridViewColumn estado)
                {
                    estado.HeaderText = "Estado";
                    estado.FillWeight = 10;
                }

                dgvUsuarios.AutoSizeRowsMode =
                    DataGridViewAutoSizeRowsMode.AllCells;
            }
            catch (HttpRequestException)
            {
                MessageBox.Show(
                    "No se pudo conectar con la API.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show(
                    "La consulta de usuarios tardó demasiado.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (System.Text.Json.JsonException)
            {
                MessageBox.Show(
                    "La API devolvió datos con un formato incorrecto.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void FrmUsuarios_Shown(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            btnNuevoUsuario.Enabled = false;

            try
            {
                await CargarUsuariosAsync();
            }
            finally
            {
                btnActualizar.Enabled = true;
                btnNuevoUsuario.Enabled = true;
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            btnNuevoUsuario.Enabled = false;

            try
            {
                await CargarUsuariosAsync();
            }
            finally
            {
                btnActualizar.Enabled = true;
                btnNuevoUsuario.Enabled = true;
            }
        }

        private async void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SesionUsuario.Token) ||
                SesionUsuario.Rol != "Administrador")
            {
                MessageBox.Show(
                    "No tiene permisos o debe iniciar sesión nuevamente.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            btnNuevoUsuario.Enabled = false;
            btnActualizar.Enabled = false;

            try
            {
                using (FrmNuevoUsuario formulario = new FrmNuevoUsuario())
                {
                    if (formulario.ShowDialog(this) == DialogResult.OK)
                    {
                        await CargarUsuariosAsync();
                    }
                }
            }
            finally
            {
                btnNuevoUsuario.Enabled = true;
                btnActualizar.Enabled = true;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}