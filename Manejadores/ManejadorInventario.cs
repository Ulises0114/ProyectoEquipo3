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
    public class ManejadorInventario
    {
        // Si CarpinteriaDB está en Docker y mapeada a 3308
        Base b = new Base("127.0.0.1;port=3308", "root", "12345", "CarpinteriaDB");
        public void Guardar(Inventarios inventario)
        {
            string imagePath = string.IsNullOrWhiteSpace(inventario.ImagePath) ? "" : inventario.ImagePath.Replace("'", "''");
            b.Comando($"CALL sp_AgregarInventario('{inventario.NombreProducto}','{inventario.IdProveedor}','{inventario.UnidadMedida}','{inventario.PrecioCompra}','{inventario.FechaIngreso}','{inventario.StockMinimo}','{inventario.StockActual}','{inventario.Descripcion}','{imagePath}')");
        }
        public void ActualizarImagePath(int idInventario, string imageFileName)
        {
            // Guardar solo el nombre del archivo; puedes cambiar a ruta relativa si prefieres
            string safe = imageFileName.Replace("'", "''"); // escapado básico
            b.Comando($"UPDATE inventario SET ImagePath = '{safe}' WHERE IdInventario = {idInventario}");
        }
        public void Borrar(Inventarios inventario)
        {
            var rs = MessageBox.Show($"Esta seguro de eliminar la pieza {inventario.NombreProducto}",
                "ATENCIÓN!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                b.Comando($"delete from inventario where IdInventario={inventario.IdInventario}");
            }
        }
        public void Modificar(Inventarios inventario)
        {
            string imagePath = string.IsNullOrWhiteSpace(inventario.ImagePath) ? "" : inventario.ImagePath.Replace("'", "''");
            b.Comando($"update inventario set NombreProducto='{inventario.NombreProducto}', IdProveedor='{inventario.IdProveedor}', UnidadMedida='{inventario.UnidadMedida}', PrecioCompra='{inventario.PrecioCompra}', FechaIngreso='{inventario.FechaIngreso}', StockMinimo='{inventario.StockMinimo}', StockActual='{inventario.StockActual}', Descripcion='{inventario.Descripcion}', ImagePath='{imagePath}' " +
              $"where IdInventario={inventario.IdInventario}");
        }
        public void Mostrar(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.Columns["IdInventario"].Visible = false;
            //tabla.Columns.Insert(10, Boton("Modificar", Color.Green));
            //tabla.Columns.Insert(11, Boton("Borrar", Color.Red));
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
        public DataTable ListarProductosParaGaleria()
        {
            var ds = b.Consultar("SELECT IdInventario, NombreProducto, StockActual, ImagePath FROM inventario", "inventario");
            if (ds != null && ds.Tables.Count > 0)
                return ds.Tables[0];
            return new DataTable();
        }
        public int AgregarInventarioYObtenerId(Inventarios inv)
        {
            // Llama al SP que ya tienes (sp_AgregarInventario)
            b.Comando($"CALL sp_AgregarInventario('{inv.NombreProducto}','{inv.IdProveedor}','{inv.UnidadMedida}','{inv.PrecioCompra}','{inv.FechaIngreso}','{inv.StockMinimo}','{inv.StockActual}','{inv.Descripcion}')");
            // Obtener LAST_INSERT_ID()
            var ds = b.Consultar("SELECT LAST_INSERT_ID() AS Id", "tmp");
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                int id;
                if (int.TryParse(ds.Tables[0].Rows[0]["Id"].ToString(), out id))
                    return id;
            }
            return 0;
        }
        public void LlenarComboProveedores(ComboBox combo)
        {
            combo.DataSource = b.Consultar("SELECT IdProveedor, NombreProveedor FROM Proveedores", "Proveedores").Tables[0];
            combo.DisplayMember = "NombreProveedor";
            combo.ValueMember = "IdProveedor";
        }
        public Inventarios ObtenerPorId(int id)
        {
            if (id <= 0) return null;

            // Consulta simple: id es entero, no debe permitir inyección en este caso
            var ds = b.Consultar($"SELECT * FROM inventario WHERE IdInventario = {id}", "inventario");
            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;

            var row = ds.Tables[0].Rows[0];

            // Extraer cada campo con comprobaciones para evitar excepciones
            int idInventario = row.Table.Columns.Contains("IdInventario") && row["IdInventario"] != DBNull.Value
                ? Convert.ToInt32(row["IdInventario"])
                : 0;

            string nombre = row.Table.Columns.Contains("NombreProducto") && row["NombreProducto"] != DBNull.Value
                ? row["NombreProducto"].ToString()
                : string.Empty;

            int idProveedor = row.Table.Columns.Contains("IdProveedor") && row["IdProveedor"] != DBNull.Value
                ? Convert.ToInt32(row["IdProveedor"])
                : 0;

            string unidadMedida = row.Table.Columns.Contains("UnidadMedida") && row["UnidadMedida"] != DBNull.Value
                ? row["UnidadMedida"].ToString()
                : string.Empty;

            decimal precioCompra = 0m;
            if (row.Table.Columns.Contains("PrecioCompra") && row["PrecioCompra"] != DBNull.Value)
                decimal.TryParse(row["PrecioCompra"].ToString(), out precioCompra);

            string fechaIngreso = row.Table.Columns.Contains("FechaIngreso") && row["FechaIngreso"] != DBNull.Value
                ? row["FechaIngreso"].ToString()
                : string.Empty;

            decimal stockMinimo = 0m;
            if (row.Table.Columns.Contains("StockMinimo") && row["StockMinimo"] != DBNull.Value)
                decimal.TryParse(row["StockMinimo"].ToString(), out stockMinimo);

            decimal stockActual = 0m;
            if (row.Table.Columns.Contains("StockActual") && row["StockActual"] != DBNull.Value)
                decimal.TryParse(row["StockActual"].ToString(), out stockActual);

            string descripcion = row.Table.Columns.Contains("Descripcion") && row["Descripcion"] != DBNull.Value
                ? row["Descripcion"].ToString()
                : string.Empty;

            string imagePath = row.Table.Columns.Contains("ImagePath") && row["ImagePath"] != DBNull.Value
                ? row["ImagePath"].ToString()
                : string.Empty;

            // Crear y retornar el objeto
            return new Inventarios(
                idInventario,
                nombre,
                idProveedor,
                unidadMedida,
                precioCompra,
                fechaIngreso,
                stockMinimo,
                stockActual,
                descripcion,
                imagePath
            );
        }
    }
}
