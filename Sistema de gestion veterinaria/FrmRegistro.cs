using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_de_gestion_veterinaria
{
    public partial class FrmRegistro : Form
    {
        private string _rolSeleccionado = "Dueño";
        public bool ModoAdmin { get; set; } = false;

        public FrmRegistro() : this(false, null)
        {
        }

        public FrmRegistro(bool esAdmin, string cedulaPrellenada = null)
        {
            InitializeComponent();
            ModoAdmin = esAdmin;
            ConfigurarFormulario();

            if (!string.IsNullOrEmpty(cedulaPrellenada))
            {
                txtNumeroIdentificacion.Text = cedulaPrellenada;
            }
        }

        private void ConfigurarFormulario()
        {
            try
            {
                string iconPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "app.ico");
                if (File.Exists(iconPath)) this.Icon = new Icon(iconPath);

                string regImg = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "Registro.jpeg");
                if (File.Exists(regImg)) picAnimales.Image = Image.FromFile(regImg);
            }
            catch { }

            cmbTipoIdentificacion.SelectedIndex = 0;

            btnRolDueno.Click += (s, e) => SeleccionarRol("Dueño");
            btnRolVeterinario.Click += (s, e) => SeleccionarRol("Veterinario");

            btnRegistrarUsuario.Click += BtnRegistrarUsuario_Click;
            btnVolver.Click += (s, e) => { GestorDatos.ReproducirSonido("click"); this.Close(); };

            if (!ModoAdmin)
            {
                // En registro público o registro express de cliente, solo se permite registrar Dueño
                lblSubtitulo.Text = "Registro Oficial de Propietario / Dueño de Mascota:";
                btnRolDueno.Location = new Point(20, 78);
                btnRolDueno.Size = new Size(460, 48);
                btnRolDueno.Text = "🐾  Registro de Dueño de Mascota (Tutor Legal)";
                btnRolVeterinario.Visible = false;
                SeleccionarRol("Dueño");
            }
            else
            {
                // En modo Administrador, se permite crear Dueño o Veterinario
                lblSubtitulo.Text = "Selecciona el rol que registrarás en el sistema:";
                btnRolDueno.Location = new Point(20, 78);
                btnRolDueno.Size = new Size(225, 52);
                btnRolDueno.Text = "🐾  Dueño de Mascota\r\nRegistra sus mascotas";
                btnRolVeterinario.Visible = true;
                SeleccionarRol("Dueño");
            }
        }

        private void SeleccionarRol(string rol)
        {
            GestorDatos.ReproducirSonido("click");
            _rolSeleccionado = rol;

            if (rol == "Dueño")
            {
                btnRolDueno.BackColor = Color.FromArgb(235, 247, 240);
                btnRolDueno.FlatAppearance.BorderColor = Color.FromArgb(15, 113, 75);
                btnRolDueno.FlatAppearance.BorderSize = 2;
                btnRolDueno.ForeColor = Color.FromArgb(15, 113, 75);

                btnRolVeterinario.BackColor = Color.White;
                btnRolVeterinario.FlatAppearance.BorderColor = Color.FromArgb(180, 210, 195);
                btnRolVeterinario.FlatAppearance.BorderSize = 1;
                btnRolVeterinario.ForeColor = Color.FromArgb(60, 90, 75);

                pnlCamposVeterinario.Visible = false;
                btnRegistrarUsuario.Location = new Point(20, 395);
                btnVolver.Location = new Point(330, 395);
            }
            else
            {
                btnRolVeterinario.BackColor = Color.FromArgb(235, 247, 240);
                btnRolVeterinario.FlatAppearance.BorderColor = Color.FromArgb(15, 113, 75);
                btnRolVeterinario.FlatAppearance.BorderSize = 2;
                btnRolVeterinario.ForeColor = Color.FromArgb(15, 113, 75);

                btnRolDueno.BackColor = Color.White;
                btnRolDueno.FlatAppearance.BorderColor = Color.FromArgb(180, 210, 195);
                btnRolDueno.FlatAppearance.BorderSize = 1;
                btnRolDueno.ForeColor = Color.FromArgb(60, 90, 75);

                pnlCamposVeterinario.Visible = true;
                btnRegistrarUsuario.Location = new Point(20, 445);
                btnVolver.Location = new Point(330, 445);
            }
        }

        private void BtnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            GestorDatos.ReproducirSonido("click");

            string nombre = txtNombreCompleto.Text.Trim();
            string usuario = txtNombreUsuario.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string tipoId = cmbTipoIdentificacion.SelectedItem != null ? cmbTipoIdentificacion.SelectedItem.ToString() : "Cédula de Ciudadanía";
            string numId = txtNumeroIdentificacion.Text.Trim();
            string pass = txtContrasena.Text.Trim();
            string tel = txtTelefono.Text.Trim();
            string dir = txtDireccion.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(correo) ||
                string.IsNullOrEmpty(numId) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(tel) || string.IsNullOrEmpty(dir))
            {
                GestorDatos.ReproducirSonido("error");
                MessageBox.Show("Por favor completa todos los campos obligatorios (*).", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el usuario o cédula no existan previamente
            bool existeUsuario = GestorDatos.Datos.Veterinarios.Any(v => v.NombreUsuario.Equals(usuario, StringComparison.OrdinalIgnoreCase)) ||
                                 GestorDatos.Datos.Duenos.Any(d => d.NombreUsuario.Equals(usuario, StringComparison.OrdinalIgnoreCase));

            if (existeUsuario)
            {
                GestorDatos.ReproducirSonido("error");
                MessageBox.Show("El nombre de usuario '" + usuario + "' ya se encuentra registrado. Por favor elige otro.", "Usuario Ya Existe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_rolSeleccionado == "Veterinario")
            {
                string matricula = txtMatricula.Text.Trim();
                string especialidad = txtEspecialidad.Text.Trim();

                if (string.IsNullOrEmpty(matricula) || string.IsNullOrEmpty(especialidad))
                {
                    GestorDatos.ReproducirSonido("error");
                    MessageBox.Show("Para el rol de Veterinario, la Matrícula Profesional y Especialidad son obligatorias.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Veterinario nuevoVet = new Veterinario
                {
                    NombreCompleto = nombre,
                    NombreUsuario = usuario,
                    Correo = correo,
                    TipoIdentificacion = tipoId,
                    NumeroIdentificacion = numId,
                    Contrasena = pass,
                    Telefono = tel,
                    Direccion = dir,
                    MatriculaProfesional = matricula,
                    Especialidad = especialidad,
                    FotoPerfil = "doctor_avatar.jpg"
                };

                GestorDatos.Datos.Veterinarios.Add(nuevoVet);
            }
            else
            {
                Dueno nuevoDueno = new Dueno
                {
                    NombreCompleto = nombre,
                    NombreUsuario = usuario,
                    Correo = correo,
                    TipoIdentificacion = tipoId,
                    NumeroIdentificacion = numId,
                    Contrasena = pass,
                    Telefono = tel,
                    Direccion = dir,
                    FotoPerfil = "dueno_avatar.jpg"
                };

                GestorDatos.Datos.Duenos.Add(nuevoDueno);
            }

            GestorDatos.Guardar();
            GestorDatos.ReproducirSonido("exito");

            MessageBox.Show("¡Usuario registrado con éxito en Huellitas! Ahora puedes iniciar sesión con tus credenciales.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
