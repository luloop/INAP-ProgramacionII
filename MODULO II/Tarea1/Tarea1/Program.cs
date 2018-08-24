using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            string avanceLinea = Environment.NewLine;
            Console.WriteLine("Directorio actual : {0}", Environment.CurrentDirectory);
            Console.WriteLine("Nombre de la maquina {0}", Environment.MachineName);
            Console.WriteLine("Nombre de Usuario {0}", Environment.UserName);
            Console.WriteLine("Dominio : {0}", Environment.UserDomainName);
            Console.WriteLine("Codigo de Salido del Programa Anterior {0}", Environment.ExitCode);
            Console.WriteLine("Linea de Comandos{0}", Environment.CommandLine);
            Console.WriteLine("Version SO : {0}", System.Convert.ToString( Environment.OSVersion));
            Console.WriteLine("Version del Net {0}", Environment.Version.ToString());
            string[] discos = Environment.GetLogicalDrives();
            Console.WriteLine("Unidades Logicas:{0}", String.Join(".", discos));
            Console.WriteLine("Carpeta de sistemas: {0}", Environment.GetFolderPath(Environment.SpecialFolder.System));
            ////////////////////////////////
            DateTime fecha = DateTime.Now;
            Console.WriteLine("//////////////////////////////////////////////////////////////////");
            Console.WriteLine("Hora {0}, Dia {1}, Mes {2}", fecha.Hour, fecha.Day, fecha.Month);
            DateTime tomorrow = fecha.AddDays(10);
            Console.WriteLine("Fecha  en 10 dias {0}", tomorrow.Date);
            ////////////////////////////////
            Console.WriteLine("//////////////////////////////////////////////////////////////////");
            TimeSpan diferencia = tomorrow.Subtract(fecha);
            Console.WriteLine("La diferencia entre las fechas es {0} dias", diferencia.TotalDays);
            Console.WriteLine("//////////////////////////////////////////////////////////////////");
            fecha = DateTime.Now;
            Console.WriteLine("Hora {0}, Minutos {1}, Segundo {2}", fecha.Hour, fecha.Minute, fecha.Second  );
            Thread.Sleep(5000);
            fecha = DateTime.Now;
            Console.WriteLine("Nueva Hora {0}, Minutos {1}, Segundo {2}", fecha.Hour, fecha.Minute, fecha.Second);
            Console.WriteLine("//////////////////////////////////////////////////////////////////");
            string myDirectory = @"E:\CURSOS\INAP-ProgramacionII\MODULO II\lolo";
            if (!Directory.Exists(myDirectory))
            {
                Directory.CreateDirectory(myDirectory);
            }
            else
            {
                Console.WriteLine("/////////////// El directorio ya existe ///////////////");
                Console.WriteLine("/////////////// Listado de Archivo ///////////////");
                string[] listafichero;
                listafichero = Directory.GetFiles(myDirectory);
                foreach (string fichero in listafichero)
                    Console.WriteLine(fichero);
            }




        }
    }
}
