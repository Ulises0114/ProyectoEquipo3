using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoEquipo3.Controls
{
    public partial class ucNotificacionItem : UserControl
    {
        public int IdNotificacion { get; private set; }
        public string TipoNotificacion { get; private set; }
        public bool Leida { get; private set; }

        // Evento público: solo eliminar (pasa el id)
        public event EventHandler<int> EliminarClicked;

        public ucNotificacionItem()
        {
            InitializeComponent(); // usa el Designer
            // Solo conectar el botón eliminar aquí
            this.btnEliminar.Click += BtnEliminar_Click;
            // Asegurarse de que el resto del control no abra detalles:
            // no registrar doble-click ni click global
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EliminarClicked?.Invoke(this, IdNotificacion);
        }

        // Método para setear datos. Llamar desde el FrmNotificaciones después de crear la instancia.
        public void SetData(int id, string tipo, string mensajePreview, string fechaFormateada, string nombreRelacionado, bool leida)
        {
            IdNotificacion = id;
            TipoNotificacion = tipo;
            Leida = leida;

            // Texto del control
            lblMensajePreview.Text = mensajePreview ?? "";
            lblRelacionado.Text = string.IsNullOrWhiteSpace(nombreRelacionado) ? "" : nombreRelacionado;
            lblFecha.Text = fechaFormateada ?? "";

            // Estilo visual si está leído
            this.BackColor = leida ? Color.FromArgb(245, 245, 245) : Color.FromArgb(235, 245, 255);
        }
    }
}
