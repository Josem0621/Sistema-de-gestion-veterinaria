namespace Sistema_de_gestion_veterinaria
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.pnlLoginCard = new System.Windows.Forms.Panel();
            this.lblTituloCard = new System.Windows.Forms.Label();
            this.lblSubtituloCard = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.chkVerContrasena = new System.Windows.Forms.CheckBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.btnOlvidaste = new System.Windows.Forms.Button();
            this.lblCredencialesDemo = new System.Windows.Forms.Label();
            this.pnlDecoracion = new System.Windows.Forms.Panel();
            this.wmpVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblLogoNombre = new System.Windows.Forms.Label();
            this.lblLogoSub = new System.Windows.Forms.Label();
            this.lblEslogan = new System.Windows.Forms.Label();
            this.lblPie = new System.Windows.Forms.Label();
            this.pnlFondo.SuspendLayout();
            this.pnlLoginCard.SuspendLayout();
            this.pnlDecoracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(247)))));
            this.pnlFondo.Controls.Add(this.pnlLoginCard);
            this.pnlFondo.Controls.Add(this.pnlDecoracion);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(960, 580);
            this.pnlFondo.TabIndex = 0;
            // 
            // pnlLoginCard
            // 
            this.pnlLoginCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLoginCard.BackColor = System.Drawing.Color.White;
            this.pnlLoginCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLoginCard.Controls.Add(this.lblTituloCard);
            this.pnlLoginCard.Controls.Add(this.lblSubtituloCard);
            this.pnlLoginCard.Controls.Add(this.lblUsuario);
            this.pnlLoginCard.Controls.Add(this.txtUsuario);
            this.pnlLoginCard.Controls.Add(this.lblContrasena);
            this.pnlLoginCard.Controls.Add(this.txtContrasena);
            this.pnlLoginCard.Controls.Add(this.chkVerContrasena);
            this.pnlLoginCard.Controls.Add(this.btnIniciarSesion);
            this.pnlLoginCard.Controls.Add(this.btnCrearUsuario);
            this.pnlLoginCard.Controls.Add(this.btnOlvidaste);
            this.pnlLoginCard.Controls.Add(this.lblCredencialesDemo);
            this.pnlLoginCard.Location = new System.Drawing.Point(500, 45);
            this.pnlLoginCard.Name = "pnlLoginCard";
            this.pnlLoginCard.Size = new System.Drawing.Size(420, 480);
            this.pnlLoginCard.TabIndex = 1;
            // 
            // lblTituloCard
            // 
            this.lblTituloCard.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTituloCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblTituloCard.Location = new System.Drawing.Point(25, 20);
            this.lblTituloCard.Name = "lblTituloCard";
            this.lblTituloCard.Size = new System.Drawing.Size(370, 35);
            this.lblTituloCard.TabIndex = 0;
            this.lblTituloCard.Text = "¡Bienvenido a Huellitas!";
            this.lblTituloCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtituloCard
            // 
            this.lblSubtituloCard.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtituloCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(80)))));
            this.lblSubtituloCard.Location = new System.Drawing.Point(25, 55);
            this.lblSubtituloCard.Name = "lblSubtituloCard";
            this.lblSubtituloCard.Size = new System.Drawing.Size(370, 40);
            this.lblSubtituloCard.TabIndex = 1;
            this.lblSubtituloCard.Text = "Sistema de gestión veterinaria\r\nAdministra pacientes, dueños y citas en un solo l" +
    "ugar.";
            this.lblSubtituloCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(35)))));
            this.lblUsuario.Location = new System.Drawing.Point(35, 110);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 17);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsuario.Location = new System.Drawing.Point(35, 132);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(350, 27);
            this.txtUsuario.TabIndex = 3;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(35)))));
            this.lblContrasena.Location = new System.Drawing.Point(35, 175);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(77, 17);
            this.lblContrasena.TabIndex = 4;
            this.lblContrasena.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(243)))));
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtContrasena.Location = new System.Drawing.Point(35, 197);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(350, 27);
            this.txtContrasena.TabIndex = 5;
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // chkVerContrasena
            // 
            this.chkVerContrasena.AutoSize = true;
            this.chkVerContrasena.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.chkVerContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.chkVerContrasena.Location = new System.Drawing.Point(260, 230);
            this.chkVerContrasena.Name = "chkVerContrasena";
            this.chkVerContrasena.Size = new System.Drawing.Size(128, 19);
            this.chkVerContrasena.TabIndex = 6;
            this.chkVerContrasena.Text = "Mostrar contraseña";
            this.chkVerContrasena.UseVisualStyleBackColor = true;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(35, 260);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(350, 42);
            this.btnIniciarSesion.TabIndex = 7;
            this.btnIniciarSesion.Text = "🐾   Iniciar sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnCrearUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCrearUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnCrearUsuario.Location = new System.Drawing.Point(35, 318);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(168, 38);
            this.btnCrearUsuario.TabIndex = 8;
            this.btnCrearUsuario.Text = "👤  Crear usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            // 
            // btnOlvidaste
            // 
            this.btnOlvidaste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnOlvidaste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOlvidaste.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnOlvidaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOlvidaste.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOlvidaste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.btnOlvidaste.Location = new System.Drawing.Point(212, 318);
            this.btnOlvidaste.Name = "btnOlvidaste";
            this.btnOlvidaste.Size = new System.Drawing.Size(173, 38);
            this.btnOlvidaste.TabIndex = 9;
            this.btnOlvidaste.Text = "🔒  ¿Olvidaste tu contraseña?";
            this.btnOlvidaste.UseVisualStyleBackColor = false;
            // 
            // lblCredencialesDemo
            // 
            this.lblCredencialesDemo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.lblCredencialesDemo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblCredencialesDemo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.lblCredencialesDemo.Location = new System.Drawing.Point(35, 375);
            this.lblCredencialesDemo.Name = "lblCredencialesDemo";
            this.lblCredencialesDemo.Padding = new System.Windows.Forms.Padding(6);
            this.lblCredencialesDemo.Size = new System.Drawing.Size(350, 85);
            this.lblCredencialesDemo.TabIndex = 10;
            this.lblCredencialesDemo.Text = "💡 Usuarios de prueba incluidos:\r\n• Veterinario: drperez | clave: 1234\r\n• Dueño: " +
    "luisa | clave: 1234 (Mascotas: Luna MC-045 y Rayo MC-046)";
            // 
            // pnlDecoracion
            // 
            this.pnlDecoracion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDecoracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.pnlDecoracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDecoracion.Controls.Add(this.wmpVideo);
            this.pnlDecoracion.Controls.Add(this.lblLogoNombre);
            this.pnlDecoracion.Controls.Add(this.lblLogoSub);
            this.pnlDecoracion.Controls.Add(this.lblEslogan);
            this.pnlDecoracion.Controls.Add(this.lblPie);
            this.pnlDecoracion.Location = new System.Drawing.Point(40, 45);
            this.pnlDecoracion.Name = "pnlDecoracion";
            this.pnlDecoracion.Size = new System.Drawing.Size(430, 480);
            this.pnlDecoracion.TabIndex = 0;
            // 
            // wmpVideo
            // 
            this.wmpVideo.Enabled = true;
            this.wmpVideo.Location = new System.Drawing.Point(-11, 110);
            this.wmpVideo.Name = "wmpVideo";
            this.wmpVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpVideo.OcxState")));
            this.wmpVideo.Size = new System.Drawing.Size(480, 270);
            this.wmpVideo.TabIndex = 5;
            // 
            // lblLogoNombre
            // 
            this.lblLogoNombre.AutoSize = true;
            this.lblLogoNombre.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblLogoNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblLogoNombre.Location = new System.Drawing.Point(20, 20);
            this.lblLogoNombre.Name = "lblLogoNombre";
            this.lblLogoNombre.Size = new System.Drawing.Size(224, 47);
            this.lblLogoNombre.TabIndex = 0;
            this.lblLogoNombre.Text = "🐾 Huellitas";
            // 
            // lblLogoSub
            // 
            this.lblLogoSub.AutoSize = true;
            this.lblLogoSub.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblLogoSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblLogoSub.Location = new System.Drawing.Point(35, 68);
            this.lblLogoSub.Name = "lblLogoSub";
            this.lblLogoSub.Size = new System.Drawing.Size(207, 19);
            this.lblLogoSub.TabIndex = 1;
            this.lblLogoSub.Text = "——  V E T E R I N A R I A  ——";
            // 
            // lblEslogan
            // 
            this.lblEslogan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblEslogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblEslogan.Location = new System.Drawing.Point(235, 25);
            this.lblEslogan.Name = "lblEslogan";
            this.lblEslogan.Size = new System.Drawing.Size(180, 50);
            this.lblEslogan.TabIndex = 2;
            this.lblEslogan.Text = "Cuidado y atención con amor ♡";
            this.lblEslogan.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblEslogan.Click += new System.EventHandler(this.lblEslogan_Click);
            // 
            // lblPie
            // 
            this.lblPie.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Italic);
            this.lblPie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.lblPie.Location = new System.Drawing.Point(20, 410);
            this.lblPie.Name = "lblPie";
            this.lblPie.Size = new System.Drawing.Size(390, 40);
            this.lblPie.TabIndex = 4;
            this.lblPie.Text = "Salud, bienestar y compromiso con tus mascotas ♡";
            this.lblPie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 580);
            this.Controls.Add(this.pnlFondo);
            this.MinimumSize = new System.Drawing.Size(900, 580);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Huellitas Veterinaria - Inicio de Sesión";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.pnlFondo.ResumeLayout(false);
            this.pnlLoginCard.ResumeLayout(false);
            this.pnlLoginCard.PerformLayout();
            this.pnlDecoracion.ResumeLayout(false);
            this.pnlDecoracion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.Panel pnlDecoracion;
        private System.Windows.Forms.Label lblLogoNombre;
        private System.Windows.Forms.Label lblLogoSub;
        private System.Windows.Forms.Label lblEslogan;
        private System.Windows.Forms.Label lblPie;
        private System.Windows.Forms.Panel pnlLoginCard;
        private System.Windows.Forms.Label lblTituloCard;
        private System.Windows.Forms.Label lblSubtituloCard;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.CheckBox chkVerContrasena;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Button btnOlvidaste;
        private System.Windows.Forms.Label lblCredencialesDemo;
        private AxWMPLib.AxWindowsMediaPlayer wmpVideo;
    }
}
