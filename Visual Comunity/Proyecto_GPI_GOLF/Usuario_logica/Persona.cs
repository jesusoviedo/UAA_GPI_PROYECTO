using Datos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario_logica
{
    public class Persona
    {
        public ArrayList v_pais = new ArrayList();
        public ArrayList v_tipodocumento = new ArrayList();
        public ArrayList v_tipopersona = new ArrayList();
        private String v_TipoEvento { get; set; }
        public String v_usuario { get; set; }
        public String v_documento { get; set; }
        public String v_DcodTipoDocumento { get; set; }
        public String v_DcodTipoPersona { get; set; }
        public String v_nombre { get; set; }
        public String v_apellido { get; set; }
        public DateTime v_fechaNacimiento { get; set; }     
        public String v_DcodPaisNacimiento { get; set; }                              
        public String v_direccion { get; set; } 
        public String v_telefono { get; set; }
        public String v_correoElectronico { get; set; }
        public char v_estado { get; set; }
        

        public Persona OptenerPais(Persona persona)
        {
            DatosSistema datos = new DatosSistema();
            persona.v_TipoEvento = "P";
            var dt = new DataTable();
            string[] parametros = { "@v_TipoEvento" };
            dt = datos.getDatosTabla("proDevolverDatos", parametros, persona.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                persona.v_pais.Add(fila["Pais"].ToString());
                
            }
            return persona;
        }

        public Persona OptenerDocumento(Persona persona)
        {
            DatosSistema datos = new DatosSistema();
            persona.v_TipoEvento = "D";
            var dt = new DataTable();
            string[] parametros = { "@v_TipoEvento" };
            dt = datos.getDatosTabla("proDevolverDatos", parametros, persona.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                persona.v_tipodocumento.Add(fila["TipoDocumento"].ToString());

            }
            return persona;
        }

        public Persona OptenerTipoPersona(Persona persona)
        {
            DatosSistema datos = new DatosSistema();
            persona.v_TipoEvento = "T";
            var dt = new DataTable();
            string[] parametros = { "@v_TipoEvento" };
            dt = datos.getDatosTabla("proDevolverDatos", parametros, persona.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                persona.v_tipopersona.Add(fila["TipoPersona"].ToString());
            }
            return persona;
        }

        public int AgregarPersona(Persona persona)
        {
            persona.v_TipoEvento = "I";
            DatosSistema datos = new DatosSistema();
            string[] parametros = { "@v_documento", 
                                    "@v_DcodTipoDocumento",
                                    "@v_DcodTipoPersona", 
                                    "@v_nombre",
                                    "@v_apellido",
                                    "@v_fechaNacimiento",
                                    "@v_DcodPaisNacimiento",
                                    "@v_direccion",
                                    "@v_telefono",
                                    "@v_correoElectronico",
                                    "@v_usuarioI",
                                    "@v_TipoEvento" };

            return datos.Ejecutar("proAgregarPersona", parametros,
                                   persona.v_documento,
                                   persona.v_DcodTipoDocumento,
                                   persona.v_DcodTipoPersona,                                   
                                   persona.v_nombre,
                                   persona.v_apellido,
                                   persona.v_fechaNacimiento,
                                   persona.v_DcodPaisNacimiento,
                                   persona.v_direccion,
                                   persona.v_telefono,
                                   persona.v_correoElectronico,
                                   persona.v_usuario,
                                   persona.v_TipoEvento);
        }

        public Persona ConsultarPersona(Persona persona)
        {
            DatosSistema datos = new DatosSistema();
            persona.v_TipoEvento = "C";
            var dt = new DataTable();
            string[] parametros = { "@v_documento", "@v_DcodTipoDocumento", "@v_TipoEvento" };
            dt = datos.getDatosTabla("proConsultarPersona", parametros, persona.v_documento, persona.v_DcodTipoDocumento, persona.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                persona.v_nombre =fila["nombre"].ToString();
                persona.v_apellido =fila["apellido"].ToString();
                persona.v_fechaNacimiento =Convert.ToDateTime(fila["fecnacimiento"].ToString());
                persona.v_DcodPaisNacimiento =fila["pais"].ToString();
                persona.v_direccion =fila["direccion"].ToString();
                persona.v_telefono =fila["telefono"].ToString();
                persona.v_correoElectronico =fila["correo"].ToString();
                persona.v_usuario =fila["usuario"].ToString();
                persona.v_DcodTipoPersona = fila["tipopersona"].ToString(); 
                
            }
            return persona;
        }

        public int EliminarPersona(Persona persona)
        {
            persona.v_TipoEvento = "E";
            DatosSistema datos = new DatosSistema();
            string[] parametros = { "@v_documento", "@v_DcodTipoDocumento", "@v_usuarioM", "@v_TipoEvento" };
            return datos.Ejecutar("proEliminarPersona", parametros, persona.v_documento, persona.v_DcodTipoDocumento,persona.v_usuario,persona.v_TipoEvento);
        }

        public Persona ConsultarPersonaIA(Persona persona)
        {
            DatosSistema datos = new DatosSistema();
            persona.v_TipoEvento = "C";
            var dt = new DataTable();
            string[] parametros = { "@v_documento", "@v_DcodTipoDocumento", "@v_TipoEvento" };
            dt = datos.getDatosTabla("proConsultarPersonaEstadoIA", parametros, persona.v_documento, persona.v_DcodTipoDocumento, persona.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                persona.v_nombre = fila["nombre"].ToString();
                persona.v_apellido = fila["apellido"].ToString();
                persona.v_fechaNacimiento = Convert.ToDateTime(fila["fecnacimiento"].ToString());
                persona.v_DcodPaisNacimiento = fila["pais"].ToString();
                persona.v_direccion = fila["direccion"].ToString();
                persona.v_telefono = fila["telefono"].ToString();
                persona.v_correoElectronico = fila["correo"].ToString();
                persona.v_usuario = fila["usuario"].ToString();
                persona.v_DcodTipoPersona = fila["tipopersona"].ToString();
                persona.v_estado = Convert.ToChar(fila["estado"].ToString());
            }

            return persona;
        }

        public int ModificarPersona(Persona persona)
        {
            persona.v_TipoEvento = "M";
            DatosSistema datos = new DatosSistema();
            string[] parametros = { "@v_documento", 
                                    "@v_DcodTipoDocumento",
                                    "@v_DcodTipoPersona", 
                                    "@v_nombre",
                                    "@v_apellido",
                                    "@v_fechaNacimiento",
                                    "@v_DcodPaisNacimiento",
                                    "@v_direccion",
                                    "@v_telefono",
                                    "@v_correoElectronico",
                                    "@v_estado",
                                    "@v_usuarioM",
                                    "@v_TipoEvento" };

            return datos.Ejecutar("proModificarPersona", parametros,
                                   persona.v_documento,
                                   persona.v_DcodTipoDocumento,
                                   persona.v_DcodTipoPersona,
                                   persona.v_nombre,
                                   persona.v_apellido,
                                   persona.v_fechaNacimiento,
                                   persona.v_DcodPaisNacimiento,
                                   persona.v_direccion,
                                   persona.v_telefono,
                                   persona.v_correoElectronico,
                                   persona.v_estado,
                                   persona.v_usuario,
                                   persona.v_TipoEvento);
        }


    }
}
