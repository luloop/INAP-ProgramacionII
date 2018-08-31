using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA1
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            int arraySize = 6;
            int* arrayheap = stackalloc int[arraySize];

                for (int i =0; i< arraySize; i++)
                {
                    Console.Write("Ingrese una numero en posicion {0}:\t", (i+1));
                    *(arrayheap+i) = Convert.ToInt32 (Console.ReadLine());
                   
                }

            for (int i = arraySize-1; i >=0; i--)
            {
                Console.Write("Ingreso el numero {0} en posicion {1}:\t \n", *(arrayheap + i), (i + 1));
            }





        }
    }
}
