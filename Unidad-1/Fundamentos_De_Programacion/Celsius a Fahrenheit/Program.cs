namespace Celsius_a_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double GradosCelsius;
            double GradosFahrenheit;

            Console.WriteLine("Ingrese la temperatura en grados Celsius:");
            GradosCelsius = Convert.ToDouble(Console.ReadLine());
            GradosFahrenheit = ( GradosCelsius * 9 / 5) + 32;
            Console.WriteLine($"{GradosCelsius} grados Celsius son {GradosFahrenheit} grados Fahrenheit.");
            Console.ReadLine();

        }
    }
}
