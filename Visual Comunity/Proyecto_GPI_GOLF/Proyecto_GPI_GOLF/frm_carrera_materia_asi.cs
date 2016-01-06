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
    public partial class frm_carrera_materia_asi : Form
    {
        private String usuario, nombre, promocion;
        private SortedList SLfacultad;
        StringBuilder errorMessages = new StringBuilder();
        Carrera ca = new Carrera();

        public frm_carrera_materia_asi()
        {
            InitializeComponent();
        }

        public frm_carrera_materia_asi(String usuario, String nombre,String promocion)
        {
            InitializeComponent();
            this.usuario=usuario;
            this.nombre=nombre;
            this.promocion = promocion;
            this.mostrarLista();
            this.consultaInicial();
            
        }

        private void frm_carrera_materia_asi_Load(object sender, EventArgs e)
        {

        }

        private void consultaInicial()
        {
            ca.v_nombre = this.nombre;
            ca.v_promocion = this.promocion;
            try
            {

                if ((ca.ConsultarCarreraMateria(ca)).v_materia_carrera.Count != 0)
                {

                    dat_carrera_materia.ColumnCount = 1;
                    dat_carrera_materia.Columns[0].Name = "materia";
                    foreach (String materias in ca.v_materia_carrera)
                    {
                        dat_carrera_materia.Rows.Add(materias);
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
                "Asignar Materia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private void mostrarLista()
        {
            StringBuilder errorMessages = new StringBuilder();
            Carrera ca = new Carrera();
            try
            {

                if ((ca.OptenerMateria(ca)).v_materia.Count != 0)
                {
                    SLfacultad = new SortedList();
                    foreach (String materia in ca.v_materia)
                    {
                        SLfacultad.Add(materia, materia);
                    }
                    com_materia.DataSource = SLfacultad.GetValueList();
                    com_materia.Show();
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
                "Asignar Materia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }




        private void but_agregar_Click(object sender, EventArgs e)
        {
            ca.v_nombre = this.nombre;
            ca.v_promocion= this.promocion;
            ca.v_DMateria = com_materia.SelectedItem.ToString();
            ca.v_usuario_i = this.usuario;

            try
            {
                if (ca.AgregarCarreraMateria(ca) != 0)
                {
                    MessageBox.Show("Materia asociada correctamente" + "\n" + "Nombre Materia: " + ca.v_DMateria,
                    "Asignar Materia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    dat_carrera_materia.DataSource = null;
                    dat_carrera_materia.Rows.Clear();
                    ca.v_materia_carrera.Clear();

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
                "Asignar Materia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }





        private void but_eliminar_Click(object sender, EventArgs e)
        {
            //
            ca.v_nombre = this.nombre;
            ca.v_promocion = this.promocion;
            ca.v_DMateria = com_materia.SelectedItem.ToString();
            ca.v_usuario_m = this.usuario;

            try
            {
                if (ca.EliminarCarreraMateria(ca) != 0)
                {
                    MessageBox.Show("Materia desasociada correctamente" + "\n" + "Nombre Materia: " + ca.v_DMateria,
                    "Asignar Materia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    dat_carrera_materia.DataSource = null;
                    dat_carrera_materia.Rows.Clear();
                    ca.v_materia_carrera.Clear();

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
                "Asignar Materia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }
    }
}
