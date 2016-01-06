namespace Proyecto_GPI_GOLF
{
    partial class frm_usuario_cam_cla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_usuario_cam_cla));
            this.tex_contraseña_nueva = new System.Windows.Forms.TextBox();
            this.lab_contraseña_nueva = new System.Windows.Forms.Label();
            this.tex_contraseña = new System.Windows.Forms.TextBox();
            this.lab_contraseña_actual = new System.Windows.Forms.Label();
            this.but_cambiar_contraseña = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tex_contraseña_nueva
            // 
            this.tex_contraseña_nueva.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_contraseña_nueva.Location = new System.Drawing.Point(214, 70);
            this.tex_contraseña_nueva.Name = "tex_contraseña_nueva";
            this.tex_contraseña_nueva.PasswordChar = '*';
            this.tex_contraseña_nueva.Size = new System.Drawing.Size(150, 26);
            this.tex_contraseña_nueva.TabIndex = 2;
            this.tex_contraseña_nueva.UseSystemPasswordChar = true;
            this.tex_contraseña_nueva.TextChanged += new System.EventHandler(this.tex_contraseña_TextChanged);
            // 
            // lab_contraseña_nueva
            // 
            this.lab_contraseña_nueva.AutoSize = true;
            this.lab_contraseña_nueva.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_contraseña_nueva.Location = new System.Drawing.Point(34, 73);
            this.lab_contraseña_nueva.Name = "lab_contraseña_nueva";
            this.lab_contraseña_nueva.Size = new System.Drawing.Size(117, 19);
            this.lab_contraseña_nueva.TabIndex = 5;
            this.lab_contraseña_nueva.Text = "Contraseña nueva";
            this.lab_contraseña_nueva.Click += new System.EventHandler(this.lab_contraseña_nueva_Click);
            // 
            // tex_contraseña
            // 
            this.tex_contraseña.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_contraseña.Location = new System.Drawing.Point(214, 25);
            this.tex_contraseña.Name = "tex_contraseña";
            this.tex_contraseña.PasswordChar = '*';
            this.tex_contraseña.Size = new System.Drawing.Size(150, 26);
            this.tex_contraseña.TabIndex = 1;
            this.tex_contraseña.UseSystemPasswordChar = true;
            this.tex_contraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex_contraseña_KeyDown);
            // 
            // lab_contraseña_actual
            // 
            this.lab_contraseña_actual.AutoSize = true;
            this.lab_contraseña_actual.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_contraseña_actual.Location = new System.Drawing.Point(34, 28);
            this.lab_contraseña_actual.Name = "lab_contraseña_actual";
            this.lab_contraseña_actual.Size = new System.Drawing.Size(117, 19);
            this.lab_contraseña_actual.TabIndex = 7;
            this.lab_contraseña_actual.Text = "Contraseña actual";
            this.lab_contraseña_actual.Click += new System.EventHandler(this.label1_Click);
            // 
            // but_cambiar_contraseña
            // 
            this.but_cambiar_contraseña.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.but_cambiar_contraseña.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_cambiar_contraseña.Location = new System.Drawing.Point(131, 130);
            this.but_cambiar_contraseña.Name = "but_cambiar_contraseña";
            this.but_cambiar_contraseña.Size = new System.Drawing.Size(134, 23);
            this.but_cambiar_contraseña.TabIndex = 3;
            this.but_cambiar_contraseña.Text = "Cambiar contraseña";
            this.but_cambiar_contraseña.UseVisualStyleBackColor = true;
            this.but_cambiar_contraseña.Click += new System.EventHandler(this.but_cambiar_contraseña_Click);
            // 
            // frm_usuario_cam_cla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(399, 193);
            this.Controls.Add(this.but_cambiar_contraseña);
            this.Controls.Add(this.tex_contraseña);
            this.Controls.Add(this.lab_contraseña_actual);
            this.Controls.Add(this.tex_contraseña_nueva);
            this.Controls.Add(this.lab_contraseña_nueva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_usuario_cam_cla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de Contraseña";
            this.Load += new System.EventHandler(this.frm_usuario_cam_cla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tex_contraseña_nueva;
        private System.Windows.Forms.Label lab_contraseña_nueva;
        private System.Windows.Forms.TextBox tex_contraseña;
        private System.Windows.Forms.Label lab_contraseña_actual;
        private System.Windows.Forms.Button but_cambiar_contraseña;
    }
}