namespace Adivina_El_Numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            int numeroUsuario = 0;
            while (numeroUsuario != numeroSecreto)
            {
                Console.Write("Ingresa un numero entre 1 y 100: ");
                string numUsuario = Console.ReadLine();

              
                  
                    if (numeroUsuario < numeroSecreto)
                    {
                        Console.WriteLine("Demasiado bajo! Intenta de nuevo.");
                    }
                    else if (numeroUsuario > numeroSecreto)
                    {
                        Console.WriteLine("Demasiado alto! Intenta de nuevo.");
                    }
                    else
                    {
                        Console.WriteLine($"Felicidades! Adivinaste el numero {numeroSecreto}");
                    }
            }   



                
        }
    }
}
