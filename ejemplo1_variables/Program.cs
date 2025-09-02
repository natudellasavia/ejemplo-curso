using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // VARAIBLES
            // Primitivas: int, float, bool, char
            // Otras: double, decimal, long, short, string, datetime

            // Console.WriteLine("Hola cómo va?"); -> ESCCRIBIR EN CONSOLA
            // Console.ReadKey(); -> LEER EN CONSOLA
            // Console.ReadLine(); -> LEER EN CONSOLA

            // a = int.Parse(Console.ReadLine()); -> CASTEO EXPLICITO

            int a, b, c;
            
            Console.WriteLine("Hola cómo va?");
            Console.WriteLine("Ingrese un numero:");

            a = int.Parse(Console.ReadLine());
            b = 10;
            c = a + b;

            Console.WriteLine("El resultado es: " + c);
            Console.ReadKey();
        }
    }
}
