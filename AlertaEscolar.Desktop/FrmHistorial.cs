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
    public partial class FrmHistorial : Form
    {
        private static readonly HttpClient clienteHttp =
            new HttpClient();

        public FrmHistorial()
        {
            InitializeComponent();
        }

        // CARGAR EL HISTORIAL GENERAL
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
                string url =
                    "https://localhost:7299/api/casos/historial";

                using var solicitud =
                    new HttpRequestMessage(HttpMethod.Get, url);

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

                // OCULTAR LAS COLUMNAS INNECESARIAS
                foreach (DataGridViewColumn columna
                    in dgvHistorial.Columns)
                {
                    columna.Visible = false;
                }

                // CONFIGURAR NÚMERO DE CASO
                if (dgvHistorial.Columns["CasoId"]
                    is DataGridViewColumn caso)
                {
                    caso.Visible = true;
                    caso.HeaderText = "N° Caso";
                    caso.FillWeight = 10;
                    caso.DisplayIndex = 0;
                }

                // CONFIGURAR FECHA
                if (dgvHistorial.Columns["Fecha"]
                    is DataGridViewColumn fecha)
                {
                    fecha.Visible = true;
                    fecha.HeaderText = "Fecha";
                    fecha.DefaultCellStyle.Format =
                        "dd-MM-yyyy HH:mm";
                    fecha.FillWeight = 20;
                    fecha.DisplayIndex = 1;
                }

                // CONFIGURAR USUARIO RESPONSABLE
                if (dgvHistorial.Columns["UsuarioId"]
                    is DataGridViewColumn usuario)
                {
                    usuario.Visible = true;
                    usuario.HeaderText = "ID Responsable";
                    usuario.FillWeight = 15;
                    usuario.DisplayIndex = 2;
                }

                // CONFIGURAR ACCIÓN REALIZADA
                if (dgvHistorial.Columns["DescripcionAccion"]
                    is DataGridViewColumn accion)
                {
                    accion.Visible = true;
                    accion.HeaderText = "Acción realizada";
                    accion.FillWeight = 40;
                    accion.DisplayIndex = 3;
                }

                // CONFIGURAR ESTADO
                if (dgvHistorial.Columns["Estado"]
                    is DataGridViewColumn estado)
                {
                    estado.Visible = true;
                    estado.HeaderText = "Estado";
                    estado.FillWeight = 15;
                    estado.DisplayIndex = 4;
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

        // BOTÓN ACTUALIZAR
        private async void btnActualizar_Click(
            object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;

            try
            {
                await CargarHistorialAsync();
            }
            finally
            {
                btnActualizar.Enabled = true;
            }
        }

        // CARGAR HISTORIAL AL ABRIR EL FORMULARIO
        private async void FrmHistorial_Shown(
            object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;

            try
            {
                await CargarHistorialAsync();
            }
            finally
            {
                btnActualizar.Enabled = true;
            }
        }

        // BOTÓN VOLVER AL MENÚ
        private void btnVolver_Click(
            object sender, EventArgs e)
        {
            this.Close();
        }
    }
}