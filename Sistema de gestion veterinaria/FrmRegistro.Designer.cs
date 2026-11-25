namespace Sistema_de_gestion_veterinaria
{
    partial class FrmRegistro
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnRolDueno = new System.Windows.Forms.Button();
            this.btnRolVeterinario = new System.Windows.Forms.Button();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblTipoIdentificacion = new System.Windows.Forms.Label();
            this.cmbTipoIdentificacion = new System.Windows.Forms.ComboBox();
            this.lblNumeroIdentificacion = new System.Windows.Forms.Label();
            this.txtNumeroIdentificacion = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.pnlCamposVeterinario = new System.Windows.Forms.Panel();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pnlDecoracion = new System.Windows.Forms.Panel();
            this.picAnimales = new System.Windows.Forms.PictureBox();
            this.lblDecoracionTitulo = new System.Windows.Forms.Label();
            this.lblDecoracionSub = new System.Windows.Forms.Label();
            this.pnlFondo.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.pnlCamposVeterinario.SuspendLayout();
            this.pnlDecoracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimales)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(247)))));
            this.pnlFondo.Controls.Add(this.pnlCard);
            this.pnlFondo.Controls.Add(this.pnlDecoracion);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(984, 661);
            this.pnlFondo.TabIndex = 0;
            // 
            // pnlCard
            // 
            this.pnlCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCard.AutoScroll = true;
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard.Controls.Add(this.lblTitulo);
            this.pnlCard.Controls.Add(this.lblSubtitulo);
            this.pnlCard.Controls.Add(this.btnRolDueno);
            this.pnlCard.Controls.Add(this.btnRolVeterinario);
            this.pnlCard.Controls.Add(this.lblNombreCompleto);
            this.pnlCard.Controls.Add(this.txtNombreCompleto);
            this.pnlCard.Controls.Add(this.lblNombreUsuario);
            this.pnlCard.Controls.Add(this.txtNombreUsuario);
            this.pnlCard.Controls.Add(this.lblCorreo);
            this.pnlCard.Controls.Add(this.txtCorreo);
            this.pnlCard.Controls.Add(this.lblTipoIdentificacion);
            this.pnlCard.Controls.Add(this.cmbTipoIdentificacion);
            this.pnlCard.Controls.Add(this.lblNumeroIdentificacion);
            this.pnlCard.Controls.Add(this.txtNumeroIdentificacion);
            this.pnlCard.Controls.Add(this.lblContrasena);
            this.pnlCard.Controls.Add(this.txtContrasena);
            this.pnlCard.Controls.Add(this.lblTelefono);
            this.pnlCard.Controls.Add(this.txtTelefono);
            this.pnlCard.Controls.Add(this.lblDireccion);
            this.pnlCard.Controls.Add(this.txtDireccion);
            this.pnlCard.Controls.Add(this.pnlCamposVeterinario);
            this.pnlCard.Controls.Add(this.btnRegistrarUsuario);
            this.pnlCard.Controls.Add(this.btnVolver);
            this.pnlCard.Location = new System.Drawing.Point(440, 20);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Padding = new System.Windows.Forms.Padding(10);
            this.pnlCard.Size = new System.Drawing.Size(515, 620);
            this.pnlCard.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(460, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "👤+  Crear Usuario";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(20, 52);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(460, 20);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Selecciona el tipo de usuario que serás:";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRolDueno
            // 
            this.btnRolDueno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnRolDueno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRolDueno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnRolDueno.FlatAppearance.BorderSize = 2;
            this.btnRolDueno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRolDueno.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRolDueno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnRolDueno.Location = new System.Drawing.Point(20, 78);
            this.btnRolDueno.Name = "btnRolDueno";
            this.btnRolDueno.Size = new System.Drawing.Size(225, 52);
            this.btnRolDueno.TabIndex = 2;
            this.btnRolDueno.Text = "🐾  Dueño de Mascota\r\nRegistra tus mascotas";
            this.btnRolDueno.UseVisualStyleBackColor = false;
            // 
            // btnRolVeterinario
            // 
            this.btnRolVeterinario.BackColor = System.Drawing.Color.White;
            this.btnRolVeterinario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRolVeterinario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(195)))));
            this.btnRolVeterinario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRolVeterinario.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnRolVeterinario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(75)))));
            this.btnRolVeterinario.Location = new System.Drawing.Point(255, 78);
            this.btnRolVeterinario.Name = "btnRolVeterinario";
            this.btnRolVeterinario.Size = new System.Drawing.Size(225, 52);
            this.btnRolVeterinario.TabIndex = 3;
            this.btnRolVeterinario.Text = "🩺  Veterinario\r\nAccede al sistema médico";
            this.btnRolVeterinario.UseVisualStyleBackColor = false;
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(35)))));
            this.lblNombreCompleto.Location = new System.Drawing.Point(20, 137);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(109, 15);
            this.lblNombreCompleto.TabIndex = 4;
            this.lblNombreCompleto.Text = "Nombre Completo *";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.txtNombreCompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCompleto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombreCompleto.Location = new System.Drawing.Point(20, 155);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(225, 25);
            this.txtNombreCompleto.TabIndex = 5;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(35)))));
            this.lblNombreUsuario.Location = new System.Drawing.Point(255, 137);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(102, 15);
            this.lblNombreUsuario.TabIndex = 6;
            this.lblNombreUsuario.Text = "Nombre Usuario *";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombreUsuario.Location = new System.Drawing.Point(255, 155);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(225, 25);
            this.txtNombreUsuario.TabIndex = 7;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(35)))));
            this.lblCorreo.Location = new System.Drawing.Point(20, 185);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(113, 15);
            this.lblCorreo.TabIndex = 8;
            this.lblCorreo.Text = "Correo Electrónico *";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCorreo.Location = new System.Drawing.Point(20, 203);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(460, 25);
            this.txtCorreo.TabIndex = 9;
            // 
            // lblTipoIdentificacion
            // 
            this.lblTipoIdentificacion.AutoSize = true;
            this.lblTipoIdentificacion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTipoIdentificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(35)))));
            this.lblTipoIdentificacion.Location = new System.Drawing.Point(20, 233);
            this.lblTipoIdentificacion.Name = "lblTipoIdentificacion";
            this.lblTipoIdentificacion.Size = new System.Drawing.Size(130, 15);
            this.lblTipoIdentificacion.TabIndex = 10;
            this.lblTipoIdentificacion.Text = "Tipo de Identificación *";
            // 
            // cmbTipoIdentificacion
            // 
            this.cmbTipoIdentificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.cmbTipoIdentificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoIdentificacion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbTipoIdentificacion.FormattingEnabled = true;
            this.cmbTipoIdentificacion.Items.AddRange(new object[] {
            "Cédula de Ciudadanía",
            "Tarjeta de Identidad",
            "Cédula de Extranjería",
            "Pasaporte"});
            this.cmbTipoIdentificacion.Location = new System.Drawing.Point(20, 251);
            this.cmbTipoIdentificacion.Name = "cmbTipoIdentificacion";
            this.cmbTipoIdentificacion.Size = new System.Drawing.Size(225, 25);
            this.cmbTipoIdentificacion.TabIndex = 11;
            // 
            // lblNumeroIdentificacion
            // 
            this.lblNumeroIdentificacion.AutoSize = true;
            this.lblNumeroIdentificacion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNumeroIdentificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(35)))));
            this.lblNumeroIdentificacion.Location = new System.Drawing.Point(255, 233);
            this.lblNumeroIdentificacion.Name = "lblNumeroIdentificacion";
            this.lblNumeroIdentificacion.Size = new System.Drawing.Size(150, 15);
            this.lblNumeroIdentificacion.TabIndex = 12;
            this.lblNumeroIdentificacion.Text = "Número de Identificación *";
            // 
            // txtNumeroIdentificacion
            // 
            this.txtNumeroIdentificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.txtNumeroIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroIdentificacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNumeroIdentificacion.Location = new System.Drawing.Point(255, 251);
            this.txtNumeroIdentificacion.Name = "txtNumeroIdentificacion";
            this.txtNumeroIdentificacion.Size = new System.Drawing.Size(225, 25);
            this.txtNumeroIdentificacion.TabIndex = 13;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(35)))));
            this.lblContrasena.Location = new System.Drawing.Point(20, 281);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(76, 15);
            this.lblContrasena.TabIndex = 14;
            this.lblContrasena.Text = "Contraseña *";
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtContrasena.Location = new System.Drawing.Point(20, 299);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(225, 25);
            this.txtContrasena.TabIndex = 15;
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(35)))));
            this.lblTelefono.Location = new System.Drawing.Point(255, 281);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(62, 15);
            this.lblTelefono.TabIndex = 16;
            this.lblTelefono.Text = "Teléfono *";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTelefono.Location = new System.Drawing.Point(255, 299);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(225, 25);
            this.txtTelefono.TabIndex = 17;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(35)))));
            this.lblDireccion.Location = new System.Drawing.Point(20, 329);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(67, 15);
            this.lblDireccion.TabIndex = 18;
            this.lblDireccion.Text = "Dirección *";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDireccion.Location = new System.Drawing.Point(20, 347);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(460, 25);
            this.txtDireccion.TabIndex = 19;
            // 
            // pnlCamposVeterinario
            // 
            this.pnlCamposVeterinario.Controls.Add(this.lblMatricula);
            this.pnlCamposVeterinario.Controls.Add(this.txtMatricula);
            this.pnlCamposVeterinario.Controls.Add(this.lblEspecialidad);
            this.pnlCamposVeterinario.Controls.Add(this.txtEspecialidad);
            this.pnlCamposVeterinario.Location = new System.Drawing.Point(10, 377);
            this.pnlCamposVeterinario.Name = "pnlCamposVeterinario";
            this.pnlCamposVeterinario.Size = new System.Drawing.Size(480, 58);
            this.pnlCamposVeterinario.TabIndex = 20;
            this.pnlCamposVeterinario.Visible = false;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(35)))));
            this.lblMatricula.Location = new System.Drawing.Point(10, 5);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(130, 15);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula Profesional *";
            // 
            // txtMatricula
            // 
            this.txtMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.txtMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatricula.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatricula.Location = new System.Drawing.Point(10, 23);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(225, 25);
            this.txtMatricula.TabIndex = 1;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblEspecialidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(35)))));
            this.lblEspecialidad.Location = new System.Drawing.Point(245, 5);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(81, 15);
            this.lblEspecialidad.TabIndex = 2;
            this.lblEspecialidad.Text = "Especialidad *";
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.txtEspecialidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEspecialidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEspecialidad.Location = new System.Drawing.Point(245, 23);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(225, 25);
            this.txtEspecialidad.TabIndex = 3;
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnRegistrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarUsuario.FlatAppearance.BorderSize = 0;
            this.btnRegistrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(20, 445);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(300, 42);
            this.btnRegistrarUsuario.TabIndex = 21;
            this.btnRegistrarUsuario.Text = "👤+  Registrar Usuario";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnVolver.Location = new System.Drawing.Point(330, 445);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(150, 42);
            this.btnVolver.TabIndex = 22;
            this.btnVolver.Text = "↩  Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // pnlDecoracion
            // 
            this.pnlDecoracion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDecoracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.pnlDecoracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecoracion.Controls.Add(this.picAnimales);
            this.pnlDecoracion.Controls.Add(this.lblDecoracionTitulo);
            this.pnlDecoracion.Controls.Add(this.lblDecoracionSub);
            this.pnlDecoracion.Location = new System.Drawing.Point(30, 20);
            this.pnlDecoracion.Name = "pnlDecoracion";
            this.pnlDecoracion.Size = new System.Drawing.Size(390, 620);
            this.pnlDecoracion.TabIndex = 0;
            // 
            // picAnimales
            // 
            this.picAnimales.Location = new System.Drawing.Point(20, 110);
            this.picAnimales.Name = "picAnimales";
            this.picAnimales.Size = new System.Drawing.Size(348, 440);
            this.picAnimales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnimales.TabIndex = 2;
            this.picAnimales.TabStop = false;
            // 
            // lblDecoracionTitulo
            // 
            this.lblDecoracionTitulo.AutoSize = true;
            this.lblDecoracionTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblDecoracionTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblDecoracionTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblDecoracionTitulo.Name = "lblDecoracionTitulo";
            this.lblDecoracionTitulo.Size = new System.Drawing.Size(193, 45);
            this.lblDecoracionTitulo.TabIndex = 0;
            this.lblDecoracionTitulo.Text = "🐾 Huellitas";
            // 
            // lblDecoracionSub
            // 
            this.lblDecoracionSub.AutoSize = true;
            this.lblDecoracionSub.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDecoracionSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblDecoracionSub.Location = new System.Drawing.Point(25, 68);
            this.lblDecoracionSub.Name = "lblDecoracionSub";
            this.lblDecoracionSub.Size = new System.Drawing.Size(242, 19);
            this.lblDecoracionSub.TabIndex = 1;
            this.lblDecoracionSub.Text = "Únete a nuestra comunidad de cuidado";
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pnlFondo);
            this.MinimumSize = new System.Drawing.Size(980, 680);
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Huellitas Veterinaria - Crear Usuario";
            this.pnlFondo.ResumeLayout(false);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.pnlCamposVeterinario.ResumeLayout(false);
            this.pnlCamposVeterinario.PerformLayout();
            this.pnlDecoracion.ResumeLayout(false);
            this.pnlDecoracion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimales)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.Panel pnlDecoracion;
        private System.Windows.Forms.Label lblDecoracionTitulo;
        private System.Windows.Forms.Label lblDecoracionSub;
        private System.Windows.Forms.PictureBox picAnimales;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnRolDueno;
        private System.Windows.Forms.Button btnRolVeterinario;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblTipoIdentificacion;
        private System.Windows.Forms.ComboBox cmbTipoIdentificacion;
        private System.Windows.Forms.Label lblNumeroIdentificacion;
        private System.Windows.Forms.TextBox txtNumeroIdentificacion;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Panel pnlCamposVeterinario;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.Button btnRegistrarUsuario;
        private System.Windows.Forms.Button btnVolver;
    }
}
