using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, ciudad;
            Console.WriteLine("Escribe tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("escribe una ciudad");
            ciudad = Console.ReadLine();
            Console.WriteLine(" hola \n" + nombre +  " bienvenido a " + ciudad);
            Console.WriteLine("Presionar cualquier tecla para continuar");
            Console.ReadKey();

        }
    }
}
