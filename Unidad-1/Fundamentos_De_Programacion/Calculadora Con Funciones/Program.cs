namespace Calculadora_Con_Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una calculadora con funciones para suma, resta, multiplicación y division.

            double Num1, Num2, Resultado, Operacion;
            Console.WriteLine("Ingrese el primer número:");
            Num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            Num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Elija la operación que desea realizar:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Operacion = Convert.ToDouble(Console.ReadLine());

            static double Calcular (double num1, double num2, double operacion )
            {
                switch (operacion)
                {
                    case 1:
                        return num1 + num2;
                    case 2:
                        return num1 - num2;
                    case 3:
                        return num1 * num2;
                    case 4:
                        if (num2 != 0)
                            return num1 / num2;
                        else
                        {
                            Console.WriteLine("Error: División entre cero.");
                            return double.NaN;
                        }
                    default:
                        Console.WriteLine("Operación no válida.");
                        return double.NaN;
                }

            }


            Resultado = Calcular(Num1,Num2,Operacion);

            Console.WriteLine("Resultado: " + Resultado);

        }

    }
}
