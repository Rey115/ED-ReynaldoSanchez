namespace Funcion_que_reciba_una_lista_y_devuelva_su_promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Función que reciba una lista de números y devuelva su promedio.
            double promedio;
            int num;

            List<int> numeros = new List<int>();
            Console.WriteLine("¿Cuántos números deseas ingresar?");
            int cantidad = int.Parse(Console.ReadLine());

       
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Ingresa el número {i + 1}: ");
                num = int.Parse(Console.ReadLine());
                numeros.Add(num);
            }

            double CalcularPromedio(List<int> lista)
            {
                int suma = 0;
                foreach (int numero in lista)
                {
                    suma += numero;
                }
                return (double)suma / lista.Count;
            }

            promedio = CalcularPromedio(numeros);
            Console.WriteLine("El promedio es: " + promedio);
           



        }
    }
}
