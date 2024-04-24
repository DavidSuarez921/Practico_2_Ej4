using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_2_Ej4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            
            var sumaTotal = valores.Sum();
            Console.WriteLine("La suma total es: " + sumaTotal.ToString());

            var sumaTotalPares = valores.Where(x => x % 2 == 0).Sum() ;
            
            
                Console.WriteLine("La suma total de los valores pares es: " + sumaTotalPares);
            
        }
    }
}
