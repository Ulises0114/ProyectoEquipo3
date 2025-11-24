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
        Base b = new Base("127.0.0.1","3308", "root", "12345", "CarpinteriaDB");


        public void Guardar(Proveedores p)
        {
            b.Comando($"call InsertarProveedor('{p.NombreProveedor}','{p.Contacto}','{p.Telefono}','{p.Email}','{p.Direccion}');");
        }

        public void Borrar(Proveedores p)
        {
                b.Comando($"delete from Proveedores where IdProveedor = {p.IdProveedor};");
        }
        public void Mostrar(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            var ds = b.Consultar(consulta, datos);
            if (ds != null && ds.Tables.Count > 0)
            {
                tabla.DataSource = ds.Tables[0];
                if (tabla.Columns.Contains("IdProveedor"))
                    tabla.Columns["IdProveedor"].Visible = true;
                tabla.AutoResizeColumns();
                tabla.AutoResizeRows();
            }
            else
            {
                // No hay datos, limpia la tabla o mostrar mensaje
                tabla.DataSource = null;
            }
        }


        public void Modificar(Proveedores p)
        {
            b.Comando($"call ModificarProveedor('{p.IdProveedor}','{p.NombreProveedor}','{p.Contacto}','{p.Telefono}','{p.Email}','{p.Direccion}');");
        }


    }
}
