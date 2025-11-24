using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Permisos
    {
        public string NombreModulo { get; set; }
        public bool PermisoLeerAbrir { get; set; }
        public bool PermisoEscritura { get; set; }
        public Permisos(string nombreModulo, bool leer, bool escribir)
        {
            NombreModulo = nombreModulo;
            PermisoLeerAbrir = leer;
            PermisoEscritura = escribir;
        }
    }
}
