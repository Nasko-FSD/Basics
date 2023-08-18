using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class House
    {
        static void Main(string[] args)
        {
            Console.Write("On how many floors do you want to draw a house: ");
            var n = int.Parse(Console.ReadLine());
            var stars = 1;
            if (n % 2 == 0)
            {
                stars = 2;
            }
            for (int row = 0; row < (n + 1) / 2; row++)
            {
                var hyphens = (n - stars) / 2;
                Console.Write(new string('-', hyphens));
                Console.Write(new string('*', stars));
                Console.WriteLine(new string('-', hyphens));
                stars += + 2;
            }
            for (int row = 0; row < n / 2; row++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.WriteLine("|");
            }
            stars++;
            }
        }
    }