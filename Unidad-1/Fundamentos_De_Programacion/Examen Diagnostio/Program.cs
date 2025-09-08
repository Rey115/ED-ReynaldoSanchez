
namespace Examen_Diagnostio
{
    internal class Program
    {
        static void Main(string[] args)
        {
          


            Console.WriteLine("Que desea calcular 1 para rectangulo o 2 para cuadrado");
            int opcion = int.Parse(Console.ReadLine());
             
            if (opcion ==1)
            {
                Console.Write("Ingresa el ancho del rectángulo: ");
                double ancho = double.Parse(Console.ReadLine());

                Console.Write("Ingresa el alto del rectángulo: ");
                double alto = double.Parse(Console.ReadLine());
                Rectangulo miRectangulo = new Rectangulo(ancho, alto);

                Console.WriteLine(miRectangulo.CalcularArea());
                Console.WriteLine(miRectangulo.CalcularPerimetro());
            }
            else if (opcion == 2)
            {
                Console.WriteLine("Ingresa el lado del cuadrado: ");
                double lado = double.Parse(Console.ReadLine());
                Cuadrado miCuadrado = new Cuadrado(lado, lado);
                miCuadrado.CalcularAreaCuadrado();
                miCuadrado.CalcularPerimetroCuadrado();


            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }

      













        
            




        }
    }
}
