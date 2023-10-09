using System.Drawing;
using System.Dynamic;

namespace P2_2_Figuras;

internal abstract class Figura
{
    protected Color _color;

    public abstract double GetArea();

    public void SetColor(int red, int green, int blue, int alpha)
    {
        this._color = Color.FromArgb(red, green, blue, alpha);
    }

}

