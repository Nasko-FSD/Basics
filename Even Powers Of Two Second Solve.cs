var n = int.Parse(Console.ReadLine());
var num = 1;
for (int i = 0; i <= n / 2; i++)
{
    Console.WriteLine(num);
    num = num * 4;
}