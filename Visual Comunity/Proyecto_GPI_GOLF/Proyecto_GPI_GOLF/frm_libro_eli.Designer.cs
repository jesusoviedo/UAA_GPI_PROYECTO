﻿namespace Proyecto_GPI_GOLF
{
    partial class frm_libro_eli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_libro_eli));
            this.but_eliminar_libro = new System.Windows.Forms.Button();
            this.com_idioma = new System.Windows.Forms.ComboBox();
            this.com_tipo_libro = new System.Windows.Forms.ComboBox();
            this.tex_año = new System.Windows.Forms.TextBox();
            this.tex_autor = new System.Windows.Forms.TextBox();
            this.tex_edicion = new System.Windows.Forms.TextBox();
            this.tex_titulo = new System.Windows.Forms.TextBox();
            this.tex_isbn = new System.Windows.Forms.TextBox();
            this.com_editorial = new System.Windows.Forms.ComboBox();
            this.lab_año = new System.Windows.Forms.Label();
            this.lab_idioma = new System.Windows.Forms.Label();
            this.lab_edicion = new System.Windows.Forms.Label();
            this.lab_autor = new System.Windows.Forms.Label();
            this.lab_tipo = new System.Windows.Forms.Label();
            this.lab_editorial = new System.Windows.Forms.Label();
            this.lab_titulo = new System.Windows.Forms.Label();
            this.lab_isbn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_eliminar_libro
            // 
            this.but_eliminar_libro.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_eliminar_libro.Location = new System.Drawing.Point(23, 27);
            this.but_eliminar_libro.Name = "but_eliminar_libro";
            this.but_eliminar_libro.Size = new System.Drawing.Size(533, 23);
            this.but_eliminar_libro.TabIndex = 68;
            this.but_eliminar_libro.Text = "Eliminar Libro";
            this.but_eliminar_libro.UseVisualStyleBackColor = true;
            this.but_eliminar_libro.Click += new System.EventHandler(this.but_eliminar_libro_Click);
            // 
            // com_idioma
            // 
            this.com_idioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_idioma.Enabled = false;
            this.com_idioma.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_idioma.FormattingEnabled = true;
            this.com_idioma.Location = new System.Drawing.Point(161, 233);
            this.com_idioma.Name = "com_idioma";
            this.com_idioma.Size = new System.Drawing.Size(217, 27);
            this.com_idioma.TabIndex = 121;
            // 
            // com_tipo_libro
            // 
            this.com_tipo_libro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_tipo_libro.Enabled = false;
            this.com_tipo_libro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_tipo_libro.FormattingEnabled = true;
            this.com_tipo_libro.Location = new System.Drawing.Point(161, 145);
            this.com_tipo_libro.Name = "com_tipo_libro";
            this.com_tipo_libro.Size = new System.Drawing.Size(217, 27);
            this.com_tipo_libro.TabIndex = 120;
            // 
            // tex_año
            // 
            this.tex_año.Enabled = false;
            this.tex_año.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_año.Location = new System.Drawing.Point(161, 263);
            this.tex_año.Name = "tex_año";
            this.tex_año.Size = new System.Drawing.Size(217, 26);
            this.tex_año.TabIndex = 111;
            // 
            // tex_autor
            // 
            this.tex_autor.Enabled = false;
            this.tex_autor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_autor.Location = new System.Drawing.Point(161, 174);
            this.tex_autor.Name = "tex_autor";
            this.tex_autor.Size = new System.Drawing.Size(217, 26);
            this.tex_autor.TabIndex = 110;
            // 
            // tex_edicion
            // 
            this.tex_edicion.Enabled = false;
            this.tex_edicion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_edicion.Location = new System.Drawing.Point(161, 202);
            this.tex_edicion.Name = "tex_edicion";
            this.tex_edicion.Size = new System.Drawing.Size(217, 26);
            this.tex_edicion.TabIndex = 109;
            // 
            // tex_titulo
            // 
            this.tex_titulo.Enabled = false;
            this.tex_titulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_titulo.Location = new System.Drawing.Point(161, 86);
            this.tex_titulo.Name = "tex_titulo";
            this.tex_titulo.Size = new System.Drawing.Size(217, 26);
            this.tex_titulo.TabIndex = 108;
            // 
            // tex_isbn
            // 
            this.tex_isbn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_isbn.Location = new System.Drawing.Point(161, 56);
            this.tex_isbn.Name = "tex_isbn";
            this.tex_isbn.Size = new System.Drawing.Size(217, 26);
            this.tex_isbn.TabIndex = 106;
            // 
            // com_editorial
            // 
            this.com_editorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_editorial.Enabled = false;
            this.com_editorial.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_editorial.FormattingEnabled = true;
            this.com_editorial.Location = new System.Drawing.Point(161, 117);
            this.com_editorial.Name = "com_editorial";
            this.com_editorial.Size = new System.Drawing.Size(217, 27);
            this.com_editorial.TabIndex = 107;
            // 
            // lab_año
            // 
            this.lab_año.AutoSize = true;
            this.lab_año.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_año.Location = new System.Drawing.Point(24, 266);
            this.lab_año.Name = "lab_año";
            this.lab_año.Size = new System.Drawing.Size(35, 19);
            this.lab_año.TabIndex = 119;
            this.lab_año.Text = "Año";
            // 
            // lab_idioma
            // 
            this.lab_idioma.AutoSize = true;
            this.lab_idioma.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_idioma.Location = new System.Drawing.Point(24, 236);
            this.lab_idioma.Name = "lab_idioma";
            this.lab_idioma.Size = new System.Drawing.Size(51, 19);
            this.lab_idioma.TabIndex = 118;
            this.lab_idioma.Text = "Idioma";
            // 
            // lab_edicion
            // 
            this.lab_edicion.AutoSize = true;
            this.lab_edicion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_edicion.Location = new System.Drawing.Point(24, 205);
            this.lab_edicion.Name = "lab_edicion";
            this.lab_edicion.Size = new System.Drawing.Size(54, 19);
            this.lab_edicion.TabIndex = 117;
            this.lab_edicion.Text = "Edición";
            // 
            // lab_autor
            // 
            this.lab_autor.AutoSize = true;
            this.lab_autor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_autor.Location = new System.Drawing.Point(24, 177);
            this.lab_autor.Name = "lab_autor";
            this.lab_autor.Size = new System.Drawing.Size(44, 19);
            this.lab_autor.TabIndex = 116;
            this.lab_autor.Text = "Autor";
            // 
            // lab_tipo
            // 
            this.lab_tipo.AutoSize = true;
            this.lab_tipo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tipo.Location = new System.Drawing.Point(24, 148);
            this.lab_tipo.Name = "lab_tipo";
            this.lab_tipo.Size = new System.Drawing.Size(73, 19);
            this.lab_tipo.TabIndex = 115;
            this.lab_tipo.Text = "Tipo Libro";
            // 
            // lab_editorial
            // 
            this.lab_editorial.AutoSize = true;
            this.lab_editorial.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_editorial.Location = new System.Drawing.Point(24, 120);
            this.lab_editorial.Name = "lab_editorial";
            this.lab_editorial.Size = new System.Drawing.Size(59, 19);
            this.lab_editorial.TabIndex = 114;
            this.lab_editorial.Text = "Editorial";
            // 
            // lab_titulo
            // 
            this.lab_titulo.AutoSize = true;
            this.lab_titulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_titulo.Location = new System.Drawing.Point(24, 89);
            this.lab_titulo.Name = "lab_titulo";
            this.lab_titulo.Size = new System.Drawing.Size(42, 19);
            this.lab_titulo.TabIndex = 113;
            this.lab_titulo.Text = "Titulo";
            // 
            // lab_isbn
            // 
            this.lab_isbn.AutoSize = true;
            this.lab_isbn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_isbn.Location = new System.Drawing.Point(24, 59);
            this.lab_isbn.Name = "lab_isbn";
            this.lab_isbn.Size = new System.Drawing.Size(45, 19);
            this.lab_isbn.TabIndex = 112;
            this.lab_isbn.Text = "ISBN";
            // 
            // frm_libro_eli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(575, 378);
            this.Controls.Add(this.com_idioma);
            this.Controls.Add(this.com_tipo_libro);
            this.Controls.Add(this.tex_año);
            this.Controls.Add(this.tex_autor);
            this.Controls.Add(this.tex_edicion);
            this.Controls.Add(this.tex_titulo);
            this.Controls.Add(this.tex_isbn);
            this.Controls.Add(this.com_editorial);
            this.Controls.Add(this.lab_año);
            this.Controls.Add(this.lab_idioma);
            this.Controls.Add(this.lab_edicion);
            this.Controls.Add(this.lab_autor);
            this.Controls.Add(this.lab_tipo);
            this.Controls.Add(this.lab_editorial);
            this.Controls.Add(this.lab_titulo);
            this.Controls.Add(this.lab_isbn);
            this.Controls.Add(this.but_eliminar_libro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_libro_eli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Libro";
            this.Load += new System.EventHandler(this.frm_libro_eli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_eliminar_libro;
        private System.Windows.Forms.ComboBox com_idioma;
        private System.Windows.Forms.ComboBox com_tipo_libro;
        private System.Windows.Forms.TextBox tex_año;
        private System.Windows.Forms.TextBox tex_autor;
        private System.Windows.Forms.TextBox tex_edicion;
        private System.Windows.Forms.TextBox tex_titulo;
        private System.Windows.Forms.TextBox tex_isbn;
        private System.Windows.Forms.ComboBox com_editorial;
        private System.Windows.Forms.Label lab_año;
        private System.Windows.Forms.Label lab_idioma;
        private System.Windows.Forms.Label lab_edicion;
        private System.Windows.Forms.Label lab_autor;
        private System.Windows.Forms.Label lab_tipo;
        private System.Windows.Forms.Label lab_editorial;
        private System.Windows.Forms.Label lab_titulo;
        private System.Windows.Forms.Label lab_isbn;
    }
}