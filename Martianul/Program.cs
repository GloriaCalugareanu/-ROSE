using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martianul
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, n;

            string line;

            line = Console.ReadLine();
            string[] numere = line.Split(' ');
            x = int.Parse(numere[0]);
            y = int.Parse(numere[1]);
            n = int.Parse(numere[1]);

            int a, h, z;
            a = n / (x * y);
            z = (n - a * (x * y) / y);
            h = n - a * (x * y) - z * y;
            Console.WriteLine(a);
            Console.WriteLine(z);
            Console.WriteLine(h);
        }
    }
}
