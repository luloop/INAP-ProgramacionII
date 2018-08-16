using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Tarea 06");
            Console.WriteLine("----------------");
            int suma = 0;
            Console.Write("\nIngrese su numero\t ");
            int numero = Convert.ToInt32(Console.ReadLine());
            suma = SumaCifras(numero);
            Console.WriteLine("\n\n------------------------------");
            Console.Write("La suma de las cifras es :  {0}\n", suma);
            Console.WriteLine("------------------------------\n\n");
        }
         static int SumaCifras (int numero)
        {
            int suma = 0;
            string aux = Convert.ToString(numero);
            int digitos = aux.Length;
            for (int i = 0; i < digitos; i++)
            {
                suma += ((int)char.GetNumericValue(aux[i]));
            }
            return suma;
         
        }

    }
}
