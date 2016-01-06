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
    public class Usuario
    {
        public ArrayList v_pantalla = new ArrayList();
        public ArrayList v_facultad = new ArrayList();
        public ArrayList v_facultad_usuario = new ArrayList();
        public String v_usuario { get; set; }
        public String v_usuario_i { get; set; }
        public String v_usuario_m { get; set; }
        public String v_Dfacultad { get; set; }
        public String v_clave { get; set; }
        public String v_clave_nueva { get; set; }
        public String v_correo { get; set; }
        private String v_TipoEvento { get; set; }
        public char v_estado { get; set; }

        public int IniciaSesion(Usuario usuario)
        {
            usuario.v_TipoEvento = "I";
            DatosSistema datos = new DatosSistema();
            string[] parametros = { "@v_usuario", "@v_clave", "@v_TipoEvento" };
            return datos.Ejecutar( "proInicioSesion", parametros, usuario.v_usuario,usuario.v_clave,usuario.v_TipoEvento);
        }

        public Usuario RecuperarClave(Usuario usuario)
        {
            DatosSistema datos = new DatosSistema();
            usuario.v_TipoEvento = "R";
            var dt = new DataTable();
            string[] parametros = { "@v_correo", "@v_TipoEvento" };
            dt = datos.getDatosTabla("proRecuperarClave", parametros, usuario.v_correo, usuario.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                usuario.v_usuario = fila["CodUsuario"].ToString();
                usuario.v_clave = fila["Clave"].ToString();
            }
            return usuario;
        }

        public int CambiarClave(Usuario usuario)
        {
            usuario.v_TipoEvento = "C";
            DatosSistema datos = new DatosSistema();
            string[] parametros = { "@v_usuario", "@v_clave_actual", "@v_clave_nueva", "@v_TipoEvento" };
            return datos.Ejecutar("proCambiarClave", parametros, usuario.v_usuario, usuario.v_clave, usuario.v_clave_nueva, usuario.v_TipoEvento);
        }

        public int VerificarPermiso(Usuario usuario,String pantalla)
        {
            usuario.v_TipoEvento = "P";
            DatosSistema datos = new DatosSistema();
            string[] parametros = { "@v_usuario", "@v_pantalla", "@v_TipoEvento" };
            return datos.Ejecutar("proPermisoPantalla", parametros, usuario.v_usuario, pantalla, usuario.v_TipoEvento);
        }

        public Usuario ConsultarPermiso(Usuario usuario)
        {
            DatosSistema datos = new DatosSistema();
            usuario.v_TipoEvento = "C";
            usuario.v_pantalla.Clear();
            var dt = new DataTable();
            string[] parametros = { "@v_usuario", "@v_TipoEvento" };
            dt = datos.getDatosTabla("proConsultarPermisoPantalla", parametros, usuario.v_usuario, usuario.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                usuario.v_pantalla.Add(fila["Pantalla"].ToString());
            }
            return usuario;
        }

        public int ActualizarPermiso(Usuario usuario, String pantalla)
        {
            usuario.v_TipoEvento = "A";
            DatosSistema datos = new DatosSistema();
            string[] parametros = { "@v_usuario", "@v_pantalla","@v_estado", "@v_TipoEvento" };
            return datos.Ejecutar("proActualizarPermisoPantalla", parametros, usuario.v_usuario, pantalla,usuario.v_estado, usuario.v_TipoEvento);
        }

        public Usuario OptenerFacultad(Usuario usuario)
        {
            DatosSistema datos = new DatosSistema();
            usuario.v_TipoEvento = "F";
            var dt = new DataTable();
            string[] parametros = { "@v_TipoEvento" };
            dt = datos.getDatosTabla("proDevolverDatos", parametros, usuario.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                usuario.v_facultad.Add(fila["facultad"].ToString());

            }
            return usuario;
        }

        public Usuario ConsultarUsuarioFacultad(Usuario usuario)
        {
            DatosSistema datos = new DatosSistema();
            usuario.v_TipoEvento = "U";
            var dt = new DataTable();
            string[] parametros = { "@v_usuario", "@v_TipoEvento" };
            dt = datos.getDatosTabla("proDevolverUsuarioFacultad", parametros, usuario.v_usuario, usuario.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                usuario.v_facultad_usuario.Add(fila["facultad"].ToString());

            }
            return usuario;
        }

        public int AgregarUsuarioFacultad(Usuario usuario)
        {
            DatosSistema datos = new DatosSistema();
            usuario.v_TipoEvento = "A";
            var dt = new DataTable();
            string[] parametros = { "@v_usuario", 
                                    "@v_Dfacultad", 
                                    "@v_usuarioI", 
                                    "@v_TipoEvento" };

            return datos.Ejecutar("proAgregarUsuarioFacultad", 
                                    parametros, 
                                    usuario.v_usuario, 
                                    usuario.v_Dfacultad, 
                                    usuario.v_usuario_i, 
                                    usuario.v_TipoEvento);
        }

        public int EliminarUsuarioFacultad(Usuario usuario)
        {
            DatosSistema datos = new DatosSistema();
            usuario.v_TipoEvento = "E";
            var dt = new DataTable();
            string[] parametros = { "@v_usuario", 
                                    "@v_Dfacultad", 
                                    "@v_usuarioM", 
                                    "@v_TipoEvento" };

            return datos.Ejecutar("proEliminarUsuarioFacultad",
                                    parametros,
                                    usuario.v_usuario,
                                    usuario.v_Dfacultad,
                                    usuario.v_usuario_m,
                                    usuario.v_TipoEvento);
        }





    }
}

  
