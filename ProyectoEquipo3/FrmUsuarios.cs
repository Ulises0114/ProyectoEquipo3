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
    public partial class FrmUsuarios : Form
    {
        ManejadorUsuarios mu;
        public static Usuarios usuario = new Usuarios(0, "", "", "", "");
        int fila = 0, columna = 0;
        public FrmUsuarios()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            usuario.IdUsuario = 0;
            usuario.NombreUsuario = "";
            usuario.Contrasena = "";
            usuario.Telefono = "";
            usuario.Puesto = "";
            FrmDatosUsuario frmAgregarUsuario = new FrmDatosUsuario(false);
            frmAgregarUsuario.ShowDialog();
            dtgDatosUsuarios.Columns.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            mu.Mostrar($"select * from Usuarios where NombreUsuario like '%{txtBuscar.Text}%'", dtgDatosUsuarios, "usuarios");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (usuario.IdUsuario == 0)
            {
                MessageBox.Show("Seleccione un usuario para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                FrmDatosUsuario frmEditarUsuario = new FrmDatosUsuario(true);
                frmEditarUsuario.ShowDialog();
                dtgDatosUsuarios.Columns.Clear();
            }
        }

        private void dtgDatosUsuarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            if (!Usuarios.PuedeLeer("Usuarios"))
            {
                MessageBox.Show("No tienes permiso para ver este módulo.");
                this.Close();
                return;
            }
            bool tieneEscritura = Usuarios.PuedeEscribir("Usuarios");
            btnAgregar.Enabled = tieneEscritura;
            btnEditar.Enabled = tieneEscritura;
            btnEliminar.Enabled = tieneEscritura;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (usuario.IdUsuario == 0)
            {
                MessageBox.Show("Seleccione un usuario para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                mu.Borrar(usuario);
            }
        }

        private void dtgDatosUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            usuario.IdUsuario = int.Parse(dtgDatosUsuarios.Rows[fila].Cells["IdUsuario"].Value.ToString());
            usuario.NombreUsuario = dtgDatosUsuarios.Rows[fila].Cells["NombreUsuario"].Value.ToString();
            usuario.Contrasena = dtgDatosUsuarios.Rows[fila].Cells["Clave"].Value.ToString();
            usuario.Telefono = dtgDatosUsuarios.Rows[fila].Cells["Telefono"].Value.ToString();
            usuario.Puesto = dtgDatosUsuarios.Rows[fila].Cells["Puesto"].Value.ToString();
        }
    }
}
