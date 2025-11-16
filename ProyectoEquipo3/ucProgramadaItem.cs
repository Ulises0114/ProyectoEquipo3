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
    public partial class ucProgramadaItem : UserControl
    {
        public int IdNotificacion { get; private set; }
        public bool Completada { get; private set; }

        // Eventos públicos
        public event EventHandler<int> CompletarClicked; // pasa id
        public event EventHandler<int> EliminarClicked;  // pasa id

        public ucProgramadaItem()
        {
            InitializeComponent();
            this.btnCompletar.Click += BtnCompletar_Click;
            this.btnEliminar.Click += BtnEliminar_Click;
        }
        private void BtnCompletar_Click(object sender, EventArgs e)
        {
            CompletarClicked?.Invoke(this, IdNotificacion);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EliminarClicked?.Invoke(this, IdNotificacion);
        }

        // SetData para llenar la tarjeta desde FrmNotificaciones
        public void SetData(int id, string aviso, DateTime fechaNotificacion, string nombreRelacionado, bool completada)
        {
            IdNotificacion = id;
            Completada = completada;

            lblAviso.Text = aviso ?? "";
            lblFecha.Text = fechaNotificacion.ToString("dd/MM/yyyy HH:mm");
            lblRelacionado.Text = string.IsNullOrWhiteSpace(nombreRelacionado) ? "" : nombreRelacionado;

            // estilo si está completada
            this.BackColor = completada ? Color.FromArgb(245, 245, 245) : Color.FromArgb(240, 255, 240);

            // cambiar texto del botón completar si ya está completada
            if (completada)
            {
                btnCompletar.Enabled = false;
                btnCompletar.Text = "Completada";
            }
            else
            {
                btnCompletar.Enabled = true;
                btnCompletar.Text = "Completar";
            }
        }
    }
}
