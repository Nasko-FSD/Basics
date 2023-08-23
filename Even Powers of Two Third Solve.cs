var n = int.Parse(Console.ReadLine());
for (int i = 0; i <= n / 2; i++)
{
    Console.WriteLine(1 << (2 * i));
}