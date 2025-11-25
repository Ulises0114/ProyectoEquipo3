using AccesoDatos;
using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorProyectos
    {
        Base b = new Base("localhost", "root", "12345", "CarpinteriaDB");

        public string GuardarProyecto(Proyectos proyecto)
        {
            try
            {
                string fecha = proyecto.FechaEstimadaFin.HasValue
                    ? proyecto.FechaEstimadaFin.Value.ToString("yyyy-MM-dd")
                    : "NULL";

                string consulta;
                if (proyecto.FechaEstimadaFin.HasValue)
                {
                    consulta = $"CALL p_agregar_proyecto_nuevo('{proyecto.NombreMueble}', " +
                              $"'{proyecto.EstadoProyecto}', '{fecha}');";
                }
                else
                {
                    consulta = $"CALL p_agregar_proyecto_nuevo('{proyecto.NombreMueble}', " +
                              $"'{proyecto.EstadoProyecto}', NULL);";
                }

                var dt = b.Consultar(consulta, "proyecto").Tables[0];

                if (dt.Rows.Count > 0)
                {
                    int idProyecto = Convert.ToInt32(dt.Rows[0]["IdProyecto"]);
                    return "OK|" + idProyecto;
                }
                else
                {
                    return "ERROR|No se pudo obtener el ID del proyecto";
                }
            }
            catch (Exception ex)
            {
                return "ERROR|" + ex.Message;
            }
        }

        public string AgregarMaterialAProyecto(int idProyecto, ProyectoMaterial material)
        {
            try
            {
                b.Comando($"CALL p_agregar_material_proyecto({idProyecto}, " +
                         $"{material.IdMaterial}, {material.CantidadRequerida}, " +
                         $"'{material.UnidadMedida}');");
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string EliminarMaterialDeProyecto(int idProyectoMaterial)
        {
            try
            {
                b.Comando($"CALL p_eliminar_material_proyecto({idProyectoMaterial});");
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public DataTable ObtenerMaterialesProyecto(int idProyecto)
        {
            string consulta = $@"SELECT pm.IdProyectoMaterial, pm.IdMaterial, i.NombreProducto as Material, pm.CantidadRequerida as Cantidad, pm.UnidadMedida as Unidad FROM ProyectoMateriales pm JOIN inventario i ON pm.IdMaterial = i.IdInventario WHERE pm.IdProyecto = {idProyecto}";
            return b.Consultar(consulta, "materiales").Tables[0];
        }

        public void Borrar(Proyectos proyecto)
        {
            var rs = MessageBox.Show($"¿Está seguro de eliminar el proyecto {proyecto.NombreMueble}?\n Esto devolverá todos los materiales al inventario.", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                // Al eliminar el proyecto, el CASCADE devolverá los materiales automáticamente
                b.Comando($"DELETE FROM ProyectosPendientes WHERE IdProyecto={proyecto.IdProyecto}");
                MessageBox.Show("Proyecto eliminado correctamente");
            }
        }

        public string Modificar(Proyectos proyecto)
        {
            try
            {
                string fecha = proyecto.FechaEstimadaFin.HasValue ? proyecto.FechaEstimadaFin.Value.ToString("yyyy-MM-dd") : "NULL";
                b.Comando($"CALL p_modificar_proyecto_nuevo({proyecto.IdProyecto}, '{proyecto.NombreMueble}', '{proyecto.EstadoProyecto}', '{fecha}');");
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public DateTime? ObtenerFechaCreacion(int idProyecto)
        {
            try
            {
                var dt = b.Consultar($"SELECT FechaCreacion FROM ProyectosPendientes WHERE IdProyecto = {idProyecto}", "temp").Tables[0];

                if (dt.Rows.Count > 0 && dt.Rows[0]["FechaCreacion"] != DBNull.Value)
                {
                    return Convert.ToDateTime(dt.Rows[0]["FechaCreacion"]);
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        public void Filtrar(ComboBox seleccion, DataGridView tabla, string datos)
        {
            string consulta;

            if (string.IsNullOrWhiteSpace(seleccion?.Text) || seleccion.Text == "Todos")
            {
                // Mostrar todos los proyectos sin filtro
                consulta = "SELECT * FROM vista_proyectos_basicos;";
            }
            else
            {
                // Filtrar por el estado seleccionado
                consulta = $"SELECT * FROM vista_proyectos_basicos WHERE Estado_Proyecto = '{seleccion.Text}';";
            }

            Mostrar(consulta, tabla, datos);
        }

        public int Conteo(string estado)
        {
            try
            {
                var dt = b.Consultar($"SELECT COUNT(*) as Total FROM vista_proyectos_basicos " +
                                   $"WHERE Estado_Proyecto = '{estado}';", "conteo").Tables[0];
                return Convert.ToInt32(dt.Rows[0]["Total"]);
            }
            catch
            {
                return 0;
            }
        }
        public void Mostrar(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.Columns.Add(Boton("Modificar", Color.Orange));
            tabla.Columns.Add(Boton("Borrar", Color.Red));

            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public static DataGridViewButtonColumn Boton(string titulo, Color fondo)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = titulo;
            btn.UseColumnTextForButtonValue = true;
            btn.FlatStyle = FlatStyle.Popup;
            btn.DefaultCellStyle.BackColor = fondo;
            btn.DefaultCellStyle.ForeColor = Color.White;
            return btn;
        }

        public void LlenarMateriales(ComboBox caja)
        {
            caja.DataSource = b.Consultar("SELECT IdInventario, NombreProducto, UnidadMedida FROM inventario WHERE StockActual > 0", "inventario").Tables[0];
            caja.DisplayMember = "NombreProducto";
            caja.ValueMember = "IdInventario";
        }
    }
}
