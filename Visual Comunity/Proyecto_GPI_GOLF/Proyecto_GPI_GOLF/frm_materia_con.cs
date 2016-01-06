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
    public partial class frm_materia_con : Form
    {
        private string usuario { get; set; }
        private SortedList SLfacultad =new SortedList();

        public frm_materia_con()
        {
            InitializeComponent();
        }

        public frm_materia_con(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.inicializarDatos();
        }

        public override string ToString()
        {
            return string.Format("frm_materia_con");
        }

        private void frm_materia_con_Load(object sender, EventArgs e)
        {

        }

        private void inicializarDatos()
        {
            tex_nombre.Text = "";
            tex_clave.Text = "";
            tex_descripcion.Text = "";
            com_facultad.DataSource = null;
            com_facultad.Enabled = false;
            com_facultad.Show();
        }


        private void but_consultar_materia_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessages = new StringBuilder();
            Materia mat = new Materia();
            if (tex_nombre.Text.Length == 0)
            {
                this.inicializarDatos();
                MessageBox.Show("Debe ingresar un Nombre",
                "Consultar Materia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    mat.v_nombre = tex_nombre.Text;
                    if ((mat.ConsultarMateria(mat)).v_nombre.Length != 0)
                    {
                        tex_nombre.Text = mat.v_nombre;
                        tex_clave.Text = mat.v_clave;
                        tex_descripcion.Text = mat.v_descripcion;
                        
                        SLfacultad.Add(mat.v_Dfacultad, mat.v_Dfacultad);
                        com_facultad.DataSource = SLfacultad.GetValueList();
                        com_facultad.Show();
                        com_facultad.Enabled = false;
                        SLfacultad.Clear();                       
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
                    "Consultar Materia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }

            }

        }
    }
}
