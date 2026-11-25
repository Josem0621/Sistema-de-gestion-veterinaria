namespace Sistema_de_gestion_veterinaria
{
    partial class FrmAtencionMedica
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
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblTituloModulo = new System.Windows.Forms.Label();
            this.lblCarneLabel = new System.Windows.Forms.Label();
            this.txtBuscarCarne = new System.Windows.Forms.TextBox();
            this.lblO = new System.Windows.Forms.Label();
            this.lblCedulaLabel = new System.Windows.Forms.Label();
            this.txtBuscarCedula = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblOtrasMascotas = new System.Windows.Forms.Label();
            this.cmbOtrasMascotas = new System.Windows.Forms.ComboBox();
            this.lblMascotaDueno = new System.Windows.Forms.Label();
            this.cmbMascotasDueno = new System.Windows.Forms.ComboBox();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.pnlFichaMascota = new System.Windows.Forms.Panel();
            this.picMascota = new System.Windows.Forms.PictureBox();
            this.lblIdBadge = new System.Windows.Forms.Label();
            this.lblNombreMascota = new System.Windows.Forms.Label();
            this.lblEdadMascota = new System.Windows.Forms.Label();
            this.lblEspecieMascota = new System.Windows.Forms.Label();
            this.lblRazaMascota = new System.Windows.Forms.Label();
            this.lblSexoMascota = new System.Windows.Forms.Label();
            this.lblEstadoSalud = new System.Windows.Forms.Label();
            this.pnlCitaCard = new System.Windows.Forms.Panel();
            this.lblTituloCitaCard = new System.Windows.Forms.Label();
            this.lblDetalleCitaCard = new System.Windows.Forms.Label();
            this.btnCancelarCita = new System.Windows.Forms.Button();
            this.pnlObsCard = new System.Windows.Forms.Panel();
            this.lblTituloObsCard = new System.Windows.Forms.Label();
            this.lblTextoObsCard = new System.Windows.Forms.Label();
            this.pnlContenidoPestanas = new System.Windows.Forms.Panel();
            this.tabModulos = new System.Windows.Forms.TabControl();
            this.tabHistorial = new System.Windows.Forms.TabPage();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.pnlNuevaConsulta = new System.Windows.Forms.Panel();
            this.lblTituloNuevaConsulta = new System.Windows.Forms.Label();
            this.lblDiag = new System.Windows.Forms.Label();
            this.txtDiag = new System.Windows.Forms.TextBox();
            this.lblTrat = new System.Windows.Forms.Label();
            this.txtTrat = new System.Windows.Forms.TextBox();
            this.lblMed = new System.Windows.Forms.Label();
            this.txtMed = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.btnAgregarConsulta = new System.Windows.Forms.Button();
            this.tabVacunas = new System.Windows.Forms.TabPage();
            this.dgvVacunas = new System.Windows.Forms.DataGridView();
            this.pnlNuevaVacuna = new System.Windows.Forms.Panel();
            this.lblTituloNuevaVacuna = new System.Windows.Forms.Label();
            this.lblNomVacuna = new System.Windows.Forms.Label();
            this.txtNomVacuna = new System.Windows.Forms.TextBox();
            this.lblDosisVacuna = new System.Windows.Forms.Label();
            this.txtDosisVacuna = new System.Windows.Forms.TextBox();
            this.lblLoteVacuna = new System.Windows.Forms.Label();
            this.txtLoteVacuna = new System.Windows.Forms.TextBox();
            this.lblProxVacuna = new System.Windows.Forms.Label();
            this.dtpProxVacuna = new System.Windows.Forms.DateTimePicker();
            this.btnGuardarVacuna = new System.Windows.Forms.Button();
            this.tabDesparasitacion = new System.Windows.Forms.TabPage();
            this.dgvDesparasitaciones = new System.Windows.Forms.DataGridView();
            this.pnlNuevaDesparasitacion = new System.Windows.Forms.Panel();
            this.lblTituloDesp = new System.Windows.Forms.Label();
            this.lblTipoDesp = new System.Windows.Forms.Label();
            this.cmbTipoDesp = new System.Windows.Forms.ComboBox();
            this.lblProdDesp = new System.Windows.Forms.Label();
            this.txtProdDesp = new System.Windows.Forms.TextBox();
            this.lblPesoDesp = new System.Windows.Forms.Label();
            this.txtPesoDesp = new System.Windows.Forms.TextBox();
            this.lblProxDesp = new System.Windows.Forms.Label();
            this.dtpProxDesp = new System.Windows.Forms.DateTimePicker();
            this.btnGuardarDesp = new System.Windows.Forms.Button();
            this.tabMedicamentos = new System.Windows.Forms.TabPage();
            this.dgvTratamientos = new System.Windows.Forms.DataGridView();
            this.pnlNuevoTratamiento = new System.Windows.Forms.Panel();
            this.lblTituloTrat = new System.Windows.Forms.Label();
            this.lblMedTrat = new System.Windows.Forms.Label();
            this.txtMedTrat = new System.Windows.Forms.TextBox();
            this.lblIndicacionesTrat = new System.Windows.Forms.Label();
            this.txtIndicacionesTrat = new System.Windows.Forms.TextBox();
            this.lblFechaFinTrat = new System.Windows.Forms.Label();
            this.dtpFinTrat = new System.Windows.Forms.DateTimePicker();
            this.btnGuardarTratamiento = new System.Windows.Forms.Button();
            this.tabAgendarCita = new System.Windows.Forms.TabPage();
            this.pnlFormCita = new System.Windows.Forms.Panel();
            this.lblTituloAgendarCita = new System.Windows.Forms.Label();
            this.lblVeterinarioCita = new System.Windows.Forms.Label();
            this.cmbVeterinarioCita = new System.Windows.Forms.ComboBox();
            this.lblFechaCita = new System.Windows.Forms.Label();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.lblHoraCita = new System.Windows.Forms.Label();
            this.cmbHoraCita = new System.Windows.Forms.ComboBox();
            this.btnAgendarCita = new System.Windows.Forms.Button();
            this.lblMotivoCita = new System.Windows.Forms.Label();
            this.txtMotivoCita = new System.Windows.Forms.TextBox();
            this.lblTituloListaCitas = new System.Windows.Forms.Label();
            this.dgvCitasProgramadas = new System.Windows.Forms.DataGridView();
            this.colCitaFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCitaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCitaMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCitaVet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCitaMotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCitaEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCitaAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlResumenInferior = new System.Windows.Forms.Panel();
            this.cardResumenVacunas = new System.Windows.Forms.Panel();
            this.lblTitResumenVacunas = new System.Windows.Forms.Label();
            this.lblTextoResumenVacunas = new System.Windows.Forms.Label();
            this.cardResumenDesp = new System.Windows.Forms.Panel();
            this.lblTitResumenDesp = new System.Windows.Forms.Label();
            this.lblTextoResumenDesp = new System.Windows.Forms.Label();
            this.cardResumenMed = new System.Windows.Forms.Panel();
            this.lblTitResumenMed = new System.Windows.Forms.Label();
            this.lblTextoResumenMed = new System.Windows.Forms.Label();
            this.pnlTopBar.SuspendLayout();
            this.pnlFichaMascota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).BeginInit();
            this.pnlCitaCard.SuspendLayout();
            this.pnlObsCard.SuspendLayout();
            this.pnlContenidoPestanas.SuspendLayout();
            this.tabModulos.SuspendLayout();
            this.tabHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.pnlNuevaConsulta.SuspendLayout();
            this.tabVacunas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacunas)).BeginInit();
            this.pnlNuevaVacuna.SuspendLayout();
            this.tabDesparasitacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesparasitaciones)).BeginInit();
            this.pnlNuevaDesparasitacion.SuspendLayout();
            this.tabMedicamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamientos)).BeginInit();
            this.pnlNuevoTratamiento.SuspendLayout();
            this.tabAgendarCita.SuspendLayout();
            this.pnlFormCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitasProgramadas)).BeginInit();
            this.pnlResumenInferior.SuspendLayout();
            this.cardResumenVacunas.SuspendLayout();
            this.cardResumenDesp.SuspendLayout();
            this.cardResumenMed.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.White;
            this.pnlTopBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTopBar.Controls.Add(this.lblTituloModulo);
            this.pnlTopBar.Controls.Add(this.lblCarneLabel);
            this.pnlTopBar.Controls.Add(this.txtBuscarCarne);
            this.pnlTopBar.Controls.Add(this.lblO);
            this.pnlTopBar.Controls.Add(this.lblCedulaLabel);
            this.pnlTopBar.Controls.Add(this.txtBuscarCedula);
            this.pnlTopBar.Controls.Add(this.btnBuscar);
            this.pnlTopBar.Controls.Add(this.lblOtrasMascotas);
            this.pnlTopBar.Controls.Add(this.cmbOtrasMascotas);
            this.pnlTopBar.Controls.Add(this.lblMascotaDueno);
            this.pnlTopBar.Controls.Add(this.cmbMascotasDueno);
            this.pnlTopBar.Controls.Add(this.btnVolverMenu);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1264, 65);
            this.pnlTopBar.TabIndex = 0;
            // 
            // lblTituloModulo
            // 
            this.lblTituloModulo.AutoSize = true;
            this.lblTituloModulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTituloModulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblTituloModulo.Location = new System.Drawing.Point(15, 18);
            this.lblTituloModulo.Name = "lblTituloModulo";
            this.lblTituloModulo.Size = new System.Drawing.Size(177, 25);
            this.lblTituloModulo.TabIndex = 0;
            this.lblTituloModulo.Text = "🐾 Buscar Mascota";
            // 
            // lblCarneLabel
            // 
            this.lblCarneLabel.AutoSize = true;
            this.lblCarneLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCarneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.lblCarneLabel.Location = new System.Drawing.Point(224, 10);
            this.lblCarneLabel.Name = "lblCarneLabel";
            this.lblCarneLabel.Size = new System.Drawing.Size(110, 13);
            this.lblCarneLabel.TabIndex = 1;
            this.lblCarneLabel.Text = "ID del Carné Digital:";
            // 
            // txtBuscarCarne
            // 
            this.txtBuscarCarne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.txtBuscarCarne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarCarne.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtBuscarCarne.Location = new System.Drawing.Point(224, 26);
            this.txtBuscarCarne.Name = "txtBuscarCarne";
            this.txtBuscarCarne.Size = new System.Drawing.Size(140, 24);
            this.txtBuscarCarne.TabIndex = 2;
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(110)))), ((int)(((byte)(100)))));
            this.lblO.Location = new System.Drawing.Point(371, 28);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(16, 17);
            this.lblO.TabIndex = 3;
            this.lblO.Text = "o";
            // 
            // lblCedulaLabel
            // 
            this.lblCedulaLabel.AutoSize = true;
            this.lblCedulaLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCedulaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.lblCedulaLabel.Location = new System.Drawing.Point(394, 10);
            this.lblCedulaLabel.Name = "lblCedulaLabel";
            this.lblCedulaLabel.Size = new System.Drawing.Size(87, 13);
            this.lblCedulaLabel.TabIndex = 4;
            this.lblCedulaLabel.Text = "C.C. del Dueño:";
            // 
            // txtBuscarCedula
            // 
            this.txtBuscarCedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.txtBuscarCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarCedula.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtBuscarCedula.Location = new System.Drawing.Point(394, 26);
            this.txtBuscarCedula.Name = "txtBuscarCedula";
            this.txtBuscarCedula.Size = new System.Drawing.Size(140, 24);
            this.txtBuscarCedula.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(544, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 30);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "🔍   Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblOtrasMascotas
            // 
            this.lblOtrasMascotas.AutoSize = true;
            this.lblOtrasMascotas.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblOtrasMascotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.lblOtrasMascotas.Location = new System.Drawing.Point(669, 10);
            this.lblOtrasMascotas.Name = "lblOtrasMascotas";
            this.lblOtrasMascotas.Size = new System.Drawing.Size(135, 13);
            this.lblOtrasMascotas.TabIndex = 8;
            this.lblOtrasMascotas.Text = "Mascotas de este dueño:";
            this.lblOtrasMascotas.Visible = false;
            // 
            // cmbOtrasMascotas
            // 
            this.cmbOtrasMascotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOtrasMascotas.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbOtrasMascotas.FormattingEnabled = true;
            this.cmbOtrasMascotas.Location = new System.Drawing.Point(669, 26);
            this.cmbOtrasMascotas.Name = "cmbOtrasMascotas";
            this.cmbOtrasMascotas.Size = new System.Drawing.Size(250, 25);
            this.cmbOtrasMascotas.TabIndex = 9;
            this.cmbOtrasMascotas.Visible = false;
            // 
            // lblMascotaDueno
            // 
            this.lblMascotaDueno.AutoSize = true;
            this.lblMascotaDueno.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMascotaDueno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.lblMascotaDueno.Location = new System.Drawing.Point(294, 10);
            this.lblMascotaDueno.Name = "lblMascotaDueno";
            this.lblMascotaDueno.Size = new System.Drawing.Size(114, 13);
            this.lblMascotaDueno.TabIndex = 10;
            this.lblMascotaDueno.Text = "Seleccionar Mascota:";
            this.lblMascotaDueno.Visible = false;
            // 
            // cmbMascotasDueno
            // 
            this.cmbMascotasDueno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMascotasDueno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMascotasDueno.FormattingEnabled = true;
            this.cmbMascotasDueno.Location = new System.Drawing.Point(260, 26);
            this.cmbMascotasDueno.Name = "cmbMascotasDueno";
            this.cmbMascotasDueno.Size = new System.Drawing.Size(350, 25);
            this.cmbMascotasDueno.TabIndex = 11;
            this.cmbMascotasDueno.Visible = false;
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolverMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnVolverMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnVolverMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnVolverMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnVolverMenu.Location = new System.Drawing.Point(1090, 16);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(155, 34);
            this.btnVolverMenu.TabIndex = 7;
            this.btnVolverMenu.Text = "↩  Volver al Menú";
            this.btnVolverMenu.UseVisualStyleBackColor = false;
            // 
            // pnlFichaMascota
            // 
            this.pnlFichaMascota.BackColor = System.Drawing.Color.White;
            this.pnlFichaMascota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFichaMascota.Controls.Add(this.picMascota);
            this.pnlFichaMascota.Controls.Add(this.lblIdBadge);
            this.pnlFichaMascota.Controls.Add(this.lblNombreMascota);
            this.pnlFichaMascota.Controls.Add(this.lblEdadMascota);
            this.pnlFichaMascota.Controls.Add(this.lblEspecieMascota);
            this.pnlFichaMascota.Controls.Add(this.lblRazaMascota);
            this.pnlFichaMascota.Controls.Add(this.lblSexoMascota);
            this.pnlFichaMascota.Controls.Add(this.lblEstadoSalud);
            this.pnlFichaMascota.Controls.Add(this.pnlCitaCard);
            this.pnlFichaMascota.Controls.Add(this.pnlObsCard);
            this.pnlFichaMascota.Location = new System.Drawing.Point(15, 80);
            this.pnlFichaMascota.Name = "pnlFichaMascota";
            this.pnlFichaMascota.Size = new System.Drawing.Size(260, 650);
            this.pnlFichaMascota.TabIndex = 1;
            // 
            // picMascota
            // 
            this.picMascota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.picMascota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMascota.Location = new System.Drawing.Point(20, 15);
            this.picMascota.Name = "picMascota";
            this.picMascota.Size = new System.Drawing.Size(218, 160);
            this.picMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMascota.TabIndex = 0;
            this.picMascota.TabStop = false;
            // 
            // lblIdBadge
            // 
            this.lblIdBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(244)))), ((int)(((byte)(230)))));
            this.lblIdBadge.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblIdBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblIdBadge.Location = new System.Drawing.Point(20, 185);
            this.lblIdBadge.Name = "lblIdBadge";
            this.lblIdBadge.Size = new System.Drawing.Size(218, 26);
            this.lblIdBadge.TabIndex = 1;
            this.lblIdBadge.Text = "🪪  ID: MC-045";
            this.lblIdBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreMascota
            // 
            this.lblNombreMascota.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNombreMascota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(40)))));
            this.lblNombreMascota.Location = new System.Drawing.Point(20, 220);
            this.lblNombreMascota.Name = "lblNombreMascota";
            this.lblNombreMascota.Size = new System.Drawing.Size(218, 20);
            this.lblNombreMascota.TabIndex = 2;
            this.lblNombreMascota.Text = "🐾  Nombre:  Luna";
            // 
            // lblEdadMascota
            // 
            this.lblEdadMascota.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEdadMascota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(40)))));
            this.lblEdadMascota.Location = new System.Drawing.Point(20, 245);
            this.lblEdadMascota.Name = "lblEdadMascota";
            this.lblEdadMascota.Size = new System.Drawing.Size(218, 20);
            this.lblEdadMascota.TabIndex = 3;
            this.lblEdadMascota.Text = "🐾  Edad:  3 años";
            // 
            // lblEspecieMascota
            // 
            this.lblEspecieMascota.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEspecieMascota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(40)))));
            this.lblEspecieMascota.Location = new System.Drawing.Point(20, 270);
            this.lblEspecieMascota.Name = "lblEspecieMascota";
            this.lblEspecieMascota.Size = new System.Drawing.Size(218, 20);
            this.lblEspecieMascota.TabIndex = 4;
            this.lblEspecieMascota.Text = "🐾  Especie:  Perro";
            // 
            // lblRazaMascota
            // 
            this.lblRazaMascota.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRazaMascota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(40)))));
            this.lblRazaMascota.Location = new System.Drawing.Point(20, 295);
            this.lblRazaMascota.Name = "lblRazaMascota";
            this.lblRazaMascota.Size = new System.Drawing.Size(218, 20);
            this.lblRazaMascota.TabIndex = 5;
            this.lblRazaMascota.Text = "🐾  Raza:  Husky Siberiano";
            // 
            // lblSexoMascota
            // 
            this.lblSexoMascota.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSexoMascota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(40)))));
            this.lblSexoMascota.Location = new System.Drawing.Point(20, 320);
            this.lblSexoMascota.Name = "lblSexoMascota";
            this.lblSexoMascota.Size = new System.Drawing.Size(218, 20);
            this.lblSexoMascota.TabIndex = 6;
            this.lblSexoMascota.Text = "🐾  Sexo:  Hembra";
            // 
            // lblEstadoSalud
            // 
            this.lblEstadoSalud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.lblEstadoSalud.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblEstadoSalud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblEstadoSalud.Location = new System.Drawing.Point(20, 350);
            this.lblEstadoSalud.Name = "lblEstadoSalud";
            this.lblEstadoSalud.Size = new System.Drawing.Size(218, 30);
            this.lblEstadoSalud.TabIndex = 7;
            this.lblEstadoSalud.Text = "💚  Estado: Saludable";
            this.lblEstadoSalud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCitaCard
            // 
            this.pnlCitaCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
            this.pnlCitaCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCitaCard.Controls.Add(this.lblTituloCitaCard);
            this.pnlCitaCard.Controls.Add(this.lblDetalleCitaCard);
            this.pnlCitaCard.Controls.Add(this.btnCancelarCita);
            this.pnlCitaCard.Location = new System.Drawing.Point(15, 395);
            this.pnlCitaCard.Name = "pnlCitaCard";
            this.pnlCitaCard.Size = new System.Drawing.Size(228, 120);
            this.pnlCitaCard.TabIndex = 8;
            // 
            // lblTituloCitaCard
            // 
            this.lblTituloCitaCard.AutoSize = true;
            this.lblTituloCitaCard.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloCitaCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblTituloCitaCard.Location = new System.Drawing.Point(10, 8);
            this.lblTituloCitaCard.Name = "lblTituloCitaCard";
            this.lblTituloCitaCard.Size = new System.Drawing.Size(93, 15);
            this.lblTituloCitaCard.TabIndex = 0;
            this.lblTituloCitaCard.Text = "📅  Próxima Cita";
            // 
            // lblDetalleCitaCard
            // 
            this.lblDetalleCitaCard.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblDetalleCitaCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.lblDetalleCitaCard.Location = new System.Drawing.Point(10, 28);
            this.lblDetalleCitaCard.Name = "lblDetalleCitaCard";
            this.lblDetalleCitaCard.Size = new System.Drawing.Size(205, 48);
            this.lblDetalleCitaCard.TabIndex = 1;
            this.lblDetalleCitaCard.Text = "25/11/2026 - 09:00 a.m.\r\nConsulta de control";
            // 
            // btnCancelarCita
            // 
            this.btnCancelarCita.BackColor = System.Drawing.Color.White;
            this.btnCancelarCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarCita.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.btnCancelarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCita.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnCancelarCita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(80)))));
            this.btnCancelarCita.Location = new System.Drawing.Point(10, 82);
            this.btnCancelarCita.Name = "btnCancelarCita";
            this.btnCancelarCita.Size = new System.Drawing.Size(95, 26);
            this.btnCancelarCita.TabIndex = 2;
            this.btnCancelarCita.Text = "Cancelar";
            this.btnCancelarCita.UseVisualStyleBackColor = false;
            // 
            // pnlObsCard
            // 
            this.pnlObsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
            this.pnlObsCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlObsCard.Controls.Add(this.lblTituloObsCard);
            this.pnlObsCard.Controls.Add(this.lblTextoObsCard);
            this.pnlObsCard.Location = new System.Drawing.Point(15, 525);
            this.pnlObsCard.Name = "pnlObsCard";
            this.pnlObsCard.Size = new System.Drawing.Size(228, 110);
            this.pnlObsCard.TabIndex = 9;
            // 
            // lblTituloObsCard
            // 
            this.lblTituloObsCard.AutoSize = true;
            this.lblTituloObsCard.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloObsCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblTituloObsCard.Location = new System.Drawing.Point(10, 8);
            this.lblTituloObsCard.Name = "lblTituloObsCard";
            this.lblTituloObsCard.Size = new System.Drawing.Size(163, 15);
            this.lblTituloObsCard.TabIndex = 0;
            this.lblTituloObsCard.Text = "ℹ  Observaciones Generales  ";
            // 
            // lblTextoObsCard
            // 
            this.lblTextoObsCard.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblTextoObsCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.lblTextoObsCard.Location = new System.Drawing.Point(10, 30);
            this.lblTextoObsCard.Name = "lblTextoObsCard";
            this.lblTextoObsCard.Size = new System.Drawing.Size(205, 68);
            this.lblTextoObsCard.TabIndex = 1;
            this.lblTextoObsCard.Text = "Mascota muy activa y sociable. Requiere mantener calendario de vacunación al día." +
    "";
            // 
            // pnlContenidoPestanas
            // 
            this.pnlContenidoPestanas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenidoPestanas.Controls.Add(this.tabModulos);
            this.pnlContenidoPestanas.Controls.Add(this.pnlResumenInferior);
            this.pnlContenidoPestanas.Location = new System.Drawing.Point(290, 80);
            this.pnlContenidoPestanas.Name = "pnlContenidoPestanas";
            this.pnlContenidoPestanas.Size = new System.Drawing.Size(955, 650);
            this.pnlContenidoPestanas.TabIndex = 2;
            // 
            // tabModulos
            // 
            this.tabModulos.Controls.Add(this.tabHistorial);
            this.tabModulos.Controls.Add(this.tabVacunas);
            this.tabModulos.Controls.Add(this.tabDesparasitacion);
            this.tabModulos.Controls.Add(this.tabMedicamentos);
            this.tabModulos.Controls.Add(this.tabAgendarCita);
            this.tabModulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabModulos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.tabModulos.Location = new System.Drawing.Point(0, 0);
            this.tabModulos.Name = "tabModulos";
            this.tabModulos.SelectedIndex = 0;
            this.tabModulos.Size = new System.Drawing.Size(955, 520);
            this.tabModulos.TabIndex = 0;
            // 
            // tabHistorial
            // 
            this.tabHistorial.BackColor = System.Drawing.Color.White;
            this.tabHistorial.Controls.Add(this.dgvHistorial);
            this.tabHistorial.Controls.Add(this.pnlNuevaConsulta);
            this.tabHistorial.Location = new System.Drawing.Point(4, 26);
            this.tabHistorial.Name = "tabHistorial";
            this.tabHistorial.Padding = new System.Windows.Forms.Padding(10);
            this.tabHistorial.Size = new System.Drawing.Size(947, 490);
            this.tabHistorial.TabIndex = 0;
            this.tabHistorial.Text = "📅  Historial Clínico";
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.dgvHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistorial.Location = new System.Drawing.Point(10, 10);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersVisible = false;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Size = new System.Drawing.Size(927, 280);
            this.dgvHistorial.TabIndex = 0;
            // 
            // pnlNuevaConsulta
            // 
            this.pnlNuevaConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
            this.pnlNuevaConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNuevaConsulta.Controls.Add(this.lblTituloNuevaConsulta);
            this.pnlNuevaConsulta.Controls.Add(this.lblDiag);
            this.pnlNuevaConsulta.Controls.Add(this.txtDiag);
            this.pnlNuevaConsulta.Controls.Add(this.lblTrat);
            this.pnlNuevaConsulta.Controls.Add(this.txtTrat);
            this.pnlNuevaConsulta.Controls.Add(this.lblMed);
            this.pnlNuevaConsulta.Controls.Add(this.txtMed);
            this.pnlNuevaConsulta.Controls.Add(this.lblObs);
            this.pnlNuevaConsulta.Controls.Add(this.txtObs);
            this.pnlNuevaConsulta.Controls.Add(this.btnAgregarConsulta);
            this.pnlNuevaConsulta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNuevaConsulta.Location = new System.Drawing.Point(10, 290);
            this.pnlNuevaConsulta.Name = "pnlNuevaConsulta";
            this.pnlNuevaConsulta.Size = new System.Drawing.Size(927, 190);
            this.pnlNuevaConsulta.TabIndex = 1;
            // 
            // lblTituloNuevaConsulta
            // 
            this.lblTituloNuevaConsulta.AutoSize = true;
            this.lblTituloNuevaConsulta.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloNuevaConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblTituloNuevaConsulta.Location = new System.Drawing.Point(15, 8);
            this.lblTituloNuevaConsulta.Name = "lblTituloNuevaConsulta";
            this.lblTituloNuevaConsulta.Size = new System.Drawing.Size(202, 19);
            this.lblTituloNuevaConsulta.TabIndex = 0;
            this.lblTituloNuevaConsulta.Text = "➕  Registrar Consulta Médica";
            // 
            // lblDiag
            // 
            this.lblDiag.AutoSize = true;
            this.lblDiag.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDiag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(45)))));
            this.lblDiag.Location = new System.Drawing.Point(15, 35);
            this.lblDiag.Name = "lblDiag";
            this.lblDiag.Size = new System.Drawing.Size(73, 15);
            this.lblDiag.TabIndex = 1;
            this.lblDiag.Text = "Diagnóstico:";
            // 
            // txtDiag
            // 
            this.txtDiag.BackColor = System.Drawing.Color.White;
            this.txtDiag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiag.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiag.Location = new System.Drawing.Point(15, 53);
            this.txtDiag.Name = "txtDiag";
            this.txtDiag.Size = new System.Drawing.Size(280, 23);
            this.txtDiag.TabIndex = 2;
            // 
            // lblTrat
            // 
            this.lblTrat.AutoSize = true;
            this.lblTrat.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTrat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(45)))));
            this.lblTrat.Location = new System.Drawing.Point(315, 35);
            this.lblTrat.Name = "lblTrat";
            this.lblTrat.Size = new System.Drawing.Size(74, 15);
            this.lblTrat.TabIndex = 3;
            this.lblTrat.Text = "Tratamiento:";
            // 
            // txtTrat
            // 
            this.txtTrat.BackColor = System.Drawing.Color.White;
            this.txtTrat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTrat.Location = new System.Drawing.Point(315, 53);
            this.txtTrat.Name = "txtTrat";
            this.txtTrat.Size = new System.Drawing.Size(280, 23);
            this.txtTrat.TabIndex = 4;
            // 
            // lblMed
            // 
            this.lblMed.AutoSize = true;
            this.lblMed.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(45)))));
            this.lblMed.Location = new System.Drawing.Point(615, 35);
            this.lblMed.Name = "lblMed";
            this.lblMed.Size = new System.Drawing.Size(89, 15);
            this.lblMed.TabIndex = 5;
            this.lblMed.Text = "Medicamentos:";
            // 
            // txtMed
            // 
            this.txtMed.BackColor = System.Drawing.Color.White;
            this.txtMed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMed.Location = new System.Drawing.Point(615, 53);
            this.txtMed.Name = "txtMed";
            this.txtMed.Size = new System.Drawing.Size(290, 23);
            this.txtMed.TabIndex = 6;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblObs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(45)))));
            this.lblObs.Location = new System.Drawing.Point(15, 85);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(87, 15);
            this.lblObs.TabIndex = 7;
            this.lblObs.Text = "Observaciones:";
            // 
            // txtObs
            // 
            this.txtObs.BackColor = System.Drawing.Color.White;
            this.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtObs.Location = new System.Drawing.Point(15, 103);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(580, 65);
            this.txtObs.TabIndex = 8;
            // 
            // btnAgregarConsulta
            // 
            this.btnAgregarConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnAgregarConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarConsulta.FlatAppearance.BorderSize = 0;
            this.btnAgregarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarConsulta.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregarConsulta.ForeColor = System.Drawing.Color.White;
            this.btnAgregarConsulta.Location = new System.Drawing.Point(615, 103);
            this.btnAgregarConsulta.Name = "btnAgregarConsulta";
            this.btnAgregarConsulta.Size = new System.Drawing.Size(290, 65);
            this.btnAgregarConsulta.TabIndex = 9;
            this.btnAgregarConsulta.Text = "💾   Guardar en Historial";
            this.btnAgregarConsulta.UseVisualStyleBackColor = false;
            // 
            // tabVacunas
            // 
            this.tabVacunas.BackColor = System.Drawing.Color.White;
            this.tabVacunas.Controls.Add(this.dgvVacunas);
            this.tabVacunas.Controls.Add(this.pnlNuevaVacuna);
            this.tabVacunas.Location = new System.Drawing.Point(4, 26);
            this.tabVacunas.Name = "tabVacunas";
            this.tabVacunas.Padding = new System.Windows.Forms.Padding(10);
            this.tabVacunas.Size = new System.Drawing.Size(947, 490);
            this.tabVacunas.TabIndex = 1;
            this.tabVacunas.Text = "💉  Vacunas";
            // 
            // dgvVacunas
            // 
            this.dgvVacunas.AllowUserToAddRows = false;
            this.dgvVacunas.AllowUserToDeleteRows = false;
            this.dgvVacunas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVacunas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.dgvVacunas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVacunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacunas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVacunas.Location = new System.Drawing.Point(10, 10);
            this.dgvVacunas.Name = "dgvVacunas";
            this.dgvVacunas.ReadOnly = true;
            this.dgvVacunas.RowHeadersVisible = false;
            this.dgvVacunas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVacunas.Size = new System.Drawing.Size(927, 340);
            this.dgvVacunas.TabIndex = 0;
            // 
            // pnlNuevaVacuna
            // 
            this.pnlNuevaVacuna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
            this.pnlNuevaVacuna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNuevaVacuna.Controls.Add(this.lblTituloNuevaVacuna);
            this.pnlNuevaVacuna.Controls.Add(this.lblNomVacuna);
            this.pnlNuevaVacuna.Controls.Add(this.txtNomVacuna);
            this.pnlNuevaVacuna.Controls.Add(this.lblDosisVacuna);
            this.pnlNuevaVacuna.Controls.Add(this.txtDosisVacuna);
            this.pnlNuevaVacuna.Controls.Add(this.lblLoteVacuna);
            this.pnlNuevaVacuna.Controls.Add(this.txtLoteVacuna);
            this.pnlNuevaVacuna.Controls.Add(this.lblProxVacuna);
            this.pnlNuevaVacuna.Controls.Add(this.dtpProxVacuna);
            this.pnlNuevaVacuna.Controls.Add(this.btnGuardarVacuna);
            this.pnlNuevaVacuna.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNuevaVacuna.Location = new System.Drawing.Point(10, 350);
            this.pnlNuevaVacuna.Name = "pnlNuevaVacuna";
            this.pnlNuevaVacuna.Size = new System.Drawing.Size(927, 130);
            this.pnlNuevaVacuna.TabIndex = 1;
            // 
            // lblTituloNuevaVacuna
            // 
            this.lblTituloNuevaVacuna.AutoSize = true;
            this.lblTituloNuevaVacuna.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloNuevaVacuna.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblTituloNuevaVacuna.Location = new System.Drawing.Point(15, 8);
            this.lblTituloNuevaVacuna.Name = "lblTituloNuevaVacuna";
            this.lblTituloNuevaVacuna.Size = new System.Drawing.Size(201, 19);
            this.lblTituloNuevaVacuna.TabIndex = 0;
            this.lblTituloNuevaVacuna.Text = "💉  Aplicar y Registrar Vacuna";
            // 
            // lblNomVacuna
            // 
            this.lblNomVacuna.AutoSize = true;
            this.lblNomVacuna.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNomVacuna.Location = new System.Drawing.Point(15, 35);
            this.lblNomVacuna.Name = "lblNomVacuna";
            this.lblNomVacuna.Size = new System.Drawing.Size(111, 15);
            this.lblNomVacuna.TabIndex = 1;
            this.lblNomVacuna.Text = "Nombre de Vacuna:";
            // 
            // txtNomVacuna
            // 
            this.txtNomVacuna.BackColor = System.Drawing.Color.White;
            this.txtNomVacuna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomVacuna.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNomVacuna.Location = new System.Drawing.Point(15, 53);
            this.txtNomVacuna.Name = "txtNomVacuna";
            this.txtNomVacuna.Size = new System.Drawing.Size(220, 23);
            this.txtNomVacuna.TabIndex = 2;
            // 
            // lblDosisVacuna
            // 
            this.lblDosisVacuna.AutoSize = true;
            this.lblDosisVacuna.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDosisVacuna.Location = new System.Drawing.Point(250, 35);
            this.lblDosisVacuna.Name = "lblDosisVacuna";
            this.lblDosisVacuna.Size = new System.Drawing.Size(38, 15);
            this.lblDosisVacuna.TabIndex = 3;
            this.lblDosisVacuna.Text = "Dosis:";
            // 
            // txtDosisVacuna
            // 
            this.txtDosisVacuna.BackColor = System.Drawing.Color.White;
            this.txtDosisVacuna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDosisVacuna.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDosisVacuna.Location = new System.Drawing.Point(250, 53);
            this.txtDosisVacuna.Name = "txtDosisVacuna";
            this.txtDosisVacuna.Size = new System.Drawing.Size(160, 23);
            this.txtDosisVacuna.TabIndex = 4;
            this.txtDosisVacuna.Text = "1ra Dosis";
            // 
            // lblLoteVacuna
            // 
            this.lblLoteVacuna.AutoSize = true;
            this.lblLoteVacuna.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblLoteVacuna.Location = new System.Drawing.Point(425, 35);
            this.lblLoteVacuna.Name = "lblLoteVacuna";
            this.lblLoteVacuna.Size = new System.Drawing.Size(33, 15);
            this.lblLoteVacuna.TabIndex = 5;
            this.lblLoteVacuna.Text = "Lote:";
            // 
            // txtLoteVacuna
            // 
            this.txtLoteVacuna.BackColor = System.Drawing.Color.White;
            this.txtLoteVacuna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoteVacuna.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLoteVacuna.Location = new System.Drawing.Point(425, 53);
            this.txtLoteVacuna.Name = "txtLoteVacuna";
            this.txtLoteVacuna.Size = new System.Drawing.Size(150, 23);
            this.txtLoteVacuna.TabIndex = 6;
            // 
            // lblProxVacuna
            // 
            this.lblProxVacuna.AutoSize = true;
            this.lblProxVacuna.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblProxVacuna.Location = new System.Drawing.Point(590, 35);
            this.lblProxVacuna.Name = "lblProxVacuna";
            this.lblProxVacuna.Size = new System.Drawing.Size(84, 15);
            this.lblProxVacuna.TabIndex = 7;
            this.lblProxVacuna.Text = "Próxima Dosis:";
            // 
            // dtpProxVacuna
            // 
            this.dtpProxVacuna.CalendarFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpProxVacuna.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpProxVacuna.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProxVacuna.Location = new System.Drawing.Point(590, 53);
            this.dtpProxVacuna.Name = "dtpProxVacuna";
            this.dtpProxVacuna.Size = new System.Drawing.Size(140, 23);
            this.dtpProxVacuna.TabIndex = 8;
            // 
            // btnGuardarVacuna
            // 
            this.btnGuardarVacuna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnGuardarVacuna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarVacuna.FlatAppearance.BorderSize = 0;
            this.btnGuardarVacuna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarVacuna.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardarVacuna.ForeColor = System.Drawing.Color.White;
            this.btnGuardarVacuna.Location = new System.Drawing.Point(750, 43);
            this.btnGuardarVacuna.Name = "btnGuardarVacuna";
            this.btnGuardarVacuna.Size = new System.Drawing.Size(155, 40);
            this.btnGuardarVacuna.TabIndex = 9;
            this.btnGuardarVacuna.Text = "💾   Registrar Vacuna";
            this.btnGuardarVacuna.UseVisualStyleBackColor = false;
            // 
            // tabDesparasitacion
            // 
            this.tabDesparasitacion.BackColor = System.Drawing.Color.White;
            this.tabDesparasitacion.Controls.Add(this.dgvDesparasitaciones);
            this.tabDesparasitacion.Controls.Add(this.pnlNuevaDesparasitacion);
            this.tabDesparasitacion.Location = new System.Drawing.Point(4, 26);
            this.tabDesparasitacion.Name = "tabDesparasitacion";
            this.tabDesparasitacion.Padding = new System.Windows.Forms.Padding(10);
            this.tabDesparasitacion.Size = new System.Drawing.Size(947, 490);
            this.tabDesparasitacion.TabIndex = 2;
            this.tabDesparasitacion.Text = "💊  Desparasitación";
            // 
            // dgvDesparasitaciones
            // 
            this.dgvDesparasitaciones.AllowUserToAddRows = false;
            this.dgvDesparasitaciones.AllowUserToDeleteRows = false;
            this.dgvDesparasitaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDesparasitaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.dgvDesparasitaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDesparasitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesparasitaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDesparasitaciones.Location = new System.Drawing.Point(10, 10);
            this.dgvDesparasitaciones.Name = "dgvDesparasitaciones";
            this.dgvDesparasitaciones.ReadOnly = true;
            this.dgvDesparasitaciones.RowHeadersVisible = false;
            this.dgvDesparasitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDesparasitaciones.Size = new System.Drawing.Size(927, 340);
            this.dgvDesparasitaciones.TabIndex = 0;
            // 
            // pnlNuevaDesparasitacion
            // 
            this.pnlNuevaDesparasitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
            this.pnlNuevaDesparasitacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNuevaDesparasitacion.Controls.Add(this.lblTituloDesp);
            this.pnlNuevaDesparasitacion.Controls.Add(this.lblTipoDesp);
            this.pnlNuevaDesparasitacion.Controls.Add(this.cmbTipoDesp);
            this.pnlNuevaDesparasitacion.Controls.Add(this.lblProdDesp);
            this.pnlNuevaDesparasitacion.Controls.Add(this.txtProdDesp);
            this.pnlNuevaDesparasitacion.Controls.Add(this.lblPesoDesp);
            this.pnlNuevaDesparasitacion.Controls.Add(this.txtPesoDesp);
            this.pnlNuevaDesparasitacion.Controls.Add(this.lblProxDesp);
            this.pnlNuevaDesparasitacion.Controls.Add(this.dtpProxDesp);
            this.pnlNuevaDesparasitacion.Controls.Add(this.btnGuardarDesp);
            this.pnlNuevaDesparasitacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNuevaDesparasitacion.Location = new System.Drawing.Point(10, 350);
            this.pnlNuevaDesparasitacion.Name = "pnlNuevaDesparasitacion";
            this.pnlNuevaDesparasitacion.Size = new System.Drawing.Size(927, 130);
            this.pnlNuevaDesparasitacion.TabIndex = 1;
            // 
            // lblTituloDesp
            // 
            this.lblTituloDesp.AutoSize = true;
            this.lblTituloDesp.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloDesp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblTituloDesp.Location = new System.Drawing.Point(15, 8);
            this.lblTituloDesp.Name = "lblTituloDesp";
            this.lblTituloDesp.Size = new System.Drawing.Size(196, 19);
            this.lblTituloDesp.TabIndex = 0;
            this.lblTituloDesp.Text = "💊  Registrar Desparasitación";
            // 
            // lblTipoDesp
            // 
            this.lblTipoDesp.AutoSize = true;
            this.lblTipoDesp.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTipoDesp.Location = new System.Drawing.Point(15, 35);
            this.lblTipoDesp.Name = "lblTipoDesp";
            this.lblTipoDesp.Size = new System.Drawing.Size(34, 15);
            this.lblTipoDesp.TabIndex = 1;
            this.lblTipoDesp.Text = "Tipo:";
            // 
            // cmbTipoDesp
            // 
            this.cmbTipoDesp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDesp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbTipoDesp.FormattingEnabled = true;
            this.cmbTipoDesp.Items.AddRange(new object[] {
            "Pipeta interna",
            "Pipeta externa",
            "Oral (Pastilla)",
            "Inyectable"});
            this.cmbTipoDesp.Location = new System.Drawing.Point(15, 53);
            this.cmbTipoDesp.Name = "cmbTipoDesp";
            this.cmbTipoDesp.Size = new System.Drawing.Size(180, 23);
            this.cmbTipoDesp.TabIndex = 2;
            // 
            // lblProdDesp
            // 
            this.lblProdDesp.AutoSize = true;
            this.lblProdDesp.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblProdDesp.Location = new System.Drawing.Point(210, 35);
            this.lblProdDesp.Name = "lblProdDesp";
            this.lblProdDesp.Size = new System.Drawing.Size(59, 15);
            this.lblProdDesp.TabIndex = 3;
            this.lblProdDesp.Text = "Producto:";
            // 
            // txtProdDesp
            // 
            this.txtProdDesp.BackColor = System.Drawing.Color.White;
            this.txtProdDesp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdDesp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProdDesp.Location = new System.Drawing.Point(210, 53);
            this.txtProdDesp.Name = "txtProdDesp";
            this.txtProdDesp.Size = new System.Drawing.Size(200, 23);
            this.txtProdDesp.TabIndex = 4;
            // 
            // lblPesoDesp
            // 
            this.lblPesoDesp.AutoSize = true;
            this.lblPesoDesp.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPesoDesp.Location = new System.Drawing.Point(425, 35);
            this.lblPesoDesp.Name = "lblPesoDesp";
            this.lblPesoDesp.Size = new System.Drawing.Size(89, 15);
            this.lblPesoDesp.TabIndex = 5;
            this.lblPesoDesp.Text = "Peso (ej. 22 kg):";
            // 
            // txtPesoDesp
            // 
            this.txtPesoDesp.BackColor = System.Drawing.Color.White;
            this.txtPesoDesp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesoDesp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPesoDesp.Location = new System.Drawing.Point(425, 53);
            this.txtPesoDesp.Name = "txtPesoDesp";
            this.txtPesoDesp.Size = new System.Drawing.Size(140, 23);
            this.txtPesoDesp.TabIndex = 6;
            // 
            // lblProxDesp
            // 
            this.lblProxDesp.AutoSize = true;
            this.lblProxDesp.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblProxDesp.Location = new System.Drawing.Point(580, 35);
            this.lblProxDesp.Name = "lblProxDesp";
            this.lblProxDesp.Size = new System.Drawing.Size(84, 15);
            this.lblProxDesp.TabIndex = 7;
            this.lblProxDesp.Text = "Próxima Dosis:";
            // 
            // dtpProxDesp
            // 
            this.dtpProxDesp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpProxDesp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProxDesp.Location = new System.Drawing.Point(580, 53);
            this.dtpProxDesp.Name = "dtpProxDesp";
            this.dtpProxDesp.Size = new System.Drawing.Size(140, 23);
            this.dtpProxDesp.TabIndex = 8;
            // 
            // btnGuardarDesp
            // 
            this.btnGuardarDesp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnGuardarDesp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarDesp.FlatAppearance.BorderSize = 0;
            this.btnGuardarDesp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarDesp.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardarDesp.ForeColor = System.Drawing.Color.White;
            this.btnGuardarDesp.Location = new System.Drawing.Point(740, 43);
            this.btnGuardarDesp.Name = "btnGuardarDesp";
            this.btnGuardarDesp.Size = new System.Drawing.Size(165, 40);
            this.btnGuardarDesp.TabIndex = 9;
            this.btnGuardarDesp.Text = "💾   Registrar";
            this.btnGuardarDesp.UseVisualStyleBackColor = false;
            // 
            // tabMedicamentos
            // 
            this.tabMedicamentos.BackColor = System.Drawing.Color.White;
            this.tabMedicamentos.Controls.Add(this.dgvTratamientos);
            this.tabMedicamentos.Controls.Add(this.pnlNuevoTratamiento);
            this.tabMedicamentos.Location = new System.Drawing.Point(4, 26);
            this.tabMedicamentos.Name = "tabMedicamentos";
            this.tabMedicamentos.Padding = new System.Windows.Forms.Padding(10);
            this.tabMedicamentos.Size = new System.Drawing.Size(947, 490);
            this.tabMedicamentos.TabIndex = 3;
            this.tabMedicamentos.Text = "🩺  Medicamentos";
            // 
            // dgvTratamientos
            // 
            this.dgvTratamientos.AllowUserToAddRows = false;
            this.dgvTratamientos.AllowUserToDeleteRows = false;
            this.dgvTratamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTratamientos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.dgvTratamientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTratamientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTratamientos.Location = new System.Drawing.Point(10, 10);
            this.dgvTratamientos.Name = "dgvTratamientos";
            this.dgvTratamientos.ReadOnly = true;
            this.dgvTratamientos.RowHeadersVisible = false;
            this.dgvTratamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTratamientos.Size = new System.Drawing.Size(927, 340);
            this.dgvTratamientos.TabIndex = 0;
            // 
            // pnlNuevoTratamiento
            // 
            this.pnlNuevoTratamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
            this.pnlNuevoTratamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNuevoTratamiento.Controls.Add(this.lblTituloTrat);
            this.pnlNuevoTratamiento.Controls.Add(this.lblMedTrat);
            this.pnlNuevoTratamiento.Controls.Add(this.txtMedTrat);
            this.pnlNuevoTratamiento.Controls.Add(this.lblIndicacionesTrat);
            this.pnlNuevoTratamiento.Controls.Add(this.txtIndicacionesTrat);
            this.pnlNuevoTratamiento.Controls.Add(this.lblFechaFinTrat);
            this.pnlNuevoTratamiento.Controls.Add(this.dtpFinTrat);
            this.pnlNuevoTratamiento.Controls.Add(this.btnGuardarTratamiento);
            this.pnlNuevoTratamiento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNuevoTratamiento.Location = new System.Drawing.Point(10, 350);
            this.pnlNuevoTratamiento.Name = "pnlNuevoTratamiento";
            this.pnlNuevoTratamiento.Size = new System.Drawing.Size(927, 130);
            this.pnlNuevoTratamiento.TabIndex = 1;
            // 
            // lblTituloTrat
            // 
            this.lblTituloTrat.AutoSize = true;
            this.lblTituloTrat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloTrat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblTituloTrat.Location = new System.Drawing.Point(15, 8);
            this.lblTituloTrat.Name = "lblTituloTrat";
            this.lblTituloTrat.Size = new System.Drawing.Size(275, 19);
            this.lblTituloTrat.TabIndex = 0;
            this.lblTituloTrat.Text = "🩺  Prescribir Medicamento / Tratamiento";
            // 
            // lblMedTrat
            // 
            this.lblMedTrat.AutoSize = true;
            this.lblMedTrat.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblMedTrat.Location = new System.Drawing.Point(15, 35);
            this.lblMedTrat.Name = "lblMedTrat";
            this.lblMedTrat.Size = new System.Drawing.Size(159, 15);
            this.lblMedTrat.TabIndex = 1;
            this.lblMedTrat.Text = "Medicamento / Tratamiento:";
            // 
            // txtMedTrat
            // 
            this.txtMedTrat.BackColor = System.Drawing.Color.White;
            this.txtMedTrat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMedTrat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMedTrat.Location = new System.Drawing.Point(15, 53);
            this.txtMedTrat.Name = "txtMedTrat";
            this.txtMedTrat.Size = new System.Drawing.Size(250, 23);
            this.txtMedTrat.TabIndex = 2;
            // 
            // lblIndicacionesTrat
            // 
            this.lblIndicacionesTrat.AutoSize = true;
            this.lblIndicacionesTrat.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblIndicacionesTrat.Location = new System.Drawing.Point(280, 35);
            this.lblIndicacionesTrat.Name = "lblIndicacionesTrat";
            this.lblIndicacionesTrat.Size = new System.Drawing.Size(127, 15);
            this.lblIndicacionesTrat.TabIndex = 3;
            this.lblIndicacionesTrat.Text = "Indicaciones / Horario:";
            // 
            // txtIndicacionesTrat
            // 
            this.txtIndicacionesTrat.BackColor = System.Drawing.Color.White;
            this.txtIndicacionesTrat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIndicacionesTrat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIndicacionesTrat.Location = new System.Drawing.Point(280, 53);
            this.txtIndicacionesTrat.Name = "txtIndicacionesTrat";
            this.txtIndicacionesTrat.Size = new System.Drawing.Size(290, 23);
            this.txtIndicacionesTrat.TabIndex = 4;
            // 
            // lblFechaFinTrat
            // 
            this.lblFechaFinTrat.AutoSize = true;
            this.lblFechaFinTrat.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFechaFinTrat.Location = new System.Drawing.Point(585, 35);
            this.lblFechaFinTrat.Name = "lblFechaFinTrat";
            this.lblFechaFinTrat.Size = new System.Drawing.Size(77, 15);
            this.lblFechaFinTrat.TabIndex = 5;
            this.lblFechaFinTrat.Text = "Fecha Límite:";
            // 
            // dtpFinTrat
            // 
            this.dtpFinTrat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFinTrat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinTrat.Location = new System.Drawing.Point(585, 53);
            this.dtpFinTrat.Name = "dtpFinTrat";
            this.dtpFinTrat.Size = new System.Drawing.Size(140, 23);
            this.dtpFinTrat.TabIndex = 6;
            // 
            // btnGuardarTratamiento
            // 
            this.btnGuardarTratamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnGuardarTratamiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarTratamiento.FlatAppearance.BorderSize = 0;
            this.btnGuardarTratamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarTratamiento.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardarTratamiento.ForeColor = System.Drawing.Color.White;
            this.btnGuardarTratamiento.Location = new System.Drawing.Point(745, 43);
            this.btnGuardarTratamiento.Name = "btnGuardarTratamiento";
            this.btnGuardarTratamiento.Size = new System.Drawing.Size(160, 40);
            this.btnGuardarTratamiento.TabIndex = 7;
            this.btnGuardarTratamiento.Text = "💾   Guardar";
            this.btnGuardarTratamiento.UseVisualStyleBackColor = false;
            // 
            // tabAgendarCita
            // 
            this.tabAgendarCita.BackColor = System.Drawing.Color.White;
            this.tabAgendarCita.Controls.Add(this.pnlFormCita);
            this.tabAgendarCita.Controls.Add(this.lblTituloListaCitas);
            this.tabAgendarCita.Controls.Add(this.dgvCitasProgramadas);
            this.tabAgendarCita.Location = new System.Drawing.Point(4, 26);
            this.tabAgendarCita.Name = "tabAgendarCita";
            this.tabAgendarCita.Padding = new System.Windows.Forms.Padding(10);
            this.tabAgendarCita.Size = new System.Drawing.Size(947, 490);
            this.tabAgendarCita.TabIndex = 4;
            this.tabAgendarCita.Text = "📅  Agendar Cita";
            // 
            // pnlFormCita
            // 
            this.pnlFormCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
            this.pnlFormCita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormCita.Controls.Add(this.lblTituloAgendarCita);
            this.pnlFormCita.Controls.Add(this.lblVeterinarioCita);
            this.pnlFormCita.Controls.Add(this.cmbVeterinarioCita);
            this.pnlFormCita.Controls.Add(this.lblFechaCita);
            this.pnlFormCita.Controls.Add(this.dtpFechaCita);
            this.pnlFormCita.Controls.Add(this.lblHoraCita);
            this.pnlFormCita.Controls.Add(this.cmbHoraCita);
            this.pnlFormCita.Controls.Add(this.btnAgendarCita);
            this.pnlFormCita.Controls.Add(this.lblMotivoCita);
            this.pnlFormCita.Controls.Add(this.txtMotivoCita);
            this.pnlFormCita.Location = new System.Drawing.Point(15, 10);
            this.pnlFormCita.Name = "pnlFormCita";
            this.pnlFormCita.Size = new System.Drawing.Size(915, 185);
            this.pnlFormCita.TabIndex = 0;
            // 
            // lblTituloAgendarCita
            // 
            this.lblTituloAgendarCita.AutoSize = true;
            this.lblTituloAgendarCita.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloAgendarCita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblTituloAgendarCita.Location = new System.Drawing.Point(15, 8);
            this.lblTituloAgendarCita.Name = "lblTituloAgendarCita";
            this.lblTituloAgendarCita.Size = new System.Drawing.Size(275, 21);
            this.lblTituloAgendarCita.TabIndex = 0;
            this.lblTituloAgendarCita.Text = "📅   Programar Próxima Cita Médica";
            // 
            // lblVeterinarioCita
            // 
            this.lblVeterinarioCita.AutoSize = true;
            this.lblVeterinarioCita.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblVeterinarioCita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(65)))));
            this.lblVeterinarioCita.Location = new System.Drawing.Point(15, 33);
            this.lblVeterinarioCita.Name = "lblVeterinarioCita";
            this.lblVeterinarioCita.Size = new System.Drawing.Size(179, 15);
            this.lblVeterinarioCita.TabIndex = 1;
            this.lblVeterinarioCita.Text = "Médico de Preferencia / General:";
            // 
            // cmbVeterinarioCita
            // 
            this.cmbVeterinarioCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVeterinarioCita.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbVeterinarioCita.FormattingEnabled = true;
            this.cmbVeterinarioCita.Location = new System.Drawing.Point(15, 52);
            this.cmbVeterinarioCita.Name = "cmbVeterinarioCita";
            this.cmbVeterinarioCita.Size = new System.Drawing.Size(240, 25);
            this.cmbVeterinarioCita.TabIndex = 2;
            // 
            // lblFechaCita
            // 
            this.lblFechaCita.AutoSize = true;
            this.lblFechaCita.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFechaCita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(65)))));
            this.lblFechaCita.Location = new System.Drawing.Point(265, 33);
            this.lblFechaCita.Name = "lblFechaCita";
            this.lblFechaCita.Size = new System.Drawing.Size(96, 15);
            this.lblFechaCita.TabIndex = 3;
            this.lblFechaCita.Text = "Fecha (Lun-Sáb):";
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCita.Location = new System.Drawing.Point(265, 52);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(140, 24);
            this.dtpFechaCita.TabIndex = 4;
            // 
            // lblHoraCita
            // 
            this.lblHoraCita.AutoSize = true;
            this.lblHoraCita.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblHoraCita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(65)))));
            this.lblHoraCita.Location = new System.Drawing.Point(415, 33);
            this.lblHoraCita.Name = "lblHoraCita";
            this.lblHoraCita.Size = new System.Drawing.Size(158, 15);
            this.lblHoraCita.TabIndex = 5;
            this.lblHoraCita.Text = "Franjas Horarias Disponibles:";
            // 
            // cmbHoraCita
            // 
            this.cmbHoraCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoraCita.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbHoraCita.FormattingEnabled = true;
            this.cmbHoraCita.Location = new System.Drawing.Point(415, 52);
            this.cmbHoraCita.Name = "cmbHoraCita";
            this.cmbHoraCita.Size = new System.Drawing.Size(260, 25);
            this.cmbHoraCita.TabIndex = 6;
            // 
            // btnAgendarCita
            // 
            this.btnAgendarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnAgendarCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgendarCita.FlatAppearance.BorderSize = 0;
            this.btnAgendarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendarCita.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAgendarCita.ForeColor = System.Drawing.Color.White;
            this.btnAgendarCita.Location = new System.Drawing.Point(685, 48);
            this.btnAgendarCita.Name = "btnAgendarCita";
            this.btnAgendarCita.Size = new System.Drawing.Size(215, 32);
            this.btnAgendarCita.TabIndex = 7;
            this.btnAgendarCita.Text = "📅  Confirmar y Agendar";
            this.btnAgendarCita.UseVisualStyleBackColor = false;
            // 
            // lblMotivoCita
            // 
            this.lblMotivoCita.AutoSize = true;
            this.lblMotivoCita.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblMotivoCita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(65)))));
            this.lblMotivoCita.Location = new System.Drawing.Point(15, 87);
            this.lblMotivoCita.Name = "lblMotivoCita";
            this.lblMotivoCita.Size = new System.Drawing.Size(126, 15);
            this.lblMotivoCita.TabIndex = 8;
            this.lblMotivoCita.Text = "Motivo de la Consulta:";
            // 
            // txtMotivoCita
            // 
            this.txtMotivoCita.BackColor = System.Drawing.Color.White;
            this.txtMotivoCita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotivoCita.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMotivoCita.Location = new System.Drawing.Point(15, 107);
            this.txtMotivoCita.Multiline = true;
            this.txtMotivoCita.Name = "txtMotivoCita";
            this.txtMotivoCita.Size = new System.Drawing.Size(885, 65);
            this.txtMotivoCita.TabIndex = 9;
            // 
            // lblTituloListaCitas
            // 
            this.lblTituloListaCitas.AutoSize = true;
            this.lblTituloListaCitas.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloListaCitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblTituloListaCitas.Location = new System.Drawing.Point(15, 203);
            this.lblTituloListaCitas.Name = "lblTituloListaCitas";
            this.lblTituloListaCitas.Size = new System.Drawing.Size(444, 19);
            this.lblTituloListaCitas.TabIndex = 1;
            this.lblTituloListaCitas.Text = "📋   Lista de Citas Programadas — (Permite Cancelar / Liberar Cupo):";
            // 
            // dgvCitasProgramadas
            // 
            this.dgvCitasProgramadas.AllowUserToAddRows = false;
            this.dgvCitasProgramadas.AllowUserToDeleteRows = false;
            this.dgvCitasProgramadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCitasProgramadas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.dgvCitasProgramadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCitasProgramadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitasProgramadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCitaFecha,
            this.colCitaHora,
            this.colCitaMascota,
            this.colCitaVet,
            this.colCitaMotivo,
            this.colCitaEstado,
            this.colCitaAccion});
            this.dgvCitasProgramadas.Location = new System.Drawing.Point(15, 227);
            this.dgvCitasProgramadas.Name = "dgvCitasProgramadas";
            this.dgvCitasProgramadas.ReadOnly = true;
            this.dgvCitasProgramadas.RowHeadersVisible = false;
            this.dgvCitasProgramadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCitasProgramadas.Size = new System.Drawing.Size(915, 250);
            this.dgvCitasProgramadas.TabIndex = 2;
            // 
            // colCitaFecha
            // 
            this.colCitaFecha.FillWeight = 75F;
            this.colCitaFecha.HeaderText = "Fecha";
            this.colCitaFecha.Name = "colCitaFecha";
            this.colCitaFecha.ReadOnly = true;
            // 
            // colCitaHora
            // 
            this.colCitaHora.FillWeight = 70F;
            this.colCitaHora.HeaderText = "Hora";
            this.colCitaHora.Name = "colCitaHora";
            this.colCitaHora.ReadOnly = true;
            // 
            // colCitaMascota
            // 
            this.colCitaMascota.FillWeight = 85F;
            this.colCitaMascota.HeaderText = "Mascota";
            this.colCitaMascota.Name = "colCitaMascota";
            this.colCitaMascota.ReadOnly = true;
            // 
            // colCitaVet
            // 
            this.colCitaVet.FillWeight = 110F;
            this.colCitaVet.HeaderText = "Veterinario";
            this.colCitaVet.Name = "colCitaVet";
            this.colCitaVet.ReadOnly = true;
            // 
            // colCitaMotivo
            // 
            this.colCitaMotivo.FillWeight = 150F;
            this.colCitaMotivo.HeaderText = "Motivo Consulta";
            this.colCitaMotivo.Name = "colCitaMotivo";
            this.colCitaMotivo.ReadOnly = true;
            // 
            // colCitaEstado
            // 
            this.colCitaEstado.FillWeight = 75F;
            this.colCitaEstado.HeaderText = "Estado";
            this.colCitaEstado.Name = "colCitaEstado";
            this.colCitaEstado.ReadOnly = true;
            // 
            // colCitaAccion
            // 
            this.colCitaAccion.FillWeight = 80F;
            this.colCitaAccion.HeaderText = "Acción";
            this.colCitaAccion.Name = "colCitaAccion";
            this.colCitaAccion.ReadOnly = true;
            this.colCitaAccion.Text = "❌ Cancelar";
            this.colCitaAccion.UseColumnTextForButtonValue = true;
            // 
            // pnlResumenInferior
            // 
            this.pnlResumenInferior.Controls.Add(this.cardResumenVacunas);
            this.pnlResumenInferior.Controls.Add(this.cardResumenDesp);
            this.pnlResumenInferior.Controls.Add(this.cardResumenMed);
            this.pnlResumenInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlResumenInferior.Location = new System.Drawing.Point(0, 520);
            this.pnlResumenInferior.Name = "pnlResumenInferior";
            this.pnlResumenInferior.Size = new System.Drawing.Size(955, 130);
            this.pnlResumenInferior.TabIndex = 1;
            // 
            // cardResumenVacunas
            // 
            this.cardResumenVacunas.BackColor = System.Drawing.Color.White;
            this.cardResumenVacunas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardResumenVacunas.Controls.Add(this.lblTitResumenVacunas);
            this.cardResumenVacunas.Controls.Add(this.lblTextoResumenVacunas);
            this.cardResumenVacunas.Location = new System.Drawing.Point(5, 10);
            this.cardResumenVacunas.Name = "cardResumenVacunas";
            this.cardResumenVacunas.Size = new System.Drawing.Size(305, 110);
            this.cardResumenVacunas.TabIndex = 0;
            // 
            // lblTitResumenVacunas
            // 
            this.lblTitResumenVacunas.AutoSize = true;
            this.lblTitResumenVacunas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTitResumenVacunas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblTitResumenVacunas.Location = new System.Drawing.Point(10, 8);
            this.lblTitResumenVacunas.Name = "lblTitResumenVacunas";
            this.lblTitResumenVacunas.Size = new System.Drawing.Size(133, 17);
            this.lblTitResumenVacunas.TabIndex = 0;
            this.lblTitResumenVacunas.Text = "💉  Últimas Vacunas";
            // 
            // lblTextoResumenVacunas
            // 
            this.lblTextoResumenVacunas.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTextoResumenVacunas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.lblTextoResumenVacunas.Location = new System.Drawing.Point(10, 30);
            this.lblTextoResumenVacunas.Name = "lblTextoResumenVacunas";
            this.lblTextoResumenVacunas.Size = new System.Drawing.Size(285, 70);
            this.lblTextoResumenVacunas.TabIndex = 1;
            this.lblTextoResumenVacunas.Text = "• Antirrábica - 15/05/2025\r\n• Séxtuple - 15/05/2025";
            // 
            // cardResumenDesp
            // 
            this.cardResumenDesp.BackColor = System.Drawing.Color.White;
            this.cardResumenDesp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardResumenDesp.Controls.Add(this.lblTitResumenDesp);
            this.cardResumenDesp.Controls.Add(this.lblTextoResumenDesp);
            this.cardResumenDesp.Location = new System.Drawing.Point(325, 10);
            this.cardResumenDesp.Name = "cardResumenDesp";
            this.cardResumenDesp.Size = new System.Drawing.Size(305, 110);
            this.cardResumenDesp.TabIndex = 1;
            // 
            // lblTitResumenDesp
            // 
            this.lblTitResumenDesp.AutoSize = true;
            this.lblTitResumenDesp.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTitResumenDesp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblTitResumenDesp.Location = new System.Drawing.Point(10, 8);
            this.lblTitResumenDesp.Name = "lblTitResumenDesp";
            this.lblTitResumenDesp.Size = new System.Drawing.Size(173, 17);
            this.lblTitResumenDesp.TabIndex = 0;
            this.lblTitResumenDesp.Text = "💊  Última Desparasitación";
            // 
            // lblTextoResumenDesp
            // 
            this.lblTextoResumenDesp.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTextoResumenDesp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.lblTextoResumenDesp.Location = new System.Drawing.Point(10, 30);
            this.lblTextoResumenDesp.Name = "lblTextoResumenDesp";
            this.lblTextoResumenDesp.Size = new System.Drawing.Size(285, 70);
            this.lblTextoResumenDesp.TabIndex = 1;
            this.lblTextoResumenDesp.Text = "• Pipeta interna (Bravecto Plus)\r\n  Fecha: 20/08/2025\r\n  Peso: 22 kg";
            // 
            // cardResumenMed
            // 
            this.cardResumenMed.BackColor = System.Drawing.Color.White;
            this.cardResumenMed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardResumenMed.Controls.Add(this.lblTitResumenMed);
            this.cardResumenMed.Controls.Add(this.lblTextoResumenMed);
            this.cardResumenMed.Location = new System.Drawing.Point(645, 10);
            this.cardResumenMed.Name = "cardResumenMed";
            this.cardResumenMed.Size = new System.Drawing.Size(305, 110);
            this.cardResumenMed.TabIndex = 2;
            // 
            // lblTitResumenMed
            // 
            this.lblTitResumenMed.AutoSize = true;
            this.lblTitResumenMed.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTitResumenMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblTitResumenMed.Location = new System.Drawing.Point(10, 8);
            this.lblTitResumenMed.Name = "lblTitResumenMed";
            this.lblTitResumenMed.Size = new System.Drawing.Size(174, 17);
            this.lblTitResumenMed.TabIndex = 0;
            this.lblTitResumenMed.Text = "🩺  Últimos Medicamentos";
            // 
            // lblTextoResumenMed
            // 
            this.lblTextoResumenMed.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTextoResumenMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.lblTextoResumenMed.Location = new System.Drawing.Point(10, 30);
            this.lblTextoResumenMed.Name = "lblTextoResumenMed";
            this.lblTextoResumenMed.Size = new System.Drawing.Size(285, 70);
            this.lblTextoResumenMed.TabIndex = 1;
            this.lblTextoResumenMed.Text = "• Amoxicilina 250 mg c/12h\r\n  Fecha: 12/11/2025";
            // 
            // FrmAtencionMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1264, 741);
            this.Controls.Add(this.pnlContenidoPestanas);
            this.Controls.Add(this.pnlFichaMascota);
            this.Controls.Add(this.pnlTopBar);
            this.MinimumSize = new System.Drawing.Size(1200, 750);
            this.Name = "FrmAtencionMedica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Huellitas Veterinaria - Ficha y Atención Médica";
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlFichaMascota.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMascota)).EndInit();
            this.pnlCitaCard.ResumeLayout(false);
            this.pnlCitaCard.PerformLayout();
            this.pnlObsCard.ResumeLayout(false);
            this.pnlObsCard.PerformLayout();
            this.pnlContenidoPestanas.ResumeLayout(false);
            this.tabModulos.ResumeLayout(false);
            this.tabHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.pnlNuevaConsulta.ResumeLayout(false);
            this.pnlNuevaConsulta.PerformLayout();
            this.tabVacunas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacunas)).EndInit();
            this.pnlNuevaVacuna.ResumeLayout(false);
            this.pnlNuevaVacuna.PerformLayout();
            this.tabDesparasitacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesparasitaciones)).EndInit();
            this.pnlNuevaDesparasitacion.ResumeLayout(false);
            this.pnlNuevaDesparasitacion.PerformLayout();
            this.tabMedicamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamientos)).EndInit();
            this.pnlNuevoTratamiento.ResumeLayout(false);
            this.pnlNuevoTratamiento.PerformLayout();
            this.tabAgendarCita.ResumeLayout(false);
            this.tabAgendarCita.PerformLayout();
            this.pnlFormCita.ResumeLayout(false);
            this.pnlFormCita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitasProgramadas)).EndInit();
            this.pnlResumenInferior.ResumeLayout(false);
            this.cardResumenVacunas.ResumeLayout(false);
            this.cardResumenVacunas.PerformLayout();
            this.cardResumenDesp.ResumeLayout(false);
            this.cardResumenDesp.PerformLayout();
            this.cardResumenMed.ResumeLayout(false);
            this.cardResumenMed.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTituloModulo;
        private System.Windows.Forms.Label lblCarneLabel;
        private System.Windows.Forms.TextBox txtBuscarCarne;
        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Label lblCedulaLabel;
        private System.Windows.Forms.TextBox txtBuscarCedula;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.Panel pnlFichaMascota;
        private System.Windows.Forms.PictureBox picMascota;
        private System.Windows.Forms.Label lblIdBadge;
        private System.Windows.Forms.Label lblNombreMascota;
        private System.Windows.Forms.Label lblEdadMascota;
        private System.Windows.Forms.Label lblEspecieMascota;
        private System.Windows.Forms.Label lblRazaMascota;
        private System.Windows.Forms.Label lblSexoMascota;
        private System.Windows.Forms.Label lblEstadoSalud;
        private System.Windows.Forms.Panel pnlCitaCard;
        private System.Windows.Forms.Label lblTituloCitaCard;
        private System.Windows.Forms.Label lblDetalleCitaCard;
        private System.Windows.Forms.Button btnCancelarCita;
        private System.Windows.Forms.Panel pnlObsCard;
        private System.Windows.Forms.Label lblTituloObsCard;
        private System.Windows.Forms.Label lblTextoObsCard;
        private System.Windows.Forms.Panel pnlContenidoPestanas;
        private System.Windows.Forms.TabControl tabModulos;
        private System.Windows.Forms.TabPage tabHistorial;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Panel pnlNuevaConsulta;
        private System.Windows.Forms.Label lblTituloNuevaConsulta;
        private System.Windows.Forms.Label lblDiag;
        private System.Windows.Forms.TextBox txtDiag;
        private System.Windows.Forms.Label lblTrat;
        private System.Windows.Forms.TextBox txtTrat;
        private System.Windows.Forms.Label lblMed;
        private System.Windows.Forms.TextBox txtMed;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Button btnAgregarConsulta;
        private System.Windows.Forms.TabPage tabVacunas;
        private System.Windows.Forms.DataGridView dgvVacunas;
        private System.Windows.Forms.Panel pnlNuevaVacuna;
        private System.Windows.Forms.Label lblTituloNuevaVacuna;
        private System.Windows.Forms.Label lblNomVacuna;
        private System.Windows.Forms.TextBox txtNomVacuna;
        private System.Windows.Forms.Label lblDosisVacuna;
        private System.Windows.Forms.TextBox txtDosisVacuna;
        private System.Windows.Forms.Label lblLoteVacuna;
        private System.Windows.Forms.TextBox txtLoteVacuna;
        private System.Windows.Forms.Label lblProxVacuna;
        private System.Windows.Forms.DateTimePicker dtpProxVacuna;
        private System.Windows.Forms.Button btnGuardarVacuna;
        private System.Windows.Forms.TabPage tabDesparasitacion;
        private System.Windows.Forms.DataGridView dgvDesparasitaciones;
        private System.Windows.Forms.Panel pnlNuevaDesparasitacion;
        private System.Windows.Forms.Label lblTituloDesp;
        private System.Windows.Forms.Label lblTipoDesp;
        private System.Windows.Forms.ComboBox cmbTipoDesp;
        private System.Windows.Forms.Label lblProdDesp;
        private System.Windows.Forms.TextBox txtProdDesp;
        private System.Windows.Forms.Label lblPesoDesp;
        private System.Windows.Forms.TextBox txtPesoDesp;
        private System.Windows.Forms.Label lblProxDesp;
        private System.Windows.Forms.DateTimePicker dtpProxDesp;
        private System.Windows.Forms.Button btnGuardarDesp;
        private System.Windows.Forms.TabPage tabMedicamentos;
        private System.Windows.Forms.DataGridView dgvTratamientos;
        private System.Windows.Forms.Panel pnlNuevoTratamiento;
        private System.Windows.Forms.Label lblTituloTrat;
        private System.Windows.Forms.Label lblMedTrat;
        private System.Windows.Forms.TextBox txtMedTrat;
        private System.Windows.Forms.Label lblIndicacionesTrat;
        private System.Windows.Forms.TextBox txtIndicacionesTrat;
        private System.Windows.Forms.Label lblFechaFinTrat;
        private System.Windows.Forms.DateTimePicker dtpFinTrat;
        private System.Windows.Forms.Button btnGuardarTratamiento;
        private System.Windows.Forms.TabPage tabAgendarCita;
        private System.Windows.Forms.Panel pnlFormCita;
        private System.Windows.Forms.Label lblTituloAgendarCita;
        private System.Windows.Forms.Label lblFechaCita;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.Label lblHoraCita;
        private System.Windows.Forms.ComboBox cmbHoraCita;
        private System.Windows.Forms.Label lblMotivoCita;
        private System.Windows.Forms.TextBox txtMotivoCita;
        private System.Windows.Forms.Button btnAgendarCita;
        private System.Windows.Forms.Panel pnlResumenInferior;
        private System.Windows.Forms.Panel cardResumenVacunas;
        private System.Windows.Forms.Label lblTitResumenVacunas;
        private System.Windows.Forms.Label lblTextoResumenVacunas;
        private System.Windows.Forms.Panel cardResumenDesp;
        private System.Windows.Forms.Label lblTitResumenDesp;
        private System.Windows.Forms.Label lblTextoResumenDesp;
        private System.Windows.Forms.Panel cardResumenMed;
        private System.Windows.Forms.Label lblTitResumenMed;
        private System.Windows.Forms.Label lblTextoResumenMed;
        private System.Windows.Forms.Label lblOtrasMascotas;
        private System.Windows.Forms.ComboBox cmbOtrasMascotas;
        private System.Windows.Forms.Label lblMascotaDueno;
        private System.Windows.Forms.ComboBox cmbMascotasDueno;
        private System.Windows.Forms.Label lblVeterinarioCita;
        private System.Windows.Forms.ComboBox cmbVeterinarioCita;
        private System.Windows.Forms.Label lblTituloListaCitas;
        private System.Windows.Forms.DataGridView dgvCitasProgramadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCitaFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCitaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCitaMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCitaVet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCitaMotivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCitaEstado;
        private System.Windows.Forms.DataGridViewButtonColumn colCitaAccion;
    }
}
