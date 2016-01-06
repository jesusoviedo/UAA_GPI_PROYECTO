using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usuario_logica;

namespace Proyecto_GPI_GOLF
{
    public partial class frm_persona_agr : Form
    {
        private string usuario { get; set; }
        private SortedList SLpais, SLtipodocumento,SLtipopersona;

        public frm_persona_agr()
        {
            InitializeComponent();
        }
        public frm_persona_agr(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.mostrarLista();
        }


        private void frm_persona_agr_Load(object sender, EventArgs e)
        {

        }

        public override string ToString()
        {
            return string.Format("frm_persona_agr");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void text_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_agregar_persona_Click(object sender, EventArgs e)
        {
            if (this.verificar_datos_persona1()==false && this.verificar_datos_persona2()==false)
            {

                if (tex_direccion.Text.Length == 0)
                {
                    tex_direccion.Text = " ";
                }

                if (tex_telefono.Text.Length == 0)
                {
                    tex_telefono.Text = " ";
                } 
            
                StringBuilder errorMessages = new StringBuilder();
                Persona per = new Persona();
                per.v_documento = tex_documento.Text;
                per.v_DcodTipoDocumento = com_tipo_documento.SelectedItem.ToString();
                per.v_DcodTipoPersona = com_tipo_persona.SelectedItem.ToString();
                per.v_nombre = tex_nombre.Text;
                per.v_apellido = tex_apellido.Text;
                per.v_fechaNacimiento = Convert.ToDateTime(tex_fecha_nacimiento.Text);
                per.v_DcodPaisNacimiento = com_pais_nacimiento.SelectedItem.ToString();
                per.v_direccion = tex_direccion.Text;
                per.v_telefono = tex_telefono.Text;
                per.v_correoElectronico = tex_correo_electronico.Text;
                per.v_usuario = this.usuario;

                try
                {
                    if (per.AgregarPersona(per) != 0)
                    {
                        MessageBox.Show("Persona creada correctamente"+ "\n" +"Documento: "+per.v_documento,
                        "Agregar Persona",
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

                    MessageBox.Show(ex.Errors[0].Message.ToString(),
                    "Agregar Persona",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }     
           }
        }

        private bool verificar_datos_persona1()
        {
            bool error=false;

            if (tex_documento.Text.Length == 0)
            {
                    MessageBox.Show("Debe ingresar un Documento",
                    "Agregar Persona",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    error = true;        
            } 
            else if (tex_nombre.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un Nombre",
                "Agregar Persona",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                error = true;
            } 
            else if (tex_apellido.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un Apellido",
                "Agregar Persona",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                error = true;
            } 
            else if (tex_fecha_nacimiento.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar una fecha de Nacimiento",
                "Agregar Persona",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                error = true;
            }
            else if (tex_correo_electronico.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un Correo electrónico",
                "Agregar Persona",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                error = true;
            }
            return error;
        }

        private bool verificar_datos_persona2()
        {
            bool error = false;

            if (tex_fecha_nacimiento.Text.Length != 0)
            {
                try
                {
                    DateTime dateValue, fecha;
                    dateValue = DateTime.ParseExact(tex_fecha_nacimiento.Text, "dd/mm/yyyy", null);
                    fecha = Convert.ToDateTime(tex_fecha_nacimiento.Text);

                    int dia, mes, anho;
                    dia = Convert.ToInt32(tex_fecha_nacimiento.Text.Substring(0, 2));
                    mes = Convert.ToInt32(tex_fecha_nacimiento.Text.Substring(3, 2));
                    anho = Convert.ToInt32(tex_fecha_nacimiento.Text.Substring(6, 4));
                    if (dia < 1 || dia > 31)
                    {
                        MessageBox.Show("Debe ingresar un dia valido(dd/mm/yyyy)",
                       "Agregar Persona",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                        error = true;
                    }
                    else if (mes < 1 || mes > 12)
                    {
                        MessageBox.Show("Debe ingresar un mes valido(dd/mm/yyyy)",
                       "Agregar Persona",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                        error = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Debe ingresar una fecha valida(dd/mm/yyyy)",
                    "Agregar Persona",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    error = true;
                }
            }
            
            if (tex_correo_electronico.Text.Length != 0)
            {
                String expresion;
                expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
                if (Regex.IsMatch(tex_correo_electronico.Text, expresion))
                {
                    if (Regex.Replace(tex_correo_electronico.Text, expresion, String.Empty).Length == 0)
                    {
                      
                    }
                    else
                    {
                        MessageBox.Show("Formato de Correo electrónico incorrecto",
                        "Agregar Persona",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        error = true;
                    }
                }
                else
                {
                    MessageBox.Show("Formato de Correo electrónico incorrecto",
                    "Agregar Persona",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    error = true;
                }
            }
            return error;
        }

        private void inicializarDatos() {
            tex_nombre.Text = "";
            tex_apellido.Text = "";
            tex_correo_electronico.Text= "";
            tex_direccion.Text = "";
            tex_documento.Text = "";
            tex_fecha_nacimiento.Text = "";
            tex_nombre.Text = "";
            tex_telefono.Text = "";
            this.mostrarLista();
        }

        private void mostrarLista()
        {
            StringBuilder errorMessages = new StringBuilder();
            Persona per = new Persona();
            try
            {

                if ((per.OptenerPais(per)).v_pais.Count != 0)
                {
                    SLpais = new SortedList();
                    foreach (String pais in per.v_pais)
                    {
                        SLpais.Add(pais, pais);
                    }
                    com_pais_nacimiento.DataSource = SLpais.GetValueList();
                    com_pais_nacimiento.Show();
                }

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

                if ((per.OptenerTipoPersona(per)).v_tipopersona.Count != 0)
                {
                    SLtipopersona = new SortedList();
                    foreach (String tipopersona in per.v_tipopersona)
                    {
                        SLtipopersona.Add(tipopersona, tipopersona);
                    }
                    com_tipo_persona.DataSource = SLtipopersona.GetValueList();
                    com_tipo_persona.Show();
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
            }


        }

        private void lab_documento_Click(object sender, EventArgs e)
        {

        }

        private void lab_tipo_documento_Click(object sender, EventArgs e)
        {

        }

        private void lab_nombre_Click(object sender, EventArgs e)
        {

        }

        private void lab_apellido_Click(object sender, EventArgs e)
        {

        }

        private void lab_fecha_nacimiento_Click(object sender, EventArgs e)
        {

        }

        private void lab_pais_Click(object sender, EventArgs e)
        {

        }

        private void lab_direccion_Click(object sender, EventArgs e)
        {

        }

        private void lab_telefono_Click(object sender, EventArgs e)
        {

        }

        private void lab_correo_electronico_Click(object sender, EventArgs e)
        {

        }

        private void lab_tipo_persona_Click(object sender, EventArgs e)
        {

        }

        private void com_tipo_persona_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tex_correo_electronico_TextChanged(object sender, EventArgs e)
        {

        }

        private void tex_telefono_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
