using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libro
{
    internal class Libro
    {
       
        public string Titulo { get; set; }  
        public string Autor { get; set; }

      
        //Metodo constructor
        public Libro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
            Console.WriteLine("Libro creado.");
        }

       
        public void MostrarInfo()
        {
            Console.WriteLine($"Título: {Titulo}  Autor: {Autor}");
        }
    }
}
