using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;
using System.Drawing;
using System.Windows.Forms;
using System.Data;


namespace Manejadores
{
    public class ManejadorNotificacion
    {
        Base b = new Base("127.0.0.1;port=3308", "root", "12345", "CarpinteriaDB");

        // Devuelve DataTable para el listado principal de notificaciones del sistema (con preview y fecha formateada)
        public DataTable ObtenerNotificacionesParaListado(int limite = 100, bool soloNoLeidas = false)
        {
            string where = "1=1";
            if (soloNoLeidas) where += " AND n.Leida = 0";

            string sql = $@"
                SELECT 
                    n.IdNotificacion,
                    n.TipoNotificacion,
                    n.Mensaje,
                    LEFT(n.Mensaje, 240) AS MensajePreview,
                    n.Leida,
                    n.FechaGeneracion,
                    inv.NombreProducto AS NombreInventario,
                    p.NombreMueble AS NombreProyecto,
                    DATE_FORMAT(n.FechaGeneracion, '%d/%m/%Y') AS FechaFormateada
                FROM NotificacionesSistema n
                LEFT JOIN inventario inv ON inv.IdInventario = n.IdInventarioRelacionado
                LEFT JOIN ProyectosPendientes p ON p.IdProyecto = n.IdProyectoRelacionado
                WHERE " + where + @"
                ORDER BY n.FechaGeneracion DESC
                LIMIT " + limite;

            var ds = b.Consultar(sql, "NotificacionesSistema");
            if (ds != null && ds.Tables.Count > 0) return ds.Tables[0];
            return new DataTable();
        }
        // Devuelve DataTable para notificaciones programadas
        public DataTable ObtenerProgramadasParaListado(bool soloPendientes = true, int limite = 50)
        {
            string where = "1=1";
            if (soloPendientes) where += " AND Completada = 0";

            string sql = $@"
                SELECT 
                    IdNotificacion,
                    Aviso,
                    FechaNotificacion,
                    DATE_FORMAT(FechaNotificacion, '%d/%m/%Y %H:%i') AS FechaFormateada,
                    Completada
                FROM NotificacionesProgramadas
                WHERE {where}
                ORDER BY FechaNotificacion ASC
                LIMIT {limite}";

            var ds = b.Consultar(sql, "NotificacionesProgramadas");
            if (ds != null && ds.Tables.Count > 0) return ds.Tables[0];
            return new DataTable();
        }
        // Alternativa: DataTable general (sin preview) - útil para otras pantallas
        public DataTable ObtenerNotificacionesTabla(bool soloNoLeidas = false)
        {
            string where = "1=1";
            if (soloNoLeidas) where += " AND Leida = 0";

            var ds = b.Consultar($@"
                SELECT * FROM NotificacionesSistema
                WHERE {where}
                ORDER BY FechaGeneracion DESC
            ", "NotificacionesSistema");

            if (ds != null && ds.Tables.Count > 0) return ds.Tables[0];
            return new DataTable();
        }
        public DataTable ObtenerProgramadasTabla(bool soloPendientes = true)
        {
            string where = "1=1";
            if (soloPendientes) where += " AND Completada = 0";

            var ds = b.Consultar($"SELECT * FROM NotificacionesProgramadas WHERE {where} ORDER BY FechaNotificacion", "NotificacionesProgramadas");
            if (ds != null && ds.Tables.Count > 0) return ds.Tables[0];
            return new DataTable();
        }
        // Listar entidades NotificacionesSistema
        public List<NotificacionesSistema> ListarNotificaciones(bool soloNoLeidas = false)
        {
            var list = new List<NotificacionesSistema>();
            DataTable dt = ObtenerNotificacionesParaListado(1000, soloNoLeidas);
            foreach (DataRow r in dt.Rows)
            {
                int id = r.Table.Columns.Contains("IdNotificacion") && r["IdNotificacion"] != DBNull.Value ? Convert.ToInt32(r["IdNotificacion"]) : 0;
                string tipo = r.Table.Columns.Contains("TipoNotificacion") ? r["TipoNotificacion"]?.ToString() ?? "" : "";
                int? idInv = r.Table.Columns.Contains("IdInventarioRelacionado") && r["IdInventarioRelacionado"] != DBNull.Value ? (int?)Convert.ToInt32(r["IdInventarioRelacionado"]) : null;
                int? idProj = r.Table.Columns.Contains("IdProyectoRelacionado") && r["IdProyectoRelacionado"] != DBNull.Value ? (int?)Convert.ToInt32(r["IdProyectoRelacionado"]) : null;
                string msg = r.Table.Columns.Contains("Mensaje") ? r["Mensaje"]?.ToString() ?? "" : "";
                bool leida = r.Table.Columns.Contains("Leida") && r["Leida"] != DBNull.Value ? Convert.ToBoolean(r["Leida"]) : false;

                list.Add(new NotificacionesSistema(id, tipo, idInv, idProj, msg, leida));
            }
            return list;
        }
        // Obtener por id (entidad)
        public NotificacionesSistema ObtenerPorId(int id)
        {
            if (id <= 0) return null;
            var ds = b.Consultar($"SELECT * FROM NotificacionesSistema WHERE IdNotificacion = {id}", "n");
            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
            var r = ds.Tables[0].Rows[0];

            int? idInv = r.Table.Columns.Contains("IdInventarioRelacionado") && r["IdInventarioRelacionado"] != DBNull.Value ? (int?)Convert.ToInt32(r["IdInventarioRelacionado"]) : null;
            int? idProj = r.Table.Columns.Contains("IdProyectoRelacionado") && r["IdProyectoRelacionado"] != DBNull.Value ? (int?)Convert.ToInt32(r["IdProyectoRelacionado"]) : null;
            return new NotificacionesSistema(
                Convert.ToInt32(r["IdNotificacion"]),
                r["TipoNotificacion"]?.ToString() ?? "",
                idInv,
                idProj,
                r["Mensaje"]?.ToString() ?? "",
                r["Leida"] != DBNull.Value && Convert.ToBoolean(r["Leida"])
            );
        }
        // Marcar como leída (simple)
        public void MarcarLeida(int id)
        {
            if (id <= 0) return;
            b.Comando($"UPDATE NotificacionesSistema SET Leida = 1 WHERE IdNotificacion = {id}");
        }

        // Marcar como leída y devolver mensaje para mostrar en detalle
        public string MarcarLeidaYDevolverMensaje(int id)
        {
            if (id <= 0) return null;
            var ds = b.Consultar($"SELECT Mensaje FROM NotificacionesSistema WHERE IdNotificacion = {id}", "tmp");
            string mensaje = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                mensaje = ds.Tables[0].Rows[0]["Mensaje"]?.ToString() ?? "";
                b.Comando($"UPDATE NotificacionesSistema SET Leida = 1 WHERE IdNotificacion = {id}");
            }
            return mensaje;
        }
        public void Eliminar(int id)
        {
            if (id <= 0) return;
            b.Comando($"DELETE FROM NotificacionesSistema WHERE IdNotificacion = {id}");
        }
        // Crear notificación de sistema: valida existencia de inventario/proyecto y usa NULL si no existen
        public void CrearNotificacionSistema(string tipo, int? idInventario, int? idProyecto, string mensaje)
        {
            string safe = (mensaje ?? "").Replace("'", "''");
            string inv = "NULL";
            string proj = "NULL";

            if (idInventario.HasValue)
            {
                var dsInv = b.Consultar($"SELECT 1 FROM inventario WHERE IdInventario = {idInventario.Value}", "tmp");
                if (dsInv != null && dsInv.Tables.Count > 0 && dsInv.Tables[0].Rows.Count > 0)
                    inv = idInventario.Value.ToString();
            }

            if (idProyecto.HasValue)
            {
                var dsProj = b.Consultar($"SELECT 1 FROM ProyectosPendientes WHERE IdProyecto = {idProyecto.Value}", "tmp");
                if (dsProj != null && dsProj.Tables.Count > 0 && dsProj.Tables[0].Rows.Count > 0)
                    proj = idProyecto.Value.ToString();
            }

            b.Comando($"INSERT INTO NotificacionesSistema (TipoNotificacion, IdInventarioRelacionado, IdProyectoRelacionado, Mensaje) VALUES ('{tipo.Replace("'", "''")}', {inv}, {proj}, '{safe}')");
        }
        public int ContarNoLeidas()
        {
            var ds = b.Consultar("SELECT COUNT(*) AS c FROM NotificacionesSistema WHERE Leida = 0", "tmp");
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(ds.Tables[0].Rows[0]["c"]);
            return 0;
        }

