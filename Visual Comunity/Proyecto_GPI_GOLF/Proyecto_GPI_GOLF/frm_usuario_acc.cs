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
    public partial class frm_usuario_acc : Form
    {
        public frm_usuario_acc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessages = new StringBuilder();
            Usuario user = new Usuario();
            if (tex_usuario.Text.Length == 0 && tex_contraseña.Text.Length == 0) 
            {
                user.v_usuario="" ;
                user.v_clave="" ;
            } else 
            {
                user.v_usuario = tex_usuario.Text;
                user.v_clave = tex_contraseña.Text;
            }

            try
            {
                if (user.IniciaSesion(user) != 0)
                {
                    this.ocultar_Pantalla();
                    frm_menu_pri FRM_MENU_PRI = new frm_menu_pri(user.v_usuario);
                    try
                    {
                        if (user.VerificarPermiso(user, FRM_MENU_PRI.ToString()) != 0)
                        {
                            FRM_MENU_PRI.ShowDialog();
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
                        "Menu Principal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                        FRM_MENU_PRI.Close();
                    }
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

                MessageBox.Show(ex.Errors[0].Message.ToString(),
                "Acceso Usuario",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }            
        }

        private void ocultar_Pantalla() 
        {
            this.Hide();
            tex_usuario.Clear();
            tex_contraseña.Clear();
        }

        private void mostrar_Pantalla() 
        {
            this.Show();
        }

        private void but_salir_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void lab_recuperar_contraseña_Click(object sender, EventArgs e)
        {
            this.ocultar_Pantalla();        
            frm_usuario_rec_cla FRM_RECUPERAR_CONTRASEÑA = new frm_usuario_rec_cla();
            FRM_RECUPERAR_CONTRASEÑA.ShowDialog();
            this.mostrar_Pantalla();
        }

        public override string ToString()
        {
            return string.Format("frm_usuario_acc");
        }

    }
}
