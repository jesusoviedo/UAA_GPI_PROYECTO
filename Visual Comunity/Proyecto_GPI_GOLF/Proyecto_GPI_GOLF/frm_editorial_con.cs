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
    public partial class frm_editorial_con : Form
    {
        private string usuario { get; set; }
        private SortedList SLpais;

        public frm_editorial_con()
        {
            InitializeComponent();
        }

        public frm_editorial_con(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.inicializarDatos();
        }

        public override string ToString()
        {
            return string.Format("frm_editorial_con");
        }

        private void frm_editorial_con_Load(object sender, EventArgs e)
        {

        }

        private void lab_nombre_Click(object sender, EventArgs e)
        {

        }

        private void but_consultar_editorial_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessages = new StringBuilder();
            Editorial edi = new Editorial();
            if (tex_nombre_editorial.Text.Length == 0)
            {
                this.inicializarDatos();
                MessageBox.Show("Debe ingresar un Nombre",
                "Consultar Editorial",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    edi.v_nombre_editorial = tex_nombre_editorial.Text;
                    //edi.v_Dpais= com_pais.SelectedItem.ToString();
                    if ((edi.ConsultarEditorial(edi)).v_nombre_editorial.Length != 0)
                    {
                        tex_nombre_editorial.Text = edi.v_nombre_editorial;
                        tex_direccion.Text = edi.v_direccion_editorial;

                        SLpais = new SortedList();
                        SLpais.Add(edi.v_Dpais, edi.v_Dpais);
                        com_pais.DataSource = SLpais.GetValueList();
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

                    this.inicializarDatos();

                    SLpais.Clear();
                    com_pais.DataSource = null;
                    com_pais.Show();

                    MessageBox.Show(ex.Errors[0].Message.ToString(),
                    "Consultar Editorial",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }

            }
        }

        private void inicializarDatos()
        {
            tex_nombre_editorial.Text = "";
            tex_direccion.Text = "";
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
        //        "Consultar Editorial",
        //        MessageBoxButtons.OK,
        //        MessageBoxIcon.Warning);
        //    }
        //}

        private void tex_direccion_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
