using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

class EllipseButton : Button
{
    int borderWidth = 0;

    Color borderColor = Color.Black;
    public EllipseButton()
    {
        this.Width = this.Height;
    }

    [Description("Color of the borders"), Category("Roundiness")]
    public Color BorderColor
    {
        set
        {
            borderColor = value;
            this.Invalidate();
        }
        get
        {
            return borderColor;
        }
    }


    [Description("Border width"), Category("Roundiness")]
    public int BorderWidth
    {
        set
        {
            borderWidth = value;
            this.Invalidate();
        }
        get
        {
            return borderWidth;
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        GraphicsPath grPath = new GraphicsPath();
        grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
        this.Region = new System.Drawing.Region(grPath);


        if (borderWidth != 0)
            e.Graphics.DrawEllipse(new Pen(borderColor, borderWidth), 0, 0, ClientSize.Width, ClientSize.Height);
    }

}
