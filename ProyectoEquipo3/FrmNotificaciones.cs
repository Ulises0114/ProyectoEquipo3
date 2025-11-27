using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Manejadores;
using ProyectoEquipo3.Controls;
using Manejadores;
using System.Threading.Tasks;

namespace ProyectoEquipo3
{
    public partial class FrmNotificaciones : Form
    {
        private readonly ManejadorNotificacion manejador = new ManejadorNotificacion();

        public FrmNotificaciones()
        {
            InitializeComponent();

            this.Load += FrmNotificaciones_Load;
            btnRefrescarNotificaciones.Click += BtnRefrescarNotificaciones_Click;
            dgvProgramadas.CellDoubleClick += DgvProgramadas_CellDoubleClick;
            timerAutoRefresh.Tick += TimerAutoRefresh_Tick;
        }

        private void FrmNotificaciones_Load(object sender, EventArgs e)
        {
            RefrescarTodo();
            ConfigurarMenu();
        }

        private void RefrescarTodo()
        {
            RefrescarSistema();
            RefrescarProgramadas();
            ActualizarBadge();
        }

        private void RefrescarSistema()
        {
            flpNotificacionesSistema.SuspendLayout();
            flpNotificacionesSistema.Controls.Clear();

            DataTable dt = manejador.ObtenerNotificacionesParaListado(limite: 200, soloNoLeidas: false);

            if (dt == null || dt.Rows.Count == 0)
            {
                var pnlEmpty = new Panel
                {
                    Width = flpNotificacionesSistema.ClientSize.Width - 25,
                    Height = 140,
                    BackColor = Color.Transparent,
                    Margin = new Padding(8)
                };

                var lbl = new Label
                {
                    Text = "No hay más notificaciones del sistema",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.DimGray,
                    Font = new Font("Segoe UI", 9F, FontStyle.Regular)
                };

                pnlEmpty.Controls.Add(lbl);
                flpNotificacionesSistema.Controls.Add(pnlEmpty);
                flpNotificacionesSistema.ResumeLayout();
                return;
            }

            foreach (DataRow r in dt.Rows)
            {
                int id = r.Table.Columns.Contains("IdNotificacion") && r["IdNotificacion"] != DBNull.Value ? Convert.ToInt32(r["IdNotificacion"]) : 0;
                string tipo = r.Table.Columns.Contains("TipoNotificacion") ? r["TipoNotificacion"]?.ToString() ?? "" : "";
                string mensaje = r.Table.Columns.Contains("Mensaje") ? r["Mensaje"]?.ToString() ?? "" : "";
                string preview = r.Table.Columns.Contains("MensajePreview") ? r["MensajePreview"]?.ToString() ?? mensaje : mensaje;
                string fechaForm = r.Table.Columns.Contains("FechaFormateada") ? r["FechaFormateada"]?.ToString() ?? "" : "";
                bool leida = r.Table.Columns.Contains("Leida") && r["Leida"] != DBNull.Value ? Convert.ToBoolean(r["Leida"]) : false;
                string nombreInv = r.Table.Columns.Contains("NombreInventario") ? r["NombreInventario"]?.ToString() ?? "" : "";
                string nombreProj = r.Table.Columns.Contains("NombreProyecto") ? r["NombreProyecto"]?.ToString() ?? "" : "";

                string relacionado = !string.IsNullOrEmpty(nombreInv) ? $"Producto: {nombreInv}" :
                                     (!string.IsNullOrEmpty(nombreProj) ? $"Proyecto: {nombreProj}" : "");

                var item = new ucNotificacionItem();
                item.SetData(id, tipo, preview, fechaForm, relacionado, leida);
                item.EliminarClicked += Item_EliminarClicked;

                flpNotificacionesSistema.Controls.Add(item);
            }

            flpNotificacionesSistema.ResumeLayout();
        }

        private void Item_EliminarClicked(object sender, int id)
        {
            if (MessageBox.Show("¿Deseas eliminar esta notificación?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                manejador.Eliminar(id);
                RefrescarTodo();
            }
        }

        private void Item_VerDetalleClicked(object sender, int id)
        {
            string texto = manejador.MarcarLeidaYDevolverMensaje(id);
            var not = manejador.ObtenerPorId(id);
            string titulo = not?.TipoNotificacion ?? "Notificación";

            using (Form f = new Form())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.Size = new Size(600, 320);
                f.Text = titulo;
                var tb = new TextBox
                {
                    Multiline = true,
                    ReadOnly = true,
                    Dock = DockStyle.Fill,
                    Text = texto ?? "",
                    ScrollBars = ScrollBars.Vertical,
                    Font = new Font("Segoe UI", 10F)
                };
                f.Controls.Add(tb);
                f.ShowDialog(this);
            }
            RefrescarTodo();
        }

