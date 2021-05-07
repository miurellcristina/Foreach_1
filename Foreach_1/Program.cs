using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Instruccion Foreach";
            int[] edades = new int[5];
            Array (edades);
            Console.ReadKey();
        }

        static void Array(int[] edades)
        {
            int total = 0;
            edades = new int[5];
            for (int x=0; x<edades.Length; x++)
            {
                Console.WriteLine("Ingresa la edad del etudiante " + (x + 1) + ":");
                edades[x] = int.Parse(Console.ReadLine());
            }
            foreach (int element in edades)
            {
                total = total + element;
            }
            Console.WriteLine("La sumatoria de las edades es: " + total);
        }
    }
}
