using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EinfacheSchleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do-While-Schleifen
            int zahl = 1;

            do
            {
                Console.WriteLine(zahl);
                zahl += 1;
            }
            while (zahl <= 5);

            Console.ReadKey();
        }
    }
}
