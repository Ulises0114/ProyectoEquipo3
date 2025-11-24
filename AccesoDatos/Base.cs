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
        public Base(string servidor, string usuario, string password, string BaseDatos, int port = 3308)
        {
            conn = new MySqlConnection($"server={servidor}; port={port}; user={usuario}; password={password}; database={BaseDatos};");
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