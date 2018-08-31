using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
        int arraySize = 4;
        int* datos = stackalloc int[arraySize];

            for (int i=0; i < arraySize; i ++)
            {
                Console.Write("Ingrese un numero entero:\t");
                *(datos+i) = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 1; i < arraySize; i++)
            {
                Console.Write("Ingrese el numero entero es  {0} en posicion {1}:\t\n", *(datos+i), i+1);
               
            }




        }
    }
}
