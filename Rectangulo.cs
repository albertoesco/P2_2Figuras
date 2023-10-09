using System.Drawing;

namespace P2_2_Figuras;

internal class Rectangulo : Figura
{
    protected double _base, _altura;

    public Rectangulo(double _base, double altura, Color color)
    {
        this._base = _base;
        this._altura = altura;
        this._color = color;
    }
    public override double GetArea()
    {
        return _base * _altura;
    }
    public double GetBase()
    {
        return this._base;
    }
    public void SetAltura(int altura)
    {
        this._altura = altura;
    }

    public override string ToString()
    {
        return $"FIGURA RECTANGULO: BASE: {_base}  ALTURA: {_altura} COLOR: {_color}  AREA: {GetArea()}";
    }
}