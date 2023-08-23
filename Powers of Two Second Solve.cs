var n = int.Parse(Console.ReadLine());
for (var num = 1; num <= Math.Pow(2, n); num*=2)
{
    Console.WriteLine(num);
}