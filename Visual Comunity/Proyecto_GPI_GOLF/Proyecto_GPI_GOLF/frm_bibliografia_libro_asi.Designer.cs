namespace Proyecto_GPI_GOLF
{
    partial class frm_bibliografia_libro_asi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_bibliografia_libro_asi));
            this.dat_materia_libro = new System.Windows.Forms.DataGridView();
            this.com_isbn = new System.Windows.Forms.ComboBox();
            this.lab_isbn = new System.Windows.Forms.Label();
            this.but_eliminar = new System.Windows.Forms.Button();
            this.but_agregar = new System.Windows.Forms.Button();
            this.com_tipo_bibliografia = new System.Windows.Forms.ComboBox();
            this.lab_tipo_bibliografia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dat_materia_libro)).BeginInit();
            this.SuspendLayout();
            // 
            // dat_materia_libro
            // 
            this.dat_materia_libro.AllowUserToAddRows = false;
            this.dat_materia_libro.AllowUserToDeleteRows = false;
            this.dat_materia_libro.AllowUserToResizeColumns = false;
            this.dat_materia_libro.AllowUserToResizeRows = false;
            this.dat_materia_libro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dat_materia_libro.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dat_materia_libro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dat_materia_libro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_materia_libro.ColumnHeadersVisible = false;
            this.dat_materia_libro.Location = new System.Drawing.Point(23, 149);
            this.dat_materia_libro.Name = "dat_materia_libro";
            this.dat_materia_libro.ReadOnly = true;
            this.dat_materia_libro.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dat_materia_libro.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dat_materia_libro.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dat_materia_libro.ShowCellErrors = false;
            this.dat_materia_libro.ShowCellToolTips = false;
            this.dat_materia_libro.ShowEditingIcon = false;
            this.dat_materia_libro.ShowRowErrors = false;
            this.dat_materia_libro.Size = new System.Drawing.Size(533, 220);
            this.dat_materia_libro.TabIndex = 5;
            // 
            // com_isbn
            // 
            this.com_isbn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_isbn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_isbn.FormattingEnabled = true;
            this.com_isbn.Location = new System.Drawing.Point(156, 82);
            this.com_isbn.Name = "com_isbn";
            this.com_isbn.Size = new System.Drawing.Size(400, 27);
            this.com_isbn.TabIndex = 1;
            // 
            // lab_isbn
            // 
            this.lab_isbn.AutoSize = true;
            this.lab_isbn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_isbn.Location = new System.Drawing.Point(19, 85);
            this.lab_isbn.Name = "lab_isbn";
            this.lab_isbn.Size = new System.Drawing.Size(45, 19);
            this.lab_isbn.TabIndex = 84;
            this.lab_isbn.Text = "ISBN";
            // 
            // but_eliminar
            // 
            this.but_eliminar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_eliminar.Location = new System.Drawing.Point(23, 49);
            this.but_eliminar.Name = "but_eliminar";
            this.but_eliminar.Size = new System.Drawing.Size(533, 23);
            this.but_eliminar.TabIndex = 4;
            this.but_eliminar.Text = "Desasociar Libro";
            this.but_eliminar.UseVisualStyleBackColor = true;
            this.but_eliminar.Click += new System.EventHandler(this.but_eliminar_Click);
            // 
            // but_agregar
            // 
            this.but_agregar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_agregar.Location = new System.Drawing.Point(23, 20);
            this.but_agregar.Name = "but_agregar";
            this.but_agregar.Size = new System.Drawing.Size(533, 23);
            this.but_agregar.TabIndex = 3;
            this.but_agregar.Text = "Asociar Libro";
            this.but_agregar.UseVisualStyleBackColor = true;
            this.but_agregar.Click += new System.EventHandler(this.but_agregar_Click);
            // 
            // com_tipo_bibliografia
            // 
            this.com_tipo_bibliografia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_tipo_bibliografia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_tipo_bibliografia.FormattingEnabled = true;
            this.com_tipo_bibliografia.Location = new System.Drawing.Point(156, 115);
            this.com_tipo_bibliografia.Name = "com_tipo_bibliografia";
            this.com_tipo_bibliografia.Size = new System.Drawing.Size(400, 27);
            this.com_tipo_bibliografia.TabIndex = 2;
            // 
            // lab_tipo_bibliografia
            // 
            this.lab_tipo_bibliografia.AutoSize = true;
            this.lab_tipo_bibliografia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tipo_bibliografia.Location = new System.Drawing.Point(19, 118);
            this.lab_tipo_bibliografia.Name = "lab_tipo_bibliografia";
            this.lab_tipo_bibliografia.Size = new System.Drawing.Size(112, 19);
            this.lab_tipo_bibliografia.TabIndex = 87;
            this.lab_tipo_bibliografia.Text = "Tipo Bibliografía ";
            // 
            // frm_bibliografia_libro_asi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(575, 378);
            this.Controls.Add(this.com_tipo_bibliografia);
            this.Controls.Add(this.lab_tipo_bibliografia);
            this.Controls.Add(this.dat_materia_libro);
            this.Controls.Add(this.com_isbn);
            this.Controls.Add(this.lab_isbn);
            this.Controls.Add(this.but_eliminar);
            this.Controls.Add(this.but_agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_bibliografia_libro_asi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Libros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_bibliografia_libro_asi_FormClosing);
            this.Load += new System.EventHandler(this.frm_bibliografia_libro_asi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_materia_libro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dat_materia_libro;
        private System.Windows.Forms.ComboBox com_isbn;
        private System.Windows.Forms.Label lab_isbn;
        private System.Windows.Forms.Button but_eliminar;
        private System.Windows.Forms.Button but_agregar;
        private System.Windows.Forms.ComboBox com_tipo_bibliografia;
        private System.Windows.Forms.Label lab_tipo_bibliografia;
    }
}