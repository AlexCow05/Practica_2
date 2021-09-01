using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculoperimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero_1 = 10;
            int numero_2 = 10;
            int numero_3 = 7;

            int suma = numero_1 + numero_2 + numero_3;
            Console.WriteLine("El perimetro del triangulo es:" + suma );
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
