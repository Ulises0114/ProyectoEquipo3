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
        public static Proveedores p = new Proveedores(0, "", "", "", "", "","");
        ManejadorProveedores m;
        int fila = 0, columna = 0;
        public FrmProveedores()
        {
            InitializeComponent();
            m= new ManejadorProveedores();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmDatosProovedores f = new FrmDatosProovedores();
            f.ShowDialog();
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            m.Mostrar("select * from Proveedores", DtgDatos, "Proveedores");
        }

        private void DtgDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                p.IdProveedor = int.Parse(DtgDatos.Rows[e.RowIndex].Cells["IdProveedor"].Value.ToString());
                p.NombreProveedor = DtgDatos.Rows[e.RowIndex].Cells["NombreProveedor"].Value.ToString();
                p.Contacto = DtgDatos.Rows[e.RowIndex].Cells["Contacto"].Value.ToString();
                p.Telefono = DtgDatos.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                p.Email = DtgDatos.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                p.Direccion = DtgDatos.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
                p.FechaIngreso = DtgDatos.Rows[e.RowIndex].Cells["FechaRegistro"].Value.ToString();

                FrmDatosProovedores f = new FrmDatosProovedores(); 
                f.ShowDialog();
                m.Mostrar("select * from Proveedores", DtgDatos, "Proveedores");
            }
        }

        private void DtgDatos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                DtgDatos.ClearSelection();
                DtgDatos.Rows[e.RowIndex].Selected = true;

                p.IdProveedor = int.Parse(DtgDatos.Rows[e.RowIndex].Cells["IdProveedor"].Value.ToString());
                p.NombreProveedor = DtgDatos.Rows[e.RowIndex].Cells["NombreProveedor"].Value.ToString();
                var rs = MessageBox.Show($"¿Estás seguro de eliminar a {p.NombreProveedor}?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rs == DialogResult.Yes)
                {
                    m.Borrar(p);
                    m.Mostrar("select * from Proveedores", DtgDatos, "Proveedores");
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            m.Mostrar($"select * from Proveedores where NombreProveedor like '%{TxtBusqueda.Text}%' ; ", DtgDatos, "Proveedores");
        }
    }
}
