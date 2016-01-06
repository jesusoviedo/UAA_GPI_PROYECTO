namespace Proyecto_GPI_GOLF
{
    partial class frm_persona_con
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_persona_con));
            this.but_consultar_persona = new System.Windows.Forms.Button();
            this.lab_documento = new System.Windows.Forms.Label();
            this.lab_tipo_documento = new System.Windows.Forms.Label();
            this.lab_nombre = new System.Windows.Forms.Label();
            this.lab_apellido = new System.Windows.Forms.Label();
            this.lab_fecha_nacimiento = new System.Windows.Forms.Label();
            this.lab_pais = new System.Windows.Forms.Label();
            this.lab_direccion = new System.Windows.Forms.Label();
            this.lab_telefono = new System.Windows.Forms.Label();
            this.lab_correo_electronico = new System.Windows.Forms.Label();
            this.lab_tipo_persona = new System.Windows.Forms.Label();
            this.com_tipo_documento = new System.Windows.Forms.ComboBox();
            this.tex_nombre = new System.Windows.Forms.TextBox();
            this.tex_apellido = new System.Windows.Forms.TextBox();
            this.tex_fecha_nacimiento = new System.Windows.Forms.TextBox();
            this.tex_direccion = new System.Windows.Forms.TextBox();
            this.tex_telefono = new System.Windows.Forms.TextBox();
            this.tex_correo_electronico = new System.Windows.Forms.TextBox();
            this.tex_pais_nacimiento = new System.Windows.Forms.TextBox();
            this.tex_tipo_persona = new System.Windows.Forms.TextBox();
            this.tex_documento = new System.Windows.Forms.TextBox();
            this.tex_usuario = new System.Windows.Forms.TextBox();
            this.lab_usuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_consultar_persona
            // 
            this.but_consultar_persona.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_consultar_persona.Location = new System.Drawing.Point(23, 26);
            this.but_consultar_persona.Name = "but_consultar_persona";
            this.but_consultar_persona.Size = new System.Drawing.Size(533, 23);
            this.but_consultar_persona.TabIndex = 12;
            this.but_consultar_persona.Text = "Consultar Persona";
            this.but_consultar_persona.UseVisualStyleBackColor = true;
            this.but_consultar_persona.Click += new System.EventHandler(this.but_agregar_persona_Click);
            // 
            // lab_documento
            // 
            this.lab_documento.AutoSize = true;
            this.lab_documento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_documento.Location = new System.Drawing.Point(19, 62);
            this.lab_documento.Name = "lab_documento";
            this.lab_documento.Size = new System.Drawing.Size(79, 19);
            this.lab_documento.TabIndex = 12;
            this.lab_documento.Text = "Documento";
            // 
            // lab_tipo_documento
            // 
            this.lab_tipo_documento.AutoSize = true;
            this.lab_tipo_documento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tipo_documento.Location = new System.Drawing.Point(19, 92);
            this.lab_tipo_documento.Name = "lab_tipo_documento";
            this.lab_tipo_documento.Size = new System.Drawing.Size(110, 19);
            this.lab_tipo_documento.TabIndex = 15;
            this.lab_tipo_documento.Text = "Tipo Documento";
            // 
            // lab_nombre
            // 
            this.lab_nombre.AutoSize = true;
            this.lab_nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_nombre.Location = new System.Drawing.Point(19, 123);
            this.lab_nombre.Name = "lab_nombre";
            this.lab_nombre.Size = new System.Drawing.Size(60, 19);
            this.lab_nombre.TabIndex = 17;
            this.lab_nombre.Text = "Nombre";
            // 
            // lab_apellido
            // 
            this.lab_apellido.AutoSize = true;
            this.lab_apellido.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_apellido.Location = new System.Drawing.Point(19, 151);
            this.lab_apellido.Name = "lab_apellido";
            this.lab_apellido.Size = new System.Drawing.Size(60, 19);
            this.lab_apellido.TabIndex = 19;
            this.lab_apellido.Text = "Apellido";
            // 
            // lab_fecha_nacimiento
            // 
            this.lab_fecha_nacimiento.AutoSize = true;
            this.lab_fecha_nacimiento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_fecha_nacimiento.Location = new System.Drawing.Point(19, 180);
            this.lab_fecha_nacimiento.Name = "lab_fecha_nacimiento";
            this.lab_fecha_nacimiento.Size = new System.Drawing.Size(119, 19);
            this.lab_fecha_nacimiento.TabIndex = 21;
            this.lab_fecha_nacimiento.Text = "Fecha Nacimiento";
            // 
            // lab_pais
            // 
            this.lab_pais.AutoSize = true;
            this.lab_pais.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_pais.Location = new System.Drawing.Point(19, 208);
            this.lab_pais.Name = "lab_pais";
            this.lab_pais.Size = new System.Drawing.Size(107, 19);
            this.lab_pais.TabIndex = 23;
            this.lab_pais.Text = "País Nacimiento";
            // 
            // lab_direccion
            // 
            this.lab_direccion.AutoSize = true;
            this.lab_direccion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_direccion.Location = new System.Drawing.Point(19, 239);
            this.lab_direccion.Name = "lab_direccion";
            this.lab_direccion.Size = new System.Drawing.Size(67, 19);
            this.lab_direccion.TabIndex = 24;
            this.lab_direccion.Text = "Direccion";
            // 
            // lab_telefono
            // 
            this.lab_telefono.AutoSize = true;
            this.lab_telefono.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_telefono.Location = new System.Drawing.Point(19, 269);
            this.lab_telefono.Name = "lab_telefono";
            this.lab_telefono.Size = new System.Drawing.Size(65, 19);
            this.lab_telefono.TabIndex = 27;
            this.lab_telefono.Text = "Teléfono ";
            // 
            // lab_correo_electronico
            // 
            this.lab_correo_electronico.AutoSize = true;
            this.lab_correo_electronico.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_correo_electronico.Location = new System.Drawing.Point(19, 299);
            this.lab_correo_electronico.Name = "lab_correo_electronico";
            this.lab_correo_electronico.Size = new System.Drawing.Size(125, 19);
            this.lab_correo_electronico.TabIndex = 29;
            this.lab_correo_electronico.Text = "Correo Electrónico";
            // 
            // lab_tipo_persona
            // 
            this.lab_tipo_persona.AutoSize = true;
            this.lab_tipo_persona.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tipo_persona.Location = new System.Drawing.Point(19, 328);
            this.lab_tipo_persona.Name = "lab_tipo_persona";
            this.lab_tipo_persona.Size = new System.Drawing.Size(89, 19);
            this.lab_tipo_persona.TabIndex = 31;
            this.lab_tipo_persona.Text = "Tipo Persona";
            // 
            // com_tipo_documento
            // 
            this.com_tipo_documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_tipo_documento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_tipo_documento.FormattingEnabled = true;
            this.com_tipo_documento.Location = new System.Drawing.Point(156, 89);
            this.com_tipo_documento.Name = "com_tipo_documento";
            this.com_tipo_documento.Size = new System.Drawing.Size(217, 27);
            this.com_tipo_documento.TabIndex = 2;
            // 
            // tex_nombre
            // 
            this.tex_nombre.Enabled = false;
            this.tex_nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_nombre.Location = new System.Drawing.Point(156, 120);
            this.tex_nombre.Name = "tex_nombre";
            this.tex_nombre.Size = new System.Drawing.Size(217, 26);
            this.tex_nombre.TabIndex = 3;
            // 
            // tex_apellido
            // 
            this.tex_apellido.Enabled = false;
            this.tex_apellido.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_apellido.Location = new System.Drawing.Point(156, 148);
            this.tex_apellido.Name = "tex_apellido";
            this.tex_apellido.Size = new System.Drawing.Size(217, 26);
            this.tex_apellido.TabIndex = 4;
            // 
            // tex_fecha_nacimiento
            // 
            this.tex_fecha_nacimiento.Enabled = false;
            this.tex_fecha_nacimiento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_fecha_nacimiento.Location = new System.Drawing.Point(156, 177);
            this.tex_fecha_nacimiento.Name = "tex_fecha_nacimiento";
            this.tex_fecha_nacimiento.Size = new System.Drawing.Size(217, 26);
            this.tex_fecha_nacimiento.TabIndex = 5;
            // 
            // tex_direccion
            // 
            this.tex_direccion.Enabled = false;
            this.tex_direccion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_direccion.Location = new System.Drawing.Point(156, 236);
            this.tex_direccion.Name = "tex_direccion";
            this.tex_direccion.Size = new System.Drawing.Size(217, 26);
            this.tex_direccion.TabIndex = 7;
            // 
            // tex_telefono
            // 
            this.tex_telefono.Enabled = false;
            this.tex_telefono.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_telefono.Location = new System.Drawing.Point(156, 266);
            this.tex_telefono.Name = "tex_telefono";
            this.tex_telefono.Size = new System.Drawing.Size(217, 26);
            this.tex_telefono.TabIndex = 8;
            // 
            // tex_correo_electronico
            // 
            this.tex_correo_electronico.Enabled = false;
            this.tex_correo_electronico.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_correo_electronico.Location = new System.Drawing.Point(156, 296);
            this.tex_correo_electronico.Name = "tex_correo_electronico";
            this.tex_correo_electronico.Size = new System.Drawing.Size(217, 26);
            this.tex_correo_electronico.TabIndex = 9;
            // 
            // tex_pais_nacimiento
            // 
            this.tex_pais_nacimiento.Enabled = false;
            this.tex_pais_nacimiento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_pais_nacimiento.Location = new System.Drawing.Point(156, 205);
            this.tex_pais_nacimiento.Name = "tex_pais_nacimiento";
            this.tex_pais_nacimiento.Size = new System.Drawing.Size(217, 26);
            this.tex_pais_nacimiento.TabIndex = 6;
            // 
            // tex_tipo_persona
            // 
            this.tex_tipo_persona.Enabled = false;
            this.tex_tipo_persona.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_tipo_persona.Location = new System.Drawing.Point(156, 325);
            this.tex_tipo_persona.Name = "tex_tipo_persona";
            this.tex_tipo_persona.Size = new System.Drawing.Size(217, 26);
            this.tex_tipo_persona.TabIndex = 10;
            // 
            // tex_documento
            // 
            this.tex_documento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_documento.Location = new System.Drawing.Point(156, 59);
            this.tex_documento.Name = "tex_documento";
            this.tex_documento.Size = new System.Drawing.Size(217, 26);
            this.tex_documento.TabIndex = 1;
            // 
            // tex_usuario
            // 
            this.tex_usuario.Enabled = false;
            this.tex_usuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_usuario.Location = new System.Drawing.Point(422, 89);
            this.tex_usuario.Name = "tex_usuario";
            this.tex_usuario.Size = new System.Drawing.Size(143, 26);
            this.tex_usuario.TabIndex = 11;
            // 
            // lab_usuario
            // 
            this.lab_usuario.AutoSize = true;
            this.lab_usuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_usuario.Location = new System.Drawing.Point(418, 62);
            this.lab_usuario.Name = "lab_usuario";
            this.lab_usuario.Size = new System.Drawing.Size(56, 19);
            this.lab_usuario.TabIndex = 58;
            this.lab_usuario.Text = "Usuario";
            // 
            // frm_persona_con
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(575, 378);
            this.Controls.Add(this.tex_usuario);
            this.Controls.Add(this.lab_usuario);
            this.Controls.Add(this.tex_tipo_persona);
            this.Controls.Add(this.tex_pais_nacimiento);
            this.Controls.Add(this.tex_correo_electronico);
            this.Controls.Add(this.tex_telefono);
            this.Controls.Add(this.tex_direccion);
            this.Controls.Add(this.tex_fecha_nacimiento);
            this.Controls.Add(this.tex_apellido);
            this.Controls.Add(this.tex_nombre);
            this.Controls.Add(this.tex_documento);
            this.Controls.Add(this.com_tipo_documento);
            this.Controls.Add(this.lab_tipo_persona);
            this.Controls.Add(this.lab_correo_electronico);
            this.Controls.Add(this.lab_telefono);
            this.Controls.Add(this.lab_direccion);
            this.Controls.Add(this.lab_pais);
            this.Controls.Add(this.lab_fecha_nacimiento);
            this.Controls.Add(this.lab_apellido);
            this.Controls.Add(this.lab_nombre);
            this.Controls.Add(this.lab_tipo_documento);
            this.Controls.Add(this.lab_documento);
            this.Controls.Add(this.but_consultar_persona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_persona_con";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Persona";
            this.Load += new System.EventHandler(this.frm_persona_con_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_consultar_persona;
        private System.Windows.Forms.Label lab_documento;
        private System.Windows.Forms.Label lab_tipo_documento;
        private System.Windows.Forms.Label lab_nombre;
        private System.Windows.Forms.Label lab_apellido;
        private System.Windows.Forms.Label lab_fecha_nacimiento;
        private System.Windows.Forms.Label lab_pais;
        private System.Windows.Forms.Label lab_direccion;
        private System.Windows.Forms.Label lab_telefono;
        private System.Windows.Forms.Label lab_correo_electronico;
        private System.Windows.Forms.Label lab_tipo_persona;
        private System.Windows.Forms.ComboBox com_tipo_documento;
        private System.Windows.Forms.TextBox tex_nombre;
        private System.Windows.Forms.TextBox tex_apellido;
        private System.Windows.Forms.TextBox tex_fecha_nacimiento;
        private System.Windows.Forms.TextBox tex_direccion;
        private System.Windows.Forms.TextBox tex_telefono;
        private System.Windows.Forms.TextBox tex_correo_electronico;
        private System.Windows.Forms.TextBox tex_pais_nacimiento;
        private System.Windows.Forms.TextBox tex_tipo_persona;
        private System.Windows.Forms.TextBox tex_documento;
        private System.Windows.Forms.TextBox tex_usuario;
        private System.Windows.Forms.Label lab_usuario;

    }
}