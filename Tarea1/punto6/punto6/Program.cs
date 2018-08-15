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
            int suma = 0;
            //int val = 0;
            Console.Write("\nIngrese su numero\t ");
            String numero = Console.ReadLine();
            int digitos= numero.Length;
            for (int i = 0; i < digitos; i++)
            {
              suma =suma +( (int)char.GetNumericValue(numero[i]));
            }
                
               

            Console.Write("\n----{0}----\n", suma);
        }
    }
}
