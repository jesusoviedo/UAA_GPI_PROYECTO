using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Datos
{
    public class DatosSistema
    {
        
        //metodo para llenar un Data Table
        public DataTable getDatosTabla(String nomprocedimiento, string[] nomparametros, params Object[] valparametros)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            Conexion con = new Conexion();
            cmd.Connection = con.getConexion();
            cmd.CommandText = nomprocedimiento;
            cmd.CommandType = CommandType.StoredProcedure;
            if (nomprocedimiento.Length != 0 && nomparametros.Length == valparametros.Length)
            {
                int posicionParametro = 0;
                StringBuilder errorMessages = new StringBuilder();
                foreach (string parametro in nomparametros)
                {
                    cmd.Parameters.AddWithValue(parametro, valparametros[posicionParametro++]);
                }
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            return dt;
        }


        //metodo ejecutar procedimiento por ejemplo insert,delete,update,select
        public int Ejecutar (String nomprocedimiento,string [] nomparametros,params Object[]valparametros) 
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.getConexion();
            cmd.CommandText = nomprocedimiento;
            cmd.CommandType = CommandType.StoredProcedure;
            if (nomprocedimiento.Length!=0 && nomparametros.Length == valparametros.Length)
            {
                int posicionParametro = 0;
                StringBuilder errorMessages = new StringBuilder();
                foreach (string parametro in nomparametros) 
                {
                    cmd.Parameters.AddWithValue(parametro, valparametros[posicionParametro++]);
                }
                return cmd.ExecuteNonQuery();                   
            }
            con.cerrarConexion();
            return 0;
        }
    }
}
