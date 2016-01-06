namespace Proyecto_GPI_GOLF
{
    partial class frm_carrera_agr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_carrera_agr));
            this.tex_descripcion = new System.Windows.Forms.TextBox();
            this.tex_nombre = new System.Windows.Forms.TextBox();
            this.com_facultad = new System.Windows.Forms.ComboBox();
            this.lab_descripcion = new System.Windows.Forms.Label();
            this.lab_facultad = new System.Windows.Forms.Label();
            this.lab_nombre = new System.Windows.Forms.Label();
            this.but_agregar_carrera = new System.Windows.Forms.Button();
            this.tex_promocion = new System.Windows.Forms.TextBox();
            this.lab_promocion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tex_descripcion
            // 
            this.tex_descripcion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_descripcion.Location = new System.Drawing.Point(156, 151);
            this.tex_descripcion.Multiline = true;
            this.tex_descripcion.Name = "tex_descripcion";
            this.tex_descripcion.Size = new System.Drawing.Size(217, 214);
            this.tex_descripcion.TabIndex = 16;
            // 
            // tex_nombre
            // 
            this.tex_nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_nombre.Location = new System.Drawing.Point(156, 59);
            this.tex_nombre.Name = "tex_nombre";
            this.tex_nombre.Size = new System.Drawing.Size(217, 26);
            this.tex_nombre.TabIndex = 13;
            // 
            // com_facultad
            // 
            this.com_facultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_facultad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_facultad.FormattingEnabled = true;
            this.com_facultad.Location = new System.Drawing.Point(156, 120);
            this.com_facultad.Name = "com_facultad";
            this.com_facultad.Size = new System.Drawing.Size(217, 27);
            this.com_facultad.TabIndex = 14;
            // 
            // lab_descripcion
            // 
            this.lab_descripcion.AutoSize = true;
            this.lab_descripcion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_descripcion.Location = new System.Drawing.Point(19, 154);
            this.lab_descripcion.Name = "lab_descripcion";
            this.lab_descripcion.Size = new System.Drawing.Size(85, 19);
            this.lab_descripcion.TabIndex = 17;
            this.lab_descripcion.Text = "Descripción ";
            // 
            // lab_facultad
            // 
            this.lab_facultad.AutoSize = true;
            this.lab_facultad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_facultad.Location = new System.Drawing.Point(19, 123);
            this.lab_facultad.Name = "lab_facultad";
            this.lab_facultad.Size = new System.Drawing.Size(61, 19);
            this.lab_facultad.TabIndex = 15;
            this.lab_facultad.Text = "Facultad";
            // 
            // lab_nombre
            // 
            this.lab_nombre.AutoSize = true;
            this.lab_nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_nombre.Location = new System.Drawing.Point(19, 62);
            this.lab_nombre.Name = "lab_nombre";
            this.lab_nombre.Size = new System.Drawing.Size(60, 19);
            this.lab_nombre.TabIndex = 12;
            this.lab_nombre.Text = "Nombre";
            // 
            // but_agregar_carrera
            // 
            this.but_agregar_carrera.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_agregar_carrera.Location = new System.Drawing.Point(23, 26);
            this.but_agregar_carrera.Name = "but_agregar_carrera";
            this.but_agregar_carrera.Size = new System.Drawing.Size(533, 23);
            this.but_agregar_carrera.TabIndex = 32;
            this.but_agregar_carrera.Text = "Agregar Carrera";
            this.but_agregar_carrera.UseVisualStyleBackColor = true;
            this.but_agregar_carrera.Click += new System.EventHandler(this.but_agregar_carrera_Click);
            // 
            // tex_promocion
            // 
            this.tex_promocion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_promocion.Location = new System.Drawing.Point(156, 88);
            this.tex_promocion.Name = "tex_promocion";
            this.tex_promocion.Size = new System.Drawing.Size(217, 26);
            this.tex_promocion.TabIndex = 34;
            this.tex_promocion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lab_promocion
            // 
            this.lab_promocion.AutoSize = true;
            this.lab_promocion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_promocion.Location = new System.Drawing.Point(19, 91);
            this.lab_promocion.Name = "lab_promocion";
            this.lab_promocion.Size = new System.Drawing.Size(79, 19);
            this.lab_promocion.TabIndex = 33;
            this.lab_promocion.Tag = "";
            this.lab_promocion.Text = "Promoción ";
            this.lab_promocion.Click += new System.EventHandler(this.label1_Click);
            // 
            // frm_carrera_agr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(575, 378);
            this.Controls.Add(this.tex_promocion);
            this.Controls.Add(this.lab_promocion);
            this.Controls.Add(this.tex_descripcion);
            this.Controls.Add(this.tex_nombre);
            this.Controls.Add(this.com_facultad);
            this.Controls.Add(this.lab_descripcion);
            this.Controls.Add(this.lab_facultad);
            this.Controls.Add(this.lab_nombre);
            this.Controls.Add(this.but_agregar_carrera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_carrera_agr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Carrera";
            this.Load += new System.EventHandler(this.frm_carrera_agr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tex_descripcion;
        private System.Windows.Forms.TextBox tex_nombre;
        private System.Windows.Forms.ComboBox com_facultad;
        private System.Windows.Forms.Label lab_descripcion;
        private System.Windows.Forms.Label lab_facultad;
        private System.Windows.Forms.Label lab_nombre;
        private System.Windows.Forms.Button but_agregar_carrera;
        private System.Windows.Forms.TextBox tex_promocion;
        private System.Windows.Forms.Label lab_promocion;
    }
}