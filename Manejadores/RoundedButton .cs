using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    // Propiedades internas
    private int borderSize = 1;
    private int borderRadius = 20;
    private Color borderColor = Color.PaleVioletRed;

    public RoundedButton()
    {
        // Optimización de renderizado para evitar parpadeo y pixelado
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 0;
        this.DoubleBuffered = true;
        this.ResizeRedraw = true;

        // Mejoras de estilo para WinForms
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                 ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);

        BackColor = Color.MediumSlateBlue;
        ForeColor = Color.White;
    }

    // ----- Propiedades públicas (tu estilo RJ Code Advance) -----
    [Category("RJ Code Advance")]
    public int BorderSize
    {
        get => borderSize;
        set { borderSize = Math.Max(0, value); Invalidate(); }
    }

    [Category("RJ Code Advance")]
    public int BorderRadius
    {
        get => borderRadius;
        set { borderRadius = Math.Max(0, value); InvalidateRegion(); Invalidate(); }
    }

    [Category("RJ Code Advance")]
    public Color BorderColor
    {
        get => borderColor;
        set { borderColor = value; Invalidate(); }
    }

    [Category("RJ Code Advance")]
    public Color BackgroundColor
    {
        get => this.BackColor;
        set { this.BackColor = value; Invalidate(); }
    }

    [Category("RJ Code Advance")]
    public Color TextColor
    {
        get => this.ForeColor;
        set { this.ForeColor = value; Invalidate(); }
    }

    // For compatibility with designer (optional)
    public override string Text
    {
        get => base.Text;
        set { base.Text = value; Invalidate(); }
    }

    // ----- Helpers -----
    private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
    {
        var path = new GraphicsPath();
        if (radius <= 0)
        {
            path.AddRectangle(rect);
            path.CloseFigure();
            return path;
        }

        int diameter = radius * 2;
        var arc = new Rectangle(rect.Location, new Size(diameter, diameter));

        // top-left
        arc.X = rect.Left; arc.Y = rect.Top;
        path.AddArc(arc, 180, 90);

        // top-right
        arc.X = rect.Right - diameter; arc.Y = rect.Top;
        path.AddArc(arc, 270, 90);

        // bottom-right
        arc.X = rect.Right - diameter; arc.Y = rect.Bottom - diameter;
        path.AddArc(arc, 0, 90);

        // bottom-left
        arc.X = rect.Left; arc.Y = rect.Bottom - diameter;
        path.AddArc(arc, 90, 90);

        path.CloseFigure();
        return path;
    }

    private void InvalidateRegion()
    {
        // Ajustar radius para que no exceda la altura
        int radius = Math.Min(BorderRadius, this.Height / 2);
        using (var path = GetRoundedPath(new Rectangle(0, 0, Width, Height), radius))
        {
            try
            {
                this.Region?.Dispose();
            }
            catch { /* ignorar si ya liberado */ }
            this.Region = new Region(path);
        }
    }

    // ----- Eventos de control -----
    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        InvalidateRegion();
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        // Preparar gráficos
        var g = pevent.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
        g.PixelOffsetMode = PixelOffsetMode.HighQuality;

        // Rectángulos y radios seguros
        var rectSurface = new Rectangle(0, 0, Width, Height);
        var rectBorder = new Rectangle(0, 0, Width - 1, Height - 1); // para que el borde quede dentro
        int radius = Math.Min(BorderRadius, Height / 2);

        using (var pathSurface = GetRoundedPath(rectSurface, radius))
        using (var pathBorder = GetRoundedPath(rectBorder, Math.Max(0, radius - BorderSize)))
        using (var brush = new SolidBrush(this.BackColor))
        {
            // Limpiar
            g.Clear(this.Parent?.BackColor ?? SystemColors.Control);

            // Dibujar superficie redondeada (fondo)
            g.FillPath(brush, pathSurface);

            // Dibujar borde si aplica
            if (BorderSize > 0)
            {
                using (var penBorder = new Pen(BorderColor, BorderSize))
                {
                    penBorder.Alignment = PenAlignment.Center;
                    g.DrawPath(penBorder, pathBorder);
                }
            }

            // Dibujar el texto centrado (usa TextRenderer para claridad)
            TextRenderer.DrawText(
                g,
                this.Text,
                this.Font,
                rectSurface,
                this.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
        }
    }

    // Asegurar que cuando el control esté deshabilitado se vea correcto
    protected override void OnEnabledChanged(EventArgs e)
    {
        base.OnEnabledChanged(e);
        Invalidate();
    }
}
