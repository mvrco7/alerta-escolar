
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
    public partial class FrmListadoCasos : Form
    {
        // CLIENTE HTTP PARA COMUNICARSE CON LA API
        private static readonly HttpClient clienteHttp =
            new HttpClient();

        public FrmListadoCasos()
        {
            InitializeComponent();
        }

        // CONSULTAR CASOS REGISTRADOS
        private async Task CargarCasosAsync()
        {
            // VERIFICAR SESIÓN
            if (string.IsNullOrWhiteSpace(SesionUsuario.Token))
            {
                MessageBox.Show(
                    "Debe iniciar sesión para consultar los casos.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                // PREPARAR SOLICITUD GET
                using var solicitud = new HttpRequestMessage(
                    HttpMethod.Get,
                    "https://localhost:7299/api/casos");

                // AGREGAR TOKEN JWT
                solicitud.Headers.Authorization =
                    new AuthenticationHeaderValue(
                        "Bearer",
                        SesionUsuario.Token);

                // ENVIAR SOLICITUD A LA API
                using var respuesta =
                    await clienteHttp.SendAsync(solicitud);

                // VERIFICAR AUTENTICACIÓN
                if (respuesta.StatusCode == HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show(
                        "La sesión ha expirado. Inicie sesión nuevamente.",
                        "Alerta Escolar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // VERIFICAR ERRORES HTTP
                if (!respuesta.IsSuccessStatusCode)
                {
                    MessageBox.Show(
                        $"Error al consultar casos. Código HTTP: {(int)respuesta.StatusCode}",
                        "Alerta Escolar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                // CONVERTIR RESPUESTA JSON EN LISTA DE CASOS
                var casos = await respuesta.Content
                    .ReadFromJsonAsync<List<Caso>>();

                // MOSTRAR CASOS EN LA TABLA
                dgvCasos.DataSource = null;
                dgvCasos.DataSource = casos ?? new List<Caso>();
                // PERSONALIZAR ENCABEZADOS DE LA TABLA
                dgvCasos.Columns["Id"].HeaderText = "N° Caso";
                dgvCasos.Columns["Titulo"].HeaderText = "Título";
                dgvCasos.Columns["Descripcion"].HeaderText = "Descripción";
                dgvCasos.Columns["FechaRegistro"].HeaderText = "Fecha de registro";
                dgvCasos.Columns["Estado"].HeaderText = "Estado";
                dgvCasos.Columns["UsuarioResponsableId"].HeaderText = "Responsable";


                // CONFIGURAR FORMATO DE FECHA
                if (dgvCasos.Columns["FechaRegistro"] != null)
                {
                    dgvCasos.Columns["FechaRegistro"]
                        .DefaultCellStyle.Format = "dd-MM-yyyy HH:mm";
                }
            }
            catch (HttpRequestException)
            {
                MessageBox.Show(
                    "No se pudo conectar con la API. Verifique que esté ejecutándose.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show(
                    "La consulta tardó demasiado.",
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
                await CargarCasosAsync();
            }
            finally
            {
                btnActualizar.Enabled = true;
            }
        }

        // CARGAR CASOS AUTOMÁTICAMENTE AL ABRIR
        private async void FrmListadoCasos_Shown(
            object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;

            try
            {
                await CargarCasosAsync();
            }
            finally
            {
                btnActualizar.Enabled = true;
            }
        }

        private void dgvCasos_CellFormatting(
            object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            if (dgvCasos.Columns[e.ColumnIndex].Name == "Estado"
                && e.Value != null)
            {
                string estado = e.Value.ToString() ?? string.Empty;

                switch (estado)
                {
                    case "Pendiente":
                        e.CellStyle.BackColor =
                            System.Drawing.Color.LightYellow;

                        e.CellStyle.ForeColor =
                            System.Drawing.Color.DarkGoldenrod;
                        break;

                    case "En seguimiento":
                        e.CellStyle.BackColor =
                            System.Drawing.Color.LightBlue;

                        e.CellStyle.ForeColor =
                            System.Drawing.Color.DarkBlue;
                        break;

                    case "Cerrado":
                        e.CellStyle.BackColor =
                            System.Drawing.Color.LightGreen;

                        e.CellStyle.ForeColor =
                            System.Drawing.Color.DarkGreen;
                        break;
                }
            }
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private async void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvCasos.CurrentRow?.DataBoundItem is not Caso caso)
            {
                MessageBox.Show(
                    "Debe seleccionar un caso del listado.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            btnVerDetalle.Enabled = false;

            try
            {
                using (FrmDetalleCaso formulario = new FrmDetalleCaso(caso))
                {
                    formulario.ShowDialog(this);
                }

                await CargarCasosAsync();
            }
            finally
            {
                btnVerDetalle.Enabled = true;
            }
        }

    }
}
