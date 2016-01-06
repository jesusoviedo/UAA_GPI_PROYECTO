namespace Proyecto_GPI_GOLF
{
    partial class frm_carrera_con
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_carrera_con));
            this.but_consultar_carrera = new System.Windows.Forms.Button();
            this.tex_promocion = new System.Windows.Forms.TextBox();
            this.lab_promocion = new System.Windows.Forms.Label();
            this.tex_descripcion = new System.Windows.Forms.TextBox();
            this.tex_nombre = new System.Windows.Forms.TextBox();
            this.com_facultad = new System.Windows.Forms.ComboBox();
            this.lab_descripcion = new System.Windows.Forms.Label();
            this.lab_facultad = new System.Windows.Forms.Label();
            this.lab_nombre = new System.Windows.Forms.Label();
            this.but_materia_consultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_consultar_carrera
            // 
            this.but_consultar_carrera.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_consultar_carrera.Location = new System.Drawing.Point(23, 27);
            this.but_consultar_carrera.Name = "but_consultar_carrera";
            this.but_consultar_carrera.Size = new System.Drawing.Size(533, 23);
            this.but_consultar_carrera.TabIndex = 46;
            this.but_consultar_carrera.Text = "Consultar Carrera";
            this.but_consultar_carrera.UseVisualStyleBackColor = true;
            this.but_consultar_carrera.Click += new System.EventHandler(this.but_consultar_carrera_Click);
            // 
            // tex_promocion
            // 
            this.tex_promocion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_promocion.Location = new System.Drawing.Point(158, 89);
            this.tex_promocion.Name = "tex_promocion";
            this.tex_promocion.Size = new System.Drawing.Size(217, 26);
            this.tex_promocion.TabIndex = 56;
            // 
            // lab_promocion
            // 
            this.lab_promocion.AutoSize = true;
            this.lab_promocion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_promocion.Location = new System.Drawing.Point(21, 92);
            this.lab_promocion.Name = "lab_promocion";
            this.lab_promocion.Size = new System.Drawing.Size(79, 19);
            this.lab_promocion.TabIndex = 55;
            this.lab_promocion.Tag = "";
            this.lab_promocion.Text = "Promoción ";
            // 
            // tex_descripcion
            // 
            this.tex_descripcion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_descripcion.Location = new System.Drawing.Point(158, 152);
            this.tex_descripcion.Multiline = true;
            this.tex_descripcion.Name = "tex_descripcion";
            this.tex_descripcion.Size = new System.Drawing.Size(217, 214);
            this.tex_descripcion.TabIndex = 53;
            // 
            // tex_nombre
            // 
            this.tex_nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_nombre.Location = new System.Drawing.Point(158, 60);
            this.tex_nombre.Name = "tex_nombre";
            this.tex_nombre.Size = new System.Drawing.Size(217, 26);
            this.tex_nombre.TabIndex = 50;
            // 
            // com_facultad
            // 
            this.com_facultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_facultad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_facultad.FormattingEnabled = true;
            this.com_facultad.Location = new System.Drawing.Point(158, 121);
            this.com_facultad.Name = "com_facultad";
            this.com_facultad.Size = new System.Drawing.Size(217, 27);
            this.com_facultad.TabIndex = 51;
            // 
            // lab_descripcion
            // 
            this.lab_descripcion.AutoSize = true;
            this.lab_descripcion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_descripcion.Location = new System.Drawing.Point(21, 155);
            this.lab_descripcion.Name = "lab_descripcion";
            this.lab_descripcion.Size = new System.Drawing.Size(85, 19);
            this.lab_descripcion.TabIndex = 54;
            this.lab_descripcion.Text = "Descripción ";
            // 
            // lab_facultad
            // 
            this.lab_facultad.AutoSize = true;
            this.lab_facultad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_facultad.Location = new System.Drawing.Point(21, 124);
            this.lab_facultad.Name = "lab_facultad";
            this.lab_facultad.Size = new System.Drawing.Size(61, 19);
            this.lab_facultad.TabIndex = 52;
            this.lab_facultad.Text = "Facultad";
            // 
            // lab_nombre
            // 
            this.lab_nombre.AutoSize = true;
            this.lab_nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_nombre.Location = new System.Drawing.Point(21, 63);
            this.lab_nombre.Name = "lab_nombre";
            this.lab_nombre.Size = new System.Drawing.Size(60, 19);
            this.lab_nombre.TabIndex = 49;
            this.lab_nombre.Text = "Nombre";
            // 
            // but_materia_consultar
            // 
            this.but_materia_consultar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_materia_consultar.Location = new System.Drawing.Point(425, 63);
            this.but_materia_consultar.Name = "but_materia_consultar";
            this.but_materia_consultar.Size = new System.Drawing.Size(131, 23);
            this.but_materia_consultar.TabIndex = 116;
            this.but_materia_consultar.Text = "Consultar Materias";
            this.but_materia_consultar.UseVisualStyleBackColor = true;
            this.but_materia_consultar.Click += new System.EventHandler(this.but_materia_consultar_Click);
            // 
            // frm_carrera_con
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(575, 378);
            this.Controls.Add(this.but_materia_consultar);
            this.Controls.Add(this.tex_promocion);
            this.Controls.Add(this.lab_promocion);
            this.Controls.Add(this.tex_descripcion);
            this.Controls.Add(this.tex_nombre);
            this.Controls.Add(this.com_facultad);
            this.Controls.Add(this.lab_descripcion);
            this.Controls.Add(this.lab_facultad);
            this.Controls.Add(this.lab_nombre);
            this.Controls.Add(this.but_consultar_carrera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_carrera_con";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Carrera";
            this.Load += new System.EventHandler(this.frm_carrera_con_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_consultar_carrera;
        private System.Windows.Forms.TextBox tex_promocion;
        private System.Windows.Forms.Label lab_promocion;
        private System.Windows.Forms.TextBox tex_descripcion;
        private System.Windows.Forms.TextBox tex_nombre;
        private System.Windows.Forms.ComboBox com_facultad;
        private System.Windows.Forms.Label lab_descripcion;
        private System.Windows.Forms.Label lab_facultad;
        private System.Windows.Forms.Label lab_nombre;
        private System.Windows.Forms.Button but_materia_consultar;
    }
}