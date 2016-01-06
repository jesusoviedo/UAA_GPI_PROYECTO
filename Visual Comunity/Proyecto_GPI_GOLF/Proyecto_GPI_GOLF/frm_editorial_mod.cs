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
    public partial class frm_editorial_mod : Form
    {
        private string usuario { get; set; }
        Editorial edi = new Editorial();
        StringBuilder errorMessages = new StringBuilder();
        public SortedList SLpais = new SortedList();
        //string seleccionado;
        int ingreso;

        public frm_editorial_mod()
        {
            InitializeComponent();
        }

        public frm_editorial_mod(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.inicializarDatos();
        }

        public override string ToString()
        {
            return string.Format("frm_editorial_mod");
        }

        private void inicializarDatos()
        {
            tex_nombre_editorial.Text = "";
            tex_direccion.Text = "";
            //seleccionado = null;
            tex_nombre_editorial.Enabled = true;
            tex_direccion.Enabled = false;
            com_pais.Enabled = false;
            //this.mostrarLista();
        }

        private void mostrarLista()
        {
            StringBuilder errorMessages = new StringBuilder();
            try
            {

                if ((edi.OptenerPais(edi)).v_pais.Count != 0)
                {
                    SLpais = new SortedList();
                    foreach (String pais in edi.v_pais)
                    {
                        SLpais.Add(pais, pais);
                    }
                    com_pais.DataSource = SLpais.GetValueList();
                    com_pais.SelectedItem = edi.v_Dpais;
                    com_pais.Show();
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
                "Modificar Editorial",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

                
            }
        }


        private void frm_editorial_mod_Load(object sender, EventArgs e)
        {

        }


         private void but_modificar_editorial_Click(object sender, EventArgs e)
         {
             if (tex_nombre_editorial.Text.Length == 0)
             {
                 MessageBox.Show("Debe ingresar un Nombre",
                 "Modificar Editorial",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
             }
             else if (ingreso != 1)
             {
                 MessageBox.Show("Debe ingresar el nombre y presionar enter",
                 "Modificar Editorial",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
             }
             else
             {
                 ///////
                 
                 {
                     StringBuilder errorMessages = new StringBuilder();
                     edi.v_nombre_editorial = tex_nombre_editorial.Text;
                     edi.v_Dpais = com_pais.SelectedItem.ToString();
                     edi.v_direccion_editorial = tex_direccion.Text;
                     edi.v_usuario_m = this.usuario;

                     if (che_activar_editorial.Checked == true)
                     {
                         edi.v_estado = 'A';
                     }

                     try
                     {
                         if (edi.ModificarEditorial(edi) != 0)
                         {
                             MessageBox.Show("Editorial modifacada correctamente" + "\n" + "Nombre: " + edi.v_nombre_editorial,
                             "Modificar Editorial",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);

                             this.inicializarDatos();

                             tex_direccion.Enabled = false;
                             tex_nombre_editorial.Enabled = true;
                             che_activar_editorial.Enabled = false;
                             che_activar_editorial.Checked = false;

                             ingreso = 0;

                             SLpais.Clear();
                             com_pais.DataSource = null;
                             com_pais.Show();
                             edi.v_pais.Clear();  
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
                         "Modificar Editorial",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Warning);
                     }
                 }
             }
         }

         private void com_pais_SelectionChangeCommitted_1(object sender, EventArgs e)
         {
             //if (tex_nombre_editorial.Text.Length == 0)
             //{
             //    MessageBox.Show("Debe ingresar un Nombre",
             //    "Modificar Editorial",
             //    MessageBoxButtons.OK,
             //    MessageBoxIcon.Warning);
             //}
             //else
             //{
             //    //try
             //    //{
             //    //    //seleccionado = "Si";
             //    //    //edi.v_nombre_editorial = tex_nombre_editorial.Text;
             //    //    //edi.v_Dpais = com_pais.SelectedItem.ToString();

             //    //    //if ((edi.ConsultarEditorialIA(edi)).v_nombre_editorial.Length != 0)
             //    //    //{
             //    //    //    tex_nombre_editorial.Text = edi.v_nombre_editorial;
             //    //    //    tex_direccion.Text = edi.v_direccion_editorial;

             //    //    //    tex_nombre_editorial.Enabled = false;
             //    //    //    tex_direccion.Enabled = true;

             //    //    //    if (edi.v_estado == 'I')
             //    //    //    {
             //    //    //        che_activar_editorial.Enabled = true;
             //    //    //        che_activar_editorial.Checked = false;
             //    //    //    }

             //    //    //}

             //    //}
             //    //catch (SqlException ex)
             //    //{
             //    //    for (int i = 0; i < ex.Errors.Count; i++)
             //    //    {
             //    //        errorMessages.Append("Index #" + i + "\n" +
             //    //        "Message: " + ex.Errors[i].Message + "\n" +
             //    //        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
             //    //        "Source: " + ex.Errors[i].Source + "\n" +
             //    //        "Procedure: " + ex.Errors[i].Procedure + "\n");
             //    //    }
             //    //    Console.WriteLine(errorMessages.ToString());
             //    //    this.inicializarDatos();
             //    //    MessageBox.Show(ex.Errors[0].Message.ToString(),
             //    //    "Modificar Editorial",
             //    //    MessageBoxButtons.OK,
             //    //    MessageBoxIcon.Warning);
             //    //}
             //}
         }

         private void tex_nombre_editorial_KeyPress(object sender, KeyPressEventArgs e)
         {

             if ((int)e.KeyChar == (int)Keys.Enter)
             {

                 try
                 {
                     ingreso = 1;
                     edi.v_nombre_editorial = tex_nombre_editorial.Text;
                     edi.v_usuario_m = this.usuario;

                     if ((edi.ConsultarEditorialIA(edi)).v_Dpais.Length != 0)
                     {
                         tex_nombre_editorial.Text = edi.v_nombre_editorial;
                         tex_direccion.Text = edi.v_direccion_editorial;

                         tex_nombre_editorial.Enabled = false;
                         tex_direccion.Enabled = true;

                         if (edi.v_estado == 'I')
                         {
                             che_activar_editorial.Enabled = true;
                             che_activar_editorial.Checked = false;
                         }

                         this.mostrarLista();
                         com_pais.Enabled = true;
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
                     "Modificar Editorial",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                     ingreso = 0;

                     
                 }
             }

         }



        
    }
}
