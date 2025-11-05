using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos
{
    public class Base
    {
        MySqlConnection con;
        public Base(string server, string user, string password, string db, int port = 3308)
        {
            con = new MySqlConnection($"server={server}; port={port}; user={user}; password={password}; database={db};");
        }

        public void Comando(string query, bool mantenerConexion = false)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();

                if (!mantenerConexion)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        public DataSet Consultar(string query, string table, bool mantenerConexion = false)
        {
            DataSet ds = new DataSet();
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                da.Fill(ds, table);

                if (!mantenerConexion)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message);
                if (!mantenerConexion)
                    con.Close();
            }

            return ds;
        }
    }
}
