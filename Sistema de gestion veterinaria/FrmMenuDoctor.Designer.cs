namespace Sistema_de_gestion_veterinaria
{
    partial class FrmMenuDoctor
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
            this.btnNavBuscar = new System.Windows.Forms.Button();
            this.btnNavRegistrarMascota = new System.Windows.Forms.Button();
            this.btnNavHistorial = new System.Windows.Forms.Button();
            this.btnNavCitas = new System.Windows.Forms.Button();
            this.btnNavNotificaciones = new System.Windows.Forms.Button();
            this.btnNavPerfil = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblBienvenidaDoctor = new System.Windows.Forms.Label();
            this.lblSubtituloDoctor = new System.Windows.Forms.Label();
            this.picAvatarDoctor = new System.Windows.Forms.PictureBox();
            this.lblNombreDoctor = new System.Windows.Forms.Label();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.lblTituloBuscar = new System.Windows.Forms.Label();
            this.lblCarneDesc = new System.Windows.Forms.Label();
            this.txtBuscarCarne = new System.Windows.Forms.TextBox();
            this.lblO = new System.Windows.Forms.Label();
            this.lblCedulaDesc = new System.Windows.Forms.Label();
            this.txtBuscarCedula = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlMetricas = new System.Windows.Forms.Panel();
            this.cardMetricaAtendidas = new System.Windows.Forms.Panel();
            this.lblNumAtendidas = new System.Windows.Forms.Label();
            this.lblTextoAtendidas = new System.Windows.Forms.Label();
            this.cardMetricaCitasHoy = new System.Windows.Forms.Panel();
            this.lblNumCitasHoy = new System.Windows.Forms.Label();
            this.lblTextoCitasHoy = new System.Windows.Forms.Label();
            this.cardMetricaHistorias = new System.Windows.Forms.Panel();
            this.lblNumHistorias = new System.Windows.Forms.Label();
            this.lblTextoHistorias = new System.Windows.Forms.Label();
            this.cardMetricaNotif = new System.Windows.Forms.Panel();
            this.lblNumNotif = new System.Windows.Forms.Label();
            this.lblTextoNotif = new System.Windows.Forms.Label();
            this.pnlCitas = new System.Windows.Forms.Panel();
            this.lblTituloCitas = new System.Windows.Forms.Label();
            this.dgvProximasCitas = new System.Windows.Forms.DataGridView();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlInfoRapida = new System.Windows.Forms.Panel();
            this.lblTituloInfoRapida = new System.Windows.Forms.Label();
            this.picMascotaRapida = new System.Windows.Forms.PictureBox();
            this.lblNombreMascotaRapida = new System.Windows.Forms.Label();
            this.lblDetalleMascotaRapida = new System.Windows.Forms.Label();
            this.lblEstadoRapido = new System.Windows.Forms.Label();
            this.lblUltimaConsulta = new System.Windows.Forms.Label();
            this.btnVerHistorialRapido = new System.Windows.Forms.Button();
            this.pnlNotifRecientes = new System.Windows.Forms.Panel();
            this.lblTituloNotif = new System.Windows.Forms.Label();
            this.lblTextoNotificacion = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatarDoctor)).BeginInit();
            this.pnlBuscar.SuspendLayout();
            this.pnlMetricas.SuspendLayout();
            this.cardMetricaAtendidas.SuspendLayout();
            this.cardMetricaCitasHoy.SuspendLayout();
            this.cardMetricaHistorias.SuspendLayout();
            this.cardMetricaNotif.SuspendLayout();
            this.pnlCitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProximasCitas)).BeginInit();
            this.pnlInfoRapida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMascotaRapida)).BeginInit();
            this.pnlNotifRecientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Controls.Add(this.lblLogoSub);
            this.pnlSidebar.Controls.Add(this.btnNavInicio);
            this.pnlSidebar.Controls.Add(this.btnNavBuscar);
            this.pnlSidebar.Controls.Add(this.btnNavRegistrarMascota);
            this.pnlSidebar.Controls.Add(this.btnNavHistorial);
            this.pnlSidebar.Controls.Add(this.btnNavCitas);
            this.pnlSidebar.Controls.Add(this.btnNavNotificaciones);
            this.pnlSidebar.Controls.Add(this.btnNavPerfil);
            this.pnlSidebar.Controls.Add(this.btnCerrarSesion);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 721);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblLogo.Location = new System.Drawing.Point(5, 15);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(185, 35);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "🐾 Huellitas";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogoSub
            // 
            this.lblLogoSub.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblLogoSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblLogoSub.Location = new System.Drawing.Point(5, 50);
            this.lblLogoSub.Name = "lblLogoSub";
            this.lblLogoSub.Size = new System.Drawing.Size(185, 18);
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
            this.btnNavInicio.Location = new System.Drawing.Point(12, 90);
            this.btnNavInicio.Name = "btnNavInicio";
            this.btnNavInicio.Size = new System.Drawing.Size(175, 42);
            this.btnNavInicio.TabIndex = 2;
            this.btnNavInicio.Text = "🏠   Inicio";
            this.btnNavInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavInicio.UseVisualStyleBackColor = false;
            // 
            // btnNavBuscar
            // 
            this.btnNavBuscar.BackColor = System.Drawing.Color.White;
            this.btnNavBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavBuscar.FlatAppearance.BorderSize = 0;
            this.btnNavBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.btnNavBuscar.Location = new System.Drawing.Point(12, 140);
            this.btnNavBuscar.Name = "btnNavBuscar";
            this.btnNavBuscar.Size = new System.Drawing.Size(175, 42);
            this.btnNavBuscar.TabIndex = 3;
            this.btnNavBuscar.Text = "🔍   Buscar Mascota";
            this.btnNavBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavBuscar.UseVisualStyleBackColor = false;
            // 
            // btnNavRegistrarMascota
            // 
            this.btnNavRegistrarMascota.BackColor = System.Drawing.Color.White;
            this.btnNavRegistrarMascota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavRegistrarMascota.FlatAppearance.BorderSize = 0;
            this.btnNavRegistrarMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavRegistrarMascota.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavRegistrarMascota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.btnNavRegistrarMascota.Location = new System.Drawing.Point(12, 190);
            this.btnNavRegistrarMascota.Name = "btnNavRegistrarMascota";
            this.btnNavRegistrarMascota.Size = new System.Drawing.Size(175, 42);
            this.btnNavRegistrarMascota.TabIndex = 4;
            this.btnNavRegistrarMascota.Text = "🐾   Registrar Mascota";
            this.btnNavRegistrarMascota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavRegistrarMascota.UseVisualStyleBackColor = false;
            // 
            // btnNavHistorial
            // 
            this.btnNavHistorial.BackColor = System.Drawing.Color.White;
            this.btnNavHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavHistorial.FlatAppearance.BorderSize = 0;
            this.btnNavHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavHistorial.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.btnNavHistorial.Location = new System.Drawing.Point(12, 240);
            this.btnNavHistorial.Name = "btnNavHistorial";
            this.btnNavHistorial.Size = new System.Drawing.Size(175, 42);
            this.btnNavHistorial.TabIndex = 5;
            this.btnNavHistorial.Text = "📄   Historial Médico";
            this.btnNavHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavHistorial.UseVisualStyleBackColor = false;
            // 
            // btnNavCitas
            // 
            this.btnNavCitas.BackColor = System.Drawing.Color.White;
            this.btnNavCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavCitas.FlatAppearance.BorderSize = 0;
            this.btnNavCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCitas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavCitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.btnNavCitas.Location = new System.Drawing.Point(12, 290);
            this.btnNavCitas.Name = "btnNavCitas";
            this.btnNavCitas.Size = new System.Drawing.Size(175, 42);
            this.btnNavCitas.TabIndex = 6;
            this.btnNavCitas.Text = "📅   Gestionar Citas";
            this.btnNavCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavCitas.UseVisualStyleBackColor = false;
            // 
            // btnNavNotificaciones
            // 
            this.btnNavNotificaciones.BackColor = System.Drawing.Color.White;
            this.btnNavNotificaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavNotificaciones.FlatAppearance.BorderSize = 0;
            this.btnNavNotificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavNotificaciones.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavNotificaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.btnNavNotificaciones.Location = new System.Drawing.Point(12, 340);
            this.btnNavNotificaciones.Name = "btnNavNotificaciones";
            this.btnNavNotificaciones.Size = new System.Drawing.Size(175, 42);
            this.btnNavNotificaciones.TabIndex = 7;
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
            this.btnNavPerfil.Location = new System.Drawing.Point(12, 390);
            this.btnNavPerfil.Name = "btnNavPerfil";
            this.btnNavPerfil.Size = new System.Drawing.Size(175, 42);
            this.btnNavPerfil.TabIndex = 8;
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
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 674);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(198, 45);
            this.btnCerrarSesion.TabIndex = 8;
            this.btnCerrarSesion.Text = "🚪   Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.AutoScroll = true;
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
            this.pnlContenedor.Controls.Add(this.pnlHeader);
            this.pnlContenedor.Controls.Add(this.pnlBuscar);
            this.pnlContenedor.Controls.Add(this.pnlMetricas);
            this.pnlContenedor.Controls.Add(this.pnlCitas);
            this.pnlContenedor.Controls.Add(this.pnlInfoRapida);
            this.pnlContenedor.Controls.Add(this.pnlNotifRecientes);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(200, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContenedor.Size = new System.Drawing.Size(984, 721);
            this.pnlContenedor.TabIndex = 1;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblBienvenidaDoctor);
            this.pnlHeader.Controls.Add(this.lblSubtituloDoctor);
            this.pnlHeader.Controls.Add(this.picAvatarDoctor);
            this.pnlHeader.Controls.Add(this.lblNombreDoctor);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(20, 20);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(944, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblBienvenidaDoctor
            // 
            this.lblBienvenidaDoctor.AutoSize = true;
            this.lblBienvenidaDoctor.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblBienvenidaDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblBienvenidaDoctor.Location = new System.Drawing.Point(5, 5);
            this.lblBienvenidaDoctor.Name = "lblBienvenidaDoctor";
            this.lblBienvenidaDoctor.Size = new System.Drawing.Size(242, 37);
            this.lblBienvenidaDoctor.TabIndex = 0;
            this.lblBienvenidaDoctor.Text = "¡Hola, Dr. Pérez! ";
            // 
            // lblSubtituloDoctor
            // 
            this.lblSubtituloDoctor.AutoSize = true;
            this.lblSubtituloDoctor.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblSubtituloDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(85)))));
            this.lblSubtituloDoctor.Location = new System.Drawing.Point(8, 42);
            this.lblSubtituloDoctor.Name = "lblSubtituloDoctor";
            this.lblSubtituloDoctor.Size = new System.Drawing.Size(342, 19);
            this.lblSubtituloDoctor.TabIndex = 1;
            this.lblSubtituloDoctor.Text = "Consulta la información y atiende a tus pacientes ♡";
            // 
            // picAvatarDoctor
            // 
            this.picAvatarDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picAvatarDoctor.BackColor = System.Drawing.Color.White;
            this.picAvatarDoctor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatarDoctor.Location = new System.Drawing.Point(760, 8);
            this.picAvatarDoctor.Name = "picAvatarDoctor";
            this.picAvatarDoctor.Size = new System.Drawing.Size(55, 55);
            this.picAvatarDoctor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatarDoctor.TabIndex = 2;
            this.picAvatarDoctor.TabStop = false;
            // 
            // lblNombreDoctor
            // 
            this.lblNombreDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreDoctor.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombreDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(40)))));
            this.lblNombreDoctor.Location = new System.Drawing.Point(825, 25);
            this.lblNombreDoctor.Name = "lblNombreDoctor";
            this.lblNombreDoctor.Size = new System.Drawing.Size(115, 25);
            this.lblNombreDoctor.TabIndex = 3;
            this.lblNombreDoctor.Text = "Dr. Pérez";
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.BackColor = System.Drawing.Color.White;
            this.pnlBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBuscar.Controls.Add(this.lblTituloBuscar);
            this.pnlBuscar.Controls.Add(this.lblCarneDesc);
            this.pnlBuscar.Controls.Add(this.txtBuscarCarne);
            this.pnlBuscar.Controls.Add(this.lblO);
            this.pnlBuscar.Controls.Add(this.lblCedulaDesc);
            this.pnlBuscar.Controls.Add(this.txtBuscarCedula);
            this.pnlBuscar.Controls.Add(this.btnBuscar);
            this.pnlBuscar.Location = new System.Drawing.Point(20, 100);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(935, 75);
            this.pnlBuscar.TabIndex = 1;
            // 
            // lblTituloBuscar
            // 
            this.lblTituloBuscar.AutoSize = true;
            this.lblTituloBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTituloBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblTituloBuscar.Location = new System.Drawing.Point(15, 10);
            this.lblTituloBuscar.Name = "lblTituloBuscar";
            this.lblTituloBuscar.Size = new System.Drawing.Size(126, 19);
            this.lblTituloBuscar.TabIndex = 0;
            this.lblTituloBuscar.Text = "🐾  Buscar Mascota";
            // 
            // lblCarneDesc
            // 
            this.lblCarneDesc.AutoSize = true;
            this.lblCarneDesc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCarneDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(110)))), ((int)(((byte)(100)))));
            this.lblCarneDesc.Location = new System.Drawing.Point(15, 30);
            this.lblCarneDesc.Name = "lblCarneDesc";
            this.lblCarneDesc.Size = new System.Drawing.Size(117, 13);
            this.lblCarneDesc.TabIndex = 1;
            this.lblCarneDesc.Text = "ID del Carné Digital:";
            // 
            // txtBuscarCarne
            // 
            this.txtBuscarCarne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.txtBuscarCarne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarCarne.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscarCarne.Location = new System.Drawing.Point(15, 45);
            this.txtBuscarCarne.Name = "txtBuscarCarne";
            this.txtBuscarCarne.Size = new System.Drawing.Size(260, 25);
            this.txtBuscarCarne.TabIndex = 2;
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(110)))));
            this.lblO.Location = new System.Drawing.Point(290, 48);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(17, 19);
            this.lblO.TabIndex = 3;
            this.lblO.Text = "o";
            // 
            // lblCedulaDesc
            // 
            this.lblCedulaDesc.AutoSize = true;
            this.lblCedulaDesc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCedulaDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(110)))), ((int)(((byte)(100)))));
            this.lblCedulaDesc.Location = new System.Drawing.Point(325, 30);
            this.lblCedulaDesc.Name = "lblCedulaDesc";
            this.lblCedulaDesc.Size = new System.Drawing.Size(89, 13);
            this.lblCedulaDesc.TabIndex = 4;
            this.lblCedulaDesc.Text = "C.C. del Dueño:";
            // 
            // txtBuscarCedula
            // 
            this.txtBuscarCedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.txtBuscarCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarCedula.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscarCedula.Location = new System.Drawing.Point(325, 45);
            this.txtBuscarCedula.Name = "txtBuscarCedula";
            this.txtBuscarCedula.Size = new System.Drawing.Size(260, 25);
            this.txtBuscarCedula.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(620, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(180, 32);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "🔍   Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // pnlMetricas
            // 
            this.pnlMetricas.Controls.Add(this.cardMetricaAtendidas);
            this.pnlMetricas.Controls.Add(this.cardMetricaCitasHoy);
            this.pnlMetricas.Controls.Add(this.cardMetricaHistorias);
            this.pnlMetricas.Controls.Add(this.cardMetricaNotif);
            this.pnlMetricas.Location = new System.Drawing.Point(20, 185);
            this.pnlMetricas.Name = "pnlMetricas";
            this.pnlMetricas.Size = new System.Drawing.Size(935, 90);
            this.pnlMetricas.TabIndex = 2;
            // 
            // cardMetricaAtendidas
            // 
            this.cardMetricaAtendidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.cardMetricaAtendidas.Controls.Add(this.lblNumAtendidas);
            this.cardMetricaAtendidas.Controls.Add(this.lblTextoAtendidas);
            this.cardMetricaAtendidas.Location = new System.Drawing.Point(0, 5);
            this.cardMetricaAtendidas.Name = "cardMetricaAtendidas";
            this.cardMetricaAtendidas.Size = new System.Drawing.Size(215, 80);
            this.cardMetricaAtendidas.TabIndex = 0;
            // 
            // lblNumAtendidas
            // 
            this.lblNumAtendidas.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblNumAtendidas.ForeColor = System.Drawing.Color.White;
            this.lblNumAtendidas.Location = new System.Drawing.Point(15, 8);
            this.lblNumAtendidas.Name = "lblNumAtendidas";
            this.lblNumAtendidas.Size = new System.Drawing.Size(80, 40);
            this.lblNumAtendidas.TabIndex = 0;
            this.lblNumAtendidas.Text = "12";
            // 
            // lblTextoAtendidas
            // 
            this.lblTextoAtendidas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTextoAtendidas.ForeColor = System.Drawing.Color.White;
            this.lblTextoAtendidas.Location = new System.Drawing.Point(15, 48);
            this.lblTextoAtendidas.Name = "lblTextoAtendidas";
            this.lblTextoAtendidas.Size = new System.Drawing.Size(180, 22);
            this.lblTextoAtendidas.TabIndex = 1;
            this.lblTextoAtendidas.Text = "🐾 Mascotas Atendidas";
            // 
            // cardMetricaCitasHoy
            // 
            this.cardMetricaCitasHoy.BackColor = System.Drawing.Color.White;
            this.cardMetricaCitasHoy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardMetricaCitasHoy.Controls.Add(this.lblNumCitasHoy);
            this.cardMetricaCitasHoy.Controls.Add(this.lblTextoCitasHoy);
            this.cardMetricaCitasHoy.Location = new System.Drawing.Point(235, 5);
            this.cardMetricaCitasHoy.Name = "cardMetricaCitasHoy";
            this.cardMetricaCitasHoy.Size = new System.Drawing.Size(215, 80);
            this.cardMetricaCitasHoy.TabIndex = 1;
            // 
            // lblNumCitasHoy
            // 
            this.lblNumCitasHoy.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblNumCitasHoy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblNumCitasHoy.Location = new System.Drawing.Point(15, 8);
            this.lblNumCitasHoy.Name = "lblNumCitasHoy";
            this.lblNumCitasHoy.Size = new System.Drawing.Size(80, 40);
            this.lblNumCitasHoy.TabIndex = 0;
            this.lblNumCitasHoy.Text = "5";
            // 
            // lblTextoCitasHoy
            // 
            this.lblTextoCitasHoy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTextoCitasHoy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(75)))));
            this.lblTextoCitasHoy.Location = new System.Drawing.Point(15, 48);
            this.lblTextoCitasHoy.Name = "lblTextoCitasHoy";
            this.lblTextoCitasHoy.Size = new System.Drawing.Size(180, 22);
            this.lblTextoCitasHoy.TabIndex = 1;
            this.lblTextoCitasHoy.Text = "📅 Citas Hoy";
            // 
            // cardMetricaHistorias
            // 
            this.cardMetricaHistorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.cardMetricaHistorias.Controls.Add(this.lblNumHistorias);
            this.cardMetricaHistorias.Controls.Add(this.lblTextoHistorias);
            this.cardMetricaHistorias.Location = new System.Drawing.Point(470, 5);
            this.cardMetricaHistorias.Name = "cardMetricaHistorias";
            this.cardMetricaHistorias.Size = new System.Drawing.Size(215, 80);
            this.cardMetricaHistorias.TabIndex = 2;
            // 
            // lblNumHistorias
            // 
            this.lblNumHistorias.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblNumHistorias.ForeColor = System.Drawing.Color.White;
            this.lblNumHistorias.Location = new System.Drawing.Point(15, 8);
            this.lblNumHistorias.Name = "lblNumHistorias";
            this.lblNumHistorias.Size = new System.Drawing.Size(80, 40);
            this.lblNumHistorias.TabIndex = 0;
            this.lblNumHistorias.Text = "8";
            // 
            // lblTextoHistorias
            // 
            this.lblTextoHistorias.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTextoHistorias.ForeColor = System.Drawing.Color.White;
            this.lblTextoHistorias.Location = new System.Drawing.Point(15, 48);
            this.lblTextoHistorias.Name = "lblTextoHistorias";
            this.lblTextoHistorias.Size = new System.Drawing.Size(180, 22);
            this.lblTextoHistorias.TabIndex = 1;
            this.lblTextoHistorias.Text = "📄 Historias Médicas";
            // 
            // cardMetricaNotif
            // 
            this.cardMetricaNotif.BackColor = System.Drawing.Color.White;
            this.cardMetricaNotif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardMetricaNotif.Controls.Add(this.lblNumNotif);
            this.cardMetricaNotif.Controls.Add(this.lblTextoNotif);
            this.cardMetricaNotif.Location = new System.Drawing.Point(705, 5);
            this.cardMetricaNotif.Name = "cardMetricaNotif";
            this.cardMetricaNotif.Size = new System.Drawing.Size(230, 80);
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
            this.lblTextoNotif.Size = new System.Drawing.Size(190, 22);
            this.lblTextoNotif.TabIndex = 1;
            this.lblTextoNotif.Text = "🔔 Notificación Nueva";
            // 
            // pnlCitas
            // 
            this.pnlCitas.BackColor = System.Drawing.Color.White;
            this.pnlCitas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCitas.Controls.Add(this.lblTituloCitas);
            this.pnlCitas.Controls.Add(this.dgvProximasCitas);
            this.pnlCitas.Location = new System.Drawing.Point(20, 285);
            this.pnlCitas.Name = "pnlCitas";
            this.pnlCitas.Padding = new System.Windows.Forms.Padding(10);
            this.pnlCitas.Size = new System.Drawing.Size(595, 410);
            this.pnlCitas.TabIndex = 3;
            // 
            // lblTituloCitas
            // 
            this.lblTituloCitas.AutoSize = true;
            this.lblTituloCitas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloCitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblTituloCitas.Location = new System.Drawing.Point(10, 10);
            this.lblTituloCitas.Name = "lblTituloCitas";
            this.lblTituloCitas.Size = new System.Drawing.Size(147, 21);
            this.lblTituloCitas.TabIndex = 0;
            this.lblTituloCitas.Text = "📅  Próximas Citas";
            // 
            // dgvProximasCitas
            // 
            this.dgvProximasCitas.AllowUserToAddRows = false;
            this.dgvProximasCitas.AllowUserToDeleteRows = false;
            this.dgvProximasCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProximasCitas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.dgvProximasCitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProximasCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProximasCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFecha,
            this.colHora,
            this.colMascota,
            this.colDueño,
            this.colMotivo,
            this.colAccion});
            this.dgvProximasCitas.Location = new System.Drawing.Point(10, 40);
            this.dgvProximasCitas.Name = "dgvProximasCitas";
            this.dgvProximasCitas.ReadOnly = true;
            this.dgvProximasCitas.RowHeadersVisible = false;
            this.dgvProximasCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProximasCitas.Size = new System.Drawing.Size(575, 355);
            this.dgvProximasCitas.TabIndex = 1;
            // 
            // colFecha
            // 
            this.colFecha.FillWeight = 85F;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colHora
            // 
            this.colHora.FillWeight = 80F;
            this.colHora.HeaderText = "Hora";
            this.colHora.Name = "colHora";
            this.colHora.ReadOnly = true;
            // 
            // colMascota
            // 
            this.colMascota.FillWeight = 90F;
            this.colMascota.HeaderText = "Mascota";
            this.colMascota.Name = "colMascota";
            this.colMascota.ReadOnly = true;
            // 
            // colDueño
            // 
            this.colDueño.FillWeight = 95F;
            this.colDueño.HeaderText = "Dueño";
            this.colDueño.Name = "colDueño";
            this.colDueño.ReadOnly = true;
            // 
            // colMotivo
            // 
            this.colMotivo.FillWeight = 110F;
            this.colMotivo.HeaderText = "Motivo";
            this.colMotivo.Name = "colMotivo";
            this.colMotivo.ReadOnly = true;
            // 
            // colAccion
            // 
            this.colAccion.FillWeight = 75F;
            this.colAccion.HeaderText = "Acción";
            this.colAccion.Name = "colAccion";
            this.colAccion.ReadOnly = true;
            this.colAccion.Text = "👁 Atender";
            this.colAccion.UseColumnTextForButtonValue = true;
            // 
            // pnlInfoRapida
            // 
            this.pnlInfoRapida.BackColor = System.Drawing.Color.White;
            this.pnlInfoRapida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfoRapida.Controls.Add(this.lblTituloInfoRapida);
            this.pnlInfoRapida.Controls.Add(this.picMascotaRapida);
            this.pnlInfoRapida.Controls.Add(this.lblNombreMascotaRapida);
            this.pnlInfoRapida.Controls.Add(this.lblDetalleMascotaRapida);
            this.pnlInfoRapida.Controls.Add(this.lblEstadoRapido);
            this.pnlInfoRapida.Controls.Add(this.lblUltimaConsulta);
            this.pnlInfoRapida.Controls.Add(this.btnVerHistorialRapido);
            this.pnlInfoRapida.Location = new System.Drawing.Point(630, 285);
            this.pnlInfoRapida.Name = "pnlInfoRapida";
            this.pnlInfoRapida.Size = new System.Drawing.Size(325, 230);
            this.pnlInfoRapida.TabIndex = 4;
            // 
            // lblTituloInfoRapida
            // 
            this.lblTituloInfoRapida.AutoSize = true;
            this.lblTituloInfoRapida.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloInfoRapida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblTituloInfoRapida.Location = new System.Drawing.Point(15, 12);
            this.lblTituloInfoRapida.Name = "lblTituloInfoRapida";
            this.lblTituloInfoRapida.Size = new System.Drawing.Size(183, 21);
            this.lblTituloInfoRapida.TabIndex = 0;
            this.lblTituloInfoRapida.Text = "🐾  Información Rápida";
            // 
            // picMascotaRapida
            // 
            this.picMascotaRapida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.picMascotaRapida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMascotaRapida.Location = new System.Drawing.Point(15, 45);
            this.picMascotaRapida.Name = "picMascotaRapida";
            this.picMascotaRapida.Size = new System.Drawing.Size(75, 75);
            this.picMascotaRapida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMascotaRapida.TabIndex = 1;
            this.picMascotaRapida.TabStop = false;
            // 
            // lblNombreMascotaRapida
            // 
            this.lblNombreMascotaRapida.AutoSize = true;
            this.lblNombreMascotaRapida.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblNombreMascotaRapida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblNombreMascotaRapida.Location = new System.Drawing.Point(100, 45);
            this.lblNombreMascotaRapida.Name = "lblNombreMascotaRapida";
            this.lblNombreMascotaRapida.Size = new System.Drawing.Size(55, 25);
            this.lblNombreMascotaRapida.TabIndex = 2;
            this.lblNombreMascotaRapida.Text = "Luna";
            // 
            // lblDetalleMascotaRapida
            // 
            this.lblDetalleMascotaRapida.AutoSize = true;
            this.lblDetalleMascotaRapida.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDetalleMascotaRapida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(85)))));
            this.lblDetalleMascotaRapida.Location = new System.Drawing.Point(100, 72);
            this.lblDetalleMascotaRapida.Name = "lblDetalleMascotaRapida";
            this.lblDetalleMascotaRapida.Size = new System.Drawing.Size(126, 15);
            this.lblDetalleMascotaRapida.TabIndex = 3;
            this.lblDetalleMascotaRapida.Text = "Husky Siberiano • 3 años";
            // 
            // lblEstadoRapido
            // 
            this.lblEstadoRapido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(248)))), ((int)(((byte)(230)))));
            this.lblEstadoRapido.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEstadoRapido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblEstadoRapido.Location = new System.Drawing.Point(100, 95);
            this.lblEstadoRapido.Name = "lblEstadoRapido";
            this.lblEstadoRapido.Size = new System.Drawing.Size(110, 22);
            this.lblEstadoRapido.TabIndex = 4;
            this.lblEstadoRapido.Text = "✓ Saludable";
            this.lblEstadoRapido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUltimaConsulta
            // 
            this.lblUltimaConsulta.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblUltimaConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(75)))));
            this.lblUltimaConsulta.Location = new System.Drawing.Point(15, 135);
            this.lblUltimaConsulta.Name = "lblUltimaConsulta";
            this.lblUltimaConsulta.Size = new System.Drawing.Size(295, 38);
            this.lblUltimaConsulta.TabIndex = 5;
            this.lblUltimaConsulta.Text = "📅 Última consulta: 12/11/2025\r\nMotivo: Control e infección respiratoria superad" +
    "a.";
            // 
            // btnVerHistorialRapido
            // 
            this.btnVerHistorialRapido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnVerHistorialRapido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerHistorialRapido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnVerHistorialRapido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerHistorialRapido.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnVerHistorialRapido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnVerHistorialRapido.Location = new System.Drawing.Point(15, 180);
            this.btnVerHistorialRapido.Name = "btnVerHistorialRapido";
            this.btnVerHistorialRapido.Size = new System.Drawing.Size(295, 35);
            this.btnVerHistorialRapido.TabIndex = 6;
            this.btnVerHistorialRapido.Text = "📄   Ver Historial Completo";
            this.btnVerHistorialRapido.UseVisualStyleBackColor = false;
            // 
            // pnlNotifRecientes
            // 
            this.pnlNotifRecientes.BackColor = System.Drawing.Color.White;
            this.pnlNotifRecientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNotifRecientes.Controls.Add(this.lblTituloNotif);
            this.pnlNotifRecientes.Controls.Add(this.lblTextoNotificacion);
            this.pnlNotifRecientes.Location = new System.Drawing.Point(630, 530);
            this.pnlNotifRecientes.Name = "pnlNotifRecientes";
            this.pnlNotifRecientes.Size = new System.Drawing.Size(325, 165);
            this.pnlNotifRecientes.TabIndex = 5;
            // 
            // lblTituloNotif
            // 
            this.lblTituloNotif.AutoSize = true;
            this.lblTituloNotif.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloNotif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblTituloNotif.Location = new System.Drawing.Point(15, 12);
            this.lblTituloNotif.Name = "lblTituloNotif";
            this.lblTituloNotif.Size = new System.Drawing.Size(201, 21);
            this.lblTituloNotif.TabIndex = 0;
            this.lblTituloNotif.Text = "🔔  Notificaciones Recientes";
            // 
            // lblTextoNotificacion
            // 
            this.lblTextoNotificacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTextoNotificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.lblTextoNotificacion.Location = new System.Drawing.Point(15, 45);
            this.lblTextoNotificacion.Name = "lblTextoNotificacion";
            this.lblTextoNotificacion.Size = new System.Drawing.Size(295, 100);
            this.lblTextoNotificacion.TabIndex = 1;
            this.lblTextoNotificacion.Text = "📌 Recordatorio:\r\nRevisión de carné digital pendiente para nuevos registros.\r\n• C" +
    "ontrol veterinario activo.";
            // 
            // FrmMenuDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 721);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlSidebar);
            this.MinimumSize = new System.Drawing.Size(1100, 720);
            this.Name = "FrmMenuDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Huellitas Veterinaria - Panel Médico";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatarDoctor)).EndInit();
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            this.pnlMetricas.ResumeLayout(false);
            this.cardMetricaAtendidas.ResumeLayout(false);
            this.cardMetricaCitasHoy.ResumeLayout(false);
            this.cardMetricaHistorias.ResumeLayout(false);
            this.cardMetricaNotif.ResumeLayout(false);
            this.pnlCitas.ResumeLayout(false);
            this.pnlCitas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProximasCitas)).EndInit();
            this.pnlInfoRapida.ResumeLayout(false);
            this.pnlInfoRapida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMascotaRapida)).EndInit();
            this.pnlNotifRecientes.ResumeLayout(false);
            this.pnlNotifRecientes.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblLogoSub;
        private System.Windows.Forms.Button btnNavInicio;
        private System.Windows.Forms.Button btnNavBuscar;
        private System.Windows.Forms.Button btnNavRegistrarMascota;
        private System.Windows.Forms.Button btnNavHistorial;
        private System.Windows.Forms.Button btnNavCitas;
        private System.Windows.Forms.Button btnNavNotificaciones;
        private System.Windows.Forms.Button btnNavPerfil;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblBienvenidaDoctor;
        private System.Windows.Forms.Label lblSubtituloDoctor;
        private System.Windows.Forms.PictureBox picAvatarDoctor;
        private System.Windows.Forms.Label lblNombreDoctor;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.Label lblTituloBuscar;
        private System.Windows.Forms.Label lblCarneDesc;
        private System.Windows.Forms.TextBox txtBuscarCarne;
        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Label lblCedulaDesc;
        private System.Windows.Forms.TextBox txtBuscarCedula;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel pnlMetricas;
        private System.Windows.Forms.Panel cardMetricaAtendidas;
        private System.Windows.Forms.Label lblNumAtendidas;
        private System.Windows.Forms.Label lblTextoAtendidas;
        private System.Windows.Forms.Panel cardMetricaCitasHoy;
        private System.Windows.Forms.Label lblNumCitasHoy;
        private System.Windows.Forms.Label lblTextoCitasHoy;
        private System.Windows.Forms.Panel cardMetricaHistorias;
        private System.Windows.Forms.Label lblNumHistorias;
        private System.Windows.Forms.Label lblTextoHistorias;
        private System.Windows.Forms.Panel cardMetricaNotif;
        private System.Windows.Forms.Label lblNumNotif;
        private System.Windows.Forms.Label lblTextoNotif;
        private System.Windows.Forms.Panel pnlCitas;
        private System.Windows.Forms.Label lblTituloCitas;
        private System.Windows.Forms.DataGridView dgvProximasCitas;
        private System.Windows.Forms.Panel pnlInfoRapida;
        private System.Windows.Forms.Label lblTituloInfoRapida;
        private System.Windows.Forms.PictureBox picMascotaRapida;
        private System.Windows.Forms.Label lblNombreMascotaRapida;
        private System.Windows.Forms.Label lblDetalleMascotaRapida;
        private System.Windows.Forms.Label lblEstadoRapido;
        private System.Windows.Forms.Label lblUltimaConsulta;
        private System.Windows.Forms.Button btnVerHistorialRapido;
        private System.Windows.Forms.Panel pnlNotifRecientes;
        private System.Windows.Forms.Label lblTituloNotif;
        private System.Windows.Forms.Label lblTextoNotificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueño;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMotivo;
        private System.Windows.Forms.DataGridViewButtonColumn colAccion;
    }
}
