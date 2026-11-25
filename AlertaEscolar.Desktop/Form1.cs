
using System.Net.Http.Json;
using System.Text.Json;

namespace AlertaEscolar.Desktop
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            txtPassword.AutoSize = false;
            txtPassword.Height = 27;

            btnVerPassword.Height = txtPassword.Height;
            btnVerPassword.Top = txtPassword.Top;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Ingresa tu correo electrónico y contraseña.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            btnIngresar.Enabled = false;

            try
            {
                using HttpClient cliente = new HttpClient
                {
                    BaseAddress = new Uri("https://localhost:7299/")
                };

                var datos = new
                {
                    correo,
                    password
                };

                using var respuesta = await cliente.PostAsJsonAsync(
                    "api/usuarios/login", datos);


                if (respuesta.IsSuccessStatusCode)
                {
                    using JsonDocument documento =
                        await JsonDocument.ParseAsync(
                            await respuesta.Content.ReadAsStreamAsync());

                    JsonElement datosUsuario = documento.RootElement;

                    SesionUsuario.Token =
                        datosUsuario.GetProperty("token").GetString() ?? string.Empty;

                    SesionUsuario.Id =
                        datosUsuario.GetProperty("id").GetInt32();

                    SesionUsuario.Nombre =
                        datosUsuario.GetProperty("nombre").GetString() ?? string.Empty;

                    SesionUsuario.Correo =
                        datosUsuario.GetProperty("correo").GetString() ?? string.Empty;

                    SesionUsuario.Rol =
                        datosUsuario.GetProperty("rol").GetString() ?? string.Empty;

                    MessageBox.Show(
                        "Inicio de sesión exitoso.",
                        "Alerta Escolar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    using FrmMenuPrincipal menuPrincipal =
                        new FrmMenuPrincipal();

                    this.Hide();

                    try
                    {
                        menuPrincipal.ShowDialog();
                    }
                    finally
                    {
                        SesionUsuario.CerrarSesion();
                        txtPassword.Clear();
                        txtPassword.UseSystemPasswordChar = true;
                        btnVerPassword.Text = "👁";
                        this.Show();
                    }
                }

                else if (respuesta.StatusCode ==
                         System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show(
                        "Correo o contraseña incorrectos.",
                        "Alerta Escolar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(
                        $"Error al iniciar sesión. Código: {(int)respuesta.StatusCode}",
                        "Alerta Escolar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException)
            {
                MessageBox.Show(
                    "No se pudo conectar con la API. Comprueba que esté ejecutándose.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show(
                    "La conexión tardó demasiado.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            finally
            {
                btnIngresar.Enabled = true;
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
    }
}
