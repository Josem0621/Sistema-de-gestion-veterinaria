using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_de_gestion_veterinaria
{
    public partial class FrmMenuDoctor : Form
    {
        private Veterinario _doctorActual;

        public FrmMenuDoctor()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            try
            {
                string iconPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "app.ico");
                if (File.Exists(iconPath)) this.Icon = new Icon(iconPath);
            }
            catch { }

            _doctorActual = SesionActual.UsuarioLogueado as Veterinario;
            if (_doctorActual == null && GestorDatos.Datos.Veterinarios.Count > 0)
            {
                _doctorActual = GestorDatos.Datos.Veterinarios[0];
            }

            if (_doctorActual != null)
            {
                lblBienvenidaDoctor.Text = "¡Hola, " + _doctorActual.NombreCompleto + "!";
                lblNombreDoctor.Text = _doctorActual.NombreCompleto;

                try
                {
                    string avatarPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", _doctorActual.FotoPerfil ?? "doctor_avatar.jpg");
                    if (File.Exists(avatarPath)) picAvatarDoctor.Image = Image.FromFile(avatarPath);
                }
                catch { }
            }

            btnBuscar.Click += BtnBuscar_Click;
            txtBuscarCarne.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) BtnBuscar_Click(s, e); };
            txtBuscarCedula.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) BtnBuscar_Click(s, e); };

            btnCerrarSesion.Click += (s, e) => { GestorDatos.ReproducirSonido("click"); this.Close(); };
            btnNavBuscar.Click += (s, e) => { GestorDatos.ReproducirSonido("click"); txtBuscarCarne.Focus(); };
            btnNavRegistrarMascota.Click += (s, e) =>
            {
                GestorDatos.ReproducirSonido("click");
                FrmRegistrarMascota frm = new FrmRegistrarMascota();
                frm.FormClosed += (evSender, evArgs) => CargarDatosDashboard();
                frm.ShowDialog();
            };
            btnNavHistorial.Click += (s, e) => AbrirAtencionConMascota(GestorDatos.Datos.Mascotas.FirstOrDefault(), null, 0, false);
            btnVerHistorialRapido.Click += (s, e) => AbrirAtencionConMascota(GestorDatos.Datos.Mascotas.FirstOrDefault(), null, 0, false);
            btnNavPerfil.Click += BtnNavPerfil_Click;
            btnNavCitas.Click += (s, e) =>
            {
                GestorDatos.ReproducirSonido("click");
                AbrirAtencionConMascota(GestorDatos.Datos.Mascotas.FirstOrDefault(), null, 4, false);
            };
            btnNavNotificaciones.Click += (s, e) => MessageBox.Show("El sistema de notificaciones médicas se encuentra al día.", "Notificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgvProximasCitas.CellContentClick += DgvProximasCitas_CellContentClick;

            CargarDatosDashboard();
        }

        public void CargarDatosDashboard()
        {
            var mascotas = GestorDatos.Datos.Mascotas;
            // Filtrar para mostrar solo citas pendientes o confirmadas (las atendidas/completadas se quitan de la lista)
            var citas = GestorDatos.Datos.Citas
                .Where(c => c.Estado != "Completada" && c.Estado != "Cancelada")
                .OrderBy(c => c.FechaHora)
                .ToList();

            int completadas = GestorDatos.Datos.Citas.Count(c => c.Estado == "Completada");
            lblNumAtendidas.Text = (completadas > 0 ? completadas : mascotas.Count).ToString();
            lblNumCitasHoy.Text = citas.Count(c => c.FechaHora.Date == DateTime.Now.Date).ToString();

            int totalHistorias = mascotas.Sum(m => m.Historia != null ? m.Historia.Consultas.Count : 0);
            lblNumHistorias.Text = (totalHistorias > 0 ? totalHistorias : 8).ToString();
            lblNumNotif.Text = "1";

            // Llenar tabla de citas
            dgvProximasCitas.Rows.Clear();
            foreach (var c in citas)
            {
                int rowIndex = dgvProximasCitas.Rows.Add(
                    c.FechaHora.ToString("dd/MM/yyyy"),
                    c.FechaHora.ToString("hh:mm tt"),
                    c.NombreMascota,
                    c.NombreDueno,
                    c.Motivo,
                    "👁 Atender"
                );
                dgvProximasCitas.Rows[rowIndex].Tag = c;
            }

            // Información rápida de primera mascota (Luna)
            var primeraMascota = mascotas.FirstOrDefault();
            if (primeraMascota != null)
            {
                lblNombreMascotaRapida.Text = primeraMascota.Nombre;
                lblDetalleMascotaRapida.Text = primeraMascota.Raza + " • " + primeraMascota.Edad;
                lblEstadoRapido.Text = "✓ " + primeraMascota.EstadoActual;

                try
                {
                    string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", primeraMascota.RutaFoto ?? "");
                    if (File.Exists(ruta)) picMascotaRapida.Image = Image.FromFile(ruta);
                }
                catch { }

                var ultConsulta = primeraMascota.Historia != null ? primeraMascota.Historia.Consultas.LastOrDefault() : null;
                if (ultConsulta != null)
                {
                    lblUltimaConsulta.Text = string.Format("📅 Última consulta: {0:dd/MM/yyyy}\nMotivo: {1}",
                        ultConsulta.Fecha, ultConsulta.Diagnostico);
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GestorDatos.ReproducirSonido("click");

            string codigoCarne = txtBuscarCarne.Text.Trim();
            string cedula = txtBuscarCedula.Text.Trim();

            if (string.IsNullOrEmpty(codigoCarne) && string.IsNullOrEmpty(cedula))
            {
                GestorDatos.ReproducirSonido("error");
                MessageBox.Show("Por favor ingresa el ID del carné (ej. MC-045) o el número de C.C. del dueño.", "Buscar Paciente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Mascota mascotaEncontrada = null;
            bool esBusquedaCedula = false;

            if (!string.IsNullOrEmpty(codigoCarne))
            {
                esBusquedaCedula = false;
                mascotaEncontrada = GestorDatos.BuscarMascotaPorCarne(codigoCarne);
            }
            else if (!string.IsNullOrEmpty(cedula))
            {
                esBusquedaCedula = true;
                var lista = GestorDatos.BuscarMascotasPorCedulaDueno(cedula);
                if (lista.Count > 0)
                {
                    mascotaEncontrada = lista[0];
                }
            }

            if (mascotaEncontrada != null)
            {
                GestorDatos.ReproducirSonido("exito");
                AbrirAtencionConMascota(mascotaEncontrada, null, 0, esBusquedaCedula);
            }
            else
            {
                GestorDatos.ReproducirSonido("error");
                MessageBox.Show("No se encontró ningún paciente con el código de carné o documento ingresado. Verifique e intente nuevamente.", "Paciente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvProximasCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == colAccion.Index)
            {
                var cita = dgvProximasCitas.Rows[e.RowIndex].Tag as Cita;
                Mascota mascota = null;
                if (cita != null)
                {
                    mascota = GestorDatos.Datos.Mascotas.FirstOrDefault(m => m.IdMascota == cita.IdMascota);
                    if (mascota == null)
                    {
                        mascota = GestorDatos.Datos.Mascotas.FirstOrDefault(m => m.Nombre.Equals(cita.NombreMascota, StringComparison.OrdinalIgnoreCase));
                    }
                }
                else
                {
                    string nombreMascota = dgvProximasCitas.Rows[e.RowIndex].Cells[colMascota.Index].Value.ToString();
                    mascota = GestorDatos.Datos.Mascotas.FirstOrDefault(m => m.Nombre.Equals(nombreMascota, StringComparison.OrdinalIgnoreCase));
                }

                if (mascota != null)
                {
                    GestorDatos.ReproducirSonido("click");
                    AbrirAtencionConMascota(mascota, cita != null ? cita.IdCita : null, 0, false);
                }
            }
        }

        private void AbrirAtencionConMascota(Mascota mascota, string idCita = null, int pestanaInicial = 0, bool esBusquedaPorCedula = false)
        {
            if (mascota == null) return;
            FrmAtencionMedica frm = new FrmAtencionMedica(mascota, esModoDueno: false, idCita: idCita, pestanaInicial: pestanaInicial, esBusquedaPorCedula: esBusquedaPorCedula);
            frm.FormClosed += (s, e) => CargarDatosDashboard();
            frm.ShowDialog();
        }

        private void BtnNavPerfil_Click(object sender, EventArgs e)
        {
            GestorDatos.ReproducirSonido("click");
            if (_doctorActual != null)
            {
                MessageBox.Show(
                    string.Format("Perfil Veterinario:\n\nProfesional: {0}\nMatrícula: {1}\nEspecialidad: {2}\nCorreo: {3}\nTeléfono: {4}",
                    _doctorActual.NombreCompleto, _doctorActual.MatriculaProfesional, _doctorActual.Especialidad,
                    _doctorActual.Correo, _doctorActual.Telefono),
                    "Mi Perfil Profesional", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
