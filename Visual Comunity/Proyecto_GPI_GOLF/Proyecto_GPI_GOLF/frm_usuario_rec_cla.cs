using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usuario_logica;

namespace Proyecto_GPI_GOLF
{
    public partial class frm_usuario_rec_cla : Form
    {
        public frm_usuario_rec_cla()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void but_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_recuperar_contraseña_Load(object sender, EventArgs e)
        {

        }

        private void but_recuperar_Click(object sender, EventArgs e)
        {

            if (tex_correo.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un correo electrónico para recuperar su usuario y contraseña",
                "Recuperar Contraseña",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                StringBuilder errorMessages = new StringBuilder();
                Usuario user = new Usuario();
                user.v_correo = tex_correo.Text;

                try
                {
                    
                    if ((user.RecuperarClave(user)).v_clave.Length != 0)
                    {
                        if (this.EnviarEmail(user.v_correo,user.v_usuario,user.v_clave) == true)
                        {
                            MessageBox.Show("Mensaje enviado correctamente, por favor verifique su correo.\n\n"
                            +"En caso de no encontrar ningún correo en su bandeja de entrada, por favor verifique en su bandeja de Spam",
                            "Recuperar Contraseña",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                            this.Close();
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
                    "Recuperar Contraseña",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }

        }

        private bool EnviarEmail(string v_dir_envio, string v_usuario, string v_clave)
        {
            MailMessage msg = new MailMessage();
            try
            {
                msg.To.Add(v_dir_envio);

                msg.From = new MailAddress("uaa.gpi.golf@gmail.com", "Soporte GPI-GOLF", System.Text.Encoding.UTF8);

                msg.Subject = "Clave de acceso";

                msg.SubjectEncoding = System.Text.Encoding.UTF8;

                msg.Body = "Usuario: " + v_usuario + "\nContraseña: " + v_clave;
                
                msg.BodyEncoding = System.Text.Encoding.UTF8;

                msg.IsBodyHtml = false; //Si vas a enviar un correo con contenido html entonces cambia el valor a true
                //Aquí es donde se hace lo especial

                SmtpClient client = new SmtpClient();

                client.Credentials = new System.Net.NetworkCredential("uaa.gpi.golf@gmail.com", "qaz123098");

                client.Port = 587;

                client.Host = "smtp.gmail.com";//Este es el smtp valido para Gmail

                client.EnableSsl = true; //Esto es para que vaya a través de SSL que es obligatorio con GMail

                client.Send(msg);

                return true;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message,
                "Envio de correo electrónico",
                MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
                return false;
            }

        }

        private void tex_mensaje_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public override string ToString()
        {
            return string.Format("frm_usuario_rec_cla");
        }
    }
}
