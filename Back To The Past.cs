using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double Inheritance = double.Parse(Console.ReadLine());
            var LiveYear = int.Parse(Console.ReadLine());
            double EvenMoney = 12000;
            var Ivan = 18;
            for (int i = 1800; i <= LiveYear; i++)
            {
                if (i % 2 == 0)
                {
                    Inheritance = Inheritance - EvenMoney;
                }
                if (i % 2 != 0)
                {
                    double OddMoney = (12000 + 50 * Ivan);
                    Inheritance = Inheritance - OddMoney;
                }
                Ivan++;
            }
            if (Inheritance >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", Inheritance);
            }
            if (Inheritance < 0)
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(Inheritance));
            }
        }
    }
}