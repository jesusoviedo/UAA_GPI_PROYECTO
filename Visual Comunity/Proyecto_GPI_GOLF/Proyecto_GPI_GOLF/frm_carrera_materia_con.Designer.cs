namespace Proyecto_GPI_GOLF
{
    partial class frm_carrera_materia_con
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_carrera_materia_con));
            this.dat_carrera_materia = new System.Windows.Forms.DataGridView();
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
            this.dat_carrera_materia.Location = new System.Drawing.Point(23, 12);
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
            this.dat_carrera_materia.Size = new System.Drawing.Size(533, 346);
            this.dat_carrera_materia.TabIndex = 85;
            this.dat_carrera_materia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dat_carrera_materia_CellContentClick);
            // 
            // frm_carrera_materia_con
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(575, 378);
            this.Controls.Add(this.dat_carrera_materia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_carrera_materia_con";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Materia";
            this.Load += new System.EventHandler(this.frm_carrera_materia_con_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_carrera_materia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dat_carrera_materia;
    }
}