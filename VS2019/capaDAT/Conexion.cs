
using System.Data;
using System.Data.SqlClient;

namespace capaDAT
{
    public class Conexion
    {
        static private string cadenaConexion = "Data Source=Carl-PC;Initial Catalog=Geriatrico_los_nonos;Integrated Security=True";
        public SqlConnection cn = new SqlConnection(cadenaConexion);
        
        public SqlConnection AbrirConexion()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            return cn;
        }

        public SqlConnection CerrarConexion()
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
            return cn;
        }
    }
}

