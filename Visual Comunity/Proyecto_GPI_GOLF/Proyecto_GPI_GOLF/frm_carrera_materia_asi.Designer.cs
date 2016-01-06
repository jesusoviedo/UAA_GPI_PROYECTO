namespace Proyecto_GPI_GOLF
{
    partial class frm_carrera_materia_asi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_carrera_materia_asi));
            this.dat_carrera_materia = new System.Windows.Forms.DataGridView();
            this.com_materia = new System.Windows.Forms.ComboBox();
            this.lab_materia = new System.Windows.Forms.Label();
            this.but_eliminar = new System.Windows.Forms.Button();
            this.but_agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dat_carrera_materia)).BeginInit();
            this.SuspendLayout();
            // 
            // dat_carrera_materia
            // 
            this.dat_carrera_materia.AllowUserToAddRows = false;
            this.dat_carrera_materia.AllowUserToDeleteRows = false;
            this.dat_carrera_materia.AllowUserToResizeColumns = false;
            this.dat_carrera_materia.AllowUserToResizeRows = false;
            this.dat_carrera_materia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dat_carrera_materia.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dat_carrera_materia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dat_carrera_materia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_carrera_materia.ColumnHeadersVisible = false;
            this.dat_carrera_materia.Location = new System.Drawing.Point(23, 138);
            this.dat_carrera_materia.Name = "dat_carrera_materia";
            this.dat_carrera_materia.ReadOnly = true;
            this.dat_carrera_materia.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dat_carrera_materia.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dat_carrera_materia.ShowCellErrors = false;
            this.dat_carrera_materia.ShowCellToolTips = false;
            this.dat_carrera_materia.ShowEditingIcon = false;
            this.dat_carrera_materia.ShowRowErrors = false;
            this.dat_carrera_materia.Size = new System.Drawing.Size(533, 220);
            this.dat_carrera_materia.TabIndex = 80;
            // 
            // com_materia
            // 
            this.com_materia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_materia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_materia.FormattingEnabled = true;
            this.com_materia.Location = new System.Drawing.Point(156, 91);
            this.com_materia.Name = "com_materia";
            this.com_materia.Size = new System.Drawing.Size(400, 27);
            this.com_materia.TabIndex = 1;
            // 
            // lab_materia
            // 
            this.lab_materia.AutoSize = true;
            this.lab_materia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_materia.Location = new System.Drawing.Point(19, 94);
            this.lab_materia.Name = "lab_materia";
            this.lab_materia.Size = new System.Drawing.Size(56, 19);
            this.lab_materia.TabIndex = 79;
            this.lab_materia.Text = "Materia";
            // 
            // but_eliminar
            // 
            this.but_eliminar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_eliminar.Location = new System.Drawing.Point(23, 49);
            this.but_eliminar.Name = "but_eliminar";
            this.but_eliminar.Size = new System.Drawing.Size(533, 23);
            this.but_eliminar.TabIndex = 3;
            this.but_eliminar.Text = "Desasociar Materia";
            this.but_eliminar.UseVisualStyleBackColor = true;
            this.but_eliminar.Click += new System.EventHandler(this.but_eliminar_Click);
            // 
            // but_agregar
            // 
            this.but_agregar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_agregar.Location = new System.Drawing.Point(23, 20);
            this.but_agregar.Name = "but_agregar";
            this.but_agregar.Size = new System.Drawing.Size(533, 23);
            this.but_agregar.TabIndex = 2;
            this.but_agregar.Text = "Asociar Materia";
            this.but_agregar.UseVisualStyleBackColor = true;
            this.but_agregar.Click += new System.EventHandler(this.but_agregar_Click);
            // 
            // frm_carrera_materia_asi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(575, 378);
            this.Controls.Add(this.dat_carrera_materia);
            this.Controls.Add(this.com_materia);
            this.Controls.Add(this.lab_materia);
            this.Controls.Add(this.but_eliminar);
            this.Controls.Add(this.but_agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_carrera_materia_asi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Materia";
            this.Load += new System.EventHandler(this.frm_carrera_materia_asi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_carrera_materia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dat_carrera_materia;
        private System.Windows.Forms.ComboBox com_materia;
        private System.Windows.Forms.Label lab_materia;
        private System.Windows.Forms.Button but_eliminar;
        private System.Windows.Forms.Button but_agregar;
    }
}