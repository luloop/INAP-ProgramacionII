using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int suma=0;
            int flag = 0;

            do
            {

                Console.WriteLine(" Ingrese un numero:");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero > 0)
                {
                    suma += numero;
                    Console.WriteLine(" la suma parcial es {0}", suma);
                }
                else
                {
                    flag = 1;
                }

            } while (flag == 0);

            Console.WriteLine("----------------");
            Console.WriteLine(" el resultado es {0}", suma);
            Console.WriteLine("----------------");

        }

    }
}
