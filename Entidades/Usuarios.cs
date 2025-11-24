using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        public Usuarios(int idUsuario, string nombreUsuario, string contrasena, string telefono, string puesto)
        {
            IdUsuario = idUsuario;
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            Telefono = telefono;
            Puesto = puesto;
        }

        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Telefono { get; set; }
        public string Puesto { get; set; }
        
        public static int UsuarioLogueadoID;
        public static string UsuarioLogueadoNombre;

        public static List<Permisos> PermisosDelUsuario = new List<Permisos>();
        public static bool PuedeEscribir(string modulo)
        {
            // Busca el permiso del módulo especificado
            var permiso = PermisosDelUsuario.FirstOrDefault(p => p.NombreModulo == modulo);
            // Si existe el permiso y tiene escritura activada, retorna true
            return permiso != null && permiso.PermisoEscritura;
        }

        public static bool PuedeLeer(string modulo)
        {
            var permiso = PermisosDelUsuario.FirstOrDefault(p => p.NombreModulo == modulo);
            return permiso != null && permiso.PermisoLeerAbrir;
        }
    }
}
