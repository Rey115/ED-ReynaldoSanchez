using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coche_con_atributos
{
    internal class Coche
    {
        public string Marca;
        public string Modelo;
        public int Velocidad;
  
        public Coche(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
            Velocidad = 0; 
        }

        
        public void Acelerar(int incremento)
        {
            Velocidad += incremento;
            Console.WriteLine($"El coche {Marca} {Modelo} aceleró a {Velocidad} km/h");
        }

        
        public void Frenar(int decremento)
        {
            Velocidad -= decremento;
            if (Velocidad < 0)
                Velocidad = 0;
            Console.WriteLine($"El coche {Marca} {Modelo} frenó y ahora va a {Velocidad} km/h");
        }
    }
}
