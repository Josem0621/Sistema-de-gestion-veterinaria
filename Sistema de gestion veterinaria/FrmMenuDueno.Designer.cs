namespace Sistema_de_gestion_veterinaria
{
    partial class FrmMenuDueno
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblLogoSub = new System.Windows.Forms.Label();
            this.btnNavInicio = new System.Windows.Forms.Button();
            this.btnNavMascotas = new System.Windows.Forms.Button();
            this.btnNavCitas = new System.Windows.Forms.Button();
            this.btnNavHistorial = new System.Windows.Forms.Button();
            this.btnNavNotificaciones = new System.Windows.Forms.Button();
            this.btnNavPerfil = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pnlContenedorPrincipal = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.lblPerfilNombre = new System.Windows.Forms.Label();
            this.pnlMetricas = new System.Windows.Forms.Panel();
            this.cardMetricaMascotas = new System.Windows.Forms.Panel();
            this.lblNumMascotas = new System.Windows.Forms.Label();
            this.lblTextoMascotas = new System.Windows.Forms.Label();
            this.cardMetricaCitas = new System.Windows.Forms.Panel();
            this.lblNumCitas = new System.Windows.Forms.Label();
            this.lblTextoCitas = new System.Windows.Forms.Label();
            this.cardMetricaHistorial = new System.Windows.Forms.Panel();
            this.lblNumHistorial = new System.Windows.Forms.Label();
            this.lblTextoHistorial = new System.Windows.Forms.Label();
            this.cardMetricaNotif = new System.Windows.Forms.Panel();
            this.lblNumNotif = new System.Windows.Forms.Label();
            this.lblTextoNotif = new System.Windows.Forms.Label();
            this.lblSeccionMascotas = new System.Windows.Forms.Label();
            this.btnRegistrarNuevaMascota = new System.Windows.Forms.Button();
            this.flpMascotas = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCitasRecientes = new System.Windows.Forms.Panel();
            this.lblSeccionCitas = new System.Windows.Forms.Label();
            this.lblInfoCita = new System.Windows.Forms.Label();
            this.lblEstadoCitaBadge = new System.Windows.Forms.Label();
            this.btnCancelarCitaDueno = new System.Windows.Forms.Button();
            this.btnAgendarCitaDirecto = new System.Windows.Forms.Button();
            this.pnlNotificacionesRecientes = new System.Windows.Forms.Panel();
            this.lblSeccionNotif = new System.Windows.Forms.Label();
            this.lblInfoNotif = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlContenedorPrincipal.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnlMetricas.SuspendLayout();
            this.cardMetricaMascotas.SuspendLayout();
            this.cardMetricaCitas.SuspendLayout();
            this.cardMetricaHistorial.SuspendLayout();
            this.cardMetricaNotif.SuspendLayout();
            this.pnlCitasRecientes.SuspendLayout();
            this.pnlNotificacionesRecientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Controls.Add(this.lblLogoSub);
            this.pnlSidebar.Controls.Add(this.btnNavInicio);
            this.pnlSidebar.Controls.Add(this.btnNavMascotas);
            this.pnlSidebar.Controls.Add(this.btnNavCitas);
            this.pnlSidebar.Controls.Add(this.btnNavHistorial);
            this.pnlSidebar.Controls.Add(this.btnNavNotificaciones);
            this.pnlSidebar.Controls.Add(this.btnNavPerfil);
            this.pnlSidebar.Controls.Add(this.btnCerrarSesion);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(210, 681);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblLogo.Location = new System.Drawing.Point(10, 15);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(190, 40);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "🐾 Huellitas";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogoSub
            // 
            this.lblLogoSub.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblLogoSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblLogoSub.Location = new System.Drawing.Point(10, 52);
            this.lblLogoSub.Name = "lblLogoSub";
            this.lblLogoSub.Size = new System.Drawing.Size(190, 18);
            this.lblLogoSub.TabIndex = 1;
            this.lblLogoSub.Text = "V E T E R I N A R I A";
            this.lblLogoSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNavInicio
            // 
            this.btnNavInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(244)))), ((int)(((byte)(227)))));
            this.btnNavInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavInicio.FlatAppearance.BorderSize = 0;
            this.btnNavInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavInicio.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnNavInicio.Location = new System.Drawing.Point(15, 95);
            this.btnNavInicio.Name = "btnNavInicio";
            this.btnNavInicio.Size = new System.Drawing.Size(180, 42);
            this.btnNavInicio.TabIndex = 2;
            this.btnNavInicio.Text = "🏠   Inicio";
            this.btnNavInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavInicio.UseVisualStyleBackColor = false;
            // 
            // btnNavMascotas
            // 
            this.btnNavMascotas.BackColor = System.Drawing.Color.White;
            this.btnNavMascotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavMascotas.FlatAppearance.BorderSize = 0;
            this.btnNavMascotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMascotas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavMascotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.btnNavMascotas.Location = new System.Drawing.Point(15, 145);
            this.btnNavMascotas.Name = "btnNavMascotas";
            this.btnNavMascotas.Size = new System.Drawing.Size(180, 42);
            this.btnNavMascotas.TabIndex = 3;
            this.btnNavMascotas.Text = "🐾   Mis Mascotas";
            this.btnNavMascotas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavMascotas.UseVisualStyleBackColor = false;
            // 
            // btnNavCitas
            // 
            this.btnNavCitas.BackColor = System.Drawing.Color.White;
            this.btnNavCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavCitas.FlatAppearance.BorderSize = 0;
            this.btnNavCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCitas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavCitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.btnNavCitas.Location = new System.Drawing.Point(15, 195);
            this.btnNavCitas.Name = "btnNavCitas";
            this.btnNavCitas.Size = new System.Drawing.Size(180, 42);
            this.btnNavCitas.TabIndex = 4;
            this.btnNavCitas.Text = "📅   Mis Citas";
            this.btnNavCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavCitas.UseVisualStyleBackColor = false;
            // 
            // btnNavHistorial
            // 
            this.btnNavHistorial.BackColor = System.Drawing.Color.White;
            this.btnNavHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavHistorial.FlatAppearance.BorderSize = 0;
            this.btnNavHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavHistorial.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.btnNavHistorial.Location = new System.Drawing.Point(15, 245);
            this.btnNavHistorial.Name = "btnNavHistorial";
            this.btnNavHistorial.Size = new System.Drawing.Size(180, 42);
            this.btnNavHistorial.TabIndex = 5;
            this.btnNavHistorial.Text = "📄   Historial Médico";
            this.btnNavHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavHistorial.UseVisualStyleBackColor = false;
            // 
            // btnNavNotificaciones
            // 
            this.btnNavNotificaciones.BackColor = System.Drawing.Color.White;
            this.btnNavNotificaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavNotificaciones.FlatAppearance.BorderSize = 0;
            this.btnNavNotificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavNotificaciones.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavNotificaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.btnNavNotificaciones.Location = new System.Drawing.Point(15, 295);
            this.btnNavNotificaciones.Name = "btnNavNotificaciones";
            this.btnNavNotificaciones.Size = new System.Drawing.Size(180, 42);
            this.btnNavNotificaciones.TabIndex = 6;
            this.btnNavNotificaciones.Text = "🔔   Notificaciones";
            this.btnNavNotificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavNotificaciones.UseVisualStyleBackColor = false;
            // 
            // btnNavPerfil
            // 
            this.btnNavPerfil.BackColor = System.Drawing.Color.White;
            this.btnNavPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavPerfil.FlatAppearance.BorderSize = 0;
            this.btnNavPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavPerfil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.btnNavPerfil.Location = new System.Drawing.Point(15, 345);
            this.btnNavPerfil.Name = "btnNavPerfil";
            this.btnNavPerfil.Size = new System.Drawing.Size(180, 42);
            this.btnNavPerfil.TabIndex = 7;
            this.btnNavPerfil.Text = "👤   Mi Perfil";
            this.btnNavPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavPerfil.UseVisualStyleBackColor = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 634);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(208, 45);
            this.btnCerrarSesion.TabIndex = 8;
            this.btnCerrarSesion.Text = "🚪   Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // pnlContenedorPrincipal
            // 
            this.pnlContenedorPrincipal.AutoScroll = true;
            this.pnlContenedorPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
            this.pnlContenedorPrincipal.Controls.Add(this.pnlHeader);
            this.pnlContenedorPrincipal.Controls.Add(this.pnlMetricas);
            this.pnlContenedorPrincipal.Controls.Add(this.lblSeccionMascotas);
            this.pnlContenedorPrincipal.Controls.Add(this.btnRegistrarNuevaMascota);
            this.pnlContenedorPrincipal.Controls.Add(this.flpMascotas);
            this.pnlContenedorPrincipal.Controls.Add(this.pnlCitasRecientes);
            this.pnlContenedorPrincipal.Controls.Add(this.pnlNotificacionesRecientes);
            this.pnlContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorPrincipal.Location = new System.Drawing.Point(210, 0);
            this.pnlContenedorPrincipal.Name = "pnlContenedorPrincipal";
            this.pnlContenedorPrincipal.Padding = new System.Windows.Forms.Padding(25);
            this.pnlContenedorPrincipal.Size = new System.Drawing.Size(894, 681);
            this.pnlContenedorPrincipal.TabIndex = 1;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblBienvenida);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.picAvatar);
            this.pnlHeader.Controls.Add(this.lblPerfilNombre);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(25, 25);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(844, 75);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblBienvenida.Location = new System.Drawing.Point(5, 5);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(183, 37);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "¡Hola, Luisa! ";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(85)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(8, 45);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(258, 19);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Bienvenida a tu panel de usuario Huellitas ♡";
            // 
            // picAvatar
            // 
            this.picAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picAvatar.BackColor = System.Drawing.Color.White;
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Location = new System.Drawing.Point(660, 10);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(55, 55);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 2;
            this.picAvatar.TabStop = false;
            // 
            // lblPerfilNombre
            // 
            this.lblPerfilNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPerfilNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPerfilNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(40)))));
            this.lblPerfilNombre.Location = new System.Drawing.Point(725, 25);
            this.lblPerfilNombre.Name = "lblPerfilNombre";
            this.lblPerfilNombre.Size = new System.Drawing.Size(115, 25);
            this.lblPerfilNombre.TabIndex = 3;
            this.lblPerfilNombre.Text = "Luisa Carvajal";
            // 
            // pnlMetricas
            // 
            this.pnlMetricas.Controls.Add(this.cardMetricaMascotas);
            this.pnlMetricas.Controls.Add(this.cardMetricaCitas);
            this.pnlMetricas.Controls.Add(this.cardMetricaHistorial);
            this.pnlMetricas.Controls.Add(this.cardMetricaNotif);
            this.pnlMetricas.Location = new System.Drawing.Point(25, 110);
            this.pnlMetricas.Name = "pnlMetricas";
            this.pnlMetricas.Size = new System.Drawing.Size(845, 95);
            this.pnlMetricas.TabIndex = 1;
            // 
            // cardMetricaMascotas
            // 
            this.cardMetricaMascotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.cardMetricaMascotas.Controls.Add(this.lblNumMascotas);
            this.cardMetricaMascotas.Controls.Add(this.lblTextoMascotas);
            this.cardMetricaMascotas.Location = new System.Drawing.Point(0, 5);
            this.cardMetricaMascotas.Name = "cardMetricaMascotas";
            this.cardMetricaMascotas.Size = new System.Drawing.Size(195, 80);
            this.cardMetricaMascotas.TabIndex = 0;
            // 
            // lblNumMascotas
            // 
            this.lblNumMascotas.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblNumMascotas.ForeColor = System.Drawing.Color.White;
            this.lblNumMascotas.Location = new System.Drawing.Point(15, 8);
            this.lblNumMascotas.Name = "lblNumMascotas";
            this.lblNumMascotas.Size = new System.Drawing.Size(80, 40);
            this.lblNumMascotas.TabIndex = 0;
            this.lblNumMascotas.Text = "2";
            // 
            // lblTextoMascotas
            // 
            this.lblTextoMascotas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTextoMascotas.ForeColor = System.Drawing.Color.White;
            this.lblTextoMascotas.Location = new System.Drawing.Point(15, 48);
            this.lblTextoMascotas.Name = "lblTextoMascotas";
            this.lblTextoMascotas.Size = new System.Drawing.Size(160, 22);
            this.lblTextoMascotas.TabIndex = 1;
            this.lblTextoMascotas.Text = "🐾 Mis Mascotas";
            // 
            // cardMetricaCitas
            // 
            this.cardMetricaCitas.BackColor = System.Drawing.Color.White;
            this.cardMetricaCitas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardMetricaCitas.Controls.Add(this.lblNumCitas);
            this.cardMetricaCitas.Controls.Add(this.lblTextoCitas);
            this.cardMetricaCitas.Location = new System.Drawing.Point(215, 5);
            this.cardMetricaCitas.Name = "cardMetricaCitas";
            this.cardMetricaCitas.Size = new System.Drawing.Size(195, 80);
            this.cardMetricaCitas.TabIndex = 1;
            // 
            // lblNumCitas
            // 
            this.lblNumCitas.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblNumCitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblNumCitas.Location = new System.Drawing.Point(15, 8);
            this.lblNumCitas.Name = "lblNumCitas";
            this.lblNumCitas.Size = new System.Drawing.Size(80, 40);
            this.lblNumCitas.TabIndex = 0;
            this.lblNumCitas.Text = "1";
            // 
            // lblTextoCitas
            // 
            this.lblTextoCitas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTextoCitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(75)))));
            this.lblTextoCitas.Location = new System.Drawing.Point(15, 48);
            this.lblTextoCitas.Name = "lblTextoCitas";
            this.lblTextoCitas.Size = new System.Drawing.Size(160, 22);
            this.lblTextoCitas.TabIndex = 1;
            this.lblTextoCitas.Text = "📅 Próxima Cita";
            // 
            // cardMetricaHistorial
            // 
            this.cardMetricaHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.cardMetricaHistorial.Controls.Add(this.lblNumHistorial);
            this.cardMetricaHistorial.Controls.Add(this.lblTextoHistorial);
            this.cardMetricaHistorial.Location = new System.Drawing.Point(430, 5);
            this.cardMetricaHistorial.Name = "cardMetricaHistorial";
            this.cardMetricaHistorial.Size = new System.Drawing.Size(195, 80);
            this.cardMetricaHistorial.TabIndex = 2;
            // 
            // lblNumHistorial
            // 
            this.lblNumHistorial.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblNumHistorial.ForeColor = System.Drawing.Color.White;
            this.lblNumHistorial.Location = new System.Drawing.Point(15, 8);
            this.lblNumHistorial.Name = "lblNumHistorial";
            this.lblNumHistorial.Size = new System.Drawing.Size(80, 40);
            this.lblNumHistorial.TabIndex = 0;
            this.lblNumHistorial.Text = "3";
            // 
            // lblTextoHistorial
            // 
            this.lblTextoHistorial.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTextoHistorial.ForeColor = System.Drawing.Color.White;
            this.lblTextoHistorial.Location = new System.Drawing.Point(15, 48);
            this.lblTextoHistorial.Name = "lblTextoHistorial";
            this.lblTextoHistorial.Size = new System.Drawing.Size(160, 22);
            this.lblTextoHistorial.TabIndex = 1;
            this.lblTextoHistorial.Text = "📄 Historial Médico";
            // 
            // cardMetricaNotif
            // 
            this.cardMetricaNotif.BackColor = System.Drawing.Color.White;
            this.cardMetricaNotif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardMetricaNotif.Controls.Add(this.lblNumNotif);
            this.cardMetricaNotif.Controls.Add(this.lblTextoNotif);
            this.cardMetricaNotif.Location = new System.Drawing.Point(645, 5);
            this.cardMetricaNotif.Name = "cardMetricaNotif";
            this.cardMetricaNotif.Size = new System.Drawing.Size(195, 80);
            this.cardMetricaNotif.TabIndex = 3;
            // 
            // lblNumNotif
            // 
            this.lblNumNotif.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblNumNotif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblNumNotif.Location = new System.Drawing.Point(15, 8);
            this.lblNumNotif.Name = "lblNumNotif";
            this.lblNumNotif.Size = new System.Drawing.Size(80, 40);
            this.lblNumNotif.TabIndex = 0;
            this.lblNumNotif.Text = "1";
            // 
            // lblTextoNotif
            // 
            this.lblTextoNotif.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTextoNotif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(75)))));
            this.lblTextoNotif.Location = new System.Drawing.Point(15, 48);
            this.lblTextoNotif.Name = "lblTextoNotif";
            this.lblTextoNotif.Size = new System.Drawing.Size(160, 22);
            this.lblTextoNotif.TabIndex = 1;
            this.lblTextoNotif.Text = "🔔 Notificaciones";
            // 
            // lblSeccionMascotas
            // 
            this.lblSeccionMascotas.AutoSize = true;
            this.lblSeccionMascotas.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSeccionMascotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblSeccionMascotas.Location = new System.Drawing.Point(25, 220);
            this.lblSeccionMascotas.Name = "lblSeccionMascotas";
            this.lblSeccionMascotas.Size = new System.Drawing.Size(150, 25);
            this.lblSeccionMascotas.TabIndex = 2;
            this.lblSeccionMascotas.Text = "🐾 Mis Mascotas";
            // 
            // btnRegistrarNuevaMascota
            // 
            this.btnRegistrarNuevaMascota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnRegistrarNuevaMascota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarNuevaMascota.FlatAppearance.BorderSize = 0;
            this.btnRegistrarNuevaMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarNuevaMascota.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarNuevaMascota.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarNuevaMascota.Location = new System.Drawing.Point(670, 215);
            this.btnRegistrarNuevaMascota.Name = "btnRegistrarNuevaMascota";
            this.btnRegistrarNuevaMascota.Size = new System.Drawing.Size(195, 35);
            this.btnRegistrarNuevaMascota.TabIndex = 3;
            this.btnRegistrarNuevaMascota.Text = "➕  Registrar Mascota";
            this.btnRegistrarNuevaMascota.UseVisualStyleBackColor = false;
            this.btnRegistrarNuevaMascota.Visible = false;
            // 
            // flpMascotas
            // 
            this.flpMascotas.AutoScroll = true;
            this.flpMascotas.BackColor = System.Drawing.Color.Transparent;
            this.flpMascotas.Location = new System.Drawing.Point(25, 260);
            this.flpMascotas.Name = "flpMascotas";
            this.flpMascotas.Size = new System.Drawing.Size(845, 195);
            this.flpMascotas.TabIndex = 4;
            // 
            // pnlCitasRecientes
            // 
            this.pnlCitasRecientes.BackColor = System.Drawing.Color.White;
            this.pnlCitasRecientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCitasRecientes.Controls.Add(this.lblSeccionCitas);
            this.pnlCitasRecientes.Controls.Add(this.lblInfoCita);
            this.pnlCitasRecientes.Controls.Add(this.lblEstadoCitaBadge);
            this.pnlCitasRecientes.Controls.Add(this.btnCancelarCitaDueno);
            this.pnlCitasRecientes.Controls.Add(this.btnAgendarCitaDirecto);
            this.pnlCitasRecientes.Location = new System.Drawing.Point(25, 470);
            this.pnlCitasRecientes.Name = "pnlCitasRecientes";
            this.pnlCitasRecientes.Size = new System.Drawing.Size(415, 170);
            this.pnlCitasRecientes.TabIndex = 5;
            // 
            // lblSeccionCitas
            // 
            this.lblSeccionCitas.AutoSize = true;
            this.lblSeccionCitas.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblSeccionCitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblSeccionCitas.Location = new System.Drawing.Point(15, 12);
            this.lblSeccionCitas.Name = "lblSeccionCitas";
            this.lblSeccionCitas.Size = new System.Drawing.Size(125, 21);
            this.lblSeccionCitas.TabIndex = 0;
            this.lblSeccionCitas.Text = "📅  Próxima Cita";
            // 
            // lblInfoCita
            // 
            this.lblInfoCita.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblInfoCita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.lblInfoCita.Location = new System.Drawing.Point(15, 45);
            this.lblInfoCita.Name = "lblInfoCita";
            this.lblInfoCita.Size = new System.Drawing.Size(380, 75);
            this.lblInfoCita.TabIndex = 1;
            this.lblInfoCita.Text = "Cargando próxima cita...";
            // 
            // lblEstadoCitaBadge
            // 
            this.lblEstadoCitaBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(248)))), ((int)(((byte)(230)))));
            this.lblEstadoCitaBadge.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstadoCitaBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblEstadoCitaBadge.Location = new System.Drawing.Point(15, 128);
            this.lblEstadoCitaBadge.Name = "lblEstadoCitaBadge";
            this.lblEstadoCitaBadge.Size = new System.Drawing.Size(120, 26);
            this.lblEstadoCitaBadge.TabIndex = 2;
            this.lblEstadoCitaBadge.Text = "Confirmada";
            this.lblEstadoCitaBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // 
            // btnCancelarCitaDueno
            // 
            this.btnCancelarCitaDueno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnCancelarCitaDueno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarCitaDueno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCancelarCitaDueno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCitaDueno.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelarCitaDueno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancelarCitaDueno.Location = new System.Drawing.Point(145, 126);
            this.btnCancelarCitaDueno.Name = "btnCancelarCitaDueno";
            this.btnCancelarCitaDueno.Size = new System.Drawing.Size(125, 28);
            this.btnCancelarCitaDueno.TabIndex = 3;
            this.btnCancelarCitaDueno.Text = "❌ Cancelar Cita";
            this.btnCancelarCitaDueno.UseVisualStyleBackColor = false;
            this.btnCancelarCitaDueno.Visible = false;
            // 
            // btnAgendarCitaDirecto
            // 
            this.btnAgendarCitaDirecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnAgendarCitaDirecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgendarCitaDirecto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnAgendarCitaDirecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendarCitaDirecto.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnAgendarCitaDirecto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnAgendarCitaDirecto.Location = new System.Drawing.Point(280, 126);
            this.btnAgendarCitaDirecto.Name = "btnAgendarCitaDirecto";
            this.btnAgendarCitaDirecto.Size = new System.Drawing.Size(120, 28);
            this.btnAgendarCitaDirecto.TabIndex = 4;
            this.btnAgendarCitaDirecto.Text = "📅 Agendar Cita";
            this.btnAgendarCitaDirecto.UseVisualStyleBackColor = false;
            // 
            // pnlNotificacionesRecientes
            // 
            this.pnlNotificacionesRecientes.BackColor = System.Drawing.Color.White;
            this.pnlNotificacionesRecientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNotificacionesRecientes.Controls.Add(this.lblSeccionNotif);
            this.pnlNotificacionesRecientes.Controls.Add(this.lblInfoNotif);
            this.pnlNotificacionesRecientes.Location = new System.Drawing.Point(455, 470);
            this.pnlNotificacionesRecientes.Name = "pnlNotificacionesRecientes";
            this.pnlNotificacionesRecientes.Size = new System.Drawing.Size(415, 170);
            this.pnlNotificacionesRecientes.TabIndex = 6;
            // 
            // lblSeccionNotif
            // 
            this.lblSeccionNotif.AutoSize = true;
            this.lblSeccionNotif.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblSeccionNotif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblSeccionNotif.Location = new System.Drawing.Point(15, 12);
            this.lblSeccionNotif.Name = "lblSeccionNotif";
            this.lblSeccionNotif.Size = new System.Drawing.Size(201, 21);
            this.lblSeccionNotif.TabIndex = 0;
            this.lblSeccionNotif.Text = "🔔  Notificaciones Recientes";
            // 
            // lblInfoNotif
            // 
            this.lblInfoNotif.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblInfoNotif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.lblInfoNotif.Location = new System.Drawing.Point(15, 45);
            this.lblInfoNotif.Name = "lblInfoNotif";
            this.lblInfoNotif.Size = new System.Drawing.Size(380, 100);
            this.lblInfoNotif.TabIndex = 1;
            this.lblInfoNotif.Text = "Cargando notificaciones...";
            // 
            // FrmMenuDueno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 681);
            this.Controls.Add(this.pnlContenedorPrincipal);
            this.Controls.Add(this.pnlSidebar);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "FrmMenuDueno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Huellitas Veterinaria - Panel Dueño";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlContenedorPrincipal.ResumeLayout(false);
            this.pnlContenedorPrincipal.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnlMetricas.ResumeLayout(false);
            this.cardMetricaMascotas.ResumeLayout(false);
            this.cardMetricaCitas.ResumeLayout(false);
            this.cardMetricaHistorial.ResumeLayout(false);
            this.cardMetricaNotif.ResumeLayout(false);
            this.pnlCitasRecientes.ResumeLayout(false);
            this.pnlCitasRecientes.PerformLayout();
            this.pnlNotificacionesRecientes.ResumeLayout(false);
            this.pnlNotificacionesRecientes.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblLogoSub;
        private System.Windows.Forms.Button btnNavInicio;
        private System.Windows.Forms.Button btnNavMascotas;
        private System.Windows.Forms.Button btnNavCitas;
        private System.Windows.Forms.Button btnNavHistorial;
        private System.Windows.Forms.Button btnNavNotificaciones;
        private System.Windows.Forms.Button btnNavPerfil;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel pnlContenedorPrincipal;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblPerfilNombre;
        private System.Windows.Forms.Panel pnlMetricas;
        private System.Windows.Forms.Panel cardMetricaMascotas;
        private System.Windows.Forms.Label lblNumMascotas;
        private System.Windows.Forms.Label lblTextoMascotas;
        private System.Windows.Forms.Panel cardMetricaCitas;
        private System.Windows.Forms.Label lblNumCitas;
        private System.Windows.Forms.Label lblTextoCitas;
        private System.Windows.Forms.Panel cardMetricaHistorial;
        private System.Windows.Forms.Label lblNumHistorial;
        private System.Windows.Forms.Label lblTextoHistorial;
        private System.Windows.Forms.Panel cardMetricaNotif;
        private System.Windows.Forms.Label lblNumNotif;
        private System.Windows.Forms.Label lblTextoNotif;
        private System.Windows.Forms.Label lblSeccionMascotas;
        private System.Windows.Forms.Button btnRegistrarNuevaMascota;
        private System.Windows.Forms.FlowLayoutPanel flpMascotas;
        private System.Windows.Forms.Panel pnlCitasRecientes;
        private System.Windows.Forms.Label lblSeccionCitas;
        private System.Windows.Forms.Label lblInfoCita;
        private System.Windows.Forms.Label lblEstadoCitaBadge;
        private System.Windows.Forms.Button btnCancelarCitaDueno;
        private System.Windows.Forms.Button btnAgendarCitaDirecto;
        private System.Windows.Forms.Panel pnlNotificacionesRecientes;
        private System.Windows.Forms.Label lblSeccionNotif;
        private System.Windows.Forms.Label lblInfoNotif;
    }
}
