using System;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1 + int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                var spaces = n - i;
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }

                var astrix = i - 1;
                for (int j = 0; j < astrix; j++)
                {
                    Console.Write("*");
                }

                Console.Write(" | ");

                for (int j = 0; j < astrix; j++)
                {
                    Console.Write("*");
                }

                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }

        }
    }
}
