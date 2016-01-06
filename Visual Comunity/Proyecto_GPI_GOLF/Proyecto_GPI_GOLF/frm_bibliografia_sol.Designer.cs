namespace Proyecto_GPI_GOLF
{
    partial class frm_bibliografia_sol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_bibliografia_sol));
            this.but_libro_asignar = new System.Windows.Forms.Button();
            this.tex_año = new System.Windows.Forms.TextBox();
            this.lab_año = new System.Windows.Forms.Label();
            this.tex_descripcion = new System.Windows.Forms.TextBox();
            this.com_materia = new System.Windows.Forms.ComboBox();
            this.lab_descripcion = new System.Windows.Forms.Label();
            this.lab_semestre = new System.Windows.Forms.Label();
            this.lab_materia = new System.Windows.Forms.Label();
            this.but_solicitar_bibliografia = new System.Windows.Forms.Button();
            this.com_semestre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // but_libro_asignar
            // 
            this.but_libro_asignar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_libro_asignar.Location = new System.Drawing.Point(424, 54);
            this.but_libro_asignar.Name = "but_libro_asignar";
            this.but_libro_asignar.Size = new System.Drawing.Size(131, 23);
            this.but_libro_asignar.TabIndex = 5;
            this.but_libro_asignar.Text = "Asignar Libros";
            this.but_libro_asignar.UseVisualStyleBackColor = true;
            this.but_libro_asignar.Click += new System.EventHandler(this.but_libro_asignar_Click);
            // 
            // tex_año
            // 
            this.tex_año.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_año.Location = new System.Drawing.Point(157, 82);
            this.tex_año.Name = "tex_año";
            this.tex_año.Size = new System.Drawing.Size(217, 26);
            this.tex_año.TabIndex = 2;
            // 
            // lab_año
            // 
            this.lab_año.AutoSize = true;
            this.lab_año.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_año.Location = new System.Drawing.Point(20, 85);
            this.lab_año.Name = "lab_año";
            this.lab_año.Size = new System.Drawing.Size(35, 19);
            this.lab_año.TabIndex = 124;
            this.lab_año.Tag = "";
            this.lab_año.Text = "Año";
            // 
            // tex_descripcion
            // 
            this.tex_descripcion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_descripcion.Location = new System.Drawing.Point(157, 145);
            this.tex_descripcion.Multiline = true;
            this.tex_descripcion.Name = "tex_descripcion";
            this.tex_descripcion.Size = new System.Drawing.Size(217, 214);
            this.tex_descripcion.TabIndex = 4;
            // 
            // com_materia
            // 
            this.com_materia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_materia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_materia.FormattingEnabled = true;
            this.com_materia.Location = new System.Drawing.Point(157, 52);
            this.com_materia.Name = "com_materia";
            this.com_materia.Size = new System.Drawing.Size(217, 27);
            this.com_materia.TabIndex = 1;
            // 
            // lab_descripcion
            // 
            this.lab_descripcion.AutoSize = true;
            this.lab_descripcion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_descripcion.Location = new System.Drawing.Point(20, 148);
            this.lab_descripcion.Name = "lab_descripcion";
            this.lab_descripcion.Size = new System.Drawing.Size(85, 19);
            this.lab_descripcion.TabIndex = 123;
            this.lab_descripcion.Text = "Descripción ";
            // 
            // lab_semestre
            // 
            this.lab_semestre.AutoSize = true;
            this.lab_semestre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_semestre.Location = new System.Drawing.Point(20, 117);
            this.lab_semestre.Name = "lab_semestre";
            this.lab_semestre.Size = new System.Drawing.Size(65, 19);
            this.lab_semestre.TabIndex = 121;
            this.lab_semestre.Text = "Semestre";
            // 
            // lab_materia
            // 
            this.lab_materia.AutoSize = true;
            this.lab_materia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_materia.Location = new System.Drawing.Point(20, 55);
            this.lab_materia.Name = "lab_materia";
            this.lab_materia.Size = new System.Drawing.Size(56, 19);
            this.lab_materia.TabIndex = 118;
            this.lab_materia.Text = "Materia";
            // 
            // but_solicitar_bibliografia
            // 
            this.but_solicitar_bibliografia.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_solicitar_bibliografia.Location = new System.Drawing.Point(22, 19);
            this.but_solicitar_bibliografia.Name = "but_solicitar_bibliografia";
            this.but_solicitar_bibliografia.Size = new System.Drawing.Size(533, 23);
            this.but_solicitar_bibliografia.TabIndex = 6;
            this.but_solicitar_bibliografia.Text = "Solicitar Bibliografía";
            this.but_solicitar_bibliografia.UseVisualStyleBackColor = true;
            this.but_solicitar_bibliografia.Click += new System.EventHandler(this.but_solicitar_bibliografia_Click);
            // 
            // com_semestre
            // 
            this.com_semestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_semestre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_semestre.FormattingEnabled = true;
            this.com_semestre.Location = new System.Drawing.Point(157, 114);
            this.com_semestre.Name = "com_semestre";
            this.com_semestre.Size = new System.Drawing.Size(217, 27);
            this.com_semestre.TabIndex = 3;
            // 
            // frm_bibliografia_sol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(575, 378);
            this.Controls.Add(this.com_semestre);
            this.Controls.Add(this.but_libro_asignar);
            this.Controls.Add(this.tex_año);
            this.Controls.Add(this.lab_año);
            this.Controls.Add(this.tex_descripcion);
            this.Controls.Add(this.com_materia);
            this.Controls.Add(this.lab_descripcion);
            this.Controls.Add(this.lab_semestre);
            this.Controls.Add(this.lab_materia);
            this.Controls.Add(this.but_solicitar_bibliografia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_bibliografia_sol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitar Bibliografía";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_bibliografia_sol_FormClosed);
            this.Load += new System.EventHandler(this.frm_bibliografia_sol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_libro_asignar;
        private System.Windows.Forms.TextBox tex_año;
        private System.Windows.Forms.Label lab_año;
        private System.Windows.Forms.TextBox tex_descripcion;
        private System.Windows.Forms.ComboBox com_materia;
        private System.Windows.Forms.Label lab_descripcion;
        private System.Windows.Forms.Label lab_semestre;
        private System.Windows.Forms.Label lab_materia;
        private System.Windows.Forms.Button but_solicitar_bibliografia;
        private System.Windows.Forms.ComboBox com_semestre;

    }
}