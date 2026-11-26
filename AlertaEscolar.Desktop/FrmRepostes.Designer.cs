namespace AlertaEscolar.Desktop
{
    partial class FrmReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            pnlTotalCasos = new Panel();
            lblTotalCasos = new Label();
            lblTituloTotalCasos = new Label();
            pnlPendientes = new Panel();
            lblPendientes = new Label();
            lblTituloPendientes = new Label();
            pnlEnSeguimiento = new Panel();
            lblEnSeguimiento = new Label();
            lblTituloEnSeguimiento = new Label();
            pnlCerrados = new Panel();
            lblCerrados = new Label();
            lblTituloCerrados = new Label();
            lblTituloGrafico = new Label();
            pnlGrafico = new Panel();
            pnlLeyenda = new Panel();
            lblPorcentajeCierre = new Label();
            prgPorcentajeCierre = new ProgressBar();
            lblTituloPorcentajeCierre = new Label();
            lblPorcentajeCerrados = new Label();
            lblLeyendaCerrados = new Label();
            lblPorcentajeEnSeguimiento = new Label();
            lblLeyendaEnSeguimiento = new Label();
            lblPorcentajePendientes = new Label();
            lblLeyendaPendientes = new Label();
            lblTituloLeyenda = new Label();
            btnActualizar = new Button();
            btnVolver = new Button();
            pnlTotalCasos.SuspendLayout();
            pnlPendientes.SuspendLayout();
            pnlEnSeguimiento.SuspendLayout();
            pnlCerrados.SuspendLayout();
            pnlLeyenda.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.MidnightBlue;
            lblTitulo.Location = new Point(30, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(338, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Reportes y estadísticas";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.ForeColor = Color.DimGray;
            lblSubtitulo.Location = new Point(30, 65);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(417, 23);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Resumen general de los casos de convivencia escolar.";
            // 
            // pnlTotalCasos
            // 
            pnlTotalCasos.BackColor = Color.WhiteSmoke;
            pnlTotalCasos.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalCasos.Controls.Add(lblTotalCasos);
            pnlTotalCasos.Controls.Add(lblTituloTotalCasos);
            pnlTotalCasos.Location = new Point(30, 110);
            pnlTotalCasos.Name = "pnlTotalCasos";
            pnlTotalCasos.Size = new Size(240, 120);
            pnlTotalCasos.TabIndex = 2;
            // 
            // lblTotalCasos
            // 
            lblTotalCasos.BackColor = Color.Transparent;
            lblTotalCasos.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCasos.ForeColor = Color.MidnightBlue;
            lblTotalCasos.Location = new Point(10, 50);
            lblTotalCasos.Name = "lblTotalCasos";
            lblTotalCasos.Size = new Size(218, 55);
            lblTotalCasos.TabIndex = 1;
            lblTotalCasos.Text = "0";
            lblTotalCasos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloTotalCasos
            // 
            lblTituloTotalCasos.BackColor = Color.Transparent;
            lblTituloTotalCasos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloTotalCasos.ForeColor = Color.MidnightBlue;
            lblTituloTotalCasos.Location = new Point(10, 15);
            lblTituloTotalCasos.Name = "lblTituloTotalCasos";
            lblTituloTotalCasos.Size = new Size(218, 30);
            lblTituloTotalCasos.TabIndex = 0;
            lblTituloTotalCasos.Text = "Total de casos";
            lblTituloTotalCasos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlPendientes
            // 
            pnlPendientes.BackColor = Color.LightYellow;
            pnlPendientes.BorderStyle = BorderStyle.FixedSingle;
            pnlPendientes.Controls.Add(lblPendientes);
            pnlPendientes.Controls.Add(lblTituloPendientes);
            pnlPendientes.Location = new Point(290, 110);
            pnlPendientes.Name = "pnlPendientes";
            pnlPendientes.Size = new Size(240, 120);
            pnlPendientes.TabIndex = 3;
            // 
            // lblPendientes
            // 
            lblPendientes.BackColor = Color.Transparent;
            lblPendientes.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendientes.ForeColor = Color.DarkGoldenrod;
            lblPendientes.Location = new Point(10, 50);
            lblPendientes.Name = "lblPendientes";
            lblPendientes.Size = new Size(218, 55);
            lblPendientes.TabIndex = 1;
            lblPendientes.Text = "0";
            lblPendientes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloPendientes
            // 
            lblTituloPendientes.BackColor = Color.Transparent;
            lblTituloPendientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloPendientes.ForeColor = Color.DarkGoldenrod;
            lblTituloPendientes.Location = new Point(10, 15);
            lblTituloPendientes.Name = "lblTituloPendientes";
            lblTituloPendientes.Size = new Size(218, 30);
            lblTituloPendientes.TabIndex = 0;
            lblTituloPendientes.Text = "Casos pendientes";
            lblTituloPendientes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlEnSeguimiento
            // 
            pnlEnSeguimiento.BackColor = Color.LightBlue;
            pnlEnSeguimiento.BorderStyle = BorderStyle.FixedSingle;
            pnlEnSeguimiento.Controls.Add(lblEnSeguimiento);
            pnlEnSeguimiento.Controls.Add(lblTituloEnSeguimiento);
            pnlEnSeguimiento.Location = new Point(550, 110);
            pnlEnSeguimiento.Name = "pnlEnSeguimiento";
            pnlEnSeguimiento.Size = new Size(240, 120);
            pnlEnSeguimiento.TabIndex = 4;
            // 
            // lblEnSeguimiento
            // 
            lblEnSeguimiento.BackColor = Color.Transparent;
            lblEnSeguimiento.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEnSeguimiento.ForeColor = Color.DarkBlue;
            lblEnSeguimiento.Location = new Point(10, 50);
            lblEnSeguimiento.Name = "lblEnSeguimiento";
            lblEnSeguimiento.Size = new Size(218, 55);
            lblEnSeguimiento.TabIndex = 1;
            lblEnSeguimiento.Text = "0";
            lblEnSeguimiento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloEnSeguimiento
            // 
            lblTituloEnSeguimiento.BackColor = Color.Transparent;
            lblTituloEnSeguimiento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloEnSeguimiento.ForeColor = Color.DarkBlue;
            lblTituloEnSeguimiento.Location = new Point(10, 15);
            lblTituloEnSeguimiento.Name = "lblTituloEnSeguimiento";
            lblTituloEnSeguimiento.Size = new Size(218, 30);
            lblTituloEnSeguimiento.TabIndex = 0;
            lblTituloEnSeguimiento.Text = "Casos en seguimiento";
            lblTituloEnSeguimiento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCerrados
            // 
            pnlCerrados.BackColor = Color.LightGreen;
            pnlCerrados.BorderStyle = BorderStyle.FixedSingle;
            pnlCerrados.Controls.Add(lblCerrados);
            pnlCerrados.Controls.Add(lblTituloCerrados);
            pnlCerrados.Location = new Point(810, 110);
            pnlCerrados.Name = "pnlCerrados";
            pnlCerrados.Size = new Size(240, 120);
            pnlCerrados.TabIndex = 5;
            // 
            // lblCerrados
            // 
            lblCerrados.BackColor = Color.Transparent;
            lblCerrados.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCerrados.ForeColor = Color.DarkGreen;
            lblCerrados.Location = new Point(10, 50);
            lblCerrados.Name = "lblCerrados";
            lblCerrados.Size = new Size(218, 55);
            lblCerrados.TabIndex = 1;
            lblCerrados.Text = "0";
            lblCerrados.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloCerrados
            // 
            lblTituloCerrados.BackColor = Color.Transparent;
            lblTituloCerrados.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloCerrados.ForeColor = Color.DarkGreen;
            lblTituloCerrados.Location = new Point(10, 15);
            lblTituloCerrados.Name = "lblTituloCerrados";
            lblTituloCerrados.Size = new Size(218, 30);
            lblTituloCerrados.TabIndex = 0;
            lblTituloCerrados.Text = "Casos cerrados";
            lblTituloCerrados.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloGrafico
            // 
            lblTituloGrafico.AutoSize = true;
            lblTituloGrafico.BackColor = Color.Transparent;
            lblTituloGrafico.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloGrafico.ForeColor = Color.MidnightBlue;
            lblTituloGrafico.Location = new Point(30, 260);
            lblTituloGrafico.Name = "lblTituloGrafico";
            lblTituloGrafico.Size = new Size(362, 31);
            lblTituloGrafico.TabIndex = 6;
            lblTituloGrafico.Text = "Distribución de casos por estado";
            // 
            // pnlGrafico
            // 
            pnlGrafico.BorderStyle = BorderStyle.FixedSingle;
            pnlGrafico.Location = new Point(30, 300);
            pnlGrafico.Name = "pnlGrafico";
            pnlGrafico.Size = new Size(500, 300);
            pnlGrafico.TabIndex = 7;
            // 
            // pnlLeyenda
            // 
            pnlLeyenda.BackColor = Color.WhiteSmoke;
            pnlLeyenda.BorderStyle = BorderStyle.FixedSingle;
            pnlLeyenda.Controls.Add(lblPorcentajeCierre);
            pnlLeyenda.Controls.Add(prgPorcentajeCierre);
            pnlLeyenda.Controls.Add(lblTituloPorcentajeCierre);
            pnlLeyenda.Controls.Add(lblPorcentajeCerrados);
            pnlLeyenda.Controls.Add(lblLeyendaCerrados);
            pnlLeyenda.Controls.Add(lblPorcentajeEnSeguimiento);
            pnlLeyenda.Controls.Add(lblLeyendaEnSeguimiento);
            pnlLeyenda.Controls.Add(lblPorcentajePendientes);
            pnlLeyenda.Controls.Add(lblLeyendaPendientes);
            pnlLeyenda.Controls.Add(lblTituloLeyenda);
            pnlLeyenda.Location = new Point(550, 300);
            pnlLeyenda.Name = "pnlLeyenda";
            pnlLeyenda.Size = new Size(500, 300);
            pnlLeyenda.TabIndex = 8;
            // 
            // lblPorcentajeCierre
            // 
            lblPorcentajeCierre.BackColor = Color.Transparent;
            lblPorcentajeCierre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPorcentajeCierre.ForeColor = Color.DarkGreen;
            lblPorcentajeCierre.Location = new Point(395, 250);
            lblPorcentajeCierre.Name = "lblPorcentajeCierre";
            lblPorcentajeCierre.Size = new Size(83, 35);
            lblPorcentajeCierre.TabIndex = 11;
            lblPorcentajeCierre.Text = "0 %";
            lblPorcentajeCierre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // prgPorcentajeCierre
            // 
            prgPorcentajeCierre.BackColor = Color.Gainsboro;
            prgPorcentajeCierre.ForeColor = Color.ForestGreen;
            prgPorcentajeCierre.Location = new Point(20, 255);
            prgPorcentajeCierre.Name = "prgPorcentajeCierre";
            prgPorcentajeCierre.Size = new Size(370, 25);
            prgPorcentajeCierre.Step = 1;
            prgPorcentajeCierre.Style = ProgressBarStyle.Continuous;
            prgPorcentajeCierre.TabIndex = 10;
            // 
            // lblTituloPorcentajeCierre
            // 
            lblTituloPorcentajeCierre.BackColor = Color.Transparent;
            lblTituloPorcentajeCierre.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloPorcentajeCierre.ForeColor = Color.MidnightBlue;
            lblTituloPorcentajeCierre.Location = new Point(20, 215);
            lblTituloPorcentajeCierre.Name = "lblTituloPorcentajeCierre";
            lblTituloPorcentajeCierre.Size = new Size(458, 30);
            lblTituloPorcentajeCierre.TabIndex = 9;
            lblTituloPorcentajeCierre.Text = "Porcentaje de casos cerrados";
            lblTituloPorcentajeCierre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPorcentajeCerrados
            // 
            lblPorcentajeCerrados.BackColor = Color.Transparent;
            lblPorcentajeCerrados.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPorcentajeCerrados.ForeColor = Color.DarkGreen;
            lblPorcentajeCerrados.Location = new Point(280, 165);
            lblPorcentajeCerrados.Name = "lblPorcentajeCerrados";
            lblPorcentajeCerrados.Size = new Size(198, 35);
            lblPorcentajeCerrados.TabIndex = 6;
            lblPorcentajeCerrados.Text = "0 casos (0 %)";
            lblPorcentajeCerrados.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblLeyendaCerrados
            // 
            lblLeyendaCerrados.BackColor = Color.LightGreen;
            lblLeyendaCerrados.BorderStyle = BorderStyle.FixedSingle;
            lblLeyendaCerrados.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLeyendaCerrados.ForeColor = Color.DarkGreen;
            lblLeyendaCerrados.Location = new Point(20, 165);
            lblLeyendaCerrados.Name = "lblLeyendaCerrados";
            lblLeyendaCerrados.Size = new Size(250, 35);
            lblLeyendaCerrados.TabIndex = 5;
            lblLeyendaCerrados.Text = "Cerrados";
            lblLeyendaCerrados.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPorcentajeEnSeguimiento
            // 
            lblPorcentajeEnSeguimiento.BackColor = Color.Transparent;
            lblPorcentajeEnSeguimiento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPorcentajeEnSeguimiento.ForeColor = Color.DarkBlue;
            lblPorcentajeEnSeguimiento.Location = new Point(280, 115);
            lblPorcentajeEnSeguimiento.Name = "lblPorcentajeEnSeguimiento";
            lblPorcentajeEnSeguimiento.Size = new Size(198, 35);
            lblPorcentajeEnSeguimiento.TabIndex = 4;
            lblPorcentajeEnSeguimiento.Text = "0 casos (0 %)";
            lblPorcentajeEnSeguimiento.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblLeyendaEnSeguimiento
            // 
            lblLeyendaEnSeguimiento.BackColor = Color.LightBlue;
            lblLeyendaEnSeguimiento.BorderStyle = BorderStyle.FixedSingle;
            lblLeyendaEnSeguimiento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLeyendaEnSeguimiento.ForeColor = Color.DarkBlue;
            lblLeyendaEnSeguimiento.Location = new Point(20, 115);
            lblLeyendaEnSeguimiento.Name = "lblLeyendaEnSeguimiento";
            lblLeyendaEnSeguimiento.Size = new Size(250, 35);
            lblLeyendaEnSeguimiento.TabIndex = 3;
            lblLeyendaEnSeguimiento.Text = "En seguimiento";
            lblLeyendaEnSeguimiento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPorcentajePendientes
            // 
            lblPorcentajePendientes.BackColor = Color.Transparent;
            lblPorcentajePendientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPorcentajePendientes.ForeColor = Color.DarkGoldenrod;
            lblPorcentajePendientes.Location = new Point(280, 65);
            lblPorcentajePendientes.Name = "lblPorcentajePendientes";
            lblPorcentajePendientes.Size = new Size(198, 35);
            lblPorcentajePendientes.TabIndex = 2;
            lblPorcentajePendientes.Text = "0 casos (0 %)";
            lblPorcentajePendientes.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblLeyendaPendientes
            // 
            lblLeyendaPendientes.BackColor = Color.LightYellow;
            lblLeyendaPendientes.BorderStyle = BorderStyle.FixedSingle;
            lblLeyendaPendientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLeyendaPendientes.ForeColor = Color.DarkGoldenrod;
            lblLeyendaPendientes.Location = new Point(20, 65);
            lblLeyendaPendientes.Name = "lblLeyendaPendientes";
            lblLeyendaPendientes.Size = new Size(250, 35);
            lblLeyendaPendientes.TabIndex = 1;
            lblLeyendaPendientes.Text = "Pendientes";
            lblLeyendaPendientes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloLeyenda
            // 
            lblTituloLeyenda.BackColor = Color.Transparent;
            lblTituloLeyenda.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloLeyenda.ForeColor = Color.MidnightBlue;
            lblTituloLeyenda.Location = new Point(20, 15);
            lblTituloLeyenda.Name = "lblTituloLeyenda";
            lblTituloLeyenda.Size = new Size(458, 35);
            lblTituloLeyenda.TabIndex = 0;
            lblTituloLeyenda.Text = "Resumen por estado";
            lblTituloLeyenda.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.SteelBlue;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(890, 635);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(160, 45);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Gainsboro;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.Black;
            btnVolver.Location = new Point(710, 635);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(160, 45);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Volver al menú";
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1082, 703);
            Controls.Add(btnVolver);
            Controls.Add(btnActualizar);
            Controls.Add(pnlLeyenda);
            Controls.Add(pnlGrafico);
            Controls.Add(lblTituloGrafico);
            Controls.Add(pnlCerrados);
            Controls.Add(pnlEnSeguimiento);
            Controls.Add(pnlPendientes);
            Controls.Add(pnlTotalCasos);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alerta Escolar - Reportes";
            pnlTotalCasos.ResumeLayout(false);
            pnlPendientes.ResumeLayout(false);
            pnlEnSeguimiento.ResumeLayout(false);
            pnlCerrados.ResumeLayout(false);
            pnlLeyenda.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Panel pnlTotalCasos;
        private Label lblTituloTotalCasos;
        private Label lblTotalCasos;
        private Panel pnlPendientes;
        private Label lblPendientes;
        private Label lblTituloPendientes;
        private Panel pnlEnSeguimiento;
        private Label lblEnSeguimiento;
        private Label lblTituloEnSeguimiento;
        private Panel pnlCerrados;
        private Label lblCerrados;
        private Label lblTituloCerrados;
        private Label lblTituloGrafico;
        private Panel pnlGrafico;
        private Panel pnlLeyenda;
        private Label lblLeyendaPendientes;
        private Label lblTituloLeyenda;
        private Label lblPorcentajePendientes;
        private Label lblLeyendaCerrados;
        private Label lblPorcentajeEnSeguimiento;
        private Label lblLeyendaEnSeguimiento;
        private Label lblPorcentajeCerrados;
        private Label lblTituloPorcentajeCierre;
        private Label lblPorcentajeCierre;
        private ProgressBar prgPorcentajeCierre;
        private Button btnActualizar;
        private Button btnVolver;
    }
}