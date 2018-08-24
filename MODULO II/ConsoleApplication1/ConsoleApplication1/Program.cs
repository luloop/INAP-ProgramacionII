using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int posX = 41, posY = 10; // genera 2 variables para que sean usadas como posicion
            string simbolos = "^>0<"; // genera un simbolo, que luedo ser mostrado
            byte simboloActual = 0; // establece una variable para moverse dentro del vector de string anterior
            bool terminado = false; // varibable de control, para salir del programa
            do // entra en un loop hasta que se cumpla la condicion de while
            { 
                Console.Clear(); // limpia pantalla
                Console.SetCursorPosition(posX, posY); // establece posicion del cursor
                Console.Write(simbolos[simboloActual]); // escribe en pantalla 
              

                Thread.Sleep(500);// espera medio segundo
                if (Console.KeyAvailable) // si se escribe algo
                {
                    ConsoleKeyInfo tecla = Console.ReadKey(true); // lee lo que se escribe
                    if (tecla.Key == ConsoleKey.RightArrow) //si es boton de derecho
                    {
                      posX++; // Se mueve la posicion del cursor hacia el positivo, y la derrecha
                    }
                    if (tecla.Key == ConsoleKey.LeftArrow) // si es la flecha izquiera
                    {
                      posX--; // cambia decrece el numero de la posicion del cursor
                    }
                    if (tecla.Key == ConsoleKey.Escape) // si apreta escape
                    {
                        terminado = true;  // modifica la variable de control
                    }

                }
                simboloActual++; // muestra el siguiente simbolo del string
                if (simboloActual > 3) // si el incremento super la cantidad de elementos del string
                {
                    simboloActual = 0;  // vuelve a cero
                }

            } while (!terminado); // variable que se tiene que dar para que continue el loop
        }
    }
}
