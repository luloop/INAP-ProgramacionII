using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HolaVS
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num2;
            Console.Write("Ingrese un Numero\n \n");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n------------------------------\n");
            ////////////////////
            if (Signo(num) == 1)
            {
                Console.Write("Es Positivo\n");
                if (EsPrimo(num) == 1)
                    Console.Write("Es Primo \n");
                else if (EsPrimo(num) == 0)
                    Console.Write("No es Primo \n");
                else
                    Console.Write("Fallo \n");
                /////////////////  
            }           

            else if (Signo(num) == -1)
                Console.Write("Es Negativo \n");
            else
                Console.Write("Es Cero\n");
            /////////////////  
            Console.Write("------------------------------\n");
            Console.Write("Ingrese Otro Numero\n \n");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("------------------------------\n");
            if (Menor(num, num2)==1)
                Console.Write("{0} es Mayor que {1} \n", num, num2);
            else if (Menor(num, num2) == -1)
                Console.Write("{0} es Mayor que {1} \n", num2, num);
            else 
                Console.Write("{0} Son Iguales {1} \n", num, num2);

            Console.Write("------------------------------\n");



        }


        public static int Signo(int num)
        {           
            if (num > 0)
                return 1;
            if (num < 0)
                return -1;
            else
                return 0;
        }

        public static int Menor(int num1, int num2)
        {
            if (num1 > num2)
                return 1;
            if (num1 < num2)
                return -1;
            else
                return 0;
        }

        public static int EsPrimo(int num1)
        {
            int flag = 0;
            for (int i = 2; i < num1; i++)
            {
                if (i == 1)
                {
                    continue;
                }
                if (num1 % i == 0)
                {
                    flag = 1;//falso
                    break;
                }
            }

            if (flag == 0)
            {
                return 1; // verdadero
            }
            else
            {
                return 0;
            }  
           
        }


 


      
    } //no mover
}


