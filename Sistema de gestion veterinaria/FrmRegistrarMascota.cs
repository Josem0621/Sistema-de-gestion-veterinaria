using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_de_gestion_veterinaria
{
    public partial class FrmRegistrarMascota : Form
    {
        private string _rutaFotoSeleccionada = null;
        private string _nombreArchivoDestino = null;

        public FrmRegistrarMascota()
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

            // Saludo personalizado
            if (SesionActual.UsuarioLogueado != null)
            {
                lblHeaderSaludo.Text = "¡Hola, " + SesionActual.UsuarioLogueado.NombreCompleto.Split(' ')[0] + "!";
            }

            cmbEdad.SelectedIndex = 3; // 1 año
            cmbEspecie.SelectedIndex = 0; // Perro

            btnSeleccionarFoto.Click += BtnSeleccionarFoto_Click;
            btnQuitarFoto.Click += BtnQuitarFoto_Click;
            btnLimpiar.Click += BtnLimpiar_Click;
            btnRegistrar.Click += BtnRegistrar_Click;
            btnBuscarDueno.Click += (s, e) => ValidarYBuscarDueno(true);
            txtCedulaDueno.Leave += (s, e) => { if (!string.IsNullOrEmpty(txtCedulaDueno.Text.Trim())) ValidarYBuscarDueno(false); };
            txtCedulaDueno.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; ValidarYBuscarDueno(true); } };
            btnNavVolver.Click += (s, e) => { GestorDatos.ReproducirSonido("click"); this.Close(); };
        }

        private void BtnSeleccionarFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Seleccionar foto de la mascota";
                ofd.Filter = "Imágenes (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _rutaFotoSeleccionada = ofd.FileName;
                    picFotoMascota.Image = Image.FromFile(_rutaFotoSeleccionada);
                    btnQuitarFoto.Visible = true;
                }
            }
        }

        private void BtnQuitarFoto_Click(object sender, EventArgs e)
        {
            _rutaFotoSeleccionada = null;
            _nombreArchivoDestino = null;
            picFotoMascota.Image = null;
            btnQuitarFoto.Visible = false;
        }

        private Dueno ValidarYBuscarDueno(bool mostrarAlertaSiNoExiste)
        {
            string cedula = txtCedulaDueno.Text.Trim();
            if (string.IsNullOrEmpty(cedula))
            {
                lblNombreDueno.Text = "Ingresa C.C. para asociar";
                lblNombreDueno.ForeColor = Color.FromArgb(80, 100, 90);
                return null;
            }

            var dueno = GestorDatos.Datos.Duenos.FirstOrDefault(d => d.NumeroIdentificacion == cedula);
            if (dueno != null)
            {
                lblNombreDueno.Text = "✓ " + dueno.NombreCompleto;
                lblNombreDueno.ForeColor = Color.FromArgb(15, 113, 75);
                return dueno;
            }
            else
            {
                lblNombreDueno.Text = "✗ Dueño no encontrado";
                lblNombreDueno.ForeColor = Color.FromArgb(185, 28, 28);

                if (mostrarAlertaSiNoExiste)
                {
                    GestorDatos.ReproducirSonido("error");
                    var res = MessageBox.Show(
                        "No se encontró ningún dueño registrado con la C.C. " + cedula + ".\n\n" +
                        "¿Deseas abrir la ventana para registrar al dueño ahora mismo?",
                        "Dueño no Registrado",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (res == DialogResult.Yes)
                    {
                        // Abrir registro exprés de dueño con la cédula pre-llenada
                        FrmRegistro frmReg = new FrmRegistro(esAdmin: false, cedulaPrellenada: cedula);
                        if (frmReg.ShowDialog() == DialogResult.OK || frmReg.DialogResult == DialogResult.OK)
                        {
                            // Volver a verificar
                            dueno = GestorDatos.Datos.Duenos.FirstOrDefault(d => d.NumeroIdentificacion == cedula);
                            if (dueno != null)
                            {
                                lblNombreDueno.Text = "✓ " + dueno.NombreCompleto;
                                lblNombreDueno.ForeColor = Color.FromArgb(15, 113, 75);
                                return dueno;
                            }
                        }
                    }
                }
                return null;
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            GestorDatos.ReproducirSonido("click");
            txtNombre.Clear();
            txtRaza.Clear();
            txtOtrosDatos.Clear();
            txtCedulaDueno.Clear();
            lblNombreDueno.Text = "Ingresa C.C. para asociar";
            lblNombreDueno.ForeColor = Color.FromArgb(80, 100, 90);
            txtObservaciones.Clear();
            cmbEdad.SelectedIndex = 3;
            cmbEspecie.SelectedIndex = 0;
            rdoMacho.Checked = true;
            BtnQuitarFoto_Click(sender, e);
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            GestorDatos.ReproducirSonido("click");

            string nombre = txtNombre.Text.Trim();
            string especie = cmbEspecie.SelectedItem != null ? cmbEspecie.SelectedItem.ToString() : "Perro";
            string raza = txtRaza.Text.Trim();
            string edad = cmbEdad.SelectedItem != null ? cmbEdad.SelectedItem.ToString() : "1 año";
            string sexo = rdoMacho.Checked ? "Macho" : "Hembra";
            string cedula = txtCedulaDueno.Text.Trim();
            string otros = txtOtrosDatos.Text.Trim();
            string obs = txtObservaciones.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(raza))
            {
                GestorDatos.ReproducirSonido("error");
                MessageBox.Show("Por favor ingresa al menos el Nombre y la Raza de la mascota.", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cedula))
            {
                GestorDatos.ReproducirSonido("error");
                MessageBox.Show("Por favor ingresa la Cédula de Ciudadanía (C.C.) del Propietario para poder vincular la mascota.", "Dueño Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCedulaDueno.Focus();
                return;
            }

            // Validar existencia del dueño
            Dueno duenoAsociado = ValidarYBuscarDueno(true);
            if (duenoAsociado == null)
            {
                GestorDatos.ReproducirSonido("error");
                MessageBox.Show("No se puede registrar la mascota sin un dueño válido activo en el sistema.", "Registro Detenido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCedulaDueno.Focus();
                return;
            }

            // Generar código único de carné
            string nuevoCodigoCarne = GestorDatos.GenerarSiguienteCodigoCarne();

            // Guardar foto en bin\Debug\Images si fue seleccionada
            if (!string.IsNullOrEmpty(_rutaFotoSeleccionada))
            {
                try
                {
                    string dirImages = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
                    if (!Directory.Exists(dirImages)) Directory.CreateDirectory(dirImages);

                    string ext = Path.GetExtension(_rutaFotoSeleccionada);
                    _nombreArchivoDestino = "foto_" + nuevoCodigoCarne + ext;
                    string rutaFinal = Path.Combine(dirImages, _nombreArchivoDestino);

                    File.Copy(_rutaFotoSeleccionada, rutaFinal, true);
                }
                catch
                {
                    _nombreArchivoDestino = null;
                }
            }

            // Dueño asociado
            string idDueno = duenoAsociado.Id;
            string nombreDueno = duenoAsociado.NombreCompleto;
            string cedulaDueno = duenoAsociado.NumeroIdentificacion;

            // Crear objeto Mascota y CarneMascota
            Mascota nuevaMascota = new Mascota
            {
                Nombre = nombre,
                Especie = especie,
                Raza = raza,
                Edad = edad,
                Sexo = sexo,
                OtrosDatos = otros,
                Observaciones = obs,
                RutaFoto = _nombreArchivoDestino,
                IdDueno = idDueno,
                NombreDueno = nombreDueno,
                CedulaDueno = cedulaDueno,
                EstadoActual = "Saludable",
                Carne = new CarneMascota(nuevoCodigoCarne)
            };

            GestorDatos.Datos.Mascotas.Add(nuevaMascota);

            // Agregar notificación al dueño
            GestorDatos.Datos.Notificaciones.Add(new Notificacion
            {
                IdUsuario = idDueno,
                Titulo = "¡Nueva Mascota Registrada!",
                Mensaje = string.Format("Se ha emitido el Carné Digital {0} para tu mascota {1}.", nuevoCodigoCarne, nombre),
                Fecha = DateTime.Now
            });

            GestorDatos.Guardar();
            GestorDatos.ReproducirSonido("exito");

            MessageBox.Show(
                string.Format("¡Mascota registrada exitosamente!\n\n" +
                              "🐾 Código de Carné Digital asignado: {0}\n" +
                              "Mascota: {1} ({2})\n" +
                              "Propietario: {3}\n\n" +
                              "El carné ha quedado activo para consultas médicas y vacunación.",
                              nuevoCodigoCarne, nombre, especie, nombreDueno),
                "Registro de Mascota Exitoso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }
    }
}
