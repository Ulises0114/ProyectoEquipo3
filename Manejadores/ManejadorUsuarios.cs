using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Entidades;

namespace Manejadores
{
    public class ManejadorUsuarios
    {
        Base b = new Base("localhost", "root", "12345", "CarpinteriaDB");
        public void Guardar(Usuarios usuario)
        {
            b.Comando($"insert into usuarios values(null, '{usuario.NombreUsuario}', '{ManejadorLogin.Sha1(usuario.Contrasena)}')");
        }

        public void Borrar(Usuarios usuario)
        {
            var rs = MessageBox.Show($"¿Estás seguro de eliminar {usuario.NombreUsuario}?",
                "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                b.Comando($"delete from usuarios where idu = {usuario.IdUsuario}");
            }
        }

        public void Editar(Usuarios usuario, bool estado)
        {
            if (estado)
            {
                b.Comando($"update usuarios set nombre = '{usuario.NombreUsuario}', clave = '{ManejadorLogin.Sha1(usuario.Contrasena)}' where idu = {usuario.IdUsuario}");
            }
            else
            {
                b.Comando($"update usuarios set nombre = '{usuario.NombreUsuario}' where idu = {usuario.IdUsuario}");
            }
        }
    
        public void Mostrar(string query, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(query, datos).Tables[0];
            tabla.Columns["idu"].Visible = false;
            tabla.Columns["clave"].Visible = false;

            tabla.Columns.Insert(2, Boton("Editar", Color.Green));
            tabla.Columns.Insert(3, Boton("Eliminar", Color.Red));

            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public static DataGridViewButtonColumn Boton(string titulo, Color color)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = titulo;
            btn.Name = titulo;
            btn.UseColumnTextForButtonValue = true;
            btn.FlatStyle = FlatStyle.Popup;
            btn.DefaultCellStyle.BackColor = color;
            btn.DefaultCellStyle.ForeColor = Color.White;
            return btn;
        }
    }
}
