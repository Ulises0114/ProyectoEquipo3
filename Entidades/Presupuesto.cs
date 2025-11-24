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
        public int IdPresupuesto { get; set; }
        public int IdProyecto { get; set; }
        public double CostoMaterial { get; set; }
        public double CostoManoObra { get; set; }
        public double CostoTotal { get; set; }
        public DateTime Fecha_Creacion { get; set; }
        public string EstadoPresupuesto { get; set; }
    }
}
