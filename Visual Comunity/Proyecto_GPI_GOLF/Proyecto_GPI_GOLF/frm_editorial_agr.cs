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
    public partial class frm_editorial_agr : Form
    {
        private string usuario { get; set; }
        private SortedList SLpais;

        public frm_editorial_agr()
        {
            InitializeComponent();
        }

        public frm_editorial_agr(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.inicializarDatos();
        }

        public override string ToString()
        {
            return string.Format("frm_editorial_agr");
        }

        private void frm_editorial_agr_Load(object sender, EventArgs e)
        {

        }

        private void mostrarLista()
        {
            StringBuilder errorMessages = new StringBuilder();
            Editorial edi = new Editorial();
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
                "Agregar Editorial",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private bool verificar_datos_editorial()
        {
            bool error = true;

            if (tex_nombre_editorial.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un Nombre",
                "Agregar Editorial",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                error = false;
            }
         
            return error;
        }

        private void inicializarDatos()
        {
            tex_nombre_editorial.Text = "";
            tex_direccion.Text = "";
            this.mostrarLista();
        }

        private void but_agregar_editorial_Click(object sender, EventArgs e)
        {
            if (this.verificar_datos_editorial())
            {

                if (tex_direccion.Text.Length == 0)
                {
                    tex_direccion.Text = "";
                }

                StringBuilder errorMessages = new StringBuilder();
                Editorial edi = new Editorial();

                edi.v_nombre_editorial = tex_nombre_editorial.Text;
                edi.v_Dpais = com_pais.SelectedItem.ToString();
                edi.v_direccion_editorial = tex_direccion.Text;               
                edi.v_usuario_i = this.usuario;

                try
                {
                    if (edi.AgregarEditorial(edi) != 0)
                    {
                        MessageBox.Show("Editorial creada correctamente" + "\n" +"Nombre: " + edi.v_nombre_editorial,
                        "Agregar Editorial",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        this.inicializarDatos();
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
                    "Agregar Editorial",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
        }
    }
}
