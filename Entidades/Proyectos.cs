using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Proyectos
    {
        public Proyectos()
        {
            Materiales = new List<ProyectoMaterial>();
        }

        public Proyectos(int idProyecto, string nombreMueble, string estadoProyecto,
                         DateTime? fechaCreacion, DateTime? fechaEstimadaFin)
        {
            IdProyecto = idProyecto;
            NombreMueble = nombreMueble;
            EstadoProyecto = estadoProyecto;
            FechaCreacion = fechaCreacion;
            FechaEstimadaFin = fechaEstimadaFin;
            Materiales = new List<ProyectoMaterial>();
        }

        public int IdProyecto { get; set; }
        public string NombreMueble { get; set; }
        public string EstadoProyecto { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaEstimadaFin { get; set; }
        public List<ProyectoMaterial> Materiales { get; set; }
    }
}
