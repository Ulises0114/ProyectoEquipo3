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
    public partial class FrmProveedores : Form
    {
        public static Proveedores p = new Proveedores(0, "", "", 0, "", "", "");
        int fila = 0, columna = 0;
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
