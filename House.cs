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
            var underscore = n / 2;
            for (int row = 0; row < n; row++)
            {
                if (n % 2 != 0)
                {
                    if (row == 0)
                    {
                        Console.Write(new string('-', n / 2));
                        Console.Write('*');
                        Console.WriteLine(new string('-', n / 2));
                    }
                    if (row == 1)
                    {
                        Console.Write(new string('-', n / 2 - 1));
                        Console.Write(new string('*', row + 2));
                        Console.WriteLine(new string('-', n / 2 - 1));
                    }
                    if (row > 1 && row <= n / 2)
                    {
                        for (int i = 1; i <= underscore; i++)
                        {
                            Console.Write("-");
                        }
                        for (int i = 0; i < stars + row; i++)
                        {
                            Console.Write("*");
                        }
                        for (int i = 1; i <= underscore; i++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine();
                    }
                    if (row > n / 2 && row < n)
                    {
                        Console.Write("|");
                        Console.Write(new string('*', n - 2));
                        Console.WriteLine("|");
                    }
                }
                if (n % 2 == 0)
                {
                    if (row == 0)
                    {
                        Console.Write(new string('-', n / 2 - 1));
                        Console.Write("**");
                        Console.WriteLine(new string('-', n / 2 - 1));
                    }
                    if (row == 1)
                    {
                        Console.Write(new string('-', n / 2 - 2));
                        Console.Write(new string('*', row + 3));
                        Console.WriteLine(new string('-', n / 2 - 2));
                    }
                    if (row > 1 && row <= n / 2 - 1)
                    {
                        for (int i = 1; i <= underscore - 1; i++)
                        {
                            Console.Write("-");
                        }
                        for (int i = 0; i <= stars + row; i++)
                        {
                            Console.Write("*");
                        }
                        for (int i = 1; i <= underscore - 1; i++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine();
                    }
                    if (row >= n / 2 && row < n)
                    {
                        Console.Write("|");
                        Console.Write(new string('*', n - 2));
                        Console.WriteLine("|");
                    }
                }
                stars++;
                underscore--;
            }
        }
    }
}