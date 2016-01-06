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
    public class Materia
    {
        public ArrayList v_facultad = new ArrayList();
        private String v_TipoEvento { get; set; }
        public String v_usuario_i { get; set; }
        public String v_usuario_m { get; set; }
        public String v_nombre { get; set; }
        public String v_clave { get; set; }
        public String v_descripcion { get; set; }
        public String v_Dfacultad { get; set; }
        public char v_estado { get; set; }


        public Materia OptenerFacultad(Materia materia)
        {
            DatosSistema datos = new DatosSistema();
            materia.v_TipoEvento = "F";
            var dt = new DataTable();
            string[] parametros = { "@v_TipoEvento" };
            dt = datos.getDatosTabla("proDevolverDatos", parametros, materia.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                materia.v_facultad.Add(fila["facultad"].ToString());

            }
            return materia;
        }

        public int AgregarMateria(Materia materia)
        {
            materia.v_TipoEvento = "I";
            DatosSistema datos = new DatosSistema();
            string[] parametros = { "@v_nombre", 
                                    "@v_clave",
                                    "@v_descripcion",
                                    "@v_Dfacultad",
                                    "@v_usuarioI",
                                    "@v_TipoEvento"};

            return datos.Ejecutar("proAgregarMateria", parametros,
                                   materia.v_nombre,
                                   materia.v_clave,
                                   materia.v_descripcion,
                                   materia.v_Dfacultad,
                                   materia.v_usuario_i,
                                   materia.v_TipoEvento);
        }

        public Materia ConsultarMateria(Materia materia)
        {
            DatosSistema datos = new DatosSistema();
            materia.v_TipoEvento = "C";
            var dt = new DataTable();
            string[] parametros = { "@v_nombre", "@v_TipoEvento" };
            dt = datos.getDatosTabla("proConsultarMateria", parametros, materia.v_nombre, materia.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                materia.v_nombre = fila["nombre"].ToString();
                materia.v_clave= fila["clave"].ToString();
                materia.v_descripcion = fila["descripcion"].ToString();
                materia.v_Dfacultad = fila["facultad"].ToString();
            }
            return materia;
        }

        public Materia ConsultarMateriaAI(Materia materia)
        {
            DatosSistema datos = new DatosSistema();
            materia.v_TipoEvento = "C";
            var dt = new DataTable();
            string[] parametros = { "@v_nombre", "@v_TipoEvento" };
            dt = datos.getDatosTabla("proConsultarMateriaAI", parametros, materia.v_nombre, materia.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                materia.v_nombre = fila["nombre"].ToString();
                materia.v_clave = fila["clave"].ToString();
                materia.v_descripcion = fila["descripcion"].ToString();
                materia.v_Dfacultad = fila["facultad"].ToString();
                materia.v_estado = Convert.ToChar(fila["estado"].ToString());
            }
            return materia;
        }

        public int EliminarMateria(Materia materia)
        {
            materia.v_TipoEvento = "E";
            DatosSistema datos = new DatosSistema();
            string[] parametros = { "@v_nombre", 
                                    "@v_clave",
                                    "@v_usuarioM",
                                    "@v_TipoEvento"};

            return datos.Ejecutar("proEliminarMateria", parametros,
                                   materia.v_nombre,
                                   materia.v_clave,
                                   materia.v_usuario_m,
                                   materia.v_TipoEvento);
        }

        public int ModificarMateria(Materia materia)
        {

            materia.v_TipoEvento = "M";
            DatosSistema datos = new DatosSistema();
            string[] parametros = { "@v_nombre", 
                                    "@v_clave",
                                    "@v_descripcion", 
                                    "@v_Dfacultad",
                                    "@v_estado",
                                    "@v_usuarioM",
                                    "@v_TipoEvento"};

            return datos.Ejecutar("proModificarMateria", parametros,
                                   materia.v_nombre,
                                   materia.v_clave,
                                   materia.v_descripcion,
                                   materia.v_Dfacultad,
                                   materia.v_estado,
                                   materia.v_usuario_m,
                                   materia.v_TipoEvento);
        }      
        
    }

}
