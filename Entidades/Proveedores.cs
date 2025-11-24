using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Proveedores
    {
        public Proveedores(int idProveedor, string nombreProveedor, string contacto, string telefono, string email, string direccion, string fechaIngreso)
        {
            IdProveedor = idProveedor;
            NombreProveedor = nombreProveedor;
            Contacto = contacto;
            Telefono = telefono;
            Email = email;
            Direccion = direccion;
            FechaIngreso = fechaIngreso;
        }

        public int IdProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public string Contacto { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string FechaIngreso { get; set; }
       
    }
}
