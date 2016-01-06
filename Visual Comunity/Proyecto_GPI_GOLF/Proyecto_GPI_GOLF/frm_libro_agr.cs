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
    public partial class frm_libro_agr : Form
    {
        private string usuario { get; set; }
        Libro lib = new Libro();
        private SortedList SLeditorial, SLtipolibro, SLidioma;

        public frm_libro_agr()
        {
            InitializeComponent();
        }

        public frm_libro_agr(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.mostrarLista();
        }

        public override string ToString()
        {
            return string.Format("frm_libro_agr");
        }

        private void inicializarDatos()
        {
            tex_año.Text = "";
            tex_autor.Text = "";
            tex_edicion.Text = "";
            tex_isbn.Text = "";
            tex_titulo.Text = "";
        }

        private void mostrarLista()
        {
            StringBuilder errorMessages = new StringBuilder();
            try
            {

                if ((lib.OptenerEditorial(lib)).v_editorial.Count != 0)
                {
                    SLeditorial = new SortedList();
                    foreach (String editorial in lib.v_editorial)
                    {
                        SLeditorial.Add(editorial, editorial);
                    }
                    com_editorial.DataSource = SLeditorial.GetValueList();
                    com_editorial.Show();
                }

                if ((lib.OptenerTipoLibro(lib)).v_tipo_libro.Count != 0)
                {
                    SLtipolibro = new SortedList();
                    foreach (String tipolibro in lib.v_tipo_libro)
                    {
                        SLtipolibro.Add(tipolibro, tipolibro);
                    }
                    com_tipo_libro.DataSource = SLtipolibro.GetValueList();
                    com_tipo_libro.Show();
                }

                if ((lib.OptenerIdioma(lib)).v_idioma.Count != 0)
                {
                    SLidioma = new SortedList();
                    foreach (String idioma in lib.v_idioma)
                    {
                        SLidioma.Add(idioma, idioma);
                    }
                    com_idioma.DataSource = SLidioma.GetValueList();
                    com_idioma.Show();
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
                "Agregar Libro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }

        }

        private bool ValidarDatos2()
        {
            bool error = true;
            int anho;
            if (tex_año.Text.Length != 0)
            {
                try
                {
                    anho = Convert.ToInt32(tex_año.Text);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Debe ingresar un Año valido",
                    "Agregar Libro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    error = false;

                    Console.WriteLine(e.Message.ToString());
                }
            }

            return error;
        }

        private bool ValidarDatos()
        {
            bool error = true;

            if (tex_isbn.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un ISBN",
                "Agregar Libro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                error = false;
            } 
            else if (tex_titulo.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un Titulo",
                "Agregar Libro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                error = false;
            }
            else if (tex_autor.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un Autor",
                "Agregar Libro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                error = false;
            }
            else if (tex_edicion.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar una Edicion",
                "Agregar Libro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                error = false;
            }
            else if (tex_año.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un Año",
                "Agregar Libro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                error = false;
            }

            return error;
        }

        private void frm_libro_agr_Load(object sender, EventArgs e)
        {

        }

        private void but_agregar_libro_Click(object sender, EventArgs e)
        {
            if (this.ValidarDatos() && this.ValidarDatos2())
            {

                StringBuilder errorMessages = new StringBuilder();
                lib.v_isbn = tex_isbn.Text;
                lib.v_titulo = tex_titulo.Text;
                lib.v_Deditorial = com_editorial.SelectedItem.ToString();
                lib.v_Dtipo_libro = com_tipo_libro.SelectedItem.ToString();
                lib.v_autor = tex_autor.Text;
                lib.v_edicion = tex_edicion.Text;
                lib.v_Didioma = com_idioma.SelectedItem.ToString();
                lib.v_año = tex_año.Text;
                lib.v_usuario_i = this.usuario;

                try
                {
                    if (lib.AgregarLibro(lib) != 0)
                    {
                        MessageBox.Show("Libro creado correctamente" + "\n" + "Titulo del Libro: " + lib.v_titulo,
                        "Agregar Libro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        this.inicializarDatos();
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
                    this.inicializarDatos();
                    MessageBox.Show(ex.Errors[0].Message.ToString(),
                    "Agregar Libro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
        }
    }
}
