namespace Proyecto_GPI_GOLF
{
    partial class frm_bibliografia_libro_con
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_bibliografia_libro_con));
            this.dat_materia_libro = new System.Windows.Forms.DataGridView();
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
            this.dat_materia_libro.Location = new System.Drawing.Point(21, 12);
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
            this.dat_materia_libro.Size = new System.Drawing.Size(533, 354);
            this.dat_materia_libro.TabIndex = 86;
            // 
            // frm_bibliografia_libro_con
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(575, 378);
            this.Controls.Add(this.dat_materia_libro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_bibliografia_libro_con";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Libro";
            this.Load += new System.EventHandler(this.frm_bibliografia_libro_con_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_materia_libro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dat_materia_libro;
    }
}