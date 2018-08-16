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
            Console.WriteLine("----------------");
            Console.WriteLine("Tarea 05");
            Console.WriteLine("----------------");
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
            int opcion;

            do
            {
                Console.Write("--------------------\n");
                Console.Write("\n 1- Suma \n 2- Resta \n 3- Multiplicar\n 4- Dividir \n 5- Salir \n\tIngrese la opcion deseada : ");
               
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\n--- SUMA ---");
                        resultado = num1 + num2;
                        break;
                    case 2:
                        Console.WriteLine("\n--- RESTA ---");
                        resultado = num1 - num2;
                        break;
                    case 3:
                        Console.WriteLine("\n--- MULTIPLICACION ---");
                        resultado = num1 * num2;
                        break;
                    case 4:
                        Console.WriteLine("\n--- DIVISION ---");
                        if (num2 != 0)
                        {
                            resultado = ((float)num1 / (float)num2);
                        }
                        else
                        {
                            Console.Write("\n\n--------------------\n");
                            Console.Write("no se puede realizar la operacion");
                            Console.Write("--------------------\n");
                            flag = 1;
                        }
                        break;
                    case 5:
                        flag = 1;                       
                        break;
                }

                if (flag == 0)
                {
                    
                    Console.Write("El resultado es {0}\n", resultado);
                    
                }

            } while (opcion != 5);


        }


    }
}
