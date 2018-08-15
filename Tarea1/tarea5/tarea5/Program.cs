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
            Console.Write("-- Ingrese el primer numero\t");
            int numero1= Convert.ToInt32(Console.ReadLine());
            Console.Write("-- ingrese el segundo numero\t");
            int numero2 = Convert.ToInt32(Console.ReadLine());            
            calcula(numero1, numero2);

        }

        static void calcula(int num1, int num2)
        {
            float resultado=0;
            int flag = 0;


            Console.Write("\n 1- Suma \n 2- Resta \n 3-Multiplicar\n 4-Dividir \n\tingrese la opcion deseada  ");
            int opcion= Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {

                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado =((float)num1 / (float)num2);
                    }
                    else
                    {
                        Console.Write("--------------------\n");
                        Console.Write("no se puede realizar la operacion");
                        Console.Write("--------------------\n");
                        flag = 1;
                    }
                    break;
            }


            if(flag==0)
            {
                Console.Write("--------------------\n");
                Console.Write("El resultado es {0}\n", resultado);
                Console.Write("--------------------\n");
            }


        }


    }
}
