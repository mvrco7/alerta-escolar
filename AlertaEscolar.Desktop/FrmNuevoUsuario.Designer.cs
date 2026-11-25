namespace AlertaEscolar.Desktop
{
    partial class FrmNuevoUsuario
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirmarPassword = new Label();
            txtConfirmarPassword = new TextBox();
            lblRol = new Label();
            txtRol = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnVerPassword = new Button();
            btnVerConfirmarPassword = new Button();
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
            lblTitulo.Size = new Size(352, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar nuevo usuario";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.ForeColor = Color.DimGray;
            lblSubtitulo.Location = new Point(30, 66);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(392, 23);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Complete los datos del nuevo usuario del sistema.";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.MidnightBlue;
            lblNombre.Location = new Point(30, 110);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(166, 25);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre completo";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 11F);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(30, 140);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(670, 32);
            txtNombre.TabIndex = 0;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.BackColor = Color.Transparent;
            lblCorreo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorreo.ForeColor = Color.MidnightBlue;
            lblCorreo.Location = new Point(30, 190);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(169, 25);
            lblCorreo.TabIndex = 3;
            lblCorreo.Text = "Correo electrónico";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.White;
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Font = new Font("Segoe UI", 11F);
            txtCorreo.ForeColor = Color.Black;
            txtCorreo.Location = new Point(30, 220);
            txtCorreo.MaxLength = 254;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(670, 32);
            txtCorreo.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.MidnightBlue;
            lblPassword.Location = new Point(30, 270);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(108, 25);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(30, 300);
            txtPassword.MaxLength = 128;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(629, 32);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmarPassword
            // 
            lblConfirmarPassword.AutoSize = true;
            lblConfirmarPassword.BackColor = Color.Transparent;
            lblConfirmarPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmarPassword.ForeColor = Color.MidnightBlue;
            lblConfirmarPassword.Location = new Point(30, 350);
            lblConfirmarPassword.Name = "lblConfirmarPassword";
            lblConfirmarPassword.Size = new Size(196, 25);
            lblConfirmarPassword.TabIndex = 5;
            lblConfirmarPassword.Text = "Confirmar contraseña";
            // 
            // txtConfirmarPassword
            // 
            txtConfirmarPassword.BackColor = Color.White;
            txtConfirmarPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmarPassword.Font = new Font("Segoe UI", 11F);
            txtConfirmarPassword.ForeColor = Color.Black;
            txtConfirmarPassword.Location = new Point(30, 380);
            txtConfirmarPassword.MaxLength = 128;
            txtConfirmarPassword.Name = "txtConfirmarPassword";
            txtConfirmarPassword.Size = new Size(629, 32);
            txtConfirmarPassword.TabIndex = 3;
            txtConfirmarPassword.UseSystemPasswordChar = true;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.BackColor = Color.Transparent;
            lblRol.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRol.ForeColor = Color.MidnightBlue;
            lblRol.Location = new Point(30, 430);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(122, 25);
            lblRol.TabIndex = 6;
            lblRol.Text = "Rol asignado";
            // 
            // txtRol
            // 
            txtRol.BackColor = Color.WhiteSmoke;
            txtRol.BorderStyle = BorderStyle.FixedSingle;
            txtRol.Font = new Font("Segoe UI", 11F);
            txtRol.ForeColor = Color.DimGray;
            txtRol.Location = new Point(30, 460);
            txtRol.MaxLength = 128;
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(670, 32);
            txtRol.TabIndex = 7;
            txtRol.TabStop = false;
            txtRol.Text = "Encargado de Convivencia Escolar";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(510, 550);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(190, 45);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar usuario";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gainsboro;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(330, 550);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(160, 45);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnVerPassword
            // 
            btnVerPassword.BackColor = Color.White;
            btnVerPassword.Cursor = Cursors.Hand;
            btnVerPassword.FlatAppearance.BorderColor = Color.Gray;
            btnVerPassword.FlatStyle = FlatStyle.Flat;
            btnVerPassword.Font = new Font("Segoe UI Emoji", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerPassword.ForeColor = Color.SteelBlue;
            btnVerPassword.Location = new Point(659, 302);
            btnVerPassword.Name = "btnVerPassword";
            btnVerPassword.Size = new Size(41, 25);
            btnVerPassword.TabIndex = 8;
            btnVerPassword.TabStop = false;
            btnVerPassword.Text = "👁";
            btnVerPassword.UseVisualStyleBackColor = false;
            btnVerPassword.Click += btnVerPassword_Click;
            // 
            // btnVerConfirmarPassword
            // 
            btnVerConfirmarPassword.BackColor = Color.White;
            btnVerConfirmarPassword.Cursor = Cursors.Hand;
            btnVerConfirmarPassword.FlatAppearance.BorderColor = Color.Gray;
            btnVerConfirmarPassword.FlatStyle = FlatStyle.Flat;
            btnVerConfirmarPassword.Font = new Font("Segoe UI Emoji", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerConfirmarPassword.ForeColor = Color.SteelBlue;
            btnVerConfirmarPassword.Location = new Point(659, 382);
            btnVerConfirmarPassword.Name = "btnVerConfirmarPassword";
            btnVerConfirmarPassword.Size = new Size(41, 25);
            btnVerConfirmarPassword.TabIndex = 9;
            btnVerConfirmarPassword.TabStop = false;
            btnVerConfirmarPassword.Text = "👁";
            btnVerConfirmarPassword.UseVisualStyleBackColor = false;
            btnVerConfirmarPassword.Click += btnConfirmarPassword_Click;
            // 
            // FrmNuevoUsuario
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(824, 751);
            Controls.Add(btnVerConfirmarPassword);
            Controls.Add(btnVerPassword);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtRol);
            Controls.Add(lblRol);
            Controls.Add(txtConfirmarPassword);
            Controls.Add(lblConfirmarPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmNuevoUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alerta Escolar - Nuevo usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblConfirmarPassword;
        private TextBox txtConfirmarPassword;
        private Label lblRol;
        private TextBox txtRol;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnVerPassword;
        private Button btnVerConfirmarPassword;
    }
}