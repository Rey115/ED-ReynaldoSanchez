using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Diagnostio
{
    internal class Rectangulo
    {
        public double Ancho;
        private double AnchoRectangulo
        {
            get { return Ancho; }
            set { Ancho = value; }
        }
        public double Alto;
        private double AltoR
        {
            get { return Alto; }
            set { Alto = value; }
        }

        
        public Rectangulo(double ancho, double alto)
        {
            Ancho = ancho;
            Alto = alto;
        }


      
        public double CalcularArea()
        {
            double area = Ancho * Alto;
            Console.WriteLine("El area del rectangulo es: " + area);
            Console.WriteLine("Las dimensiones fueron Ancho: " + Ancho + " y Alto: " + Alto);
            return area;
        }

        public double CalcularPerimetro()
        {
            double perimetro = 2 * (Ancho + Alto);
            Console.WriteLine("El perimetro del rectangulo es: " + perimetro);
            Console.WriteLine("Las dimensiones fueron Ancho: " + Ancho + " y Alto: " + Alto);
            return perimetro;
        }

    }
}
