namespace Proyecto_GPI_GOLF
{
    partial class frm_materia_con
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_materia_con));
            this.tex_clave = new System.Windows.Forms.TextBox();
            this.tex_descripcion = new System.Windows.Forms.TextBox();
            this.tex_nombre = new System.Windows.Forms.TextBox();
            this.lab_descripcion = new System.Windows.Forms.Label();
            this.lab_clave = new System.Windows.Forms.Label();
            this.lab_nombre = new System.Windows.Forms.Label();
            this.but_consultar_materia = new System.Windows.Forms.Button();
            this.com_facultad = new System.Windows.Forms.ComboBox();
            this.lab_facultad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tex_clave
            // 
            this.tex_clave.Enabled = false;
            this.tex_clave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_clave.Location = new System.Drawing.Point(156, 90);
            this.tex_clave.Name = "tex_clave";
            this.tex_clave.Size = new System.Drawing.Size(217, 26);
            this.tex_clave.TabIndex = 35;
            // 
            // tex_descripcion
            // 
            this.tex_descripcion.Enabled = false;
            this.tex_descripcion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_descripcion.Location = new System.Drawing.Point(156, 121);
            this.tex_descripcion.Multiline = true;
            this.tex_descripcion.Name = "tex_descripcion";
            this.tex_descripcion.Size = new System.Drawing.Size(217, 158);
            this.tex_descripcion.TabIndex = 36;
            // 
            // tex_nombre
            // 
            this.tex_nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_nombre.Location = new System.Drawing.Point(156, 60);
            this.tex_nombre.Name = "tex_nombre";
            this.tex_nombre.Size = new System.Drawing.Size(217, 26);
            this.tex_nombre.TabIndex = 34;
            // 
            // lab_descripcion
            // 
            this.lab_descripcion.AutoSize = true;
            this.lab_descripcion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_descripcion.Location = new System.Drawing.Point(19, 124);
            this.lab_descripcion.Name = "lab_descripcion";
            this.lab_descripcion.Size = new System.Drawing.Size(85, 19);
            this.lab_descripcion.TabIndex = 48;
            this.lab_descripcion.Text = "Descripción ";
            // 
            // lab_clave
            // 
            this.lab_clave.AutoSize = true;
            this.lab_clave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_clave.Location = new System.Drawing.Point(19, 93);
            this.lab_clave.Name = "lab_clave";
            this.lab_clave.Size = new System.Drawing.Size(44, 19);
            this.lab_clave.TabIndex = 47;
            this.lab_clave.Text = "Clave";
            // 
            // lab_nombre
            // 
            this.lab_nombre.AutoSize = true;
            this.lab_nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_nombre.Location = new System.Drawing.Point(19, 63);
            this.lab_nombre.Name = "lab_nombre";
            this.lab_nombre.Size = new System.Drawing.Size(60, 19);
            this.lab_nombre.TabIndex = 45;
            this.lab_nombre.Text = "Nombre";
            // 
            // but_consultar_materia
            // 
            this.but_consultar_materia.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_consultar_materia.Location = new System.Drawing.Point(23, 27);
            this.but_consultar_materia.Name = "but_consultar_materia";
            this.but_consultar_materia.Size = new System.Drawing.Size(533, 23);
            this.but_consultar_materia.TabIndex = 38;
            this.but_consultar_materia.Text = "Consultar Materia";
            this.but_consultar_materia.UseVisualStyleBackColor = true;
            this.but_consultar_materia.Click += new System.EventHandler(this.but_consultar_materia_Click);
            // 
            // com_facultad
            // 
            this.com_facultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_facultad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_facultad.FormattingEnabled = true;
            this.com_facultad.Location = new System.Drawing.Point(156, 285);
            this.com_facultad.Name = "com_facultad";
            this.com_facultad.Size = new System.Drawing.Size(217, 27);
            this.com_facultad.TabIndex = 37;
            // 
            // lab_facultad
            // 
            this.lab_facultad.AutoSize = true;
            this.lab_facultad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_facultad.Location = new System.Drawing.Point(19, 288);
            this.lab_facultad.Name = "lab_facultad";
            this.lab_facultad.Size = new System.Drawing.Size(61, 19);
            this.lab_facultad.TabIndex = 50;
            this.lab_facultad.Text = "Facultad";
            // 
            // frm_materia_con
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(575, 378);
            this.Controls.Add(this.com_facultad);
            this.Controls.Add(this.lab_facultad);
            this.Controls.Add(this.tex_clave);
            this.Controls.Add(this.tex_descripcion);
            this.Controls.Add(this.tex_nombre);
            this.Controls.Add(this.lab_descripcion);
            this.Controls.Add(this.lab_clave);
            this.Controls.Add(this.lab_nombre);
            this.Controls.Add(this.but_consultar_materia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_materia_con";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Materia";
            this.Load += new System.EventHandler(this.frm_materia_con_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tex_clave;
        private System.Windows.Forms.TextBox tex_descripcion;
        private System.Windows.Forms.TextBox tex_nombre;
        private System.Windows.Forms.Label lab_descripcion;
        private System.Windows.Forms.Label lab_clave;
        private System.Windows.Forms.Label lab_nombre;
        private System.Windows.Forms.Button but_consultar_materia;
        private System.Windows.Forms.ComboBox com_facultad;
        private System.Windows.Forms.Label lab_facultad;
    }
}