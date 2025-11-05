using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Proveedores
    {
        public Proveedores(int idProveedor, string nombreProveedor, string contacto, int telefono, string email, string direccion, string fechaRegistro)
        {
            IdProveedor = idProveedor;
            NombreProveedor = nombreProveedor;
            Contacto = contacto;
            Telefono = telefono;
            Email = email;
            Direccion = direccion;
            FechaRegistro = fechaRegistro;
        }

        public int IdProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public string Contacto { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string FechaRegistro { get; set; }
    }
}
