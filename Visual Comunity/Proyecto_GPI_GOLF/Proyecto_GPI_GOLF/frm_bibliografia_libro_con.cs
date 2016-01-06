using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usuario_logica;

namespace Proyecto_GPI_GOLF
{
    public partial class frm_bibliografia_libro_con : Form
    {
        String usuario, v_DnombreMateria, v_Dsemestre, v_descripcion;
        int v_año;
        StringBuilder errorMessages = new StringBuilder();
        Bibliografia bi = new Bibliografia();

        public frm_bibliografia_libro_con()
        {
            InitializeComponent();
        }

        public frm_bibliografia_libro_con(String usuario,
            String v_DnombreMateria,int v_año, String v_Dsemestre,String v_descripcion)
        {
            InitializeComponent();
            this.usuario=usuario;
            this.v_DnombreMateria=v_DnombreMateria;
            this.v_año=v_año;
            this.v_Dsemestre=v_Dsemestre;
            this.v_descripcion=v_descripcion;
            this.consultaInicial();
        }

        private void frm_bibliografia_libro_con_Load(object sender, EventArgs e)
        {

        }


        private void consultaInicial()
        {
            bi.v_DnombreMateria = this.v_DnombreMateria;
            bi.v_año = this.v_año;
            bi.v_Dsemestre = this.v_Dsemestre;
            bi.v_usuario_i = this.usuario;

            try
            {

                if ((bi.ConsultarMateriaLibroSAI(bi)).v_materia_libro.Count != 0)
                {
                    dat_materia_libro.ColumnCount = 1;
                    dat_materia_libro.Columns[0].Name = "libros";
                    foreach (String materias in bi.v_materia_libro)
                    {
                        dat_materia_libro.Rows.Add(materias);

                    }

                }
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                    "Message: " + ex.Errors[i].Message + "\n" +
                    "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                    "Source: " + ex.Errors[i].Source + "\n" +
                    "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());

                MessageBox.Show(ex.Errors[0].Message.ToString(),
                "Consultar Libros",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }
    }
}
