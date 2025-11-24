using AccesoDatos;
using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorProyectos
    {
        Base b = new Base("localhost", "root", "12345", "CarpinteriaDB", 3308);
        public void Guardar(Proyectos proyecto)
        {
            b.Comando($"CALL p_agregar_proyecto('{proyecto.NombreMueble}',{proyecto.IdMaterial},'{proyecto.CantidadRequerida}','{proyecto.UnidadMedida}','{proyecto.EstadoProyecto}'," +
                $"'{proyecto.FechaEstimadaFin}');");
        }
        public void Borrar(Proyectos proyecto)
        {
            var rs = MessageBox.Show($"Esta seguro de eliminar la orden No. {proyecto.NombreMueble}",
                "ATENCIÓN!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                b.Comando($"delete from ProyectosPendientes where IdProyecto={proyecto.IdProyecto}");
            }
        }
        public void Modificar(Proyectos proyecto)
        {
            b.Comando($"CALL p_modificar_proyecto('{proyecto.IdProyecto}','{proyecto.NombreMueble}','{proyecto.CantidadRequerida}','{proyecto.UnidadMedida}','{proyecto.EstadoProyecto}'," +
                $"'{proyecto.FechaEstimadaFin}');");
        }
        public void Filtrar(ComboBox seleccion, DataGridView tabla, string datos)
        {
            if (string.IsNullOrWhiteSpace(seleccion?.Text))
            {
                Mostrar($"SELECT * FROM vista_proyectos_basicos;", tabla, datos);
            }
            else
            {
                Mostrar($"SELECT * FROM vista_proyectos_basicos WHERE `Estado Proyecto` = '{seleccion.Text}';", tabla, datos);
            }   
        }
        public void Conteo(Button bt)
        {
            b.Comando($"SELECT COUNT(*) FROM vista_proyectos_basicos WHERE `Estado Proyecto` = 'Pendiente';"); //Aqui ya no supe xd
        }
        public void Mostrar(string consulta, DataGridView tabla, string datos)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar(consulta, datos).Tables[0];
            tabla.Columns.Insert(6, Boton("Modificar", Color.Orange));
            tabla.Columns.Insert(7, Boton("Borrar", Color.Red));
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
        public void LlenarLugares(ComboBox caja)
        {
            caja.DataSource = b.Consultar("SELECT IdInventario,NombreProducto FROM Inventario", "Inventario").Tables[0];
            caja.DisplayMember = "NombreProducto";
            caja.ValueMember = "IdInventario";
        }
    }
}
