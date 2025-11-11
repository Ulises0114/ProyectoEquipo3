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
using AccesoDatos;
using Manejadores;

namespace ProyectoEquipo3
{
    public partial class FrmDatosProovedores : Form
    {
        ManejadorProveedores mp;
        
        public FrmDatosProovedores()
        {
            InitializeComponent();
            mp = new ManejadorProveedores();
            if(FrmProveedores.p.IdProveedor>0)
            {
                TxtNombre.Text=FrmProveedores.p.NombreProveedor.ToString();
                TxtContacto.Text=FrmProveedores.p.Contacto.ToString();
                TxtTelefono.Text=FrmProveedores.p.Telefono.ToString();
                TxtEmail.Text=FrmProveedores.p.Email.ToString();
                TxtDireccion.Text=FrmProveedores.p.Direccion.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(FrmProveedores.p.IdProveedor==0)
            {
                mp.Guardar(new Proveedores(0, TxtNombre.Text, TxtContacto.Text, TxtTelefono.Text,TxtEmail.Text,TxtDireccion.Text,null));
            }
            else
            {
                mp.Modificar(new Proveedores(FrmProveedores.p.IdProveedor, TxtNombre.Text, TxtContacto.Text, TxtTelefono.Text, TxtEmail.Text, TxtDireccion.Text,null));
            }
            Close();
        }
    }
}
