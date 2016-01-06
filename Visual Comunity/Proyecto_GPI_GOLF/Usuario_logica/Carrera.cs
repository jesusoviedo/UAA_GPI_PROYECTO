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
    public class Carrera
    {
        public ArrayList v_facultad = new ArrayList();
        public ArrayList v_materia = new ArrayList();
        public ArrayList v_materia_carrera = new ArrayList();
        private String v_TipoEvento { get; set; }
        public String v_usuario_i { get; set; }
        public String v_usuario_m { get; set; }
        public String v_nombre { get; set; }
        public String v_promocion { get; set; }
        public String v_descripcion { get; set; }
        public String v_Dfacultad { get; set; }
        public String v_DMateria { get; set; }
        public char v_estado { get; set; }

        public Carrera OptenerFacultad(Carrera carrera)
        {
            DatosSistema datos = new DatosSistema();
            carrera.v_TipoEvento = "F";
            var dt = new DataTable();
            string[] parametros = { "@v_TipoEvento" };
            dt = datos.getDatosTabla("proDevolverDatos", parametros, carrera.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                carrera.v_facultad.Add(fila["facultad"].ToString());

            }
            return carrera;
        }

        public Carrera OptenerMateria(Carrera carrera)
        {
            DatosSistema datos = new DatosSistema();
            carrera.v_TipoEvento = "M";
            var dt = new DataTable();
            string[] parametros = { "@v_TipoEvento" };
            dt = datos.getDatosTabla("proDevolverDatos", parametros, carrera.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                carrera.v_materia.Add(fila["materia"].ToString());

            }
            return carrera;
        }

        public int AgregarCarrera(Carrera carrera)
        {
            carrera.v_TipoEvento = "I";
            DatosSistema datos = new DatosSistema();
            string[] parametros = { "@v_nombre", 
                                    "@v_promocion",
                                    "@v_Dfacultad",
                                    "@v_descripcion",
                                    "@v_usuarioI",
                                    "@v_TipoEvento"};

            return datos.Ejecutar("proAgregarCarrera", parametros,
                                   carrera.v_nombre,
                                   carrera.v_promocion,
                                   carrera.v_Dfacultad,
                                   carrera.v_descripcion,
                                   carrera.v_usuario_i,
                                   carrera.v_TipoEvento);
        }

        public Carrera ConsultarCarrera(Carrera carrera)
        {
            DatosSistema datos = new DatosSistema();
            carrera.v_TipoEvento = "C";
            var dt = new DataTable();
            string[] parametros = { "@v_nombre","@v_promocion" , "@v_TipoEvento" };
            dt = datos.getDatosTabla("proConsultarCarrera", parametros, carrera.v_nombre, carrera.v_promocion, carrera.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                carrera.v_nombre = fila["nombre"].ToString();
                carrera.v_promocion = fila["promocion"].ToString();
                carrera.v_descripcion = fila["descripcion"].ToString();
                carrera.v_Dfacultad = fila["facultad"].ToString();
            }
            return carrera;
        }

        public Carrera ConsultarCarreraIA(Carrera carrera)
        {
            DatosSistema datos = new DatosSistema();
            carrera.v_TipoEvento = "C";
            var dt = new DataTable();
            string[] parametros = { "@v_nombre", "@v_promocion", "@v_TipoEvento" };
            dt = datos.getDatosTabla("proConsultarCarreraIA", parametros, carrera.v_nombre, carrera.v_promocion, carrera.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                carrera.v_nombre = fila["nombre"].ToString();
                carrera.v_promocion = fila["promocion"].ToString();
                carrera.v_descripcion = fila["descripcion"].ToString();
                carrera.v_Dfacultad = fila["facultad"].ToString();
                carrera.v_estado = Convert.ToChar(fila["estado"].ToString());
            }
            return carrera;
        }

        public int EliminarCarrera(Carrera carrera)
        {
            carrera.v_TipoEvento = "E";
            DatosSistema datos = new DatosSistema();
            string[] parametros = { "@v_nombre", 
                                    "@v_promocion",
                                    "@v_usuarioM",
                                    "@v_TipoEvento"};

            return datos.Ejecutar("proEliminarCarrera", parametros,
                                   carrera.v_nombre,
                                   carrera.v_promocion,
                                   carrera.v_usuario_m,
                                   carrera.v_TipoEvento);
        }


        public int ModificarCarrera(Carrera carrera)
        {

            carrera.v_TipoEvento = "M";
            DatosSistema datos = new DatosSistema();
            string[] parametros = { "@v_nombre", 
                                    "@v_promocion",
                                    "@v_descripcion", 
                                    "@v_Dfacultad",
                                    "@v_estado",
                                    "@v_usuarioM",
                                    "@v_TipoEvento"};

            return datos.Ejecutar("proModificarCarrera", parametros,
                                   carrera.v_nombre,
                                   carrera.v_promocion,
                                   carrera.v_descripcion,
                                   carrera.v_Dfacultad,
                                   carrera.v_estado,
                                   carrera.v_usuario_m,
                                   carrera.v_TipoEvento);
        }

        public Carrera ConsultarCarreraMateria(Carrera carrera)
        {
            DatosSistema datos = new DatosSistema();
            carrera.v_TipoEvento = "M";
            var dt = new DataTable();
            string[] parametros = { "@v_nombre", "@v_promocion", "@v_TipoEvento" };
            dt = datos.getDatosTabla("proDevolverCarreraMateria", parametros, carrera.v_nombre, carrera.v_promocion, carrera.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                carrera.v_materia_carrera.Add(fila["materia"].ToString());

            }
            return carrera;
        }


        public int AgregarCarreraMateria(Carrera carrera)
        {
            DatosSistema datos = new DatosSistema();
            carrera.v_TipoEvento = "A";
            var dt = new DataTable();
            string[] parametros = { "@v_Dcarrera", 
                                    "@v_promocion",
                                    "@v_Dmateria",
                                    "@v_usuarioI", 
                                    "@v_TipoEvento" };

            return datos.Ejecutar("proAgregarCarreraMateria",
                                    parametros,
                                    carrera.v_nombre,
                                    carrera.v_promocion,
                                    carrera.v_DMateria,
                                    carrera.v_usuario_i,
                                    carrera.v_TipoEvento);
        }

        public int EliminarCarreraMateria(Carrera carrera)
        {
            DatosSistema datos = new DatosSistema();
            carrera.v_TipoEvento = "E";
            var dt = new DataTable();
            string[] parametros = { "@v_Dcarrera", 
                                    "@v_promocion",
                                    "@v_Dmateria",
                                    "@v_usuarioM", 
                                    "@v_TipoEvento" };

            return datos.Ejecutar("proEliminarCarreraMateria",
                                    parametros,
                                    carrera.v_nombre,
                                    carrera.v_promocion,
                                    carrera.v_DMateria,
                                    carrera.v_usuario_m,
                                    carrera.v_TipoEvento);
        }




    }
}
