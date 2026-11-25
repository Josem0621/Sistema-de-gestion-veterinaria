namespace Sistema_de_gestion_veterinaria
{
    partial class FrmMenuAdmin
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
            this.lblBadgeAdmin = new System.Windows.Forms.Label();
            this.btnNavUsuarios = new System.Windows.Forms.Button();
            this.btnNavRegistrarUsuario = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTituloAdmin = new System.Windows.Forms.Label();
            this.lblSubtituloAdmin = new System.Windows.Forms.Label();
            this.lblPerfilAdmin = new System.Windows.Forms.Label();
            this.pnlMetricas = new System.Windows.Forms.Panel();
            this.cardTotalUsuarios = new System.Windows.Forms.Panel();
            this.lblNumTotalUsuarios = new System.Windows.Forms.Label();
            this.lblTxtTotalUsuarios = new System.Windows.Forms.Label();
            this.cardTotalDuenos = new System.Windows.Forms.Panel();
            this.lblNumTotalDuenos = new System.Windows.Forms.Label();
            this.lblTxtTotalDuenos = new System.Windows.Forms.Label();
            this.cardTotalVets = new System.Windows.Forms.Panel();
            this.lblNumTotalVets = new System.Windows.Forms.Label();
            this.lblTxtTotalVets = new System.Windows.Forms.Label();
            this.cardTotalMascotas = new System.Windows.Forms.Panel();
            this.lblNumTotalMascotas = new System.Windows.Forms.Label();
            this.lblTxtTotalMascotas = new System.Windows.Forms.Label();
            this.pnlListaUsuarios = new System.Windows.Forms.Panel();
            this.lblTitLista = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblFiltroRol = new System.Windows.Forms.Label();
            this.cmbFiltroRol = new System.Windows.Forms.ComboBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.pnlAccionesUsuario = new System.Windows.Forms.Panel();
            this.lblTitAcciones = new System.Windows.Forms.Label();
            this.lblInfoNombre = new System.Windows.Forms.Label();
            this.lblInfoUsuario = new System.Windows.Forms.Label();
            this.lblInfoRol = new System.Windows.Forms.Label();
            this.lblInfoDoc = new System.Windows.Forms.Label();
            this.lblInfoCorreo = new System.Windows.Forms.Label();
            this.lblInfoTel = new System.Windows.Forms.Label();
            this.lblInfoExtra = new System.Windows.Forms.Label();
            this.pnlCambiarClave = new System.Windows.Forms.Panel();
            this.lblTitCambiarClave = new System.Windows.Forms.Label();
            this.lblNuevaClaveDesc = new System.Windows.Forms.Label();
            this.txtNuevaContrasena = new System.Windows.Forms.TextBox();
            this.btnActualizarContrasena = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlMetricas.SuspendLayout();
            this.cardTotalUsuarios.SuspendLayout();
            this.cardTotalDuenos.SuspendLayout();
            this.cardTotalVets.SuspendLayout();
            this.cardTotalMascotas.SuspendLayout();
            this.pnlListaUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.pnlAccionesUsuario.SuspendLayout();
            this.pnlCambiarClave.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Controls.Add(this.lblLogoSub);
            this.pnlSidebar.Controls.Add(this.lblBadgeAdmin);
            this.pnlSidebar.Controls.Add(this.btnNavUsuarios);
            this.pnlSidebar.Controls.Add(this.btnNavRegistrarUsuario);
            this.pnlSidebar.Controls.Add(this.btnCerrarSesion);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(210, 721);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblLogo.Location = new System.Drawing.Point(5, 15);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(195, 35);
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
            this.lblLogoSub.Size = new System.Drawing.Size(195, 18);
            this.lblLogoSub.TabIndex = 1;
            this.lblLogoSub.Text = "V E T E R I N A R I A";
            this.lblLogoSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBadgeAdmin
            // 
            this.lblBadgeAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(244)))), ((int)(((byte)(230)))));
            this.lblBadgeAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblBadgeAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblBadgeAdmin.Location = new System.Drawing.Point(15, 78);
            this.lblBadgeAdmin.Name = "lblBadgeAdmin";
            this.lblBadgeAdmin.Size = new System.Drawing.Size(175, 25);
            this.lblBadgeAdmin.TabIndex = 2;
            this.lblBadgeAdmin.Text = "🛡 MÓDULO ADMIN";
            this.lblBadgeAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNavUsuarios
            // 
            this.btnNavUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(244)))), ((int)(((byte)(227)))));
            this.btnNavUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavUsuarios.FlatAppearance.BorderSize = 0;
            this.btnNavUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavUsuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnNavUsuarios.Location = new System.Drawing.Point(15, 125);
            this.btnNavUsuarios.Name = "btnNavUsuarios";
            this.btnNavUsuarios.Size = new System.Drawing.Size(175, 42);
            this.btnNavUsuarios.TabIndex = 3;
            this.btnNavUsuarios.Text = "👥   Gestión Usuarios";
            this.btnNavUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnNavRegistrarUsuario
            // 
            this.btnNavRegistrarUsuario.BackColor = System.Drawing.Color.White;
            this.btnNavRegistrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavRegistrarUsuario.FlatAppearance.BorderSize = 0;
            this.btnNavRegistrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavRegistrarUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavRegistrarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnNavRegistrarUsuario.Location = new System.Drawing.Point(15, 175);
            this.btnNavRegistrarUsuario.Name = "btnNavRegistrarUsuario";
            this.btnNavRegistrarUsuario.Size = new System.Drawing.Size(175, 42);
            this.btnNavRegistrarUsuario.TabIndex = 4;
            this.btnNavRegistrarUsuario.Text = "➕   Registrar Usuario";
            this.btnNavRegistrarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavRegistrarUsuario.UseVisualStyleBackColor = false;
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
            this.btnCerrarSesion.Size = new System.Drawing.Size(208, 45);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "🚪   Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.AutoScroll = true;
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
            this.pnlContenedor.Controls.Add(this.pnlHeader);
            this.pnlContenedor.Controls.Add(this.pnlMetricas);
            this.pnlContenedor.Controls.Add(this.pnlListaUsuarios);
            this.pnlContenedor.Controls.Add(this.pnlAccionesUsuario);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(210, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContenedor.Size = new System.Drawing.Size(1074, 721);
            this.pnlContenedor.TabIndex = 1;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTituloAdmin);
            this.pnlHeader.Controls.Add(this.lblSubtituloAdmin);
            this.pnlHeader.Controls.Add(this.lblPerfilAdmin);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(20, 20);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1034, 65);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTituloAdmin
            // 
            this.lblTituloAdmin.AutoSize = true;
            this.lblTituloAdmin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTituloAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblTituloAdmin.Location = new System.Drawing.Point(5, 5);
            this.lblTituloAdmin.Name = "lblTituloAdmin";
            this.lblTituloAdmin.Size = new System.Drawing.Size(325, 32);
            this.lblTituloAdmin.TabIndex = 0;
            this.lblTituloAdmin.Text = "¡Panel de Administración!";
            // 
            // lblSubtituloAdmin
            // 
            this.lblSubtituloAdmin.AutoSize = true;
            this.lblSubtituloAdmin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtituloAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(85)))));
            this.lblSubtituloAdmin.Location = new System.Drawing.Point(8, 38);
            this.lblSubtituloAdmin.Name = "lblSubtituloAdmin";
            this.lblSubtituloAdmin.Size = new System.Drawing.Size(439, 17);
            this.lblSubtituloAdmin.TabIndex = 1;
            this.lblSubtituloAdmin.Text = "Consulta información de usuarios, actualiza contraseñas y gestiona accesos ♡";
            // 
            // lblPerfilAdmin
            // 
            this.lblPerfilAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPerfilAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPerfilAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(40)))));
            this.lblPerfilAdmin.Location = new System.Drawing.Point(820, 20);
            this.lblPerfilAdmin.Name = "lblPerfilAdmin";
            this.lblPerfilAdmin.Size = new System.Drawing.Size(200, 25);
            this.lblPerfilAdmin.TabIndex = 2;
            this.lblPerfilAdmin.Text = "👤 Admin: admin";
            this.lblPerfilAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlMetricas
            // 
            this.pnlMetricas.Controls.Add(this.cardTotalUsuarios);
            this.pnlMetricas.Controls.Add(this.cardTotalDuenos);
            this.pnlMetricas.Controls.Add(this.cardTotalVets);
            this.pnlMetricas.Controls.Add(this.cardTotalMascotas);
            this.pnlMetricas.Location = new System.Drawing.Point(20, 95);
            this.pnlMetricas.Name = "pnlMetricas";
            this.pnlMetricas.Size = new System.Drawing.Size(1030, 85);
            this.pnlMetricas.TabIndex = 1;
            // 
            // cardTotalUsuarios
            // 
            this.cardTotalUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.cardTotalUsuarios.Controls.Add(this.lblNumTotalUsuarios);
            this.cardTotalUsuarios.Controls.Add(this.lblTxtTotalUsuarios);
            this.cardTotalUsuarios.Location = new System.Drawing.Point(0, 5);
            this.cardTotalUsuarios.Name = "cardTotalUsuarios";
            this.cardTotalUsuarios.Size = new System.Drawing.Size(235, 75);
            this.cardTotalUsuarios.TabIndex = 0;
            // 
            // lblNumTotalUsuarios
            // 
            this.lblNumTotalUsuarios.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblNumTotalUsuarios.ForeColor = System.Drawing.Color.White;
            this.lblNumTotalUsuarios.Location = new System.Drawing.Point(15, 6);
            this.lblNumTotalUsuarios.Name = "lblNumTotalUsuarios";
            this.lblNumTotalUsuarios.Size = new System.Drawing.Size(80, 35);
            this.lblNumTotalUsuarios.TabIndex = 0;
            this.lblNumTotalUsuarios.Text = "0";
            // 
            // lblTxtTotalUsuarios
            // 
            this.lblTxtTotalUsuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTxtTotalUsuarios.ForeColor = System.Drawing.Color.White;
            this.lblTxtTotalUsuarios.Location = new System.Drawing.Point(15, 45);
            this.lblTxtTotalUsuarios.Name = "lblTxtTotalUsuarios";
            this.lblTxtTotalUsuarios.Size = new System.Drawing.Size(200, 20);
            this.lblTxtTotalUsuarios.TabIndex = 1;
            this.lblTxtTotalUsuarios.Text = "👥 Total Usuarios Activos";
            // 
            // cardTotalDuenos
            // 
            this.cardTotalDuenos.BackColor = System.Drawing.Color.White;
            this.cardTotalDuenos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTotalDuenos.Controls.Add(this.lblNumTotalDuenos);
            this.cardTotalDuenos.Controls.Add(this.lblTxtTotalDuenos);
            this.cardTotalDuenos.Location = new System.Drawing.Point(265, 5);
            this.cardTotalDuenos.Name = "cardTotalDuenos";
            this.cardTotalDuenos.Size = new System.Drawing.Size(235, 75);
            this.cardTotalDuenos.TabIndex = 1;
            // 
            // lblNumTotalDuenos
            // 
            this.lblNumTotalDuenos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblNumTotalDuenos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblNumTotalDuenos.Location = new System.Drawing.Point(15, 6);
            this.lblNumTotalDuenos.Name = "lblNumTotalDuenos";
            this.lblNumTotalDuenos.Size = new System.Drawing.Size(80, 35);
            this.lblNumTotalDuenos.TabIndex = 0;
            this.lblNumTotalDuenos.Text = "0";
            // 
            // lblTxtTotalDuenos
            // 
            this.lblTxtTotalDuenos.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTxtTotalDuenos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(75)))));
            this.lblTxtTotalDuenos.Location = new System.Drawing.Point(15, 45);
            this.lblTxtTotalDuenos.Name = "lblTxtTotalDuenos";
            this.lblTxtTotalDuenos.Size = new System.Drawing.Size(200, 20);
            this.lblTxtTotalDuenos.TabIndex = 1;
            this.lblTxtTotalDuenos.Text = "🐾 Dueños Registrados";
            // 
            // cardTotalVets
            // 
            this.cardTotalVets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.cardTotalVets.Controls.Add(this.lblNumTotalVets);
            this.cardTotalVets.Controls.Add(this.lblTxtTotalVets);
            this.cardTotalVets.Location = new System.Drawing.Point(530, 5);
            this.cardTotalVets.Name = "cardTotalVets";
            this.cardTotalVets.Size = new System.Drawing.Size(235, 75);
            this.cardTotalVets.TabIndex = 2;
            // 
            // lblNumTotalVets
            // 
            this.lblNumTotalVets.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblNumTotalVets.ForeColor = System.Drawing.Color.White;
            this.lblNumTotalVets.Location = new System.Drawing.Point(15, 6);
            this.lblNumTotalVets.Name = "lblNumTotalVets";
            this.lblNumTotalVets.Size = new System.Drawing.Size(80, 35);
            this.lblNumTotalVets.TabIndex = 0;
            this.lblNumTotalVets.Text = "0";
            // 
            // lblTxtTotalVets
            // 
            this.lblTxtTotalVets.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTxtTotalVets.ForeColor = System.Drawing.Color.White;
            this.lblTxtTotalVets.Location = new System.Drawing.Point(15, 45);
            this.lblTxtTotalVets.Name = "lblTxtTotalVets";
            this.lblTxtTotalVets.Size = new System.Drawing.Size(200, 20);
            this.lblTxtTotalVets.TabIndex = 1;
            this.lblTxtTotalVets.Text = "🩺 Veterinarios Activos";
            // 
            // cardTotalMascotas
            // 
            this.cardTotalMascotas.BackColor = System.Drawing.Color.White;
            this.cardTotalMascotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTotalMascotas.Controls.Add(this.lblNumTotalMascotas);
            this.cardTotalMascotas.Controls.Add(this.lblTxtTotalMascotas);
            this.cardTotalMascotas.Location = new System.Drawing.Point(795, 5);
            this.cardTotalMascotas.Name = "cardTotalMascotas";
            this.cardTotalMascotas.Size = new System.Drawing.Size(235, 75);
            this.cardTotalMascotas.TabIndex = 3;
            // 
            // lblNumTotalMascotas
            // 
            this.lblNumTotalMascotas.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblNumTotalMascotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblNumTotalMascotas.Location = new System.Drawing.Point(15, 6);
            this.lblNumTotalMascotas.Name = "lblNumTotalMascotas";
            this.lblNumTotalMascotas.Size = new System.Drawing.Size(80, 35);
            this.lblNumTotalMascotas.TabIndex = 0;
            this.lblNumTotalMascotas.Text = "0";
            // 
            // lblTxtTotalMascotas
            // 
            this.lblTxtTotalMascotas.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTxtTotalMascotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(75)))));
            this.lblTxtTotalMascotas.Location = new System.Drawing.Point(15, 45);
            this.lblTxtTotalMascotas.Name = "lblTxtTotalMascotas";
            this.lblTxtTotalMascotas.Size = new System.Drawing.Size(200, 20);
            this.lblTxtTotalMascotas.TabIndex = 1;
            this.lblTxtTotalMascotas.Text = "🐶 Mascotas en Sistema";
            // 
            // pnlListaUsuarios
            // 
            this.pnlListaUsuarios.BackColor = System.Drawing.Color.White;
            this.pnlListaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListaUsuarios.Controls.Add(this.lblTitLista);
            this.pnlListaUsuarios.Controls.Add(this.txtBuscar);
            this.pnlListaUsuarios.Controls.Add(this.lblFiltroRol);
            this.pnlListaUsuarios.Controls.Add(this.cmbFiltroRol);
            this.pnlListaUsuarios.Controls.Add(this.dgvUsuarios);
            this.pnlListaUsuarios.Location = new System.Drawing.Point(20, 195);
            this.pnlListaUsuarios.Name = "pnlListaUsuarios";
            this.pnlListaUsuarios.Padding = new System.Windows.Forms.Padding(12);
            this.pnlListaUsuarios.Size = new System.Drawing.Size(680, 500);
            this.pnlListaUsuarios.TabIndex = 2;
            // 
            // lblTitLista
            // 
            this.lblTitLista.AutoSize = true;
            this.lblTitLista.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblTitLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblTitLista.Location = new System.Drawing.Point(10, 10);
            this.lblTitLista.Name = "lblTitLista";
            this.lblTitLista.Size = new System.Drawing.Size(155, 21);
            this.lblTitLista.TabIndex = 0;
            this.lblTitLista.Text = "👥  Lista de Usuarios";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtBuscar.Location = new System.Drawing.Point(10, 38);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(380, 24);
            this.txtBuscar.TabIndex = 1;
            // 
            // lblFiltroRol
            // 
            this.lblFiltroRol.AutoSize = true;
            this.lblFiltroRol.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFiltroRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(70)))));
            this.lblFiltroRol.Location = new System.Drawing.Point(410, 42);
            this.lblFiltroRol.Name = "lblFiltroRol";
            this.lblFiltroRol.Size = new System.Drawing.Size(27, 15);
            this.lblFiltroRol.TabIndex = 2;
            this.lblFiltroRol.Text = "Rol:";
            // 
            // cmbFiltroRol
            // 
            this.cmbFiltroRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroRol.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFiltroRol.FormattingEnabled = true;
            this.cmbFiltroRol.Items.AddRange(new object[] {
            "Todos los roles",
            "Dueño",
            "Veterinario"});
            this.cmbFiltroRol.Location = new System.Drawing.Point(445, 38);
            this.cmbFiltroRol.Name = "cmbFiltroRol";
            this.cmbFiltroRol.Size = new System.Drawing.Size(220, 23);
            this.cmbFiltroRol.TabIndex = 3;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(10, 72);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(655, 410);
            this.dgvUsuarios.TabIndex = 4;
            // 
            // pnlAccionesUsuario
            // 
            this.pnlAccionesUsuario.BackColor = System.Drawing.Color.White;
            this.pnlAccionesUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAccionesUsuario.Controls.Add(this.lblTitAcciones);
            this.pnlAccionesUsuario.Controls.Add(this.lblInfoNombre);
            this.pnlAccionesUsuario.Controls.Add(this.lblInfoUsuario);
            this.pnlAccionesUsuario.Controls.Add(this.lblInfoRol);
            this.pnlAccionesUsuario.Controls.Add(this.lblInfoDoc);
            this.pnlAccionesUsuario.Controls.Add(this.lblInfoCorreo);
            this.pnlAccionesUsuario.Controls.Add(this.lblInfoTel);
            this.pnlAccionesUsuario.Controls.Add(this.lblInfoExtra);
            this.pnlAccionesUsuario.Controls.Add(this.pnlCambiarClave);
            this.pnlAccionesUsuario.Controls.Add(this.btnEliminarUsuario);
            this.pnlAccionesUsuario.Location = new System.Drawing.Point(715, 195);
            this.pnlAccionesUsuario.Name = "pnlAccionesUsuario";
            this.pnlAccionesUsuario.Padding = new System.Windows.Forms.Padding(12);
            this.pnlAccionesUsuario.Size = new System.Drawing.Size(335, 500);
            this.pnlAccionesUsuario.TabIndex = 3;
            // 
            // lblTitAcciones
            // 
            this.lblTitAcciones.AutoSize = true;
            this.lblTitAcciones.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblTitAcciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblTitAcciones.Location = new System.Drawing.Point(12, 10);
            this.lblTitAcciones.Name = "lblTitAcciones";
            this.lblTitAcciones.Size = new System.Drawing.Size(185, 21);
            this.lblTitAcciones.TabIndex = 0;
            this.lblTitAcciones.Text = "👤  Información Usuario";
            // 
            // lblInfoNombre
            // 
            this.lblInfoNombre.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblInfoNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(35)))));
            this.lblInfoNombre.Location = new System.Drawing.Point(12, 38);
            this.lblInfoNombre.Name = "lblInfoNombre";
            this.lblInfoNombre.Size = new System.Drawing.Size(310, 20);
            this.lblInfoNombre.TabIndex = 1;
            this.lblInfoNombre.Text = "Nombre: Selecciona un usuario";
            // 
            // lblInfoUsuario
            // 
            this.lblInfoUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.lblInfoUsuario.Location = new System.Drawing.Point(12, 62);
            this.lblInfoUsuario.Name = "lblInfoUsuario";
            this.lblInfoUsuario.Size = new System.Drawing.Size(310, 18);
            this.lblInfoUsuario.TabIndex = 2;
            this.lblInfoUsuario.Text = "Usuario: -";
            // 
            // lblInfoRol
            // 
            this.lblInfoRol.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfoRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.lblInfoRol.Location = new System.Drawing.Point(12, 82);
            this.lblInfoRol.Name = "lblInfoRol";
            this.lblInfoRol.Size = new System.Drawing.Size(310, 18);
            this.lblInfoRol.TabIndex = 3;
            this.lblInfoRol.Text = "Rol: -";
            // 
            // lblInfoDoc
            // 
            this.lblInfoDoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfoDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.lblInfoDoc.Location = new System.Drawing.Point(12, 102);
            this.lblInfoDoc.Name = "lblInfoDoc";
            this.lblInfoDoc.Size = new System.Drawing.Size(310, 18);
            this.lblInfoDoc.TabIndex = 4;
            this.lblInfoDoc.Text = "Documento: -";
            // 
            // lblInfoCorreo
            // 
            this.lblInfoCorreo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfoCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.lblInfoCorreo.Location = new System.Drawing.Point(12, 122);
            this.lblInfoCorreo.Name = "lblInfoCorreo";
            this.lblInfoCorreo.Size = new System.Drawing.Size(310, 18);
            this.lblInfoCorreo.TabIndex = 5;
            this.lblInfoCorreo.Text = "Correo: -";
            // 
            // lblInfoTel
            // 
            this.lblInfoTel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfoTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.lblInfoTel.Location = new System.Drawing.Point(12, 142);
            this.lblInfoTel.Name = "lblInfoTel";
            this.lblInfoTel.Size = new System.Drawing.Size(310, 18);
            this.lblInfoTel.TabIndex = 6;
            this.lblInfoTel.Text = "Teléfono: -";
            // 
            // lblInfoExtra
            // 
            this.lblInfoExtra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfoExtra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.lblInfoExtra.Location = new System.Drawing.Point(12, 162);
            this.lblInfoExtra.Name = "lblInfoExtra";
            this.lblInfoExtra.Size = new System.Drawing.Size(310, 40);
            this.lblInfoExtra.TabIndex = 7;
            this.lblInfoExtra.Text = "Detalle: -";
            // 
            // pnlCambiarClave
            // 
            this.pnlCambiarClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
            this.pnlCambiarClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCambiarClave.Controls.Add(this.lblTitCambiarClave);
            this.pnlCambiarClave.Controls.Add(this.lblNuevaClaveDesc);
            this.pnlCambiarClave.Controls.Add(this.txtNuevaContrasena);
            this.pnlCambiarClave.Controls.Add(this.btnActualizarContrasena);
            this.pnlCambiarClave.Location = new System.Drawing.Point(12, 215);
            this.pnlCambiarClave.Name = "pnlCambiarClave";
            this.pnlCambiarClave.Size = new System.Drawing.Size(310, 185);
            this.pnlCambiarClave.TabIndex = 8;
            // 
            // lblTitCambiarClave
            // 
            this.lblTitCambiarClave.AutoSize = true;
            this.lblTitCambiarClave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitCambiarClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblTitCambiarClave.Location = new System.Drawing.Point(10, 10);
            this.lblTitCambiarClave.Name = "lblTitCambiarClave";
            this.lblTitCambiarClave.Size = new System.Drawing.Size(164, 19);
            this.lblTitCambiarClave.TabIndex = 0;
            this.lblTitCambiarClave.Text = "🔑  Modificar Contraseña";
            // 
            // lblNuevaClaveDesc
            // 
            this.lblNuevaClaveDesc.AutoSize = true;
            this.lblNuevaClaveDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNuevaClaveDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(75)))));
            this.lblNuevaClaveDesc.Location = new System.Drawing.Point(10, 38);
            this.lblNuevaClaveDesc.Name = "lblNuevaClaveDesc";
            this.lblNuevaClaveDesc.Size = new System.Drawing.Size(107, 15);
            this.lblNuevaClaveDesc.TabIndex = 1;
            this.lblNuevaClaveDesc.Text = "Nueva Contraseña:";
            // 
            // txtNuevaContrasena
            // 
            this.txtNuevaContrasena.BackColor = System.Drawing.Color.White;
            this.txtNuevaContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNuevaContrasena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNuevaContrasena.Location = new System.Drawing.Point(10, 58);
            this.txtNuevaContrasena.Name = "txtNuevaContrasena";
            this.txtNuevaContrasena.Size = new System.Drawing.Size(285, 25);
            this.txtNuevaContrasena.TabIndex = 2;
            // 
            // btnActualizarContrasena
            // 
            this.btnActualizarContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnActualizarContrasena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarContrasena.FlatAppearance.BorderSize = 0;
            this.btnActualizarContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarContrasena.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnActualizarContrasena.ForeColor = System.Drawing.Color.White;
            this.btnActualizarContrasena.Location = new System.Drawing.Point(10, 105);
            this.btnActualizarContrasena.Name = "btnActualizarContrasena";
            this.btnActualizarContrasena.Size = new System.Drawing.Size(285, 42);
            this.btnActualizarContrasena.TabIndex = 3;
            this.btnActualizarContrasena.Text = "💾   Guardar Nueva Contraseña";
            this.btnActualizarContrasena.UseVisualStyleBackColor = false;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEliminarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(12, 425);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(310, 45);
            this.btnEliminarUsuario.TabIndex = 9;
            this.btnEliminarUsuario.Text = "🗑   Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            // 
            // FrmMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 721);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlSidebar);
            this.MinimumSize = new System.Drawing.Size(1150, 720);
            this.Name = "FrmMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Huellitas Veterinaria - Panel de Administración";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMetricas.ResumeLayout(false);
            this.cardTotalUsuarios.ResumeLayout(false);
            this.cardTotalDuenos.ResumeLayout(false);
            this.cardTotalVets.ResumeLayout(false);
            this.cardTotalMascotas.ResumeLayout(false);
            this.pnlListaUsuarios.ResumeLayout(false);
            this.pnlListaUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.pnlAccionesUsuario.ResumeLayout(false);
            this.pnlAccionesUsuario.PerformLayout();
            this.pnlCambiarClave.ResumeLayout(false);
            this.pnlCambiarClave.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblLogoSub;
        private System.Windows.Forms.Label lblBadgeAdmin;
        private System.Windows.Forms.Button btnNavUsuarios;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTituloAdmin;
        private System.Windows.Forms.Label lblSubtituloAdmin;
        private System.Windows.Forms.Label lblPerfilAdmin;
        private System.Windows.Forms.Panel pnlMetricas;
        private System.Windows.Forms.Panel cardTotalUsuarios;
        private System.Windows.Forms.Label lblNumTotalUsuarios;
        private System.Windows.Forms.Label lblTxtTotalUsuarios;
        private System.Windows.Forms.Panel cardTotalDuenos;
        private System.Windows.Forms.Label lblNumTotalDuenos;
        private System.Windows.Forms.Label lblTxtTotalDuenos;
        private System.Windows.Forms.Panel cardTotalVets;
        private System.Windows.Forms.Label lblNumTotalVets;
        private System.Windows.Forms.Label lblTxtTotalVets;
        private System.Windows.Forms.Panel cardTotalMascotas;
        private System.Windows.Forms.Label lblNumTotalMascotas;
        private System.Windows.Forms.Label lblTxtTotalMascotas;
        private System.Windows.Forms.Panel pnlListaUsuarios;
        private System.Windows.Forms.Label lblTitLista;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblFiltroRol;
        private System.Windows.Forms.ComboBox cmbFiltroRol;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Panel pnlAccionesUsuario;
        private System.Windows.Forms.Label lblTitAcciones;
        private System.Windows.Forms.Label lblInfoNombre;
        private System.Windows.Forms.Label lblInfoUsuario;
        private System.Windows.Forms.Label lblInfoRol;
        private System.Windows.Forms.Label lblInfoDoc;
        private System.Windows.Forms.Label lblInfoCorreo;
        private System.Windows.Forms.Label lblInfoTel;
        private System.Windows.Forms.Label lblInfoExtra;
        private System.Windows.Forms.Panel pnlCambiarClave;
        private System.Windows.Forms.Label lblTitCambiarClave;
        private System.Windows.Forms.Label lblNuevaClaveDesc;
        private System.Windows.Forms.TextBox txtNuevaContrasena;
        private System.Windows.Forms.Button btnNavRegistrarUsuario;
        private System.Windows.Forms.Button btnActualizarContrasena;
        private System.Windows.Forms.Button btnEliminarUsuario;
    }
}
