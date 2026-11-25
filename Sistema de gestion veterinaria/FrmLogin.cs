using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Sistema_de_gestion_veterinaria
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            // Cargar icono de aplicacion si existe
            try
            {
                string iconPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "app.ico");
                if (File.Exists(iconPath))
                {
                    this.Icon = new Icon(iconPath);
                }
            }
            catch { }

            
            // Asignar eventos de controles
            btnIniciarSesion.Click += BtnIniciarSesion_Click;
            btnCrearUsuario.Click += BtnCrearUsuario_Click;
            btnOlvidaste.Click += BtnOlvidaste_Click;
            chkVerContrasena.CheckedChanged += ChkVerContrasena_CheckedChanged;

            // Soporte para tecla Enter
            txtUsuario.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) txtContrasena.Focus(); };
            txtContrasena.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) BtnIniciarSesion_Click(s, e); };

            // Asegurar que los datos iniciales existan
            GestorDatos.Inicializar();
        }

        private void ChkVerContrasena_CheckedChanged(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = !chkVerContrasena.Checked;
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            GestorDatos.ReproducirSonido("click");

            string user = txtUsuario.Text.Trim();
            string pass = txtContrasena.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                GestorDatos.ReproducirSonido("error");
                MessageBox.Show("Por favor ingresa tu usuario y contraseña.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var usuario = GestorDatos.Autenticar(user, pass);
            if (usuario == null)
            {
                GestorDatos.ReproducirSonido("error");
                MessageBox.Show("Usuario o contraseña incorrectos. Revisa las credenciales de prueba abajo.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Inicio de sesion exitoso
            GestorDatos.ReproducirSonido("login");
            SesionActual.UsuarioLogueado = usuario;

            wmpVideo.Ctlcontrols.stop();
            this.Hide();

            if (usuario.Rol == "Administrador")
            {
                FrmMenuAdmin frmAdmin = new FrmMenuAdmin();
                frmAdmin.FormClosed += (s, args) => { this.Show(); txtContrasena.Clear(); if (wmpVideo != null && wmpVideo.Ctlcontrols != null) wmpVideo.Ctlcontrols.play(); };
                frmAdmin.Show();
            }
            else if (usuario.Rol == "Veterinario")
            {
                FrmMenuDoctor frmDoctor = new FrmMenuDoctor();
                frmDoctor.FormClosed += (s, args) => { this.Show(); txtContrasena.Clear(); if (wmpVideo != null && wmpVideo.Ctlcontrols != null) wmpVideo.Ctlcontrols.play(); };
                frmDoctor.Show();
            }
            else
            {
                FrmMenuDueno frmDueno = new FrmMenuDueno();
                frmDueno.FormClosed += (s, args) => { this.Show(); txtContrasena.Clear(); if (wmpVideo != null && wmpVideo.Ctlcontrols != null) wmpVideo.Ctlcontrols.play(); };
                frmDueno.Show();
            }
        }

        private void BtnCrearUsuario_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.stop();
            GestorDatos.ReproducirSonido("click");
            FrmRegistro frmReg = new FrmRegistro();
            this.Hide();
            frmReg.FormClosed += (s, args) => { this.Show(); wmpVideo.Ctlcontrols.play(); };
            frmReg.Show();
        }

        private void BtnOlvidaste_Click(object sender, EventArgs e)
        {
            GestorDatos.ReproducirSonido("click");
            MessageBox.Show(
                "Para recuperar tu contraseña comunícate con la administración de Huellitas Veterinaria o utiliza las cuentas de demostración:\n\n" +
                "• Médico Veterinario: drperez (Clave: 1234)\n" +
                "• Dueño de Mascota: luisa (Clave: 1234)",
                "Recuperación de Contraseña",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // Construye la ruta exacta dentro de bin\Debug
            string rutaVideo = Path.Combine(Application.StartupPath, "veterinariaVideo.mp4");

            // Verifica que el archivo exista antes de intentar reproducirlo
            if (File.Exists(rutaVideo))
            {
                wmpVideo.uiMode = "none";                 // Oculta los controles de reproducción (play, pausa, barra)
                wmpVideo.settings.setMode("loop", true);  // Repite el video en bucle infinito
                wmpVideo.settings.volume = 50;            // volumen
                wmpVideo.stretchToFit = true;
                wmpVideo.URL = rutaVideo;                 // Carga el video
                wmpVideo.Ctlcontrols.play();              // Inicia la reproducción automática
            }
            else
            {
                MessageBox.Show("No se encontró el video en: " + rutaVideo, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblEslogan_Click(object sender, EventArgs e)
        {

        }
    }

    // =========================================================================
    // SESIÓN ACTUAL GLOBAL
    // =========================================================================
    public static class SesionActual
    {
        public static Usuario UsuarioLogueado { get; set; }
    }

    // =========================================================================
    // ARQUITECTURA POO - CLASES DEL SISTEMA (DIAGRAMA DE CLASES)
    // =========================================================================

    public class Usuario
    {
        public string Id { get; set; }
        public string NombreUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public string TipoIdentificacion { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Contrasena { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Rol { get; set; } // "Dueño", "Veterinario", "Administrador"
        public string FotoPerfil { get; set; }

        public Usuario()
        {
            Id = Guid.NewGuid().ToString("N").Substring(0, 8);
        }

        public virtual bool IniciarSesion(string password)
        {
            return Contrasena == password;
        }

        public virtual string ObtenerInformacion()
        {
            return string.Format("{0} ({1}) - {2}", NombreCompleto, Rol, Correo);
        }
    }

    public class Dueno : Usuario
    {
        public List<string> IdsMascotas { get; set; }

        public Dueno()
        {
            Rol = "Dueño";
            IdsMascotas = new List<string>();
        }
    }

    public class Veterinario : Usuario
    {
        public string MatriculaProfesional { get; set; }
        public string Especialidad { get; set; }

        public Veterinario()
        {
            Rol = "Veterinario";
        }
    }

    public class Administrador : Usuario
    {
        public Administrador()
        {
            Rol = "Administrador";
        }
    }

    public class CarneMascota
    {
        public string Codigo { get; set; } // Ej. MC-045
        public DateTime FechaEmision { get; set; }
        public string Estado { get; set; } // "Activo", "Inactivo"

        public CarneMascota()
        {
            FechaEmision = DateTime.Now;
            Estado = "Activo";
        }

        public CarneMascota(string codigo) : this()
        {
            Codigo = codigo;
        }
    }

    public class Mascota
    {
        public string IdMascota { get; set; }
        public CarneMascota Carne { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; } // "Perro", "Gato", "Conejo", "Ave", etc.
        public string Raza { get; set; }
        public string Edad { get; set; }
        public string Sexo { get; set; } // "Macho", "Hembra"
        public string OtrosDatos { get; set; }
        public string Observaciones { get; set; }
        public string RutaFoto { get; set; }
        public string IdDueno { get; set; }
        public string NombreDueno { get; set; }
        public string CedulaDueno { get; set; }
        public string EstadoActual { get; set; } // "Saludable", "En Tratamiento", "Observacion"
        public HistoriaClinica Historia { get; set; }

        public Mascota()
        {
            IdMascota = Guid.NewGuid().ToString("N").Substring(0, 8);
            Carne = new CarneMascota();
            Historia = new HistoriaClinica();
            EstadoActual = "Saludable";
        }
    }

    public class HistoriaClinica
    {
        public string IdHistoria { get; set; }
        public DateTime FechaApertura { get; set; }
        public List<RegistroMedico> Consultas { get; set; }
        public List<Vacuna> Vacunas { get; set; }
        public List<Desparasitacion> Desparasitaciones { get; set; }
        public List<Tratamiento> Tratamientos { get; set; }
        public List<Diagnostico> Diagnosticos { get; set; }

        public HistoriaClinica()
        {
            IdHistoria = Guid.NewGuid().ToString("N").Substring(0, 8);
            FechaApertura = DateTime.Now;
            Consultas = new List<RegistroMedico>();
            Vacunas = new List<Vacuna>();
            Desparasitaciones = new List<Desparasitacion>();
            Tratamientos = new List<Tratamiento>();
            Diagnosticos = new List<Diagnostico>();
        }
    }

    public class RegistroMedico
    {
        public string IdRegistro { get; set; }
        public DateTime Fecha { get; set; }
        public string Veterinario { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string Medicamentos { get; set; }
        public string Observaciones { get; set; }

        public RegistroMedico()
        {
            IdRegistro = Guid.NewGuid().ToString("N").Substring(0, 8);
            Fecha = DateTime.Now;
        }
    }

    public class Vacuna
    {
        public string IdVacuna { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public DateTime? FechaProxima { get; set; }
        public string Dosis { get; set; }
        public string Lote { get; set; }
        public string Veterinario { get; set; }

        public Vacuna()
        {
            IdVacuna = Guid.NewGuid().ToString("N").Substring(0, 8);
            FechaAplicacion = DateTime.Now;
            Dosis = "1ra Dosis";
        }
    }

    public class Desparasitacion
    {
        public string IdDesparasitacion { get; set; }
        public string Tipo { get; set; } // "Interna", "Externa", "Mixta"
        public string Producto { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public DateTime? FechaProxima { get; set; }
        public string Peso { get; set; }
        public string Veterinario { get; set; }

        public Desparasitacion()
        {
            IdDesparasitacion = Guid.NewGuid().ToString("N").Substring(0, 8);
            FechaAplicacion = DateTime.Now;
            Tipo = "Interna";
        }
    }

    public class Diagnostico
    {
        public string IdDiagnostico { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Gravedad { get; set; } // "Leve", "Moderada", "Alta"
        public string Veterinario { get; set; }

        public Diagnostico()
        {
            IdDiagnostico = Guid.NewGuid().ToString("N").Substring(0, 8);
            Fecha = DateTime.Now;
            Gravedad = "Leve";
        }
    }

    public class Tratamiento
    {
        public string IdTratamiento { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Medicamentos { get; set; }
        public string Indicaciones { get; set; }
        public string Veterinario { get; set; }

        public Tratamiento()
        {
            IdTratamiento = Guid.NewGuid().ToString("N").Substring(0, 8);
            FechaInicio = DateTime.Now;
        }
    }

    public class Cita
    {
        public string IdCita { get; set; }
        public string IdMascota { get; set; }
        public string NombreMascota { get; set; }
        public string IdDueno { get; set; }
        public string NombreDueno { get; set; }
        public string Veterinario { get; set; }
        public DateTime FechaHora { get; set; }
        public string Motivo { get; set; }
        public string Estado { get; set; } // "Confirmada", "Pendiente", "Completada", "Cancelada"

        public Cita()
        {
            IdCita = Guid.NewGuid().ToString("N").Substring(0, 8);
            Estado = "Confirmada";
        }
    }

    public class Notificacion
    {
        public string IdNotificacion { get; set; }
        public string IdUsuario { get; set; }
        public string Titulo { get; set; }
        public string Mensaje { get; set; }
        public DateTime Fecha { get; set; }
        public bool Leida { get; set; }

        public Notificacion()
        {
            IdNotificacion = Guid.NewGuid().ToString("N").Substring(0, 8);
            Fecha = DateTime.Now;
            Leida = false;
        }
    }

    // =========================================================================
    // MODELO RAÍZ SERIALIZABLE PARA JSON
    // =========================================================================
    public class DatosSistema
    {
        public List<Administrador> Administradores { get; set; }
        public List<Dueno> Duenos { get; set; }
        public List<Veterinario> Veterinarios { get; set; }
        public List<Mascota> Mascotas { get; set; }
        public List<Cita> Citas { get; set; }
        public List<Notificacion> Notificaciones { get; set; }

        public DatosSistema()
        {
            Administradores = new List<Administrador>();
            Duenos = new List<Dueno>();
            Veterinarios = new List<Veterinario>();
            Mascotas = new List<Mascota>();
            Citas = new List<Cita>();
            Notificaciones = new List<Notificacion>();
        }
    }

    // =========================================================================
    // GESTOR DE DATOS, PERSISTENCIA Y RECURSOS SONOROS
    // =========================================================================
    public static class GestorDatos
    {
        private static DatosSistema _datos;
        private static readonly string CarpetaBase = AppDomain.CurrentDomain.BaseDirectory;
        private static readonly string CarpetaData = Path.Combine(CarpetaBase, "Data");
        private static readonly string ArchivoJson = Path.Combine(CarpetaData, "datos.json");

        public static DatosSistema Datos
        {
            get
            {
                if (_datos == null) Inicializar();
                return _datos;
            }
        }

        public static void Inicializar()
        {
            try
            {
                if (!Directory.Exists(CarpetaData))
                {
                    Directory.CreateDirectory(CarpetaData);
                }

                if (File.Exists(ArchivoJson))
                {
                    string json = File.ReadAllText(ArchivoJson);
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    serializer.MaxJsonLength = int.MaxValue;
                    _datos = serializer.Deserialize<DatosSistema>(json);
                }

                if (_datos == null || _datos.Veterinarios.Count == 0)
                {
                    CrearDatosIniciales();
                }
                else
                {
                    // Asegurar que exista la lista y el usuario administrador por defecto
                    if (_datos.Administradores == null)
                    {
                        _datos.Administradores = new List<Administrador>();
                    }

                    if (!_datos.Administradores.Any(a => a.NombreUsuario.Equals("admin", StringComparison.OrdinalIgnoreCase)))
                    {
                        _datos.Administradores.Add(new Administrador
                        {
                            Id = "admin01",
                            NombreUsuario = "admin",
                            NombreCompleto = "Administrador del Sistema",
                            Correo = "admin@huellitas.com",
                            TipoIdentificacion = "Cédula de Ciudadanía",
                            NumeroIdentificacion = "00000000",
                            Contrasena = "123",
                            Telefono = "3000000000",
                            Direccion = "Sede Central Huellitas",
                            FotoPerfil = "doctor_avatar.jpg"
                        });
                        Guardar();
                    }
                }
            }
            catch
            {
                CrearDatosIniciales();
            }
        }

        public static void Guardar()
        {
            try
            {
                if (!Directory.Exists(CarpetaData))
                {
                    Directory.CreateDirectory(CarpetaData);
                }

                JavaScriptSerializer serializer = new JavaScriptSerializer();
                serializer.MaxJsonLength = int.MaxValue;
                string json = serializer.Serialize(_datos);
                File.WriteAllText(ArchivoJson, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar datos: " + ex.Message, "Error de Persistencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Usuario Autenticar(string nombreUsuario, string contrasena)
        {
            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contrasena))
                return null;

            // 1. Buscar en administradores
            if (Datos.Administradores != null)
            {
                var admin = Datos.Administradores.FirstOrDefault(a =>
                    (a.NombreUsuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase) ||
                     a.Correo.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase)) &&
                    a.Contrasena == contrasena);
                if (admin != null) return admin;
            }

            // 2. Buscar en veterinarios
            var doc = Datos.Veterinarios.FirstOrDefault(v =>
                (v.NombreUsuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase) ||
                 v.Correo.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase)) &&
                v.Contrasena == contrasena);

            if (doc != null) return doc;

            // 3. Buscar en dueños
            var dueno = Datos.Duenos.FirstOrDefault(d =>
                (d.NombreUsuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase) ||
                 d.Correo.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase)) &&
                d.Contrasena == contrasena);

            return dueno;
        }

        public static string GenerarSiguienteCodigoCarne()
        {
            int maxNum = 44;
            foreach (var m in Datos.Mascotas)
            {
                if (m.Carne != null && !string.IsNullOrEmpty(m.Carne.Codigo) && m.Carne.Codigo.StartsWith("MC-"))
                {
                    int n;
                    if (int.TryParse(m.Carne.Codigo.Substring(3), out n))
                    {
                        if (n > maxNum) maxNum = n;
                    }
                }
            }
            return string.Format("MC-{0:D3}", maxNum + 1);
        }

        public static Mascota BuscarMascotaPorCarne(string codigoCarne)
        {
            if (string.IsNullOrEmpty(codigoCarne)) return null;
            return Datos.Mascotas.FirstOrDefault(m =>
                m.Carne != null &&
                m.Carne.Codigo.Equals(codigoCarne.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        public static List<Mascota> BuscarMascotasPorCedulaDueno(string cedula)
        {
            if (string.IsNullOrEmpty(cedula)) return new List<Mascota>();
            return Datos.Mascotas.Where(m =>
                !string.IsNullOrEmpty(m.CedulaDueno) &&
                m.CedulaDueno.Trim() == cedula.Trim()).ToList();
        }

        public static void ReproducirSonido(string tipo)
        {
            try
            {
                string archivo = Path.Combine(CarpetaBase, "Sounds", tipo + ".wav");
                if (File.Exists(archivo))
                {
                    using (SoundPlayer player = new SoundPlayer(archivo))
                    {
                        player.Play();
                    }
                }
                else
                {
                    // Fallback a sonidos del sistema
                    if (tipo == "error") SystemSounds.Hand.Play();
                    else if (tipo == "exito" || tipo == "login") SystemSounds.Asterisk.Play();
                    else SystemSounds.Beep.Play();
                }
            }
            catch
            {
                // Manejo silencioso para no interrumpir el flujo
            }
        }

        private static void CrearDatosIniciales()
        {
            _datos = new DatosSistema();

            // 0. Administrador por defecto
            var admin = new Administrador
            {
                Id = "admin01",
                NombreUsuario = "admin",
                NombreCompleto = "Administrador del Sistema",
                Correo = "admin@huellitas.com",
                TipoIdentificacion = "Cédula de Ciudadanía",
                NumeroIdentificacion = "00000000",
                Contrasena = "123",
                Telefono = "3000000000",
                Direccion = "Sede Central Huellitas",
                FotoPerfil = "doctor_avatar.jpg"
            };
            _datos.Administradores.Add(admin);

            // 1. Veterinario de prueba
            var doctor = new Veterinario
            {
                Id = "vet01",
                NombreUsuario = "drperez",
                NombreCompleto = "Dr. Andrés Pérez",
                Correo = "perez@huellitas.com",
                TipoIdentificacion = "Cédula de Ciudadanía",
                NumeroIdentificacion = "10203040",
                Contrasena = "1234",
                Telefono = "3001234567",
                Direccion = "Av. Principal # 10-20",
                MatriculaProfesional = "MP-78945",
                Especialidad = "Medicina General y Cirugía Menor",
                FotoPerfil = "doctor_avatar.jpg"
            };
            _datos.Veterinarios.Add(doctor);

            // 2. Dueña de prueba
            var duena = new Dueno
            {
                Id = "dueno01",
                NombreUsuario = "luisa",
                NombreCompleto = "Luisa Carvajal",
                Correo = "luisa@gmail.com",
                TipoIdentificacion = "Cédula de Ciudadanía",
                NumeroIdentificacion = "1098765432",
                Contrasena = "1234",
                Telefono = "3105551234",
                Direccion = "Calle 45 # 12-30",
                FotoPerfil = "dueno_avatar.jpg",
                IdsMascotas = new List<string> { "m01", "m02" }
            };
            _datos.Duenos.Add(duena);

            // 3. Mascota 1: Luna (MC-045)
            var luna = new Mascota
            {
                IdMascota = "m01",
                Carne = new CarneMascota("MC-045"),
                Nombre = "Luna",
                Especie = "Perro",
                Raza = "Husky Siberiano",
                Edad = "3 años",
                Sexo = "Hembra",
                OtrosDatos = "Pelaje blanco con ojos celestes",
                Observaciones = "Mascota muy activa y sociable.",
                RutaFoto = "luna.jpg",
                IdDueno = duena.Id,
                NombreDueno = duena.NombreCompleto,
                CedulaDueno = duena.NumeroIdentificacion,
                EstadoActual = "Saludable"
            };

            // Historia clínica de Luna
            luna.Historia.Consultas.Add(new RegistroMedico
            {
                Fecha = new DateTime(2025, 11, 12),
                Veterinario = "Dr. Pérez",
                Diagnostico = "Infección respiratoria",
                Tratamiento = "Antibiótico y reposo",
                Medicamentos = "Amoxicilina 250 mg c/12 h",
                Observaciones = "Mejora progresiva."
            });
            luna.Historia.Consultas.Add(new RegistroMedico
            {
                Fecha = new DateTime(2025, 8, 20),
                Veterinario = "Dra. María López",
                Diagnostico = "Control general",
                Tratamiento = "Revisión y limpieza",
                Medicamentos = "Multivitamínico",
                Observaciones = "Sin novedades."
            });
            luna.Historia.Consultas.Add(new RegistroMedico
            {
                Fecha = new DateTime(2025, 5, 15),
                Veterinario = "Dr. Andrés Gómez",
                Diagnostico = "Vacunación anual",
                Tratamiento = "Aplicación de vacuna",
                Medicamentos = "Vacuna antirrábica",
                Observaciones = "Todo bien."
            });

            // Vacunas de Luna
            luna.Historia.Vacunas.Add(new Vacuna
            {
                Nombre = "Antirrábica",
                FechaAplicacion = new DateTime(2025, 5, 15),
                FechaProxima = new DateTime(2026, 5, 15),
                Dosis = "Anual",
                Lote = "LOT-2025-A",
                Veterinario = "Dr. Andrés Pérez"
            });
            luna.Historia.Vacunas.Add(new Vacuna
            {
                Nombre = "Séxtuple",
                FechaAplicacion = new DateTime(2025, 5, 15),
                FechaProxima = new DateTime(2026, 5, 15),
                Dosis = "Refuerzo",
                Lote = "LOT-9981-S",
                Veterinario = "Dr. Andrés Pérez"
            });

            // Desparasitación de Luna
            luna.Historia.Desparasitaciones.Add(new Desparasitacion
            {
                Tipo = "Pipeta interna",
                Producto = "Bravecto Plus",
                FechaAplicacion = new DateTime(2025, 8, 20),
                FechaProxima = new DateTime(2025, 11, 20),
                Peso = "22 kg",
                Veterinario = "Dra. María López"
            });

            // Tratamientos de Luna
            luna.Historia.Tratamientos.Add(new Tratamiento
            {
                FechaInicio = new DateTime(2025, 11, 12),
                FechaFin = new DateTime(2025, 11, 22),
                Medicamentos = "Amoxicilina 250 mg c/12h",
                Indicaciones = "Tomar con las comidas por 10 días",
                Veterinario = "Dr. Pérez"
            });

            _datos.Mascotas.Add(luna);

            // 4. Mascota 2: Rayo (MC-046)
            var rayo = new Mascota
            {
                IdMascota = "m02",
                Carne = new CarneMascota("MC-046"),
                Nombre = "Rayo",
                Especie = "Gallo",
                Raza = "Gallo Fino Criollo",
                Edad = "1 año",
                Sexo = "Macho",
                OtrosDatos = "Cresta roja brillante",
                Observaciones = "Excelente plumaje y temperamento enérgico.",
                RutaFoto = "rayo.jpg",
                IdDueno = duena.Id,
                NombreDueno = duena.NombreCompleto,
                CedulaDueno = duena.NumeroIdentificacion,
                EstadoActual = "Saludable"
            };
            rayo.Historia.Vacunas.Add(new Vacuna
            {
                Nombre = "Marek y Newcastle",
                FechaAplicacion = new DateTime(2025, 9, 10),
                FechaProxima = new DateTime(2026, 9, 10),
                Dosis = "Dosis Única",
                Lote = "LOT-AV-44",
                Veterinario = "Dr. Andrés Pérez"
            });
            _datos.Mascotas.Add(rayo);

            // 5. Citas de prueba
            _datos.Citas.Add(new Cita
            {
                IdCita = "c01",
                IdMascota = luna.IdMascota,
                NombreMascota = luna.Nombre,
                IdDueno = duena.Id,
                NombreDueno = duena.NombreCompleto,
                Veterinario = doctor.NombreCompleto,
                FechaHora = new DateTime(2026, 11, 25, 9, 0, 0),
                Motivo = "Consulta de control y revisión respiratoria",
                Estado = "Confirmada"
            });

            // 6. Notificaciones de prueba
            _datos.Notificaciones.Add(new Notificacion
            {
                IdUsuario = duena.Id,
                Titulo = "Recomendación médica",
                Mensaje = "Tu mascota Luna tiene una nueva recomendación médica registrada.",
                Fecha = DateTime.Now.AddDays(-1),
                Leida = false
            });

            Guardar();
        }
    }
}
