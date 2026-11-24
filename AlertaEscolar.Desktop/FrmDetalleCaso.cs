
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlertaEscolar.Shared.Models;

namespace AlertaEscolar.Desktop
{
    public partial class FrmDetalleCaso : Form
    {
        private readonly Caso casoSeleccionado;

        private static readonly HttpClient clienteHttp = new HttpClient();

        public FrmDetalleCaso(Caso caso)
        {
            InitializeComponent();

            casoSeleccionado = caso;

            lblNumeroCaso.Text = $"N° de caso: {casoSeleccionado.Id}";

            lblFechaRegistro.Text = $"Fecha de registro: {casoSeleccionado.FechaRegistro:dd-MM-yyyy HH:mm}";

            txtTituloCaso.Text = casoSeleccionado.Titulo;

            txtDescripcion.Text = casoSeleccionado.Descripcion;

            cboEstado.SelectedItem = casoSeleccionado.Estado;
        }

        // Consultar el historial del caso
        private async Task CargarHistorialAsync()
        {
            if (string.IsNullOrWhiteSpace(SesionUsuario.Token))
            {
                MessageBox.Show(
                    "Debe iniciar sesión para consultar el historial.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                string url = $"https://localhost:7299/api/casos/{casoSeleccionado.Id}/historial";

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

                if (!respuesta.IsSuccessStatusCode)
                {
                    MessageBox.Show(
                        $"Error al consultar el historial. Código HTTP: {(int)respuesta.StatusCode}",
                        "Alerta Escolar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                var historial = await respuesta.Content
                    .ReadFromJsonAsync<List<HistorialCaso>>();

                dgvHistorial.DataSource = null;

                dgvHistorial.DataSource =
                    historial ?? new List<HistorialCaso>();

                // Configurar las columnas visibles
                foreach (DataGridViewColumn columna in dgvHistorial.Columns)
                {
                    columna.Visible = false;
                }

                if (dgvHistorial.Columns["Fecha"] is DataGridViewColumn fecha)
                {
                    fecha.Visible = true;
                    fecha.HeaderText = "Fecha";
                    fecha.DefaultCellStyle.Format = "dd-MM-yyyy HH:mm";
                    fecha.FillWeight = 25;
                }

                if (dgvHistorial.Columns["DescripcionAccion"] is DataGridViewColumn accion)
                {
                    accion.Visible = true;
                    accion.HeaderText = "Acción realizada";
                    accion.FillWeight = 50;
                }

                if (dgvHistorial.Columns["Estado"] is DataGridViewColumn estado)
                {
                    estado.Visible = true;
                    estado.HeaderText = "Estado";
                    estado.FillWeight = 25;
                }
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
                    "La consulta del historial tardó demasiado.",
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

        // Botón para regresar al listado
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void FrmDetalleCaso_Shown(object sender, EventArgs e)
        {
            btnGuardarCambios.Enabled = false;

            try
            {
                await CargarHistorialAsync();
            }
            finally
            {
                btnGuardarCambios.Enabled = true;
            }
        }


        private async void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            string nuevoEstado = cboEstado.SelectedItem?.ToString() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(nuevoEstado))
            {
                MessageBox.Show(
                    "Debe seleccionar un estado.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (nuevoEstado == casoSeleccionado.Estado)
            {
                MessageBox.Show(
                    "No se han realizado cambios en el estado.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            if (string.IsNullOrWhiteSpace(SesionUsuario.Token))
            {
                MessageBox.Show(
                    "Debe iniciar sesión nuevamente.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var confirmacion = MessageBox.Show(
                $"¿Desea cambiar el estado del caso a '{nuevoEstado}'?",
                "Confirmar cambio",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            btnGuardarCambios.Enabled = false;
            btnVolver.Enabled = false;
            cboEstado.Enabled = false;

            try
            {
                string url = $"https://localhost:7299/api/casos/{casoSeleccionado.Id}/estado";

                using var solicitud = new HttpRequestMessage(
                    HttpMethod.Put, url);

                solicitud.Headers.Authorization =
                    new AuthenticationHeaderValue(
                        "Bearer", SesionUsuario.Token);

                solicitud.Content = JsonContent.Create(new
                {
                    Estado = nuevoEstado
                });

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

                if (!respuesta.IsSuccessStatusCode)
                {
                    MessageBox.Show(
                        $"Error al actualizar el estado. Código HTTP: {(int)respuesta.StatusCode}",
                        "Alerta Escolar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                casoSeleccionado.Estado = nuevoEstado;

                MessageBox.Show(
                    "El estado del caso se actualizó correctamente.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                await CargarHistorialAsync();
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
                    "La solicitud tardó demasiado.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            finally
            {
                btnGuardarCambios.Enabled = true;
                btnVolver.Enabled = true;
                cboEstado.Enabled = true;
            }
        }

    }
}
