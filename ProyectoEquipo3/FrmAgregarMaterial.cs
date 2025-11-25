using Entidades;
using Manejadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEquipo3
{
    public partial class FrmAgregarMaterial : Form
    {
        ManejadorProyectos mp;
        private int idProyecto;
        public FrmAgregarMaterial(int idProyecto)
        {
            InitializeComponent();
            this.idProyecto = idProyecto;
            mp = new ManejadorProyectos();
            mp.LlenarMateriales(CmbMaterial);
        }

        private void CmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbMaterial.SelectedValue != null)
            {
                DataRowView drv = (DataRowView)CmbMaterial.SelectedItem;
                TxtUnidad.Text = drv["UnidadMedida"].ToString();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (CmbMaterial.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un material", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(TxtCantidad.Text, out double cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProyectoMaterial pm = new ProyectoMaterial
            {
                IdMaterial = Convert.ToInt32(CmbMaterial.SelectedValue),
                CantidadRequerida = cantidad,
                UnidadMedida = TxtUnidad.Text
            };

            string resultado = mp.AgregarMaterialAProyecto(idProyecto, pm);

            if (resultado == "OK")
            {
                MessageBox.Show("Material agregado correctamente y descontado del inventario",
                              "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
