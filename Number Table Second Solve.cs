var n = int.Parse(Console.ReadLine());
for (int row = 1; row <= n; row++)
{
    var num = row;
    for (int col = 1; col <= n; col++)
    {
        if (num > n)
        {
            Console.Write("{0} ", n * 2 - num);
        }
        else
        {
            Console.Write("{0} ", num);
        }
        num++;
    }
    Console.WriteLine();
}