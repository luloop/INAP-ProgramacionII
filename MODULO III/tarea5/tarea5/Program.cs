using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Ingrese un Numero:\t");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese otro Numero:\t");
                int num2 = Convert.ToInt32(Console.ReadLine());
                if(num1%num2==0)
                {
                    Console.WriteLine("el numero {0} es multiplo de {1}", num1, num2);
                }
                else
                {
                    Console.WriteLine("el numero {0} NO es multiplo de {1}", num1, num2);
                }
               
                Console.WriteLine("----------------");
                
            } 



        }
    }
}
