using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlertaEscolar.Desktop
{
    public partial class FrmNuevoUsuario : Form
    {
        private static readonly HttpClient clienteHttp = new HttpClient();

        public FrmNuevoUsuario()
        {
            InitializeComponent();

            // CAMPO CONTRASEÑA
            txtPassword.AutoSize = false;
            txtPassword.Height = txtNombre.Height;

            btnVerPassword.Height = txtPassword.Height;
            btnVerPassword.Top = txtPassword.Top;

            // CAMPO CONFIRMAR CONTRASEÑA
            txtConfirmarPassword.AutoSize = false;
            txtConfirmarPassword.Height = txtNombre.Height;

            btnVerConfirmarPassword.Height = txtConfirmarPassword.Height;
            btnVerConfirmarPassword.Top = txtConfirmarPassword.Top;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string correo = txtCorreo.Text.Trim().ToLowerInvariant();
            string password = txtPassword.Text;
            string confirmarPassword = txtConfirmarPassword.Text;

            // VALIDAR NOMBRE
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show(
                    "Debe ingresar el nombre completo.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombre.Focus();
                return;
            }

            // VALIDAR CORREO ELECTRONICO
            if (!MailAddress.TryCreate(correo, out var direccion) ||
                direccion.Address != correo)
            {
                MessageBox.Show(
                    "Debe ingresar un correo electrónico válido.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCorreo.Focus();
                return;
            }

            // VALIDAR CONTRASEÑA
            if (string.IsNullOrWhiteSpace(password) ||
                password.Length < 12)
            {
                MessageBox.Show(
                    "La contraseña debe tener al menos 12 caracteres.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Focus();
                return;
            }

            // CONFIRMAR CONTRASEÑA
            if (password != confirmarPassword)
            {
                MessageBox.Show(
                    "Las contraseñas no coinciden.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtConfirmarPassword.Focus();
                return;
            }

            // VALIDAR SESION
            if (string.IsNullOrWhiteSpace(SesionUsuario.Token))
            {
                MessageBox.Show(
                    "Debe iniciar sesión nuevamente.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // VALIDAR PERMISOS
            if (SesionUsuario.Rol != "Administrador")
            {
                MessageBox.Show(
                    "No tiene permisos para registrar usuarios.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // CONFIRMAR REGISTRO
            var confirmacion = MessageBox.Show(
                $"¿Desea registrar al usuario {nombre}?",
                "Confirmar registro",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            txtNombre.Enabled = false;
            txtCorreo.Enabled = false;
            txtPassword.Enabled = false;
            txtConfirmarPassword.Enabled = false;
            this.ControlBox = false;

            try
            {
                var nuevoUsuario = new
                {
                    Nombre = nombre,
                    Correo = correo,
                    Password = password
                };

                using var solicitud = new HttpRequestMessage(
                    HttpMethod.Post,
                    "https://localhost:7299/api/usuarios/registrar");

                solicitud.Headers.Authorization =
                    new AuthenticationHeaderValue(
                        "Bearer",
                        SesionUsuario.Token);

                solicitud.Content = JsonContent.Create(nuevoUsuario);

                using var respuesta =
                    await clienteHttp.SendAsync(solicitud);

                // SESION EXPIRADA
                if (respuesta.StatusCode == HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show(
                        "La sesión ha expirado. Inicie sesión nuevamente.",
                        "Alerta Escolar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // PERMISOS INSUFICIENTES
                if (respuesta.StatusCode == HttpStatusCode.Forbidden)
                {
                    MessageBox.Show(
                        "No tiene permisos para registrar usuarios.",
                        "Alerta Escolar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // CORREO DUPLICADO
                if (respuesta.StatusCode == HttpStatusCode.Conflict)
                {
                    MessageBox.Show(
                        "El correo electrónico ya está registrado.",
                        "Alerta Escolar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtCorreo.Enabled = true;
                    txtCorreo.Focus();
                    return;
                }

                // DATOS INVALIDOS
                if (respuesta.StatusCode == HttpStatusCode.BadRequest)
                {
                    MessageBox.Show(
                        "Los datos ingresados no son válidos.",
                        "Alerta Escolar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // OTROS ERRORES
                if (!respuesta.IsSuccessStatusCode)
                {
                    MessageBox.Show(
                        $"Error al registrar usuario. Código HTTP: " +
                        $"{(int)respuesta.StatusCode}",
                        "Alerta Escolar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                // REGISTRO EXITOSO
                txtPassword.Clear();
                txtConfirmarPassword.Clear();

                MessageBox.Show(
                    "El usuario se registró correctamente.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
            }
            catch (HttpRequestException)
            {
                MessageBox.Show(
                    "No se pudo conectar con la API. " +
                    "Verifique que esté ejecutándose.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show(
                    "La solicitud tardó demasiado. " +
                    "Compruebe el listado antes de intentar nuevamente.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            finally
            {
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                txtNombre.Enabled = true;
                txtCorreo.Enabled = true;
                txtPassword.Enabled = true;
                txtConfirmarPassword.Enabled = true;
                this.ControlBox = true;
            }
        }

        private void btnVerPassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar =
        !txtPassword.UseSystemPasswordChar;

            btnVerPassword.Text =
                txtPassword.UseSystemPasswordChar ? "👁" : "🙈";

            txtPassword.Focus();
        }

        private void btnConfirmarPassword_Click(object sender, EventArgs e)
        {
            txtConfirmarPassword.UseSystemPasswordChar =
      !txtConfirmarPassword.UseSystemPasswordChar;

            btnVerConfirmarPassword.Text =
                txtConfirmarPassword.UseSystemPasswordChar ? "👁" : "🙈";

            txtConfirmarPassword.Focus();
        }
    }
}