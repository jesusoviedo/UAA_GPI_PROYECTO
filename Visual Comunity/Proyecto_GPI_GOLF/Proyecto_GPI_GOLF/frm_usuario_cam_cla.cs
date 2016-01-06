using System;
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
    public partial class frm_usuario_cam_cla : Form
    {
        private string usuario { get; set; }

        public frm_usuario_cam_cla()
        {
            InitializeComponent();
        }

        public frm_usuario_cam_cla(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }


        private void tex_contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_usuario_cam_cla_Load(object sender, EventArgs e)
        {

        }

        private void lab_contraseña_nueva_Click(object sender, EventArgs e)
        {

        }

        private void but_cambiar_contraseña_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessages = new StringBuilder();
            Usuario user = new Usuario();
            user.v_usuario = this.usuario;
            if (tex_contraseña.Text.Length == 0 && tex_contraseña_nueva.Text.Length == 0)
            {
                user.v_clave = "";
                user.v_clave_nueva = "";
            }
            else
            {
                user.v_clave = tex_contraseña.Text;
                user.v_clave_nueva = tex_contraseña_nueva.Text;
            }

            try
            {
                if (user.CambiarClave(user) != 0)
                {
                    MessageBox.Show("Cambio realizado correctamente",
                    "Cambio de Contraseña",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    this.Close();
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
                "Cambio de Contraseña",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }  
        }

        public override string ToString()
        {
            return string.Format("frm_usuario_cam_cla");
        }

        private void tex_contraseña_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    EjecutarFuncion();
            //}
        }
    }
}
