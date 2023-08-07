using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meinersteCsharpprogramm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zahl1 = 0,
                zahl2 = 2,
                ergebnis = 0;

                if (zahl1 ==1)
            {
                ergebnis = zahl1;
                ergebnis += zahl2;
                zahl1 = zahl2;
                Console.WriteLine("Gruss aus dem Block");
            }
                else if
                (zahl2 ==2) {
                Console.WriteLine("Kein gros aus 1 dondern aus 2");
            }
            else
            {
                Console.WriteLine("Ausgabe erwunscht");
            }
            Console.WriteLine("Merhaba Süleymann");
        }
    }
}
