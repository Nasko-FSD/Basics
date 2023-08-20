var n = int.Parse(Console.ReadLine());
var width = 2 * n;
var lowercase = n / 2;
for (int row = 0; row < 1; row++)
{
        Console.Write("/");
    Console.Write(new string('^', n / 2));
    Console.Write("\\");
    if (n >= 5)
    {
        Console.Write(new string('_', width - ((2 * lowercase) + 4)));
    }
    Console.Write("/");
    Console.Write(new string('^', n / 2));
    Console.WriteLine("\\");
    for (int mid = 1; mid <= n - 2; mid++)
    {
        Console.Write("|");
        if (mid >= 1 && mid < n - 2)
        {
            if (n % 2 != 0 && n >= 5)
            {
                Console.Write(new string(' ', width - 2));
            }
            if (n % 2 != 0 && n < 5)
            {
                Console.Write(new string(' ', (n + 1)));
            }
            else if (n % 2 == 0 && n >= 5)
            {
                Console.Write(new string(' ', width - 2));
            }
            else if (n % 2 == 0 && n < 5)
            {
                Console.Write(new string(' ', (n + 2)));
            }
        }
        else if (mid == n - 2 && n < 5)
        {
            if (n % 2 != 0 && n < 5)
            {
                Console.Write(new string(' ', (n + 1)));
            }
            else if (n % 2 == 0 && n < 5)
            {
                Console.Write(new string(' ', (n + 2)));
            }        
        }
            if(mid == n - 2 && n >= 5)
        {
                if (n % 2 != 0 && n >= 5)
                {
                    Console.Write(new string(' ', ((n + 1) / 2)));
                }
                else if (n % 2 == 0 && n >= 5)
                {
                    Console.Write(new string(' ', ((n + 2) / 2)));
                }
            Console.Write(new string('_', width - ((2 * lowercase) + 4)));
            if (n % 2 != 0 && n >= 5)
            {
                Console.Write(new string(' ', ((n + 1) / 2)));
            }
            else if (n % 2 == 0 && n >= 5)
            {
                Console.Write(new string(' ', ((n + 2) / 2)));
            }
        }
        Console.WriteLine("|");
    }
    Console.Write("\\", n / n);
    Console.Write(new string('_', n / 2));
    Console.Write("/");
    if (n >= 5)
    {
        Console.Write(new string(' ', width - ((2 * lowercase) + 4)));
    }
    Console.Write("\\", n / n);
    Console.Write(new string('_', n / 2));
    Console.WriteLine("/");
}