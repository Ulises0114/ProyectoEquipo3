using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Proyectos
    {
        public Proyectos(int idProyecto, string nombreMueble, int idMaterial, double cantidadRequerida, string unidadMedida, string estadoProyecto, string fechaCreacion, string fechaEstimadaFin)
        {
            IdProyecto = idProyecto;
            NombreMueble = nombreMueble;
            IdMaterial = idMaterial;
            CantidadRequerida = cantidadRequerida;
            UnidadMedida = unidadMedida;
            EstadoProyecto = estadoProyecto;
            FechaCreacion = fechaCreacion;
            FechaEstimadaFin = fechaEstimadaFin;
        }

        public int IdProyecto { get; set; }
        public string NombreMueble { get; set; }
        public int IdMaterial { get; set; }
        public double CantidadRequerida { get; set; }
        public string UnidadMedida { get; set; }
        public string EstadoProyecto { get; set; }
        public string FechaCreacion { get; set; }
        public string FechaEstimadaFin { get; set; }
    }
}
