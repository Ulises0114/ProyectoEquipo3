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
    public partial class FrmDatosProyectos : Form
    {
        ManejadorProyectos mp;
        public FrmDatosProyectos()
        {
            InitializeComponent();
            mp = new ManejadorProyectos();
            mp.LlenarLugares(CmbMaterial);
            if (FrmProyectos.proyecto.IdProyecto > 0)
            {
                TxtMueble.Text = FrmProyectos.proyecto.NombreMueble;
                CmbMaterial.SelectedValue = FrmProyectos.proyecto.IdMaterial;
                TxtCantidad.Text = FrmProyectos.proyecto.CantidadRequerida.ToString();
                TxtUnidad.Text = FrmProyectos.proyecto.UnidadMedida;
                CmbEstado.SelectedValue = FrmProyectos.proyecto.EstadoProyecto;
                TxtFecha.Text = FrmProyectos.proyecto.FechaEstimadaFin;
            }
        }

        /*private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmProyectos.proyecto.IdProyecto == 0)
                mp.Guardar(new Proyectos(0,)



            if (FrmUsuarios.usuario.Idu == 0)
                mu.Guardar(new Usuarios(0, TxtNombre.Text, TxtClave.Text));
            else
                mu.Modificar(new Usuarios(FrmUsuarios.usuario.Idu, TxtNombre.Text, TxtClave.Text));
            Close();
        }*/

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            if (FrmProyectos.proyecto.IdProyecto == 0)
                mp.Guardar(new Proyectos(0, TxtMueble.Text, int.Parse(CmbMaterial.SelectedValue.ToString()), int.Parse(TxtCantidad.Text), TxtUnidad.Text, CmbEstado.SelectedValue.ToString(), "null", DtpFecha.Text));
            else
                mp.Modificar(new Proyectos(FrmProyectos.proyecto.IdProyecto, TxtMueble.Text, int.Parse(CmbMaterial.SelectedValue.ToString()), int.Parse(TxtCantidad.Text), TxtUnidad.Text, CmbEstado.SelectedValue.ToString(), "null", DtpFecha.Text));
            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
