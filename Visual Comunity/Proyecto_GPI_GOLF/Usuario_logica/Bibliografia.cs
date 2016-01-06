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
    public class Bibliografia
    {
        public ArrayList v_materia = new ArrayList();
        public ArrayList v_semestre = new ArrayList();
        public ArrayList v_tipoBibliografia = new ArrayList();
        public ArrayList v_isbn = new ArrayList();
        public ArrayList v_materia_libro = new ArrayList();
        private String v_TipoEvento { get; set; }
        public String v_DnombreMateria { get; set; }
	    public String v_Disbn { get; set; }
		public String v_DtipoBibliografia { get; set; }
		public int v_año { get; set; }
		public String v_Dsemestre { get; set; }
		public String v_descripcion { get; set; }
        public char v_estado { get; set; }
        public String v_usuario_i { get; set; }
        public String v_usuario_m { get; set; }
        public String v_usuario_so { get; set; }
        public String v_usuario_au { get; set; }
        public String v_usuario_in { get; set; }

        public Bibliografia OptenerMateria(Bibliografia bibliografia)
        {
            DatosSistema datos = new DatosSistema();
            bibliografia.v_TipoEvento = "M";
            var dt = new DataTable();
            string[] parametros = { "@v_TipoEvento" };
            dt = datos.getDatosTabla("proDevolverDatos", parametros, bibliografia.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                bibliografia.v_materia.Add(fila["materia"].ToString());
            }
            return bibliografia;
        }

        public Bibliografia OptenerSemestre(Bibliografia bibliografia)
        {
            DatosSistema datos = new DatosSistema();
            bibliografia.v_TipoEvento = "S";
            var dt = new DataTable();
            string[] parametros = { "@v_TipoEvento" };
            dt = datos.getDatosTabla("proDevolverDatos", parametros, bibliografia.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                bibliografia.v_semestre.Add(fila["semestre"].ToString());
            }
            return bibliografia;
        }

        public Bibliografia OptenerIsbn(Bibliografia bibliografia)
        {
            DatosSistema datos = new DatosSistema();
            bibliografia.v_TipoEvento = "N";
            var dt = new DataTable();
            string[] parametros = { "@v_TipoEvento" };
            dt = datos.getDatosTabla("proDevolverDatos", parametros, bibliografia.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                bibliografia.v_isbn.Add(fila["isbn"].ToString());
            }
            return bibliografia;
        }

        public Bibliografia OptenerTipoBibliografia(Bibliografia bibliografia)
        {
            DatosSistema datos = new DatosSistema();
            bibliografia.v_TipoEvento = "G";
            var dt = new DataTable();
            string[] parametros = { "@v_TipoEvento" };
            dt = datos.getDatosTabla("proDevolverDatos", parametros, bibliografia.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                bibliografia.v_tipoBibliografia.Add(fila["tipobibliografia"].ToString());
            }
            return bibliografia;
        }

        public int VerificarBibliografia(Bibliografia bibliografia)
        {
            bibliografia.v_TipoEvento = "V";
            DatosSistema datos = new DatosSistema();
            string[] parametros = { "@v_DnombreMateria", 
                                    "@v_año",
                                    "@v_Dsemestre",
                                    "@v_usuario_i",
                                    "@v_TipoEvento"};

            return datos.Ejecutar("proVerificarBibliografia", parametros,
                                   bibliografia.v_DnombreMateria,
                                   bibliografia.v_año,
                                   bibliografia.v_Dsemestre,
                                   bibliografia.v_usuario_i,
                                   bibliografia.v_TipoEvento);
        }


        public Bibliografia ConsultarMateriaLibroP(Bibliografia bibliografia)
        {
            DatosSistema datos = new DatosSistema();
            bibliografia.v_TipoEvento = "P";
            var dt = new DataTable();
            string[] parametros = { "@v_DnombreMateria", "@v_año", "@v_Dsemestre","@v_usuario", "@v_TipoEvento" };
            dt = datos.getDatosTabla("proDevolverMateriaLibro", parametros, 
                bibliografia.v_DnombreMateria,
                bibliografia.v_año, 
                bibliografia.v_Dsemestre,
                bibliografia.v_usuario_i ,
                bibliografia.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                bibliografia.v_materia_libro.Add(fila["datos"].ToString());

            }
            return bibliografia;
        }

        public Bibliografia ConsultarMateriaLibroSAI(Bibliografia bibliografia)
        {
            DatosSistema datos = new DatosSistema();
            bibliografia.v_TipoEvento = "G";
            var dt = new DataTable();
            string[] parametros = { "@v_DnombreMateria", "@v_año", "@v_Dsemestre", "@v_usuario", "@v_TipoEvento" };
            dt = datos.getDatosTabla("proDevolverMateriaLibro", parametros,
                bibliografia.v_DnombreMateria,
                bibliografia.v_año,
                bibliografia.v_Dsemestre,
                bibliografia.v_usuario_i,
                bibliografia.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                bibliografia.v_materia_libro.Add(fila["datos"].ToString());

            }
            return bibliografia;
        }

        public Bibliografia ConsultarMateriaLibroS(Bibliografia bibliografia)
        {
            DatosSistema datos = new DatosSistema();
            bibliografia.v_TipoEvento = "S";
            var dt = new DataTable();
            string[] parametros = { "@v_DnombreMateria", "@v_año", "@v_Dsemestre", "@v_usuario", "@v_TipoEvento" };
            dt = datos.getDatosTabla("proDevolverMateriaLibro", parametros,
                bibliografia.v_DnombreMateria,
                bibliografia.v_año,
                bibliografia.v_Dsemestre,
                bibliografia.v_usuario_i,
                bibliografia.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                bibliografia.v_materia_libro.Add(fila["datos"].ToString());

            }
            return bibliografia;
        }

        public int SolicitarAgregarMateriaLibroP(Bibliografia bibliografia)
        {
            DatosSistema datos = new DatosSistema();
            bibliografia.v_TipoEvento = "P";
            var dt = new DataTable();
            string[] parametros = { "@v_DnombreMateria", 
                                    "@v_Disbn",
                                    "@v_DtipoBibliografia",
                                    "@v_año",
                                    "@v_Dsemestre",
                                    "@v_descripcion",
                                    "@v_usuarioI", 
                                    "@v_TipoEvento" };

            return datos.Ejecutar("proSolicitarAgregarMateriaLibroP",
                                    parametros,
                                    bibliografia.v_DnombreMateria,
                                    bibliografia.v_Disbn,
                                    bibliografia.v_DtipoBibliografia,
                                    bibliografia.v_año,
                                    bibliografia.v_Dsemestre,
                                    bibliografia.v_descripcion,
                                    bibliografia.v_usuario_i,
                                    bibliografia.v_TipoEvento);
        }

        public int SolicitarEliminarMateriaLibroP(Bibliografia bibliografia)
        {
            DatosSistema datos = new DatosSistema();
            bibliografia.v_TipoEvento = "E";
            var dt = new DataTable();
            string[] parametros = { "@v_DnombreMateria", 
                                    "@v_Disbn",
                                    "@v_DtipoBibliografia",
                                    "@v_año",
                                    "@v_Dsemestre",
                                    "@v_descripcion",
                                    "@v_usuarioI", 
                                    "@v_TipoEvento" };

            return datos.Ejecutar("proSolicitarEliminarMateriaLibroP",
                                    parametros,
                                    bibliografia.v_DnombreMateria,
                                    bibliografia.v_Disbn,
                                    bibliografia.v_DtipoBibliografia,
                                    bibliografia.v_año,
                                    bibliografia.v_Dsemestre,
                                    bibliografia.v_descripcion,
                                    bibliografia.v_usuario_i,
                                    bibliografia.v_TipoEvento);
        }

        public int SolicitarBibliografiaS(Bibliografia bibliografia)
        {
            DatosSistema datos = new DatosSistema();
            bibliografia.v_TipoEvento = "S";
            var dt = new DataTable();
            string[] parametros = { "@v_DnombreMateria", 
                                    "@v_año",
                                    "@v_Dsemestre",
                                    "@v_descripcion",
                                    "@v_usuarioI", 
                                    "@v_TipoEvento" };

            return datos.Ejecutar("proSolicitarBibliografiaS",
                                    parametros,
                                    bibliografia.v_DnombreMateria,
                                    bibliografia.v_año,
                                    bibliografia.v_Dsemestre,
                                    bibliografia.v_descripcion,
                                    bibliografia.v_usuario_i,
                                    bibliografia.v_TipoEvento);
        }

        public int EliminarBibliografiaP(Bibliografia bibliografia)
        {
            DatosSistema datos = new DatosSistema();
            bibliografia.v_TipoEvento = "E";
            var dt = new DataTable();
            string[] parametros = { "@v_DnombreMateria", 
                                    "@v_Dsemestre",
                                    "@v_usuarioI", 
                                    "@v_TipoEvento" };

            return datos.Ejecutar("proEliminarBibliografiaE",
                                    parametros,
                                    bibliografia.v_DnombreMateria,
                                    bibliografia.v_Dsemestre,
                                    bibliografia.v_usuario_i,
                                    bibliografia.v_TipoEvento);
        }

        public Bibliografia ConsultarBibliografiaSAI(Bibliografia bibliografia)
        {
            DatosSistema datos = new DatosSistema();
            bibliografia.v_TipoEvento = "G";
            var dt = new DataTable();
            string[] parametros = { "@v_DnombreMateria", "@v_año", "@v_Dsemestre", "@v_TipoEvento" };
            dt = datos.getDatosTabla("proDevolverBibliografia", parametros,
                bibliografia.v_DnombreMateria,
                bibliografia.v_año,
                bibliografia.v_Dsemestre,
                bibliografia.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                bibliografia.v_DnombreMateria = fila["materia"].ToString();
                bibliografia.v_año = Convert.ToInt32(fila["año"].ToString());
                bibliografia.v_Dsemestre = fila["semestre"].ToString();
                bibliografia.v_descripcion = fila["descripcion"].ToString();
                bibliografia.v_estado = Convert.ToChar(fila["estado"].ToString());
                bibliografia.v_usuario_so = fila["solicitante"].ToString();
                bibliografia.v_usuario_au = fila["autorizador"].ToString();
                bibliografia.v_usuario_in = fila["inactivador"].ToString();
            }
            return bibliografia;
        }

        public Bibliografia ConsultarBibliografiaS(Bibliografia bibliografia)
        {
            DatosSistema datos = new DatosSistema();
            bibliografia.v_TipoEvento = "S";
            var dt = new DataTable();
            string[] parametros = { "@v_DnombreMateria", "@v_año", "@v_Dsemestre", "@v_TipoEvento" };
            dt = datos.getDatosTabla("proDevolverBibliografia", parametros,
                bibliografia.v_DnombreMateria,
                bibliografia.v_año,
                bibliografia.v_Dsemestre,
                bibliografia.v_TipoEvento);
            foreach (DataRow fila in dt.Rows)
            {
                bibliografia.v_DnombreMateria = fila["materia"].ToString();
                bibliografia.v_año = Convert.ToInt32(fila["año"].ToString());
                bibliografia.v_Dsemestre = fila["semestre"].ToString();
                bibliografia.v_descripcion = fila["descripcion"].ToString();
                bibliografia.v_estado = Convert.ToChar(fila["estado"].ToString());
                bibliografia.v_usuario_so = fila["solicitante"].ToString();
                bibliografia.v_usuario_au = fila["autorizador"].ToString();
                bibliografia.v_usuario_in = fila["inactivador"].ToString();
            }
            return bibliografia;
        }

        public int AutorizarBibliografiaS(Bibliografia bibliografia)
        {
            DatosSistema datos = new DatosSistema();
            bibliografia.v_TipoEvento = "A";
            var dt = new DataTable();
            string[] parametros = { "@v_DnombreMateria", 
                                    "@v_año",
                                    "@v_Dsemestre",
                                    "@v_descripcion",
                                    "@v_usuario_s",
                                    "@v_usuario_m", 
                                    "@v_TipoEvento" };

            return datos.Ejecutar("proAutorizarBibliografiaS",
                                    parametros,
                                    bibliografia.v_DnombreMateria,
                                    bibliografia.v_año,
                                    bibliografia.v_Dsemestre,
                                    bibliografia.v_descripcion,
                                    bibliografia.v_usuario_so,
                                    bibliografia.v_usuario_m,
                                    bibliografia.v_TipoEvento);
        }

        public int RechazarBibliografiaS(Bibliografia bibliografia)
        {
            DatosSistema datos = new DatosSistema();
            bibliografia.v_TipoEvento = "R";
            var dt = new DataTable();
            string[] parametros = { "@v_DnombreMateria", 
                                    "@v_año",
                                    "@v_Dsemestre",
                                    "@v_descripcion",
                                    "@v_usuario_s",
                                    "@v_usuario_m", 
                                    "@v_TipoEvento" };

            return datos.Ejecutar("proRechazarBibliografiaS",
                                    parametros,
                                    bibliografia.v_DnombreMateria,
                                    bibliografia.v_año,
                                    bibliografia.v_Dsemestre,
                                    bibliografia.v_descripcion,
                                    bibliografia.v_usuario_so,
                                    bibliografia.v_usuario_m,
                                    bibliografia.v_TipoEvento);
        }

    }
}
