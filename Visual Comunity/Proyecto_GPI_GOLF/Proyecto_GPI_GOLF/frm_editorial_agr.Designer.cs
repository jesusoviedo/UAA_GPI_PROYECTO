namespace Proyecto_GPI_GOLF
{
    partial class frm_editorial_agr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_editorial_agr));
            this.tex_nombre_editorial = new System.Windows.Forms.TextBox();
            this.com_pais = new System.Windows.Forms.ComboBox();
            this.lab_pais = new System.Windows.Forms.Label();
            this.lab_nombre_editorial = new System.Windows.Forms.Label();
            this.but_agregar_editorial = new System.Windows.Forms.Button();
            this.lab_direccion = new System.Windows.Forms.Label();
            this.tex_direccion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tex_nombre_editorial
            // 
            this.tex_nombre_editorial.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_nombre_editorial.Location = new System.Drawing.Point(156, 59);
            this.tex_nombre_editorial.Name = "tex_nombre_editorial";
            this.tex_nombre_editorial.Size = new System.Drawing.Size(217, 26);
            this.tex_nombre_editorial.TabIndex = 13;
            // 
            // com_pais
            // 
            this.com_pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_pais.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_pais.FormattingEnabled = true;
            this.com_pais.Location = new System.Drawing.Point(156, 89);
            this.com_pais.Name = "com_pais";
            this.com_pais.Size = new System.Drawing.Size(217, 27);
            this.com_pais.TabIndex = 14;
            // 
            // lab_pais
            // 
            this.lab_pais.AutoSize = true;
            this.lab_pais.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_pais.Location = new System.Drawing.Point(19, 92);
            this.lab_pais.Name = "lab_pais";
            this.lab_pais.Size = new System.Drawing.Size(34, 19);
            this.lab_pais.TabIndex = 15;
            this.lab_pais.Text = "País";
            // 
            // lab_nombre_editorial
            // 
            this.lab_nombre_editorial.AutoSize = true;
            this.lab_nombre_editorial.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_nombre_editorial.Location = new System.Drawing.Point(19, 62);
            this.lab_nombre_editorial.Name = "lab_nombre_editorial";
            this.lab_nombre_editorial.Size = new System.Drawing.Size(114, 19);
            this.lab_nombre_editorial.TabIndex = 12;
            this.lab_nombre_editorial.Text = "Nombre Editorial";
            // 
            // but_agregar_editorial
            // 
            this.but_agregar_editorial.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_agregar_editorial.Location = new System.Drawing.Point(23, 26);
            this.but_agregar_editorial.Name = "but_agregar_editorial";
            this.but_agregar_editorial.Size = new System.Drawing.Size(533, 23);
            this.but_agregar_editorial.TabIndex = 32;
            this.but_agregar_editorial.Text = "Agregar Editorial";
            this.but_agregar_editorial.UseVisualStyleBackColor = true;
            this.but_agregar_editorial.Click += new System.EventHandler(this.but_agregar_editorial_Click);
            // 
            // lab_direccion
            // 
            this.lab_direccion.AutoSize = true;
            this.lab_direccion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_direccion.Location = new System.Drawing.Point(19, 123);
            this.lab_direccion.Name = "lab_direccion";
            this.lab_direccion.Size = new System.Drawing.Size(67, 19);
            this.lab_direccion.TabIndex = 17;
            this.lab_direccion.Text = "Direccion";
            // 
            // tex_direccion
            // 
            this.tex_direccion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_direccion.Location = new System.Drawing.Point(156, 120);
            this.tex_direccion.Name = "tex_direccion";
            this.tex_direccion.Size = new System.Drawing.Size(217, 26);
            this.tex_direccion.TabIndex = 15;
            // 
            // frm_editorial_agr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(575, 378);
            this.Controls.Add(this.tex_direccion);
            this.Controls.Add(this.tex_nombre_editorial);
            this.Controls.Add(this.com_pais);
            this.Controls.Add(this.lab_direccion);
            this.Controls.Add(this.lab_pais);
            this.Controls.Add(this.lab_nombre_editorial);
            this.Controls.Add(this.but_agregar_editorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_editorial_agr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Editorial";
            this.Load += new System.EventHandler(this.frm_editorial_agr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tex_nombre_editorial;
        private System.Windows.Forms.ComboBox com_pais;
        private System.Windows.Forms.Label lab_pais;
        private System.Windows.Forms.Label lab_nombre_editorial;
        private System.Windows.Forms.Button but_agregar_editorial;
        private System.Windows.Forms.Label lab_direccion;
        private System.Windows.Forms.TextBox tex_direccion;
    }
}