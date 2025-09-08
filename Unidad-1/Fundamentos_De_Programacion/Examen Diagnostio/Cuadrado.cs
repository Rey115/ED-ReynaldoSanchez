using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Diagnostio
{
    internal class Cuadrado : Rectangulo
    {
      
        public Cuadrado (double Lado, double alto ) : base(Lado,alto )   
        {
            Alto = alto;
            Lado= Lado;

        }

        
        public double CalcularAreaCuadrado()
        {
            double area = Ancho * Ancho;
            Console.WriteLine("El area del cuadrado es: " + area);
            Console.WriteLine("Las dimensiones fueron Lado: " + Ancho);
            return area;
        }

        public double CalcularPerimetroCuadrado()
        {
            double perimetro = 4 * Ancho;
            Console.WriteLine("El perimetro del cuadrado es: " + perimetro);
            Console.WriteLine("Las dimensiones fueron Lado: " + Ancho);
            return perimetro;
        }

    }
}
