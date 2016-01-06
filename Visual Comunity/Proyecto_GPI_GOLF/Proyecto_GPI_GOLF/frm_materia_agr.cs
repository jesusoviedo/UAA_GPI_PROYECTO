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
    public partial class frm_materia_agr : Form
    {
        private string usuario { get; set; }
        private SortedList SLfacultad;

        public frm_materia_agr()
        {
            InitializeComponent();
        }

        public frm_materia_agr(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.inicializarDatos();
            this.mostrarLista();
        }

        public override string ToString()
        {
            return string.Format("frm_materia_agr");
        }

        private void frm_materia_agr_Load(object sender, EventArgs e)
        {

        }

        private void mostrarLista()
        {
            StringBuilder errorMessages = new StringBuilder();
            Materia mat = new Materia();
            try
            {

                if ((mat.OptenerFacultad(mat)).v_facultad.Count != 0)
                {
                    SLfacultad = new SortedList();
                    foreach (String facu in mat.v_facultad)
                    {
                        SLfacultad.Add(facu, facu);
                    }
                    com_facultad.DataSource = SLfacultad.GetValueList();
                    com_facultad.Show();
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
                "Agregar Materia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }



        private bool verificar_datos_materia()
        {
            bool error = true;

            if (tex_nombre.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un Nombre",
                "Agregar Materia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                error = false;
            } else if (tex_clave.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar una  Clave",
                "Agregar Materia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                error = false;
            }
            return error;
        }

        private void inicializarDatos()
        {
            tex_nombre.Text = "";
            tex_clave.Text = "";
            tex_descripcion.Text = "";
        }

        private void but_agregar_materia_Click(object sender, EventArgs e)
        {
            if (this.verificar_datos_materia())
            {

                if (tex_descripcion.Text.Length == 0)
                {
                    tex_descripcion.Text = "";
                }

                StringBuilder errorMessages = new StringBuilder();
                Materia mat = new Materia();

                mat.v_nombre = tex_nombre.Text;
                mat.v_clave = tex_clave.Text;
                mat.v_descripcion = tex_descripcion.Text;
                mat.v_usuario_i = this.usuario;
                mat.v_Dfacultad = com_facultad.SelectedItem.ToString();

                try
                {
                    if (mat.AgregarMateria(mat) != 0)
                    {
                        MessageBox.Show("Materia creada correctamente" + "\n" + "Nombre: " + mat.v_nombre,
                        "Agregar Materia",
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

                    MessageBox.Show(ex.Errors[0].Message.ToString(),
                    "Agregar Materia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
        }
    }
}
