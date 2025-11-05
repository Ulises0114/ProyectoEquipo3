using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Manejadores
{
    public class ManejadorProveedores
    {
        Base b = new Base("localhost", "root", "12345", "CarpinteriaDB");

        public void Guardar(Proveedores p)
        {
            b.Comando($"call InsertarProovedor('{p.NombreProveedor}','{p.Contacto}','{p.Telefono}','{p.Email}','{p.Direccion}');");
        }

        public void Borrar(Proveedores p)
        {
            var rs = MessageBox.Show($"Esta seguro de eliminar {p.IdProveedor}", "ATENCION!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                b.Comando($"delete from Proveedores where IdProveedor = {p.IdProveedor}");
            }
        }
        public void Mostrar(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.Columns["IDPiezas"].Visible = false;
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
    }
}
