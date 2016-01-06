using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        private SqlConnection con { get; set; }

        private string cadenaConexion() 
        {
            return @"Data Source=RJ92\SQLEXPRESS;Initial Catalog=Proyecto_GPI_GOLF;User Id=ap;Password=gpigolf";

        }

        //metodo obtener conexion
        public SqlConnection getConexion() {
            try{
              con= new SqlConnection(cadenaConexion());
              con.Open();
              return con;
            } catch (Exception ex ) {
                Console.WriteLine("\nMessage ---\n{0}", ex.Message);
                return null;

            }

        }

        //metodo cerrar conexion
        public void cerrarConexion()
        {
            if (this.con != null)
            {
                this.con.Close();
            }

        }
            
       
    }
}
