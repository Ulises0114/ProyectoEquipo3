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
using System.IO;
using System.Drawing.Drawing2D;

namespace ProyectoEquipo3
{
    public partial class FrmInventario : Form
    {
        ManejadorInventario mi;
        public static Inventarios inventario = new Inventarios(0,"",0,"",0m,"",0m,0m,"","");
        int fila = 0, columna = 0;
        private readonly string baseImagesPath = Path.Combine(Application.StartupPath, "images");

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            fila = e.RowIndex;
            columna = e.ColumnIndex;

            var row = DtgDatos.Rows[fila];

            FrmInventario.inventario.IdInventario = Convert.ToInt32(row.Cells["IdInventario"].Value ?? 0);
            FrmInventario.inventario.NombreProducto = row.Cells["NombreProducto"].Value?.ToString() ?? "";
            FrmInventario.inventario.IdProveedor = Convert.ToInt32(row.Cells["IdProveedor"].Value ?? 0);
            FrmInventario.inventario.UnidadMedida = row.Cells["UnidadMedida"].Value?.ToString() ?? "";
            FrmInventario.inventario.PrecioCompra = Convert.ToDecimal(row.Cells["PrecioCompra"].Value ?? 0m);
            FrmInventario.inventario.FechaIngreso = row.Cells["FechaIngreso"].Value?.ToString() ?? "";
            FrmInventario.inventario.StockMinimo = Convert.ToDecimal(row.Cells["StockMinimo"].Value ?? 0m);
            FrmInventario.inventario.StockActual = Convert.ToDecimal(row.Cells["StockActual"].Value ?? 0m);
            FrmInventario.inventario.Descripcion = row.Cells["Descripcion"].Value?.ToString() ?? "";

            if (DtgDatos.Columns.Contains("ImagePath"))
                FrmInventario.inventario.ImagePath = row.Cells["ImagePath"].Value?.ToString() ?? "";

            switch (columna)
            {
                case 10:
                    {
                        FrmDatosInventario di = new FrmDatosInventario();
                        di.ShowDialog(this);
                        DtgDatos.Columns.Clear();
                    }; break;
                case 11:
                    {
                        mi.Borrar(FrmInventario.inventario);
                        DtgDatos.Columns.Clear();
                    }; break;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            inventario.IdInventario = 0;
            inventario.NombreProducto = "";
            inventario.IdProveedor = 0;
            inventario.UnidadMedida = "";
            inventario.PrecioCompra = 0m;
            inventario.FechaIngreso = "";
            inventario.StockMinimo = 0m;
            inventario.StockActual = 0m;
            inventario.Descripcion = "";
            inventario.ImagePath = ""; 

            FrmDatosInventario di = new FrmDatosInventario();
            di.ShowDialog(this);
            DtgDatos.Columns.Clear();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            mi.Mostrar($"select * from inventario where NombreProducto like '%{textBox1.Text}%'", DtgDatos, "inventario");
            CargarGaleria();
        }
        private void FrmInventario_Load(object sender, EventArgs e)
        {
            BtnRefresh_Click(null, null);
            CargarGaleria();
            ConfigurarMenu();
            //ConfigurarBotones();
            if (!Usuarios.PuedeLeer("Inventario"))
            {
                MessageBox.Show("No tienes permiso para ver este módulo.");
                this.Close();
                return;
            }
            bool tieneEscritura = Usuarios.PuedeEscribir("Usuarios");
            btnAgregar.Enabled = tieneEscritura;
        }

        private void CargarGaleria()
        {
            DataTable dt = mi.ListarProductosParaGaleria();
            FillListViewFromDataTable(lvProductos, ilThumbnails, dt);
        }
        private Image GetImageFromPath(string imagePathFromDb)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(imagePathFromDb))
                    return SystemIcons.Application.ToBitmap();

                string fullPath = imagePathFromDb;
                if (!Path.IsPathRooted(imagePathFromDb))
                    fullPath = Path.Combine(baseImagesPath, imagePathFromDb);

