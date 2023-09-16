Console.Write("Enter a number: ");
var a = int.Parse(Console.ReadLine());
Console.Write("Enter a number: ");
var b = int.Parse(Console.ReadLine());
if (b < a + 3)
{
    Console.WriteLine("No");
}
else
{
    for (int col = a; col <= b; col++)
    {
        for (int j = col + 1; j <= b; j++)
        {
            for (int k = j + 1; k <= b; k++)
            {
                for (int l = k + 1; l <= b; l++)
                {
                    Console.Write("{0} {1} {2} {3}", col, j, k, l);
                    Console.WriteLine();
                }
            }
        }
    }
}