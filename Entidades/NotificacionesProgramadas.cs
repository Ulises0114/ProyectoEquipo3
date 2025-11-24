using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NotificacionesProgramadas
    {
        public NotificacionesProgramadas(int idNotificacion, DateTime fechaNotificacion, string aviso, bool completada)
        {
            IdNotificacion = idNotificacion;
            FechaNotificacion = fechaNotificacion;
            Aviso = aviso;
            Completada = completada;
        }

        public int IdNotificacion { get; set; }
        public DateTime FechaNotificacion { get; set; }
        public string Aviso { get; set; }
        public bool Completada { get; set; }
    }
}
