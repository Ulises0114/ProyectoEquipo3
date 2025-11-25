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
            string filtro = TxtBuscarPresupuesto.Text.Trim();
            string consulta;

            if (string.IsNullOrWhiteSpace(filtro))
            {
                consulta = "SELECT * FROM vista_presupuestos";
            }
            else
            {
                consulta = $"SELECT * FROM vista_presupuestos " +
                          $"WHERE NombreMueble LIKE '%{filtro}%' " +
                          $"OR EstadoPresupuesto LIKE '%{filtro}%'";
            }

            mp.Mostrar(consulta, DgvPresupuesto, "Presupuestos");
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            presupuesto = new Presupuesto();
            FrmDatosPresupuestos dp = new FrmDatosPresupuestos();
            dp.ShowDialog();
            ActualizarGrid();
        }

        private void DgvPresupuesto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                int filaActual = e.RowIndex;
                string nombreColumna = DgvPresupuesto.Columns[e.ColumnIndex].Name;

                // Cargar datos del presupuesto seleccionado
                presupuesto.IdPresupuesto = Convert.ToInt32(DgvPresupuesto.Rows[filaActual].Cells["IdPresupuesto"].Value);
                presupuesto.IdProyecto = Convert.ToInt32(DgvPresupuesto.Rows[filaActual].Cells["IdProyecto"].Value);
                presupuesto.NombreMueble = DgvPresupuesto.Rows[filaActual].Cells["NombreMueble"].Value.ToString();
                presupuesto.CostoMaterial = Convert.ToDouble(DgvPresupuesto.Rows[filaActual].Cells["CostoMaterial"].Value);
                presupuesto.CostoManoObra = Convert.ToDouble(DgvPresupuesto.Rows[filaActual].Cells["CostoManoObra"].Value);
                presupuesto.CostoTotal = Convert.ToDouble(DgvPresupuesto.Rows[filaActual].Cells["CostoTotal"].Value);
                presupuesto.EstadoPresupuesto = DgvPresupuesto.Rows[filaActual].Cells["EstadoPresupuesto"].Value.ToString();

                if (nombreColumna == "btnModificar")
                {
                    FrmDatosPresupuestos dp = new FrmDatosPresupuestos();
                    dp.ShowDialog();
                    ActualizarGrid();
                }
                else if (nombreColumna == "btnBorrar")
                {
                    mp.Borrar(presupuesto);
                    ActualizarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarGrid()
        {
            string consulta = "SELECT * FROM vista_presupuestos ORDER BY FechaCreacion DESC";
            mp.Mostrar(consulta, DgvPresupuesto, "Presupuestos");
        }
    }
}
