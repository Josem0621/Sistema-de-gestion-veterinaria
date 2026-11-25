using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_de_gestion_veterinaria
{
    public partial class FrmMenuAdmin : Form
    {
        private Usuario _usuarioSeleccionado;

        public FrmMenuAdmin()
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

            // Configurar columnas de grilla de usuarios
            dgvUsuarios.Columns.Clear();
            dgvUsuarios.Columns.Add("colRol", "Rol");
            dgvUsuarios.Columns.Add("colNombre", "Nombre Completo");
            dgvUsuarios.Columns.Add("colUsuario", "Usuario");
            dgvUsuarios.Columns.Add("colDoc", "Documento");
            dgvUsuarios.Columns.Add("colCorreo", "Correo");
            dgvUsuarios.Columns.Add("colTel", "Teléfono");
            dgvUsuarios.Columns.Add("colClave", "Contraseña");
            dgvUsuarios.Columns.Add("colExtra", "Detalle");

            dgvUsuarios.Columns["colRol"].FillWeight = 85;
            dgvUsuarios.Columns["colNombre"].FillWeight = 120;
            dgvUsuarios.Columns["colUsuario"].FillWeight = 85;
            dgvUsuarios.Columns["colDoc"].FillWeight = 85;
            dgvUsuarios.Columns["colCorreo"].FillWeight = 110;
            dgvUsuarios.Columns["colTel"].FillWeight = 85;
            dgvUsuarios.Columns["colClave"].FillWeight = 85;
            dgvUsuarios.Columns["colExtra"].FillWeight = 120;

            cmbFiltroRol.SelectedIndex = 0;

            // Eventos
            txtBuscar.TextChanged += (s, e) => CargarUsuarios();
            cmbFiltroRol.SelectedIndexChanged += (s, e) => CargarUsuarios();
            dgvUsuarios.SelectionChanged += DgvUsuarios_SelectionChanged;
            btnActualizarContrasena.Click += BtnActualizarContrasena_Click;
            btnEliminarUsuario.Click += BtnEliminarUsuario_Click;
            btnNavRegistrarUsuario.Click += (s, e) =>
            {
                GestorDatos.ReproducirSonido("click");
                FrmRegistro frm = new FrmRegistro(esAdmin: true);
                frm.FormClosed += (evSender, evArgs) => CargarUsuarios();
                frm.ShowDialog();
            };
            btnCerrarSesion.Click += (s, e) => { GestorDatos.ReproducirSonido("click"); this.Close(); };

            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            string filtroTexto = txtBuscar.Text.Trim().ToLower();
            string filtroRol = cmbFiltroRol.SelectedItem != null ? cmbFiltroRol.SelectedItem.ToString() : "Todos los roles";

            List<Usuario> listaTotal = new List<Usuario>();

            // Agregar Dueños
            if (filtroRol == "Todos los roles" || filtroRol == "Dueño")
            {
                listaTotal.AddRange(GestorDatos.Datos.Duenos);
            }

            // Agregar Veterinarios
            if (filtroRol == "Todos los roles" || filtroRol == "Veterinario")
            {
                listaTotal.AddRange(GestorDatos.Datos.Veterinarios);
            }

            // Filtrar por texto
            if (!string.IsNullOrEmpty(filtroTexto))
            {
                listaTotal = listaTotal.Where(u =>
                    (u.NombreCompleto != null && u.NombreCompleto.ToLower().Contains(filtroTexto)) ||
                    (u.NombreUsuario != null && u.NombreUsuario.ToLower().Contains(filtroTexto)) ||
                    (u.NumeroIdentificacion != null && u.NumeroIdentificacion.Contains(filtroTexto)) ||
                    (u.Correo != null && u.Correo.ToLower().Contains(filtroTexto))
                ).ToList();
            }

            dgvUsuarios.Rows.Clear();

            foreach (var u in listaTotal)
            {
                string extra = "";
                if (u is Veterinario vet)
                {
                    extra = "Mat: " + vet.MatriculaProfesional + " | " + vet.Especialidad;
                }
                else if (u is Dueno dueno)
                {
                    int cantMascotas = GestorDatos.Datos.Mascotas.Count(m => m.IdDueno == dueno.Id || m.CedulaDueno == dueno.NumeroIdentificacion);
                    extra = cantMascotas + " mascota(s) registrada(s)";
                }

                int rowIndex = dgvUsuarios.Rows.Add(
                    u.Rol,
                    u.NombreCompleto,
                    u.NombreUsuario,
                    u.NumeroIdentificacion,
                    u.Correo,
                    u.Telefono,
                    u.Contrasena,
                    extra
                );

                dgvUsuarios.Rows[rowIndex].Tag = u;
            }

            // Actualizar métricas
            int cantDuenos = GestorDatos.Datos.Duenos.Count;
            int cantVets = GestorDatos.Datos.Veterinarios.Count;
            lblNumTotalUsuarios.Text = (cantDuenos + cantVets).ToString();
            lblNumTotalDuenos.Text = cantDuenos.ToString();
            lblNumTotalVets.Text = cantVets.ToString();
            lblNumTotalMascotas.Text = GestorDatos.Datos.Mascotas.Count.ToString();

            if (dgvUsuarios.Rows.Count > 0)
            {
                dgvUsuarios.Rows[0].Selected = true;
            }
            else
            {
                LimpiarDetalle();
            }
        }

        private void DgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                _usuarioSeleccionado = dgvUsuarios.SelectedRows[0].Tag as Usuario;
                MostrarDetalle(_usuarioSeleccionado);
            }
            else
            {
                LimpiarDetalle();
            }
        }

        private void MostrarDetalle(Usuario u)
        {
            if (u == null)
            {
                LimpiarDetalle();
                return;
            }

            lblInfoNombre.Text = "Nombre: " + u.NombreCompleto;
            lblInfoUsuario.Text = "Usuario: " + u.NombreUsuario;
            lblInfoRol.Text = "Rol: " + u.Rol;
            lblInfoDoc.Text = "Documento: " + (u.TipoIdentificacion ?? "C.C.") + " " + u.NumeroIdentificacion;
            lblInfoCorreo.Text = "Correo: " + u.Correo;
            lblInfoTel.Text = "Teléfono: " + u.Telefono;

            if (u is Veterinario vet)
            {
                lblInfoExtra.Text = "Matrícula: " + vet.MatriculaProfesional + "\nEspecialidad: " + vet.Especialidad;
            }
            else if (u is Dueno dueno)
            {
                var mascotas = GestorDatos.Datos.Mascotas.Where(m => m.IdDueno == dueno.Id || m.CedulaDueno == dueno.NumeroIdentificacion).ToList();
                string nombres = mascotas.Count > 0 ? string.Join(", ", mascotas.Select(m => m.Nombre + " (" + (m.Carne != null ? m.Carne.Codigo : "N/A") + ")")) : "Ninguna";
                lblInfoExtra.Text = "Mascotas (" + mascotas.Count + "): " + nombres;
            }
            else
            {
                lblInfoExtra.Text = "Detalle: Cuenta de sistema";
            }

            txtNuevaContrasena.Text = u.Contrasena;
        }

        private void LimpiarDetalle()
        {
            _usuarioSeleccionado = null;
            lblInfoNombre.Text = "Nombre: Ningún usuario seleccionado";
            lblInfoUsuario.Text = "Usuario: -";
            lblInfoRol.Text = "Rol: -";
            lblInfoDoc.Text = "Documento: -";
            lblInfoCorreo.Text = "Correo: -";
            lblInfoTel.Text = "Teléfono: -";
            lblInfoExtra.Text = "Detalle: -";
            txtNuevaContrasena.Clear();
        }

        private void BtnActualizarContrasena_Click(object sender, EventArgs e)
        {
            if (_usuarioSeleccionado == null)
            {
                GestorDatos.ReproducirSonido("error");
                MessageBox.Show("Por favor selecciona un usuario de la lista para modificar su contraseña.", "Seleccionar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nuevaClave = txtNuevaContrasena.Text.Trim();
            if (string.IsNullOrEmpty(nuevaClave))
            {
                GestorDatos.ReproducirSonido("error");
                MessageBox.Show("La contraseña no puede estar vacía.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GestorDatos.ReproducirSonido("click");

            _usuarioSeleccionado.Contrasena = nuevaClave;
            GestorDatos.Guardar();
            GestorDatos.ReproducirSonido("exito");

            MessageBox.Show(
                string.Format("¡Contraseña actualizada exitosamente!\n\nUsuario: {0} ({1})\nNueva contraseña: {2}",
                _usuarioSeleccionado.NombreUsuario, _usuarioSeleccionado.NombreCompleto, nuevaClave),
                "Contraseña Actualizada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            CargarUsuarios();
        }

        private void BtnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (_usuarioSeleccionado == null)
            {
                GestorDatos.ReproducirSonido("error");
                MessageBox.Show("Por favor selecciona un usuario de la lista para eliminar.", "Seleccionar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_usuarioSeleccionado.NombreUsuario.Equals("admin", StringComparison.OrdinalIgnoreCase))
            {
                GestorDatos.ReproducirSonido("error");
                MessageBox.Show("No es posible eliminar la cuenta principal de Administrador.", "Acción Denegada", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                string.Format("¿Estás seguro de que deseas eliminar permanentemente al usuario '{0}' ({1} - {2})?\n\nEsta acción no se puede deshacer.",
                _usuarioSeleccionado.NombreUsuario, _usuarioSeleccionado.NombreCompleto, _usuarioSeleccionado.Rol),
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                GestorDatos.ReproducirSonido("click");

                if (_usuarioSeleccionado is Dueno dueno)
                {
                    GestorDatos.Datos.Duenos.Remove(dueno);
                }
                else if (_usuarioSeleccionado is Veterinario vet)
                {
                    GestorDatos.Datos.Veterinarios.Remove(vet);
                }

                GestorDatos.Guardar();
                GestorDatos.ReproducirSonido("exito");

                MessageBox.Show("El usuario ha sido eliminado correctamente del sistema.", "Usuario Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarUsuarios();
            }
        }
    }
}
