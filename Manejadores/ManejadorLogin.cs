using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorLogin
    {
        Base b = new Base("localhost", "root", "12345", "CarpinteriaDB");
        public static string Sha1(string texto)
        {
            SHA1 sha = SHA1.Create();
            Byte[] hash = sha.ComputeHash(ASCIIEncoding.Default.GetBytes(texto));
            StringBuilder cadena = new StringBuilder();
            foreach (byte bit in hash)
            {
                cadena.AppendFormat("{0:x2}", bit);
            }
            return cadena.ToString();
        }
        public bool Validar(TextBox usuario, TextBox clave)
        {
            DataSet ds = b.Consultar($"call sp_validar('{usuario.Text}', '{Sha1(clave.Text)}')", "usuarios");

            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            DataRow dr = ds.Tables[0].Rows[0];

            if (dr["rs"].ToString().Equals("Aceptado"))
            {
                Usuarios.UsuarioLogueadoID = Convert.ToInt32(dr["IdUsuario"]);
                Usuarios.UsuarioLogueadoNombre = usuario.Text; 

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
