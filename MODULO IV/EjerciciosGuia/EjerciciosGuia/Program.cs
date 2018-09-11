using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjerciciosGuia
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string palabra;
             Queue miCola = new Queue();
             miCola.Enqueue("Hola");
             miCola.Enqueue("Hola2");
             miCola.Enqueue("Hola3");
             for (byte i=0; i < 3;i++)
             {
                 palabra = (string)miCola.Dequeue();
                 Console.WriteLine(palabra);
             }*/

            /* ArrayList miLista =  new ArrayList();

              miLista.Add("Hola,");
              miLista.Add("Soy");
              miLista.Add("Yo");

              Console.WriteLine("Contenido actual: ");
              foreach(string frase in miLista)
                  Console.WriteLine (frase);

              Console.WriteLine("La Segunda palabra es: {0}",  miLista[1]);

              miLista.Insert(1, "Como estas?");

              Console.WriteLine("Contenido tras insertar:");
              foreach (string frase in miLista)
                  Console.WriteLine(frase);

              Console.WriteLine("La palabra YO se encuentra en la posicion:");
                int index = miLista.IndexOf("Yo");
              Console.WriteLine("{0}", index);

              Console.WriteLine("Ordenado:");
              miLista.Sort();
              foreach (string frase in miLista)
                  Console.WriteLine(frase);*/

            Hashtable miDiccio = new Hashtable();
            miDiccio.Add("Byte", " 8 bits");
            miDiccio.Add("PC", " Personal Computer");
            miDiccio.Add("KiloByte", " 1024 bits");

            Console.WriteLine("Contenidos");
            IDictionaryEnumerator miEnumerador= miDiccio.GetEnumerator();
            while (miEnumerador.MoveNext())
                Console.WriteLine("{0}={1}", miEnumerador.Key, miEnumerador.Value);







        }
    }
}
