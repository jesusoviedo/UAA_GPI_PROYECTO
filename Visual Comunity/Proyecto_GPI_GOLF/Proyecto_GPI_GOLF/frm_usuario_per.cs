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
    public partial class frm_usuario_per : Form
    {
        private string usuario { get; set; }
        public ArrayList pantalla = new ArrayList();
        public ArrayList estado = new ArrayList();

        public frm_usuario_per()
        {
            InitializeComponent();
        }

        public frm_usuario_per(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void frm_usuario_per_Load(object sender, EventArgs e)
        {

        }

        public override string ToString()
        {
            return string.Format("frm_usuario_per");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gro_pernisos_Enter(object sender, EventArgs e)
        {

        }

        private void but_consultar_Click(object sender, EventArgs e)
        {
            this.DesactivarChec();
            if (tex_usuario.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un Usuario",
                "Permisos de Usuarios",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                StringBuilder errorMessages = new StringBuilder();
                Usuario user = new Usuario();
                user.v_usuario = tex_usuario.Text;
                try
                {

                    if ((user.ConsultarPermiso(user)).v_pantalla.Count != 0)
                    {
                        foreach (String v_nom_pantalla in user.v_pantalla)
                        {
                            this.VerificarChec(v_nom_pantalla);
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
                    "Permisos de Usuarios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
        }

        private void DesactivarChec() {
            che_frm_menu_pri.Checked = false;
            che_frm_usuario_per.Checked = false;

            che_frm_persona_agr.Checked = false;
            che_frm_persona_eli.Checked = false;
            che_frm_persona_mod.Checked = false;
            che_frm_persona_con.Checked = false;

            che_frm_editorial_agr.Checked = false;
            che_frm_editorial_eli.Checked = false;
            che_frm_editorial_mod.Checked = false;
            che_frm_editorial_con.Checked = false;

            che_frm_libro_agr.Checked = false;
            che_frm_libro_eli.Checked = false;
            che_frm_libro_mod.Checked = false;
            che_frm_libro_con.Checked = false;

            che_frm_materia_agr.Checked = false;
            che_frm_materia_eli.Checked = false;
            che_frm_materia_mod.Checked = false;
            che_frm_materia_con.Checked = false;

            che_frm_carrera_agr.Checked = false;
            che_frm_carrera_eli.Checked = false;
            che_frm_carrera_mod.Checked = false;
            che_frm_carrera_con.Checked = false;


            che_frm_bibliografia_sol.Checked = false;
            che_frm_bibliografia_con.Checked = false;
            che_frm_bibliografia_aut.Checked = false;

        }

        private void CrearArrayListPantalla()
        {
            pantalla.Clear();
            estado.Clear();

            pantalla.Add(che_frm_menu_pri.Text.ToUpper());
            estado.Add((che_frm_menu_pri.Checked == true) ? 'A' : 'I');

            pantalla.Add(che_frm_usuario_per.Text.ToUpper());
            estado.Add((che_frm_usuario_per.Checked == true) ? 'A' : 'I');



            pantalla.Add(che_frm_persona_agr.Text.ToUpper());
            estado.Add((che_frm_persona_agr.Checked == true) ? 'A' : 'I');

            pantalla.Add(che_frm_persona_eli.Text.ToUpper());
            estado.Add((che_frm_persona_eli.Checked == true) ? 'A' : 'I');

            pantalla.Add(che_frm_persona_mod.Text.ToUpper());
            estado.Add((che_frm_persona_mod.Checked == true) ? 'A' : 'I');

            pantalla.Add(che_frm_persona_con.Text.ToUpper());
            estado.Add((che_frm_persona_con.Checked == true) ? 'A' : 'I');



            pantalla.Add(che_frm_editorial_agr.Text.ToUpper());
            estado.Add((che_frm_editorial_agr.Checked == true) ? 'A' : 'I');

            pantalla.Add(che_frm_editorial_eli.Text.ToUpper());
            estado.Add((che_frm_editorial_eli.Checked == true) ? 'A' : 'I');

            pantalla.Add(che_frm_editorial_mod.Text.ToUpper());
            estado.Add((che_frm_editorial_mod.Checked == true) ? 'A' : 'I');

            pantalla.Add(che_frm_editorial_con.Text.ToUpper());
            estado.Add((che_frm_editorial_con.Checked == true) ? 'A' : 'I');



            pantalla.Add(che_frm_libro_agr.Text.ToUpper());
            estado.Add((che_frm_libro_agr.Checked == true) ? 'A' : 'I');

            pantalla.Add(che_frm_libro_eli.Text.ToUpper());
            estado.Add((che_frm_libro_eli.Checked == true) ? 'A' : 'I');

            pantalla.Add(che_frm_libro_mod.Text.ToUpper());
            estado.Add((che_frm_libro_mod.Checked == true) ? 'A' : 'I');

            pantalla.Add(che_frm_libro_con.Text.ToUpper());
            estado.Add((che_frm_libro_con.Checked == true) ? 'A' : 'I');



            pantalla.Add(che_frm_materia_agr.Text.ToUpper());
            estado.Add((che_frm_materia_agr.Checked == true) ? 'A' : 'I');

            pantalla.Add(che_frm_materia_eli.Text.ToUpper());
            estado.Add((che_frm_materia_eli.Checked == true) ? 'A' : 'I');

            pantalla.Add(che_frm_materia_mod.Text.ToUpper());
            estado.Add((che_frm_materia_mod.Checked == true) ? 'A' : 'I');

            pantalla.Add(che_frm_materia_con.Text.ToUpper());
            estado.Add((che_frm_materia_con.Checked == true) ? 'A' : 'I');



            pantalla.Add(che_frm_carrera_agr.Text.ToUpper());
            estado.Add((che_frm_carrera_agr.Checked == true) ? 'A' : 'I');

            pantalla.Add(che_frm_carrera_eli.Text.ToUpper());
            estado.Add((che_frm_carrera_eli.Checked == true) ? 'A' : 'I');

            pantalla.Add(che_frm_carrera_mod.Text.ToUpper());
            estado.Add((che_frm_carrera_mod.Checked == true) ? 'A' : 'I');

            pantalla.Add(che_frm_carrera_con.Text.ToUpper());
            estado.Add((che_frm_carrera_con.Checked == true) ? 'A' : 'I');


            pantalla.Add(che_frm_bibliografia_sol.Text.ToUpper());
            estado.Add((che_frm_bibliografia_sol.Checked == true) ? 'A' : 'I');

            pantalla.Add(che_frm_bibliografia_con.Text.ToUpper());
            estado.Add((che_frm_bibliografia_con.Checked == true) ? 'A' : 'I');

            pantalla.Add(che_frm_bibliografia_aut.Text.ToUpper());
            estado.Add((che_frm_bibliografia_aut.Checked == true) ? 'A' : 'I');

        }

        private void VerificarChec(String v_nom_pantalla)
        {

            if (v_nom_pantalla == che_frm_menu_pri.Text.ToUpper())
            {
                che_frm_menu_pri.Checked = true;
            }
                  
            if (v_nom_pantalla == che_frm_usuario_per.Text.ToUpper())
            {
               che_frm_usuario_per.Checked = true;
            }





            if (v_nom_pantalla == che_frm_persona_agr.Text.ToUpper())
            {
                che_frm_persona_agr.Checked = true;
            }

            if (v_nom_pantalla == che_frm_persona_eli.Text.ToUpper())
            {
                che_frm_persona_eli.Checked = true;
            }
                           
            if (v_nom_pantalla == che_frm_persona_mod.Text.ToUpper())
            {
                che_frm_persona_mod.Checked = true;
            }
            
            if (v_nom_pantalla == che_frm_persona_con.Text.ToUpper())
            {
                che_frm_persona_con.Checked = true;
            }



            if (v_nom_pantalla == che_frm_editorial_agr.Text.ToUpper())
            {
                che_frm_editorial_agr.Checked = true;
            }

            if (v_nom_pantalla == che_frm_editorial_eli.Text.ToUpper())
            {
                che_frm_editorial_eli.Checked = true;
            }

            if (v_nom_pantalla == che_frm_editorial_mod.Text.ToUpper())
            {
                che_frm_editorial_mod.Checked = true;
            }

            if (v_nom_pantalla == che_frm_editorial_con.Text.ToUpper())
            {
                che_frm_editorial_con.Checked = true;
            }



            if (v_nom_pantalla == che_frm_libro_agr.Text.ToUpper())
            {
                che_frm_libro_agr.Checked = true;
            }

            if (v_nom_pantalla == che_frm_libro_eli.Text.ToUpper())
            {
                che_frm_libro_eli.Checked = true;
            }

            if (v_nom_pantalla == che_frm_libro_mod.Text.ToUpper())
            {
                che_frm_libro_mod.Checked = true;
            }

            if (v_nom_pantalla == che_frm_libro_con.Text.ToUpper())
            {
                che_frm_libro_con.Checked = true;
            }




            if (v_nom_pantalla == che_frm_materia_agr.Text.ToUpper())
            {
                che_frm_materia_agr.Checked = true;
            }

            if (v_nom_pantalla == che_frm_materia_eli.Text.ToUpper())
            {
                che_frm_materia_eli.Checked = true;
            }

            if (v_nom_pantalla == che_frm_materia_mod.Text.ToUpper())
            {
                che_frm_materia_mod.Checked = true;
            }

            if (v_nom_pantalla == che_frm_materia_con.Text.ToUpper())
            {
                che_frm_materia_con.Checked = true;
            }




            if (v_nom_pantalla == che_frm_carrera_agr.Text.ToUpper())
            {
                che_frm_carrera_agr.Checked = true;
            }

            if (v_nom_pantalla == che_frm_carrera_eli.Text.ToUpper())
            {
                che_frm_carrera_eli.Checked = true;
            }

            if (v_nom_pantalla == che_frm_carrera_mod.Text.ToUpper())
            {
                che_frm_carrera_mod.Checked = true;
            }

            if (v_nom_pantalla == che_frm_carrera_con.Text.ToUpper())
            {
                che_frm_carrera_con.Checked = true;
            }



            if (v_nom_pantalla == che_frm_bibliografia_sol.Text.ToUpper())
            {
                che_frm_bibliografia_sol.Checked = true;
            }

            if (v_nom_pantalla == che_frm_bibliografia_con.Text.ToUpper())
            {
                che_frm_bibliografia_con.Checked = true;
            }

            if (v_nom_pantalla == che_frm_bibliografia_aut.Text.ToUpper())
            {
                che_frm_bibliografia_aut.Checked = true;
            }

        }

        private void but_actualizar_Click(object sender, EventArgs e)
        {
            if (tex_usuario.Text.Length == 0)
            {
                this.DesactivarChec();

                MessageBox.Show("Debe ingresar un Usuario",
                "Permisos de Usuarios",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                StringBuilder errorMessages = new StringBuilder();
                Usuario user = new Usuario();
                user.v_usuario = tex_usuario.Text;
                try
                {
                    this.CrearArrayListPantalla();
                    for (int i = 0; i < pantalla.Count; i++)
                    {
                        user.v_estado = Convert.ToChar(estado[i]);
                        user.ActualizarPermiso(user, Convert.ToString(pantalla[i]));
                    }

                    MessageBox.Show("Actualización realizada correctamente",
                    "Permisos de Usuarios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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

                    this.DesactivarChec();

                    MessageBox.Show(ex.Errors[0].Message.ToString(),
                    "Permisos de Usuarios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void che_frm_editorial_con_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void but_permiso_facultad_Click(object sender, EventArgs e)
        {
            this.DesactivarChec();
            if (tex_usuario.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un Usuario",
                "Permisos de Usuarios",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                StringBuilder errorMessages = new StringBuilder();
                Usuario user = new Usuario();
                user.v_usuario = tex_usuario.Text;
                try
                {

                    if ((user.ConsultarPermiso(user)).v_pantalla.Count != 0)
                    {
                        foreach (String v_nom_pantalla in user.v_pantalla)
                        {
                            this.VerificarChec(v_nom_pantalla);
                        }

                        this.ocultar_Pantalla();
                        frm_usuario_per_facultad FRM_USUARIO_PER_FACULTAD = new frm_usuario_per_facultad(this.usuario,tex_usuario.Text);
                        FRM_USUARIO_PER_FACULTAD.ShowDialog();
                        this.mostrar_Pantalla();
                        this.DesactivarChec();
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
                    "Permisos de Usuarios",
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
