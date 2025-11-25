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
        private int idProyectoActual = 0;
        private bool esNuevo = true;

        public FrmDatosProyectos()
        {
            InitializeComponent();
            mp = new ManejadorProyectos();

            // Configurar ComboBox de estados
            CmbEstado.Items.Clear();
            CmbEstado.Items.AddRange(new string[] { "Pendiente", "En Proceso", "Pausado", "Completado", "Cancelado" });
            CmbEstado.SelectedIndex = 0; // Seleccionar "Pendiente" por defecto

            // Configurar el DataGridView de materiales
            ConfigurarGridMateriales();

            // Deshabilitar el panel de materiales hasta que se guarde el proyecto
            PanelMateriales.Enabled = false;

            // Verificar si estamos modificando un proyecto existente
            if (FrmProyectos.proyecto != null && FrmProyectos.proyecto.IdProyecto > 0)
            {
                esNuevo = false;
                idProyectoActual = FrmProyectos.proyecto.IdProyecto;

                TxtMueble.Text = FrmProyectos.proyecto.NombreMueble;
                CmbEstado.Text = FrmProyectos.proyecto.EstadoProyecto;

                if (FrmProyectos.proyecto.FechaEstimadaFin.HasValue)
                {
                    DtpFecha.Value = FrmProyectos.proyecto.FechaEstimadaFin.Value;
                }

                // Habilitar el panel de materiales para proyectos existentes
                PanelMateriales.Enabled = true;

                // Cargar materiales existentes
                CargarMateriales();
            }
        }

        private void ConfigurarGridMateriales()
        {
            // Configuración básica del DataGridView
            DtgMateriales.AutoGenerateColumns = true;
            DtgMateriales.AllowUserToAddRows = false;
            DtgMateriales.AllowUserToDeleteRows = false;
            DtgMateriales.ReadOnly = true;
            DtgMateriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtgMateriales.MultiSelect = false;
        }

        private void CargarMateriales()
        {
            try
            {
                // Limpiar el DataGridView
                DtgMateriales.DataSource = null;
                DtgMateriales.Columns.Clear();

                // Obtener los materiales del proyecto
                DataTable dtMateriales = mp.ObtenerMaterialesProyecto(idProyectoActual);
                DtgMateriales.DataSource = dtMateriales;

                // Ocultar columnas de IDs
                if (DtgMateriales.Columns.Contains("IdProyectoMaterial"))
                    DtgMateriales.Columns["IdProyectoMaterial"].Visible = false;

                if (DtgMateriales.Columns.Contains("IdMaterial"))
                    DtgMateriales.Columns["IdMaterial"].Visible = false;

                // Agregar botón de eliminar
                if (!DtgMateriales.Columns.Contains("BtnEliminar"))
                {
                    DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                    btnEliminar.Name = "BtnEliminar";
                    btnEliminar.HeaderText = "Acción";
                    btnEliminar.Text = "Quitar";
                    btnEliminar.UseColumnTextForButtonValue = true;
                    btnEliminar.DefaultCellStyle.BackColor = Color.Red;
                    btnEliminar.DefaultCellStyle.ForeColor = Color.White;
                    btnEliminar.FlatStyle = FlatStyle.Flat;
                    btnEliminar.Width = 80;
                    DtgMateriales.Columns.Add(btnEliminar);
                }

                // Ajustar tamaño de columnas
                DtgMateriales.AutoResizeColumns();

                // Mostrar mensaje si no hay materiales
                if (dtMateriales.Rows.Count == 0)
                {
                    MessageBox.Show("No hay materiales agregados a este proyecto.\n" +
                                  "Use el botón 'Agregar Material' para comenzar.",
                                  "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar materiales: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtMueble.Text))
            {
                MessageBox.Show("Ingrese el nombre del mueble", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtMueble.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(CmbEstado.Text))
            {
                MessageBox.Show("Seleccione el estado del proyecto", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmbEstado.Focus();
                return;
            }

            try
            {
                string resultado;

                if (esNuevo)
                {
                    // Guardar proyecto nuevo
                    resultado = mp.GuardarProyecto(new Proyectos(
                        0,
                        TxtMueble.Text.Trim(),
                        CmbEstado.Text,
                        null,
                        DtpFecha.Value
                    ));

                    if (resultado.StartsWith("OK"))
                    {
                        // Extraer el ID del proyecto recién creado
                        string[] partes = resultado.Split('|');
                        idProyectoActual = int.Parse(partes[1]);
                        esNuevo = false;

                        MessageBox.Show("Proyecto creado exitosamente.\n" +
                                      "Ahora puede agregar los materiales necesarios.",
                                      "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Habilitar la sección de materiales
                        PanelMateriales.Enabled = true;

                        BtnAgregarMaterial.Focus();
                    }
                    else
                    {
                        MessageBox.Show(resultado.Replace("ERROR|", ""), "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    resultado = mp.Modificar(new Proyectos(
                        idProyectoActual,
                        TxtMueble.Text.Trim(),
                        CmbEstado.Text,
                        FrmProyectos.proyecto.FechaCreacion,
                        DtpFecha.Value
                    ));

                    if (resultado == "OK")
                    {
                        MessageBox.Show("Proyecto modificado correctamente", "Éxito",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(resultado, "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregarMaterial_Click(object sender, EventArgs e)
        {
            if (idProyectoActual == 0)
            {
                MessageBox.Show("Primero debe guardar el proyecto antes de agregar materiales.",
                              "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmAgregarMaterial fam = new FrmAgregarMaterial(idProyectoActual);
            fam.ShowDialog();
            CargarMateriales();
        }

        private void DtgMateriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                if (e.ColumnIndex >= 0 && DtgMateriales.Columns[e.ColumnIndex].Name == "BtnEliminar")
                {
                    // Verificar que la fila tenga datos
                    if (DtgMateriales.Rows[e.RowIndex].Cells["IdProyectoMaterial"].Value == null)
                    {
                        MessageBox.Show("No se puede eliminar esta fila.", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int idProyectoMaterial = Convert.ToInt32(DtgMateriales.Rows[e.RowIndex].Cells["IdProyectoMaterial"].Value);
                    string nombreMaterial = DtgMateriales.Rows[e.RowIndex].Cells["Material"].Value?.ToString() ?? "Material";

                    var rs = MessageBox.Show(
                        $"¿Desea quitar el material '{nombreMaterial}' del proyecto?\n\n" +
                        "Esto devolverá la cantidad al inventario.",
                        "Confirmar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (rs == DialogResult.Yes)
                    {
                        string resultado = mp.EliminarMaterialDeProyecto(idProyectoMaterial);

                        if (resultado == "OK")
                        {
                            MessageBox.Show("Material eliminado correctamente.\n" +
                                          "La cantidad ha sido devuelta al inventario.",
                                          "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarMateriales();
                        }
                        else
                        {
                            MessageBox.Show(resultado, "Error",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar material: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(
                "¿Está seguro que desea cancelar?\n" +
                "Los cambios no guardados se perderán.",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

    }
}
