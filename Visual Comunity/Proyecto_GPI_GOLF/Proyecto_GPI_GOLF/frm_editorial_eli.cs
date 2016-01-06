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
    public partial class frm_editorial_eli : Form
    {
        private string usuario { get; set; }
        private SortedList SLpais;

        public frm_editorial_eli()
        {
            InitializeComponent();
        }

        public frm_editorial_eli(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.inicializarDatos();

        }

        public override string ToString()
        {
            return string.Format("frm_editorial_eli");
        }

        private void frm_editorial_eli_Load(object sender, EventArgs e)
        {

        }

        private void inicializarDatos()
        {
            tex_nombre_editorial.Text = "";
            tex_direccion.Text = "";
            com_pais.Enabled = false;
            //this.mostrarLista();
        }

        //private void mostrarLista()
        //{
        //    StringBuilder errorMessages = new StringBuilder();
        //    Editorial edi = new Editorial();
        //    try
        //    {

        //        if ((edi.OptenerPais(edi)).v_pais.Count != 0)
        //        {
        //            SLpais = new SortedList();
        //            foreach (String pais in edi.v_pais)
        //            {
        //                SLpais.Add(pais, pais);
        //            }
        //            com_pais.DataSource = SLpais.GetValueList();
        //            com_pais.Show();
        //        }


        //    }
        //    catch (SqlException ex)
        //    {
        //        for (int i = 0; i < ex.Errors.Count; i++)
        //        {
        //            errorMessages.Append("Index #" + i + "\n" +
        //            "Message: " + ex.Errors[i].Message + "\n" +
        //            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
        //            "Source: " + ex.Errors[i].Source + "\n" +
        //            "Procedure: " + ex.Errors[i].Procedure + "\n");
        //        }
        //        Console.WriteLine(errorMessages.ToString());

        //        MessageBox.Show(ex.Errors[0].Message.ToString(),
        //        "Eliminar Editorial",
        //        MessageBoxButtons.OK,
        //        MessageBoxIcon.Warning);
        //    }
        //}

     
         private void but_eliminar_persona_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessages = new StringBuilder();
            Editorial edi = new Editorial();
            if (tex_nombre_editorial.Text.Length == 0)
            {
                this.inicializarDatos();
                MessageBox.Show("Debe ingresar un Nombre",
                "Eliminar Editorial",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    edi.v_nombre_editorial = tex_nombre_editorial.Text;
                    //edi.v_Dpais = com_pais.SelectedItem.ToString();
                    edi.v_usuario_m = this.usuario;
                    if ((edi.ConsultarEditorial(edi)).v_nombre_editorial.Length != 0)
                    {
                        tex_nombre_editorial.Text = edi.v_nombre_editorial;
                        tex_direccion.Text = edi.v_direccion_editorial;

                        SLpais = new SortedList();
                        SLpais.Add(edi.v_Dpais, edi.v_Dpais);
                        com_pais.DataSource = SLpais.GetValueList();
                        com_pais.Show();
                        com_pais.Enabled = false;


                        if ((MessageBox.Show("¿Desea eliminar la Editorial con Nombre: " + edi.v_nombre_editorial + " ?", "Eliminar Editorial", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {

                            try
                            {
                                if (edi.EliminarEditorial(edi) != 0)
                                {

                                    SLpais.Clear();
                                    com_pais.DataSource = null;
                                    com_pais.Show();

                                    this.inicializarDatos();
                                    MessageBox.Show("Editorial eliminada correctamente",
                                    "Eliminar Editorial",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                                    
                                }

                            }
                            catch (SqlException ex)
                            {
                                for (int i = 0; i < ex.Errors.Count; i++)
                                {

                                    SLpais.Clear();
                                    com_pais.DataSource = null;
                                    com_pais.Show();

                                    errorMessages.Append("Index #" + i + "\n" +
                                    "Message: " + ex.Errors[i].Message + "\n" +
                                    "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                                    "Source: " + ex.Errors[i].Source + "\n" +
                                    "Procedure: " + ex.Errors[i].Procedure + "\n");
                                }
                                Console.WriteLine(errorMessages.ToString());
                                this.inicializarDatos();
                                MessageBox.Show(ex.Errors[0].Message.ToString(),
                                    "Eliminar Editorial",
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

                    SLpais.Clear();
                    com_pais.DataSource = null;
                    com_pais.Show();

                    Console.WriteLine(errorMessages.ToString());
                    this.inicializarDatos();
                    MessageBox.Show(ex.Errors[0].Message.ToString(),
                    "Eliminar Editorial",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                    
                }

            }
        }

         private void com_pais_KeyPress(object sender, KeyPressEventArgs e)
         {


         }
    }
}
