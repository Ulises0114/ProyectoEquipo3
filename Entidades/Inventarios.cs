using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Inventarios
    {
        public Inventarios(int idInventario, string nombreProducto, int idProveedor, string unidadMedida, decimal precioCompra, string fechaIngreso, decimal stockMinimo, decimal stockActual, string descripcion, string imagePath)
        {
            IdInventario = idInventario;
            NombreProducto = nombreProducto;
            IdProveedor = idProveedor;
            UnidadMedida = unidadMedida;
            PrecioCompra = precioCompra;
            FechaIngreso = fechaIngreso;
            StockMinimo = stockMinimo;
            StockActual = stockActual;
            Descripcion = descripcion;
            ImagePath = imagePath;
        }

        public int IdInventario {  get; set; }
        public string NombreProducto { get; set; }
        public int IdProveedor { get; set; }
        public string UnidadMedida { get; set; }
        public decimal PrecioCompra { get; set; }
        public string FechaIngreso { get; set; }
        public decimal StockMinimo { get; set; }
        public decimal StockActual { get; set; }
        public string Descripcion { get; set; }
        public string ImagePath { get; set; }
    }
}
