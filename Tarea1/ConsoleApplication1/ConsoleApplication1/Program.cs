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
            //Console.Clear;
            for (int fila = 0; fila <= 7; fila++)
            {
                for (int espacios = 7 - fila; espacios > 0; espacios--)
                    Console.Write(" ");

                for (int conta = 1; conta < (2 * fila); conta++)
                    Console.Write("*");


                Console.WriteLine(" ");

            }
        }
    }
}
