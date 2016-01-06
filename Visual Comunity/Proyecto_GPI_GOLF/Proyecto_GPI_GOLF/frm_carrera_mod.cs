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
    public partial class frm_carrera_mod : Form
    {
        private string usuario { get; set; }
        private SortedList SLfacultad = new SortedList();
        private StringBuilder errorMessages = new StringBuilder();
        private Carrera ca = new Carrera();
        private int ingreso;

        public frm_carrera_mod()
        {
            InitializeComponent();
        }

        public frm_carrera_mod(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.inicializarDatos();
        }

        public override string ToString()
        {
            return string.Format("frm_carrera_mod");
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

            che_activar_carrera.Enabled = false;
            che_activar_carrera.Checked = false;

            but_materia_asignar.Enabled = false;
        }

        private void frm_carrera_mod_Load(object sender, EventArgs e)
        {

        }

        private bool validardatos()
        {
            bool error = true;

            if (tex_nombre.Text.Length == 0)
            {

                MessageBox.Show("Debe ingresar un Nombre",
                "Modificar Carrera",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

                error = false;
            }
            else if (tex_promocion.Text.Length == 0)
            {

                MessageBox.Show("Debe ingresar una Promoción",
                "Modificar Carrera",
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
                    "Modificar Carrera",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    error = false;
                    Console.WriteLine(ex.Message.ToString());
                }
            }

            return error;
        }

        private void but_modificar_carrera_Click(object sender, EventArgs e)
        {
            if (this.validardatos())
            {
                if (ingreso != 1)
                {
                    MessageBox.Show("Debe ingresar el nombre y promoción, y a continuación presionar enter",
                    "Modificar Materia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
                else
                {
                    ca.v_nombre = tex_nombre.Text;
                    ca.v_promocion = tex_promocion.Text;
                    ca.v_descripcion = tex_descripcion.Text;
                    ca.v_Dfacultad = com_facultad.SelectedItem.ToString();
                    ca.v_usuario_m = this.usuario;

                    if (che_activar_carrera.Checked == true)
                    {
                        ca.v_estado = 'A';
                    }


                    try
                    {
                        if (ca.ModificarCarrera(ca) != 0)
                        {
                            MessageBox.Show("Carrera modifacada correctamente" + "\n" + "Nombre: " + ca.v_nombre,
                            "Modificar Carrera",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                            this.inicializarDatos();
                            tex_nombre.Enabled = true;
                            tex_promocion.Enabled = true;
                            tex_descripcion.Enabled = false;
                            che_activar_carrera.Enabled = false;
                            che_activar_carrera.Checked = false;
                            ingreso = 0;

                            com_facultad.DataSource = null;
                            com_facultad.Show();
                            com_facultad.Enabled = false;
                            SLfacultad.Clear();
                            ca.v_facultad.Clear();

                            but_materia_asignar.Enabled = false;
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
                        "Modificar Carrera",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    }

                }
            }
        }

        private void tex_promocion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {

                try
                {
                    ingreso = 1;
                    ca.v_nombre = tex_nombre.Text;
                    ca.v_promocion = tex_promocion.Text;
                    ca.v_usuario_m = this.usuario;
                    if ((ca.ConsultarCarreraIA(ca)).v_nombre.Length != 0)
                    {
                        tex_nombre.Text = ca.v_nombre;
                        tex_promocion.Text = ca.v_promocion;
                        tex_descripcion.Text = ca.v_descripcion;

                        tex_nombre.Enabled = false;
                        tex_promocion.Enabled = false;
                        tex_descripcion.Enabled = true;

                        if (ca.v_estado == 'I')
                        {
                            che_activar_carrera.Enabled = true;
                            che_activar_carrera.Checked = false;

                            
                        }
                        else
                        {
                            but_materia_asignar.Enabled = true;
                        }


                        this.mostrarFacultad();
                        com_facultad.Enabled = true;
                        
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
                    "Modificar Carrera",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    ingreso = 0;
                }
            }
        }

        private void mostrarFacultad()
        {
            try
            {
                if ((ca.OptenerFacultad(ca)).v_facultad.Count != 0)
                {
                    SLfacultad = new SortedList();
                    foreach (String pais in ca.v_facultad)
                    {
                        SLfacultad.Add(pais, pais);
                    }
                    com_facultad.DataSource = SLfacultad.GetValueList();
                    com_facultad.SelectedItem = ca.v_Dfacultad;
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
                "Modificar Carrera",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private void but_materia_asignar_Click(object sender, EventArgs e)
        {
            if (this.validardatos())
            {
                if (ingreso != 1)
                {
                    MessageBox.Show("Debe ingresar el nombre y promoción, y a continuación presionar enter",
                    "Modificar Materia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
                else
                {
                    ca.v_nombre = tex_nombre.Text;
                    ca.v_promocion = tex_promocion.Text;
                    ca.v_descripcion = tex_descripcion.Text;
                    ca.v_Dfacultad = com_facultad.SelectedItem.ToString();
                    ca.v_usuario_m = this.usuario;

                    if (che_activar_carrera.Checked == true)
                    {
                        ca.v_estado = 'A';
                    }


                    try
                    {
                        this.ocultar_Pantalla();
                        frm_carrera_materia_asi FRM_CARRERA_MATERIA_ASI = new frm_carrera_materia_asi(this.usuario, ca.v_nombre, ca.v_promocion);
                        FRM_CARRERA_MATERIA_ASI.ShowDialog();
                        this.mostrar_Pantalla();
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
                        "Modificar Carrera",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    }

                }
            }
        }

        private void ocultar_Pantalla()
        {
            this.Hide();
        }

        private void mostrar_Pantalla()
        {
            this.Show();
        }

        private void com_facultad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
