namespace Sistema_de_gestion_veterinaria
{
    partial class FrmRegistrarMascota
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
            this.btnNavVolver = new System.Windows.Forms.Button();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.lblHeaderSaludo = new System.Windows.Forms.Label();
            this.lblHeaderSub = new System.Windows.Forms.Label();
            this.pnlBannerTitulo = new System.Windows.Forms.Panel();
            this.lblTituloRegistro = new System.Windows.Forms.Label();
            this.pnlFoto = new System.Windows.Forms.Panel();
            this.lblTituloFoto = new System.Windows.Forms.Label();
            this.picFotoMascota = new System.Windows.Forms.PictureBox();
            this.btnSeleccionarFoto = new System.Windows.Forms.Button();
            this.btnQuitarFoto = new System.Windows.Forms.Button();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.lblTituloDatos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.cmbEdad = new System.Windows.Forms.ComboBox();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.cmbEspecie = new System.Windows.Forms.ComboBox();
            this.lblRaza = new System.Windows.Forms.Label();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.rdoMacho = new System.Windows.Forms.RadioButton();
            this.rdoHembra = new System.Windows.Forms.RadioButton();
            this.lblOtrosDatos = new System.Windows.Forms.Label();
            this.txtOtrosDatos = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblCedulaDueno = new System.Windows.Forms.Label();
            this.txtCedulaDueno = new System.Windows.Forms.TextBox();
            this.btnBuscarDueno = new System.Windows.Forms.Button();
            this.lblNombreDueno = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.pnlBannerTitulo.SuspendLayout();
            this.pnlFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoMascota)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Controls.Add(this.lblLogoSub);
            this.pnlSidebar.Controls.Add(this.btnNavVolver);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 681);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblLogo.Location = new System.Drawing.Point(5, 20);
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
            this.lblLogoSub.Location = new System.Drawing.Point(5, 55);
            this.lblLogoSub.Name = "lblLogoSub";
            this.lblLogoSub.Size = new System.Drawing.Size(185, 18);
            this.lblLogoSub.TabIndex = 1;
            this.lblLogoSub.Text = "V E T E R I N A R I A";
            this.lblLogoSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNavVolver
            // 
            this.btnNavVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnNavVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnNavVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavVolver.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnNavVolver.Location = new System.Drawing.Point(15, 100);
            this.btnNavVolver.Name = "btnNavVolver";
            this.btnNavVolver.Size = new System.Drawing.Size(165, 42);
            this.btnNavVolver.TabIndex = 2;
            this.btnNavVolver.Text = "↩  Volver al Menú";
            this.btnNavVolver.UseVisualStyleBackColor = false;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.AutoScroll = true;
            this.pnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
            this.pnlPrincipal.Controls.Add(this.lblHeaderSaludo);
            this.pnlPrincipal.Controls.Add(this.lblHeaderSub);
            this.pnlPrincipal.Controls.Add(this.pnlBannerTitulo);
            this.pnlPrincipal.Controls.Add(this.pnlFoto);
            this.pnlPrincipal.Controls.Add(this.pnlDatos);
            this.pnlPrincipal.Controls.Add(this.btnLimpiar);
            this.pnlPrincipal.Controls.Add(this.btnRegistrar);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(200, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Padding = new System.Windows.Forms.Padding(25);
            this.pnlPrincipal.Size = new System.Drawing.Size(884, 681);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // lblHeaderSaludo
            // 
            this.lblHeaderSaludo.AutoSize = true;
            this.lblHeaderSaludo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeaderSaludo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblHeaderSaludo.Location = new System.Drawing.Point(25, 20);
            this.lblHeaderSaludo.Name = "lblHeaderSaludo";
            this.lblHeaderSaludo.Size = new System.Drawing.Size(271, 37);
            this.lblHeaderSaludo.TabIndex = 0;
            this.lblHeaderSaludo.Text = "¡Registrar Mascota!";
            // 
            // lblHeaderSub
            // 
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(85)))));
            this.lblHeaderSub.Location = new System.Drawing.Point(28, 60);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(329, 19);
            this.lblHeaderSub.TabIndex = 1;
            this.lblHeaderSub.Text = "Ingresa los datos para emitir el carné digital oficial ♡";
            // 
            // pnlBannerTitulo
            // 
            this.pnlBannerTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(244)))), ((int)(((byte)(230)))));
            this.pnlBannerTitulo.Controls.Add(this.lblTituloRegistro);
            this.pnlBannerTitulo.Location = new System.Drawing.Point(25, 95);
            this.pnlBannerTitulo.Name = "pnlBannerTitulo";
            this.pnlBannerTitulo.Size = new System.Drawing.Size(830, 42);
            this.pnlBannerTitulo.TabIndex = 2;
            // 
            // lblTituloRegistro
            // 
            this.lblTituloRegistro.AutoSize = true;
            this.lblTituloRegistro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblTituloRegistro.Location = new System.Drawing.Point(15, 10);
            this.lblTituloRegistro.Name = "lblTituloRegistro";
            this.lblTituloRegistro.Size = new System.Drawing.Size(217, 21);
            this.lblTituloRegistro.TabIndex = 0;
            this.lblTituloRegistro.Text = "🐾   Registrar Nueva Mascota";
            // 
            // pnlFoto
            // 
            this.pnlFoto.BackColor = System.Drawing.Color.White;
            this.pnlFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFoto.Controls.Add(this.lblTituloFoto);
            this.pnlFoto.Controls.Add(this.picFotoMascota);
            this.pnlFoto.Controls.Add(this.btnSeleccionarFoto);
            this.pnlFoto.Controls.Add(this.btnQuitarFoto);
            this.pnlFoto.Location = new System.Drawing.Point(25, 150);
            this.pnlFoto.Name = "pnlFoto";
            this.pnlFoto.Size = new System.Drawing.Size(260, 440);
            this.pnlFoto.TabIndex = 3;
            // 
            // lblTituloFoto
            // 
            this.lblTituloFoto.AutoSize = true;
            this.lblTituloFoto.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblTituloFoto.Location = new System.Drawing.Point(15, 15);
            this.lblTituloFoto.Name = "lblTituloFoto";
            this.lblTituloFoto.Size = new System.Drawing.Size(126, 19);
            this.lblTituloFoto.TabIndex = 0;
            this.lblTituloFoto.Text = "📷  Foto del Animal";
            // 
            // picFotoMascota
            // 
            this.picFotoMascota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.picFotoMascota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFotoMascota.Location = new System.Drawing.Point(15, 50);
            this.picFotoMascota.Name = "picFotoMascota";
            this.picFotoMascota.Size = new System.Drawing.Size(225, 270);
            this.picFotoMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFotoMascota.TabIndex = 1;
            this.picFotoMascota.TabStop = false;
            // 
            // btnSeleccionarFoto
            // 
            this.btnSeleccionarFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnSeleccionarFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarFoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnSeleccionarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarFoto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionarFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnSeleccionarFoto.Location = new System.Drawing.Point(15, 335);
            this.btnSeleccionarFoto.Name = "btnSeleccionarFoto";
            this.btnSeleccionarFoto.Size = new System.Drawing.Size(225, 40);
            this.btnSeleccionarFoto.TabIndex = 2;
            this.btnSeleccionarFoto.Text = "📷  Seleccionar Foto";
            this.btnSeleccionarFoto.UseVisualStyleBackColor = false;
            // 
            // btnQuitarFoto
            // 
            this.btnQuitarFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnQuitarFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarFoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnQuitarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarFoto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQuitarFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnQuitarFoto.Location = new System.Drawing.Point(15, 385);
            this.btnQuitarFoto.Name = "btnQuitarFoto";
            this.btnQuitarFoto.Size = new System.Drawing.Size(225, 32);
            this.btnQuitarFoto.TabIndex = 3;
            this.btnQuitarFoto.Text = "✖  Quitar Foto";
            this.btnQuitarFoto.UseVisualStyleBackColor = false;
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.Color.White;
            this.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatos.Controls.Add(this.lblTituloDatos);
            this.pnlDatos.Controls.Add(this.lblNombre);
            this.pnlDatos.Controls.Add(this.txtNombre);
            this.pnlDatos.Controls.Add(this.lblEdad);
            this.pnlDatos.Controls.Add(this.cmbEdad);
            this.pnlDatos.Controls.Add(this.lblEspecie);
            this.pnlDatos.Controls.Add(this.cmbEspecie);
            this.pnlDatos.Controls.Add(this.lblRaza);
            this.pnlDatos.Controls.Add(this.txtRaza);
            this.pnlDatos.Controls.Add(this.lblSexo);
            this.pnlDatos.Controls.Add(this.rdoMacho);
            this.pnlDatos.Controls.Add(this.rdoHembra);
            this.pnlDatos.Controls.Add(this.lblOtrosDatos);
            this.pnlDatos.Controls.Add(this.txtOtrosDatos);
            this.pnlDatos.Controls.Add(this.lblCedulaDueno);
            this.pnlDatos.Controls.Add(this.txtCedulaDueno);
            this.pnlDatos.Controls.Add(this.btnBuscarDueno);
            this.pnlDatos.Controls.Add(this.lblNombreDueno);
            this.pnlDatos.Controls.Add(this.lblObservaciones);
            this.pnlDatos.Controls.Add(this.txtObservaciones);
            this.pnlDatos.Location = new System.Drawing.Point(300, 150);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(555, 440);
            this.pnlDatos.TabIndex = 4;
            // 
            // lblTituloDatos
            // 
            this.lblTituloDatos.AutoSize = true;
            this.lblTituloDatos.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblTituloDatos.Location = new System.Drawing.Point(20, 15);
            this.lblTituloDatos.Name = "lblTituloDatos";
            this.lblTituloDatos.Size = new System.Drawing.Size(217, 21);
            this.lblTituloDatos.TabIndex = 0;
            this.lblTituloDatos.Text = "🐾  Información de la Mascota";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(35)))));
            this.lblNombre.Location = new System.Drawing.Point(20, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre *";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.Location = new System.Drawing.Point(20, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(240, 25);
            this.txtNombre.TabIndex = 2;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblEdad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(35)))));
            this.lblEdad.Location = new System.Drawing.Point(285, 50);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(43, 15);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad *";
            // 
            // cmbEdad
            // 
            this.cmbEdad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.cmbEdad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEdad.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbEdad.FormattingEnabled = true;
            this.cmbEdad.Items.AddRange(new object[] {
            "1 mes",
            "3 meses",
            "6 meses",
            "1 año",
            "2 años",
            "3 años",
            "4 años",
            "5 años",
            "6 años",
            "7+ años"});
            this.cmbEdad.Location = new System.Drawing.Point(285, 68);
            this.cmbEdad.Name = "cmbEdad";
            this.cmbEdad.Size = new System.Drawing.Size(245, 25);
            this.cmbEdad.TabIndex = 4;
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblEspecie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(35)))));
            this.lblEspecie.Location = new System.Drawing.Point(20, 105);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(56, 15);
            this.lblEspecie.TabIndex = 5;
            this.lblEspecie.Text = "Especie *";
            // 
            // cmbEspecie
            // 
            this.cmbEspecie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.cmbEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecie.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbEspecie.FormattingEnabled = true;
            this.cmbEspecie.Items.AddRange(new object[] {
            "Perro",
            "Gato",
            "Conejo",
            "Ave",
            "Roedor",
            "Otro"});
            this.cmbEspecie.Location = new System.Drawing.Point(20, 125);
            this.cmbEspecie.Name = "cmbEspecie";
            this.cmbEspecie.Size = new System.Drawing.Size(240, 25);
            this.cmbEspecie.TabIndex = 6;
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblRaza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(35)))));
            this.lblRaza.Location = new System.Drawing.Point(285, 105);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(42, 15);
            this.lblRaza.TabIndex = 7;
            this.lblRaza.Text = "Raza *";
            // 
            // txtRaza
            // 
            this.txtRaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.txtRaza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRaza.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRaza.Location = new System.Drawing.Point(285, 125);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(245, 25);
            this.txtRaza.TabIndex = 8;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(35)))));
            this.lblSexo.Location = new System.Drawing.Point(20, 165);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(43, 15);
            this.lblSexo.TabIndex = 9;
            this.lblSexo.Text = "Sexo *";
            // 
            // rdoMacho
            // 
            this.rdoMacho.AutoSize = true;
            this.rdoMacho.Checked = true;
            this.rdoMacho.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rdoMacho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(45)))));
            this.rdoMacho.Location = new System.Drawing.Point(25, 185);
            this.rdoMacho.Name = "rdoMacho";
            this.rdoMacho.Size = new System.Drawing.Size(65, 21);
            this.rdoMacho.TabIndex = 10;
            this.rdoMacho.TabStop = true;
            this.rdoMacho.Text = "Macho";
            this.rdoMacho.UseVisualStyleBackColor = true;
            // 
            // rdoHembra
            // 
            this.rdoHembra.AutoSize = true;
            this.rdoHembra.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rdoHembra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(45)))));
            this.rdoHembra.Location = new System.Drawing.Point(110, 185);
            this.rdoHembra.Name = "rdoHembra";
            this.rdoHembra.Size = new System.Drawing.Size(73, 21);
            this.rdoHembra.TabIndex = 11;
            this.rdoHembra.Text = "Hembra";
            this.rdoHembra.UseVisualStyleBackColor = true;
            // 
            // lblOtrosDatos
            // 
            this.lblOtrosDatos.AutoSize = true;
            this.lblOtrosDatos.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblOtrosDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(35)))));
            this.lblOtrosDatos.Location = new System.Drawing.Point(285, 165);
            this.lblOtrosDatos.Name = "lblOtrosDatos";
            this.lblOtrosDatos.Size = new System.Drawing.Size(130, 15);
            this.lblOtrosDatos.TabIndex = 12;
            this.lblOtrosDatos.Text = "Otros Datos (Opcional)";
            // 
            // txtOtrosDatos
            // 
            this.txtOtrosDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.txtOtrosDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOtrosDatos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOtrosDatos.Location = new System.Drawing.Point(285, 183);
            this.txtOtrosDatos.Name = "txtOtrosDatos";
            this.txtOtrosDatos.Size = new System.Drawing.Size(245, 25);
            this.txtOtrosDatos.TabIndex = 13;
            // 
            // lblCedulaDueno
            // 
            this.lblCedulaDueno.AutoSize = true;
            this.lblCedulaDueno.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblCedulaDueno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(35)))));
            this.lblCedulaDueno.Location = new System.Drawing.Point(20, 220);
            this.lblCedulaDueno.Name = "lblCedulaDueno";
            this.lblCedulaDueno.Size = new System.Drawing.Size(185, 15);
            this.lblCedulaDueno.TabIndex = 14;
            this.lblCedulaDueno.Text = "C.C. del Dueño / Propietario *";
            // 
            // txtCedulaDueno
            // 
            this.txtCedulaDueno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.txtCedulaDueno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCedulaDueno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCedulaDueno.Location = new System.Drawing.Point(20, 240);
            this.txtCedulaDueno.Name = "txtCedulaDueno";
            this.txtCedulaDueno.Size = new System.Drawing.Size(200, 25);
            this.txtCedulaDueno.TabIndex = 15;
            // 
            // btnBuscarDueno
            // 
            this.btnBuscarDueno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnBuscarDueno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarDueno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnBuscarDueno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDueno.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnBuscarDueno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnBuscarDueno.Location = new System.Drawing.Point(228, 238);
            this.btnBuscarDueno.Name = "btnBuscarDueno";
            this.btnBuscarDueno.Size = new System.Drawing.Size(85, 28);
            this.btnBuscarDueno.TabIndex = 16;
            this.btnBuscarDueno.Text = "🔍 Validar";
            this.btnBuscarDueno.UseVisualStyleBackColor = false;
            // 
            // lblNombreDueno
            // 
            this.lblNombreDueno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblNombreDueno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.lblNombreDueno.Location = new System.Drawing.Point(320, 243);
            this.lblNombreDueno.Name = "lblNombreDueno";
            this.lblNombreDueno.Size = new System.Drawing.Size(210, 20);
            this.lblNombreDueno.TabIndex = 17;
            this.lblNombreDueno.Text = "Ingresa C.C. para asociar";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblObservaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(35)))));
            this.lblObservaciones.Location = new System.Drawing.Point(20, 275);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(144, 15);
            this.lblObservaciones.TabIndex = 18;
            this.lblObservaciones.Text = "Observaciones (Opcional)";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservaciones.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtObservaciones.Location = new System.Drawing.Point(20, 295);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(510, 115);
            this.txtObservaciones.TabIndex = 19;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnLimpiar.Location = new System.Drawing.Point(300, 610);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(180, 42);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "🔄  Limpiar Formulario";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(595, 610);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(260, 42);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "💾   Registrar Mascota";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // FrmRegistrarMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 681);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlSidebar);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "FrmRegistrarMascota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Huellitas Veterinaria - Registrar Nueva Mascota";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlBannerTitulo.ResumeLayout(false);
            this.pnlBannerTitulo.PerformLayout();
            this.pnlFoto.ResumeLayout(false);
            this.pnlFoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoMascota)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblLogoSub;
        private System.Windows.Forms.Button btnNavVolver;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Label lblHeaderSaludo;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Panel pnlBannerTitulo;
        private System.Windows.Forms.Label lblTituloRegistro;
        private System.Windows.Forms.Panel pnlFoto;
        private System.Windows.Forms.Label lblTituloFoto;
        private System.Windows.Forms.PictureBox picFotoMascota;
        private System.Windows.Forms.Button btnSeleccionarFoto;
        private System.Windows.Forms.Button btnQuitarFoto;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label lblTituloDatos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.ComboBox cmbEdad;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.ComboBox cmbEspecie;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton rdoMacho;
        private System.Windows.Forms.RadioButton rdoHembra;
        private System.Windows.Forms.Label lblOtrosDatos;
        private System.Windows.Forms.TextBox txtOtrosDatos;
        private System.Windows.Forms.Label lblCedulaDueno;
        private System.Windows.Forms.TextBox txtCedulaDueno;
        private System.Windows.Forms.Button btnBuscarDueno;
        private System.Windows.Forms.Label lblNombreDueno;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegistrar;
    }
}
