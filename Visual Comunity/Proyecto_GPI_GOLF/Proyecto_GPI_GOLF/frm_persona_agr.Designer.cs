namespace Proyecto_GPI_GOLF
{
    partial class frm_persona_agr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_persona_agr));
            this.but_agregar_persona = new System.Windows.Forms.Button();
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
            this.com_pais_nacimiento = new System.Windows.Forms.ComboBox();
            this.tex_documento = new System.Windows.Forms.TextBox();
            this.tex_nombre = new System.Windows.Forms.TextBox();
            this.tex_apellido = new System.Windows.Forms.TextBox();
            this.tex_fecha_nacimiento = new System.Windows.Forms.TextBox();
            this.tex_direccion = new System.Windows.Forms.TextBox();
            this.tex_telefono = new System.Windows.Forms.TextBox();
            this.tex_correo_electronico = new System.Windows.Forms.TextBox();
            this.com_tipo_persona = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // but_agregar_persona
            // 
            this.but_agregar_persona.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_agregar_persona.Location = new System.Drawing.Point(21, 12);
            this.but_agregar_persona.Name = "but_agregar_persona";
            this.but_agregar_persona.Size = new System.Drawing.Size(533, 23);
            this.but_agregar_persona.TabIndex = 11;
            this.but_agregar_persona.Text = "Agregar Persona";
            this.but_agregar_persona.UseVisualStyleBackColor = true;
            this.but_agregar_persona.Click += new System.EventHandler(this.but_agregar_persona_Click);
            // 
            // lab_documento
            // 
            this.lab_documento.AutoSize = true;
            this.lab_documento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_documento.Location = new System.Drawing.Point(17, 48);
            this.lab_documento.Name = "lab_documento";
            this.lab_documento.Size = new System.Drawing.Size(79, 19);
            this.lab_documento.TabIndex = 1;
            this.lab_documento.Text = "Documento";
            this.lab_documento.Click += new System.EventHandler(this.lab_documento_Click);
            // 
            // lab_tipo_documento
            // 
            this.lab_tipo_documento.AutoSize = true;
            this.lab_tipo_documento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tipo_documento.Location = new System.Drawing.Point(17, 78);
            this.lab_tipo_documento.Name = "lab_tipo_documento";
            this.lab_tipo_documento.Size = new System.Drawing.Size(110, 19);
            this.lab_tipo_documento.TabIndex = 2;
            this.lab_tipo_documento.Text = "Tipo Documento";
            this.lab_tipo_documento.Click += new System.EventHandler(this.lab_tipo_documento_Click);
            // 
            // lab_nombre
            // 
            this.lab_nombre.AutoSize = true;
            this.lab_nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_nombre.Location = new System.Drawing.Point(17, 109);
            this.lab_nombre.Name = "lab_nombre";
            this.lab_nombre.Size = new System.Drawing.Size(60, 19);
            this.lab_nombre.TabIndex = 3;
            this.lab_nombre.Text = "Nombre";
            this.lab_nombre.Click += new System.EventHandler(this.lab_nombre_Click);
            // 
            // lab_apellido
            // 
            this.lab_apellido.AutoSize = true;
            this.lab_apellido.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_apellido.Location = new System.Drawing.Point(17, 137);
            this.lab_apellido.Name = "lab_apellido";
            this.lab_apellido.Size = new System.Drawing.Size(60, 19);
            this.lab_apellido.TabIndex = 4;
            this.lab_apellido.Text = "Apellido";
            this.lab_apellido.Click += new System.EventHandler(this.lab_apellido_Click);
            // 
            // lab_fecha_nacimiento
            // 
            this.lab_fecha_nacimiento.AutoSize = true;
            this.lab_fecha_nacimiento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_fecha_nacimiento.Location = new System.Drawing.Point(17, 166);
            this.lab_fecha_nacimiento.Name = "lab_fecha_nacimiento";
            this.lab_fecha_nacimiento.Size = new System.Drawing.Size(119, 19);
            this.lab_fecha_nacimiento.TabIndex = 5;
            this.lab_fecha_nacimiento.Text = "Fecha Nacimiento";
            this.lab_fecha_nacimiento.Click += new System.EventHandler(this.lab_fecha_nacimiento_Click);
            // 
            // lab_pais
            // 
            this.lab_pais.AutoSize = true;
            this.lab_pais.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_pais.Location = new System.Drawing.Point(17, 194);
            this.lab_pais.Name = "lab_pais";
            this.lab_pais.Size = new System.Drawing.Size(107, 19);
            this.lab_pais.TabIndex = 6;
            this.lab_pais.Text = "País Nacimiento";
            this.lab_pais.Click += new System.EventHandler(this.lab_pais_Click);
            // 
            // lab_direccion
            // 
            this.lab_direccion.AutoSize = true;
            this.lab_direccion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_direccion.Location = new System.Drawing.Point(17, 225);
            this.lab_direccion.Name = "lab_direccion";
            this.lab_direccion.Size = new System.Drawing.Size(67, 19);
            this.lab_direccion.TabIndex = 7;
            this.lab_direccion.Text = "Direccion";
            this.lab_direccion.Click += new System.EventHandler(this.lab_direccion_Click);
            // 
            // lab_telefono
            // 
            this.lab_telefono.AutoSize = true;
            this.lab_telefono.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_telefono.Location = new System.Drawing.Point(17, 255);
            this.lab_telefono.Name = "lab_telefono";
            this.lab_telefono.Size = new System.Drawing.Size(65, 19);
            this.lab_telefono.TabIndex = 8;
            this.lab_telefono.Text = "Teléfono ";
            this.lab_telefono.Click += new System.EventHandler(this.lab_telefono_Click);
            // 
            // lab_correo_electronico
            // 
            this.lab_correo_electronico.AutoSize = true;
            this.lab_correo_electronico.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_correo_electronico.Location = new System.Drawing.Point(17, 285);
            this.lab_correo_electronico.Name = "lab_correo_electronico";
            this.lab_correo_electronico.Size = new System.Drawing.Size(125, 19);
            this.lab_correo_electronico.TabIndex = 9;
            this.lab_correo_electronico.Text = "Correo Electrónico";
            this.lab_correo_electronico.Click += new System.EventHandler(this.lab_correo_electronico_Click);
            // 
            // lab_tipo_persona
            // 
            this.lab_tipo_persona.AutoSize = true;
            this.lab_tipo_persona.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tipo_persona.Location = new System.Drawing.Point(17, 314);
            this.lab_tipo_persona.Name = "lab_tipo_persona";
            this.lab_tipo_persona.Size = new System.Drawing.Size(89, 19);
            this.lab_tipo_persona.TabIndex = 10;
            this.lab_tipo_persona.Text = "Tipo Persona";
            this.lab_tipo_persona.Click += new System.EventHandler(this.lab_tipo_persona_Click);
            // 
            // com_tipo_documento
            // 
            this.com_tipo_documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_tipo_documento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_tipo_documento.FormattingEnabled = true;
            this.com_tipo_documento.Location = new System.Drawing.Point(154, 75);
            this.com_tipo_documento.Name = "com_tipo_documento";
            this.com_tipo_documento.Size = new System.Drawing.Size(217, 27);
            this.com_tipo_documento.TabIndex = 2;
            // 
            // com_pais_nacimiento
            // 
            this.com_pais_nacimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_pais_nacimiento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_pais_nacimiento.FormattingEnabled = true;
            this.com_pais_nacimiento.Location = new System.Drawing.Point(154, 191);
            this.com_pais_nacimiento.Name = "com_pais_nacimiento";
            this.com_pais_nacimiento.Size = new System.Drawing.Size(217, 27);
            this.com_pais_nacimiento.TabIndex = 6;
            // 
            // tex_documento
            // 
            this.tex_documento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_documento.Location = new System.Drawing.Point(154, 45);
            this.tex_documento.Name = "tex_documento";
            this.tex_documento.Size = new System.Drawing.Size(217, 26);
            this.tex_documento.TabIndex = 1;
            this.tex_documento.TextChanged += new System.EventHandler(this.text_nombre_TextChanged);
            // 
            // tex_nombre
            // 
            this.tex_nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_nombre.Location = new System.Drawing.Point(154, 106);
            this.tex_nombre.Name = "tex_nombre";
            this.tex_nombre.Size = new System.Drawing.Size(217, 26);
            this.tex_nombre.TabIndex = 3;
            // 
            // tex_apellido
            // 
            this.tex_apellido.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_apellido.Location = new System.Drawing.Point(154, 134);
            this.tex_apellido.Name = "tex_apellido";
            this.tex_apellido.Size = new System.Drawing.Size(217, 26);
            this.tex_apellido.TabIndex = 4;
            // 
            // tex_fecha_nacimiento
            // 
            this.tex_fecha_nacimiento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_fecha_nacimiento.Location = new System.Drawing.Point(154, 163);
            this.tex_fecha_nacimiento.Name = "tex_fecha_nacimiento";
            this.tex_fecha_nacimiento.Size = new System.Drawing.Size(217, 26);
            this.tex_fecha_nacimiento.TabIndex = 5;
            // 
            // tex_direccion
            // 
            this.tex_direccion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_direccion.Location = new System.Drawing.Point(154, 222);
            this.tex_direccion.Name = "tex_direccion";
            this.tex_direccion.Size = new System.Drawing.Size(217, 26);
            this.tex_direccion.TabIndex = 7;
            // 
            // tex_telefono
            // 
            this.tex_telefono.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_telefono.Location = new System.Drawing.Point(154, 252);
            this.tex_telefono.Name = "tex_telefono";
            this.tex_telefono.Size = new System.Drawing.Size(217, 26);
            this.tex_telefono.TabIndex = 8;
            this.tex_telefono.TextChanged += new System.EventHandler(this.tex_telefono_TextChanged);
            // 
            // tex_correo_electronico
            // 
            this.tex_correo_electronico.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_correo_electronico.Location = new System.Drawing.Point(154, 282);
            this.tex_correo_electronico.Name = "tex_correo_electronico";
            this.tex_correo_electronico.Size = new System.Drawing.Size(217, 26);
            this.tex_correo_electronico.TabIndex = 9;
            this.tex_correo_electronico.TextChanged += new System.EventHandler(this.tex_correo_electronico_TextChanged);
            // 
            // com_tipo_persona
            // 
            this.com_tipo_persona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_tipo_persona.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_tipo_persona.FormattingEnabled = true;
            this.com_tipo_persona.Location = new System.Drawing.Point(154, 311);
            this.com_tipo_persona.Name = "com_tipo_persona";
            this.com_tipo_persona.Size = new System.Drawing.Size(217, 27);
            this.com_tipo_persona.TabIndex = 10;
            this.com_tipo_persona.SelectedIndexChanged += new System.EventHandler(this.com_tipo_persona_SelectedIndexChanged);
            // 
            // frm_persona_agr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(575, 378);
            this.Controls.Add(this.com_tipo_persona);
            this.Controls.Add(this.tex_correo_electronico);
            this.Controls.Add(this.tex_telefono);
            this.Controls.Add(this.tex_direccion);
            this.Controls.Add(this.tex_fecha_nacimiento);
            this.Controls.Add(this.tex_apellido);
            this.Controls.Add(this.tex_nombre);
            this.Controls.Add(this.tex_documento);
            this.Controls.Add(this.com_pais_nacimiento);
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
            this.Controls.Add(this.but_agregar_persona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_persona_agr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Persona";
            this.Load += new System.EventHandler(this.frm_persona_agr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_agregar_persona;
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
        private System.Windows.Forms.ComboBox com_pais_nacimiento;
        private System.Windows.Forms.TextBox tex_documento;
        private System.Windows.Forms.TextBox tex_nombre;
        private System.Windows.Forms.TextBox tex_apellido;
        private System.Windows.Forms.TextBox tex_fecha_nacimiento;
        private System.Windows.Forms.TextBox tex_direccion;
        private System.Windows.Forms.TextBox tex_telefono;
        private System.Windows.Forms.TextBox tex_correo_electronico;
        private System.Windows.Forms.ComboBox com_tipo_persona;


    }
}