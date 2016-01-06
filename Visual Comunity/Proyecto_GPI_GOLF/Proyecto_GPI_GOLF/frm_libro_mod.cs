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
    public partial class frm_libro_mod : Form
    {
        private string usuario { get; set; }
        private int ingreso;
        private Libro lib = new Libro();
        StringBuilder errorMessages = new StringBuilder();
        SortedList SLeditorial, SLtipolibro, SLidioma;

        public frm_libro_mod()
        {
            InitializeComponent();
        }

        public frm_libro_mod(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.inicializarDatos();
        }

        private void inicializarDatos()
        {

            tex_año.Text = "";
            tex_autor.Text = "";
            tex_edicion.Text = "";
            tex_isbn.Text = "";
            tex_titulo.Text = "";

            tex_isbn.Enabled = true;
            tex_año.Enabled = false;
            tex_autor.Enabled = false;
            tex_edicion.Enabled = false;
            tex_titulo.Enabled = false;

            che_activar_libro.Enabled = false;
            che_activar_libro.Checked = false;

            com_editorial.DataSource = null;
            com_editorial.Enabled = false;
            com_editorial.Show();

            com_tipo_libro.DataSource = null;
            com_tipo_libro.Enabled = false;
            com_tipo_libro.Show();

            com_idioma.DataSource = null;
            com_idioma.Enabled = false;
            com_idioma.Show();
        }


        public override string ToString()
        {
            return string.Format("frm_libro_mod");
        }

        private void frm_libro_mod_Load(object sender, EventArgs e)
        {

        }

        private bool validar_datos_2 ()
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
                    "Modificar Libro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    error = false;

                    Console.WriteLine(e.Message.ToString());
                }
            }

            return error;
        }

        private bool validar_datos()
        {
            bool error = true;

            if (tex_isbn.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un ISBN",
                "Modificar Libro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                error = false;
            }
            else if (tex_titulo.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un Titulo",
                "Modificar Libro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                error = false;
            }
            else if (tex_autor.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un Autor",
                "Modificar Libro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                error = false;
            }
            else if (tex_edicion.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar una Edicion",
                "Modificar Libro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                error = false;
            }
            else if (tex_año.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un Año",
                "Modificar Libro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                error = false;
            }

            return error;
        }


        private void tex_libro_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_modificar_libro_Click(object sender, EventArgs e)
        {
            if (tex_isbn.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un ISBN",
                "Modificar Libro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else if (ingreso != 1)
            {
                MessageBox.Show("Debe ingresar el ISBN y presionar enter",
                "Modificar Libro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {

                if (this.validar_datos() == true && this.validar_datos_2() == true)
                {

                    lib.v_isbn = tex_isbn.Text;
                    lib.v_titulo = tex_titulo.Text;
                    lib.v_Deditorial = com_editorial.SelectedItem.ToString();
                    lib.v_Dtipo_libro = com_tipo_libro.SelectedItem.ToString();
                    lib.v_autor = tex_autor.Text;
                    lib.v_edicion = tex_edicion.Text;
                    lib.v_Didioma = com_idioma.SelectedItem.ToString();
                    lib.v_año = tex_año.Text;

                    lib.v_usuario_m = this.usuario;

                    if (che_activar_libro.Checked == true)
                    {
                        lib.v_estado = 'A';
                    }


                    try
                    {
                        if (lib.ModificarLibro(lib) != 0)
                        {
                            MessageBox.Show("Libro modifacada correctamente" + "\n" + "Titulo Libro: " + lib.v_titulo,
                            "Modificar Libro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                            this.inicializarDatos();
                            ingreso = 0;

                            SLidioma.Clear();
                            lib.v_idioma.Clear();

                            SLtipolibro.Clear();
                            lib.v_tipo_libro.Clear();

                            SLeditorial.Clear();
                            lib.v_editorial.Clear();
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
                        "Modificar Libro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                        SLidioma.Clear();
                        lib.v_idioma.Clear();

                        SLtipolibro.Clear();
                        lib.v_tipo_libro.Clear();

                        SLeditorial.Clear();
                        lib.v_editorial.Clear();

                    }
                }
            }
        }

        public void mostrarLista()
        {
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
                    com_editorial.SelectedItem = lib.v_Deditorial;
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
                    com_tipo_libro.SelectedItem = lib.v_Dtipo_libro;
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
                    com_idioma.SelectedItem = lib.v_Didioma;
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
                "Modificar Libro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private void tex_isbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {

                try
                {
                    ingreso = 1;
                    lib.v_isbn = tex_isbn.Text;

                    if ((lib.ConsultarLibroAI(lib)).v_isbn.Length != 0)
                    {
                        tex_isbn.Text = lib.v_isbn;
                        tex_titulo.Text = lib.v_titulo;
                        tex_edicion.Text = lib.v_edicion;
                        tex_autor.Text = lib.v_autor;
                        tex_año.Text = lib.v_año;

                        tex_isbn.Enabled = false;
                        tex_año.Enabled = true;
                        tex_autor.Enabled = true;
                        tex_edicion.Enabled = true;
                        tex_titulo.Enabled = true;

                        if (lib.v_estado == 'I')
                        {
                            che_activar_libro.Enabled = true;
                            che_activar_libro.Checked = false;
                        }

                        this.mostrarLista();
                        com_idioma.Enabled = true;
                        com_tipo_libro.Enabled = true;
                        com_editorial.Enabled = true;
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
                    "Modificar Libro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    ingreso = 0;
                }
            }
        }
    }
}
