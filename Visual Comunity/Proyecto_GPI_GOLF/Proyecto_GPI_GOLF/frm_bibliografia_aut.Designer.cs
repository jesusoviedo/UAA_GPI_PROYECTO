namespace Proyecto_GPI_GOLF
{
    partial class frm_bibliografia_aut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_bibliografia_aut));
            this.com_semestre = new System.Windows.Forms.ComboBox();
            this.but_libro_consultar = new System.Windows.Forms.Button();
            this.tex_año = new System.Windows.Forms.TextBox();
            this.lab_año = new System.Windows.Forms.Label();
            this.tex_descripcion = new System.Windows.Forms.TextBox();
            this.com_materia = new System.Windows.Forms.ComboBox();
            this.lab_descripcion = new System.Windows.Forms.Label();
            this.lab_semestre = new System.Windows.Forms.Label();
            this.lab_materia = new System.Windows.Forms.Label();
            this.but_autorizar_bibliografia = new System.Windows.Forms.Button();
            this.but_rechazar_bibliografia = new System.Windows.Forms.Button();
            this.tex_solicitante = new System.Windows.Forms.TextBox();
            this.lab_solicitante = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.com_semestre.SelectionChangeCommitted += new System.EventHandler(this.com_semestre_SelectionChangeCommitted);
            // 
            // but_libro_consultar
            // 
            this.but_libro_consultar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_libro_consultar.Location = new System.Drawing.Point(424, 54);
            this.but_libro_consultar.Name = "but_libro_consultar";
            this.but_libro_consultar.Size = new System.Drawing.Size(131, 23);
            this.but_libro_consultar.TabIndex = 5;
            this.but_libro_consultar.Text = "Consultar Libros";
            this.but_libro_consultar.UseVisualStyleBackColor = true;
            this.but_libro_consultar.Click += new System.EventHandler(this.but_libro_consultar_Click);
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
            this.lab_año.TabIndex = 134;
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
            this.lab_descripcion.TabIndex = 133;
            this.lab_descripcion.Text = "Descripción ";
            // 
            // lab_semestre
            // 
            this.lab_semestre.AutoSize = true;
            this.lab_semestre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_semestre.Location = new System.Drawing.Point(20, 117);
            this.lab_semestre.Name = "lab_semestre";
            this.lab_semestre.Size = new System.Drawing.Size(65, 19);
            this.lab_semestre.TabIndex = 131;
            this.lab_semestre.Text = "Semestre";
            // 
            // lab_materia
            // 
            this.lab_materia.AutoSize = true;
            this.lab_materia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_materia.Location = new System.Drawing.Point(20, 55);
            this.lab_materia.Name = "lab_materia";
            this.lab_materia.Size = new System.Drawing.Size(56, 19);
            this.lab_materia.TabIndex = 129;
            this.lab_materia.Text = "Materia";
            // 
            // but_autorizar_bibliografia
            // 
            this.but_autorizar_bibliografia.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_autorizar_bibliografia.Location = new System.Drawing.Point(22, 19);
            this.but_autorizar_bibliografia.Name = "but_autorizar_bibliografia";
            this.but_autorizar_bibliografia.Size = new System.Drawing.Size(266, 23);
            this.but_autorizar_bibliografia.TabIndex = 6;
            this.but_autorizar_bibliografia.Text = "Autorizar Bibliografía";
            this.but_autorizar_bibliografia.UseVisualStyleBackColor = true;
            this.but_autorizar_bibliografia.Click += new System.EventHandler(this.but_autorizar_bibliografia_Click);
            // 
            // but_rechazar_bibliografia
            // 
            this.but_rechazar_bibliografia.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_rechazar_bibliografia.Location = new System.Drawing.Point(289, 19);
            this.but_rechazar_bibliografia.Name = "but_rechazar_bibliografia";
            this.but_rechazar_bibliografia.Size = new System.Drawing.Size(266, 23);
            this.but_rechazar_bibliografia.TabIndex = 7;
            this.but_rechazar_bibliografia.Text = "Rechazar Bibliografía";
            this.but_rechazar_bibliografia.UseVisualStyleBackColor = true;
            this.but_rechazar_bibliografia.Click += new System.EventHandler(this.but_rechazar_bibliografia_Click);
            // 
            // tex_solicitante
            // 
            this.tex_solicitante.Enabled = false;
            this.tex_solicitante.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_solicitante.Location = new System.Drawing.Point(424, 114);
            this.tex_solicitante.Name = "tex_solicitante";
            this.tex_solicitante.Size = new System.Drawing.Size(131, 26);
            this.tex_solicitante.TabIndex = 140;
            // 
            // lab_solicitante
            // 
            this.lab_solicitante.AutoSize = true;
            this.lab_solicitante.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_solicitante.Location = new System.Drawing.Point(420, 85);
            this.lab_solicitante.Name = "lab_solicitante";
            this.lab_solicitante.Size = new System.Drawing.Size(71, 19);
            this.lab_solicitante.TabIndex = 141;
            this.lab_solicitante.Text = "Solicitante";
            // 
            // frm_bibliografia_aut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(575, 378);
            this.Controls.Add(this.tex_solicitante);
            this.Controls.Add(this.lab_solicitante);
            this.Controls.Add(this.but_rechazar_bibliografia);
            this.Controls.Add(this.com_semestre);
            this.Controls.Add(this.but_libro_consultar);
            this.Controls.Add(this.tex_año);
            this.Controls.Add(this.lab_año);
            this.Controls.Add(this.tex_descripcion);
            this.Controls.Add(this.com_materia);
            this.Controls.Add(this.lab_descripcion);
            this.Controls.Add(this.lab_semestre);
            this.Controls.Add(this.lab_materia);
            this.Controls.Add(this.but_autorizar_bibliografia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_bibliografia_aut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autorizar Bibliografía";
            this.Load += new System.EventHandler(this.frm_bibliografia_aut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox com_semestre;
        private System.Windows.Forms.Button but_libro_consultar;
        private System.Windows.Forms.TextBox tex_año;
        private System.Windows.Forms.Label lab_año;
        private System.Windows.Forms.TextBox tex_descripcion;
        private System.Windows.Forms.ComboBox com_materia;
        private System.Windows.Forms.Label lab_descripcion;
        private System.Windows.Forms.Label lab_semestre;
        private System.Windows.Forms.Label lab_materia;
        private System.Windows.Forms.Button but_autorizar_bibliografia;
        private System.Windows.Forms.Button but_rechazar_bibliografia;
        private System.Windows.Forms.TextBox tex_solicitante;
        private System.Windows.Forms.Label lab_solicitante;
    }
}