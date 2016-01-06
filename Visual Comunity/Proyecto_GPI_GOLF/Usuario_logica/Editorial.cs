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
    public class Editorial
    {
        public ArrayList v_pais = new ArrayList();
        private String v_TipoEvento { get; set; }
        public String v_usuario_i { get; set; }
        public String v_usuario_m { get; set; }
        public String v_nombre_editorial { get; set; }
        public String v_Dpais { get; set; }
        public String v_direccion_editorial { get; set; }
        public char v_estado { get; set; }


        public Editorial OptenerPais(Editorial editorial)
        {
            DatosSistema datos = new DatosSistema();
            editorial.v_TipoEvento = "P";
            var dt = new DataTable();
            string[] parametros = { "@v_TipoEvento" };
            dt = datos.getDatosTabla("proDevolverDatos", parametros, editorial.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                editorial.v_pais.Add(fila["Pais"].ToString());

            }
            return editorial;
        }

        public int AgregarEditorial(Editorial editorial)
        {
            editorial.v_TipoEvento = "I";
            DatosSistema datos = new DatosSistema();
            string[] parametros = { "@v_nombre", 
                                    "@v_Dpais",
                                    "@v_direccion", 
                                    "@v_usuarioI",
                                    "@v_TipoEvento"};

            return datos.Ejecutar("proAgregarEditorial", parametros,
                                   editorial.v_nombre_editorial,
                                   editorial.v_Dpais,
                                   editorial.v_direccion_editorial,
                                   editorial.v_usuario_i,
                                   editorial.v_TipoEvento);
        }

        public Editorial ConsultarEditorial(Editorial editorial)
        {
            DatosSistema datos = new DatosSistema();
            editorial.v_TipoEvento = "C";
            var dt = new DataTable();
            string[] parametros = { "@v_nombre", "@v_TipoEvento" };
            dt = datos.getDatosTabla("proConsultarEditorial", parametros, editorial.v_nombre_editorial, editorial.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                editorial.v_nombre_editorial = fila["nombre"].ToString();
                editorial.v_Dpais = fila["pais"].ToString();
                editorial.v_direccion_editorial = fila["direccion"].ToString();
            }
            return editorial;
        }

        public int EliminarEditorial(Editorial editorial)
        {
            editorial.v_TipoEvento = "E";
            DatosSistema datos = new DatosSistema();
            string[] parametros = { "@v_nombre", 
                                    "@v_usuarioM",
                                    "@v_TipoEvento"};

            return datos.Ejecutar("proEliminarEditorial", parametros,
                                   editorial.v_nombre_editorial,
                                   editorial.v_usuario_m,
                                   editorial.v_TipoEvento);
        }

        public Editorial ConsultarEditorialIA(Editorial editorial)
        {
            DatosSistema datos = new DatosSistema();
            editorial.v_TipoEvento = "C";
            var dt = new DataTable();
            string[] parametros = { "@v_nombre", "@v_TipoEvento" };
            dt = datos.getDatosTabla("proConsultarEditorialIA", parametros, editorial.v_nombre_editorial, editorial.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                editorial.v_nombre_editorial = fila["nombre"].ToString();
                editorial.v_Dpais = fila["pais"].ToString();
                editorial.v_direccion_editorial = fila["direccion"].ToString();
                editorial.v_estado = Convert.ToChar(fila["estado"].ToString());
            }
            return editorial;
        }

        public int ModificarEditorial(Editorial editorial)
        {
            editorial.v_TipoEvento = "M";
            DatosSistema datos = new DatosSistema();
            string[] parametros = { "@v_nombre", 
                                    "@v_Dpais",
                                    "@v_direccion", 
                                    "@v_estado",
                                    "@v_usuarioM",
                                    "@v_TipoEvento"};

            return datos.Ejecutar("proModificarEditorial", parametros,
                                   editorial.v_nombre_editorial,
                                   editorial.v_Dpais,
                                   editorial.v_direccion_editorial,
                                   editorial.v_estado,
                                   editorial.v_usuario_m,
                                   editorial.v_TipoEvento);
        }

        

    }
}
