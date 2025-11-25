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
        public static Proyectos proyecto;
        int fila = 0, columna = 0;

        public FrmProyectos()
        {
            InitializeComponent();
            mp = new ManejadorProyectos();

            InicializarFiltros();
            CargarDatos();
            ActualizarContadores();
        }

        private void InicializarFiltros()
        {
            CmbFiltrar.Items.Clear();
            CmbFiltrar.Items.Add("Todos");
            CmbFiltrar.Items.Add("Pendiente");
            CmbFiltrar.Items.Add("En Proceso");
            CmbFiltrar.Items.Add("Pausado");
            CmbFiltrar.Items.Add("Completado");
            CmbFiltrar.Items.Add("Cancelado");
            CmbFiltrar.SelectedIndex = 0;
        }

        private void CargarDatos()
        {
            mp.Filtrar(CmbFiltrar, DtgDatos, "ProyectosPendientes");
            ActualizarContadores();
        }

        private void ActualizarContadores()
        {
            try
            {
                int pendientes = mp.Conteo("Pendiente");
                int enProceso = mp.Conteo("En Proceso");
                int pausados = mp.Conteo("Pausado");

                BtnPendientes.Text = $"Órdenes pendientes\n{pendientes}";
                BtnUrgentes.Text = $"Órdenes urgentes\n{enProceso}";
                BtnAtrasadas.Text = $"Órdenes atrasadas\n{pausados}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar contadores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                fila = e.RowIndex;
                columna = e.ColumnIndex;
            }
        }

        private void BtnPrueba_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            proyecto = new Proyectos(0, "", "Pendiente", null, null);
            FrmDatosProyectos fdp = new FrmDatosProyectos();
            fdp.ShowDialog();
            CargarDatos();
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                fila = e.RowIndex;
                columna = e.ColumnIndex;

                int idProyecto = Convert.ToInt32(DtgDatos.Rows[fila].Cells["No_Orden"].Value);
                string nombreMueble = DtgDatos.Rows[fila].Cells["Mueble"].Value.ToString();
                string estadoProyecto = DtgDatos.Rows[fila].Cells["Estado_Proyecto"].Value.ToString();

                DateTime? fechaEstimada = null;
                if (DtgDatos.Rows[fila].Cells["Fecha_Estimada"].Value != DBNull.Value)
                {
                    fechaEstimada = Convert.ToDateTime(DtgDatos.Rows[fila].Cells["Fecha_Estimada"].Value);
                }

                DateTime? fechaCreacion = mp.ObtenerFechaCreacion(idProyecto);

                proyecto = new Proyectos(idProyecto, nombreMueble, estadoProyecto, fechaCreacion, fechaEstimada);

                int totalColumnas = DtgDatos.Columns.Count;

                if (columna == totalColumnas - 2) // Botón Modificar
                {
                    FrmDatosProyectos fdp = new FrmDatosProyectos();
                    fdp.ShowDialog();
                    CargarDatos();
                }
                else if (columna == totalColumnas - 1) // Botón Borrar
                {
                    mp.Borrar(proyecto);
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar la selección: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPendientes_Click(object sender, EventArgs e)
        {
            CmbFiltrar.Text = "Pendiente";
            CargarDatos();
        }

        private void BtnUrgentes_Click(object sender, EventArgs e)
        {
            CmbFiltrar.Text = "En Proceso";
            CargarDatos();
        }

        private void BtnAtrasadas_Click(object sender, EventArgs e)
        {
            CmbFiltrar.Text = "Pausado";
            CargarDatos();
        }

        private void CmbFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void FrmProyectos_Load(object sender, EventArgs e)
        {
            DtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtgDatos.MultiSelect = false;
            DtgDatos.AllowUserToAddRows = false;
            DtgDatos.AllowUserToDeleteRows = false;
            DtgDatos.ReadOnly = true;
        }
    }
}
