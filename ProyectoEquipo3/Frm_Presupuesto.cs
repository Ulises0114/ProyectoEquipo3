using System;
using ProyectoEquipo3;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejador;
using Entidades;

namespace ProyectoEquipo3
{
    public partial class Frm_Presupuesto : Form
    {
        ManejadorPresupuesto mp;

        public static Presupuesto presupuesto = new Presupuesto();

        public Frm_Presupuesto()
        {
            InitializeComponent();
            mp = new ManejadorPresupuesto();
            ActualizarGrid();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            string filtro = TxtBuscarPresupuesto.Text;

            string consulta = $"SELECT p.*, pp.NombreMueble FROM Presupuestos p " +
                       $"JOIN ProyectosPendientes pp ON p.IdProyecto = pp.IdProyecto " +
                       $"WHERE pp.NombreMueble LIKE '%{filtro}%'";
            mp.Mostrar(consulta, DgvPresupuesto, "Presupuestos");
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            presupuesto = new Presupuesto();

            FrmDatosPresupuestos dp = new FrmDatosPresupuestos();
            dp.ShowDialog();
            ActualizarGrid();
        }

        private void DgvPresupuesto_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DgvPresupuesto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int filaActual = e.RowIndex;
            string nombreColumna = DgvPresupuesto.Columns[e.ColumnIndex].Name;

            if (nombreColumna == "btnModificar")
            {
                presupuesto.IdPresupuesto = int.Parse(DgvPresupuesto.Rows[filaActual].Cells["IdPresupuesto"].Value.ToString());
                presupuesto.IdProyecto = int.Parse(DgvPresupuesto.Rows[filaActual].Cells["IdProyecto"].Value.ToString());
                presupuesto.CostoMaterial = double.Parse(DgvPresupuesto.Rows[filaActual].Cells["CostoMaterial"].Value.ToString());
                presupuesto.CostoManoObra = double.Parse(DgvPresupuesto.Rows[filaActual].Cells["CostoManoObra"].Value.ToString());
                presupuesto.CostoTotal = double.Parse(DgvPresupuesto.Rows[filaActual].Cells["CostoTotal"].Value.ToString());
                presupuesto.EstadoPresupuesto = DgvPresupuesto.Rows[filaActual].Cells["EstadoPresupuesto"].Value.ToString();

                FrmDatosPresupuestos dp = new FrmDatosPresupuestos();
                dp.ShowDialog();
                ActualizarGrid();
            }
            else if (nombreColumna == "btnBorrar")
            {
                presupuesto.IdPresupuesto = int.Parse(DgvPresupuesto.Rows[filaActual].Cells["IdPresupuesto"].Value.ToString());
                mp.Borrar(presupuesto);
                ActualizarGrid();
            }
        }
        private void ActualizarGrid()
        {
            string consulta = "SELECT p.*, pp.NombreMueble FROM Presupuestos p " +
                           "JOIN ProyectosPendientes pp ON p.IdProyecto = pp.IdProyecto";
            mp.Mostrar(consulta, DgvPresupuesto, "Presupuestos");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