                if (File.Exists(fullPath))
                {
                    byte[] bytes = File.ReadAllBytes(fullPath);
                    using (var ms = new MemoryStream(bytes))
                    {
                        return Image.FromStream(ms);
                    }
                }
            }
            catch
            {
                // ignorar y devolver 
            }
            return SystemIcons.Application.ToBitmap();
        }

        private Image CreateThumbnailWithBadge(Image src, int thumbW, int thumbH, decimal stock)
        {
            if (src == null) src = SystemIcons.Application.ToBitmap();

            double ratioX = (double)thumbW / src.Width;
            double ratioY = (double)thumbH / src.Height;
            double ratio = Math.Min(ratioX, ratioY);
            int newW = Math.Max(1, (int)(src.Width * ratio));
            int newH = Math.Max(1, (int)(src.Height * ratio));

            Bitmap thumb = new Bitmap(thumbW, thumbH);
            using (Graphics g = Graphics.FromImage(thumb))
            {
                g.Clear(Color.FromArgb(217, 217, 217)); //color de fondo
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                int x = (thumbW - newW) / 2;
                int y = (thumbH - newH) / 2;
                g.DrawImage(src, x, y, newW, newH);

                // badge
                string stockText = stock.ToString("0");
                using (Font badgeFont = new Font("Rounded MT Bold", 10, FontStyle.Bold))
                {
                    SizeF textSize = g.MeasureString(stockText, badgeFont);
                    int pad = 6;
                    int badgeW = (int)textSize.Width + pad * 2;
                    int badgeH = (int)textSize.Height + pad;
                    int badgeX = thumbW - badgeW - 6;
                    int badgeY = 6;

                    using (Brush brush = new SolidBrush(Color.FromArgb(220, 50, 50)))
                    using (Brush brushText = new SolidBrush(Color.White))
                    using (Pen pen = new Pen(Color.FromArgb(180, 40, 40)))
                    {
                        Rectangle rect = new Rectangle(badgeX, badgeY, badgeW, badgeH);
                        int corner = Math.Min(badgeH, badgeW) / 3;

                        using (var path = RoundedRect(rect, corner))
                        {
                            g.FillPath(brush, path);
                            g.DrawPath(pen, path);
                        }

                        float tx = badgeX + (badgeW - textSize.Width) / 2f;
                        float ty = badgeY + (badgeH - textSize.Height) / 2f - 1;
                        g.DrawString(stockText, badgeFont, brushText, tx, ty);
                    }
                }
            }
            return thumb;
        }

        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            var path = new GraphicsPath();
            int diameter = radius * 2;
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void FillListViewFromDataTable(ListView lv, ImageList il, DataTable dt)
        {
            lv.BeginUpdate();
            try
            {
                lv.Items.Clear();
                // Liberar imágenes previas (si quieres liberar memoria)
                foreach (Image img in il.Images)
                {
                    img.Dispose();
                }
                il.Images.Clear();

                int thumbW = il.ImageSize.Width;
                int thumbH = il.ImageSize.Height;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow row = dt.Rows[i];
                    string imagePathDb = dt.Columns.Contains("ImagePath") && row["ImagePath"] != DBNull.Value
                                         ? row["ImagePath"].ToString() : string.Empty;

                    Image src = GetImageFromPath(imagePathDb);

                    decimal stock = 0;
                    if (dt.Columns.Contains("StockActual") && row["StockActual"] != DBNull.Value)
                        decimal.TryParse(row["StockActual"].ToString(), out stock);

                    using (Image tmpThumb = CreateThumbnailWithBadge(src, thumbW, thumbH, stock))
                    {
                        Bitmap bmp = new Bitmap(tmpThumb);
                        il.Images.Add(bmp);
                    }

                    var item = new ListViewItem
                    {
                        Text = row["NombreProducto"]?.ToString() ?? "(sin nombre)",
                        ImageIndex = i,
                        Tag = row["IdInventario"]
                    };
                    lv.Items.Add(item);
                }
            }
            finally
            {
                lv.EndUpdate();
            }
        }

        private void LvProductos_ItemActivate(object sender, EventArgs e)
        {
            if (lvProductos.SelectedItems.Count == 0) return;

            int id;
            if (!int.TryParse(lvProductos.SelectedItems[0].Tag?.ToString(), out id)) return;

            try
            {
                var dt = DtgDatos.DataSource as DataTable;
                if (dt != null)
                {
                    DataRow[] found = dt.Select($"IdInventario = {id}");
                    if (found.Length > 0)
                    {
                        var row = found[0];
                        FrmInventario.inventario.IdInventario = Convert.ToInt32(row["IdInventario"]);
                        FrmInventario.inventario.NombreProducto = row["NombreProducto"]?.ToString() ?? "";
                        FrmInventario.inventario.IdProveedor = Convert.ToInt32(row["IdProveedor"] ?? 0);
                        FrmInventario.inventario.UnidadMedida = row["UnidadMedida"]?.ToString() ?? "";
                        FrmInventario.inventario.PrecioCompra = Convert.ToDecimal(row["PrecioCompra"] ?? 0m);
                        FrmInventario.inventario.FechaIngreso = row["FechaIngreso"]?.ToString() ?? "";
                        FrmInventario.inventario.StockMinimo = Convert.ToDecimal(row["StockMinimo"] ?? 0m);
                        FrmInventario.inventario.StockActual = Convert.ToDecimal(row["StockActual"] ?? 0m);
                        FrmInventario.inventario.Descripcion = row["Descripcion"]?.ToString() ?? "";
                        if (dt.Columns.Contains("ImagePath"))
                            FrmInventario.inventario.ImagePath = row["ImagePath"]?.ToString() ?? "";
                    }
                    else
                    {
                        var item = mi.ObtenerPorId(id); // implementar ObtenerPorId en ManejadorInventario si no existe
                        if (item != null)
                        {
                            FrmInventario.inventario = item;
                        }
                    }
                }
            }
            catch
            {
                // si algo falla, intenta al menos abrir el diálogo 
            }

            FrmDatosInventario di = new FrmDatosInventario();
            di.ShowDialog(this);
            DtgDatos.Columns.Clear();
        }
        public void RefreshGrid()
        {
            BtnRefresh_Click(null, null);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public FrmInventario()
        {
            InitializeComponent();
            mi = new ManejadorInventario();
            ilThumbnails.ImageSize = new Size(120, 120);
            ilThumbnails.ColorDepth = ColorDepth.Depth32Bit;
            lvProductos.LargeImageList = ilThumbnails;
            lvProductos.View = View.LargeIcon;
            lvProductos.MultiSelect = false;
            lvProductos.ItemActivate += LvProductos_ItemActivate;
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

        private void BtnNotificaciones_Click(object sender, EventArgs e)
        {
            FrmNotificaciones fn = new FrmNotificaciones();
            fn.Show();
            Close();
        }

        private void BtnPresupuesto_Click(object sender, EventArgs e)
        {
            Frm_Presupuesto fp = new Frm_Presupuesto();
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