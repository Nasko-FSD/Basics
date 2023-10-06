using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Lilly
{
    class Program
    {
        static void Main(string[] args)
        {
                var Age = int.Parse(Console.ReadLine());
                double machine = double.Parse(Console.ReadLine());
                int ToysPrice = int.Parse(Console.ReadLine());
                int ToysCount = 0;
                double SavedMoney = 0;
                double moneybirthday = 9;
                for (int i = 1; i <= Age; i++)
                {
                    if (i % 2 == 0)
                    {
                        SavedMoney += moneybirthday;
                        moneybirthday += 10;
                    }
                    if (i % 2 != 0)
                    {
                        ToysCount++;
                    }
                }
                SavedMoney += (ToysCount * ToysPrice);
                if (SavedMoney >= machine)
                {
                    double LeftMoney = SavedMoney - machine;
                    Console.WriteLine("Yes! {0:f2}", LeftMoney);
                }
                if (machine > SavedMoney)
                {
                    double NeededMoney = Math.Abs(machine - SavedMoney);
                    Console.WriteLine("No! {0:f2}", NeededMoney);
                }
            }
        }
    }