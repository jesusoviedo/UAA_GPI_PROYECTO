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
    public partial class frm_carrera_agr : Form
    {
        private string usuario { get; set; }
        private SortedList SLfacultad;

        public frm_carrera_agr()
        {
            InitializeComponent();
        }

        public frm_carrera_agr(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.inicializarDatos();
        }

        public override string ToString()
        {
            return string.Format("frm_carrera_agr");
        }

        private void inicializarDatos()
        {
            tex_nombre.Text = "";
            tex_promocion.Text = "";
            tex_descripcion.Text = "";
            this.mostrarLista();
            
        }

        private void mostrarLista()
        {
            StringBuilder errorMessages = new StringBuilder();
            Carrera ca = new Carrera();
            try
            {

                if ((ca.OptenerFacultad(ca)).v_facultad.Count != 0)
                {
                    SLfacultad = new SortedList();
                    foreach (String facultad in ca.v_facultad)
                    {
                        SLfacultad.Add(facultad, facultad);
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
                "Agregar Carrera",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private bool validar_datos()
        {
            bool error = true;

            if (tex_nombre.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un Nombre",
                "Agregar Carrera",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                error = false;
            }
            else if (tex_promocion.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar una  Promoción",
                "Agregar Carrera",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                error = false;
            }
            return error;

        }

        private bool validar_datos_2()
        {
            bool error = true;
            int prmocion;
            if (tex_promocion.Text.Length != 0)
            {
                try
                {
                    prmocion = Convert.ToInt32(tex_promocion.Text);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Debe ingresar una Promoción valida",
                    "Agregar Carrera",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    error = false;

                    Console.WriteLine(e.Message.ToString());
                }
            }

            return error;

        }


        private void frm_carrera_agr_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void but_agregar_carrera_Click(object sender, EventArgs e)
        {
            if (this.validar_datos() && this.validar_datos_2())
            {

                StringBuilder errorMessages = new StringBuilder();
                Carrera ca = new Carrera();

                ca.v_nombre= tex_nombre.Text;
                ca.v_promocion= tex_promocion.Text;
                ca.v_Dfacultad = com_facultad.SelectedItem.ToString();
                ca.v_descripcion = tex_descripcion.Text;
                ca.v_usuario_i = this.usuario;

                try
                {
                    if (ca.AgregarCarrera(ca) != 0)
                    {
                        this.inicializarDatos();

                        MessageBox.Show("Carrera creada correctamente" + "\n" + "Nombre Carrera: " + ca.v_nombre,
                        "Agregar Carrera",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
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
                    "Agregar Carrera",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }

        }
    }
}
