
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using capaENT;

namespace capaDAT
{
    public class capaDatos
    {
        Conexion t = new Conexion();
        public DataSet ds = new DataSet();
        public DataTable dt = new DataTable();
        public SqlDataAdapter da = new SqlDataAdapter();

        public DataTable personal()
        {
            SqlCommand cmd = new SqlCommand("Select anfitriones from parametros", t.AbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public DataTable lugar()
        {
            SqlCommand cmd = new SqlCommand("Select lugares from parametros", t.AbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public void lleve(ref pacENT pac)
        {
            SqlCommand cmd = new SqlCommand("insert into pacientes values ('" + pac.Documento + "','" 
                + pac.Nombre + "','" + pac.Apellido + "','" + pac.Fecha + "','" 
                + pac.Obrsocial + "','" + pac.Foto + "')", t.AbrirConexion());

            try { 
                cmd.ExecuteNonQuery();
                MessageBox.Show("Guardado en BD !!! ");
            } catch {
                //MessageBox.Show("error en capa datos paciente"); 
            }
            finally { t.CerrarConexion(); }
        }

        public void lleve_v(ref perENT tut)
        {
            SqlCommand cmd = new SqlCommand("insert into visitas values ('" + tut.Documento + "','" 
                + tut.Nombre + "','" + tut.Parentezco + "','" + tut.Anfitrion + "','" 
                + tut.Salon + "' )", t.AbrirConexion());

            try { 
                cmd.ExecuteNonQuery();
                MessageBox.Show("Guardado en BD !!! ");
            } catch {
                // MessageBox.Show("error en tutor dato");
            }
            finally { t.CerrarConexion(); }

        }

        public DataSet Listk()
        {
            SqlCommand cmd = new SqlCommand("select * from pacientes", t.AbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            try { da.Fill(ds); 
            } catch {
                //   MessageBox.Show("Error en listar, en capa datos "); 
            }
            return ds;

        }
    }
}

