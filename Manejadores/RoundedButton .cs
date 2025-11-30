using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    // Propiedades internas
    private int borderSize = 1;
    private int borderRadius = 15;
    private Color borderColor = Color.PaleVioletRed;

    // Estados
    private Color backgroundColor = Color.AliceBlue;
    private Color hoverColor = Color.LightBlue;
    private Color pressedColor = Color.DodgerBlue;
    private bool isHovering = false;
    private bool isPressed = false;

    // ✨ NUEVAS PROPIEDADES para imágenes
    private Image buttonImage = null;
    private ContentAlignment imageAlign = ContentAlignment.MiddleLeft;
    private ContentAlignment textAlign = ContentAlignment.MiddleCenter;
    private int imagePadding = 5;

    public RoundedButton()
    {
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 0;
        this.DoubleBuffered = true;
        this.ResizeRedraw = true;
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                 ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw |
                 ControlStyles.SupportsTransparentBackColor, true);

        BackColor = backgroundColor;
        ForeColor = Color.White;

        this.MouseEnter += RoundedButton_MouseEnter;
        this.MouseLeave += RoundedButton_MouseLeave;
        this.MouseDown += RoundedButton_MouseDown;
        this.MouseUp += RoundedButton_MouseUp;
    }

    // ----- Propiedades públicas -----
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
        get => backgroundColor;
        set { backgroundColor = value; this.BackColor = value; Invalidate(); }
    }

    [Category("RJ Code Advance")]
    public Color HoverColor
    {
        get => hoverColor;
        set { hoverColor = value; }
    }

    [Category("RJ Code Advance")]
    public Color PressedColor
    {
        get => pressedColor;
        set { pressedColor = value; }
    }

    [Category("RJ Code Advance")]
    public Color TextColor
    {
        get => this.ForeColor;
        set { this.ForeColor = value; Invalidate(); }
    }

    // ✨ NUEVAS PROPIEDADES DE IMAGEN
    [Category("RJ Code Advance")]
    [Description("Imagen que se mostrará en el botón")]
    public Image ButtonImage
    {
        get => buttonImage;
        set { buttonImage = value; Invalidate(); }
    }

    [Category("RJ Code Advance")]
    [Description("Alineación de la imagen dentro del botón")]
    [DefaultValue(ContentAlignment.MiddleLeft)]
    public ContentAlignment ImageAlign
    {
        get => imageAlign;
        set { imageAlign = value; Invalidate(); }
    }

    [Category("RJ Code Advance")]
    [Description("Alineación del texto dentro del botón")]
    [DefaultValue(ContentAlignment.MiddleCenter)]
    public ContentAlignment TextAlign
    {
        get => textAlign;
        set { textAlign = value; Invalidate(); }
    }

    [Category("RJ Code Advance")]
    [Description("Espacio entre la imagen y los bordes del botón")]
    [DefaultValue(5)]
    public int ImagePadding
    {
        get => imagePadding;
        set { imagePadding = Math.Max(0, value); Invalidate(); }
    }

    public override string Text
    {
        get => base.Text;
        set { base.Text = value; Invalidate(); }
    }

    // ----- Eventos del mouse -----
    private void RoundedButton_MouseEnter(object sender, EventArgs e)
    {
        isHovering = true;
        Invalidate();
    }

    private void RoundedButton_MouseLeave(object sender, EventArgs e)
    {
        isHovering = false;
        isPressed = false;
        Invalidate();
    }

    private void RoundedButton_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            isPressed = true;
            Invalidate();
        }
    }

    private void RoundedButton_MouseUp(object sender, MouseEventArgs e)
    {
        isPressed = false;
        Invalidate();
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

        arc.X = rect.Left; arc.Y = rect.Top;
        path.AddArc(arc, 180, 90);

        arc.X = rect.Right - diameter; arc.Y = rect.Top;
        path.AddArc(arc, 270, 90);

        arc.X = rect.Right - diameter; arc.Y = rect.Bottom - diameter;
        path.AddArc(arc, 0, 90);

        arc.X = rect.Left; arc.Y = rect.Bottom - diameter;
        path.AddArc(arc, 90, 90);

        path.CloseFigure();
        return path;
    }

    private void InvalidateRegion()
    {
        int radius = Math.Min(BorderRadius, this.Height / 2);
        using (var path = GetRoundedPath(new Rectangle(0, 0, Width, Height), radius))
        {
            try
            {
                this.Region?.Dispose();
            }
            catch { }
            this.Region = new Region(path);
        }
    }

    private Color GetCurrentBackColor()
    {
        if (!this.Enabled)
            return Color.Gray;
        if (isPressed)
            return PressedColor;
        if (isHovering)
            return HoverColor;
        return backgroundColor;
    }

    // ✨ MÉTODO para calcular posición de la imagen según ContentAlignment
    private Rectangle GetImageRectangle()
    {
        if (ButtonImage == null) return Rectangle.Empty;

        int imgWidth = ButtonImage.Width;
        int imgHeight = ButtonImage.Height;
        int x = ImagePadding;
        int y = ImagePadding;

        switch (ImageAlign)
        {
            case ContentAlignment.TopLeft:
                x = ImagePadding;
                y = ImagePadding;
                break;
            case ContentAlignment.TopCenter:
                x = (Width - imgWidth) / 2;
                y = ImagePadding;
                break;
            case ContentAlignment.TopRight:
                x = Width - imgWidth - ImagePadding;
                y = ImagePadding;
                break;
            case ContentAlignment.MiddleLeft:
                x = ImagePadding;
                y = (Height - imgHeight) / 2;
                break;
            case ContentAlignment.MiddleCenter:
                x = (Width - imgWidth) / 2;
                y = (Height - imgHeight) / 2;
                break;
            case ContentAlignment.MiddleRight:
                x = Width - imgWidth - ImagePadding;
                y = (Height - imgHeight) / 2;
                break;
            case ContentAlignment.BottomLeft:
                x = ImagePadding;
                y = Height - imgHeight - ImagePadding;
                break;
            case ContentAlignment.BottomCenter:
                x = (Width - imgWidth) / 2;
                y = Height - imgHeight - ImagePadding;
                break;
            case ContentAlignment.BottomRight:
                x = Width - imgWidth - ImagePadding;
                y = Height - imgHeight - ImagePadding;
                break;
        }

        return new Rectangle(x, y, imgWidth, imgHeight);
    }

    // ✨ MÉTODO para calcular área de texto (evitando la imagen)
    private Rectangle GetTextRectangle()
    {
        Rectangle textRect = new Rectangle(0, 0, Width, Height);

        if (ButtonImage != null)
        {
            Rectangle imgRect = GetImageRectangle();

            // Ajustar el rectángulo de texto según dónde está la imagen
            switch (ImageAlign)
            {
                case ContentAlignment.MiddleLeft:
                case ContentAlignment.TopLeft:
                case ContentAlignment.BottomLeft:
                    // Imagen a la izquierda, mover texto a la derecha
                    textRect.X = imgRect.Right + ImagePadding;
                    textRect.Width = Width - textRect.X - ImagePadding;
                    break;

                case ContentAlignment.MiddleRight:
                case ContentAlignment.TopRight:
                case ContentAlignment.BottomRight:
                    // Imagen a la derecha, reducir ancho del texto
                    textRect.Width = imgRect.Left - ImagePadding;
                    break;

                case ContentAlignment.TopCenter:
                    // Imagen arriba, mover texto abajo
                    textRect.Y = imgRect.Bottom + ImagePadding;
                    textRect.Height = Height - textRect.Y - ImagePadding;
                    break;

                case ContentAlignment.BottomCenter:
                    // Imagen abajo, reducir altura del texto
                    textRect.Height = imgRect.Top - ImagePadding;
                    break;
            }
        }

        return textRect;
    }

    // ✨ MÉTODO para convertir ContentAlignment a TextFormatFlags
    private TextFormatFlags GetTextFormatFlags()
    {
        TextFormatFlags flags = TextFormatFlags.EndEllipsis | TextFormatFlags.WordBreak;

        switch (TextAlign)
        {
            case ContentAlignment.TopLeft:
                flags |= TextFormatFlags.Top | TextFormatFlags.Left;
                break;
            case ContentAlignment.TopCenter:
                flags |= TextFormatFlags.Top | TextFormatFlags.HorizontalCenter;
                break;
            case ContentAlignment.TopRight:
                flags |= TextFormatFlags.Top | TextFormatFlags.Right;
                break;
            case ContentAlignment.MiddleLeft:
                flags |= TextFormatFlags.VerticalCenter | TextFormatFlags.Left;
                break;
            case ContentAlignment.MiddleCenter:
                flags |= TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter;
                break;
            case ContentAlignment.MiddleRight:
                flags |= TextFormatFlags.VerticalCenter | TextFormatFlags.Right;
                break;
            case ContentAlignment.BottomLeft:
                flags |= TextFormatFlags.Bottom | TextFormatFlags.Left;
                break;
            case ContentAlignment.BottomCenter:
                flags |= TextFormatFlags.Bottom | TextFormatFlags.HorizontalCenter;
                break;
            case ContentAlignment.BottomRight:
                flags |= TextFormatFlags.Bottom | TextFormatFlags.Right;
                break;
        }

        return flags;
    }

    // ----- Eventos de control -----
    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        InvalidateRegion();
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        var g = pevent.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
        g.PixelOffsetMode = PixelOffsetMode.HighQuality;

        var rectSurface = new Rectangle(0, 0, Width, Height);
        var rectBorder = new Rectangle(0, 0, Width - 1, Height - 1);
        int radius = Math.Min(BorderRadius, Height / 2);

        using (var pathSurface = GetRoundedPath(rectSurface, radius))
        using (var pathBorder = GetRoundedPath(rectBorder, Math.Max(0, radius - BorderSize)))
        using (var brush = new SolidBrush(GetCurrentBackColor()))
        {
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

            // ✨ Dibujar la imagen si existe
            if (ButtonImage != null)
            {
                Rectangle imgRect = GetImageRectangle();

                // Aplicar clip para que la imagen no se salga del botón redondeado
                g.SetClip(pathSurface);

                if (this.Enabled)
                {
                    g.DrawImage(ButtonImage, imgRect);
                }
                else
                {
                    // Imagen en escala de grises cuando está deshabilitado
                    ControlPaint.DrawImageDisabled(g, ButtonImage, imgRect.X, imgRect.Y, Color.Transparent);
                }

                g.ResetClip();
            }

            // ✨ Dibujar el texto en el área calculada
            if (!string.IsNullOrEmpty(this.Text))
            {
                Rectangle textRect = GetTextRectangle();
                TextFormatFlags flags = GetTextFormatFlags();

                TextRenderer.DrawText(
                    g,
                    this.Text,
                    this.Font,
                    textRect,
                    this.Enabled ? this.ForeColor : Color.Gray,
                    flags);
            }
        }
    }

    protected override void OnEnabledChanged(EventArgs e)
    {
        base.OnEnabledChanged(e);
        Invalidate();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            this.MouseEnter -= RoundedButton_MouseEnter;
            this.MouseLeave -= RoundedButton_MouseLeave;
            this.MouseDown -= RoundedButton_MouseDown;
            this.MouseUp -= RoundedButton_MouseUp;
        }
        base.Dispose(disposing);
    }
}