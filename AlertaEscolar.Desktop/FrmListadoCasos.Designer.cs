namespace AlertaEscolar.Desktop
{
    partial class FrmListadoCasos
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
            dgvCasos = new DataGridView();
            btnActualizar = new Button();
            btnVolver = new Button();
            btnVerDetalle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCasos).BeginInit();
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
            lblTitulo.Size = new Size(245, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Listado de casos";
            // 
            // dgvCasos
            // 
            dgvCasos.AllowUserToAddRows = false;
            dgvCasos.AllowUserToDeleteRows = false;
            dgvCasos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvCasos.BackgroundColor = Color.White;
            dgvCasos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCasos.Location = new Point(30, 100);
            dgvCasos.MultiSelect = false;
            dgvCasos.Name = "dgvCasos";
            dgvCasos.ReadOnly = true;
            dgvCasos.RowHeadersVisible = false;
            dgvCasos.RowHeadersWidth = 51;
            dgvCasos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCasos.Size = new Size(920, 400);
            dgvCasos.TabIndex = 1;
            dgvCasos.CellFormatting += dgvCasos_CellFormatting;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.SteelBlue;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(790, 525);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(160, 45);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Gainsboro;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.Black;
            btnVolver.Location = new Point(610, 525);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(160, 45);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver al menú";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnVerDetalle
            // 
            btnVerDetalle.BackColor = Color.SteelBlue;
            btnVerDetalle.Cursor = Cursors.Hand;
            btnVerDetalle.FlatStyle = FlatStyle.Flat;
            btnVerDetalle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerDetalle.ForeColor = SystemColors.HighlightText;
            btnVerDetalle.Location = new Point(430, 525);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(160, 45);
            btnVerDetalle.TabIndex = 4;
            btnVerDetalle.Text = "Ver Detalles";
            btnVerDetalle.UseVisualStyleBackColor = false;
            btnVerDetalle.Click += btnVerDetalle_Click;
            // 
            // FrmListadoCasos
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1105, 693);
            Controls.Add(btnVerDetalle);
            Controls.Add(btnVolver);
            Controls.Add(btnActualizar);
            Controls.Add(dgvCasos);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmListadoCasos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alerta Escolar - Listado de casos";
            Shown += FrmListadoCasos_Shown;
            ((System.ComponentModel.ISupportInitialize)dgvCasos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvCasos;
        private Button btnActualizar;
        private Button btnVolver;
        private Button btnVerDetalle;
    }
}