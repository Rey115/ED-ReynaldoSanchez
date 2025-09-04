namespace Determinar_Si_Un_Numero_Es_Primo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Un numero primo solo es divisible entre 1 y entre si mismo
            // 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47

            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            int i = 2;
            for (; i < numero; i++)
            {
                if (numero % i == 0)
                    break;
            }
            if (numero > 1 && i == numero)
            {
                Console.WriteLine("El número es primo.");
            }
            else
            {
                Console.WriteLine("El número no es primo.");
            }
               

            Console.ReadKey();




        }
    }
}
