
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlertaEscolar.Shared.Models;

namespace AlertaEscolar.Desktop
{
    public partial class FrmReportes : Form
    {
        private static readonly HttpClient clienteHttp = new HttpClient();

        private int totalCasos = 0;
        private int pendientes = 0;
        private int enSeguimiento = 0;
        private int cerrados = 0;
        private int otrosEstados = 0;

        private bool datosCargados = false;

        public FrmReportes()
        {
            InitializeComponent();

            this.Shown += FrmReportes_Shown;
            pnlGrafico.Paint += pnlGrafico_Paint;
            btnActualizar.Click += btnActualizar_Click;
            btnVolver.Click += btnVolver_Click;
        }

        private async void FrmReportes_Shown(object sender, EventArgs e)
        {
            await ActualizarReportesAsync();
        }

        private async Task ActualizarReportesAsync()
        {
            btnActualizar.Enabled = false;
            btnVolver.Enabled = false;
            this.ControlBox = false;
            this.UseWaitCursor = true;

            try
            {
                await CargarReportesAsync();
            }
            finally
            {
                btnActualizar.Enabled = true;
                btnVolver.Enabled = true;
                this.ControlBox = true;
                this.UseWaitCursor = false;
            }
        }

        private async Task CargarReportesAsync()
        {
            if (string.IsNullOrWhiteSpace(SesionUsuario.Token))
            {
                MessageBox.Show(
                    "Debe iniciar sesión nuevamente.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using var solicitud = new HttpRequestMessage(
                    HttpMethod.Get,
                    "https://localhost:7299/api/casos");

                solicitud.Headers.Authorization =
                    new AuthenticationHeaderValue(
                        "Bearer",
                        SesionUsuario.Token);

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
                        "No tiene permisos para consultar los reportes.",
                        "Alerta Escolar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (!respuesta.IsSuccessStatusCode)
                {
                    MessageBox.Show(
                        $"Error al cargar los reportes. Código HTTP: {(int)respuesta.StatusCode}",
                        "Alerta Escolar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                var casos = await respuesta.Content
                    .ReadFromJsonAsync<List<Caso>>();

                if (casos == null)
                {
                    MessageBox.Show(
                        "No se recibieron datos válidos desde la API.",
                        "Alerta Escolar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                totalCasos = casos.Count;

                pendientes = casos.Count(c =>
                    string.Equals(
                        c.Estado,
                        "Pendiente",
                        StringComparison.OrdinalIgnoreCase));

                enSeguimiento = casos.Count(c =>
                    string.Equals(
                        c.Estado,
                        "En seguimiento",
                        StringComparison.OrdinalIgnoreCase));

                cerrados = casos.Count(c =>
                    string.Equals(
                        c.Estado,
                        "Cerrado",
                        StringComparison.OrdinalIgnoreCase));

                otrosEstados = totalCasos -
                    pendientes - enSeguimiento - cerrados;

                datosCargados = true;

                ActualizarIndicadores();

                pnlGrafico.Invalidate();
            }
            catch (HttpRequestException)
            {
                MessageBox.Show(
                    "No se pudo conectar con la API. Compruebe que esté ejecutándose.",
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
            catch (JsonException)
            {
                MessageBox.Show(
                    "No se pudieron interpretar los datos recibidos.",
                    "Alerta Escolar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (!datosCargados)
                {
                    lblTotalCasos.Text = "—";
                    lblPendientes.Text = "—";
                    lblEnSeguimiento.Text = "—";
                    lblCerrados.Text = "—";

                    lblPorcentajePendientes.Text = "Sin datos";
                    lblPorcentajeEnSeguimiento.Text = "Sin datos";
                    lblPorcentajeCerrados.Text = "Sin datos";
                    lblPorcentajeCierre.Text = "—";

                    prgPorcentajeCierre.Value = 0;

                    pnlGrafico.Invalidate();
                }
            }
        }

        private double CalcularPorcentaje(int cantidad)
        {
            if (totalCasos == 0)
            {
                return 0;
            }

            return cantidad * 100.0 / totalCasos;
        }

        private void ActualizarIndicadores()
        {
            lblTotalCasos.Text = totalCasos.ToString();
            lblPendientes.Text = pendientes.ToString();
            lblEnSeguimiento.Text = enSeguimiento.ToString();
            lblCerrados.Text = cerrados.ToString();

            double porcentajePendientes =
                CalcularPorcentaje(pendientes);

            double porcentajeSeguimiento =
                CalcularPorcentaje(enSeguimiento);

            double porcentajeCerrados =
                CalcularPorcentaje(cerrados);

            lblPorcentajePendientes.Text =
                $"{pendientes} {(pendientes == 1 ? "caso" : "casos")} ({porcentajePendientes:0.#} %)";

            lblPorcentajeEnSeguimiento.Text =
                $"{enSeguimiento} {(enSeguimiento == 1 ? "caso" : "casos")} ({porcentajeSeguimiento:0.#} %)";

            lblPorcentajeCerrados.Text =
                 $"{cerrados} {(cerrados == 1 ? "caso" : "casos")} ({porcentajeCerrados:0.#} %)";

            lblPorcentajeCierre.Text =
                $"{porcentajeCerrados:0.#} %";

            prgPorcentajeCierre.Value = Math.Clamp(
                (int)Math.Round(porcentajeCerrados),
                0,
                100);
        }

        private void pnlGrafico_Paint(object sender, PaintEventArgs e)
        {
            Graphics grafico = e.Graphics;

            grafico.SmoothingMode = SmoothingMode.AntiAlias;

            using Font fuenteMensaje =
                new Font("Segoe UI", 12, FontStyle.Bold);

            using StringFormat formatoCentrado = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            if (!datosCargados || totalCasos == 0)
            {
                string mensaje = datosCargados
                    ? "Sin casos registrados"
                    : "Datos no disponibles";

                grafico.DrawString(
                    mensaje,
                    fuenteMensaje,
                    Brushes.DimGray,
                    pnlGrafico.ClientRectangle,
                    formatoCentrado);

                return;
            }

            int diametro = Math.Min(
                pnlGrafico.ClientSize.Width,
                pnlGrafico.ClientSize.Height) - 50;

            if (diametro <= 0)
            {
                return;
            }

            int posicionX =
                (pnlGrafico.ClientSize.Width - diametro) / 2;

            int posicionY =
                (pnlGrafico.ClientSize.Height - diametro) / 2;

            Rectangle areaGrafico = new Rectangle(
                posicionX,
                posicionY,
                diametro,
                diametro);

            float anguloInicial = -90f;

            int[] cantidades =
            {
                pendientes,
                enSeguimiento,
                cerrados,
                otrosEstados
            };

            Color[] colores =
            {
                Color.LightYellow,
                Color.LightBlue,
                Color.LightGreen,
                Color.LightGray
            };

            using Pen borde = new Pen(Color.Gray, 1);

            for (int i = 0; i < cantidades.Length; i++)
            {
                if (cantidades[i] == 0)
                {
                    continue;
                }

                float angulo =
                    cantidades[i] * 360f / totalCasos;

                using SolidBrush pincel =
                    new SolidBrush(colores[i]);

                grafico.FillPie(
                    pincel,
                    areaGrafico,
                    anguloInicial,
                    angulo);

                grafico.DrawPie(
                    borde,
                    areaGrafico,
                    anguloInicial,
                    angulo);

                anguloInicial += angulo;
            }

            int diametroInterior = (int)(diametro * 0.60);

            Rectangle areaInterior = new Rectangle(
                posicionX + (diametro - diametroInterior) / 2,
                posicionY + (diametro - diametroInterior) / 2,
                diametroInterior,
                diametroInterior);

            grafico.FillEllipse(Brushes.White, areaInterior);
            grafico.DrawEllipse(borde, areaInterior);

            using Font fuenteTotal =
                new Font("Segoe UI", 26, FontStyle.Bold);

            using Font fuenteCasos =
                new Font("Segoe UI", 11, FontStyle.Regular);

            using SolidBrush pincelTexto =
                new SolidBrush(Color.MidnightBlue);

            Rectangle areaTotal = new Rectangle(
                areaInterior.X,
                areaInterior.Y + areaInterior.Height / 2 - 40,
                areaInterior.Width,
                45);

            Rectangle areaTexto = new Rectangle(
                areaInterior.X,
                areaInterior.Y + areaInterior.Height / 2 + 5,
                areaInterior.Width,
                30);

            grafico.DrawString(
                totalCasos.ToString(),
                fuenteTotal,
                pincelTexto,
                areaTotal,
                formatoCentrado);

            grafico.DrawString(
                "Total de casos",
                fuenteCasos,
                pincelTexto,
                areaTexto,
                formatoCentrado);

            if (otrosEstados > 0)
            {
                grafico.DrawString(
                    $"Otros estados (gris): {otrosEstados}",
                    fuenteCasos,
                    Brushes.DimGray,
                    new Rectangle(
                        0,
                        pnlGrafico.ClientSize.Height - 24,
                        pnlGrafico.ClientSize.Width,
                        24),
                    formatoCentrado);
            }
        }

        private async void btnActualizar_Click(
            object sender, EventArgs e)
        {
            await ActualizarReportesAsync();
        }

        private void btnVolver_Click(
            object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
