namespace Coche_con_atributos
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Coche miCoche = new Coche("Nissan", "Versa");

            miCoche.Acelerar(50); 
            miCoche.Acelerar(30);
            miCoche.Frenar(40);   
            miCoche.Frenar(50);   

            
            Console.WriteLine("Presionar tecla para salir");
            Console.ReadKey();
        }
    }
}
