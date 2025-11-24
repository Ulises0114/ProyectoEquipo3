using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;
using Entidades;

namespace ProyectoEquipo3
{
    public partial class FrmProyectos : Form
    {
        ManejadorProyectos mp;
        public static Proyectos proyecto = new Proyectos(0, "", 0, 0, "", "", "", "");
        int fila = 0, columna = 0;
        string cant = "";
        
        public FrmProyectos()
        {
            InitializeComponent();
            mp = new ManejadorProyectos();
            BtnPendientes.Text = $"Ordenes pendientes";
            BtnUrgentes.Text = $"Ordenes urgentes";
            BtnAtrasadas.Text = $"Ordenes atrasadas";
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
        }

        private void BtnPrueba_Click(object sender, EventArgs e)
        {
            mp.Filtrar(CmbFiltrar, DtgDatos, "ProyectosPendientes");
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            proyecto.IdProyecto = 0; proyecto.NombreMueble = "";
            proyecto.IdMaterial = 0; proyecto.CantidadRequerida = 0;
            proyecto.UnidadMedida = ""; proyecto.EstadoProyecto = "";
            proyecto.FechaCreacion = ""; proyecto.FechaEstimadaFin = "";
            FrmDatosProyectos fdp = new FrmDatosProyectos();
            fdp.ShowDialog();
            DtgDatos.Columns.Clear();
        }

        private void DtgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*proyecto.IdProyecto = int.Parse(DtgDatos.Rows[fila].Cells[0].Value.ToString());
            proyecto.NombreMueble = DtgDatos.Rows[fila].Cells["Mueble"].Value.ToString();
            proyecto.IdMaterial = int.Parse(DtgDatos.Rows[fila].Cells["Material"].Value.ToString());
            proyecto.CantidadRequerida = int.Parse(DtgDatos.Rows[fila].Cells["Cantidad"].Value.ToString());
            proyecto.UnidadMedida = DtgDatos.Rows[fila].Cells["Unidad"].Value.ToString();

            switch (columna)
            {
                case 5:
                    {
                        FrmDatosProyectos fdp = new FrmDatosProyectos();
                        fdp.ShowDialog();
                        DtgDatos.Columns.Clear();
                    }
                    ; break;
                case 6:
                    {
                        mp.Borrar(proyecto);
                        DtgDatos.Columns.Clear();
                    }
                    ; break;
            }*/
        }

        private void BtnPendientes_Click(object sender, EventArgs e)
        {
            //Aqui no va nada xd
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            proyecto.IdProyecto = int.Parse(DtgDatos.Rows[fila].Cells[0].Value.ToString());
            proyecto.NombreMueble = DtgDatos.Rows[fila].Cells[0].Value.ToString();
            proyecto.IdMaterial = int.Parse(DtgDatos.Rows[fila].Cells[0].Value.ToString());
            proyecto.CantidadRequerida = int.Parse(DtgDatos.Rows[fila].Cells[0].Value.ToString());
            proyecto.UnidadMedida = DtgDatos.Rows[fila].Cells[0].Value.ToString();
            proyecto.EstadoProyecto = DtgDatos.Rows[fila].Cells[0].Value.ToString();

            switch (columna)
            {
                case 6:
                    {
                        FrmDatosProyectos fdp = new FrmDatosProyectos();
                        fdp.ShowDialog();
                        DtgDatos.Columns.Clear();
                    }
                    ; break;
                case 7:
                    {
                        mp.Borrar(proyecto);
                        DtgDatos.Columns.Clear();
                    }
                    ; break;
            }
        }
    }
}
