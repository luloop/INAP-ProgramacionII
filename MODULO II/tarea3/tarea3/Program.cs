using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tarea3
{
    class Program
    {
        static void Main(string[] args)
        {
            string miDirectorio = @"c:\"; // asigna a una string el nombre del directorio
            string[] listaFicheros; // array de string para futuros archivos

            listaFicheros = Directory.GetFiles(miDirectorio); // obtiene lo archivos que hay en el directorio
            foreach (string fichero in listaFicheros) // por cada archivo, se lo copia en el array de string
            {
                Console.WriteLine(fichero); // muestra el nombre de cada archivo que figura
            }

        }
    }
}
