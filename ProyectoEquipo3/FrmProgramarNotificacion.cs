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
using Manejadores;

namespace ProyectoEquipo3
{
    public partial class FrmProgramarNotificacion : Form
    {
        private readonly ManejadorNotificacion manejador = new ManejadorNotificacion();

        public FrmProgramarNotificacion()
        {
            InitializeComponent();
                        
        }

        private void btnProgramar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAviso.Text))
            {
                MessageBox.Show("Escribe el aviso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAviso.Focus();
                return;
            }

            DateTime fecha = dtpFechaNotificacion.Value;
            if (fecha < DateTime.Now.AddMinutes(-1))
            {
                var r = MessageBox.Show("La fecha seleccionada es pasada. ¿Deseas usarla igual?", "Fecha pasada", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r != DialogResult.Yes) return;
            }

            string aviso = txtAviso.Text.Trim();

            int? idProducto = null;
            int? idProyecto = null;
            if (this.Controls.ContainsKey("cmbRelacionTipo") && this.Controls.ContainsKey("cmbRelacionId"))
            {
                var cmbTipo = this.Controls["cmbRelacionTipo"] as ComboBox;
                var cmbIds = this.Controls["cmbRelacionId"] as ComboBox;
                if (cmbTipo != null && cmbIds != null && cmbTipo.SelectedItem != null && cmbTipo.SelectedItem.ToString() != "Ninguno")
                {
                    var selected = cmbIds.SelectedItem?.ToString();
                    if (!string.IsNullOrEmpty(selected))
                    {
                        var parts = selected.Split(new char[] { '-' }, 2);
                        if (int.TryParse(parts[0].Trim(), out int parsedId))
                        {
                            if (cmbTipo.SelectedItem.ToString() == "Producto") idProducto = parsedId;
                            else if (cmbTipo.SelectedItem.ToString() == "Proyecto") idProyecto = parsedId;
                        }
                    }
                }
            }

            try
            {
                manejador.CrearNotificacionProgramada(fecha, aviso);
                MessageBox.Show("Notificación programada correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al programar la notificación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
