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
    List<Figura> lista_figuras = new List<Figura>();

    // Crear instancias de diferentes figuras y agregarlas a la lista
    Rectangulo r1 = new Rectangulo(3.9, 3, Color.FromArgb(255, 50, 20, 200));
    Circulo c1 = new Circulo(4, Color.FromArgb(255, 30, 120, 10));
    TrianguloEquilatero t1 = new TrianguloEquilatero(3, Color.FromArgb(255, 230, 20, 30));

    lista_figuras.Add(r1);
    lista_figuras.Add(c1);
    lista_figuras.Add(t1);

    // Crear más instancias y agregarlas a la lista
    Rectangulo r2 = new Rectangulo(4.5, 2, Color.FromArgb(255, 50, 20, 200));
    Circulo c2 = new Circulo(3, Color.FromArgb(255, 30, 120, 10));
    TrianguloEquilatero t2 = new TrianguloEquilatero(5, Color.FromArgb(255, 230, 20, 30));

    lista_figuras.Add(r2);
    lista_figuras.Add(c2);
    lista_figuras.Add(t2);


    foreach (var figura in lista_figuras)
    {
      Console.WriteLine(figura.ToString() + ", Área: " + figura.GetArea());
    }
  }


}
