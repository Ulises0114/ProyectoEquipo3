using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Manejadores
{
    public class ManejadorLogin
    {
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

    }
}
