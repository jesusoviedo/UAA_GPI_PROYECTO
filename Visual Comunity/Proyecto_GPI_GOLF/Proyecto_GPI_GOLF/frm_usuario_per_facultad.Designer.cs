namespace Proyecto_GPI_GOLF
{
    partial class frm_usuario_per_facultad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_usuario_per_facultad));
            this.but_agregar = new System.Windows.Forms.Button();
            this.but_eliminar = new System.Windows.Forms.Button();
            this.com_facultad = new System.Windows.Forms.ComboBox();
            this.lab_facultad = new System.Windows.Forms.Label();
            this.dat_usuario_facultad = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dat_usuario_facultad)).BeginInit();
            this.SuspendLayout();
            // 
            // but_agregar
            // 
            this.but_agregar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_agregar.Location = new System.Drawing.Point(21, 12);
            this.but_agregar.Name = "but_agregar";
            this.but_agregar.Size = new System.Drawing.Size(533, 23);
            this.but_agregar.TabIndex = 2;
            this.but_agregar.Text = "Asociar Facultad";
            this.but_agregar.UseVisualStyleBackColor = true;
            this.but_agregar.Click += new System.EventHandler(this.but_agregar_Click);
            // 
            // but_eliminar
            // 
            this.but_eliminar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_eliminar.Location = new System.Drawing.Point(21, 41);
            this.but_eliminar.Name = "but_eliminar";
            this.but_eliminar.Size = new System.Drawing.Size(533, 23);
            this.but_eliminar.TabIndex = 3;
            this.but_eliminar.Text = "Desasociar Facultad";
            this.but_eliminar.UseVisualStyleBackColor = true;
            this.but_eliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // com_facultad
            // 
            this.com_facultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_facultad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_facultad.FormattingEnabled = true;
            this.com_facultad.Location = new System.Drawing.Point(154, 83);
            this.com_facultad.Name = "com_facultad";
            this.com_facultad.Size = new System.Drawing.Size(400, 27);
            this.com_facultad.TabIndex = 1;
            // 
            // lab_facultad
            // 
            this.lab_facultad.AutoSize = true;
            this.lab_facultad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_facultad.Location = new System.Drawing.Point(17, 86);
            this.lab_facultad.Name = "lab_facultad";
            this.lab_facultad.Size = new System.Drawing.Size(61, 19);
            this.lab_facultad.TabIndex = 74;
            this.lab_facultad.Text = "Facultad";
            // 
            // dat_usuario_facultad
            // 
            this.dat_usuario_facultad.AllowUserToAddRows = false;
            this.dat_usuario_facultad.AllowUserToDeleteRows = false;
            this.dat_usuario_facultad.AllowUserToResizeColumns = false;
            this.dat_usuario_facultad.AllowUserToResizeRows = false;
            this.dat_usuario_facultad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dat_usuario_facultad.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dat_usuario_facultad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dat_usuario_facultad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_usuario_facultad.ColumnHeadersVisible = false;
            this.dat_usuario_facultad.Location = new System.Drawing.Point(21, 130);
            this.dat_usuario_facultad.Name = "dat_usuario_facultad";
            this.dat_usuario_facultad.ReadOnly = true;
            this.dat_usuario_facultad.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dat_usuario_facultad.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dat_usuario_facultad.ShowCellErrors = false;
            this.dat_usuario_facultad.ShowCellToolTips = false;
            this.dat_usuario_facultad.ShowEditingIcon = false;
            this.dat_usuario_facultad.ShowRowErrors = false;
            this.dat_usuario_facultad.Size = new System.Drawing.Size(533, 220);
            this.dat_usuario_facultad.TabIndex = 75;
            // 
            // frm_usuario_per_facultad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(575, 378);
            this.Controls.Add(this.dat_usuario_facultad);
            this.Controls.Add(this.com_facultad);
            this.Controls.Add(this.lab_facultad);
            this.Controls.Add(this.but_eliminar);
            this.Controls.Add(this.but_agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_usuario_per_facultad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Facultad";
            this.Load += new System.EventHandler(this.frm_usuario_per_facultad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_usuario_facultad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_agregar;
        private System.Windows.Forms.Button but_eliminar;
        private System.Windows.Forms.ComboBox com_facultad;
        private System.Windows.Forms.Label lab_facultad;
        private System.Windows.Forms.DataGridView dat_usuario_facultad;
    }
}