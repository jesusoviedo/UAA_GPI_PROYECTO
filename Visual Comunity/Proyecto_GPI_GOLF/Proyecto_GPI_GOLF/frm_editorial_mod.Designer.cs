namespace Proyecto_GPI_GOLF
{
    partial class frm_editorial_mod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_editorial_mod));
            this.che_activar_editorial = new System.Windows.Forms.CheckBox();
            this.tex_direccion = new System.Windows.Forms.TextBox();
            this.tex_nombre_editorial = new System.Windows.Forms.TextBox();
            this.com_pais = new System.Windows.Forms.ComboBox();
            this.lab_nombre = new System.Windows.Forms.Label();
            this.lab_pais = new System.Windows.Forms.Label();
            this.lab_nombre_editorial = new System.Windows.Forms.Label();
            this.but_modificar_editorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // che_activar_editorial
            // 
            this.che_activar_editorial.AutoSize = true;
            this.che_activar_editorial.Enabled = false;
            this.che_activar_editorial.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.che_activar_editorial.Location = new System.Drawing.Point(431, 61);
            this.che_activar_editorial.Name = "che_activar_editorial";
            this.che_activar_editorial.Size = new System.Drawing.Size(126, 23);
            this.che_activar_editorial.TabIndex = 5;
            this.che_activar_editorial.Text = "Activar Editorial";
            this.che_activar_editorial.UseVisualStyleBackColor = true;
            // 
            // tex_direccion
            // 
            this.tex_direccion.Enabled = false;
            this.tex_direccion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_direccion.Location = new System.Drawing.Point(156, 120);
            this.tex_direccion.Name = "tex_direccion";
            this.tex_direccion.Size = new System.Drawing.Size(217, 26);
            this.tex_direccion.TabIndex = 4;
            // 
            // tex_nombre_editorial
            // 
            this.tex_nombre_editorial.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_nombre_editorial.Location = new System.Drawing.Point(156, 59);
            this.tex_nombre_editorial.Name = "tex_nombre_editorial";
            this.tex_nombre_editorial.Size = new System.Drawing.Size(217, 26);
            this.tex_nombre_editorial.TabIndex = 2;
            this.tex_nombre_editorial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_nombre_editorial_KeyPress);
            // 
            // com_pais
            // 
            this.com_pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_pais.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_pais.FormattingEnabled = true;
            this.com_pais.Location = new System.Drawing.Point(156, 89);
            this.com_pais.Name = "com_pais";
            this.com_pais.Size = new System.Drawing.Size(217, 27);
            this.com_pais.TabIndex = 3;
            this.com_pais.SelectionChangeCommitted += new System.EventHandler(this.com_pais_SelectionChangeCommitted_1);
            // 
            // lab_nombre
            // 
            this.lab_nombre.AutoSize = true;
            this.lab_nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_nombre.Location = new System.Drawing.Point(19, 123);
            this.lab_nombre.Name = "lab_nombre";
            this.lab_nombre.Size = new System.Drawing.Size(67, 19);
            this.lab_nombre.TabIndex = 95;
            this.lab_nombre.Text = "Dirección";
            // 
            // lab_pais
            // 
            this.lab_pais.AutoSize = true;
            this.lab_pais.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_pais.Location = new System.Drawing.Point(19, 92);
            this.lab_pais.Name = "lab_pais";
            this.lab_pais.Size = new System.Drawing.Size(34, 19);
            this.lab_pais.TabIndex = 94;
            this.lab_pais.Text = "País";
            // 
            // lab_nombre_editorial
            // 
            this.lab_nombre_editorial.AutoSize = true;
            this.lab_nombre_editorial.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_nombre_editorial.Location = new System.Drawing.Point(19, 62);
            this.lab_nombre_editorial.Name = "lab_nombre_editorial";
            this.lab_nombre_editorial.Size = new System.Drawing.Size(114, 19);
            this.lab_nombre_editorial.TabIndex = 92;
            this.lab_nombre_editorial.Text = "Nombre Editorial";
            // 
            // but_modificar_editorial
            // 
            this.but_modificar_editorial.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_modificar_editorial.Location = new System.Drawing.Point(23, 26);
            this.but_modificar_editorial.Name = "but_modificar_editorial";
            this.but_modificar_editorial.Size = new System.Drawing.Size(533, 23);
            this.but_modificar_editorial.TabIndex = 6;
            this.but_modificar_editorial.Text = "Modificar Editorial";
            this.but_modificar_editorial.UseVisualStyleBackColor = true;
            this.but_modificar_editorial.Click += new System.EventHandler(this.but_modificar_editorial_Click);
            // 
            // frm_editorial_mod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(575, 378);
            this.Controls.Add(this.che_activar_editorial);
            this.Controls.Add(this.tex_direccion);
            this.Controls.Add(this.tex_nombre_editorial);
            this.Controls.Add(this.com_pais);
            this.Controls.Add(this.lab_nombre);
            this.Controls.Add(this.lab_pais);
            this.Controls.Add(this.lab_nombre_editorial);
            this.Controls.Add(this.but_modificar_editorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_editorial_mod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Editorial";
            this.Load += new System.EventHandler(this.frm_editorial_mod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox che_activar_editorial;
        private System.Windows.Forms.TextBox tex_direccion;
        private System.Windows.Forms.TextBox tex_nombre_editorial;
        private System.Windows.Forms.ComboBox com_pais;
        private System.Windows.Forms.Label lab_nombre;
        private System.Windows.Forms.Label lab_pais;
        private System.Windows.Forms.Label lab_nombre_editorial;
        private System.Windows.Forms.Button but_modificar_editorial;
    }
}