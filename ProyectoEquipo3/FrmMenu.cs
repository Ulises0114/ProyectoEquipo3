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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.ShowDialog();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FrmInventario frmInventario = new FrmInventario();
            frmInventario.ShowDialog();
        }

        private void btnProyectos_Click(object sender, EventArgs e)
        {
            FrmProyectos frmProyectos = new FrmProyectos();
            frmProyectos.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FrmProveedores frmProveedores = new FrmProveedores();
            frmProveedores.ShowDialog();
        }

        private void btnNotifiaciones_Click(object sender, EventArgs e)
        {
            FrmNotificaciones frmNotificaciones = new FrmNotificaciones();
            frmNotificaciones.ShowDialog();
        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            Frm_Presupuesto frmPresupuesto = new Frm_Presupuesto();
            frmPresupuesto.ShowDialog();
        }
    }
}
