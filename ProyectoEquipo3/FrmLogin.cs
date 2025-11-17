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
                FrmMenu frm = new FrmMenu();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
