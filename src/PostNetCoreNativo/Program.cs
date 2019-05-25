using System;
using System.Runtime.InteropServices;
using System.Text;

namespace NetCoreExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Obtenemos el sistema operativo sobre el que corre la aplicacion
            string OS = RuntimeInformation.OSDescription;
            int sumando1 = 123, sumando2 = 3245;
            Console.WriteLine($"Mensaje escrito en C# sobre {OS}");
            Console.WriteLine(NativeMethods.GetStringMessage());
            Console.WriteLine($"Suma desde codigo nativo '{sumando1} + {sumando2} = {NativeMethods.SumaNativo(sumando1, sumando2)}'");

            Console.Read();
        }
    }
}
