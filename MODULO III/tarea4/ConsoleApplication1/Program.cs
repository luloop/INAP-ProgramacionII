using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero");
           int  numero1 = Convert.ToInt32(Console.ReadLine());
            if (numero1 % 10 == 0)
            {
                Console.WriteLine("----------------");
                Console.Write("El numero ingresado es multiplo del 10\nIngrese el segundo numero\n");
                Console.WriteLine("----------------");
                int numero2 = Convert.ToInt32(Console.ReadLine());

                if (numero2 % 10 == 0)
                {
                    Console.WriteLine("----------------");
                    Console.WriteLine("El numero ingresado TAMBIEN es multiplo del 10");
                    Console.WriteLine("----------------");
                }
                else
                {
                    Console.WriteLine("----------------");
                    Console.WriteLine("El 2do numero NO es multiplo del 10");
                    Console.WriteLine("----------------");
                }


            }
            else
            {
                Console.WriteLine("----------------");
                Console.WriteLine("El 1ER numero NO es multiplo del 10");
                Console.WriteLine("----------------");
            }




        }
    }
}
