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
    public partial class frm_bibliografia_sol : Form
    {
        private string usuario { get; set; }
        private SortedList SLmateria, SLsemestre;
        private bool Clicbut_libro_asignar = false;
        StringBuilder errorMessages = new StringBuilder();
        Bibliografia bi = new Bibliografia();

        public frm_bibliografia_sol()
        {
            InitializeComponent();
        }

        public frm_bibliografia_sol(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            Clicbut_libro_asignar = false;
            this.inicializarDatos();
        }

        public override string ToString()
        {
            return string.Format("frm_bibliografia_sol");
        }

        private void frm_bibliografia_sol_Load(object sender, EventArgs e)
        {

        }

        private void ocultar_Pantalla()
        {
            this.Hide();
        }

        private void mostrar_Pantalla()
        {
            this.Show();
        }

        private void inicializarDatos()
        {
            tex_año.Text = "";
            tex_descripcion.Text = "";
            this.mostrarLista();
        }

        private void mostrarLista()
        {
            
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
                "Solicitar Bibliografía",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private void but_solicitar_bibliografia_Click(object sender, EventArgs e)
        {
            if (this.validar_datos() && this.validar_datos_2())
            {
                bi.v_DnombreMateria = com_materia.SelectedItem.ToString();
                bi.v_año = Convert.ToInt32(tex_año.Text);
                bi.v_Dsemestre = com_semestre.SelectedItem.ToString();
                bi.v_usuario_i = this.usuario;
                bi.v_descripcion = tex_descripcion.Text;

                try
                {
                    if (bi.SolicitarBibliografiaS(bi) != 0)
                    {
                        tex_año.Text = "";
                        tex_descripcion.Text = "";

                        MessageBox.Show("Bibliografía solicitada correctamente" + "\n" + "Nombre Materia: " + bi.v_DnombreMateria,
                        "Solicitar Bibliografía",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
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
                    "Solicitar Bibliografía",
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
                "Solicitar Bibliografía",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                error = false;
            } else if (tex_año.Text.Length != 0)
            {
                try
                {
                    año = Convert.ToInt32(tex_año.Text);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Debe ingresar una Año valida",
                    "Solicitar Bibliografía",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    error = false;

                    Console.WriteLine(e.Message.ToString());
                }
            }
            return error;
        }

        private bool validar_datos_2()
        {
            bool error = true;

            if (Clicbut_libro_asignar == false)
            {
                MessageBox.Show("Debe Asignar libros a la materia",
                "Solicitar Bibliografía",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                error = false;
            }
            return error;
        }

        private void but_libro_asignar_Click(object sender, EventArgs e)
        {

            if (this.validar_datos())
            {

                try
                {
                    bi.v_DnombreMateria = com_materia.SelectedItem.ToString();
                    bi.v_año = Convert.ToInt32(tex_año.Text);
                    bi.v_Dsemestre = com_semestre.SelectedItem.ToString();
                    bi.v_descripcion = tex_descripcion.Text;
                    bi.v_usuario_i = this.usuario;

                    if (bi.VerificarBibliografia(bi) != 0)
                    {
                        Clicbut_libro_asignar = true;

                        this.ocultar_Pantalla();

                        frm_bibliografia_libro_asi FRM_BIBLIOGRAFIA_LIBRO_ASI = new frm_bibliografia_libro_asi(
                            this.usuario,
                            bi.v_DnombreMateria,
                            bi.v_año,
                            bi.v_Dsemestre,
                            bi.v_descripcion);

                        FRM_BIBLIOGRAFIA_LIBRO_ASI.ShowDialog();

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

                    tex_año.Text = "";
                    tex_descripcion.Text = "";
                    Clicbut_libro_asignar = false;

                    MessageBox.Show(ex.Errors[0].Message.ToString(),
                    "Solicitar Bibliografía",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
        }

        private void frm_bibliografia_sol_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            
            bi.v_DnombreMateria = com_materia.SelectedItem.ToString();
            //bi.v_año = Convert.ToInt32(tex_año.Text);
            bi.v_Dsemestre = com_semestre.SelectedItem.ToString();
            bi.v_usuario_i = this.usuario;

            try
            {
                if (bi.EliminarBibliografiaP(bi) != 0)
                {
                    
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
                "Solicitar Bibliografía",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }

        }

    }
}
