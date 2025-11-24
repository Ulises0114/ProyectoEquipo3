using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NotificacionesSistema
    {
        public NotificacionesSistema(int idNotificacion, string tipoNotificacion, int? idInventarioRelacionado, int? idProyectoRelacionado, string mensaje, bool leida)
        {
            IdNotificacion = idNotificacion;
            TipoNotificacion = tipoNotificacion;
            IdInventarioRelacionado = idInventarioRelacionado;
            IdProyectoRelacionado = idProyectoRelacionado;
            Mensaje = mensaje;
            Leida = leida;
        }

        public int IdNotificacion { get; set; }
        public string TipoNotificacion { get; set; }
        public int? IdInventarioRelacionado { get; set; }
        public int? IdProyectoRelacionado { get; set; }
        public string Mensaje { get; set; }
        public bool Leida { get; set; }
    }
}
