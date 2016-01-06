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
    public partial class frm_persona_con : Form
    {
        private string usuario { get; set; }
        private SortedList SLtipodocumento;

        public frm_persona_con()
        {
            InitializeComponent();
        }

        public frm_persona_con(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.mostrarLista();
        }

        private void frm_persona_con_Load(object sender, EventArgs e)
        {

        }

        public override string ToString()
        {
            return string.Format("frm_persona_con");
        }

        private void but_agregar_persona_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessages = new StringBuilder();
            Persona per = new Persona();
            if (tex_documento.Text.Length == 0){
                this.inicializarDatos();
                MessageBox.Show("Debe ingresar un Documento",
                "Consultar Persona",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }else {
                try
                {
                    per.v_documento=tex_documento.Text;
                    per.v_DcodTipoDocumento = com_tipo_documento.SelectedItem.ToString();
                    if ((per.ConsultarPersona(per)).v_nombre.Length != 0)
                    {
                        tex_tipo_persona.Text=per.v_DcodTipoPersona;
                        tex_nombre.Text=per.v_nombre ;
                        tex_apellido.Text = per.v_apellido;
                        tex_fecha_nacimiento.Text = String.Format("{0:dd/MM/yyyy}", per.v_fechaNacimiento); 
                        tex_pais_nacimiento.Text = per.v_DcodPaisNacimiento;
                        tex_direccion.Text = per.v_direccion;
                        tex_telefono.Text=per.v_telefono ;
                        tex_correo_electronico.Text = per.v_correoElectronico;
                        tex_usuario.Text =per.v_usuario;
                        tex_tipo_persona.Text = per.v_DcodTipoPersona;
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
                    "Consultar Persona",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }

            }
        }



        private void mostrarLista()
        {
            StringBuilder errorMessages = new StringBuilder();
            Persona per = new Persona();
            try
            {

                if ((per.OptenerDocumento(per)).v_tipodocumento.Count != 0)
                {
                    SLtipodocumento = new SortedList();
                    foreach (String tipodocumento in per.v_tipodocumento)
                    {
                        SLtipodocumento.Add(tipodocumento, tipodocumento);
                    }
                    com_tipo_documento.DataSource = SLtipodocumento.GetValueList();
                    com_tipo_documento.Show();
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
            }
        }

        private void inicializarDatos()
        {
            tex_tipo_persona.Text = "";
            tex_nombre.Text = "";
            tex_apellido.Text = "";
            tex_fecha_nacimiento.Text = "";
            tex_pais_nacimiento.Text = "";
            tex_correo_electronico.Text = "";
            tex_direccion.Text = "";
            tex_fecha_nacimiento.Text = "";
            tex_nombre.Text = "";
            tex_telefono.Text = "";
            tex_usuario.Text = "";
            tex_tipo_persona.Text = "";
            this.mostrarLista();
        }
 
    }
}
