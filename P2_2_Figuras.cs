//necesario para usar la estructura Color
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color?view=net-7.0
using System.Drawing;
//método para obtener un color a partir de los valores RGBA 
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color.fromargb?view=net-7.0

namespace P2_2_Figuras;

public class P2_2_Figuras
{
  static void Main(string[] args)
  {
    Rectangulo r1 = new Rectangulo(3.9, 3, Color.FromArgb(255, 50, 20, 200));
    Circulo c1 = new Circulo(4, Color.FromArgb(255, 30, 120, 10));
    TrianguloEquilatero t1 = new TrianguloEquilatero(3, Color.FromArgb(255, 230, 20, 30));

    Console.WriteLine("Rectángulo: " + r1.ToString() + ", Área: " + r1.GetArea());
    Console.WriteLine("Círculo: " + c1.ToString() + ", Área: " + c1.GetArea());
    Console.WriteLine("Triángulo Equilátero: " + t1.ToString() + ", Área: " + t1.GetArea());

    Rectangulo r2 = new Rectangulo(4.5, 2, Color.FromArgb(255, 50, 20, 200));
    Circulo c2 = new Circulo(3, Color.FromArgb(255, 30, 120, 10));
    TrianguloEquilatero t2 = new TrianguloEquilatero(5, Color.FromArgb(255, 230, 20, 30));

    Console.WriteLine("Rectángulo: " + r2.ToString() + ", Área: " + r2.GetArea());
    Console.WriteLine("Círculo: " + c2.ToString() + ", Área: " + c2.GetArea());
    Console.WriteLine("Triángulo Equilátero: " + t2.ToString() + ", Área: " + t2.GetArea());
  }


}
