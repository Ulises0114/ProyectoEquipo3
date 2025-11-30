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
            frmUsuarios.Show();
            this.Hide();
            //Close();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FrmInventario frmInventario = new FrmInventario();
            frmInventario.Show();
            this.Hide();
            //Close();
        }

        private void btnProyectos_Click(object sender, EventArgs e)
        {
            FrmProyectos frmProyectos = new FrmProyectos();
            frmProyectos.Show();
            this.Hide();
            //Close();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FrmProveedores frmProveedores = new FrmProveedores();
            frmProveedores.Show();
            this.Hide();
            //Close();
        }

        private void btnNotifiaciones_Click(object sender, EventArgs e)
        {
            FrmNotificaciones frmNotificaciones = new FrmNotificaciones();
            frmNotificaciones.Show();
            this.Hide();
            //Close();
        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            Frm_Presupuesto frmPresupuesto = new Frm_Presupuesto();
            frmPresupuesto.Show();
            this.Hide();
            //Close();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            LblBienvenido.Text = "Bienvenido " + Entidades.Usuarios.UsuarioLogueadoNombre;
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
