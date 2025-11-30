using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejador;
using ProyectoEquipo3;

namespace ProyectoEquipo3
{
    public partial class FrmDatosPresupuestos : Form
    {
        ManejadorPresupuesto mp;
        private bool esModificacion = false;

        public FrmDatosPresupuestos()
        {
            InitializeComponent();
            mp = new ManejadorPresupuesto();

            CargarEstadosComboBox();

            // Verificar si es modificación o nuevo
            if (Frm_Presupuesto.presupuesto.IdPresupuesto > 0)
            {
                esModificacion = true;
                CargarDatosModificacion();
            }
            else
            {
                esModificacion = false;
                CargarDatosNuevo();
            }
        }

        private void CargarEstadosComboBox()
        {
            CmbEstado.Items.Clear();
            CmbEstado.Items.Add("Pendiente");
            CmbEstado.Items.Add("Aprobado");
            CmbEstado.Items.Add("En Proceso");
            CmbEstado.Items.Add("Rechazado");
            CmbEstado.Items.Add("Completado");
            CmbEstado.SelectedIndex = 0;
        }

        private void CargarDatosNuevo()
        {
            this.Text = "Generar Nuevo Presupuesto";
            mp.LlenarProyectos(CmbIdMueble);
            CmbIdMueble.SelectedIndex = -1;
            CmbIdMueble.Enabled = true;

            TxtCostoMaterial.ReadOnly = true;
            TxtCostoMaterial.BackColor = Color.LightGray;
            TxtCostoManoObra.ReadOnly = true;
            TxtCostoManoObra.BackColor = Color.LightGray;

        }

        private void CargarDatosModificacion()
        {
            this.Text = $"Modificar Presupuesto - {Frm_Presupuesto.presupuesto.NombreMueble}";

            CmbIdMueble.Enabled = false;
            CmbIdMueble.Items.Clear();
            CmbIdMueble.Items.Add(Frm_Presupuesto.presupuesto.NombreMueble);
            CmbIdMueble.SelectedIndex = 0;

            TxtCostoMaterial.Text = Frm_Presupuesto.presupuesto.CostoMaterial.ToString("F2");
            TxtCostoMaterial.ReadOnly = true;
            TxtCostoMaterial.BackColor = Color.LightGray;

            TxtCostoManoObra.Text = Frm_Presupuesto.presupuesto.CostoManoObra.ToString("F2");
            TxtCostoManoObra.ReadOnly = true;
            TxtCostoManoObra.BackColor = Color.LightGray;

            CmbEstado.Text = Frm_Presupuesto.presupuesto.EstadoPresupuesto;

        }

        private void CmbIdMueble_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbIdMueble.SelectedValue != null && !esModificacion)
            {
                try
                {
                    int idProyecto = Convert.ToInt32(CmbIdMueble.SelectedValue);
                    CalcularCostos(idProyecto);
                }
                catch { }
            }
        }

        private void CalcularCostos(int idProyecto)
        {
            try
            {
                DataTable dt = mp.ObtenerDetallePresupuesto(idProyecto);
                double costoMaterial = 0;

                foreach (DataRow row in dt.Rows)
                {
                    costoMaterial += Convert.ToDouble(row["Subtotal"]);
                }

                double costoManoObra = costoMaterial;

                TxtCostoMaterial.Text = costoMaterial.ToString("F2");
                TxtCostoManoObra.Text = costoManoObra.ToString("F2");

                if (LblTotal != null)
                {
                    LblTotal.Text = $"Total: {(costoMaterial + costoManoObra):C2}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular costos: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}