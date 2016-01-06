namespace Proyecto_GPI_GOLF
{
    partial class frm_menu_pri
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu_pri));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.men_usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_men_usuario_cam_cla = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_men_usuario_per = new System.Windows.Forms.ToolStripMenuItem();
            this.men_persona = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_men_persona_agr = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_men_persona_mod = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_men_persona_con = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_men_persona_eli = new System.Windows.Forms.ToolStripMenuItem();
            this.men_carrera = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_men_carrera_agr = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_men_carrera_mod = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_men_carrera_con = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_men_carrera_eli = new System.Windows.Forms.ToolStripMenuItem();
            this.men_materia = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_men_materia_agr = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_men_materia_mod = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_men_materia_con = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_men_materia_eli = new System.Windows.Forms.ToolStripMenuItem();
            this.men_libro = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_men_libro_agr = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_men_libro_mod = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_men_libro_con = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_men_libro_eli = new System.Windows.Forms.ToolStripMenuItem();
            this.men_editorial = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_men_editorial_agr = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_men_editorial_mod = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_men_editorial_con = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_men_editorial_eli = new System.Windows.Forms.ToolStripMenuItem();
            this.men_bibliografia = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_men_bibliografia_sol = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_men_bibliografia_con = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_men_bibliografia_aut = new System.Windows.Forms.ToolStripMenuItem();
            this.pic_ayuda = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ayuda)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.men_usuario,
            this.men_persona,
            this.men_carrera,
            this.men_materia,
            this.men_libro,
            this.men_editorial,
            this.men_bibliografia});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(575, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // men_usuario
            // 
            this.men_usuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sub_men_usuario_cam_cla,
            this.sub_men_usuario_per});
            this.men_usuario.Name = "men_usuario";
            this.men_usuario.Size = new System.Drawing.Size(68, 23);
            this.men_usuario.Text = "Usuario";
            // 
            // sub_men_usuario_cam_cla
            // 
            this.sub_men_usuario_cam_cla.Name = "sub_men_usuario_cam_cla";
            this.sub_men_usuario_cam_cla.Size = new System.Drawing.Size(203, 24);
            this.sub_men_usuario_cam_cla.Text = "Cambiar Contraseña";
            this.sub_men_usuario_cam_cla.Click += new System.EventHandler(this.sub_men_usuario_cam_cla_Click);
            // 
            // sub_men_usuario_per
            // 
            this.sub_men_usuario_per.Name = "sub_men_usuario_per";
            this.sub_men_usuario_per.Size = new System.Drawing.Size(203, 24);
            this.sub_men_usuario_per.Text = "Permisos";
            this.sub_men_usuario_per.Click += new System.EventHandler(this.sub_men_usuario_per_Click);
            // 
            // men_persona
            // 
            this.men_persona.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sub_men_persona_agr,
            this.sub_men_persona_mod,
            this.sub_men_persona_con,
            this.sub_men_persona_eli});
            this.men_persona.Name = "men_persona";
            this.men_persona.Size = new System.Drawing.Size(70, 23);
            this.men_persona.Text = "Persona";
            // 
            // sub_men_persona_agr
            // 
            this.sub_men_persona_agr.Name = "sub_men_persona_agr";
            this.sub_men_persona_agr.Size = new System.Drawing.Size(137, 24);
            this.sub_men_persona_agr.Text = "Agregar";
            this.sub_men_persona_agr.Click += new System.EventHandler(this.sub_men_persona_agr_Click);
            // 
            // sub_men_persona_mod
            // 
            this.sub_men_persona_mod.Name = "sub_men_persona_mod";
            this.sub_men_persona_mod.Size = new System.Drawing.Size(137, 24);
            this.sub_men_persona_mod.Text = "Modificar";
            this.sub_men_persona_mod.Click += new System.EventHandler(this.sub_men_persona_mod_Click);
            // 
            // sub_men_persona_con
            // 
            this.sub_men_persona_con.Name = "sub_men_persona_con";
            this.sub_men_persona_con.Size = new System.Drawing.Size(137, 24);
            this.sub_men_persona_con.Text = "Consultar";
            this.sub_men_persona_con.Click += new System.EventHandler(this.sub_men_persona_con_Click);
            // 
            // sub_men_persona_eli
            // 
            this.sub_men_persona_eli.Name = "sub_men_persona_eli";
            this.sub_men_persona_eli.Size = new System.Drawing.Size(137, 24);
            this.sub_men_persona_eli.Text = "Eliminar";
            this.sub_men_persona_eli.Click += new System.EventHandler(this.sub_men_persona_eli_Click);
            // 
            // men_carrera
            // 
            this.men_carrera.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sub_men_carrera_agr,
            this.sub_men_carrera_mod,
            this.sub_men_carrera_con,
            this.sub_men_carrera_eli});
            this.men_carrera.Name = "men_carrera";
            this.men_carrera.Size = new System.Drawing.Size(68, 23);
            this.men_carrera.Text = "Carrera";
            // 
            // sub_men_carrera_agr
            // 
            this.sub_men_carrera_agr.Name = "sub_men_carrera_agr";
            this.sub_men_carrera_agr.Size = new System.Drawing.Size(137, 24);
            this.sub_men_carrera_agr.Text = "Agregar";
            this.sub_men_carrera_agr.Click += new System.EventHandler(this.sub_men_carrera_agr_Click);
            // 
            // sub_men_carrera_mod
            // 
            this.sub_men_carrera_mod.Name = "sub_men_carrera_mod";
            this.sub_men_carrera_mod.Size = new System.Drawing.Size(137, 24);
            this.sub_men_carrera_mod.Text = "Modificar";
            this.sub_men_carrera_mod.Click += new System.EventHandler(this.sub_men_carrera_mod_Click);
            // 
            // sub_men_carrera_con
            // 
            this.sub_men_carrera_con.Name = "sub_men_carrera_con";
            this.sub_men_carrera_con.Size = new System.Drawing.Size(137, 24);
            this.sub_men_carrera_con.Text = "Consular";
            this.sub_men_carrera_con.Click += new System.EventHandler(this.sub_men_carrera_con_Click);
            // 
            // sub_men_carrera_eli
            // 
            this.sub_men_carrera_eli.Name = "sub_men_carrera_eli";
            this.sub_men_carrera_eli.Size = new System.Drawing.Size(137, 24);
            this.sub_men_carrera_eli.Text = "Eliminar";
            this.sub_men_carrera_eli.Click += new System.EventHandler(this.sub_men_carrera_eli_Click);
            // 
            // men_materia
            // 
            this.men_materia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sub_men_materia_agr,
            this.sub_men_materia_mod,
            this.sub_men_materia_con,
            this.sub_men_materia_eli});
            this.men_materia.Name = "men_materia";
            this.men_materia.Size = new System.Drawing.Size(68, 23);
            this.men_materia.Text = "Materia";
            // 
            // sub_men_materia_agr
            // 
            this.sub_men_materia_agr.Name = "sub_men_materia_agr";
            this.sub_men_materia_agr.Size = new System.Drawing.Size(137, 24);
            this.sub_men_materia_agr.Text = "Agregar";
            this.sub_men_materia_agr.Click += new System.EventHandler(this.sub_men_materia_agr_Click);
            // 
            // sub_men_materia_mod
            // 
            this.sub_men_materia_mod.Name = "sub_men_materia_mod";
            this.sub_men_materia_mod.Size = new System.Drawing.Size(137, 24);
            this.sub_men_materia_mod.Text = "Modificar";
            this.sub_men_materia_mod.Click += new System.EventHandler(this.sub_men_materia_mod_Click);
            // 
            // sub_men_materia_con
            // 
            this.sub_men_materia_con.Name = "sub_men_materia_con";
            this.sub_men_materia_con.Size = new System.Drawing.Size(137, 24);
            this.sub_men_materia_con.Text = "Consultar";
            this.sub_men_materia_con.Click += new System.EventHandler(this.sub_men_materia_con_Click);
            // 
            // sub_men_materia_eli
            // 
            this.sub_men_materia_eli.Name = "sub_men_materia_eli";
            this.sub_men_materia_eli.Size = new System.Drawing.Size(137, 24);
            this.sub_men_materia_eli.Text = "Eliminar";
            this.sub_men_materia_eli.Click += new System.EventHandler(this.sub_men_materia_eli_Click);
            // 
            // men_libro
            // 
            this.men_libro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sub_men_libro_agr,
            this.sub_men_libro_mod,
            this.sub_men_libro_con,
            this.sub_men_libro_eli});
            this.men_libro.Name = "men_libro";
            this.men_libro.Size = new System.Drawing.Size(54, 23);
            this.men_libro.Text = "Libro";
            // 
            // sub_men_libro_agr
            // 
            this.sub_men_libro_agr.Name = "sub_men_libro_agr";
            this.sub_men_libro_agr.Size = new System.Drawing.Size(137, 24);
            this.sub_men_libro_agr.Text = "Agregar";
            this.sub_men_libro_agr.Click += new System.EventHandler(this.sub_men_libro_agr_Click);
            // 
            // sub_men_libro_mod
            // 
            this.sub_men_libro_mod.Name = "sub_men_libro_mod";
            this.sub_men_libro_mod.Size = new System.Drawing.Size(137, 24);
            this.sub_men_libro_mod.Text = "Modificar";
            this.sub_men_libro_mod.Click += new System.EventHandler(this.sub_men_libro_mod_Click);
            // 
            // sub_men_libro_con
            // 
            this.sub_men_libro_con.Name = "sub_men_libro_con";
            this.sub_men_libro_con.Size = new System.Drawing.Size(137, 24);
            this.sub_men_libro_con.Text = "Consultar";
            this.sub_men_libro_con.Click += new System.EventHandler(this.sub_men_libro_con_Click);
            // 
            // sub_men_libro_eli
            // 
            this.sub_men_libro_eli.Name = "sub_men_libro_eli";
            this.sub_men_libro_eli.Size = new System.Drawing.Size(137, 24);
            this.sub_men_libro_eli.Text = "Eliminar";
            this.sub_men_libro_eli.Click += new System.EventHandler(this.sub_men_libro_eli_Click);
            // 
            // men_editorial
            // 
            this.men_editorial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sub_men_editorial_agr,
            this.sub_men_editorial_mod,
            this.sub_men_editorial_con,
            this.sub_men_editorial_eli});
            this.men_editorial.Name = "men_editorial";
            this.men_editorial.Size = new System.Drawing.Size(71, 23);
            this.men_editorial.Text = "Editorial";
            // 
            // sub_men_editorial_agr
            // 
            this.sub_men_editorial_agr.Name = "sub_men_editorial_agr";
            this.sub_men_editorial_agr.Size = new System.Drawing.Size(137, 24);
            this.sub_men_editorial_agr.Text = "Agregar";
            this.sub_men_editorial_agr.Click += new System.EventHandler(this.sub_men_editorial_agr_Click);
            // 
            // sub_men_editorial_mod
            // 
            this.sub_men_editorial_mod.Name = "sub_men_editorial_mod";
            this.sub_men_editorial_mod.Size = new System.Drawing.Size(137, 24);
            this.sub_men_editorial_mod.Text = "Modificar";
            this.sub_men_editorial_mod.Click += new System.EventHandler(this.sub_men_editorial_mod_Click);
            // 
            // sub_men_editorial_con
            // 
            this.sub_men_editorial_con.Name = "sub_men_editorial_con";
            this.sub_men_editorial_con.Size = new System.Drawing.Size(137, 24);
            this.sub_men_editorial_con.Text = "Consultar";
            this.sub_men_editorial_con.Click += new System.EventHandler(this.sub_men_editorial_con_Click);
            // 
            // sub_men_editorial_eli
            // 
            this.sub_men_editorial_eli.Name = "sub_men_editorial_eli";
            this.sub_men_editorial_eli.Size = new System.Drawing.Size(137, 24);
            this.sub_men_editorial_eli.Text = "Eliminar";
            this.sub_men_editorial_eli.Click += new System.EventHandler(this.sub_men_editorial_eli_Click);
            // 
            // men_bibliografia
            // 
            this.men_bibliografia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sub_men_bibliografia_sol,
            this.sub_men_bibliografia_con,
            this.sub_men_bibliografia_aut});
            this.men_bibliografia.Name = "men_bibliografia";
            this.men_bibliografia.Size = new System.Drawing.Size(89, 23);
            this.men_bibliografia.Text = "Bibliografia";
            // 
            // sub_men_bibliografia_sol
            // 
            this.sub_men_bibliografia_sol.Name = "sub_men_bibliografia_sol";
            this.sub_men_bibliografia_sol.Size = new System.Drawing.Size(152, 24);
            this.sub_men_bibliografia_sol.Text = "Solicitar";
            this.sub_men_bibliografia_sol.Click += new System.EventHandler(this.sub_men_bibliografia_sol_Click);
            // 
            // sub_men_bibliografia_con
            // 
            this.sub_men_bibliografia_con.Name = "sub_men_bibliografia_con";
            this.sub_men_bibliografia_con.Size = new System.Drawing.Size(152, 24);
            this.sub_men_bibliografia_con.Text = "Consultar";
            this.sub_men_bibliografia_con.Click += new System.EventHandler(this.sub_men_bibliografia_con_Click);
            // 
            // sub_men_bibliografia_aut
            // 
            this.sub_men_bibliografia_aut.Name = "sub_men_bibliografia_aut";
            this.sub_men_bibliografia_aut.Size = new System.Drawing.Size(152, 24);
            this.sub_men_bibliografia_aut.Text = "Autorizar";
            this.sub_men_bibliografia_aut.Click += new System.EventHandler(this.sub_men_bibliografia_aut_Click);
            // 
            // pic_ayuda
            // 
            this.pic_ayuda.Image = global::Proyecto_GPI_GOLF.Properties.Resources.Help_Bubble_24;
            this.pic_ayuda.Location = new System.Drawing.Point(509, 3);
            this.pic_ayuda.Name = "pic_ayuda";
            this.pic_ayuda.Size = new System.Drawing.Size(27, 24);
            this.pic_ayuda.TabIndex = 3;
            this.pic_ayuda.TabStop = false;
            this.pic_ayuda.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // frm_menu_pri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(575, 448);
            this.Controls.Add(this.pic_ayuda);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_menu_pri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_menu_pri_FormClosing);
            this.Load += new System.EventHandler(this.frm_menu_pri_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_menu_pri_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ayuda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem men_persona;
        private System.Windows.Forms.ToolStripMenuItem sub_men_persona_agr;
        private System.Windows.Forms.ToolStripMenuItem sub_men_persona_mod;
        private System.Windows.Forms.ToolStripMenuItem sub_men_persona_con;
        private System.Windows.Forms.ToolStripMenuItem sub_men_persona_eli;
        private System.Windows.Forms.ToolStripMenuItem men_usuario;
        private System.Windows.Forms.ToolStripMenuItem sub_men_usuario_cam_cla;
        private System.Windows.Forms.ToolStripMenuItem sub_men_usuario_per;
        private System.Windows.Forms.ToolStripMenuItem men_carrera;
        private System.Windows.Forms.ToolStripMenuItem sub_men_carrera_agr;
        private System.Windows.Forms.ToolStripMenuItem sub_men_carrera_mod;
        private System.Windows.Forms.ToolStripMenuItem sub_men_carrera_con;
        private System.Windows.Forms.ToolStripMenuItem sub_men_carrera_eli;
        private System.Windows.Forms.ToolStripMenuItem men_materia;
        private System.Windows.Forms.ToolStripMenuItem sub_men_materia_agr;
        private System.Windows.Forms.ToolStripMenuItem sub_men_materia_mod;
        private System.Windows.Forms.ToolStripMenuItem sub_men_materia_con;
        private System.Windows.Forms.ToolStripMenuItem sub_men_materia_eli;
        private System.Windows.Forms.ToolStripMenuItem men_libro;
        private System.Windows.Forms.ToolStripMenuItem sub_men_libro_agr;
        private System.Windows.Forms.ToolStripMenuItem sub_men_libro_mod;
        private System.Windows.Forms.ToolStripMenuItem sub_men_libro_con;
        private System.Windows.Forms.ToolStripMenuItem sub_men_libro_eli;
        private System.Windows.Forms.ToolStripMenuItem men_editorial;
        private System.Windows.Forms.ToolStripMenuItem sub_men_editorial_agr;
        private System.Windows.Forms.ToolStripMenuItem sub_men_editorial_mod;
        private System.Windows.Forms.ToolStripMenuItem sub_men_editorial_con;
        private System.Windows.Forms.ToolStripMenuItem sub_men_editorial_eli;
        private System.Windows.Forms.ToolStripMenuItem men_bibliografia;
        private System.Windows.Forms.ToolStripMenuItem sub_men_bibliografia_sol;
        private System.Windows.Forms.ToolStripMenuItem sub_men_bibliografia_con;
        private System.Windows.Forms.ToolStripMenuItem sub_men_bibliografia_aut;
        private System.Windows.Forms.PictureBox pic_ayuda;
    }
}