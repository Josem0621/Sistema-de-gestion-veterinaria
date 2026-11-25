using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_de_gestion_veterinaria
{
    public partial class FrmMenuDueno : Form
    {
        private Dueno _duenoActual;
        private Cita _citaSeleccionadaParaCancelar;

        public FrmMenuDueno()
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

            // Cargar usuario logueado
            _duenoActual = SesionActual.UsuarioLogueado as Dueno;
            if (_duenoActual == null && GestorDatos.Datos.Duenos.Count > 0)
            {
                _duenoActual = GestorDatos.Datos.Duenos[0];
            }

            if (_duenoActual != null)
            {
                lblBienvenida.Text = "¡Hola, " + _duenoActual.NombreCompleto.Split(' ')[0] + "!";
                lblPerfilNombre.Text = _duenoActual.NombreCompleto;

                try
                {
                    string avatarPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", _duenoActual.FotoPerfil ?? "dueno_avatar.jpg");
                    if (File.Exists(avatarPath)) picAvatar.Image = Image.FromFile(avatarPath);
                }
                catch { }
            }

            btnRegistrarNuevaMascota.Click += BtnRegistrarNuevaMascota_Click;
            btnNavMascotas.Click += BtnNavMascotas_Click;
            btnCerrarSesion.Click += (s, e) => { GestorDatos.ReproducirSonido("click"); this.Close(); };
            btnNavPerfil.Click += BtnNavPerfil_Click;
            btnNavCitas.Click += (s, e) => AbrirAgendarCitas();
            btnAgendarCitaDirecto.Click += (s, e) => AbrirAgendarCitas();
            btnCancelarCitaDueno.Click += BtnCancelarCitaDueno_Click;
            btnNavHistorial.Click += BtnNavMascotas_Click;
            btnNavNotificaciones.Click += (s, e) => MessageBox.Show("Tienes las notificaciones al día.", "Notificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarDatosDashboard();
        }

        private void AbrirAgendarCitas()
        {
            if (_duenoActual == null) return;

            var mascotas = GestorDatos.Datos.Mascotas.Where(m =>
                m.IdDueno == _duenoActual.Id ||
                (!string.IsNullOrEmpty(m.CedulaDueno) && m.CedulaDueno == _duenoActual.NumeroIdentificacion)
            ).ToList();

            if (mascotas.Count == 0)
            {
                GestorDatos.ReproducirSonido("error");
                MessageBox.Show("Aún no tienes mascotas registradas. El veterinario debe registrar a tu mascota primero.", "Mis Citas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            GestorDatos.ReproducirSonido("click");
            FrmAtencionMedica frm = new FrmAtencionMedica(mascotas[0], esModoDueno: true, idCita: null, pestanaInicial: 4);
            frm.FormClosed += (evSender, evArgs) => CargarDatosDashboard();
            frm.ShowDialog();
        }

        private void BtnCancelarCitaDueno_Click(object sender, EventArgs e)
        {
            if (_citaSeleccionadaParaCancelar != null)
            {
                GestorDatos.ReproducirSonido("click");
                var dr = MessageBox.Show(
                    string.Format("¿Deseas cancelar la cita para {0} programada el {1:dd/MM/yyyy} a las {1:hh:mm tt}?\n\nLa franja horaria se liberará inmediatamente.",
                    _citaSeleccionadaParaCancelar.NombreMascota, _citaSeleccionadaParaCancelar.FechaHora),
                    "Confirmar Cancelación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    _citaSeleccionadaParaCancelar.Estado = "Cancelada";
                    GestorDatos.Guardar();
                    GestorDatos.ReproducirSonido("exito");
                    CargarDatosDashboard();
                    MessageBox.Show("¡La cita médica ha sido cancelada exitosamente!", "Cita Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnNavMascotas_Click(object sender, EventArgs e)
        {
            if (_duenoActual == null) return;

            var mascotas = GestorDatos.Datos.Mascotas.Where(m =>
                m.IdDueno == _duenoActual.Id ||
                (!string.IsNullOrEmpty(m.CedulaDueno) && m.CedulaDueno == _duenoActual.NumeroIdentificacion)
            ).ToList();

            if (mascotas.Count == 0)
            {
                GestorDatos.ReproducirSonido("error");
                MessageBox.Show("Aún no tienes mascotas registradas en el sistema.", "Mis Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            GestorDatos.ReproducirSonido("click");
            FrmAtencionMedica frm = new FrmAtencionMedica(mascotas[0], esModoDueno: true, idCita: null, pestanaInicial: 0);
            frm.FormClosed += (s, args) => CargarDatosDashboard();
            frm.ShowDialog();
        }

        public void CargarDatosDashboard()
        {
            if (_duenoActual == null) return;

            // Obtener mascotas del dueño
            var mascotas = GestorDatos.Datos.Mascotas.Where(m =>
                m.IdDueno == _duenoActual.Id ||
                (!string.IsNullOrEmpty(m.CedulaDueno) && m.CedulaDueno == _duenoActual.NumeroIdentificacion)
            ).ToList();

            lblNumMascotas.Text = mascotas.Count.ToString();

            // Citas del dueño
            var citas = GestorDatos.Datos.Citas.Where(c =>
                c.IdDueno == _duenoActual.Id ||
                mascotas.Any(m => m.IdMascota == c.IdMascota)
            ).OrderBy(c => c.FechaHora).ToList();

            lblNumCitas.Text = citas.Count(c => c.Estado != "Cancelada" && c.Estado != "Completada").ToString();

            // Total de registros médicos
            int totalHistorial = mascotas.Sum(m => m.Historia != null ? m.Historia.Consultas.Count + m.Historia.Vacunas.Count : 0);
            lblNumHistorial.Text = totalHistorial.ToString();

            // Notificaciones
            var notifs = GestorDatos.Datos.Notificaciones.Where(n => n.IdUsuario == _duenoActual.Id).ToList();
            lblNumNotif.Text = notifs.Count.ToString();

            // Llenar tarjetas de mascotas
            flpMascotas.Controls.Clear();
            foreach (var m in mascotas)
            {
                Panel card = CrearTarjetaMascota(m);
                flpMascotas.Controls.Add(card);
            }

            // Próxima cita
            var proximaCita = citas.FirstOrDefault(c => c.FechaHora >= DateTime.Now.Date && c.Estado != "Cancelada" && c.Estado != "Completada");
            if (proximaCita != null)
            {
                _citaSeleccionadaParaCancelar = proximaCita;
                lblInfoCita.Text = string.Format("Mascota: {0}\nMotivo: {1}\nFecha: {2:dd/MM/yyyy} - {2:hh:mm tt}\nVeterinario: {3}",
                    proximaCita.NombreMascota, proximaCita.Motivo, proximaCita.FechaHora, !string.IsNullOrEmpty(proximaCita.Veterinario) ? proximaCita.Veterinario : "General");
                lblEstadoCitaBadge.Text = proximaCita.Estado ?? "Confirmada";
                btnCancelarCitaDueno.Visible = true;
            }
            else
            {
                _citaSeleccionadaParaCancelar = null;
                lblInfoCita.Text = "No tienes citas programadas actualmente.\nHaz clic en '📅 Agendar Cita' para programar una.";
                lblEstadoCitaBadge.Text = "Sin citas pendientes";
                btnCancelarCitaDueno.Visible = false;
            }

            // Notificaciones recientes
            var ultNotif = notifs.OrderByDescending(n => n.Fecha).FirstOrDefault();
            if (ultNotif != null)
            {
                lblInfoNotif.Text = string.Format("📌 {0}\n{1}\nFecha: {2:dd/MM/yyyy}",
                    ultNotif.Titulo, ultNotif.Mensaje, ultNotif.Fecha);
            }
            else
            {
                lblInfoNotif.Text = "No tienes notificaciones pendientes.\n¡Tus mascotas están al día con sus cuidados!";
            }
        }

        private Panel CrearTarjetaMascota(Mascota m)
        {
            Panel card = new Panel
            {
                Width = 240,
                Height = 175,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10, 5, 10, 5)
            };

            PictureBox pic = new PictureBox
            {
                Location = new Point(15, 15),
                Size = new Size(70, 70),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(240, 248, 243),
                BorderStyle = BorderStyle.FixedSingle
            };

            try
            {
                string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", m.RutaFoto ?? "");
                if (File.Exists(ruta)) pic.Image = Image.FromFile(ruta);
            }
            catch { }

            Label lblNombre = new Label
            {
                Text = m.Nombre,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(15, 113, 75),
                Location = new Point(95, 15),
                Size = new Size(130, 25)
            };

            Label lblEspecie = new Label
            {
                Text = m.Especie + " • " + m.Raza,
                Font = new Font("Segoe UI", 8.5f),
                ForeColor = Color.FromArgb(80, 100, 90),
                Location = new Point(95, 40),
                Size = new Size(135, 30)
            };

            Label lblCarne = new Label
            {
                Text = "Carné: " + (m.Carne != null ? m.Carne.Codigo : "N/A"),
                Font = new Font("Segoe UI Semibold", 8.5f, FontStyle.Bold),
                ForeColor = Color.FromArgb(15, 113, 75),
                Location = new Point(95, 68),
                Size = new Size(135, 18)
            };

            Label lblEstado = new Label
            {
                Text = "💚 " + m.EstadoActual,
                Font = new Font("Segoe UI", 8f),
                ForeColor = Color.FromArgb(15, 113, 75),
                Location = new Point(15, 95),
                Size = new Size(210, 18)
            };

            Button btnVerDetalles = new Button
            {
                Text = "🐾  Ver carné y ficha",
                Font = new Font("Segoe UI Semibold", 8.5f, FontStyle.Bold),
                ForeColor = Color.FromArgb(15, 113, 75),
                BackColor = Color.FromArgb(235, 247, 240),
                FlatStyle = FlatStyle.Flat,
                Location = new Point(15, 125),
                Size = new Size(205, 32),
                Cursor = Cursors.Hand
            };
            btnVerDetalles.FlatAppearance.BorderColor = Color.FromArgb(15, 113, 75);
            btnVerDetalles.Click += (s, e) =>
            {
                GestorDatos.ReproducirSonido("click");
                FrmAtencionMedica frm = new FrmAtencionMedica(m, esModoDueno: true, idCita: null, pestanaInicial: 0);
                frm.FormClosed += (evSender, evArgs) => CargarDatosDashboard();
                frm.ShowDialog();
            };

            card.Controls.Add(pic);
            card.Controls.Add(lblNombre);
            card.Controls.Add(lblEspecie);
            card.Controls.Add(lblCarne);
            card.Controls.Add(lblEstado);
            card.Controls.Add(btnVerDetalles);

            return card;
        }

        private void BtnRegistrarNuevaMascota_Click(object sender, EventArgs e)
        {
            GestorDatos.ReproducirSonido("click");
            FrmRegistrarMascota frm = new FrmRegistrarMascota();
            frm.FormClosed += (s, args) => CargarDatosDashboard();
            frm.ShowDialog();
        }

        private void BtnNavPerfil_Click(object sender, EventArgs e)
        {
            GestorDatos.ReproducirSonido("click");
            if (_duenoActual != null)
            {
                MessageBox.Show(
                    string.Format("Perfil de Usuario:\n\nNombre: {0}\nUsuario: {1}\nC.C.: {2}\nCorreo: {3}\nTeléfono: {4}\nDirección: {5}",
                    _duenoActual.NombreCompleto, _duenoActual.NombreUsuario, _duenoActual.NumeroIdentificacion,
                    _duenoActual.Correo, _duenoActual.Telefono, _duenoActual.Direccion),
                    "Mi Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
