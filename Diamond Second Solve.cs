using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_Second_Solve
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int left = (n - 1) / 2;
            int right = n / 2;
            for (int row = 0; row < (n - 1) / 2; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col == left || col == right)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('-');
                    }
                }
                Console.WriteLine(); 
                left--;
                right++;
            }
            if (n > 1)
            {
                Console.Write("*");
                Console.Write(new string('-', n - 2));
                Console.Write('*');
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("*");
            }
            left = 1;
            right = n - 2;
            for (int row = 0; row < (n - 1) / 2; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col == left || col == right)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('-');
                    }
                }
                Console.WriteLine();
                left++;
                right--; 
            }
        }
    }
}
