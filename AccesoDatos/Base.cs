using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic; // Necesario para List<>
using System.Data;                // Necesario para CommandType y ConnectionState
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos
{
    public class Base
    {
        MySqlConnection conn;

        public Base(string servidor, string puerto, string usuario, string password, string BaseDatos)
        {
            conn = new MySqlConnection("server=127.0.0.1; port=3308; user=root; password=12345; database=CarpinteriaDB;");
        }

        public void Comando(string cadena)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(cadena, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        public void EjecutarSP(string nombreSP, List<MySqlParameter> parametros)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(nombreSP, conn);

                cmd.CommandType = CommandType.StoredProcedure;

                if (parametros != null)
                {
                    cmd.Parameters.AddRange(parametros.ToArray());
                }

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        public DataSet Consultar(string consulta, string tabla)
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conn);
                conn.Open();
                da.Fill(ds, tabla);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            return ds;
        }
    }
}