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

        public FrmDatosPresupuestos()
        {
            InitializeComponent(); 
            mp = new ManejadorPresupuesto();

            mp.LlenarProyectos(CmbIdMueble);
            CargarEstadosComboBox();

            CmbIdMueble.SelectedIndex = -1;
            CmbEstado.SelectedIndex = -1;

            if (Frm_Presupuesto.presupuesto.IdPresupuesto > 0)
            {
                CmbIdMueble.SelectedValue = Frm_Presupuesto.presupuesto.IdProyecto;
                TxtCostoMaterial.Text = Frm_Presupuesto.presupuesto.CostoMaterial.ToString();
                TxtCostoManoObra.Text = Frm_Presupuesto.presupuesto.CostoManoObra.ToString();
                CmbEstado.Text = Frm_Presupuesto.presupuesto.EstadoPresupuesto;
            }
        }

        private void CargarEstadosComboBox()
        {
            CmbEstado.Items.Clear();
            CmbEstado.Items.Add("Pendiente");
            CmbEstado.Items.Add("Aprobado");
            CmbEstado.Items.Add("En Proceso");
            CmbEstado.Items.Add("Rechazado");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (CmbIdMueble.SelectedIndex == -1 || CmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un mueble y un estado.", "Error");
                return;
            }

            Presupuesto p = new Presupuesto();

            p.IdProyecto = (int)CmbIdMueble.SelectedValue;
            p.CostoMaterial = string.IsNullOrEmpty(TxtCostoMaterial.Text) ? 0 : double.Parse(TxtCostoMaterial.Text);
            p.CostoManoObra = string.IsNullOrEmpty(TxtCostoManoObra.Text) ? 0 : double.Parse(TxtCostoManoObra.Text);
            p.EstadoPresupuesto = CmbEstado.Text;

            if (Frm_Presupuesto.presupuesto.IdPresupuesto == 0)
            {
                mp.Guardar(p);
            }
            else
            {
                p.IdPresupuesto = Frm_Presupuesto.presupuesto.IdPresupuesto;
                mp.Modificar(p);
            }

            Close();
        }
    }
}