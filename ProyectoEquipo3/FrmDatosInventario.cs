using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejadores;

namespace ProyectoEquipo3
{
    public partial class FrmDatosInventario : Form
    {
        ManejadorInventario mi;
        //ManejadorDiseño md;
        private readonly string baseImagesPath = Path.Combine(Application.StartupPath, "images");
        private string selectedImageFileName = "";
        private string selectedImageFullPath = "";
        public FrmDatosInventario()
        {
            InitializeComponent();
            mi = new ManejadorInventario();
            mi.LlenarComboProveedores(cmbProveedor);
            //md = new ManejadorDiseño();            
            txtNombreProducto.Text = FrmInventario.inventario.NombreProducto;

            try
            {
                cmbProveedor.SelectedValue = FrmInventario.inventario.IdProveedor;
            }
            catch
            {
                cmbProveedor.Text = FrmInventario.inventario.IdProveedor.ToString();
            }

            cmbUnidadMedida.Text = FrmInventario.inventario.UnidadMedida;
            txtPrecioCompra.Text = FrmInventario.inventario.PrecioCompra.ToString();
            DateTime dt;
            if (DateTime.TryParse(FrmInventario.inventario.FechaIngreso, out dt))
                dtpFechaIngreso.Value = dt;
            else
                dtpFechaIngreso.Text = FrmInventario.inventario.FechaIngreso;

            txtStockMinimo.Text = FrmInventario.inventario.StockMinimo.ToString();
            txtStockActual.Text = FrmInventario.inventario.StockActual.ToString();
            txtDescripción.Text = FrmInventario.inventario.Descripcion;
            if (!string.IsNullOrWhiteSpace(FrmInventario.inventario.ImagePath))
            {
                string candidate = FrmInventario.inventario.ImagePath;
                string fullCandidate = Path.IsPathRooted(candidate) ? candidate : Path.Combine(baseImagesPath, candidate);
                if (File.Exists(fullCandidate))
                {
                    selectedImageFileName = Path.GetFileName(candidate);
                    using (var fs = new FileStream(fullCandidate, FileMode.Open, FileAccess.Read))
                    {
                        pictureBoxPreview.Image = Image.FromStream(fs);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) ||
                cmbProveedor.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(cmbUnidadMedida.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioCompra.Text) ||
                string.IsNullOrWhiteSpace(txtStockMinimo.Text) ||
                string.IsNullOrWhiteSpace(txtStockActual.Text) ||
                string.IsNullOrWhiteSpace(txtDescripción.Text) ||
                string.IsNullOrWhiteSpace(selectedImageFileName))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de guardar.","Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int proveedorId = 0;
                if (cmbProveedor.SelectedValue != null && int.TryParse(cmbProveedor.SelectedValue.ToString(), out proveedorId))
                {
                }
                else
                {
                    int.TryParse(cmbProveedor.Text, out proveedorId);
                }

                string imagePathToSave = selectedImageFileName;
                if (string.IsNullOrWhiteSpace(imagePathToSave) && FrmInventario.inventario.IdInventario > 0)
                {
                    imagePathToSave = FrmInventario.inventario.ImagePath;
                }

                var nuevo = new Inventarios(
                FrmInventario.inventario.IdInventario > 0 ? FrmInventario.inventario.IdInventario : 0,
                txtNombreProducto.Text,
                proveedorId,
                cmbUnidadMedida.Text,
                decimal.Parse(txtPrecioCompra.Text),
                dtpFechaIngreso.Value.ToString("yyyy-MM-dd"),
                decimal.Parse(txtStockMinimo.Text),
                decimal.Parse(txtStockActual.Text),
                txtDescripción.Text,
                imagePathToSave ?? ""
                );

                if (nuevo.IdInventario == 0)
                {
                    mi.Guardar(nuevo);
                }
                else
                {
                    mi.Modificar(nuevo); 
                }
                FrmInventario.inventario.ImagePath = imagePathToSave ?? "";

                selectedImageFileName = "";

                if (this.Owner is FrmInventario parent)
                {
                    parent.RefreshGrid();
                }
                MessageBox.Show("Guardado correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Seleccionar imagen del producto";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string origen = ofd.FileName;
                    string fileName = Path.GetFileName(origen);
                    string destino = Path.Combine(baseImagesPath, fileName);

                    // Asegurar carpeta de destino existe
                    if (!Directory.Exists(baseImagesPath))
                    {
                        Directory.CreateDirectory(baseImagesPath);
                    }

                    // Si ya existe un archivo con ese nombre, generar nombre único
                    if (File.Exists(destino))
                    {
                        string uniqueName = $"{Path.GetFileNameWithoutExtension(fileName)}_{Guid.NewGuid()}{Path.GetExtension(fileName)}";
                        destino = Path.Combine(baseImagesPath, uniqueName);
                        fileName = uniqueName;
                    }

                    try
                    {
                        File.Copy(origen, destino);

                        selectedImageFileName = fileName;
                        selectedImageFullPath = destino;

                        using (var fs = new FileStream(destino, FileMode.Open, FileAccess.Read))
                        {
                            pictureBoxPreview.Image = Image.FromStream(fs);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo copiar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
