﻿namespace Proyecto_GPI_GOLF
{
    partial class frm_carrera_eli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_carrera_eli));
            this.but_eliminar_carrera = new System.Windows.Forms.Button();
            this.tex_nombre = new System.Windows.Forms.TextBox();
            this.lab_nombre = new System.Windows.Forms.Label();
            this.tex_promocion = new System.Windows.Forms.TextBox();
            this.lab_promocion = new System.Windows.Forms.Label();
            this.tex_descripcion = new System.Windows.Forms.TextBox();
            this.com_facultad = new System.Windows.Forms.ComboBox();
            this.lab_descripcion = new System.Windows.Forms.Label();
            this.lab_facultad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_eliminar_carrera
            // 
            this.but_eliminar_carrera.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_eliminar_carrera.Location = new System.Drawing.Point(23, 27);
            this.but_eliminar_carrera.Name = "but_eliminar_carrera";
            this.but_eliminar_carrera.Size = new System.Drawing.Size(533, 23);
            this.but_eliminar_carrera.TabIndex = 68;
            this.but_eliminar_carrera.Text = "Eliminar Carrera";
            this.but_eliminar_carrera.UseVisualStyleBackColor = true;
            this.but_eliminar_carrera.Click += new System.EventHandler(this.but_eliminar_carrera_Click);
            // 
            // tex_nombre
            // 
            this.tex_nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_nombre.Location = new System.Drawing.Point(157, 60);
            this.tex_nombre.Name = "tex_nombre";
            this.tex_nombre.Size = new System.Drawing.Size(217, 26);
            this.tex_nombre.TabIndex = 70;
            // 
            // lab_nombre
            // 
            this.lab_nombre.AutoSize = true;
            this.lab_nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_nombre.Location = new System.Drawing.Point(20, 63);
            this.lab_nombre.Name = "lab_nombre";
            this.lab_nombre.Size = new System.Drawing.Size(60, 19);
            this.lab_nombre.TabIndex = 69;
            this.lab_nombre.Text = "Nombre";
            // 
            // tex_promocion
            // 
            this.tex_promocion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_promocion.Location = new System.Drawing.Point(157, 92);
            this.tex_promocion.Name = "tex_promocion";
            this.tex_promocion.Size = new System.Drawing.Size(217, 26);
            this.tex_promocion.TabIndex = 76;
            // 
            // lab_promocion
            // 
            this.lab_promocion.AutoSize = true;
            this.lab_promocion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_promocion.Location = new System.Drawing.Point(20, 95);
            this.lab_promocion.Name = "lab_promocion";
            this.lab_promocion.Size = new System.Drawing.Size(79, 19);
            this.lab_promocion.TabIndex = 75;
            this.lab_promocion.Tag = "";
            this.lab_promocion.Text = "Promoción ";
            // 
            // tex_descripcion
            // 
            this.tex_descripcion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_descripcion.Location = new System.Drawing.Point(157, 155);
            this.tex_descripcion.Multiline = true;
            this.tex_descripcion.Name = "tex_descripcion";
            this.tex_descripcion.Size = new System.Drawing.Size(217, 214);
            this.tex_descripcion.TabIndex = 73;
            // 
            // com_facultad
            // 
            this.com_facultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_facultad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_facultad.FormattingEnabled = true;
            this.com_facultad.Location = new System.Drawing.Point(157, 124);
            this.com_facultad.Name = "com_facultad";
            this.com_facultad.Size = new System.Drawing.Size(217, 27);
            this.com_facultad.TabIndex = 71;
            // 
            // lab_descripcion
            // 
            this.lab_descripcion.AutoSize = true;
            this.lab_descripcion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_descripcion.Location = new System.Drawing.Point(20, 158);
            this.lab_descripcion.Name = "lab_descripcion";
            this.lab_descripcion.Size = new System.Drawing.Size(85, 19);
            this.lab_descripcion.TabIndex = 74;
            this.lab_descripcion.Text = "Descripción ";
            // 
            // lab_facultad
            // 
            this.lab_facultad.AutoSize = true;
            this.lab_facultad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_facultad.Location = new System.Drawing.Point(20, 127);
            this.lab_facultad.Name = "lab_facultad";
            this.lab_facultad.Size = new System.Drawing.Size(61, 19);
            this.lab_facultad.TabIndex = 72;
            this.lab_facultad.Text = "Facultad";
            // 
            // frm_carrera_eli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(575, 378);
            this.Controls.Add(this.tex_promocion);
            this.Controls.Add(this.lab_promocion);
            this.Controls.Add(this.tex_descripcion);
            this.Controls.Add(this.com_facultad);
            this.Controls.Add(this.lab_descripcion);
            this.Controls.Add(this.lab_facultad);
            this.Controls.Add(this.tex_nombre);
            this.Controls.Add(this.lab_nombre);
            this.Controls.Add(this.but_eliminar_carrera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_carrera_eli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Carrera";
            this.Load += new System.EventHandler(this.frm_carrera_eli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_eliminar_carrera;
        private System.Windows.Forms.TextBox tex_nombre;
        private System.Windows.Forms.Label lab_nombre;
        private System.Windows.Forms.TextBox tex_promocion;
        private System.Windows.Forms.Label lab_promocion;
        private System.Windows.Forms.TextBox tex_descripcion;
        private System.Windows.Forms.ComboBox com_facultad;
        private System.Windows.Forms.Label lab_descripcion;
        private System.Windows.Forms.Label lab_facultad;
    }
}