        private void ActualizarBadge()
        {
            int c = manejador.ContarNoLeidas();
            if (c > 0)
            {
                lblBadgeCount.Text = c.ToString();
                lblBadgeCount.Visible = true;
            }
            else
            {
                lblBadgeCount.Visible = false;
            }
        }

        private void RefrescarProgramadas()
        {
            flpProgramadas.SuspendLayout();
            flpProgramadas.Controls.Clear();

            var dt = manejador.ObtenerProgramadasParaListado(soloPendientes: false, limite: 500); 

            if (dt == null || dt.Rows.Count == 0)
            {
                var pnlEmpty = new Panel
                {
                    Width = flpProgramadas.ClientSize.Width - 25,
                    Height = 120,
                    BackColor = Color.Transparent,
                    Margin = new Padding(8)
                };
                var lbl = new Label
                {
                    Text = "No hay notificaciones programadas",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.DimGray,
                    Font = new Font("Segoe UI", 9F)
                };
                pnlEmpty.Controls.Add(lbl);
                flpProgramadas.Controls.Add(pnlEmpty);
                flpProgramadas.ResumeLayout();
                return;
            }

            foreach (DataRow r in dt.Rows)
            {
                int id = r.Table.Columns.Contains("IdNotificacion") && r["IdNotificacion"] != DBNull.Value ? Convert.ToInt32(r["IdNotificacion"]) : 0;
                string aviso = r.Table.Columns.Contains("Aviso") ? r["Aviso"]?.ToString() ?? "" : "";
                DateTime fecha = r.Table.Columns.Contains("FechaNotificacion") && r["FechaNotificacion"] != DBNull.Value ? Convert.ToDateTime(r["FechaNotificacion"]) : DateTime.MinValue;
                bool completada = r.Table.Columns.Contains("Completada") && r["Completada"] != DBNull.Value ? Convert.ToBoolean(r["Completada"]) : false;

                string relacionado = ""; 

                var card = new ucProgramadaItem();
                card.SetData(id, aviso, fecha, relacionado, completada);

                card.CompletarClicked += (s, nid) =>
                {
                    if (MessageBox.Show("Marcar esta notificación como completada?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        manejador.MarcarProgramadaCompletada(nid);
                        RefrescarTodo();
                    }
                };

                card.EliminarClicked += (s, nid) =>
                {
                    if (MessageBox.Show("¿Eliminar esta notificación programada?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        manejador.EliminarProgramada(nid); 
                        RefrescarTodo();
                    }
                };

                flpProgramadas.Controls.Add(card);
            }

            flpProgramadas.ResumeLayout();
        }


        private void BtnRefrescarNotificaciones_Click(object sender, EventArgs e)
        {
            RefrescarTodo();
        }
        private void DgvProgramadas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (!dgvProgramadas.Columns.Contains("IdNotificacion")) return;

            int id = Convert.ToInt32(dgvProgramadas.Rows[e.RowIndex].Cells["IdNotificacion"].Value);
            var aviso = dgvProgramadas.Rows[e.RowIndex].Cells["Aviso"].Value?.ToString() ?? "";

            if (MessageBox.Show($"Marcar como completada la notificación:\n\n{aviso}", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                manejador.MarcarProgramadaCompletada(id);
                RefrescarTodo();
            }
        }
        private void TimerAutoRefresh_Tick(object sender, EventArgs e)
        {
            RefrescarTodo();
        }
        private void btnProgramarNotificacion_Click_1(object sender, EventArgs e)
        {
            using (var f = new FrmProgramarNotificacion())
            {
                if (f.ShowDialog(this) == DialogResult.OK)
                {
                    RefrescarTodo();
                }
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu fm = new FrmMenu();
            fm.Show();
            Close();
        }

        private void BtnProyectos_Click(object sender, EventArgs e)
        {
            FrmProyectos fp = new FrmProyectos();
            fp.Show();
            Close();
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            FrmProveedores fp = new FrmProveedores();
            fp.Show();
            Close();
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            FrmInventario fi = new FrmInventario();
            fi.Show();
            Close();
        }

        private void BtnPresupuesto_Click(object sender, EventArgs e)
        {
            FrmDatosPresupuestos fp = new FrmDatosPresupuestos();
            fp.Show();
            Close();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios fu = new FrmUsuarios();
            fu.Show();
            Close();
        }
    }
}
