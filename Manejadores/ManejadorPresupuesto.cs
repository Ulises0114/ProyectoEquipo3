using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Manejador
{
    public class ManejadorPresupuesto
    {
        Base b = new Base("localhost", "root", "12345", "CarpinteriaDB");

        public string GenerarPresupuesto(int idProyecto, string estado = "Pendiente")
        {
            try
            {
                b.Comando($"CALL sp_GenerarPresupuesto({idProyecto}, '{estado}');");
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string ModificarEstado(int idPresupuesto, string estado)
        {
            try
            {
                b.Comando($"CALL sp_ModificarEstadoPresupuesto({idPresupuesto}, '{estado}');");
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public void Borrar(Presupuesto presupuesto)
        {
            var rs = MessageBox.Show($"¿Está seguro de eliminar el presupuesto del proyecto '{presupuesto.NombreMueble}'?",
                                     "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    b.Comando($"CALL sp_BorrarPresupuesto({presupuesto.IdPresupuesto});");
                    MessageBox.Show("Presupuesto eliminado correctamente", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Mostrar(string consulta, DataGridView tabla, string nombreTablaDataSet)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, nombreTablaDataSet).Tables[0];

            if (tabla.Columns.Contains("IdPresupuesto"))
                tabla.Columns["IdPresupuesto"].Visible = false;
            if (tabla.Columns.Contains("IdProyecto"))
                tabla.Columns["IdProyecto"].Visible = false;
            if (tabla.Columns.Contains("FechaCreacion"))
                tabla.Columns["FechaCreacion"].Visible = false;
            if (tabla.Columns.Contains("FechaActualizacion"))
                tabla.Columns["FechaActualizacion"].Visible = false;

            // Formatear columnas de dinero
            if (tabla.Columns.Contains("CostoMaterial"))
            {
                tabla.Columns["CostoMaterial"].DefaultCellStyle.Format = "C2";
                tabla.Columns["CostoMaterial"].HeaderText = "Costo Material";
            }
            if (tabla.Columns.Contains("CostoManoObra"))
            {
                tabla.Columns["CostoManoObra"].DefaultCellStyle.Format = "C2";
                tabla.Columns["CostoManoObra"].HeaderText = "Costo Mano de Obra";
            }
            if (tabla.Columns.Contains("CostoTotal"))
            {
                tabla.Columns["CostoTotal"].DefaultCellStyle.Format = "C2";
                tabla.Columns["CostoTotal"].HeaderText = "Costo Total";
                tabla.Columns["CostoTotal"].DefaultCellStyle.Font = new Font(tabla.Font, FontStyle.Bold);
            }

            tabla.Columns.Add(Boton("Modificar", Color.Orange));
            tabla.Columns.Add(Boton("Borrar", Color.Red));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public static DataGridViewButtonColumn Boton(string titulo, Color fondo)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = titulo;
            btn.Name = "btn" + titulo;
            btn.UseColumnTextForButtonValue = true;
            btn.FlatStyle = FlatStyle.Flat;
            btn.DefaultCellStyle.BackColor = fondo;
            btn.DefaultCellStyle.ForeColor = Color.White;
            return btn;
        }

        public void LlenarProyectos(ComboBox caja)
        {
            // Solo mostrar proyectos que NO tengan presupuesto
            string consulta = @"SELECT pp.IdProyecto, pp.NombreMueble 
                           FROM ProyectosPendientes pp
                           LEFT JOIN Presupuestos p ON pp.IdProyecto = p.IdProyecto
                           WHERE p.IdPresupuesto IS NULL";

            caja.DataSource = b.Consultar(consulta, "ProyectosSinPresupuesto").Tables[0];
            caja.DisplayMember = "NombreMueble";
            caja.ValueMember = "IdProyecto";
        }

        public DataTable ObtenerDetallePresupuesto(int idProyecto)
        {
            string consulta = $@"SELECT 
            i.NombreProducto as Material,
            pm.CantidadRequerida as Cantidad,
            pm.UnidadMedida as Unidad,
            i.PrecioCompra as 'Precio Unitario',
            (pm.CantidadRequerida * i.PrecioCompra) as Subtotal
            FROM ProyectoMateriales pm
            JOIN inventario i ON pm.IdMaterial = i.IdInventario
            WHERE pm.IdProyecto = {idProyecto}";

            return b.Consultar(consulta, "detalle").Tables[0];
        }
    }
}