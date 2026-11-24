namespace AlertaEscolar.Desktop
{
    partial class FrmDetalleCaso
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
            lblNumeroCaso = new Label();
            lblFechaRegistro = new Label();
            lblTituloCaso = new Label();
            txtTituloCaso = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblEstado = new Label();
            cboEstado = new ComboBox();
            lblHistorial = new Label();
            dgvHistorial = new DataGridView();
            btnGuardarCambios = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
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
            lblTitulo.Size = new Size(239, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Detalle del caso";
            // 
            // lblNumeroCaso
            // 
            lblNumeroCaso.AutoSize = true;
            lblNumeroCaso.BackColor = Color.Transparent;
            lblNumeroCaso.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumeroCaso.ForeColor = Color.MidnightBlue;
            lblNumeroCaso.Location = new Point(30, 85);
            lblNumeroCaso.Name = "lblNumeroCaso";
            lblNumeroCaso.Size = new Size(140, 28);
            lblNumeroCaso.TabIndex = 1;
            lblNumeroCaso.Text = "N° de caso: --";
            // 
            // lblFechaRegistro
            // 
            lblFechaRegistro.AutoSize = true;
            lblFechaRegistro.BackColor = Color.Transparent;
            lblFechaRegistro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaRegistro.ForeColor = Color.MidnightBlue;
            lblFechaRegistro.Location = new Point(550, 85);
            lblFechaRegistro.Name = "lblFechaRegistro";
            lblFechaRegistro.Size = new Size(202, 28);
            lblFechaRegistro.TabIndex = 2;
            lblFechaRegistro.Text = "Fecha de registro: --";
            // 
            // lblTituloCaso
            // 
            lblTituloCaso.AutoSize = true;
            lblTituloCaso.BackColor = Color.Transparent;
            lblTituloCaso.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloCaso.Location = new Point(30, 130);
            lblTituloCaso.Name = "lblTituloCaso";
            lblTituloCaso.Size = new Size(141, 25);
            lblTituloCaso.TabIndex = 3;
            lblTituloCaso.Text = "Título del caso:";
            // 
            // txtTituloCaso
            // 
            txtTituloCaso.BackColor = Color.WhiteSmoke;
            txtTituloCaso.BorderStyle = BorderStyle.FixedSingle;
            txtTituloCaso.Font = new Font("Segoe UI", 11F);
            txtTituloCaso.ForeColor = Color.Black;
            txtTituloCaso.Location = new Point(30, 160);
            txtTituloCaso.Name = "txtTituloCaso";
            txtTituloCaso.ReadOnly = true;
            txtTituloCaso.Size = new Size(920, 32);
            txtTituloCaso.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(30, 210);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(190, 25);
            lblDescripcion.TabIndex = 5;
            lblDescripcion.Text = "Descripción del caso:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.WhiteSmoke;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Segoe UI", 11F);
            txtDescripcion.ForeColor = Color.Black;
            txtDescripcion.Location = new Point(30, 240);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ReadOnly = true;
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(920, 120);
            txtDescripcion.TabIndex = 6;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.Transparent;
            lblEstado.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(30, 380);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(148, 25);
            lblEstado.TabIndex = 7;
            lblEstado.Text = "Estado del caso:";
            // 
            // cboEstado
            // 
            cboEstado.BackColor = Color.White;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboEstado.ForeColor = Color.Black;
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "Pendiente", "En seguimiento", "Cerrado" });
            cboEstado.Location = new Point(30, 410);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(300, 33);
            cboEstado.TabIndex = 8;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.BackColor = Color.Transparent;
            lblHistorial.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistorial.ForeColor = Color.MidnightBlue;
            lblHistorial.Location = new Point(30, 460);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(199, 31);
            lblHistorial.TabIndex = 9;
            lblHistorial.Text = "Historial del caso";
            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.BackgroundColor = Color.White;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(30, 495);
            dgvHistorial.MultiSelect = false;
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dgvHistorial.RowHeadersVisible = false;
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.Size = new Size(920, 180);
            dgvHistorial.TabIndex = 10;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.BackColor = Color.SteelBlue;
            btnGuardarCambios.Cursor = Cursors.Hand;
            btnGuardarCambios.FlatStyle = FlatStyle.Flat;
            btnGuardarCambios.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGuardarCambios.ForeColor = Color.White;
            btnGuardarCambios.Location = new Point(750, 695);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(200, 45);
            btnGuardarCambios.TabIndex = 11;
            btnGuardarCambios.Text = "Guardar cambios";
            btnGuardarCambios.UseVisualStyleBackColor = false;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Gainsboro;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.Black;
            btnVolver.Location = new Point(530, 695);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(200, 45);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "Volver al listado";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmDetalleCaso
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1105, 866);
            Controls.Add(btnVolver);
            Controls.Add(btnGuardarCambios);
            Controls.Add(dgvHistorial);
            Controls.Add(lblHistorial);
            Controls.Add(cboEstado);
            Controls.Add(lblEstado);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(txtTituloCaso);
            Controls.Add(lblTituloCaso);
            Controls.Add(lblFechaRegistro);
            Controls.Add(lblNumeroCaso);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmDetalleCaso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alerta Escolar - Detalle del caso";
            Shown += FrmDetalleCaso_Shown;
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNumeroCaso;
        private Label lblFechaRegistro;
        private Label lblTituloCaso;
        private TextBox txtTituloCaso;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Label lblEstado;
        private ComboBox cboEstado;
        private Label lblHistorial;
        private DataGridView dgvHistorial;
        private Button btnGuardarCambios;
        private Button btnVolver;
    }
}