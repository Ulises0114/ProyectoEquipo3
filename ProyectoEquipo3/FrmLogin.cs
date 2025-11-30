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
using Manejadores;

namespace ProyectoEquipo3
{
    public partial class FrmLogin : Form
    {
        ManejadorLogin ml;
        public FrmLogin()
        {
            InitializeComponent();
            ml = new ManejadorLogin();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ml.Validar(txtUsuario, txtClave))
            {
                MessageBox.Show("Bienvenido al sistema", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ManejadorPermisos mp = new ManejadorPermisos();
                Usuarios.PermisosDelUsuario = mp.ObtenerPermisosPorUsuario(Usuarios.UsuarioLogueadoID);
                FrmMenu frm = new FrmMenu();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            txtClave.Text = "";
            txtClave.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            txtClave.PasswordChar = '*';
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtUsuario.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
        }
    }
}
