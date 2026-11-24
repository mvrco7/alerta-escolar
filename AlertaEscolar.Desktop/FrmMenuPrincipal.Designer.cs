namespace AlertaEscolar.Desktop
{
    partial class FrmMenuPrincipal
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
            pnlMenuLateral = new Panel();
            btnCerrarSesion = new Button();
            btnReportes = new Button();
            btnUsuarios = new Button();
            btnHistorial = new Button();
            btnCasos = new Button();
            btnRegistrarCaso = new Button();
            btnInicio = new Button();
            lblNombreSistema = new Label();
            pnlEncabezado = new Panel();
            lblBienvenida = new Label();
            label1 = new Label();
            pnlTotalCasos = new Panel();
            lblTextoTotalCasos = new Label();
            lblTotalCasos = new Label();
            pnlPendientes = new Panel();
            lblTextoPendientes = new Label();
            lblPendientes = new Label();
            pnlSeguimiento = new Panel();
            lblTextoSeguimiento = new Label();
            label5 = new Label();
            pnlCerrados = new Panel();
            lblTextoCerrados = new Label();
            label7 = new Label();
            lblCasosRecientes = new Label();
            dvgCasosRecientes = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colEstudiante = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            pnlMenuLateral.SuspendLayout();
            pnlEncabezado.SuspendLayout();
            pnlTotalCasos.SuspendLayout();
            pnlPendientes.SuspendLayout();
            pnlSeguimiento.SuspendLayout();
            pnlCerrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgCasosRecientes).BeginInit();
            SuspendLayout();
            // 
            // pnlMenuLateral
            // 
            pnlMenuLateral.BackColor = Color.MidnightBlue;
            pnlMenuLateral.Controls.Add(btnCerrarSesion);
            pnlMenuLateral.Controls.Add(btnReportes);
            pnlMenuLateral.Controls.Add(btnUsuarios);
            pnlMenuLateral.Controls.Add(btnHistorial);
            pnlMenuLateral.Controls.Add(btnCasos);
            pnlMenuLateral.Controls.Add(btnRegistrarCaso);
            pnlMenuLateral.Controls.Add(btnInicio);
            pnlMenuLateral.Controls.Add(lblNombreSistema);
            pnlMenuLateral.Dock = DockStyle.Left;
            pnlMenuLateral.Location = new Point(0, 0);
            pnlMenuLateral.Name = "pnlMenuLateral";
            pnlMenuLateral.Size = new Size(220, 603);
            pnlMenuLateral.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.MidnightBlue;
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(12, 430);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(195, 45);
            btnCerrarSesion.TabIndex = 7;
            btnCerrarSesion.Text = "↪  Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.MidnightBlue;
            btnReportes.Cursor = Cursors.Hand;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.ForeColor = Color.White;
            btnReportes.Location = new Point(12, 360);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(195, 45);
            btnReportes.TabIndex = 6;
            btnReportes.Text = "▥  Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.MidnightBlue;
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Location = new Point(12, 305);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(195, 45);
            btnUsuarios.TabIndex = 5;
            btnUsuarios.Text = "♙  Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.MidnightBlue;
            btnHistorial.Cursor = Cursors.Hand;
            btnHistorial.FlatAppearance.BorderSize = 0;
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistorial.ForeColor = Color.White;
            btnHistorial.Location = new Point(12, 250);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(195, 45);
            btnHistorial.TabIndex = 4;
            btnHistorial.Text = "◷  Historial";
            btnHistorial.UseVisualStyleBackColor = false;
            // 
            // btnCasos
            // 
            btnCasos.BackColor = Color.MidnightBlue;
            btnCasos.Cursor = Cursors.Hand;
            btnCasos.FlatAppearance.BorderSize = 0;
            btnCasos.FlatStyle = FlatStyle.Flat;
            btnCasos.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCasos.ForeColor = Color.White;
            btnCasos.Location = new Point(12, 195);
            btnCasos.Name = "btnCasos";
            btnCasos.Size = new Size(195, 45);
            btnCasos.TabIndex = 3;
            btnCasos.Text = "☷  Casos";
            btnCasos.UseVisualStyleBackColor = false;
            btnCasos.Click += btnCasos_Click;
            // 
            // btnRegistrarCaso
            // 
            btnRegistrarCaso.BackColor = Color.MidnightBlue;
            btnRegistrarCaso.Cursor = Cursors.Hand;
            btnRegistrarCaso.FlatAppearance.BorderSize = 0;
            btnRegistrarCaso.FlatStyle = FlatStyle.Flat;
            btnRegistrarCaso.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarCaso.ForeColor = Color.White;
            btnRegistrarCaso.Location = new Point(12, 140);
            btnRegistrarCaso.Name = "btnRegistrarCaso";
            btnRegistrarCaso.Size = new Size(195, 45);
            btnRegistrarCaso.TabIndex = 2;
            btnRegistrarCaso.Text = "⊕  Registrar caso";
            btnRegistrarCaso.UseVisualStyleBackColor = false;
            btnRegistrarCaso.Click += btnRegistrarCaso_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.RoyalBlue;
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(12, 85);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(195, 45);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "⌂  Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            // 
            // lblNombreSistema
            // 
            lblNombreSistema.AutoSize = true;
            lblNombreSistema.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreSistema.ForeColor = Color.White;
            lblNombreSistema.Location = new Point(20, 25);
            lblNombreSistema.Name = "lblNombreSistema";
            lblNombreSistema.Size = new Size(197, 38);
            lblNombreSistema.TabIndex = 0;
            lblNombreSistema.Text = "Alerta Escolar";
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.AliceBlue;
            pnlEncabezado.Controls.Add(lblBienvenida);
            pnlEncabezado.Controls.Add(label1);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(220, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(762, 80);
            pnlEncabezado.TabIndex = 1;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = Color.MidnightBlue;
            lblBienvenida.Location = new Point(22, 50);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(216, 23);
            lblBienvenida.TabIndex = 1;
            lblBienvenida.Text = "Bienvenido a Alerta Escolar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(227, 41);
            label1.TabIndex = 0;
            label1.Text = "Panel principal";
            // 
            // pnlTotalCasos
            // 
            pnlTotalCasos.BackColor = Color.LightBlue;
            pnlTotalCasos.Controls.Add(lblTextoTotalCasos);
            pnlTotalCasos.Controls.Add(lblTotalCasos);
            pnlTotalCasos.Location = new Point(245, 120);
            pnlTotalCasos.Name = "pnlTotalCasos";
            pnlTotalCasos.Size = new Size(150, 145);
            pnlTotalCasos.TabIndex = 2;
            // 
            // lblTextoTotalCasos
            // 
            lblTextoTotalCasos.AutoSize = true;
            lblTextoTotalCasos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextoTotalCasos.ForeColor = Color.MidnightBlue;
            lblTextoTotalCasos.Location = new Point(22, 105);
            lblTextoTotalCasos.Name = "lblTextoTotalCasos";
            lblTextoTotalCasos.Size = new Size(120, 23);
            lblTextoTotalCasos.TabIndex = 1;
            lblTextoTotalCasos.Text = "Total de casos";
            // 
            // lblTotalCasos
            // 
            lblTotalCasos.AutoSize = true;
            lblTotalCasos.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCasos.ForeColor = Color.MidnightBlue;
            lblTotalCasos.Location = new Point(50, 35);
            lblTotalCasos.Name = "lblTotalCasos";
            lblTotalCasos.Size = new Size(50, 60);
            lblTotalCasos.TabIndex = 0;
            lblTotalCasos.Text = "0";
            lblTotalCasos.Click += lblTotalCasos_Click;
            // 
            // pnlPendientes
            // 
            pnlPendientes.BackColor = Color.MistyRose;
            pnlPendientes.Controls.Add(lblTextoPendientes);
            pnlPendientes.Controls.Add(lblPendientes);
            pnlPendientes.Location = new Point(410, 120);
            pnlPendientes.Name = "pnlPendientes";
            pnlPendientes.Size = new Size(150, 145);
            pnlPendientes.TabIndex = 3;
            // 
            // lblTextoPendientes
            // 
            lblTextoPendientes.AutoSize = true;
            lblTextoPendientes.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextoPendientes.ForeColor = Color.MidnightBlue;
            lblTextoPendientes.Location = new Point(26, 105);
            lblTextoPendientes.Name = "lblTextoPendientes";
            lblTextoPendientes.Size = new Size(96, 23);
            lblTextoPendientes.TabIndex = 1;
            lblTextoPendientes.Text = "Pendientes";
            // 
            // lblPendientes
            // 
            lblPendientes.AutoSize = true;
            lblPendientes.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendientes.ForeColor = Color.MidnightBlue;
            lblPendientes.Location = new Point(53, 35);
            lblPendientes.Name = "lblPendientes";
            lblPendientes.Size = new Size(50, 60);
            lblPendientes.TabIndex = 0;
            lblPendientes.Text = "0";
            // 
            // pnlSeguimiento
            // 
            pnlSeguimiento.BackColor = Color.LemonChiffon;
            pnlSeguimiento.Controls.Add(lblTextoSeguimiento);
            pnlSeguimiento.Controls.Add(label5);
            pnlSeguimiento.Location = new Point(575, 120);
            pnlSeguimiento.Name = "pnlSeguimiento";
            pnlSeguimiento.Size = new Size(150, 145);
            pnlSeguimiento.TabIndex = 3;
            // 
            // lblTextoSeguimiento
            // 
            lblTextoSeguimiento.AutoSize = true;
            lblTextoSeguimiento.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextoSeguimiento.ForeColor = Color.MidnightBlue;
            lblTextoSeguimiento.Location = new Point(14, 105);
            lblTextoSeguimiento.Name = "lblTextoSeguimiento";
            lblTextoSeguimiento.Size = new Size(133, 23);
            lblTextoSeguimiento.TabIndex = 1;
            lblTextoSeguimiento.Text = "En seguimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(49, 35);
            label5.Name = "label5";
            label5.Size = new Size(50, 60);
            label5.TabIndex = 0;
            label5.Text = "0";
            // 
            // pnlCerrados
            // 
            pnlCerrados.BackColor = Color.Honeydew;
            pnlCerrados.Controls.Add(lblTextoCerrados);
            pnlCerrados.Controls.Add(label7);
            pnlCerrados.Location = new Point(740, 120);
            pnlCerrados.Name = "pnlCerrados";
            pnlCerrados.Size = new Size(150, 145);
            pnlCerrados.TabIndex = 3;
            // 
            // lblTextoCerrados
            // 
            lblTextoCerrados.AutoSize = true;
            lblTextoCerrados.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextoCerrados.ForeColor = Color.MidnightBlue;
            lblTextoCerrados.Location = new Point(40, 105);
            lblTextoCerrados.Name = "lblTextoCerrados";
            lblTextoCerrados.Size = new Size(81, 23);
            lblTextoCerrados.TabIndex = 1;
            lblTextoCerrados.Text = "Cerrados";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.MidnightBlue;
            label7.Location = new Point(51, 35);
            label7.Name = "label7";
            label7.Size = new Size(50, 60);
            label7.TabIndex = 0;
            label7.Text = "0";
            // 
            // lblCasosRecientes
            // 
            lblCasosRecientes.AutoSize = true;
            lblCasosRecientes.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCasosRecientes.ForeColor = Color.MidnightBlue;
            lblCasosRecientes.Location = new Point(245, 290);
            lblCasosRecientes.Name = "lblCasosRecientes";
            lblCasosRecientes.Size = new Size(176, 31);
            lblCasosRecientes.TabIndex = 4;
            lblCasosRecientes.Text = "Casos recientes";
            // 
            // dvgCasosRecientes
            // 
            dvgCasosRecientes.AllowUserToAddRows = false;
            dvgCasosRecientes.AllowUserToDeleteRows = false;
            dvgCasosRecientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgCasosRecientes.BackgroundColor = Color.White;
            dvgCasosRecientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgCasosRecientes.Columns.AddRange(new DataGridViewColumn[] { colId, colFecha, colEstudiante, colTipo, colEstado });
            dvgCasosRecientes.Location = new Point(245, 330);
            dvgCasosRecientes.Name = "dvgCasosRecientes";
            dvgCasosRecientes.ReadOnly = true;
            dvgCasosRecientes.RowHeadersVisible = false;
            dvgCasosRecientes.RowHeadersWidth = 51;
            dvgCasosRecientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgCasosRecientes.Size = new Size(645, 220);
            dvgCasosRecientes.TabIndex = 5;
            // 
            // colId
            // 
            colId.HeaderText = "N° Caso";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.MinimumWidth = 6;
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // colEstudiante
            // 
            colEstudiante.HeaderText = "Título";
            colEstudiante.MinimumWidth = 6;
            colEstudiante.Name = "colEstudiante";
            colEstudiante.ReadOnly = true;
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Responsable";
            colTipo.MinimumWidth = 6;
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 6;
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(982, 603);
            Controls.Add(dvgCasosRecientes);
            Controls.Add(lblCasosRecientes);
            Controls.Add(pnlCerrados);
            Controls.Add(pnlSeguimiento);
            Controls.Add(pnlPendientes);
            Controls.Add(pnlTotalCasos);
            Controls.Add(pnlEncabezado);
            Controls.Add(pnlMenuLateral);
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alerta Escolar - Menú principal";
            pnlMenuLateral.ResumeLayout(false);
            pnlMenuLateral.PerformLayout();
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            pnlTotalCasos.ResumeLayout(false);
            pnlTotalCasos.PerformLayout();
            pnlPendientes.ResumeLayout(false);
            pnlPendientes.PerformLayout();
            pnlSeguimiento.ResumeLayout(false);
            pnlSeguimiento.PerformLayout();
            pnlCerrados.ResumeLayout(false);
            pnlCerrados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgCasosRecientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMenuLateral;
        private Label lblNombreSistema;
        private Button btnInicio;
        private Button btnCasos;
        private Button btnRegistrarCaso;
        private Button btnCerrarSesion;
        private Button btnReportes;
        private Button btnUsuarios;
        private Button btnHistorial;
        private Panel pnlEncabezado;
        private Label label1;
        private Label lblBienvenida;
        private Panel pnlTotalCasos;
        private Label lblTextoTotalCasos;
        private Label lblTotalCasos;
        private Panel pnlPendientes;
        private Panel pnlSeguimiento;
        private Panel pnlCerrados;
        private Label lblTextoCerrados;
        private Label label7;
        private Label lblTextoSeguimiento;
        private Label label5;
        private Label lblTextoPendientes;
        private Label lblPendientes;
        private Label lblCasosRecientes;
        private DataGridView dvgCasosRecientes;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colEstudiante;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colEstado;
    }
}