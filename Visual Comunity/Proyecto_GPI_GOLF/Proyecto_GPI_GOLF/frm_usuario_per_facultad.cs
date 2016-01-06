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
    public partial class frm_usuario_per_facultad : Form
    {
        private String usuario_cargado;
        private String usuario_ingreso;
        private SortedList SLfacultad;
        StringBuilder errorMessages = new StringBuilder();
        Usuario usu = new Usuario();

        public frm_usuario_per_facultad()
        {
            InitializeComponent();
        }

        public frm_usuario_per_facultad(String usuario_ingreso, String usuario_cargado)
        {
            InitializeComponent();
            this.usuario_ingreso = usuario_ingreso;
            this.usuario_cargado = usuario_cargado;
            this.mostrarLista();
            this.consultaInicial();
        }
         
        private void frm_usuario_per_facultad_Load(object sender, EventArgs e)
        {

        }

        private void consultaInicial()
        {
            
            usu.v_usuario = this.usuario_cargado;
            try
            {

                if ((usu.ConsultarUsuarioFacultad(usu)).v_facultad_usuario.Count != 0)
                {
                   
                    dat_usuario_facultad.ColumnCount = 1;
                    dat_usuario_facultad.Columns[0].Name = "Facultad";
                    foreach (String facultades in usu.v_facultad_usuario)
                    {
                        dat_usuario_facultad.Rows.Add(facultades);
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
                "Asignar Facultad",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private void mostrarLista()
        {
            StringBuilder errorMessages = new StringBuilder();
            Usuario usu = new Usuario();
            try
            {

                if ((usu.OptenerFacultad(usu)).v_facultad.Count != 0)
                {
                    SLfacultad = new SortedList();
                    foreach (String facu in usu.v_facultad)
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
                "Asignar Facultad",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }







        private void but_agregar_Click(object sender, EventArgs e)
        {
            usu.v_usuario= this.usuario_cargado;
            usu.v_usuario_i = this.usuario_ingreso;
            usu.v_Dfacultad = com_facultad.SelectedItem.ToString();
            try
            {
                if (usu.AgregarUsuarioFacultad(usu) != 0)
                {
                    MessageBox.Show("Facultad asociada correctamente" + "\n" + "Nombre Facultad: " + usu.v_Dfacultad,
                    "Asignar Facultad",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    dat_usuario_facultad.DataSource = null;
                    dat_usuario_facultad.Rows.Clear();
                    usu.v_facultad_usuario.Clear();

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
                "Asignar Facultad",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }





        private void button1_Click(object sender, EventArgs e)
        {
            usu.v_usuario = this.usuario_cargado;
            usu.v_usuario_m = this.usuario_ingreso;
            usu.v_Dfacultad = com_facultad.SelectedItem.ToString();
            try
            {
                if (usu.EliminarUsuarioFacultad(usu) != 0)
                {
                    MessageBox.Show("Facultad desasociada correctamente" + "\n" + "Nombre Facultad: " + usu.v_Dfacultad,
                    "Asignar Facultad",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    dat_usuario_facultad.DataSource = null;
                    dat_usuario_facultad.Rows.Clear();
                    usu.v_facultad_usuario.Clear();

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
                "Asignar Facultad",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }


    }
}
