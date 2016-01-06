namespace Proyecto_GPI_GOLF
{
    partial class frm_usuario_acc
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_usuario_acc));
            this.lab_usuario = new System.Windows.Forms.Label();
            this.lab_contraseña = new System.Windows.Forms.Label();
            this.tex_usuario = new System.Windows.Forms.TextBox();
            this.tex_contraseña = new System.Windows.Forms.TextBox();
            this.lab_recuperar_contraseña = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.but_ingresar = new System.Windows.Forms.Button();
            this.but_cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_usuario
            // 
            this.lab_usuario.AutoSize = true;
            this.lab_usuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_usuario.ForeColor = System.Drawing.Color.Black;
            this.lab_usuario.Location = new System.Drawing.Point(32, 29);
            this.lab_usuario.Name = "lab_usuario";
            this.lab_usuario.Size = new System.Drawing.Size(56, 19);
            this.lab_usuario.TabIndex = 1;
            this.lab_usuario.Text = "Usuario";
            this.lab_usuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_contraseña
            // 
            this.lab_contraseña.AutoSize = true;
            this.lab_contraseña.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_contraseña.ForeColor = System.Drawing.Color.Black;
            this.lab_contraseña.Location = new System.Drawing.Point(32, 78);
            this.lab_contraseña.Name = "lab_contraseña";
            this.lab_contraseña.Size = new System.Drawing.Size(78, 19);
            this.lab_contraseña.TabIndex = 2;
            this.lab_contraseña.Text = "Contraseña";
            // 
            // tex_usuario
            // 
            this.tex_usuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_usuario.Location = new System.Drawing.Point(212, 22);
            this.tex_usuario.Name = "tex_usuario";
            this.tex_usuario.Size = new System.Drawing.Size(150, 26);
            this.tex_usuario.TabIndex = 1;
            // 
            // tex_contraseña
            // 
            this.tex_contraseña.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_contraseña.Location = new System.Drawing.Point(212, 71);
            this.tex_contraseña.Name = "tex_contraseña";
            this.tex_contraseña.PasswordChar = '*';
            this.tex_contraseña.Size = new System.Drawing.Size(150, 26);
            this.tex_contraseña.TabIndex = 2;
            this.tex_contraseña.UseSystemPasswordChar = true;
            this.tex_contraseña.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lab_recuperar_contraseña
            // 
            this.lab_recuperar_contraseña.AutoSize = true;
            this.lab_recuperar_contraseña.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_recuperar_contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(110)))));
            this.lab_recuperar_contraseña.Location = new System.Drawing.Point(61, 165);
            this.lab_recuperar_contraseña.Name = "lab_recuperar_contraseña";
            this.lab_recuperar_contraseña.Size = new System.Drawing.Size(278, 19);
            this.lab_recuperar_contraseña.TabIndex = 5;
            this.lab_recuperar_contraseña.Text = "¿Olvidó su nombre de usuario o contraseña?";
            this.lab_recuperar_contraseña.Click += new System.EventHandler(this.lab_recuperar_contraseña_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // but_ingresar
            // 
            this.but_ingresar.BackColor = System.Drawing.SystemColors.Control;
            this.but_ingresar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_ingresar.Location = new System.Drawing.Point(35, 120);
            this.but_ingresar.Name = "but_ingresar";
            this.but_ingresar.Size = new System.Drawing.Size(75, 23);
            this.but_ingresar.TabIndex = 3;
            this.but_ingresar.Text = "Ingresar";
            this.but_ingresar.UseVisualStyleBackColor = false;
            this.but_ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_cerrar
            // 
            this.but_cerrar.BackColor = System.Drawing.SystemColors.Control;
            this.but_cerrar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_cerrar.Location = new System.Drawing.Point(287, 120);
            this.but_cerrar.Name = "but_cerrar";
            this.but_cerrar.Size = new System.Drawing.Size(75, 23);
            this.but_cerrar.TabIndex = 4;
            this.but_cerrar.Text = "Cerrar";
            this.but_cerrar.UseVisualStyleBackColor = false;
            this.but_cerrar.Click += new System.EventHandler(this.but_salir_Click);
            // 
            // frm_usuario_acc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(399, 192);
            this.ControlBox = false;
            this.Controls.Add(this.but_cerrar);
            this.Controls.Add(this.but_ingresar);
            this.Controls.Add(this.lab_recuperar_contraseña);
            this.Controls.Add(this.tex_contraseña);
            this.Controls.Add(this.tex_usuario);
            this.Controls.Add(this.lab_contraseña);
            this.Controls.Add(this.lab_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_usuario_acc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso Usuario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_usuario;
        private System.Windows.Forms.Label lab_contraseña;
        private System.Windows.Forms.TextBox tex_usuario;
        private System.Windows.Forms.TextBox tex_contraseña;
        private System.Windows.Forms.Label lab_recuperar_contraseña;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button but_ingresar;
        private System.Windows.Forms.Button but_cerrar;
    }
}