        // Programadas
        public void CrearNotificacionProgramada(DateTime fechaNotificacion, string aviso)
        {
            string safe = (aviso ?? "").Replace("'", "''");
            b.Comando($"INSERT INTO NotificacionesProgramadas (FechaNotificacion, Aviso) VALUES ('{fechaNotificacion.ToString("yyyy-MM-dd HH:mm:ss")}', '{safe}')");
        }

        public void MarcarProgramadaCompletada(int id)
        {
            if (id <= 0) return;
            b.Comando($"UPDATE NotificacionesProgramadas SET Completada = 1 WHERE IdNotificacion = {id}");
        }
        // Generar notificaciones de stock bajo manualmente desde la app (evita duplicados del día)
        public void GenerarNotificacionesStockBajoManuales()
        {
            var ds = b.Consultar(@"
                SELECT IdInventario, NombreProducto, StockActual, StockMinimo, UnidadMedida
                FROM inventario
                WHERE StockActual <= StockMinimo
            ", "inv");

            if (ds == null || ds.Tables.Count == 0) return;
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                int idInv = Convert.ToInt32(r["IdInventario"]);
                var existe = b.Consultar($"SELECT 1 FROM NotificacionesSistema WHERE IdInventarioRelacionado = {idInv} AND TipoNotificacion = 'STOCK_BAJO' AND DATE(FechaGeneracion) = CURDATE()", "tmp");
                if (existe != null && existe.Tables.Count > 0 && existe.Tables[0].Rows.Count > 0) continue;

                string msg = $"ALERTA: El producto \"{r["NombreProducto"]}\" ha alcanzado el stock mínimo. Stock actual: {r["StockActual"]} {r["UnidadMedida"]} (Mínimo: {r["StockMinimo"]})";
                CrearNotificacionSistema("STOCK_BAJO", idInv, null, msg);
            }
        }
        public void EliminarProgramada(int id)
        {
            if (id <= 0) return;
            b.Comando($"DELETE FROM NotificacionesProgramadas WHERE IdNotificacion = {id}");
        }
    }
}
