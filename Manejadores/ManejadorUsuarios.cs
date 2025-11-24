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
            b.Comando($"insert into Usuarios VALUES(null, '{usuario.NombreUsuario}','{ManejadorLogin.Sha1(usuario.Contrasena)}', '{usuario.Telefono}','{usuario.Puesto}',true ,NULL);");
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

        public void Editar(Usuarios usuario)
        {
            b.Comando($"update Usuarios set NombreUsuario = '{usuario.NombreUsuario}', Clave = '{ManejadorLogin.Sha1(usuario.Contrasena)}', Telefono = '{usuario.Telefono}', Puesto = '{usuario.Puesto}' where IdUsuario = {usuario.IdUsuario}");
        }

        public void Mostrar(string query, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(query, datos).Tables[0];
            tabla.Columns["IdUsuario"].Visible = false;
            tabla.Columns["Clave"].Visible = false;
            tabla.Columns["FechaRegistro"].Visible = false;
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
