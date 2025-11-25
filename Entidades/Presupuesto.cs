using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Presupuesto
    {
        public Presupuesto()
        {
        }
        public Presupuesto(int idPresupuesto, int idProyecto, string nombreMueble,
                           double costoMaterial, double costoManoObra, double costoTotal,
                           string estadoPresupuesto, DateTime? fechaCreacion, DateTime? fechaActualizacion)
        {
            IdPresupuesto = idPresupuesto;
            IdProyecto = idProyecto;
            NombreMueble = nombreMueble;
            CostoMaterial = costoMaterial;
            CostoManoObra = costoManoObra;
            CostoTotal = costoTotal;
            EstadoPresupuesto = estadoPresupuesto;
            FechaCreacion = fechaCreacion;
            FechaActualizacion = fechaActualizacion;
        }

        public int IdPresupuesto { get; set; }
        public int IdProyecto { get; set; }
        public string NombreMueble { get; set; }
        public double CostoMaterial { get; set; }
        public double CostoManoObra { get; set; }
        public double CostoTotal { get; set; }
        public string EstadoPresupuesto { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
