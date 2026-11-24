namespace AlertaEscolar.Desktop
{
    partial class FrmRegistrarCaso
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
            lblTituloCaso = new Label();
            txtTituloCaso = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.MidnightBlue;
            lblTitulo.Location = new Point(30, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(309, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar nuevo caso";
            // 
            // lblTituloCaso
            // 
            lblTituloCaso.AutoSize = true;
            lblTituloCaso.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloCaso.Location = new Point(30, 100);
            lblTituloCaso.Name = "lblTituloCaso";
            lblTituloCaso.Size = new Size(141, 25);
            lblTituloCaso.TabIndex = 1;
            lblTituloCaso.Text = "Título del caso:";
            // 
            // txtTituloCaso
            // 
            txtTituloCaso.BorderStyle = BorderStyle.FixedSingle;
            txtTituloCaso.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTituloCaso.Location = new Point(30, 130);
            txtTituloCaso.MaxLength = 150;
            txtTituloCaso.Name = "txtTituloCaso";
            txtTituloCaso.Size = new Size(780, 31);
            txtTituloCaso.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(30, 190);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(190, 25);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripción del caso:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(30, 220);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(780, 180);
            txtDescripcion.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(650, 464);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(160, 45);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar caso";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gainsboro;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(460, 460);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(160, 45);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmRegistrarCaso
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(936, 693);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(txtTituloCaso);
            Controls.Add(lblTituloCaso);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmRegistrarCaso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alerta Escolar - Registrar caso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblTituloCaso;
        private TextBox txtTituloCaso;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}