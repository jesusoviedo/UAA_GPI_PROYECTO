using System;
using System.Collections;
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
    public partial class frm_bibliografia_libro_asi : Form
    {
        String usuario,v_DnombreMateria,v_Dsemestre,v_descripcion;
        int v_año;
        private SortedList SLisbn, SLtipobibliografia;
        StringBuilder errorMessages = new StringBuilder();
        Bibliografia bi = new Bibliografia();

        public frm_bibliografia_libro_asi()
        {
            InitializeComponent();
        }


        public frm_bibliografia_libro_asi(String usuario,
            String v_DnombreMateria,int v_año, String v_Dsemestre,String v_descripcion)
        {
            InitializeComponent();
            this.usuario=usuario;
            this.v_DnombreMateria=v_DnombreMateria;
            this.v_año=v_año;
            this.v_Dsemestre=v_Dsemestre;
            this.v_descripcion=v_descripcion;
            this.mostrarLista();
            this.consultaInicial();
        }


        private void mostrarLista()
        {
            StringBuilder errorMessages = new StringBuilder();
            Bibliografia bi = new Bibliografia();
            try
            {

                if ((bi.OptenerIsbn(bi)).v_isbn.Count != 0)
                {
                    SLisbn = new SortedList();
                    foreach (String isbn in bi.v_isbn)
                    {
                        SLisbn.Add(isbn, isbn);
                    }
                    com_isbn.DataSource = SLisbn.GetValueList();
                    com_isbn.Show();
                }

                if ((bi.OptenerTipoBibliografia(bi)).v_tipoBibliografia.Count != 0)
                {
                    SLtipobibliografia = new SortedList();
                    foreach (String tipobibliografias in bi.v_tipoBibliografia)
                    {
                        SLtipobibliografia.Add(tipobibliografias, tipobibliografias);
                    }
                    com_tipo_bibliografia.DataSource = SLtipobibliografia.GetValueList();
                    com_tipo_bibliografia.Show();
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
                "Asignar Libros",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private void frm_bibliografia_libro_asi_Load(object sender, EventArgs e)
        {

        }

        private void frm_bibliografia_libro_asi_FormClosing(object sender, FormClosingEventArgs e)
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
                if ((bi.ConsultarMateriaLibroP(bi)).v_materia_libro.Count != 0)
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
                "Asignar Libros",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }


        
        private void but_agregar_Click(object sender, EventArgs e)
        {
            //    

            bi.v_DnombreMateria= this.v_DnombreMateria;
            bi.v_Disbn = com_isbn.SelectedItem.ToString();
            bi.v_DtipoBibliografia = com_tipo_bibliografia.SelectedItem.ToString();
            bi.v_año= this.v_año;
            bi.v_Dsemestre = this.v_Dsemestre;
            bi.v_descripcion = this.v_descripcion;
            bi.v_usuario_i= this.usuario;

            try
            {
                if (bi.SolicitarAgregarMateriaLibroP(bi) != 0)
                {
                    MessageBox.Show("Libro asociada correctamente" + "\n" + "ISBN Libro: " + bi.v_Disbn,
                    "Asignar Libros",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    dat_materia_libro.DataSource = null;
                    dat_materia_libro.Rows.Clear();
                    bi.v_materia_libro.Clear();

                    this.consultaInicial();
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
                "Asignar Libros",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }





        private void but_eliminar_Click(object sender, EventArgs e)
        {

            bi.v_DnombreMateria = this.v_DnombreMateria;
            bi.v_Disbn = com_isbn.SelectedItem.ToString();
            bi.v_DtipoBibliografia = com_tipo_bibliografia.SelectedItem.ToString();
            bi.v_año = this.v_año;
            bi.v_Dsemestre = this.v_Dsemestre;
            bi.v_descripcion = this.v_descripcion;
            bi.v_usuario_i = this.usuario;

            try
            {
                if (bi.SolicitarEliminarMateriaLibroP(bi) != 0)
                {
                    MessageBox.Show("Libro desasociada correctamente" + "\n" + "ISBN Libro: " + bi.v_Disbn,
                    "Asignar Libros",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    dat_materia_libro.DataSource = null;
                    dat_materia_libro.Rows.Clear();
                    bi.v_materia_libro.Clear();

                    this.consultaInicial();
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
                "Asignar Libros",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }

        }



    }
}
