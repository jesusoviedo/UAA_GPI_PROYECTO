namespace Proyecto_GPI_GOLF
{
    partial class frm_usuario_rec_cla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_usuario_rec_cla));
            this.but_recuperar = new System.Windows.Forms.Button();
            this.lab_correo = new System.Windows.Forms.Label();
            this.tex_correo = new System.Windows.Forms.TextBox();
            this.tex_mensaje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // but_recuperar
            // 
            this.but_recuperar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.but_recuperar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_recuperar.Location = new System.Drawing.Point(142, 146);
            this.but_recuperar.Name = "but_recuperar";
            this.but_recuperar.Size = new System.Drawing.Size(114, 23);
            this.but_recuperar.TabIndex = 2;
            this.but_recuperar.Text = "Recuperar";
            this.but_recuperar.UseVisualStyleBackColor = true;
            this.but_recuperar.Click += new System.EventHandler(this.but_recuperar_Click);
            // 
            // lab_correo
            // 
            this.lab_correo.AutoSize = true;
            this.lab_correo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_correo.Location = new System.Drawing.Point(20, 100);
            this.lab_correo.Name = "lab_correo";
            this.lab_correo.Size = new System.Drawing.Size(123, 19);
            this.lab_correo.TabIndex = 1;
            this.lab_correo.Text = "Correo electrónico";
            this.lab_correo.Click += new System.EventHandler(this.label1_Click);
            // 
            // tex_correo
            // 
            this.tex_correo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_correo.Location = new System.Drawing.Point(164, 97);
            this.tex_correo.Name = "tex_correo";
            this.tex_correo.Size = new System.Drawing.Size(205, 26);
            this.tex_correo.TabIndex = 1;
            // 
            // tex_mensaje
            // 
            this.tex_mensaje.BackColor = System.Drawing.SystemColors.Control;
            this.tex_mensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tex_mensaje.Cursor = System.Windows.Forms.Cursors.Default;
            this.tex_mensaje.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_mensaje.Location = new System.Drawing.Point(24, 5);
            this.tex_mensaje.Multiline = true;
            this.tex_mensaje.Name = "tex_mensaje";
            this.tex_mensaje.ReadOnly = true;
            this.tex_mensaje.Size = new System.Drawing.Size(345, 87);
            this.tex_mensaje.TabIndex = 1000;
            this.tex_mensaje.TabStop = false;
            this.tex_mensaje.Text = "Estimado Usuario:\r\n\r\nPor favor ingrese su correo y a continuación de clic en el b" +
    "otón Recuperar.";
            this.tex_mensaje.TextChanged += new System.EventHandler(this.tex_mensaje_TextChanged);
            // 
            // frm_usuario_rec_cla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(399, 193);
            this.Controls.Add(this.tex_mensaje);
            this.Controls.Add(this.tex_correo);
            this.Controls.Add(this.lab_correo);
            this.Controls.Add(this.but_recuperar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_usuario_rec_cla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar Contraseña";
            this.Load += new System.EventHandler(this.frm_recuperar_contraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_recuperar;
        private System.Windows.Forms.Label lab_correo;
        private System.Windows.Forms.TextBox tex_correo;
        private System.Windows.Forms.TextBox tex_mensaje;
    }
}