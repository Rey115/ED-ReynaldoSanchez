namespace Devolver_impares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //almacenar los numeros imapares en un array y devolverlos 

            int  Numeros;
           
            Console.WriteLine("cuantos numeros quiere ingresar:");
            Numeros = int.Parse(Console.ReadLine());


            for (int i = 0; i <= Numeros; i++)
            {
                if (i % 2 != 0)
                {

                    Console.WriteLine("Los Numeros impares son " + i );

                }
            }
            Console.ReadKey();


        }
    }
}
