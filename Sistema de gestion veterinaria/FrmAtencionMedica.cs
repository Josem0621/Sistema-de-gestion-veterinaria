using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_de_gestion_veterinaria
{
    public partial class FrmAtencionMedica : Form
    {
        private Mascota _mascotaActual;
        public bool ModoDueno { get; set; } = false;
        public string IdCitaAtendiendo { get; set; } = null;
        private int _pestanaInicial = 0;
        private bool _busquedaPorCedula = false;
        private bool _actualizandoCombo = false;

        public FrmAtencionMedica()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        public FrmAtencionMedica(Mascota mascota, bool esModoDueno = false, string idCita = null, int pestanaInicial = 0, bool esBusquedaPorCedula = false) : this()
        {
            ModoDueno = esModoDueno;
            IdCitaAtendiendo = idCita;
            _pestanaInicial = pestanaInicial;
            _busquedaPorCedula = esBusquedaPorCedula;
            ConfigurarModoVista();
            if (mascota != null)
            {
                CargarFichaMascota(mascota);
            }
        }

        private void ConfigurarFormulario()
        {
            try
            {
                string iconPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "app.ico");
                if (File.Exists(iconPath)) this.Icon = new Icon(iconPath);
            }
            catch { }

            // Configurar columnas de DataGridViews
            ConfigurarGrillas();

            // Configurar valores por defecto
            if (cmbTipoDesp.Items.Count > 0) cmbTipoDesp.SelectedIndex = 0;

            // Poblar médicos en cmbVeterinarioCita
            cmbVeterinarioCita.Items.Clear();
            cmbVeterinarioCita.Items.Add("Cualquier médico disponible (General)");
            foreach (var vet in GestorDatos.Datos.Veterinarios)
            {
                cmbVeterinarioCita.Items.Add(vet.NombreCompleto);
            }
            if (cmbVeterinarioCita.Items.Count > 0) cmbVeterinarioCita.SelectedIndex = 0;

            dtpFechaCita.MinDate = DateTime.Today;
            dtpFechaCita.Value = DateTime.Today;
            dtpFechaCita.ValueChanged += (s, e) => ActualizarFranjasHorarias();
            cmbVeterinarioCita.SelectedIndexChanged += (s, e) => ActualizarFranjasHorarias();

            // Eventos de botones
            btnBuscar.Click += BtnBuscar_Click;
            btnVolverMenu.Click += (s, e) => { GestorDatos.ReproducirSonido("click"); this.Close(); };
            btnAgregarConsulta.Click += BtnAgregarConsulta_Click;
            btnGuardarVacuna.Click += BtnGuardarVacuna_Click;
            btnGuardarDesp.Click += BtnGuardarDesp_Click;
            btnGuardarTratamiento.Click += BtnGuardarTratamiento_Click;
            btnAgendarCita.Click += BtnAgendarCita_Click;
            btnCancelarCita.Click += BtnCancelarCita_Click;

            // Eventos para selectores de mascotas
            cmbMascotasDueno.SelectedIndexChanged += CmbMascotasDueno_SelectedIndexChanged;
            cmbOtrasMascotas.SelectedIndexChanged += CmbOtrasMascotas_SelectedIndexChanged;

            // Grilla de citas programadas
            dgvCitasProgramadas.CellContentClick += DgvCitasProgramadas_CellContentClick;

            // Soporte Enter en cajas de búsqueda
            txtBuscarCarne.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) BtnBuscar_Click(s, e); };
            txtBuscarCedula.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) BtnBuscar_Click(s, e); };

            ActualizarFranjasHorarias();
            ConfigurarModoVista();
        }

        public void ConfigurarModoVista()
        {
            if (ModoDueno)
            {
                lblTituloModulo.Text = "🐾 Historial Clínico y Carné";
                lblCarneLabel.Visible = false;
                txtBuscarCarne.Visible = false;
                lblO.Visible = false;
                lblCedulaLabel.Visible = false;
                txtBuscarCedula.Visible = false;
                btnBuscar.Visible = false;
                lblOtrasMascotas.Visible = false;
                cmbOtrasMascotas.Visible = false;

                lblMascotaDueno.Visible = true;
                cmbMascotasDueno.Visible = true;

                // Ocultar paneles de registro para el dueño (modo solo lectura de historial)
                pnlNuevaConsulta.Visible = false;
                pnlNuevaVacuna.Visible = false;
                pnlNuevaDesparasitacion.Visible = false;
                pnlNuevoTratamiento.Visible = false;
                btnCancelarCita.Visible = false;

                // Asegurar que tabAgendarCita esté presente para el dueño
                if (!tabModulos.TabPages.Contains(tabAgendarCita))
                {
                    tabModulos.TabPages.Add(tabAgendarCita);
                }

                CargarComboMascotasDueno();
            }
            else
            {
                lblTituloModulo.Text = "🐾 Buscar Mascota";
                lblCarneLabel.Visible = true;
                txtBuscarCarne.Visible = true;
                lblO.Visible = true;
                lblCedulaLabel.Visible = true;
                txtBuscarCedula.Visible = true;
                btnBuscar.Visible = true;

                lblMascotaDueno.Visible = false;
                cmbMascotasDueno.Visible = false;

                pnlNuevaConsulta.Visible = true;
                pnlNuevaVacuna.Visible = true;
                pnlNuevaDesparasitacion.Visible = true;
                pnlNuevoTratamiento.Visible = true;
                btnCancelarCita.Visible = true;

                if (!tabModulos.TabPages.Contains(tabAgendarCita))
                {
                    tabModulos.TabPages.Add(tabAgendarCita);
                }
            }

            if (_pestanaInicial >= 0 && _pestanaInicial < tabModulos.TabPages.Count)
            {
                tabModulos.SelectedIndex = _pestanaInicial;
            }
        }

        private void CargarComboMascotasDueno()
        {
            _actualizandoCombo = true;
            cmbMascotasDueno.Items.Clear();

            Dueno dueno = SesionActual.UsuarioLogueado as Dueno;
            string cedula = dueno != null ? dueno.NumeroIdentificacion : (_mascotaActual != null ? _mascotaActual.CedulaDueno : "");
            string idDueno = dueno != null ? dueno.Id : (_mascotaActual != null ? _mascotaActual.IdDueno : "");

            var mascotas = GestorDatos.Datos.Mascotas.Where(m =>
                (!string.IsNullOrEmpty(idDueno) && m.IdDueno == idDueno) ||
                (!string.IsNullOrEmpty(cedula) && m.CedulaDueno == cedula)
            ).ToList();

            int selectedIdx = 0;
            for (int i = 0; i < mascotas.Count; i++)
            {
                var m = mascotas[i];
                string itemText = string.Format("{0} ({1}) - Carné: {2}", m.Nombre, m.Especie, m.Carne != null ? m.Carne.Codigo : "N/A");
                cmbMascotasDueno.Items.Add(itemText);
                if (_mascotaActual != null && m.IdMascota == _mascotaActual.IdMascota)
                {
                    selectedIdx = i;
                }
            }

            if (cmbMascotasDueno.Items.Count > 0)
            {
                cmbMascotasDueno.SelectedIndex = selectedIdx;
            }
            _actualizandoCombo = false;
        }

        private void CmbMascotasDueno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_actualizandoCombo || cmbMascotasDueno.SelectedIndex < 0) return;

            Dueno dueno = SesionActual.UsuarioLogueado as Dueno;
            string cedula = dueno != null ? dueno.NumeroIdentificacion : (_mascotaActual != null ? _mascotaActual.CedulaDueno : "");
            string idDueno = dueno != null ? dueno.Id : (_mascotaActual != null ? _mascotaActual.IdDueno : "");

            var mascotas = GestorDatos.Datos.Mascotas.Where(m =>
                (!string.IsNullOrEmpty(idDueno) && m.IdDueno == idDueno) ||
                (!string.IsNullOrEmpty(cedula) && m.CedulaDueno == cedula)
            ).ToList();

            if (cmbMascotasDueno.SelectedIndex < mascotas.Count)
            {
                GestorDatos.ReproducirSonido("click");
                CargarFichaMascota(mascotas[cmbMascotasDueno.SelectedIndex]);
            }
        }

        private void ActualizarSelectorOtrasMascotas(Mascota m)
        {
            if (ModoDueno || m == null || !_busquedaPorCedula)
            {
                lblOtrasMascotas.Visible = false;
                cmbOtrasMascotas.Visible = false;
                return;
            }

            var listaMascotasDueno = GestorDatos.BuscarMascotasPorCedulaDueno(m.CedulaDueno);
            if (listaMascotasDueno.Count <= 1 && !string.IsNullOrEmpty(m.IdDueno))
            {
                listaMascotasDueno = GestorDatos.Datos.Mascotas.Where(x => x.IdDueno == m.IdDueno).ToList();
            }

            if (listaMascotasDueno.Count > 1)
            {
                _actualizandoCombo = true;
                cmbOtrasMascotas.Items.Clear();
                int selIdx = 0;
                for (int i = 0; i < listaMascotasDueno.Count; i++)
                {
                    var p = listaMascotasDueno[i];
                    string item = string.Format("[{0}] {1} ({2})", p.Carne != null ? p.Carne.Codigo : "S/C", p.Nombre, p.Especie);
                    cmbOtrasMascotas.Items.Add(item);
                    if (p.IdMascota == m.IdMascota) selIdx = i;
                }

                lblOtrasMascotas.Text = string.Format("Mascotas de este dueño ({0}):", listaMascotasDueno.Count);
                lblOtrasMascotas.Visible = true;
                cmbOtrasMascotas.Visible = true;
                cmbOtrasMascotas.SelectedIndex = selIdx;
                _actualizandoCombo = false;
            }
            else
            {
                lblOtrasMascotas.Visible = false;
                cmbOtrasMascotas.Visible = false;
            }
        }

        private void CmbOtrasMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_actualizandoCombo || cmbOtrasMascotas.SelectedIndex < 0 || _mascotaActual == null) return;

            var listaMascotasDueno = GestorDatos.BuscarMascotasPorCedulaDueno(_mascotaActual.CedulaDueno);
            if (listaMascotasDueno.Count <= 1 && !string.IsNullOrEmpty(_mascotaActual.IdDueno))
            {
                listaMascotasDueno = GestorDatos.Datos.Mascotas.Where(x => x.IdDueno == _mascotaActual.IdDueno).ToList();
            }

            if (cmbOtrasMascotas.SelectedIndex < listaMascotasDueno.Count)
            {
                GestorDatos.ReproducirSonido("click");
                CargarFichaMascota(listaMascotasDueno[cmbOtrasMascotas.SelectedIndex]);
            }
        }

        private void ConfigurarGrillas()
        {
            // 1. Grilla Historial
            dgvHistorial.Columns.Clear();
            dgvHistorial.Columns.Add("colFecha", "Fecha");
            dgvHistorial.Columns.Add("colVet", "Veterinario");
            dgvHistorial.Columns.Add("colDiag", "Diagnóstico");
            dgvHistorial.Columns.Add("colTrat", "Tratamiento");
            dgvHistorial.Columns.Add("colMed", "Medicamentos");
            dgvHistorial.Columns.Add("colObs", "Observaciones");

            // 2. Grilla Vacunas
            dgvVacunas.Columns.Clear();
            dgvVacunas.Columns.Add("colNom", "Vacuna");
            dgvVacunas.Columns.Add("colFec", "Fecha Aplicación");
            dgvVacunas.Columns.Add("colProx", "Próxima Dosis");
            dgvVacunas.Columns.Add("colDosis", "Dosis");
            dgvVacunas.Columns.Add("colLote", "Lote");
            dgvVacunas.Columns.Add("colVet", "Veterinario");

            // 3. Grilla Desparasitación
            dgvDesparasitaciones.Columns.Clear();
            dgvDesparasitaciones.Columns.Add("colTipo", "Tipo");
            dgvDesparasitaciones.Columns.Add("colProd", "Producto");
            dgvDesparasitaciones.Columns.Add("colFec", "Fecha Aplicación");
            dgvDesparasitaciones.Columns.Add("colProx", "Próxima Dosis");
            dgvDesparasitaciones.Columns.Add("colPeso", "Peso");
            dgvDesparasitaciones.Columns.Add("colVet", "Veterinario");

            // 4. Grilla Tratamientos / Medicamentos
            dgvTratamientos.Columns.Clear();
            dgvTratamientos.Columns.Add("colMed", "Medicamento / Tratamiento");
            dgvTratamientos.Columns.Add("colInicio", "Fecha Inicio");
            dgvTratamientos.Columns.Add("colFin", "Fecha Límite");
            dgvTratamientos.Columns.Add("colInd", "Indicaciones / Horario");
            dgvTratamientos.Columns.Add("colVet", "Veterinario");
        }

        public void CargarFichaMascota(Mascota m)
        {
            if (m == null) return;
            _mascotaActual = m;

            // Datos principales
            lblIdBadge.Text = "🐾  ID: " + (m.Carne != null ? m.Carne.Codigo : "N/A");
            lblNombreMascota.Text = "🐾  Nombre:  " + m.Nombre;
            lblEdadMascota.Text = "🐾  Edad:  " + m.Edad;
            lblEspecieMascota.Text = "🐾  Especie:  " + m.Especie;
            lblRazaMascota.Text = "🐾  Raza:  " + m.Raza;
            lblSexoMascota.Text = "🐾  Sexo:  " + m.Sexo;
            lblEstadoSalud.Text = "💚  Estado: " + m.EstadoActual;
            lblTextoObsCard.Text = !string.IsNullOrEmpty(m.Observaciones) ? m.Observaciones : "Sin observaciones registradas.";

            // Foto
            try
            {
                string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", m.RutaFoto ?? "");
                if (File.Exists(ruta))
                {
                    picMascota.Image = Image.FromFile(ruta);
                }
                else
                {
                    picMascota.Image = null;
                }
            }
            catch
            {
                picMascota.Image = null;
            }

            // Próxima cita en tarjeta izquierda
            var proximaCita = GestorDatos.Datos.Citas.FirstOrDefault(c => c.IdMascota == m.IdMascota && c.FechaHora >= DateTime.Now.Date && c.Estado != "Cancelada" && c.Estado != "Completada");
            if (proximaCita != null)
            {
                lblDetalleCitaCard.Text = string.Format("{0:dd/MM/yyyy} - {0:hh:mm tt}\n{1}", proximaCita.FechaHora, proximaCita.Motivo);
                btnCancelarCita.Visible = !ModoDueno;
            }
            else
            {
                lblDetalleCitaCard.Text = "Sin citas programadas actualmente.";
                btnCancelarCita.Visible = false;
            }

            RefrescarTablas();
            ActualizarResumenInferior();
            ActualizarFranjasHorarias();
            CargarTablaCitasProgramadas();

            // Actualizar selectores
            if (!ModoDueno)
            {
                ActualizarSelectorOtrasMascotas(m);
            }
            else if (!_actualizandoCombo && cmbMascotasDueno.Items.Count > 0)
            {
                _actualizandoCombo = true;
                for (int i = 0; i < cmbMascotasDueno.Items.Count; i++)
                {
                    if (cmbMascotasDueno.Items[i].ToString().Contains(m.Nombre))
                    {
                        cmbMascotasDueno.SelectedIndex = i;
                        break;
                    }
                }
                _actualizandoCombo = false;
            }
        }

        private void RefrescarTablas()
        {
            if (_mascotaActual == null) return;

            // 1. Historial
            dgvHistorial.Rows.Clear();
            if (_mascotaActual.Historia != null)
            {
                foreach (var reg in _mascotaActual.Historia.Consultas.OrderByDescending(r => r.Fecha))
                {
                    dgvHistorial.Rows.Add(
                        reg.Fecha.ToString("dd/MM/yyyy"),
                        reg.Veterinario,
                        reg.Diagnostico,
                        reg.Tratamiento,
                        reg.Medicamentos,
                        reg.Observaciones
                    );
                }
            }

            // 2. Vacunas
            dgvVacunas.Rows.Clear();
            if (_mascotaActual.Historia != null)
            {
                foreach (var vac in _mascotaActual.Historia.Vacunas.OrderByDescending(v => v.FechaAplicacion))
                {
                    dgvVacunas.Rows.Add(
                        vac.Nombre,
                        vac.FechaAplicacion.ToString("dd/MM/yyyy"),
                        vac.FechaProxima.HasValue ? vac.FechaProxima.Value.ToString("dd/MM/yyyy") : "N/A",
                        vac.Dosis,
                        vac.Lote ?? "N/A",
                        vac.Veterinario
                    );
                }
            }

            // 3. Desparasitación
            dgvDesparasitaciones.Rows.Clear();
            if (_mascotaActual.Historia != null)
            {
                foreach (var d in _mascotaActual.Historia.Desparasitaciones.OrderByDescending(x => x.FechaAplicacion))
                {
                    dgvDesparasitaciones.Rows.Add(
                        d.Tipo,
                        d.Producto,
                        d.FechaAplicacion.ToString("dd/MM/yyyy"),
                        d.FechaProxima.HasValue ? d.FechaProxima.Value.ToString("dd/MM/yyyy") : "N/A",
                        d.Peso,
                        d.Veterinario
                    );
                }
            }

            // 4. Tratamientos
            dgvTratamientos.Rows.Clear();
            if (_mascotaActual.Historia != null)
            {
                foreach (var t in _mascotaActual.Historia.Tratamientos.OrderByDescending(x => x.FechaInicio))
                {
                    dgvTratamientos.Rows.Add(
                        t.Medicamentos,
                        t.FechaInicio.ToString("dd/MM/yyyy"),
                        t.FechaFin.HasValue ? t.FechaFin.Value.ToString("dd/MM/yyyy") : "Indefinido",
                        t.Indicaciones,
                        t.Veterinario
                    );
                }
            }
        }

        private void ActualizarResumenInferior()
        {
            if (_mascotaActual == null || _mascotaActual.Historia == null) return;

            // Últimas vacunas
            var ultimasVacunas = _mascotaActual.Historia.Vacunas.OrderByDescending(v => v.FechaAplicacion).Take(2).ToList();
            if (ultimasVacunas.Count > 0)
            {
                lblTextoResumenVacunas.Text = string.Join("\n", ultimasVacunas.Select(v => "• " + v.Nombre + " - " + v.FechaAplicacion.ToString("dd/MM/yyyy")));
            }
            else
            {
                lblTextoResumenVacunas.Text = "Sin vacunas registradas.";
            }

            // Última desparasitación
            var ultDesp = _mascotaActual.Historia.Desparasitaciones.OrderByDescending(d => d.FechaAplicacion).FirstOrDefault();
            if (ultDesp != null)
            {
                lblTextoResumenDesp.Text = string.Format("• {0} ({1})\n  Fecha: {2:dd/MM/yyyy}\n  Peso: {3}",
                    ultDesp.Tipo, ultDesp.Producto, ultDesp.FechaAplicacion, ultDesp.Peso);
            }
            else
            {
                lblTextoResumenDesp.Text = "Sin desparasitaciones registradas.";
            }

            // Último medicamento
            var ultTrat = _mascotaActual.Historia.Tratamientos.OrderByDescending(t => t.FechaInicio).FirstOrDefault();
            if (ultTrat != null)
            {
                lblTextoResumenMed.Text = string.Format("• {0}\n  Inicio: {1:dd/MM/yyyy}\n  Horario: {2}",
                    ultTrat.Medicamentos, ultTrat.FechaInicio, ultTrat.Indicaciones);
            }
            else
            {
                lblTextoResumenMed.Text = "Sin tratamientos activos.";
            }
        }

        private void ActualizarFranjasHorarias()
        {
            if (cmbHoraCita == null || dtpFechaCita == null) return;

            cmbHoraCita.Items.Clear();
            DateTime fecha = dtpFechaCita.Value.Date;

            if (fecha < DateTime.Today)
            {
                cmbHoraCita.Items.Add("Fecha anterior no válida");
                cmbHoraCita.SelectedIndex = 0;
                return;
            }

            if (fecha.DayOfWeek == DayOfWeek.Sunday)
            {
                cmbHoraCita.Items.Add("Domingo (Cerrado - No hay atención)");
                cmbHoraCita.SelectedIndex = 0;
                return;
            }

            // Horarios de atención:
            // Lunes a Viernes: 8 horas (16 franjas de 30 min: 08:00 - 12:00 y 14:00 - 18:00)
            // Sábado: 4 horas (8 franjas de 30 min: 08:00 - 12:00)
            List<TimeSpan> franjas = new List<TimeSpan>();

            for (int h = 8; h < 12; h++)
            {
                franjas.Add(new TimeSpan(h, 0, 0));
                franjas.Add(new TimeSpan(h, 30, 0));
            }

            if (fecha.DayOfWeek != DayOfWeek.Saturday)
            {
                for (int h = 14; h < 18; h++)
                {
                    franjas.Add(new TimeSpan(h, 0, 0));
                    franjas.Add(new TimeSpan(h, 30, 0));
                }
            }

            string vetFiltro = cmbVeterinarioCita != null && cmbVeterinarioCita.SelectedIndex > 0
                ? cmbVeterinarioCita.SelectedItem.ToString()
                : null;

            int totalVets = Math.Max(1, GestorDatos.Datos.Veterinarios.Count);
            int primerDisponible = -1;

            for (int i = 0; i < franjas.Count; i++)
            {
                TimeSpan ts = franjas[i];
                DateTime slotDateTime = fecha.Add(ts);
                string horaTexto = DateTime.Today.Add(ts).ToString("hh:mm tt");

                if (slotDateTime <= DateTime.Now)
                {
                    cmbHoraCita.Items.Add(string.Format("{0} [⚪ Pasada]", horaTexto));
                    continue;
                }

                bool ocupado = false;
                if (!string.IsNullOrEmpty(vetFiltro))
                {
                    ocupado = GestorDatos.Datos.Citas.Any(c =>
                        c.Estado != "Cancelada" && c.Estado != "Completada" &&
                        c.FechaHora == slotDateTime &&
                        c.Veterinario == vetFiltro);
                }
                else
                {
                    int citasEnSlot = GestorDatos.Datos.Citas.Count(c =>
                        c.Estado != "Cancelada" && c.Estado != "Completada" &&
                        c.FechaHora == slotDateTime);
                    ocupado = (citasEnSlot >= totalVets);
                }

                if (ocupado)
                {
                    cmbHoraCita.Items.Add(string.Format("{0} [🔴 Ocupado]", horaTexto));
                }
                else
                {
                    cmbHoraCita.Items.Add(string.Format("{0} [🟢 Disponible]", horaTexto));
                    if (primerDisponible == -1)
                    {
                        primerDisponible = cmbHoraCita.Items.Count - 1;
                    }
                }
            }

            if (primerDisponible >= 0)
            {
                cmbHoraCita.SelectedIndex = primerDisponible;
            }
            else if (cmbHoraCita.Items.Count > 0)
            {
                cmbHoraCita.SelectedIndex = 0;
            }
        }

        private void CargarTablaCitasProgramadas()
        {
            if (dgvCitasProgramadas == null) return;
            dgvCitasProgramadas.Rows.Clear();

            List<Cita> listaCitas;
            if (_mascotaActual != null)
            {
                if (ModoDueno)
                {
                    listaCitas = GestorDatos.Datos.Citas
                        .Where(c => (c.IdDueno == _mascotaActual.IdDueno || c.IdMascota == _mascotaActual.IdMascota) && c.Estado != "Cancelada" && c.Estado != "Completada")
                        .OrderBy(c => c.FechaHora)
                        .ToList();
                }
                else
                {
                    listaCitas = GestorDatos.Datos.Citas
                        .Where(c => c.IdMascota == _mascotaActual.IdMascota && c.Estado != "Cancelada" && c.Estado != "Completada")
                        .OrderBy(c => c.FechaHora)
                        .ToList();
                }
            }
            else
            {
                listaCitas = GestorDatos.Datos.Citas
                    .Where(c => c.Estado != "Cancelada" && c.Estado != "Completada")
                    .OrderBy(c => c.FechaHora)
                    .ToList();
            }

            foreach (var c in listaCitas)
            {
                int rowIdx = dgvCitasProgramadas.Rows.Add(
                    c.FechaHora.ToString("dd/MM/yyyy"),
                    c.FechaHora.ToString("hh:mm tt"),
                    c.NombreMascota,
                    !string.IsNullOrEmpty(c.Veterinario) ? c.Veterinario : "General",
                    c.Motivo,
                    c.Estado ?? "Confirmada",
                    "❌ Cancelar"
                );
                dgvCitasProgramadas.Rows[rowIdx].Tag = c;
            }
        }

        private void DgvCitasProgramadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == colCitaAccion.Index)
            {
                var cita = dgvCitasProgramadas.Rows[e.RowIndex].Tag as Cita;
                if (cita != null)
                {
                    GestorDatos.ReproducirSonido("click");
                    var dr = MessageBox.Show(
                        string.Format("¿Estás seguro de cancelar la cita de {0} programada para el {1:dd/MM/yyyy} a las {1:hh:mm tt}?\n\nEsta franja horaria quedará libre inmediatamente.",
                            cita.NombreMascota, cita.FechaHora),
                        "Confirmar Cancelación de Cita",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        cita.Estado = "Cancelada";

                        GestorDatos.Datos.Notificaciones.Add(new Notificacion
                        {
                            IdUsuario = cita.IdDueno,
                            Titulo = "Cita Cancelada",
                            Mensaje = string.Format("Se canceló la cita para {0} programada para el {1:dd/MM/yyyy} a las {1:hh:mm tt}.", cita.NombreMascota, cita.FechaHora),
                            Fecha = DateTime.Now
                        });

                        GestorDatos.Guardar();
                        GestorDatos.ReproducirSonido("exito");

                        CargarFichaMascota(_mascotaActual);
                        ActualizarFranjasHorarias();
                        CargarTablaCitasProgramadas();

                        MessageBox.Show("¡La cita médica ha sido cancelada exitosamente y el cupo se ha liberado!", "Cita Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private string ObtenerNombreDoctorActual()
        {
            if (SesionActual.UsuarioLogueado is Veterinario vet)
            {
                return vet.NombreCompleto;
            }
            return "Dr. Andrés Pérez";
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GestorDatos.ReproducirSonido("click");

            string codigo = txtBuscarCarne.Text.Trim();
            string cedula = txtBuscarCedula.Text.Trim();

            if (string.IsNullOrEmpty(codigo) && string.IsNullOrEmpty(cedula))
            {
                GestorDatos.ReproducirSonido("error");
                MessageBox.Show("Ingresa el ID del Carné o la C.C. del Dueño para buscar.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Mascota m = null;
            if (!string.IsNullOrEmpty(codigo))
            {
                _busquedaPorCedula = false;
                m = GestorDatos.BuscarMascotaPorCarne(codigo);
            }
            else if (!string.IsNullOrEmpty(cedula))
            {
                _busquedaPorCedula = true;
                var lista = GestorDatos.BuscarMascotasPorCedulaDueno(cedula);
                if (lista.Count > 0) m = lista[0];
            }

            if (m != null)
            {
                GestorDatos.ReproducirSonido("exito");
                CargarFichaMascota(m);
            }
            else
            {
                GestorDatos.ReproducirSonido("error");
                MessageBox.Show("No se encontró ningún registro para el valor ingresado.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregarConsulta_Click(object sender, EventArgs e)
        {
            if (_mascotaActual == null) return;
            GestorDatos.ReproducirSonido("click");

            string diag = txtDiag.Text.Trim();
            string trat = txtTrat.Text.Trim();
            string med = txtMed.Text.Trim();
            string obs = txtObs.Text.Trim();

            if (string.IsNullOrEmpty(diag))
            {
                GestorDatos.ReproducirSonido("error");
                MessageBox.Show("Por favor ingresa al menos el Diagnóstico de la consulta.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevoRegistro = new RegistroMedico
            {
                Fecha = DateTime.Now,
                Veterinario = ObtenerNombreDoctorActual(),
                Diagnostico = diag,
                Tratamiento = trat,
                Medicamentos = med,
                Observaciones = obs
            };

            _mascotaActual.Historia.Consultas.Add(nuevoRegistro);

            // Si se está atendiendo una cita médica, marcarla como Completada
            Cita citaAtendida = null;
            if (!string.IsNullOrEmpty(IdCitaAtendiendo))
            {
                citaAtendida = GestorDatos.Datos.Citas.FirstOrDefault(c => c.IdCita == IdCitaAtendiendo);
            }
            if (citaAtendida == null)
            {
                citaAtendida = GestorDatos.Datos.Citas.FirstOrDefault(c => c.IdMascota == _mascotaActual.IdMascota && c.Estado != "Completada" && c.Estado != "Cancelada");
            }

            if (citaAtendida != null)
            {
                citaAtendida.Estado = "Completada";
                IdCitaAtendiendo = null;

                GestorDatos.Datos.Notificaciones.Add(new Notificacion
                {
                    IdUsuario = _mascotaActual.IdDueno,
                    Titulo = "Consulta Médica Realizada",
                    Mensaje = string.Format("Tu mascota {0} fue atendida por {1}. Diagnóstico: {2}",
                        _mascotaActual.Nombre, ObtenerNombreDoctorActual(), diag),
                    Fecha = DateTime.Now
                });
            }

            GestorDatos.Guardar();
            GestorDatos.ReproducirSonido("exito");

            txtDiag.Clear();
            txtTrat.Clear();
            txtMed.Clear();
            txtObs.Clear();

            RefrescarTablas();
            string msgExito = "¡Consulta registrada exitosamente en el historial médico!";
            if (citaAtendida != null)
            {
                msgExito += "\n\nSe ha completado la cita programada y se ha retirado de la lista de pendientes.";
            }
            MessageBox.Show(msgExito, "Consulta Guardada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnGuardarVacuna_Click(object sender, EventArgs e)
        {
            if (_mascotaActual == null) return;
            GestorDatos.ReproducirSonido("click");

            string nom = txtNomVacuna.Text.Trim();
            string dosis = txtDosisVacuna.Text.Trim();
            string lote = txtLoteVacuna.Text.Trim();
            DateTime prox = dtpProxVacuna.Value;

            if (string.IsNullOrEmpty(nom))
            {
                GestorDatos.ReproducirSonido("error");
                MessageBox.Show("Por favor ingresa el nombre de la vacuna aplicada.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevaVacuna = new Vacuna
            {
                Nombre = nom,
                Dosis = dosis,
                Lote = lote,
                FechaAplicacion = DateTime.Now,
                FechaProxima = prox,
                Veterinario = ObtenerNombreDoctorActual()
            };

            _mascotaActual.Historia.Vacunas.Add(nuevaVacuna);
            GestorDatos.Guardar();
            GestorDatos.ReproducirSonido("exito");

            txtNomVacuna.Clear();
            txtLoteVacuna.Clear();

            RefrescarTablas();
            ActualizarResumenInferior();
            MessageBox.Show("¡Vacunación registrada exitosamente en el carné digital!", "Vacuna Aplicada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnGuardarDesp_Click(object sender, EventArgs e)
        {
            if (_mascotaActual == null) return;
            GestorDatos.ReproducirSonido("click");

            string tipo = cmbTipoDesp.SelectedItem != null ? cmbTipoDesp.SelectedItem.ToString() : "Pipeta interna";
            string prod = txtProdDesp.Text.Trim();
            string peso = txtPesoDesp.Text.Trim();
            DateTime prox = dtpProxDesp.Value;

            if (string.IsNullOrEmpty(prod))
            {
                GestorDatos.ReproducirSonido("error");
                MessageBox.Show("Ingresa el producto de desparasitación utilizado.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var desp = new Desparasitacion
            {
                Tipo = tipo,
                Producto = prod,
                Peso = peso,
                FechaAplicacion = DateTime.Now,
                FechaProxima = prox,
                Veterinario = ObtenerNombreDoctorActual()
            };

            _mascotaActual.Historia.Desparasitaciones.Add(desp);
            GestorDatos.Guardar();
            GestorDatos.ReproducirSonido("exito");

            txtProdDesp.Clear();
            txtPesoDesp.Clear();

            RefrescarTablas();
            ActualizarResumenInferior();
            MessageBox.Show("¡Desparasitación registrada correctamente!", "Desparasitación Guardada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnGuardarTratamiento_Click(object sender, EventArgs e)
        {
            if (_mascotaActual == null) return;
            GestorDatos.ReproducirSonido("click");

            string med = txtMedTrat.Text.Trim();
            string ind = txtIndicacionesTrat.Text.Trim();
            DateTime fin = dtpFinTrat.Value;

            if (string.IsNullOrEmpty(med))
            {
                GestorDatos.ReproducirSonido("error");
                MessageBox.Show("Ingresa el medicamento o tratamiento prescrito.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var trat = new Tratamiento
            {
                Medicamentos = med,
                Indicaciones = ind,
                FechaInicio = DateTime.Now,
                FechaFin = fin,
                Veterinario = ObtenerNombreDoctorActual()
            };

            _mascotaActual.Historia.Tratamientos.Add(trat);
            GestorDatos.Guardar();
            GestorDatos.ReproducirSonido("exito");

            txtMedTrat.Clear();
            txtIndicacionesTrat.Clear();

            RefrescarTablas();
            ActualizarResumenInferior();
            MessageBox.Show("¡Tratamiento médico registrado exitosamente!", "Tratamiento Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnAgendarCita_Click(object sender, EventArgs e)
        {
            if (_mascotaActual == null)
            {
                GestorDatos.ReproducirSonido("error");
                MessageBox.Show("Debes seleccionar una mascota antes de agendar una cita médica.", "Mascota no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GestorDatos.ReproducirSonido("click");

            DateTime fecha = dtpFechaCita.Value.Date;
            if (fecha < DateTime.Today)
            {
                GestorDatos.ReproducirSonido("error");
                MessageBox.Show("No se pueden agendar citas en fechas anteriores.", "Fecha Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (fecha.DayOfWeek == DayOfWeek.Sunday)
            {
                GestorDatos.ReproducirSonido("error");
                MessageBox.Show("La clínica veterinaria no labora los domingos. Por favor selecciona una fecha de lunes a sábado.", "Día no laborable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbHoraCita.SelectedItem == null)
            {
                GestorDatos.ReproducirSonido("error");
                MessageBox.Show("Selecciona una franja horaria disponible.", "Hora Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string franjaSeleccionada = cmbHoraCita.SelectedItem.ToString();
            if (!franjaSeleccionada.Contains("[🟢 Disponible]"))
            {
                GestorDatos.ReproducirSonido("error");
                MessageBox.Show("La franja horaria seleccionada no está disponible o ya se encuentra ocupada.\nPor favor selecciona una que indique [🟢 Disponible].", "Horario no disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string motivo = txtMotivoCita.Text.Trim();
            if (string.IsNullOrEmpty(motivo))
            {
                GestorDatos.ReproducirSonido("error");
                MessageBox.Show("Por favor ingresa el motivo o sintomatología de la consulta.", "Motivo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMotivoCita.Focus();
                return;
            }

            // Extraer hora limpia, ej: "08:30 AM"
            string horaLimpia = franjaSeleccionada.Replace("[🟢 Disponible]", "").Trim();
            DateTime horaParsed;
            DateTime fechaHoraCompleta = fecha;
            if (DateTime.TryParse(horaLimpia, out horaParsed))
            {
                fechaHoraCompleta = fecha.Add(horaParsed.TimeOfDay);
            }

            // Asignar veterinario
            string vetNombre;
            if (cmbVeterinarioCita != null && cmbVeterinarioCita.SelectedIndex > 0)
            {
                vetNombre = cmbVeterinarioCita.SelectedItem.ToString();
            }
            else
            {
                var vets = GestorDatos.Datos.Veterinarios;
                var vetDisponible = vets.FirstOrDefault(v => !GestorDatos.Datos.Citas.Any(c =>
                    c.Estado != "Cancelada" && c.Estado != "Completada" &&
                    c.FechaHora == fechaHoraCompleta && c.Veterinario == v.NombreCompleto));

                vetNombre = vetDisponible != null ? vetDisponible.NombreCompleto : (vets.Count > 0 ? vets[0].NombreCompleto : ObtenerNombreDoctorActual());
            }

            var nuevaCita = new Cita
            {
                IdMascota = _mascotaActual.IdMascota,
                NombreMascota = _mascotaActual.Nombre,
                IdDueno = _mascotaActual.IdDueno,
                NombreDueno = _mascotaActual.NombreDueno,
                Veterinario = vetNombre,
                FechaHora = fechaHoraCompleta,
                Motivo = motivo,
                Estado = "Confirmada"
            };

            GestorDatos.Datos.Citas.Add(nuevaCita);

            // Notificación al dueño
            GestorDatos.Datos.Notificaciones.Add(new Notificacion
            {
                IdUsuario = _mascotaActual.IdDueno,
                Titulo = "Nueva Cita Agendada",
                Mensaje = string.Format("Se programó una cita para {0} el {1:dd/MM/yyyy} a las {1:hh:mm tt} con {2}. Motivo: {3}.",
                    _mascotaActual.Nombre, fechaHoraCompleta, vetNombre, motivo),
                Fecha = DateTime.Now
            });

            GestorDatos.Guardar();
            GestorDatos.ReproducirSonido("exito");

            txtMotivoCita.Clear();
            ActualizarFranjasHorarias();
            CargarTablaCitasProgramadas();
            CargarFichaMascota(_mascotaActual);

            MessageBox.Show(
                string.Format("¡Cita agendada exitosamente!\n\nPaciente: {0}\nVeterinario: {1}\nFecha y Hora: {2:dd/MM/yyyy} - {2:hh:mm tt}\nMotivo: {3}",
                _mascotaActual.Nombre, vetNombre, fechaHoraCompleta, motivo),
                "Cita Programada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCancelarCita_Click(object sender, EventArgs e)
        {
            if (_mascotaActual == null) return;
            var cita = GestorDatos.Datos.Citas.FirstOrDefault(c => c.IdMascota == _mascotaActual.IdMascota && c.FechaHora >= DateTime.Now.Date && c.Estado != "Cancelada" && c.Estado != "Completada");
            if (cita != null)
            {
                if (MessageBox.Show("¿Deseas cancelar la cita programada para " + _mascotaActual.Nombre + "?", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cita.Estado = "Cancelada";
                    GestorDatos.Guardar();
                    GestorDatos.ReproducirSonido("exito");
                    CargarFichaMascota(_mascotaActual);
                    ActualizarFranjasHorarias();
                    CargarTablaCitasProgramadas();
                }
            }
        }
    }
}
