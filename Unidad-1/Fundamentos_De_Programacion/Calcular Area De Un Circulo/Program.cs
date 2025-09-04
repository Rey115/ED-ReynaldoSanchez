namespace Calcular_Area_De_Un_Circulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radio;
            double area;

            Console.WriteLine("Ingresar radio del circulo: ");
            radio = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * Math.Pow(radio, 2);
            Console.WriteLine("El area del circulo es: " + area);
            Console.ReadKey();
        }
    }
}
