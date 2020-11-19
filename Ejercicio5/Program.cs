using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static int counter = 0;
        public static void increment()
        {
            counter++;
            Console.WriteLine(counter);
        }

        static void Main(string[] args)
        {
            MyTimer t = new MyTimer(increment);
            t.intervalo = 1000; // Una función se ejecuta cada 1s

            string opcion = "";

            do
            {
                Console.WriteLine("Press any key to start.");
                Console.ReadKey();
                t.run();

                Console.WriteLine("Press any key to pause.");
                Console.ReadKey();
                t.pause();

                Console.WriteLine("Press 1 to restart or Enter to end.");
                opcion = Console.ReadLine();
            } while (opcion == "1");
        }
    }
}
