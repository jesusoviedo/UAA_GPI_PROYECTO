using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usuario_logica;

namespace Proyecto_GPI_GOLF
{
    public partial class frm_menu_pri : Form
    {
        private string usuario {get; set;}
        private string manual_dir = "C:\\Manual de Usuario.pdf";

        public frm_menu_pri()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            return string.Format("frm_menu_pri");
        }

        private void F_MENU_PRINCIPAL_Load(object sender, EventArgs e)
        {

        }

        public frm_menu_pri(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void ocultar_Pantalla()
        {
            this.Hide();
        }

        private void mostrar_Pantalla()
        {
            this.Show();
        }

        private void sub_men_persona_agr_Click(object sender, EventArgs e)
        {
            this.ocultar_Pantalla();
            StringBuilder errorMessages = new StringBuilder();
            Usuario user = new Usuario();
            user.v_usuario = this.usuario;
            frm_persona_agr FRM_PERSONA_AGR = new frm_persona_agr(this.usuario);
            try
            {
                if (user.VerificarPermiso(user, FRM_PERSONA_AGR.ToString()) != 0)
                {
                    FRM_PERSONA_AGR.ShowDialog();
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
                "Agregar Persona",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                FRM_PERSONA_AGR.Close();
            }
            this.mostrar_Pantalla();
        }

        private void sub_men_persona_mod_Click(object sender, EventArgs e)
        {
            this.ocultar_Pantalla();
            StringBuilder errorMessages = new StringBuilder();
            Usuario user = new Usuario();
            user.v_usuario = this.usuario;
            frm_persona_mod FRM_PERSONA_MOD = new frm_persona_mod(this.usuario);
            try
            {
                if (user.VerificarPermiso(user,FRM_PERSONA_MOD.ToString()) != 0)
                {
                    FRM_PERSONA_MOD.ShowDialog();
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
                "Modificar Persona",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                FRM_PERSONA_MOD.Close();
            }
            this.mostrar_Pantalla();
        }

        private void sub_men_persona_con_Click(object sender, EventArgs e)
        {
            this.ocultar_Pantalla();
            StringBuilder errorMessages = new StringBuilder();
            Usuario user = new Usuario();
            user.v_usuario = this.usuario;
            frm_persona_con FRM_PERSONA_CON = new frm_persona_con(this.usuario);
            try
            {
                if (user.VerificarPermiso(user, FRM_PERSONA_CON.ToString()) != 0)
                {
                    FRM_PERSONA_CON.ShowDialog();
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
                "Consultar Persona",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                FRM_PERSONA_CON.Close();
            }
            this.mostrar_Pantalla();
        }

        private void sub_men_persona_eli_Click(object sender, EventArgs e)
        {
            this.ocultar_Pantalla();
            StringBuilder errorMessages = new StringBuilder();
            Usuario user = new Usuario();
            user.v_usuario = this.usuario;
            frm_persona_eli FRM_PERSONA_ELI = new frm_persona_eli(this.usuario);
            try
            {
                if (user.VerificarPermiso(user, FRM_PERSONA_ELI.ToString()) != 0)
                {
                    FRM_PERSONA_ELI.ShowDialog();
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
                "Eliminar Persona",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                FRM_PERSONA_ELI.Close();
            }
            this.mostrar_Pantalla();
        }
        

        private void sub_men_usuario_cam_cla_Click(object sender, EventArgs e)
        {
            this.ocultar_Pantalla();
            frm_usuario_cam_cla FRM_USUARIO_CAM_CLA = new frm_usuario_cam_cla(this.usuario);
            FRM_USUARIO_CAM_CLA.ShowDialog();
            this.mostrar_Pantalla();
        }

        private void sub_men_usuario_per_Click(object sender, EventArgs e)
        {
            this.ocultar_Pantalla();
            StringBuilder errorMessages = new StringBuilder();
            Usuario user = new Usuario();
            user.v_usuario = this.usuario;
            frm_usuario_per FRM_USUARIO_PER = new frm_usuario_per(this.usuario);
            try
            {
                if (user.VerificarPermiso(user, FRM_USUARIO_PER.ToString()) != 0)
                {
                    FRM_USUARIO_PER.ShowDialog();
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
                "Permiso Usuario",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                FRM_USUARIO_PER.Close();
            }
            this.mostrar_Pantalla();
        }

        //private void men_cerrar_sesion_Click(object sender, EventArgs e)
        //{
        //    if ((
        //        MessageBox.Show("¿Desea cerrar su sesión?",
        //        "Cerrar Sesión",
        //        MessageBoxButtons.YesNo,
        //        MessageBoxIcon.Question) == DialogResult.Yes))
        //    {
        //        this.Close();
        //    }
        //}



        private void sub_men_carrera_agr_Click(object sender, EventArgs e)
        {
            this.ocultar_Pantalla();
            StringBuilder errorMessages = new StringBuilder();
            Usuario user = new Usuario();
            user.v_usuario = this.usuario;
            frm_carrera_agr FRM_CARRERA_AGR = new frm_carrera_agr(this.usuario);
            try
            {
                if (user.VerificarPermiso(user, FRM_CARRERA_AGR.ToString()) != 0)
                {
                    FRM_CARRERA_AGR.ShowDialog();
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
                "Agregar Carrera",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                FRM_CARRERA_AGR.Close();
            }
            this.mostrar_Pantalla();
        }

        private void sub_men_carrera_mod_Click(object sender, EventArgs e)
        {
            this.ocultar_Pantalla();
            StringBuilder errorMessages = new StringBuilder();
            Usuario user = new Usuario();
            user.v_usuario = this.usuario;
            frm_carrera_mod FRM_CARRERA_MOD = new frm_carrera_mod(this.usuario);
            try
            {
                if (user.VerificarPermiso(user, FRM_CARRERA_MOD.ToString()) != 0)
                {
                    FRM_CARRERA_MOD.ShowDialog();
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
                "Modificar Carrera",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                FRM_CARRERA_MOD.Close();
            }
            this.mostrar_Pantalla();
            
        }

        private void sub_men_carrera_con_Click(object sender, EventArgs e)
        {
            this.ocultar_Pantalla();
            StringBuilder errorMessages = new StringBuilder();
            Usuario user = new Usuario();
            user.v_usuario = this.usuario;
            frm_carrera_con FRM_CARRERA_CON = new frm_carrera_con(this.usuario);
            try
            {
                if (user.VerificarPermiso(user, FRM_CARRERA_CON.ToString()) != 0)
                {
                    FRM_CARRERA_CON.ShowDialog();
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
                "Consultar Carrera",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                FRM_CARRERA_CON.Close();
            }
            this.mostrar_Pantalla();
        }

        private void sub_men_carrera_eli_Click(object sender, EventArgs e)
        {
            this.ocultar_Pantalla();
            StringBuilder errorMessages = new StringBuilder();
            Usuario user = new Usuario();
            user.v_usuario = this.usuario;
            frm_carrera_eli FRM_CARRERA_ELI = new frm_carrera_eli(this.usuario);
            try
            {
                if (user.VerificarPermiso(user, FRM_CARRERA_ELI.ToString()) != 0)
                {
                    FRM_CARRERA_ELI.ShowDialog();
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
                "Eliminar Carrera",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                FRM_CARRERA_ELI.Close();
            }
            this.mostrar_Pantalla();
        }

        private void sub_men_materia_agr_Click(object sender, EventArgs e)
        {
            this.ocultar_Pantalla();
            StringBuilder errorMessages = new StringBuilder();
            Usuario user = new Usuario();
            user.v_usuario = this.usuario;
            frm_materia_agr FRM_MATERIA_AGR = new frm_materia_agr(this.usuario);
            try
            {
                if (user.VerificarPermiso(user, FRM_MATERIA_AGR.ToString()) != 0)
                {
                    FRM_MATERIA_AGR.ShowDialog();
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
                "Agregar Materia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                FRM_MATERIA_AGR.Close();
            }
            this.mostrar_Pantalla();
        }

        private void sub_men_materia_mod_Click(object sender, EventArgs e)
        {
            this.ocultar_Pantalla();
            StringBuilder errorMessages = new StringBuilder();
            Usuario user = new Usuario();
            user.v_usuario = this.usuario;
            frm_materia_mod FRM_MATERIA_MOD = new frm_materia_mod(this.usuario);
            try
            {
                if (user.VerificarPermiso(user, FRM_MATERIA_MOD.ToString()) != 0)
                {
                    FRM_MATERIA_MOD.ShowDialog();
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
                "Modificar Materia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                FRM_MATERIA_MOD.Close();
            }
            this.mostrar_Pantalla();

        }

        private void sub_men_materia_con_Click(object sender, EventArgs e)
        {
            this.ocultar_Pantalla();
            StringBuilder errorMessages = new StringBuilder();
            Usuario user = new Usuario();
            user.v_usuario = this.usuario;
            frm_materia_con FRM_MATERIA_CON = new frm_materia_con(this.usuario);
            try
            {
                if (user.VerificarPermiso(user, FRM_MATERIA_CON.ToString()) != 0)
                {
                    FRM_MATERIA_CON.ShowDialog();
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
                "Consultar Materia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                FRM_MATERIA_CON.Close();
            }
            this.mostrar_Pantalla();
        }

        private void sub_men_materia_eli_Click(object sender, EventArgs e)
        {
            this.ocultar_Pantalla();
            StringBuilder errorMessages = new StringBuilder();
            Usuario user = new Usuario();
            user.v_usuario = this.usuario;
            frm_materia_eli FRM_MATERIA_ELI = new frm_materia_eli(this.usuario);
            try
            {
                if (user.VerificarPermiso(user, FRM_MATERIA_ELI.ToString()) != 0)
                {
                    FRM_MATERIA_ELI.ShowDialog();
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
                "Eliminar Materia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                FRM_MATERIA_ELI.Close();
            }
            this.mostrar_Pantalla();
        }

        private void sub_men_libro_agr_Click(object sender, EventArgs e)
        {
            this.ocultar_Pantalla();
            StringBuilder errorMessages = new StringBuilder();
            Usuario user = new Usuario();
            user.v_usuario = this.usuario;
            frm_libro_agr FRM_LIBRO_AGR = new frm_libro_agr(this.usuario);
            try
            {
                if (user.VerificarPermiso(user, FRM_LIBRO_AGR.ToString()) != 0)
                {
                    FRM_LIBRO_AGR.ShowDialog();
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
                "Agregar Libro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                FRM_LIBRO_AGR.Close();
            }
            this.mostrar_Pantalla();
        }

        private void sub_men_libro_mod_Click(object sender, EventArgs e)
        {
            this.ocultar_Pantalla();
            StringBuilder errorMessages = new StringBuilder();
            Usuario user = new Usuario();
            user.v_usuario = this.usuario;
            frm_libro_mod FRM_LIBRO_MOD = new frm_libro_mod(this.usuario);
            try
            {
                if (user.VerificarPermiso(user, FRM_LIBRO_MOD.ToString()) != 0)
                {
                    FRM_LIBRO_MOD.ShowDialog();
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
                "Modificar Libro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                FRM_LIBRO_MOD.Close();
            }
            this.mostrar_Pantalla();
        }

        private void sub_men_libro_con_Click(object sender, EventArgs e)
        {
            this.ocultar_Pantalla();
            StringBuilder errorMessages = new StringBuilder();
            Usuario user = new Usuario();
            user.v_usuario = this.usuario;
            frm_libro_con FRM_LIBRO_CON = new frm_libro_con(this.usuario);
            try
            {
                if (user.VerificarPermiso(user, FRM_LIBRO_CON.ToString()) != 0)
                {
                    FRM_LIBRO_CON.ShowDialog();
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
                "Consultar Libro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                FRM_LIBRO_CON.Close();
            }
            this.mostrar_Pantalla();
        }

        private void sub_men_libro_eli_Click(object sender, EventArgs e)
        {
            this.ocultar_Pantalla();
            StringBuilder errorMessages = new StringBuilder();
            Usuario user = new Usuario();
            user.v_usuario = this.usuario;
            frm_libro_eli FRM_LIBRO_ELI = new frm_libro_eli(this.usuario);
            try
            {
                if (user.VerificarPermiso(user, FRM_LIBRO_ELI.ToString()) != 0)
                {
                    FRM_LIBRO_ELI.ShowDialog();
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
                "Eliminar Libro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                FRM_LIBRO_ELI.Close();
            }
            this.mostrar_Pantalla();

        }

        private void sub_men_editorial_agr_Click(object sender, EventArgs e)
        {
            this.ocultar_Pantalla();
            StringBuilder errorMessages = new StringBuilder();
            Usuario user = new Usuario();
            user.v_usuario = this.usuario;
            frm_editorial_agr FRM_EDITORIAL_AGR = new frm_editorial_agr(this.usuario);
            try
            {
                if (user.VerificarPermiso(user, FRM_EDITORIAL_AGR.ToString()) != 0)
                {
                    FRM_EDITORIAL_AGR.ShowDialog();
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
                FRM_EDITORIAL_AGR.Close();
            }
            this.mostrar_Pantalla();
        }

        private void sub_men_editorial_mod_Click(object sender, EventArgs e)
        {
            this.ocultar_Pantalla();
            StringBuilder errorMessages = new StringBuilder();
            Usuario user = new Usuario();
            user.v_usuario = this.usuario;
            frm_editorial_mod FRM_EDITORIAL_MOD = new frm_editorial_mod(this.usuario);
            try
            {
                if (user.VerificarPermiso(user, FRM_EDITORIAL_MOD.ToString()) != 0)
                {
                    FRM_EDITORIAL_MOD.ShowDialog();
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
                FRM_EDITORIAL_MOD.Close();
            }
            this.mostrar_Pantalla();
        }

        private void sub_men_editorial_con_Click(object sender, EventArgs e)
        {
            this.ocultar_Pantalla();
            StringBuilder errorMessages = new StringBuilder();
            Usuario user = new Usuario();
            user.v_usuario = this.usuario;
            frm_editorial_con FRM_EDITORIAL_CON = new frm_editorial_con(this.usuario);
            try
            {
                if (user.VerificarPermiso(user, FRM_EDITORIAL_CON.ToString()) != 0)
                {
                    FRM_EDITORIAL_CON.ShowDialog();
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
                "Consultar Editorial",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                FRM_EDITORIAL_CON.Close();
            }
            this.mostrar_Pantalla();
        }

        private void sub_men_editorial_eli_Click(object sender, EventArgs e)
        {
            this.ocultar_Pantalla();
            StringBuilder errorMessages = new StringBuilder();
            Usuario user = new Usuario();
            user.v_usuario = this.usuario;
            frm_editorial_eli FRM_EDITORIAL_ELI = new frm_editorial_eli(this.usuario);
            try
            {
                if (user.VerificarPermiso(user, FRM_EDITORIAL_ELI.ToString()) != 0)
                {
                    FRM_EDITORIAL_ELI.ShowDialog();
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
                "Eliminar Editorial",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                FRM_EDITORIAL_ELI.Close();
            }
            this.mostrar_Pantalla();
        }

        //private void frm_menu_pri_FormClosed(object sender, CancelEventArgs e)
        //{
            
        //}

        //solicitar bibliografia
        private void sub_men_bibliografia_sol_Click(object sender, EventArgs e)
        {
            this.ocultar_Pantalla();
            StringBuilder errorMessages = new StringBuilder();
            Usuario user = new Usuario();
            user.v_usuario = this.usuario;
            frm_bibliografia_sol FRM_BIBLIOGRAFIA_SOL = new frm_bibliografia_sol(this.usuario);
            try
            {
                if (user.VerificarPermiso(user, FRM_BIBLIOGRAFIA_SOL.ToString()) != 0)
                {
                    FRM_BIBLIOGRAFIA_SOL.ShowDialog();
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
                FRM_BIBLIOGRAFIA_SOL.Close();
            }
            this.mostrar_Pantalla();
        }

        //
        private void sub_men_bibliografia_con_Click(object sender, EventArgs e)
        {
            this.ocultar_Pantalla();
            StringBuilder errorMessages = new StringBuilder();
            Usuario user = new Usuario();
            user.v_usuario = this.usuario;
            frm_bibliografia_con FRM_BIBLIOGRAFIA_CON = new frm_bibliografia_con(this.usuario);
            try
            {
                if (user.VerificarPermiso(user, FRM_BIBLIOGRAFIA_CON.ToString()) != 0)
                {
                    FRM_BIBLIOGRAFIA_CON.ShowDialog();
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
                FRM_BIBLIOGRAFIA_CON.Close();
            }
            this.mostrar_Pantalla();
        }

        //
        private void sub_men_bibliografia_aut_Click(object sender, EventArgs e)
        {
            this.ocultar_Pantalla();
            StringBuilder errorMessages = new StringBuilder();
            Usuario user = new Usuario();
            user.v_usuario = this.usuario;
            frm_bibliografia_aut FRM_BIBLIOGRAFIA_AUT = new frm_bibliografia_aut(this.usuario);
            try
            {
                if (user.VerificarPermiso(user, FRM_BIBLIOGRAFIA_AUT.ToString()) != 0)
                {
                    FRM_BIBLIOGRAFIA_AUT.ShowDialog();
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
                FRM_BIBLIOGRAFIA_AUT.Close();
            }
            this.mostrar_Pantalla();
        }

        //
        private void frm_menu_pri_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((
                MessageBox.Show("¿Desea cerrar su sesión?",
                "Cerrar Sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes))
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        //
        private void frm_menu_pri_Load(object sender, EventArgs e)
        {

        }

        //
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frm_menu_pri_KeyPress(object sender, KeyPressEventArgs e)
        {
            
           if (e.KeyChar == Convert.ToChar(Keys.M))
            {
            //aqui se coloca la direccion del archivo y listo 
                Process.Start(this.manual_dir);
            }
            
        
        }        

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            try {
                Process.Start(this.manual_dir);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }   
   
        public static int aaaa()
        {
            return 1;
        }

    }
}
