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
    public partial class frm_bibliografia_con : Form
    {
        private string usuario { get; set; }
        private SortedList SLmateria,SLsemestre;
        StringBuilder errorMessages = new StringBuilder();
        Bibliografia bi = new Bibliografia();

        public frm_bibliografia_con()
        {
            InitializeComponent();
            
        }



        public frm_bibliografia_con(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.inicializarDatos();
        }



        public override string ToString()
        {
            return string.Format("frm_bibliografia_con");
        }



        private void frm_bibliografia_con_Load(object sender, EventArgs e)
        {

        }




        private void inicializarDatos()
        {
            tex_año.Text = "";
            tex_descripcion.Text = "";
            tex_descripcion.Text = "";
            tex_estado.Text = "";
            tex_solicitante.Text = "";
            tex_autorizador.Text = "";
            tex_inactivador.Text = "";
            but_libro_consultar.Enabled = false;
            this.mostrarLista();
        }



        private void mostrarLista()
        {
            StringBuilder errorMessages = new StringBuilder();
            Bibliografia bi = new Bibliografia();
            try
            {

                if ((bi.OptenerMateria(bi)).v_materia.Count != 0)
                {
                    SLmateria = new SortedList();
                    foreach (String materia in bi.v_materia)
                    {
                        SLmateria.Add(materia, materia);
                    }
                    com_materia.DataSource = SLmateria.GetValueList();
                    com_materia.Show();
                }

                if ((bi.OptenerSemestre(bi)).v_semestre.Count != 0)
                {
                    SLsemestre = new SortedList();
                    foreach (String semestre in bi.v_semestre)
                    {
                        SLsemestre.Add(semestre, semestre);
                    }
                    com_semestre.DataSource = SLsemestre.GetValueList();
                    com_semestre.Show();
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
                "Consultar Bibliografía",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }



        private void but_consultar_bibliografia_Click(object sender, EventArgs e)
        {
            if (this.validar_datos())
            {
                
                bi.v_DnombreMateria = com_materia.SelectedItem.ToString();
                bi.v_año = Convert.ToInt32(tex_año.Text);
                bi.v_Dsemestre = com_semestre.SelectedItem.ToString();

                try
                {
                    if ((bi.ConsultarBibliografiaSAI(bi)).v_DnombreMateria.Length != 0)
                    {
                        tex_descripcion.Text = bi.v_descripcion;

                        if (bi.v_estado == 'S')
                        {
                            tex_estado.Text = "SOLICITADO";
                        } 
                        else if (bi.v_estado == 'A')
                        {
                            tex_estado.Text = "AUTORIZADO";
                        }
                        else if (bi.v_estado == 'I')
                        {
                            tex_estado.Text = "INACTIVO";
                        }

                        tex_solicitante.Text = bi.v_usuario_so;
                        tex_autorizador.Text = bi.v_usuario_au;
                        tex_inactivador.Text = bi.v_usuario_in;

                        but_libro_consultar.Enabled = true;

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
                    "Consultar Bibliografía",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
        }



        private bool validar_datos()
        {
            bool error = true;
            int año;

            if (tex_año.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un Año",
                "Consultar Bibliografía",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                error = false;
            }
            else if (tex_año.Text.Length != 0)
            {
                try
                {
                    año = Convert.ToInt32(tex_año.Text);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Debe ingresar una Año valida",
                    "Consultar Bibliografía",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    error = false;

                    Console.WriteLine(e.Message.ToString());
                }
            }

            return error;

        }



        private void but_libro_consultar_Click(object sender, EventArgs e)
        {
            if (this.validar_datos())
            {
                bi.v_DnombreMateria = com_materia.SelectedItem.ToString();
                bi.v_año = Convert.ToInt32(tex_año.Text);
                bi.v_Dsemestre = com_semestre.SelectedItem.ToString();
                bi.v_descripcion = tex_descripcion.Text;

                    this.ocultar_Pantalla();

                    frm_bibliografia_libro_con FRM_BIBLIOGRAFIA_LIBRO_CON = new frm_bibliografia_libro_con(
                        bi.v_usuario_so,
                        bi.v_DnombreMateria,
                        bi.v_año,
                        bi.v_Dsemestre,
                        bi.v_descripcion);

                    FRM_BIBLIOGRAFIA_LIBRO_CON.ShowDialog();

                    this.mostrar_Pantalla();

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
