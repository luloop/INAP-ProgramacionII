using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Tarea 07");
            Console.WriteLine("----------------");

            Console.Write("Ingrese una Letra:\t");
            char letra = Convert.ToChar( Console.ReadLine());

            Console.Write("\n");

            Console.Write("Ingrese un Numero:\t");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nTRIANGULO");
            Console.WriteLine("----------------");

            for (int i = 0; i < numero; i++)
            {
                for (int j = numero; j >= i+1; j--)
                {
                    Console.Write("{0}", letra);
                }
                Console.Write("\n");

            }
            Console.WriteLine("----------------");


        }
    }
}
