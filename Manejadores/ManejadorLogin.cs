using AccesoDatos;
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
            DataRow dr = b.Consultar($"call p_validar('{usuario.Text}', '{Sha1(clave.Text)}')", "Usuarios").Tables[0].Rows[0];
            if (dr["rs"].ToString().Equals("Aceptado"))
                return true;
            else
                return false;
        }
    }
}
