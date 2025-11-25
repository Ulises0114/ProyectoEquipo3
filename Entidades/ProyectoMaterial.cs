using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProyectoMaterial
    {
        public int IdProyectoMaterial { get; set; }
        public int IdProyecto { get; set; }
        public int IdMaterial { get; set; }
        public string NombreMaterial { get; set; } // Para mostrar en el grid
        public double CantidadRequerida { get; set; }
        public string UnidadMedida { get; set; }
        public DateTime FechaAsignacion { get; set; }
    }
}
