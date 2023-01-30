using System;
using System.Globalization;

class _1000DaysAfterBirth
{
    static void Main()
    {
        Console.Write("Enter Bithday date: ");
        Console.WriteLine(DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy",
            CultureInfo.InvariantCulture).AddDays(999).ToString("dd-MM-yyyy")); 
    }
}

