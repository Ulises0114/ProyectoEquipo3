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
        Base b = new Base("127.0.0.1", "3308", "root", "12345", "CarpinteriaDB");

        public void Guardar(Presupuesto presupuesto)
        {
            var listaParams = new List<MySqlParameter>();
            listaParams.Add(new MySqlParameter("_IdProyecto", presupuesto.IdProyecto));
            listaParams.Add(new MySqlParameter("_CostoMaterial", presupuesto.CostoMaterial));
            listaParams.Add(new MySqlParameter("_CostoManoObra", presupuesto.CostoManoObra));
            listaParams.Add(new MySqlParameter("_EstadoPresupuesto", presupuesto.EstadoPresupuesto));

            b.EjecutarSP("sp_GuardarPresupuesto", listaParams);
        }

        public void Borrar(Presupuesto presupuesto)
        {
            var rs = MessageBox.Show($"¿Está seguro de eliminar el presupuesto ID {presupuesto.IdPresupuesto}?",
                                     "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                var listaParams = new List<MySqlParameter>();
                listaParams.Add(new MySqlParameter("_IdPresupuesto", presupuesto.IdPresupuesto));

                b.EjecutarSP("sp_BorrarPresupuesto", listaParams);
            }
        }

        public void Modificar(Presupuesto presupuesto)
        {
            var listaParams = new List<MySqlParameter>();
            listaParams.Add(new MySqlParameter("_IdPresupuesto", presupuesto.IdPresupuesto));
            listaParams.Add(new MySqlParameter("_IdProyecto", presupuesto.IdProyecto));
            listaParams.Add(new MySqlParameter("_CostoMaterial", presupuesto.CostoMaterial));
            listaParams.Add(new MySqlParameter("_CostoManoObra", presupuesto.CostoManoObra));
            listaParams.Add(new MySqlParameter("_EstadoPresupuesto", presupuesto.EstadoPresupuesto));

            b.EjecutarSP("sp_ModificarPresupuesto", listaParams);
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

            tabla.Columns.Insert(tabla.Columns.Count, Boton("Modificar", Color.Green));
            tabla.Columns.Insert(tabla.Columns.Count, Boton("Borrar", Color.Red));

            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public static DataGridViewButtonColumn Boton(string Titulo, Color fondo)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = Titulo;
            btn.Name = "btn" + Titulo;
            btn.UseColumnTextForButtonValue = true;
            btn.FlatStyle = FlatStyle.Popup;
            btn.DefaultCellStyle.BackColor = fondo;
            btn.DefaultCellStyle.ForeColor = Color.White;
            return btn;
        }

        public void LlenarProyectos(ComboBox caja)
        {
            caja.DataSource = b.Consultar("SELECT IdProyecto, NombreMueble FROM ProyectosPendientes", "ProyectosPendientes").Tables[0];
            caja.DisplayMember = "NombreMueble";
            caja.ValueMember = "IdProyecto";
        }
    }
}