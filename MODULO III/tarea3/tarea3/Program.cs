using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea3
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            int numero1;
            int numero2;

            Console.WriteLine("ingrese el primer numero");
            numero1 = Convert.ToInt32(Console.ReadLine());

            if (numero1 == 0)
            {
                Console.WriteLine("El producto de 0 por cualquier número es 0");
            }

            else
            {
                Console.WriteLine  ("ingrese el segundo numero");
                numero2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n\nEl producto de ambos es {0} \n\n", (numero1*numero2));

            }


        }
    }
}
