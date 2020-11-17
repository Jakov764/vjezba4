using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite cijenu bez PDV-a: ");
            double bPDV = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unesite cijenu sa PDV-om: ");
            double sPDV = Convert.ToDouble(Console.ReadLine());
            double PDV = ((sPDV / bPDV) - 1) * 100;
            Console.WriteLine("PDV izađe: " + PDV + "%");
            Console.ReadKey();

        }
    }
}
