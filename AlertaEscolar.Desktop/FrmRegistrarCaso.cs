
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace AlertaEscolar.Desktop
{
    public partial class FrmRegistrarCaso : Form
    {
        private static readonly HttpClient clienteHttp = new HttpClient();

        public FrmRegistrarCaso()
        {
            InitializeComponent();
        }

        // BOTÓN CANCELAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // BOTÓN GUARDAR CASO
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            // VALIDAR TÍTULO
            if (string.IsNullOrWhiteSpace(txtTituloCaso.Text))
            {
                MessageBox.Show(
                    "Debe ingresar un título para el caso.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTituloCaso.Focus();
                return;
            }

            // VALIDAR DESCRIPCIÓN
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show(
                    "Debe ingresar una descripción del caso.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtDescripcion.Focus();
                return;
            }

            // VERIFICAR SESIÓN
            if (string.IsNullOrWhiteSpace(SesionUsuario.Token) ||
                SesionUsuario.Id <= 0)
            {
                MessageBox.Show(
                    "No existe una sesión válida. Inicie sesión nuevamente.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // PREPARAR DATOS DEL CASO
            var nuevoCaso = new
            {
                Titulo = txtTituloCaso.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                FechaRegistro = DateTime.UtcNow,
                Estado = "Pendiente",
                UsuarioResponsableId = SesionUsuario.Id
            };

            btnGuardar.Enabled = false;

            try
            {
                // PREPARAR SOLICITUD AUTORIZADA
                using var solicitud = new HttpRequestMessage(
                    HttpMethod.Post,
                    "https://localhost:7299/api/casos");

                solicitud.Headers.Authorization =
                    new AuthenticationHeaderValue(
                        "Bearer",
                        SesionUsuario.Token);

                solicitud.Content =
                    JsonContent.Create(nuevoCaso);

                // ENVIAR CASO A LA API
                using var respuesta =
                    await clienteHttp.SendAsync(solicitud);

                if (respuesta.IsSuccessStatusCode)
                {
                    MessageBox.Show(
                        "El caso se registró correctamente.",
                        "Alerta Escolar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else if (respuesta.StatusCode ==
                         System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show(
                        "La sesión ha expirado o no está autorizada. " +
                        "Inicie sesión nuevamente.",
                        "Alerta Escolar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    string detalle =
                        await respuesta.Content.ReadAsStringAsync();

                    MessageBox.Show(
                        "No fue posible registrar el caso.\n\n" +
                        $"Código HTTP: {(int)respuesta.StatusCode}\n" +
                        detalle,
                        "Alerta Escolar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException)
            {
                MessageBox.Show(
                    "No fue posible conectar con la API. " +
                    "Compruebe que AlertaEscolar.Api esté ejecutándose.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show(
                    "La conexión con la API tardó demasiado.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            finally
            {
                btnGuardar.Enabled = true;
            }
        }
    }
}
