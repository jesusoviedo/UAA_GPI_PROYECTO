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
    public partial class frm_carrera_con : Form
    {
        private string usuario { get; set; }
        private SortedList SLfacultad = new SortedList();

        public frm_carrera_con()
        {
            InitializeComponent();
        }

        public frm_carrera_con(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.inicializarDatos();
            but_materia_consultar.Enabled = false;
        }

        public override string ToString()
        {
            return string.Format("frm_carrera_con");
        }

        private void frm_carrera_con_Load(object sender, EventArgs e)
        {

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

        private bool validardatos (){
            bool error = true;

            if (tex_nombre.Text.Length == 0)
            {

                MessageBox.Show("Debe ingresar un Nombre",
                "Consultar Carrera",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

                error = false;
            }
            else if (tex_promocion.Text.Length == 0)
            {

                MessageBox.Show("Debe ingresar una Promoción",
                "Consultar Carrera",
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
                    "Consultar Carrera",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    error = false;

                    Console.WriteLine(ex.Message.ToString());
                }
            }

            return error;
        }

        private void but_consultar_carrera_Click(object sender, EventArgs e)
        {
            
            
            if (this.validardatos())
            {
                StringBuilder errorMessages = new StringBuilder();
                Carrera ca = new Carrera();
                try
                {
                    
                    ca.v_nombre = tex_nombre.Text;
                    ca.v_promocion = tex_promocion.Text;
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

                        but_materia_consultar.Enabled = true;
                        
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

                    but_materia_consultar.Enabled = false;

                    MessageBox.Show(ex.Errors[0].Message.ToString(),
                    "Consultar Carrera",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }

            }
        }

        private void but_materia_consultar_Click(object sender, EventArgs e)
        {
            if (this.validardatos())
            {
                StringBuilder errorMessages = new StringBuilder();
                Carrera ca = new Carrera();
                try
                {

                    ca.v_nombre = tex_nombre.Text;
                    ca.v_promocion = tex_promocion.Text;
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

                        this.ocultar_Pantalla();
                        frm_carrera_materia_con FRM_CARRERA_MATERIA_CON = new frm_carrera_materia_con(this.usuario, ca.v_nombre, ca.v_promocion);
                        FRM_CARRERA_MATERIA_CON.ShowDialog();
                        this.mostrar_Pantalla();
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
                    "Consultar Carrera",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
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
    }
}
