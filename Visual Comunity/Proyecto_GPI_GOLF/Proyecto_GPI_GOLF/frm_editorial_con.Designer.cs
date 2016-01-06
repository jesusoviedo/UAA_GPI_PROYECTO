namespace Proyecto_GPI_GOLF
{
    partial class frm_editorial_con
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_editorial_con));
            this.but_consultar_editorial = new System.Windows.Forms.Button();
            this.tex_nombre_editorial = new System.Windows.Forms.TextBox();
            this.com_pais = new System.Windows.Forms.ComboBox();
            this.tex_direccion = new System.Windows.Forms.TextBox();
            this.lab_nombre = new System.Windows.Forms.Label();
            this.lab_pais = new System.Windows.Forms.Label();
            this.lab_nombre_editorial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_consultar_editorial
            // 
            this.but_consultar_editorial.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_consultar_editorial.Location = new System.Drawing.Point(23, 27);
            this.but_consultar_editorial.Name = "but_consultar_editorial";
            this.but_consultar_editorial.Size = new System.Drawing.Size(533, 23);
            this.but_consultar_editorial.TabIndex = 6;
            this.but_consultar_editorial.Text = "Consultar Editorial";
            this.but_consultar_editorial.UseVisualStyleBackColor = true;
            this.but_consultar_editorial.Click += new System.EventHandler(this.but_consultar_editorial_Click);
            // 
            // tex_nombre_editorial
            // 
            this.tex_nombre_editorial.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_nombre_editorial.Location = new System.Drawing.Point(156, 60);
            this.tex_nombre_editorial.Name = "tex_nombre_editorial";
            this.tex_nombre_editorial.Size = new System.Drawing.Size(217, 26);
            this.tex_nombre_editorial.TabIndex = 3;
            // 
            // com_pais
            // 
            this.com_pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_pais.Enabled = false;
            this.com_pais.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_pais.FormattingEnabled = true;
            this.com_pais.Location = new System.Drawing.Point(156, 90);
            this.com_pais.Name = "com_pais";
            this.com_pais.Size = new System.Drawing.Size(217, 27);
            this.com_pais.TabIndex = 4;
            // 
            // tex_direccion
            // 
            this.tex_direccion.Enabled = false;
            this.tex_direccion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_direccion.Location = new System.Drawing.Point(156, 121);
            this.tex_direccion.Name = "tex_direccion";
            this.tex_direccion.Size = new System.Drawing.Size(217, 26);
            this.tex_direccion.TabIndex = 5;
            this.tex_direccion.TextChanged += new System.EventHandler(this.tex_direccion_TextChanged);
            // 
            // lab_nombre
            // 
            this.lab_nombre.AutoSize = true;
            this.lab_nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_nombre.Location = new System.Drawing.Point(19, 124);
            this.lab_nombre.Name = "lab_nombre";
            this.lab_nombre.Size = new System.Drawing.Size(67, 19);
            this.lab_nombre.TabIndex = 48;
            this.lab_nombre.Text = "Direccion";
            this.lab_nombre.Click += new System.EventHandler(this.lab_nombre_Click);
            // 
            // lab_pais
            // 
            this.lab_pais.AutoSize = true;
            this.lab_pais.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_pais.Location = new System.Drawing.Point(19, 93);
            this.lab_pais.Name = "lab_pais";
            this.lab_pais.Size = new System.Drawing.Size(34, 19);
            this.lab_pais.TabIndex = 47;
            this.lab_pais.Text = "País";
            // 
            // lab_nombre_editorial
            // 
            this.lab_nombre_editorial.AutoSize = true;
            this.lab_nombre_editorial.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_nombre_editorial.Location = new System.Drawing.Point(19, 63);
            this.lab_nombre_editorial.Name = "lab_nombre_editorial";
            this.lab_nombre_editorial.Size = new System.Drawing.Size(114, 19);
            this.lab_nombre_editorial.TabIndex = 45;
            this.lab_nombre_editorial.Text = "Nombre Editorial";
            // 
            // frm_editorial_con
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(575, 378);
            this.Controls.Add(this.tex_direccion);
            this.Controls.Add(this.tex_nombre_editorial);
            this.Controls.Add(this.com_pais);
            this.Controls.Add(this.lab_nombre);
            this.Controls.Add(this.lab_pais);
            this.Controls.Add(this.lab_nombre_editorial);
            this.Controls.Add(this.but_consultar_editorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_editorial_con";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Editorial";
            this.Load += new System.EventHandler(this.frm_editorial_con_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_consultar_editorial;
        private System.Windows.Forms.TextBox tex_nombre_editorial;
        private System.Windows.Forms.ComboBox com_pais;
        private System.Windows.Forms.TextBox tex_direccion;
        private System.Windows.Forms.Label lab_nombre;
        private System.Windows.Forms.Label lab_pais;
        private System.Windows.Forms.Label lab_nombre_editorial;

    }
}