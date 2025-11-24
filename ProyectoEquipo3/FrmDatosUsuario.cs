using Org.BouncyCastle.Bcpg.OpenPgp;
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
    public partial class FrmDatosUsuario : Form
    {
        ManejadorUsuarios mu;
        bool edit;
        public FrmDatosUsuario(bool editar)
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
            edit = editar;
            if (FrmUsuarios.usuario.IdUsuario > 0)
            {
                txtNombre.Text = FrmUsuarios.usuario.NombreUsuario;
                txtClave.Text = FrmUsuarios.usuario.Contrasena;
                txtTelefono.Text = FrmUsuarios.usuario.Telefono;
                txtPuesto.Text = FrmUsuarios.usuario.Puesto;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                mu.Editar(new Usuarios(FrmUsuarios.usuario.IdUsuario, txtNombre.Text, txtClave.Text, txtTelefono.Text, txtPuesto.Text));
            }
            else
            {
                mu.Guardar(new Usuarios(0, txtNombre.Text, txtClave.Text, txtTelefono.Text, txtPuesto.Text));
            }
            Close();
        }
    }
}
