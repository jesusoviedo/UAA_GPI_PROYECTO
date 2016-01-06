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
    public partial class frm_carrera_eli : Form
    {
        private string usuario { get; set; }
        private SortedList SLfacultad = new SortedList();

        public frm_carrera_eli()
        {
            InitializeComponent();
        }

        public frm_carrera_eli(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.inicializarDatos();
        }

        public override string ToString()
        {
            return string.Format("frm_carrera_eli");
        }

        private void inicializarDatos()
        {
            tex_nombre.Text = "";
            tex_promocion.Text = "";
            tex_descripcion.Text = "";

            com_facultad.DataSource = null;
            com_facultad.Show();

            tex_descripcion.Enabled = false;
            com_facultad.Enabled = false;
        }

        private bool validardatos()
        {
            bool error = true;

            if (tex_nombre.Text.Length == 0)
            {

                MessageBox.Show("Debe ingresar un Nombre",
                "Eliminar Carrera",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

                error = false;
            }
            else if (tex_promocion.Text.Length == 0)
            {

                MessageBox.Show("Debe ingresar una Promoción",
                "Eliminar Carrera",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

                error = false;
            }
            else if (tex_promocion.Text.Length != 0)
            {
                int promocion;
                try
                {
                    promocion = Convert.ToInt32(tex_promocion.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe ingresar una Promoción valida",
                    "Eliminar Carrera",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    error = false;
                    Console.WriteLine(ex.Message.ToString());
                }
            }

            return error;
        }

        private void frm_carrera_eli_Load(object sender, EventArgs e)
        {

        }

        private void but_eliminar_carrera_Click(object sender, EventArgs e)
        {
            if (this.validardatos())
            {
                StringBuilder errorMessages = new StringBuilder();
                Carrera ca = new Carrera();
                    try
                    {
                        ca.v_nombre = tex_nombre.Text;
                        ca.v_promocion = tex_promocion.Text;
                        ca.v_usuario_m = this.usuario;
                        if ((ca.ConsultarCarrera(ca)).v_nombre.Length != 0)
                        {
                            tex_nombre.Text = ca.v_nombre;
                            tex_promocion.Text = ca.v_promocion;
                            tex_descripcion.Text = ca.v_descripcion;

                            SLfacultad.Add(ca.v_Dfacultad, ca.v_Dfacultad);
                            com_facultad.DataSource = SLfacultad.GetValueList();
                            com_facultad.Show();
                            com_facultad.Enabled = false;
                            SLfacultad.Clear();

                            if ((MessageBox.Show("¿Desea eliminar la Carrera con Nombre: " + ca.v_nombre + " ?", "Eliminar Materia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                            {

                                try
                                {
                                    if (ca.EliminarCarrera(ca) != 0)
                                    {
                                        this.inicializarDatos();
                                        com_facultad.DataSource = null;
                                        com_facultad.Show();
                                        MessageBox.Show("Carrera eliminada correctamente",
                                        "Eliminar Carrera",
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
                                        "Eliminar Carrera",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                                }
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
                        this.inicializarDatos();
                        MessageBox.Show(ex.Errors[0].Message.ToString(),
                        "Eliminar Carrera",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    }

                
            }
        }



    } //clase
} //name
