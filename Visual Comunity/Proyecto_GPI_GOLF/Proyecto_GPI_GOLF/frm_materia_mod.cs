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
    public partial class frm_materia_mod : Form
    {
        private string usuario { get; set; }
        private StringBuilder errorMessages = new StringBuilder();
        private Materia mat = new Materia();
        private SortedList SLfacultad = new SortedList();
        private int ingreso;

        public frm_materia_mod()
        {
            InitializeComponent();
        }

        public frm_materia_mod(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.inicializarDatos();
        }

        private void inicializarDatos()
        {
            tex_nombre.Text = "";
            tex_clave.Text = "";
            tex_descripcion.Text = "";
            com_facultad.Enabled = false;
        }

        public override string ToString()
        {
            return string.Format("frm_materia_mod");
        }

        private void frm_materia_mod_Load(object sender, EventArgs e)
        {

        }

        private void but_modificar_materia_Click(object sender, EventArgs e)
        {
            if (tex_nombre.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un Nombre",
                "Modificar Materia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else if (ingreso != 1)
            {
                MessageBox.Show("Debe ingresar el nombre y presionar enter",
                "Modificar Materia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                
                if (this.verificar_datos_materia()==true)
                {
                    
                    mat.v_nombre = tex_nombre.Text;
                    mat.v_clave = tex_clave.Text;
                    mat.v_descripcion = tex_descripcion.Text;
                    mat.v_Dfacultad = com_facultad.SelectedItem.ToString();
                    mat.v_usuario_m = this.usuario;
                    
                    if (che_activar_materia.Checked == true)
                    {
                        mat.v_estado = 'A';
                    }

                    
                    try
                    {
                        if (mat.ModificarMateria(mat) != 0)
                        {
                            MessageBox.Show("Materia modifacada correctamente" + "\n" + "Nombre: " + mat.v_nombre,
                            "Modificar Materia",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                            this.inicializarDatos();
                            tex_nombre.Enabled = true;
                            tex_clave.Enabled = false;
                            tex_descripcion.Enabled = false;
                            che_activar_materia.Enabled = false;
                            che_activar_materia.Checked = false;
                            ingreso = 0;

                            com_facultad.DataSource = null;
                            com_facultad.Show();
                            com_facultad.Enabled = false;
                            SLfacultad.Clear();
                            mat.v_facultad.Clear();  
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
                        "Modificar Materia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                        this.inicializarDatos();
                        tex_nombre.Enabled = true;
                        tex_clave.Enabled = false;
                        tex_descripcion.Enabled = false;
                        che_activar_materia.Enabled = false;
                        che_activar_materia.Checked = false;
                        ingreso = 0;

                        com_facultad.DataSource = null;
                        com_facultad.Show();
                        com_facultad.Enabled = false;
                        SLfacultad.Clear();
                        mat.v_facultad.Clear();  

                    }
                }
            }

        }

        private bool verificar_datos_materia()
        {
            bool error = true;

            if (tex_nombre.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un Nombre",
                "Modificar Materia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                error = false;
                return error;
            } 
                
            if (tex_clave.Text.Length == 0 )
            {
                MessageBox.Show("Debe ingresar una Clave",
                "Modificar Materia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                error = false;
                return error;
            }
            
            return error;
        }

        private void tex_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tex_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {

                try
                {
                    ingreso = 1;
                    mat.v_nombre = tex_nombre.Text;
                    mat.v_usuario_m = this.usuario;

                    if ((mat.ConsultarMateriaAI(mat)).v_nombre.Length != 0)
                    {
                        tex_nombre.Text = mat.v_nombre;
                        tex_clave.Text = mat.v_clave;
                        tex_descripcion.Text = mat.v_descripcion;

                        tex_nombre.Enabled = false;
                        tex_clave.Enabled = true;
                        tex_descripcion.Enabled = true;

                        if (mat.v_estado == 'I')
                        {
                            che_activar_materia.Enabled = true;
                            che_activar_materia.Checked = false;
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
                    "Modificar Materia",
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
                if ((mat.OptenerFacultad(mat)).v_facultad.Count != 0)
                {
                    SLfacultad = new SortedList();
                    foreach (String pais in mat.v_facultad)
                    {
                        SLfacultad.Add(pais, pais);
                    }
                    com_facultad.DataSource = SLfacultad.GetValueList();
                    com_facultad.SelectedItem = mat.v_Dfacultad;
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
                "Modificar Materia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }



    }
}
