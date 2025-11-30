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
            mu.Mostrar($"select * from Usuarios", dtgDatosUsuarios, "usuarios");
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
            mu.Mostrar("select * from Usuarios", dtgDatosUsuarios, "usuarios");
            ConfigurarMenu();
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
            if (tieneEscritura)
            {
                LblMiembro.ForeColor = Color.FromKnownColor(KnownColor.ButtonShadow);
            }
            else
            {
                LblAdmin.ForeColor = Color.FromKnownColor(KnownColor.ButtonShadow);
            }
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

        private void BtnPresupuesto_Click(object sender, EventArgs e)
        {
            Frm_Presupuesto fp = new Frm_Presupuesto();
            fp.Show();
            Close();
        }

        private void BtnNotificaciones_Click(object sender, EventArgs e)
        {
            FrmNotificaciones fn = new FrmNotificaciones();
            fn.Show();
            Close();
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            FrmProveedores fp = new FrmProveedores();
            fp.Show();
            Close();
        }

        private void BtnProyectos_Click(object sender, EventArgs e)
        {
            FrmProyectos fp = new FrmProyectos();
            fp.Show();
            Close();
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            FrmInventario fi = new FrmInventario();
            fi.Show();
            Close();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu fm = new FrmMenu();
            fm.Show();
            Close();
        }
        private void ConfigurarMenu()
        {
            FlpAncho.Visible = false;
            FlpAngosto.MouseEnter += (s, e) => MostrarMenuCompleto();
            FlpAncho.MouseLeave += (s, e) => OcultarMenuCompleto(e);

            foreach (Control btn in FlpAngosto.Controls)
            {
                btn.MouseEnter += (s, e) => MostrarMenuCompleto();
            }

            foreach (Control btn in FlpAncho.Controls)
            {
                btn.MouseLeave += (s, e) => OcultarMenuCompleto(e);
            }
        }

        private void MostrarMenuCompleto()
        {
            FlpAngosto.Visible = false;
            FlpAncho.Visible = true;
            FlpAncho.BringToFront();
        }

        private void OcultarMenuCompleto(EventArgs e)
        {
            Task.Delay(100).ContinueWith(t =>
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() =>
                    {
                        Point cursorPos = FlpAncho.PointToClient(Cursor.Position);
                        if (!FlpAncho.ClientRectangle.Contains(cursorPos))
                        {
                            FlpAncho.Visible = false;
                            FlpAngosto.Visible = true;
                        }
                    }));
                }
            });
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
