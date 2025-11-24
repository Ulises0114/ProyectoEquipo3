using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejadores
{
    public class ManejadorPermisos
    {
        Base b = new Base("localhost", "root", "12345", "CarpinteriaDB");

        // Método para obtener una lista de permisos de un usuario
        public List<Permisos> ObtenerPermisosPorUsuario(int idUsuario)
        {
            List<Permisos> listaPermisos = new List<Permisos>();

            string query = $"call sp_ObtenerPermisosPorUsuario({idUsuario})";

            DataSet ds = b.Consultar(query, "PermisosUsuario");

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    // Convierte el valor de MySQL (0 o 1) a booleano
                    bool leer = Convert.ToBoolean(dr["permiso_leer_abrir"]);
                    bool escribir = Convert.ToBoolean(dr["permiso_escritura"]);

                    listaPermisos.Add(new Permisos(
                        dr["NombreModulo"].ToString(),
                        leer,
                        escribir
                    ));
                }
            }
            return listaPermisos;
        }
    }
}
