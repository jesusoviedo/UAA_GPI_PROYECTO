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
    public partial class frm_persona_mod : Form
    {
        private string usuario { get; set; }
        public SortedList SLtipodocumento;
        StringBuilder errorMessages = new StringBuilder();
        public SortedList SLpais= new SortedList();
        public SortedList SLtipopersona = new SortedList();
        Persona per = new Persona();
        public frm_persona_mod()
        {
            InitializeComponent();
        }

        public frm_persona_mod(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.inicializarDatos();
        }

        private void frm_persona_mod_Load(object sender, EventArgs e)
        {

        }

        public override string ToString()
        {
            return string.Format("frm_persona_mod");
        }

        private void but_agregar_persona_Click(object sender, EventArgs e)
        {
            if (tex_documento.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un Documento",
                "Modificar Persona",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            }
            else if ( String.IsNullOrEmpty(tex_usuario.Text))
            {
                MessageBox.Show("Debe seleccionar el tipo de Documento",
                "Modificar Persona",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            } else
            {
                ///////
                if (this.verificar_datos_persona1() == false && this.verificar_datos_persona2() == false)
                {
                    StringBuilder errorMessages = new StringBuilder();
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
                    
                    if (che_activar_persona.Checked== true)
                    {
                        per.v_estado ='A';
                    }

                    try
                    {   
                        if (per.ModificarPersona(per) != 0)
                        {
                            MessageBox.Show("Persona modifacada correctamente" + "\n" + "Documento: " + per.v_documento,
                            "Modificar Persona",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                            this.inicializarDatos();
                            this.bloquearDatosFinal();
                            com_pais_nacimiento.DataSource = null;
                            com_pais_nacimiento.Show();
                            com_tipo_persona.DataSource = null;
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
                        "Modificar Persona",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    }  
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
                "Modificar Persona",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private void inicializarDatos()
        {
            tex_nombre.Text = "";
            tex_apellido.Text = "";
            tex_fecha_nacimiento.Text = "";
            tex_correo_electronico.Text = "";
            tex_direccion.Text = "";
            tex_fecha_nacimiento.Text = "";
            tex_nombre.Text = "";
            tex_telefono.Text = "";
            tex_usuario.Text = "";
            this.mostrarLista();
        }

        private void com_tipo_documento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (tex_documento.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un Documento",
                "Modificar Persona",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    per.v_documento = tex_documento.Text;
                    per.v_DcodTipoDocumento = com_tipo_documento.SelectedItem.ToString();
                    if ((per.ConsultarPersonaIA(per)).v_nombre.Length != 0)
                    {
                        tex_nombre.Text = per.v_nombre;
                        tex_apellido.Text = per.v_apellido;
                        tex_fecha_nacimiento.Text = String.Format("{0:dd/MM/yyyy}", per.v_fechaNacimiento);
                        tex_direccion.Text = per.v_direccion;
                        tex_telefono.Text = per.v_telefono;
                        tex_correo_electronico.Text = per.v_correoElectronico;
                        tex_usuario.Text = per.v_usuario;
                        tex_documento.Enabled = false;
                        com_tipo_documento.Enabled = false;
                        tex_nombre.Enabled = true;
                        tex_apellido.Enabled = true;
                        tex_fecha_nacimiento.Enabled = true;
                        tex_direccion.Enabled = true;
                        tex_telefono.Enabled = true;
                        tex_correo_electronico.Enabled = true;

                        if (per.v_estado=='I'){
                            che_activar_persona.Enabled = true;
                            che_activar_persona.Checked = false;
                        }
                                             
                        com_pais_nacimiento.Enabled = true;
                        com_tipo_persona.Enabled = true;

                        this.mostrarListaPaisTipPersona();                    
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
                    "Modificar Persona",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
        }

        private void mostrarListaPaisTipPersona()
        {
            StringBuilder errorMessages = new StringBuilder();
            
            try
            {
                if ((per.OptenerPais(per)).v_pais.Count != 0)
                {
                    foreach (String pais in per.v_pais)
                    {
                        SLpais.Add(pais, pais);        
                    }
                    com_pais_nacimiento.DataSource = SLpais.GetValueList();
                    com_pais_nacimiento.SelectedItem = per.v_DcodPaisNacimiento;
                    com_pais_nacimiento.Show();
                }

                if ((per.OptenerTipoPersona(per)).v_tipopersona.Count != 0)
                {
                    foreach (String tipopersona in per.v_tipopersona)
                    {
                            SLtipopersona.Add(tipopersona, tipopersona);
                    }
                    com_tipo_persona.DataSource = SLtipopersona.GetValueList();
                    com_tipo_persona.SelectedItem = per.v_DcodTipoPersona;
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
                "Modificar Persona",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }


        }

        private bool verificar_datos_persona1()
        {
            bool error = false;

            if (tex_documento.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un Documento",
                "Modificar Persona",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                error = true;
            }
            else if (tex_nombre.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un Nombre",
                "Modificar Persona",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                error = true;
            }
            else if (tex_apellido.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un Apellido",
                "Modificar Persona",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                error = true;
            }
            else if (tex_fecha_nacimiento.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar una fecha de Nacimiento",
                "Modificar Persona",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                error = true;
            }
            else if (tex_correo_electronico.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un Correo electrónico",
                "Modificar Persona",
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
                        MessageBox.Show("Debe ingresar una fecha valido(dd/mm/yyyy)",
                       "Modificar Persona",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                        error = true;
                    }
                    else if (mes < 1 || mes > 12)
                    {
                        MessageBox.Show("Debe ingresar una fecha valido(dd/mm/yyyy)",
                       "Modificar Persona",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                        error = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Debe ingresar una fecha valida(dd/mm/yyyy)",
                    "Modificar Persona",
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
                        error = false;
                    }
                    else
                    {
                        MessageBox.Show("Formato de Correo electrónico incorrecto",
                        "Modificar Persona",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        error = true;
                    }
                }
                else
                {
                    MessageBox.Show("Formato de Correo electrónico incorrecto",
                    "Modificar Persona",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    error = true;
                }
            }
            return error;
        }

        private void bloquearDatosFinal(){

            tex_documento.Enabled = true;
            com_tipo_documento.Enabled = true;
            tex_nombre.Enabled = false;
            tex_apellido.Enabled = false;
            tex_fecha_nacimiento.Enabled = false;
            tex_direccion.Enabled = false;
            tex_telefono.Enabled = false;
            tex_correo_electronico.Enabled = false;
            che_activar_persona.Enabled = false;
            che_activar_persona.Checked = false;
            tex_documento.Text = "";
            com_pais_nacimiento.DataSource = null;
            com_pais_nacimiento.Show();
            com_tipo_persona.DataSource = null;
            com_tipo_persona.Show();
            com_pais_nacimiento.Enabled = false;
            com_tipo_persona.Enabled = false;
            SLpais.Clear();
            per.v_pais.Clear();
            SLtipopersona.Clear();
            per.v_tipopersona.Clear();          

        }

        private void com_tipo_documento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
