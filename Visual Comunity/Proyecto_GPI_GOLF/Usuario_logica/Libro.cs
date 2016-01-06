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
    public class Libro
    {
        public ArrayList v_editorial = new ArrayList();
        public ArrayList v_tipo_libro = new ArrayList();
        public ArrayList v_idioma = new ArrayList();
        private String v_TipoEvento { get; set; }
        public String v_usuario_i { get; set; }
        public String v_usuario_m { get; set; }
        public String v_isbn { get; set; }
        public String v_titulo { get; set; }
        public String v_autor { get; set; }
        public String v_edicion { get; set; }
        public String v_año { get; set; }
        public String v_Deditorial { get; set; }
        public String v_Dtipo_libro { get; set; }
        public String v_Didioma { get; set; }
        public char v_estado { get; set; }

        public Libro OptenerEditorial(Libro libro)
        {
            DatosSistema datos = new DatosSistema();
            libro.v_TipoEvento = "E";
            var dt = new DataTable();
            string[] parametros = { "@v_TipoEvento" };
            dt = datos.getDatosTabla("proDevolverDatos", parametros, libro.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                libro.v_editorial.Add(fila["editorial"].ToString());

            }
            return libro;
        }

        public Libro OptenerTipoLibro(Libro libro)
        {
            DatosSistema datos = new DatosSistema();
            libro.v_TipoEvento = "L";
            var dt = new DataTable();
            string[] parametros = { "@v_TipoEvento" };
            dt = datos.getDatosTabla("proDevolverDatos", parametros, libro.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                libro.v_tipo_libro.Add(fila["tipolibro"].ToString());

            }
            return libro;
        }

        public Libro OptenerIdioma(Libro libro)
        {
            DatosSistema datos = new DatosSistema();
            libro.v_TipoEvento = "I";
            var dt = new DataTable();
            string[] parametros = { "@v_TipoEvento" };
            dt = datos.getDatosTabla("proDevolverDatos", parametros, libro.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                libro.v_idioma.Add(fila["idioma"].ToString());

            }
            return libro;
        }

        public int AgregarLibro(Libro libro)
        {
            libro.v_TipoEvento = "I";
            DatosSistema datos = new DatosSistema();
            string[] parametros = { "@v_isbn", 
                                    "@v_titulo",
                                    "@v_Deditorial", 
                                    "@v_Dtipo_libro",
                                    "@v_autor",
                                    "@v_edicion",
                                    "@v_Didioma",
                                    "@v_año",
                                    "@v_usuarioI",
                                    "@v_TipoEvento"};

            return datos.Ejecutar("proAgregarLibro", parametros,
                                   libro.v_isbn,
                                   libro.v_titulo,
                                   libro.v_Deditorial,
                                   libro.v_Dtipo_libro,
                                   libro.v_autor,
                                   libro.v_edicion,
                                   libro.v_Didioma,
                                   libro.v_año,
                                   libro.v_usuario_i,
                                   libro.v_TipoEvento);
        }

        public Libro ConsultarLibro(Libro libro)
        {
            DatosSistema datos = new DatosSistema();
            libro.v_TipoEvento = "C";
            var dt = new DataTable();
            string[] parametros = { "@v_isbn", "@v_TipoEvento" };
            dt = datos.getDatosTabla("proConsultarLibro", parametros,libro.v_isbn ,libro.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                libro.v_isbn = fila["isbn"].ToString();
                libro.v_titulo = fila["titulo"].ToString();
                libro.v_Deditorial = fila["editorial"].ToString();
                libro.v_Dtipo_libro = fila["tipolibro"].ToString();
                libro.v_autor = fila["autor"].ToString();
                libro.v_edicion = fila["edicion"].ToString();
                libro.v_Didioma = fila["idioma"].ToString();
                libro.v_año = fila["año"].ToString();
             }
            return libro;
        }

        public Libro ConsultarLibroAI(Libro libro)
        {
            DatosSistema datos = new DatosSistema();
            libro.v_TipoEvento = "C";
            var dt = new DataTable();
            string[] parametros = { "@v_isbn", "@v_TipoEvento" };
            dt = datos.getDatosTabla("proConsultarLibroAI", parametros, libro.v_isbn, libro.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                libro.v_isbn = fila["isbn"].ToString();
                libro.v_titulo = fila["titulo"].ToString();
                libro.v_Deditorial = fila["editorial"].ToString();
                libro.v_Dtipo_libro = fila["tipolibro"].ToString();
                libro.v_autor = fila["autor"].ToString();
                libro.v_edicion = fila["edicion"].ToString();
                libro.v_Didioma = fila["idioma"].ToString();
                libro.v_año = fila["año"].ToString();
                libro.v_estado = Convert.ToChar(fila["estado"].ToString());
            }
            return libro;
        }

        public int EliminarLibro(Libro libro)
        {
            libro.v_TipoEvento = "E";
            DatosSistema datos = new DatosSistema();
            string[] parametros = { "@v_isbn", 
                                    "@v_usuarioM",
                                    "@v_TipoEvento"};

            return datos.Ejecutar("proEliminarLibro", parametros,
                                   libro.v_isbn,
                                   libro.v_usuario_m,
                                   libro.v_TipoEvento);
        }

        public int ModificarLibro(Libro libro)
        {
            libro.v_TipoEvento = "M";
            DatosSistema datos = new DatosSistema();
            string[] parametros = { "@v_isbn", 
                                    "@v_titulo",
                                    "@v_Deditorial", 
                                    "@v_Dtipo_libro",
                                    "@v_autor",
                                    "@v_edicion",
                                    "@v_Didioma",
                                    "@v_año",
                                    "@v_estado",
                                    "@v_usuarioM",
                                    "@v_TipoEvento"};

            return datos.Ejecutar("proModificarLibro", parametros,
                                   libro.v_isbn,
                                   libro.v_titulo,
                                   libro.v_Deditorial,
                                   libro.v_Dtipo_libro,
                                   libro.v_autor,
                                   libro.v_edicion,
                                   libro.v_Didioma,
                                   libro.v_año,
                                   libro.v_estado,
                                   libro.v_usuario_m,
                                   libro.v_TipoEvento);
        }
    }
}
