namespace Libro
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Console.Write("Ingresa el título del libro: ");
            string titulo = Console.ReadLine();
            Console.Write("Ingresa el autor del libro: ");
            string autor = Console.ReadLine();

           
            Libro miLibro = new Libro(titulo, autor);
            miLibro.MostrarInfo();
        }
    }
}
